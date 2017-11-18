using System;
using System.Collections.Generic;
using System.Threading;
using System.Windows.Forms;
using THS.Twitch_Integration;
using THS.Utils;
using THS.Input;
using System.Net.Sockets;
using System.Net;
using System.IO;
using HearthMirror;
using System.Diagnostics;
using System.Windows.Input;

namespace THS.Windows
{

    public partial class THS : Form
    {
        //TODO: Cambiar todo esto para que este en otra clase??
        //TODO: Mirar que el programa cierra bien (Procesos y Files)
        //TODO: Cerrar bien el programa
        //TWITCH SHIT
        Queue<string> chat = new Queue<string>();
        static IrcClient irc;
        Thread _ircThread, ircprocessThread, manageThread;
        List<CommandChat> list = new List<CommandChat>();

        //UI SHIT
        private Config _configwindow;

        //IMPORT SHIT
        private HSApp.HSCore GameCore;

        public THS()
        {
            InitializeComponent();
            IO.OpenDebugFiles();
            ConfigFile.readConfigFile();
            irc = new IrcClient();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //var decks = Reflection.GetDecks();
            SetupTestButtons();

            manageThread = new Thread(() =>
            {
                while (true)
                {
                    var num0 = Methods.GetKeyState(0x60);
                    var num2 = Methods.GetKeyState(0x62);
                    var num5 = Methods.GetKeyState(0x65);
                    var num8 = Methods.GetKeyState(0x68);
                    int index = 0;

                    if (num0 < 0)
                    {
                        listViewActions.Invoke(new Action(() =>
                        {
                            if (listViewActions.SelectedItems.Count == 1)
                            {
                                //irc.SendChatMessage(listViewActions.SelectedItems[0].Text);&& irc != null
                                var cmd = new CommandChat(listViewActions.SelectedItems[0].Text.ToLower());

                                if (cmd.Type != PlayType.Incorrect)
                                {
                                    if (irc == null) return;
                                    irc.Queue.Enqueue(cmd);
                                    IO.LogDebug(cmd.ToString(), IO.DebugFile.Twitch, false);
                                }
                                else
                                {
                                    IO.LogDebug(listViewActions.SelectedItems[0].Text.ToLower(), IO.DebugFile.Twitch);
                                }
                            }
                        }));
                    }
                    if (num2 < 0)
                    {
                        listViewActions.Invoke(new Action(() =>
                        {
                            if (listViewActions.SelectedItems.Count == 1 && listViewActions.Items.Count >= 2 && listViewActions.SelectedItems[0].Index < listViewActions.Items.Count - 1)
                            {
                                index = listViewActions.SelectedItems[0].Index;
                                listViewActions.SelectedItems[0].Selected = false;
                                listViewActions.Items[index + 1].Selected = true;
                            }
                        }));
                    }
                    if (num5 < 0)
                    {
                        buttonActions_Click(null, null);
                        listViewActions.Invoke(new Action(() =>
                        {
                            if (listViewActions.Items.Count >= 1)
                            {
                                listViewActions.Items[0].Selected = true;
                            }
                        }));
                    }
                    if (num8 < 0)
                    {
                        listViewActions.Invoke(new Action(() =>
                        {
                            if (listViewActions.SelectedItems.Count == 1 && listViewActions.Items.Count >= 2 && listViewActions.SelectedItems[0].Index >= 1)
                            {
                                index = listViewActions.SelectedItems[0].Index;
                                listViewActions.SelectedItems[0].Selected = false;
                                listViewActions.Items[index - 1].Selected = true;
                            }
                        }));
                    }
                    Thread.Sleep(100);
                }
            })
            { Name = "Input" };
            manageThread.Start();
        }

        private void ButtonConfig_Click(object sender, EventArgs e)
        {
            _configwindow = new Config();
            _configwindow.Show();

            //TcpListener listener = new TcpListener(IPAddress.Parse("192.168.1.241"), 8888);
            //listener.Start();
            //Socket a = listener.AcceptSocket();
        }

