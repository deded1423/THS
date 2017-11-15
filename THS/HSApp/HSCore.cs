using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using THS.HSImport;
using THS.Twitch_Integration;
using THS.Windows;

namespace THS.HSApp
{
    public class HSCore
    {
        public LogHandler _logHandler;
        public HSGame Game;
        public THS.Windows.THS ths;
        public HSCore(IrcClient irc, THS.Windows.THS window)
        {
            Game = new HSApp.HSGame(irc, this);
            _logHandler = new LogHandler(Game);
            ths = window;
        }

        public void Start() => (new Thread(_logHandler.StartLogReader) { IsBackground = true, Name = "Main Log Handler" }).Start();

        public void Stop() => _logHandler.Stop();
    }
}
