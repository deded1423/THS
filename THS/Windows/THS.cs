using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using System.Windows.Forms;
using THS;
using THS.HSGame;
using THS.HSImport;
using THS.Twitch_Integration;
using THS.Utils;

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
        private HsGame _game;
        public THS()
        {
            InitializeComponent();
            IO.OpenDebugFiles();
            ConfigFile.readConfigFile();
            _game = new HsGame(this);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            irc = new IrcClient("irc.twitch.tv", 6667, ConfigFile.TwitchLoginName, ConfigFile.TwitchLoginOauth);
            _twitchThread = new Thread(irc.StartTwitchChat) { Name = "TwitchChatReader" };
            _twitchThread.Start("deded1423");
            //string str = "Play mark of nature on me";
            //str = str.ToLower();
            //Match aaa = InstructionType.InstructionPlayOnRegex.Match(str);
            //Utils.Misc.CloseApp();

            //IO.OpenDebugFiles();
            //IO.LogDebug("a");
            //a.StartLogReader();
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

        private void ButtonTest1_Click(object sender, EventArgs e)
        {
        }

        private void THS_FormClosed(object sender, FormClosedEventArgs e)
        {
            irc.Stop();
        }

    }
}
