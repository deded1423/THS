using System.Collections.Concurrent;
using System.IO;
using System.Net.Sockets;
using System.Threading;
using THS.HSApp;
using THS.Input;
using THS.Utils;

//TODO: Hay que pasar todo lo de twitch a lower case para que el regex no se lie
namespace THS.Twitch_Integration
{
    public class IrcClient
    {

        private string userName;
        private string _channel;
        private bool _stop = false;
        public string ip;
        public int port;

        private TcpClient tcpClient;
        private StreamReader inputStream;
        private StreamWriter outputStream;

        System.Timers.Timer timerActionsCD = new System.Timers.Timer();
        bool actionsCD = false;

        public ConcurrentQueue<CommandChat> Queue = new ConcurrentQueue<CommandChat>();


        public IrcClient()
        {
            timerActionsCD.AutoReset = false;
            timerActionsCD.Interval = 5000;
            timerActionsCD.Elapsed += (s, e) =>
            {
                actionsCD = false;
            };
        }

        //IRC Methds
        public void StartConnection(string _ip, int _port, string name, string auth)
        {
            userName = name;
            ip = _ip;
            port = _port;
            tcpClient = new TcpClient(ip, port);
            inputStream = new StreamReader(tcpClient.GetStream());
            outputStream = new StreamWriter(tcpClient.GetStream());

            outputStream.WriteLine("PASS " + auth);
            outputStream.WriteLine("NICK " + userName);
            outputStream.WriteLine("USER " + userName + " 8 * :" + userName);
            outputStream.Flush();
        }
        public void StartTwitchChat(object channel)
        {
            if (channel is string)
            {
                this._channel = (string)channel;
                JoinRoom((string)channel);
                while (!_stop)
                {

                    string msg = ReadMessage();
                    if (msg != null)
                    {
                        //Commands
                        if (ConfigFile.TwitchCommands != null && ConfigFile.TwitchCommands.ContainsKey(msg))
                        {
                            SendChatMessage(ConfigFile.TwitchCommands[msg]);
                            continue;
                        }
                        if (msg.Equals("!actions") && THS.Windows.THS.GameCore != null && !actionsCD)
                        {
                            int chars = 0;
                            string send = "";
                            foreach (var item in THS.Windows.THS.GameCore.Game.GetActions())
                            {
                                chars = chars + item.Length + 3;
                                if (chars > 500)
                                {
                                    chars = item.Length;
                                    SendChatMessage(send);
                                    send = item;
                                }
                                send = send + " / " + item;
                            }
                            SendChatMessage(send);
                            timerActionsCD.Enabled = true;
                            actionsCD = true;
                            continue;
                        }
                        if (msg.Contains("tmi.twitch.tv"))
                        {
                            IO.LogDebug(msg, IO.DebugFile.Twitch);
                            continue;
                        }
                        var cmd = new CommandChat(msg);
                        if (cmd.Type != PlayType.Incorrect)
                        {
                            Queue.Enqueue(cmd);
                            IO.LogDebug(cmd.ToString(), IO.DebugFile.Twitch, false);
                        }
                        else
                        {
                            IO.LogDebug(msg, IO.DebugFile.Twitch);
                        }
                    }
                }
            }
        }
        public void JoinRoom(string channel)
        {
            Thread.Sleep(500);
            outputStream.WriteLine("JOIN #" + channel);
            outputStream.Flush();
        }
        private void SendIrcMessage(string message)
        {
            outputStream.WriteLine(message);
            outputStream.Flush();
        }
        public void SendChatMessage(string message)
        {
            if (ip == null)
            {
                IO.LogDebug(message, IO.DebugFile.Output, false);
            }
            else
            {
                SendIrcMessage(":" + userName + "!" + userName + "@" + userName + ".tmi.twitch.tv PRIVMSG #" + _channel + " :" + message);
            }
        }
        public string ReadMessage()
        {
            string message = null;
            if (!inputStream.EndOfStream)
            {
                message = inputStream.ReadLine();
            }
            if (message == null)
            {
                return "";
            }
            if (message.StartsWith("PING"))
            {
                var ip = message.Substring(4);
                SendIrcMessage("PONG" + ip);
                IO.LogDebug(message, IO.DebugFile.Twitch, false);
                return message;
            }
            if (message?.Contains("PRIVMSG") == true)
            {
                string[] msg = message.Split(':');
                return msg[2];
            }
            return message;
        }
        public void Stop()
        {
            _stop = true;
        }
        public void StartIRCProcessing()
        {
            var GameCore = THS.Windows.THS.GameCore;
            CommandChat cmd;
            while (!_stop)
            {
                while (Queue.IsEmpty || GameCore == null || GameCore.Game == null)
                {
                    Thread.Sleep(100);
                }
                Queue.TryDequeue(out cmd);
                if (!GameCore.Running || !GameCore.Game.User.IsPlaying)
                {
                    if (cmd.Type.Equals(PlayType.Queue))
                    {
                        MouseMovement.Requeue(int.Parse(cmd.Other));
                        while (!GameCore.Running)
                        {
                            Thread.Sleep(200);
                        }
                    }
                    continue;
                }
                HSApp.HSCard name, target;
                switch (cmd.Type)
                {
                    case PlayType.Play:
                        if (GameCore.Game.User.GetHandCard(cmd.Name, cmd.NamePos) == null)
                        {
                            IO.LogDebug("FAIL " + cmd.ToString(), IO.DebugFile.Input);
                            continue;
                        }
                        if (cmd.Target == null)
                        {
                            MouseMovement.PlayCard(GameCore.Game.User.Hand.Count, GameCore.Game.User.GetHandCard(cmd.Name, cmd.NamePos).ZonePos - 1);
                        }
                        else
                        {
                            name = GameCore.Game.User.GetHandCard(cmd.Name, cmd.NamePos);
                            var _namepos = name.ZonePos - 1;

                            if (cmd.TargetUser.Equals('e') || cmd.TargetUser.Equals('\0'))
                            {
                                if ((target = GameCore.Game.Opponent.GetPlayCard(cmd.Target, cmd.NamePos)) != null)
                                {
                                    MouseMovement.PlayCardOn(GameCore.Game.User.Hand.Count, _namepos, true, GameCore.Game.GetOpponentMinions().Count, target.ZonePos - 1);
                                }
                                else if (GameCore.Game.Opponent.EqualsHeroName(cmd.Target))
                                {
                                    MouseMovement.PlayCardOn(0, 0, true, 0, 0, true);
                                }
                            }
                            else if (cmd.TargetUser.Equals('m') || cmd.TargetUser.Equals('\0'))
                            {
                                if ((target = GameCore.Game.User.GetPlayCard(cmd.Target, cmd.NamePos)) != null)
                                {
                                    MouseMovement.PlayCardOn(GameCore.Game.User.Hand.Count, _namepos, false, GameCore.Game.GetUserMinions().Count, target.ZonePos - 1);
                                }
                                else if (GameCore.Game.User.EqualsHeroName(cmd.Target))
                                {
                                    MouseMovement.PlayCardOn(0, 0, false, 0, 0, true);
                                }
                            }
                        }
                        break;
                    case PlayType.HeroPower:
                        if (GameCore.Game.User.Mana >= 2 && !GameCore.Game.User.HeroPower.Exhausted)
                        {
                            if (cmd.Target == null)
                            {
                                MouseMovement.HeroPower();
                            }
                            else
                            {
                                if (cmd.TargetUser.Equals('e') || cmd.TargetUser.Equals('\0'))
                                {
                                    if ((target = GameCore.Game.Opponent.GetPlayCard(cmd.Target, cmd.TargetPos)) != null)
                                    {
                                        MouseMovement.HeroPower(GameCore.Game.GetOpponentMinions().Count, target.ZonePos - 1, true);
                                    }
                                    else if (GameCore.Game.Opponent.EqualsHeroName(cmd.Target))
                                    {
                                        MouseMovement.HeroPower(true);
                                    }
                                }
                                else if (cmd.TargetUser.Equals('m') || cmd.TargetUser.Equals('\0'))
                                {
                                    if ((target = GameCore.Game.User.GetPlayCard(cmd.Target, cmd.TargetPos)) != null)
                                    {
                                        MouseMovement.HeroPower(GameCore.Game.GetUserMinions().Count, target.ZonePos - 1, false);
                                    }
                                    else if (GameCore.Game.User.EqualsHeroName(cmd.Target))
                                    {
                                        MouseMovement.HeroPower(false);
                                    }

                                }
                            }
                        }
                        break;
                    case PlayType.Attack:
                        if (GameCore.Game.User.GetPlayCard(cmd.Name, cmd.NamePos) == null && !GameCore.Game.User.EqualsHeroName(cmd.Name))
                        {
                            IO.LogDebug("FAIL " + cmd.ToString(), IO.DebugFile.Input);
                            continue;
                        }
                        if (GameCore.Game.Opponent.GetPlayCard(cmd.Target, cmd.NamePos) == null && !GameCore.Game.Opponent.EqualsHeroName(cmd.Target))
                        {
                            IO.LogDebug("FAIL " + cmd.ToString(), IO.DebugFile.Input);
                            continue;
                        }
                        if ((name = GameCore.Game.User.GetPlayCard(cmd.Name, cmd.NamePos)) != null)
                        {
                            if ((target = GameCore.Game.Opponent.GetPlayCard(cmd.Target, cmd.NamePos)) != null)
                            {
                                MouseMovement.AttackCard(GameCore.Game.GetUserMinions().Count, name.ZonePos - 1, GameCore.Game.GetOpponentMinions().Count, target.ZonePos - 1);
                            }
                            else if (GameCore.Game.Opponent.EqualsHeroName(cmd.Target))
                            {
                                MouseMovement.AttackCard(GameCore.Game.GetUserMinions().Count, name.ZonePos - 1, 0, 0, true);
                            }
                        }
                        else if ((name = GameCore.Game.User.Hero).Name.ToLower().Equals(cmd.Name) || GameCore.Game.User.EqualsHeroName(cmd.Name))
                        {
                            if ((target = GameCore.Game.Opponent.GetPlayCard(cmd.Target, cmd.NamePos)) != null)
                            {
                                MouseMovement.AttackHero(GameCore.Game.GetOpponentMinions().Count, target.ZonePos - 1);
                            }
                            else if (GameCore.Game.Opponent.EqualsHeroName(cmd.Target))
                            {
                                MouseMovement.AttackHero(0, 0, true);
                            }
                        }
                        break;
                    case PlayType.Incorrect:
                        IO.LogDebug(cmd.ToString());
                        break;
                    case PlayType.Mulligan:
                        char[] mull = cmd.Other.ToCharArray();
                        if (mull.Length == 3)
                        {
                            MouseMovement.Mulligan(mull[0].Equals('0') ? 0 : 1, mull[1].Equals('0') ? 0 : 1, mull[2].Equals('0') ? 0 : 1);
                        }
                        else
                        {
                            MouseMovement.MulliganCoin(mull[0].Equals('0') ? 0 : 1, mull[1].Equals('0') ? 0 : 1, mull[2].Equals('0') ? 0 : 1, mull[3].Equals('0') ? 0 : 1);
                        }
                        break;
                    case PlayType.Discover:
                        MouseMovement.Discover(int.Parse(cmd.Other));
                        break;
                    case PlayType.Choose:
                        MouseMovement.ChooseOne(int.Parse(cmd.Other));
                        break;
                    case PlayType.Queue:
                        break;
                    case PlayType.Emote:
                        if (cmd.Other.Equals("greetings"))
                        {
                            MouseMovement.Emote(HSPoints.EmoteGreetings);
                        }
                        else if (cmd.Other.Equals("wellplayed"))
                        {
                            MouseMovement.Emote(HSPoints.EmoteWellPlayed);
                        }
                        else if (cmd.Other.Equals("thanks"))
                        {
                            MouseMovement.Emote(HSPoints.EmoteThanks);
                        }
                        else if (cmd.Other.Equals("wow"))
                        {
                            MouseMovement.Emote(HSPoints.EmoteWow);
                        }
                        else if (cmd.Other.Equals("oops"))
                        {
                            MouseMovement.Emote(HSPoints.EmoteOops);
                        }
                        else if (cmd.Other.Equals("threaten"))
                        {
                            MouseMovement.Emote(HSPoints.EmoteThreaten);
                        }

                        break;
                    case PlayType.Concede:
                        MouseMovement.Concede();
                        break;
                    case PlayType.EndTurn:
                        MouseMovement.EndTurn();
                        break;
                    case PlayType.SeeDeck:
                        MouseMovement.SeeDeck();
                        break;
                    case PlayType.Other:
                        break;
                    default:
                        break;
                }
            }
        }
    }
}