using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using THS.HSImport;

namespace THS.HSApp
{
    class HSCore
    {
        LogHandler _logHandler;
        HSGame Game;
        public HSCore(Windows.THS ths)
        {
            Game = new HSApp.HSGame();
            _logHandler = new LogHandler(ths, Game);
        }

        public void Start() => (new Thread(_logHandler.StartLogReader) { IsBackground = true, Name = "Main Log Handler" }).Start();

        public void Stop() => _logHandler.Stop();
    }
}
