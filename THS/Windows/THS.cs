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

namespace THS.Windows
{

    public partial class THS : Form
    {
        //TODO: Cambiar todo esto para que este en otra clase??
        //TODO: Mirar que el programa cierra bien (Procesos y Files)
        //TWITCH SHIT
        Queue<string> chat = new Queue<string>();
        static IrcClient irc;
        Thread _messageThread;

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
                _messageThread = new Thread(irc.StartTwitchChat) { Name = "TwitchChatReader" };
                _messageThread.Start("THS");
            }
            else
            {
                irc.StartConnection("irc.twitch.tv", 6667, ConfigFile.TwitchLoginName, ConfigFile.TwitchLoginOauth);
                _messageThread = new Thread(irc.StartTwitchChat) { Name = "TwitchChatReader" };
                _messageThread.Start("deded1423");
            }
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
    }
}