        private void ButtonStart_Click(object sender, EventArgs e)
        {
            if (ButtonStart.Text.Equals("Start"))
            {
                if (Process.GetProcessesByName("Hearthstone").Length != 0 || checkBoxHs.Checked)
                {
                    GameCore = new HSApp.HSCore(irc, this);
                    GameCore.Start();
                    ButtonStart.Text = "Stop";
                    Text = "THS";
                    if (DateTime.Compare(File.GetLastWriteTime(Path.Combine(ConfigFile.HearthstonePath, "Logs", "LoadingScreen.log")), File.GetLastWriteTime(Path.Combine(ConfigFile.HearthstonePath, "Logs", "Power.log"))) > 0)
                    {
                        IO.LogDebug("Delete Power.log");
                        if (!checkBoxDeletePower.Checked)
                        {
                            File.Delete(Path.Combine(ConfigFile.HearthstonePath, "Logs", "Power.log"));
                        }
                    }
                }
                else
                {
                    Text = "THS - No Hearthstone";
                }
            }
            else
            {
                GameCore.Stop();
                ButtonStart.Text = "Start";
            }
        }

        private void buttonStartTCP_Click(object sender, EventArgs e)
        {

            if (buttonStartTCP.Text.Equals("Start Tcp"))
            {
                StartIRC();
                buttonStartTCP.Text = "Stop Tcp";

            }
            else
            {
                buttonStartTCP.Text = "Start Tcp";
            }
        }

        private void THS_FormClosed(object sender, FormClosedEventArgs e)
        {
            IO.CloseDebugFiles();
            if (Directory.Exists(Path.Combine(@"C: \Users\USER\Documents\Visual Studio 2015\Projects\THS\HearthDb", "hsdata")))
            {
                Directory.Delete(Path.Combine(@"C: \Users\USER\Documents\Visual Studio 2015\Projects\THS\HearthDb", "hsdata"));
            }
            //irc.Stop();
        }

        private void StartIRC()
        {
            if (checkBoxTCP.Checked)
            {
                irc.StartConnection("irc.freenode.net", 6667, "THStone1", "none");
                _ircThread = new Thread(irc.StartTwitchChat) { Name = "TwitchChatReader" };
                _ircThread.Start("THS");
            }
            else
            {
                irc.StartConnection("irc.twitch.tv", 6667, ConfigFile.TwitchLoginName, ConfigFile.TwitchLoginOauth);
                _ircThread = new Thread(irc.StartTwitchChat) { Name = "TwitchChatReader" };
                _ircThread.Start("deded1423");
            }
            ircprocessThread = new Thread(StartIRCProcessing) { Name = "TwitchChatProcesser" };
            ircprocessThread.Start();
        }

        private void buttonTest_Click(object sender, EventArgs e)
        {
            if (((Button)sender).Equals(buttonTest1))
            {
                Methods.Point mouse = Methods.GetMouseInfoFromWindow("Hearthstone");
                Console.WriteLine(mouse.X + "," + mouse.Y);
            }
            else if (((Button)sender).Equals(buttonTest2))
            {
                GameCore.Game.Debug();
            }
            else if (((Button)sender).Equals(buttonTest3))
            {

            }
            else if (((Button)sender).Equals(buttonTest4))
            {

            }
            else if (((Button)sender).Equals(buttonTest5))
            {

            }
            else if (((Button)sender).Equals(buttonTest6))
            {

            }
            else if (((Button)sender).Equals(buttonTest7))
            {

            }
            else if (((Button)sender).Equals(buttonTest8))
            {

            }
        }

        private void SetupTestButtons()
        {
            buttonTest1.Text = "Mouse";
            buttonTest2.Text = "Debug";
            buttonTest3.Text = "";
            buttonTest4.Text = "";
            buttonTest5.Text = "";
            buttonTest6.Text = "";
            buttonTest7.Text = "";
            buttonTest8.Text = "";
        }


