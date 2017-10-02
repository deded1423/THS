using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using THS.HSImport;
using THS.Twitch_Integration;

namespace THS.HSApp
{
    class HSCore
    {
        public LogHandler _logHandler;
        public HSGame Game;
        public HSCore(IrcClient irc)
        {
            Game = new HSApp.HSGame(irc);
            _logHandler = new LogHandler(Game);
        }

        public void Start() => (new Thread(_logHandler.StartLogReader) { IsBackground = true, Name = "Main Log Handler" }).Start();

        public void Stop() => _logHandler.Stop();
    }
}
