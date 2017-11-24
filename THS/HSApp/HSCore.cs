using HearthDb.Enums;
using System.Threading;
using THS.HSImport;
using THS.Twitch_Integration;
using THS.Utils;

namespace THS.HSApp
{
    public class HSCore
    {
        public LogHandler _logHandler;
        public HSGame Game;
        public Windows.THS ths;

        public bool Spectating = false;
        public bool Running = false;
        public string Winner = "";

        public HSCore(IrcClient irc, THS.Windows.THS window)
        {
            Game = new HSApp.HSGame(irc, this);
            _logHandler = new LogHandler(Game);
            ths = window;
            Dictionaries.CardDict.UpdateGame(Game);
        }

        public void Start() => (new Thread(_logHandler.StartLogReader) { IsBackground = true, Name = "Main Log Handler" }).Start();

        public void Stop() => _logHandler.Stop();
        public void EndGame()
        {
            Spectating = false;
            Running = false;
            if (Game.User.Tags[GameTag.PLAYSTATE].Equals(PlayState.WON))
            {
                Winner = Game.User.PlayerName;
            }
            else if (Game.Opponent.Tags[GameTag.PLAYSTATE].Equals(PlayState.WON))
            {
                Winner = Game.Opponent.PlayerName;
            }
            else
            {
                Winner = "";
            }
            IO.LogDebug("Finished Game Winner: " + Winner, IO.DebugFile.Hs);
        }
    }
}