        public void UpdateUI()
        {
            listViewUserHand.Invoke(new Action(() =>
            {
                listViewUserHand.BeginUpdate();
                listViewUserHand.Items.Clear();
                foreach (var card in GameCore.Game.User.Hand)
                {
                    string[] arr = new string[6];
                    arr[0] = card.Id.ToString();
                    arr[1] = card.CardDB?.Name;
                    arr[2] = card.CardType.ToString();
                    arr[3] = card.TrueHealth.ToString();
                    arr[4] = card.Attack.ToString();
                    arr[5] = card.ManaCost.ToString();
                    listViewUserHand.Items.Add(new ListViewItem(arr));
                }
                listViewUserHand.EndUpdate();
            }));

            listViewOpponentHand.Invoke(new Action(() =>
            {
                listViewOpponentHand.BeginUpdate();
                listViewOpponentHand.Items.Clear();
                foreach (var card in GameCore.Game.Opponent.Hand)
                {
                    string[] arr = new string[6];
                    arr[0] = card.Id.ToString();
                    arr[1] = card.CardDB?.Name;
                    arr[2] = card.CardType.ToString();
                    arr[3] = card.TrueHealth.ToString();
                    arr[4] = card.Attack.ToString();
                    arr[5] = card.ManaCost.ToString();
                    listViewOpponentHand.Items.Add(new ListViewItem(arr));
                }
                listViewOpponentHand.EndUpdate();
            }));

            listViewUserBoard.Invoke(new Action(() =>
            {
                listViewUserBoard.BeginUpdate();
                listViewUserBoard.Items.Clear();
                foreach (var card in GameCore.Game.User.Play)
                {
                    string[] arr = new string[6];
                    arr[0] = card.Id.ToString();
                    arr[1] = card.CardDB?.Name;
                    arr[2] = card.CardType.ToString();
                    arr[3] = card.TrueHealth.ToString();
                    arr[4] = card.Attack.ToString();
                    arr[5] = card.ManaCost.ToString();
                    listViewUserBoard.Items.Add(new ListViewItem(arr));
                }
                listViewUserBoard.EndUpdate();
            }));

            listViewOpponentBoard.Invoke(new Action(() =>
            {
                listViewOpponentBoard.BeginUpdate();
                listViewOpponentBoard.Items.Clear();
                foreach (var card in GameCore.Game.Opponent.Play)
                {
                    string[] arr = new string[6];
                    arr[0] = card.Id.ToString();
                    arr[1] = card.CardDB?.Name;
                    arr[2] = card.CardType.ToString();
                    arr[3] = card.TrueHealth.ToString();
                    arr[4] = card.Attack.ToString();
                    arr[5] = card.ManaCost.ToString();
                    listViewOpponentBoard.Items.Add(new ListViewItem(arr));
                }
                listViewOpponentBoard.EndUpdate();
            }));

            listViewUserGraveyard.Invoke(new Action(() =>
            {
                listViewUserGraveyard.BeginUpdate();
                listViewUserGraveyard.Items.Clear();
                foreach (var card in GameCore.Game.User.Graveyard)
                {
                    string[] arr = new string[6];
                    arr[0] = card.Id.ToString();
                    arr[1] = card.CardDB?.Name;
                    arr[2] = card.CardType.ToString();
                    arr[3] = card.TrueHealth.ToString();
                    arr[4] = card.Attack.ToString();
                    arr[5] = card.ManaCost.ToString();
                    listViewUserGraveyard.Items.Add(new ListViewItem(arr));
                }
                listViewUserGraveyard.EndUpdate();
            }));

            listViewOpponentGraveyard.Invoke(new Action(() =>
            {
                listViewOpponentGraveyard.BeginUpdate();
                listViewOpponentGraveyard.Items.Clear();
                foreach (var card in GameCore.Game.Opponent.Graveyard)
                {
                    string[] arr = new string[6];
                    arr[0] = card.Id.ToString();
                    arr[1] = card.CardDB?.Name;
                    arr[2] = card.CardType.ToString();
                    arr[3] = card.TrueHealth.ToString();
                    arr[4] = card.Attack.ToString();
                    arr[5] = card.ManaCost.ToString();
                    listViewOpponentGraveyard.Items.Add(new ListViewItem(arr));
                }
                listViewOpponentGraveyard.EndUpdate();
            }));
        }

        private void buttonActions_Click(object sender, EventArgs e)
        {
            listViewActions.Invoke(new Action(() =>
            {
                listViewActions.BeginUpdate();
                listViewActions.Items.Clear();
                if (GameCore == null)
                {
                    listViewActions.EndUpdate();
                    return;
                }
                foreach (var action in GameCore.Game.GetActions())
                {
                    var a = new string[1];
                    a[0] = action;
                    listViewActions.Items.Add(new ListViewItem(a));
                }
                listViewActions.EndUpdate();
            }));
        }

