﻿using System;
using System.Collections.Generic;
using System.Threading;
using System.Windows.Forms;
using THS.Twitch_Integration;
using THS.Utils;
using THS.Input;

namespace THS.Windows
{

    public partial class THS : Form
    {
        //TODO: CAMBIAR TODA ESTA MIERDA PARA QUE ESTE EN OTRA CLASE
        //TWITCH SHIT
        Queue<string> chat = new Queue<string>();
        static IrcClient irc;
        Thread _twitchThread;

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
            //irc = new IrcClient("irc.twitch.tv", 6667, ConfigFile.TwitchLoginName, ConfigFile.TwitchLoginOauth);
            //_twitchThread = new Thread(irc.StartTwitchChat) { Name = "TwitchChatReader" };
            //_twitchThread.Start("deded1423");

            //string str = "Play mark of nature on me";
            //str = str.ToLower();
            //Match aaa = InstructionType.InstructionPlayOnRegex.Match(str);
            //Utils.Misc.CloseApp();

            _inputThread = new Thread(() =>
            {
                while (true)
                {
                    Methods.GetWindowInfo(this, "Friends");
                    Methods.GetMouseInfo(this);
                    Thread.Sleep(100);
                }
            }) { Name = "Test" };
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
