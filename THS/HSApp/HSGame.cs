using System;
using System.Collections.Generic;
using System.Threading;
using HearthDb;
using HearthDb.CardDefs;
using HearthDb.Enums;
using THS.HSImport;
using THS.Utils;
using Type = HearthDb.Enums.Type;

namespace THS.HSApp
{
    public class HSGame
    {
        LogHandler _logHandler;

        //// Cards
        //public List<HSCard> HandUser = new List<HSCard>();
        //public List<HSCard> HandOpponent = new List<HSCard>();
        //public List<HSCard> PlayedUser = new List<HSCard>();
        //public List<HSCard> PlayedOpponent = new List<HSCard>();
        //public List<HSCard> GraveyardUser = new List<HSCard>();
        //public List<HSCard> GraveyardOpponent = new List<HSCard>();
        //public List<HSCard> SetasideUser = new List<HSCard>();
        //public List<HSCard> SetasideOpponent = new List<HSCard>();
        //public List<HSCard> DeckUser = new List<HSCard>();
        //public List<HSCard> DeckOpponent = new List<HSCard>();
        public List<HSCard> EnchantmentHsCards = new List<HSCard>();

        //Other
        public HSPlayer User;
        public HSPlayer Opponent;

        //Game Entity
        public Dictionary<GameTag, int> Tags = new Dictionary<GameTag, int>();
        public int NumGe;

        public HSGame(Windows.THS ths)
        {
            _logHandler = new LogHandler(ths, this);
            User = new HSPlayer();
            Opponent = new HSPlayer();
        }

        public void Start()
        {
            Thread _thread = new Thread(_logHandler.StartLogReader) { IsBackground = true, Name = "Main Log Handler" };
            _thread.Start();
        }

        public void Stop()
        {
            _logHandler.Stop();
        }
        //Non-Game methods
        public void ClearGame()
        {
            User.Clear();
            Opponent.Clear();
            Tags.Clear();
            NumGe = 0;
            User = new HSPlayer();
            Opponent = new HSPlayer();

            Utils.IO.LogDebug("Game Cleared", Utils.IO.DebugFile.Hs);
        }

        //Create Things
        public void AddTag(string tag, string value)
        {
            GameTag gt = HsConstants.StringToTag(tag);
            int i = HsConstants.TagToInt(gt, value);
            if (Tags.ContainsKey(gt))
            {
                IO.LogDebug("Changed GE Tag: " + tag + " to " + i, IO.DebugFile.Hs, false);
                Tags[gt] = i;
            }
            else
            {
                IO.LogDebug("Added GE Tag: " + tag + " to " + i, IO.DebugFile.Hs, false);
                Tags.Add(gt, i);
            }
        }
        //Methods that do something to the game

        //Methods that take info from the game

    }
}