        public void StartIRCProcessing()
        {
            CommandChat cmd;
            while (true)
            {
                while (irc.Queue.IsEmpty || GameCore == null || GameCore.Game == null)
                {
                    Thread.Sleep(100);
                }
                irc.Queue.TryDequeue(out cmd);
                HSApp.HSCard name, target;
                switch (cmd.Type)
                {
                    case PlayType.Play:
                        if (GameCore.Game.User.GetHandCard(cmd.Name) == null)
                        {
                            IO.LogDebug("FAIL " + cmd.ToString(), IO.DebugFile.Input);
                            continue;
                        }
                        if (cmd.Target == null)
                        {
                            MouseMovement.PlayCard(GameCore.Game.User.Hand.Count, GameCore.Game.User.GetHandCard(cmd.Name).ZonePos - 1);
                        }
                        else
                        {
                            name = GameCore.Game.User.GetHandCard(cmd.Name);
                            var _namepos = name.ZonePos - 1;
                            if ((target = GameCore.Game.User.GetPlayCard(cmd.Target)) != null)
                            {
                                MouseMovement.PlayCardOn(GameCore.Game.User.Hand.Count, _namepos, false, GameCore.Game.GetUserMinions().Count, target.ZonePos - 1);
                            }
                            else if ((target = GameCore.Game.Opponent.GetPlayCard(cmd.Target)) != null)
                            {
                                MouseMovement.PlayCardOn(GameCore.Game.Opponent.Hand.Count, _namepos, true, GameCore.Game.GetOpponentMinions().Count, target.ZonePos - 1);
                            }
                            else if (GameCore.Game.User.Hero.Name.ToLower().Equals(cmd.Target))
                            {
                                MouseMovement.PlayCardOn(0, 0, false, 0, 0, true);
                            }
                            else if (GameCore.Game.Opponent.Hero.Name.ToLower().Equals(cmd.Target))
                            {
                                MouseMovement.PlayCardOn(0, 0, true, 0, 0, true);
                            }
                        }
                        break;
                    case PlayType.HeroPower:
                        if (cmd.Target == null)
                        {
                            MouseMovement.HeroPower();
                        }
                        else
                        {
                            if ((target = GameCore.Game.User.GetPlayCard(cmd.Target)) != null)
                            {
                                MouseMovement.HeroPower(GameCore.Game.GetUserMinions().Count, target.ZonePos - 1, false);
                            }
                            else if ((target = GameCore.Game.Opponent.GetPlayCard(cmd.Target)) != null)
                            {
                                MouseMovement.HeroPower(GameCore.Game.GetOpponentMinions().Count, target.ZonePos - 1, true);
                            }
                            else if (GameCore.Game.User.Hero.Name.ToLower().Equals(cmd.Target))
                            {
                                MouseMovement.HeroPower(false);
                            }
                            else if (GameCore.Game.Opponent.Hero.Name.ToLower().Equals(cmd.Target))
                            {
                                MouseMovement.HeroPower(true);
                            }
                        }
                        break;
                    case PlayType.Attack:
                        if ((GameCore.Game.User.GetPlayCard(cmd.Name) == null && !GameCore.Game.User.Hero.Name.ToLower().Equals(cmd.Name)) || (GameCore.Game.Opponent.GetPlayCard(cmd.Target) == null && !GameCore.Game.Opponent.Hero.Name.ToLower().Equals(cmd.Target)))
                        {
                            IO.LogDebug("FAIL " + cmd.ToString(), IO.DebugFile.Input);
                            continue;
                        }
                        if ((name = GameCore.Game.User.GetPlayCard(cmd.Name)) != null)
                        {
                            if ((target = GameCore.Game.Opponent.GetPlayCard(cmd.Target)) != null)
                            {
                                MouseMovement.AttackCard(GameCore.Game.GetOpponentMinions().Count, name.ZonePos - 1, GameCore.Game.GetOpponentMinions().Count, target.ZonePos - 1);
                            }
                            else if ((target = GameCore.Game.Opponent.Hero).Name.ToLower().Equals(cmd.Target))
                            {
                                MouseMovement.AttackCard(GameCore.Game.GetOpponentMinions().Count, name.ZonePos - 1, 0, 0, true);
                            }
                        }
                        else if ((name = GameCore.Game.User.Hero).Name.ToLower().Equals(cmd.Name))
                        {
                            if ((target = GameCore.Game.Opponent.GetPlayCard(cmd.Target)) != null)
                            {
                                MouseMovement.AttackHero(GameCore.Game.GetOpponentMinions().Count, target.ZonePos - 1);
                            }
                            else if ((target = GameCore.Game.Opponent.Hero).Name.ToLower().Equals(cmd.Target))
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
                        MouseMovement.Requeue(int.Parse(cmd.Other));
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
