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
        public THS()
        {
            InitializeComponent();
            IO.OpenDebugFiles();
            ConfigFile.readConfigFile();
            //_game = new HSApp.HSGame(this);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //string str = "Play mark of nature on me";
            //str = str.ToLower();
            //Match aaa = InstructionType.InstructionPlayOnRegex.Match(str);
            //Utils.Misc.CloseApp();






            _inputThread = new Thread(() =>
                {
                    int i = 1;
                    int key = 0x61;
                    int size = 0;
                    int select = 0;
                    while (true)
                    {
                        Methods.Point mouseAbs = Methods.GetMouseInfo();
                        SetText(LabelMouse, mouseAbs.X + "," + mouseAbs.Y);
                        Methods.Point[] HsScreen = Methods.GetWindowCoords("Hearthstone");
                        if (HsScreen != null)
                        {
                            SetText(LabelScreenOrigin, HsScreen[0].X + "," + HsScreen[0].Y);
                            SetText(LabelScreenSize, HsScreen[1].X + "," + HsScreen[1].Y);
                        }
                        else
                        {
                            SetText(LabelScreenOrigin, "N/A");
                            SetText(LabelScreenSize, "N/A");
                        }

                        Methods.Point mouse = Methods.GetMouseInfoFromWindow("Hearthstone");

                        if (mouse.X != -1)
                        {
                            SetText(LabelMouseRel, mouse.X + "," + mouse.Y);
                        }
                        else
                        {
                            SetText(LabelMouseRel, "N/A");
                        }

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
            { Name = "Test" };
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
                if (checkBoxTCP.Checked)
                {
                    TcpListener list = new TcpListener(IPAddress.Parse("127.0.0.1"), 1234);
                    list.Start(1);
                    //list.Stop();
                    var client = list.AcceptTcpClient();
                    var inputStream = new StreamReader(client.GetStream());
                    var outputStream = new StreamWriter(client.GetStream());

                    while (true)
                    {
                        string msg = null;
                        if (!inputStream.EndOfStream)
                        {
                            msg = inputStream.ReadLine();
                        }
                        if (msg != null)
                        {
                            msg = msg.ToLower();
                            var cmd = new CommandChat(msg);
                            if (cmd.Type != PlayType.Incorrect)
                            {
                                IO.LogDebug(cmd.ToString(), IO.DebugFile.Tcp, false);
                            }
                            else
                            {
                                IO.LogDebug(msg, IO.DebugFile.Tcp);
                            }
                        }
                    }
                }
                else
                {
                    irc = new IrcClient("irc.twitch.tv", 6667, ConfigFile.TwitchLoginName, ConfigFile.TwitchLoginOauth);
                    _messageThread = new Thread(irc.StartTwitchChat) { Name = "TwitchChatReader" };
                    _messageThread.Start("deded1423");
                }
                //_game.Start();
                ButtonStart.Text = "Stop";

            }
            else
            {
                //_game.Stop();
                ButtonStart.Text = "Start";
            }
        }


        private void THS_FormClosed(object sender, FormClosedEventArgs e)
        {
            _inputThread.Suspend();
            //irc.Stop();
        }


    }
}
