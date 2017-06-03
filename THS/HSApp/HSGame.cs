using System.Collections.Generic;
using System.Threading;
using THS.HSImport;

namespace THS.HSApp
{
    public class HSGame
    {
        LogHandler _logHandler;

        // Cards

        List<HSCard> _handPlayer = new List<HSCard>();
        List<HSCard> _handOpponent = new List<HSCard>();
        List<HSCard> _graveyardPlayer = new List<HSCard>();
        List<HSCard> _graveyardOpponent = new List<HSCard>();
        List<HSCard> _deckPlayer = new List<HSCard>();
        List<HSCard> _deckOpponent = new List<HSCard>();

        //Other
        HSPlayer _player;
        HSPlayer _opponent;

        //Game Entity
        Dictionary<string, int> _tagsGE = new Dictionary<string, int>();
        public int numGE;

        public HSGame(Windows.THS ths)
        {
            _logHandler = new LogHandler(ths, this);
        }

        public void Start()
        {
            Thread _thread = new Thread(_logHandler.StartLogReader) {IsBackground = true, Name = "LogHandler"};
            _thread.Start();
        }

        public void Stop()
        {
            _logHandler.Stop();
        }

        //Methods that do sthg to the game
        public void CreateNewGame()
        {
            _handPlayer.Clear();
            _handOpponent.Clear();
            _graveyardPlayer.Clear();
            _graveyardOpponent.Clear();
            _deckPlayer.Clear();
            _deckOpponent.Clear();
            _tagsGE.Clear();
            numGE = 0;

            Utils.IO.LogDebug("Game Created", Utils.IO.DebugFile.Hs);
        }

        public void AddCardToDeck(HSCard card, HSPlayer player)
        {
            if (player == _player)
            {
                _handPlayer.Add(card);
            }
            else
            {
                _handOpponent.Add(card);
            }
        }
        public void RemoveCardToDeck(HSCard card, HSPlayer player)
        {
            if (player == _player)
            {
                _handPlayer.Remove(card);
            }
            else
            {
                _handOpponent.Remove(card);
            }
        }

        //Methods that take info from the game

    }
}