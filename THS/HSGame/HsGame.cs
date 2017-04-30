using THS.HSImport;

namespace THS.HSGame
{
    public class HsGame
    {
        LogHandler _logHandler;

        public HsGame(Windows.THS ths)
        {
            _logHandler = new LogHandler(ths);
        }

        public void Start()
        {
            _logHandler.StartLogReader();
        }

        public void Stop()
        {
            _logHandler.Stop();
        }
    }
}