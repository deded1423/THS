using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using System.Windows.Forms;
using THS.HSImport;
using THS.Twitch_Integration;
using THS.Utils;

namespace THS.Windows
{

    public partial class THS : Form
    {
        //TWITCH SHIT
        Queue<string> chat = new Queue<string>();
        static IrcClient irc = new IrcClient("irc.twitch.tv", 6667, "deded1423", "oauth:p26a360ks4lpg359oh5v8mbamsf3v1");
        Thread _twitchThread = new Thread(irc.StartTwitchChat) { Name = "TwitchChatReader" };

        //UI SHIT
        private Config _configwindow;

        LogHandler a = new LogHandler();
        public THS()
        {
            InitializeComponent();
            IO.OpenDebugFiles();
            ConfigFile.readConfigFile();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //_twitchThread.Start("hsdogdog");
            //Utils.Utils.OpenDebugFiles();
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
            //_configwindow = new Config();
            //_configwindow.Show();

            TcpListener listener = new TcpListener(IPAddress.Parse("192.168.1.241"), 8888);
            listener.Start();
            Socket a = listener.AcceptSocket();
            Console.WriteLine("sss");
        }

        private void ButtonStart_Click(object sender, EventArgs e)
        {
            a.StartLogReader();
        }
    }
}
