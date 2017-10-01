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
                    GameCore = new HSApp.HSCore(this);
                    GameCore.Start();
                    ButtonStart.Text = "Stop";
                    Text = "THS";
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
                irc = new IrcClient("irc.freenode.net", 6667, "THStone", "none");
                _messageThread = new Thread(irc.StartTwitchChat) { Name = "TwitchChatReader" };
                _messageThread.Start("THS");
            }
            else
            {
                irc = new IrcClient("irc.twitch.tv", 6667, ConfigFile.TwitchLoginName, ConfigFile.TwitchLoginOauth);
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
                IO.LogDebug("USER BOARD");
                foreach (var card in GameCore.Game.GetUserBoard())
                {
                    IO.LogDebug(card.ToString());
                }
            }
            else if (((Button)sender).Equals(buttonTest4))
            {
                IO.LogDebug("OPPONENT BOARD");
                foreach (var card in GameCore.Game.GetOpponentBoard())
                {
                    IO.LogDebug(card.ToString());
                }
            }
            else if (((Button)sender).Equals(buttonTest5))
            {
                IO.LogDebug("USER HAND " + GameCore.Game.User.Hand.Count);
                foreach (var card in GameCore.Game.User.Hand)
                {
                    IO.LogDebug(card.ToString());
                }
            }
            else if (((Button)sender).Equals(buttonTest6))
            {
                IO.LogDebug("OPPONENT HAND " + GameCore.Game.Opponent.Hand.Count);
                foreach (var card in GameCore.Game.Opponent.Hand)
                {
                    IO.LogDebug(card.ToString());
                }
            }
            else if (((Button)sender).Equals(buttonTest7))
            {
                IO.LogDebug("USER DEAD MINIONS");
                foreach (var card in GameCore.Game.GetUserDeadMinion())
                {
                    IO.LogDebug(card.ToString());
                }
            }
            else if (((Button)sender).Equals(buttonTest8))
            {
                IO.LogDebug("OPPONENT DEAD MINIONS");
                foreach (var card in GameCore.Game.GetOpponentDeadMinion())
                {
                    IO.LogDebug(card.ToString());
                }
            }
        }

        private void SetupTestButtons()
        {
            buttonTest1.Text = "Mouse";
            buttonTest2.Text = "Debug";
            buttonTest3.Text = "U Board";
            buttonTest4.Text = "O Board";
            buttonTest5.Text = "U Hand";
            buttonTest6.Text = "O Hand";
            buttonTest7.Text = "U Dead";
            buttonTest8.Text = "O Dead";
        }
    }
}
