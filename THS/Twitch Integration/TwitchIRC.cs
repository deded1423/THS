using System.Collections.Concurrent;
using System.Collections.Generic;
using System.IO;
using System.Net.Sockets;
using System.Threading;
using THS.Utils;

//TODO: Hay que pasar todo lo de twitch a lower case para que el regex no se lie
namespace THS.Twitch_Integration
{
    class IrcClient
    {

        private string userName;
        private string _channel;
        private bool _stop = false;

        private TcpClient tcpClient;
        private StreamReader inputStream;
        private StreamWriter outputStream;

        private ConcurrentQueue<CommandChat> _queue = new ConcurrentQueue<CommandChat>();

        public IrcClient(string ip, int port, string userName, string password)
        {
            this.userName = userName;

            tcpClient = new TcpClient(ip, port);
            inputStream = new StreamReader(tcpClient.GetStream());
            outputStream = new StreamWriter(tcpClient.GetStream());

            outputStream.WriteLine("PASS " + password);
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
                        if (msg.Equals("!help"))
                        {
                            //SendChatMessage(@"Play <handSize> <handNumber> // Play <handSize> <handNumber> <enemy>[ef] <boardSize> <boardNumber> // Play <handSize> <handNumber> <enemy>[ef] Hero");
                            SendChatMessage(@"Play <handSize> <handNumber>");
                            SendChatMessage(@"Play <handSize> <handNumber> <enemy>[e-f] <boardSize> <boardNumber>");
                            SendChatMessage(@"Play <handSize> <handNumber> <enemy>[e-f] Hero");
                            //SendChatMessage(@"Mulligan <first> <second> <third> {<fourth> c} // Attack <boardSize> <boardNumber> <boardEnemySize> <boardEnemyNumber> // Attack <boardSize> <boardNumber> Hero");
                            SendChatMessage(@"Mulligan <first>[0-1] <second>[0-1] <third>[0-1] {<fourth>[0-1] c}");
                            SendChatMessage(@"Attack <boardSize> <boardNumber> <boardEnemySize> <boardEnemyNumber>");
                            SendChatMessage(@"Attack <boardSize> <boardNumber> Hero");
                            SendChatMessage(@"Attack Hero <boardEnemySize> <boardEnemyNumber>");
                            SendChatMessage(@"Attack Hero Hero");
                            SendChatMessage(@"Attack <boardSize> <boardNumber> Hero");
                            SendChatMessage(@"Choose <card>");
                            SendChatMessage(@"Discover <card>");
                            SendChatMessage(@"End");
                            SendChatMessage(@"Power");
                            SendChatMessage(@"Power <enemy>[e-f] Hero");
                            SendChatMessage(@"Power <enemy>[e-f] <boardSize> <boardNumber>");
                        }
                        msg = msg.ToLower();
                        if (msg.Contains("tmi.twitch.tv"))
                        {
                            IO.LogDebug(msg, IO.DebugFile.Twitch);
                            continue;
                        }
                        var cmd = new CommandChat(msg);
                        if (cmd.Type != PlayType.Incorrect)
                        {
                            _queue.Enqueue(cmd);
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
            SendIrcMessage(":" + userName + "!" + userName + "@" + userName + ".tmi.twitch.tv PRIVMSG #" + _channel +
                           " :" + message);
        }

        public string ReadMessage()
        {
            string message = null;
            if (!inputStream.EndOfStream)
            {
                message = inputStream.ReadLine();
            }
            if (message == "PING :tmi.twitch.tv")
            {
                //foreach (var irc in Program.irc)
                //{
                //    irc.SendIrcMessage("PONG :tmi.twitch.tv");
                //}
                SendIrcMessage("PONG :tmi.twitch.tv");
                IO.LogDebug(message, IO.DebugFile.Twitch, false);
                return "PING :tmi.twitch.tv";
            }
            if (message?.Contains("PRIVMSG") == true)
            {
                string[] msg = message.Split(':');
                return msg[2];
            }
            return message;
        }

        public List<CommandChat> GetCommandChats()
        {
            List<CommandChat> list = new List<CommandChat>();
            foreach (var commandChat in _queue)
            {
                list.Add(commandChat);
            }
            return list;
        }

        public void Stop()
        {
            _stop = true;
        }
    }
}