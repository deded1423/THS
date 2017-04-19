using System;
using System.Collections.Generic;
using System.Threading;
using System.Windows.Forms;
using THS.HSImport;
using THS.Twitch_Integration;

namespace THS.Windows
{

    public partial class THS : Form
    {
        Queue<string> chat = new Queue<string>();
        static IrcClient irc = new IrcClient("irc.twitch.tv", 6667, "deded1423", "oauth:p26a360ks4lpg359oh5v8mbamsf3v1");
        Thread _twitchThread = new Thread(irc.StartTwitchChat) { Name = "TwitchChatReader" };

        LogHandler a = new LogHandler();
        public THS()
        {
            InitializeComponent();
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
            Form a = new Form();
            
        }
    }
}
