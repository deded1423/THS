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

namespace THS.Windows
{

    public partial class THS : Form
    {
        //TODO: CAMBIAR TODA ESTA MIERDA PARA QUE ESTE EN OTRA CLASE
        //TWITCH SHIT
        Queue<string> chat = new Queue<string>();
        static IrcClient irc;
        Thread _messageThread;

        //UI SHIT
        private Config _configwindow;

        //IMPORT SHIT
        private HSApp.HSGame _game;

        //INPUT SHIT
        Thread _inputThread;
        bool stopinput = false;
        public THS()
        {
            InitializeComponent();
            IO.OpenDebugFiles();
            ConfigFile.readConfigFile();
            _game = new HSApp.HSGame(this);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            _inputThread = new Thread(() =>
                {
                    int i = 1;
                    int key = 0x61;
                    while (!stopinput)
                    {
                        Methods.Point mouse = Methods.GetMouseInfoFromWindow("Hearthstone");
                        if (Methods.GetKeyState(key) < 0) //NUM1
                        {
                            Console.WriteLine(i + ") " + mouse.X + "," + mouse.Y);
                            i++;
                            while (Methods.GetKeyState(key) < 0) { }
                        }
                        if (Methods.GetKeyState(0x64) < 0) //NUM4
                        {
                            while (Methods.GetKeyState(0x64) < 0) { }
                        }
                        if (Methods.GetKeyState(0x66) < 0) //NUM6
                        {
                            while (Methods.GetKeyState(0x66) < 0) { }
                        }
                        if (Methods.GetKeyState(0x62) < 0) //NUM2
                        {
                            while (Methods.GetKeyState(0x62) < 0) { }
                        }
                        if (Methods.GetKeyState(0x68) < 0) //NUM8
                        {
                            while (Methods.GetKeyState(0x68) < 0) { }
                        }

                        if (Methods.GetKeyState(0x63) < 0) //NUM3
                        {
                            MouseMovement.AttackHero(0, 0, true);
                            while (Methods.GetKeyState(0x63) < 0) { }
                        }
                        Thread.Sleep(10);
                    }
                })
            { Name = "Input" };
            _inputThread.Start();
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
                _game.Start();
                ButtonStart.Text = "Stop";

            }
            else
            {
                _game.Stop();
                ButtonStart.Text = "Start";
            }
        }

        private void buttonStartTCP_Click(object sender, EventArgs e)
        {

            if (ButtonStart.Text.Equals("Start Tcp"))
            {
                StartIRC();
                ButtonStart.Text = "Stop Tcp";

            }
            else
            {
                ButtonStart.Text = "Start Tcp";
            }
        }

        private void THS_FormClosed(object sender, FormClosedEventArgs e)
        {
            stopinput = true;
            IO.CloseDebugFiles();
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

    }
}
