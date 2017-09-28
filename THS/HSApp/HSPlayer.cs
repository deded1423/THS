using System;
using System.Collections.Generic;
using HearthDb.Enums;
using THS.Utils;

namespace THS.HSApp
{
    public class HSPlayer
    {
        //INFO
        public int PlayerId;
        public int EntityId;
        public string PlayerName;
        public string GameAccountId;

        //INFO GAME
        public string CardClass;

        public HSCard HeroPower;


        //GAME
        public List<HSCard> Hand;
        public List<HSCard> Graveyard;
        public List<HSCard> Deck;
        public List<HSCard> Play;
        public List<HSCard> Setaside;

        public Dictionary<GameTag, int> Tags = new Dictionary<GameTag, int>();
        public HSCard Hero;

        public HSPlayer()
        {
            Hand = new List<HSCard>();
            Graveyard = new List<HSCard>();
            Deck = new List<HSCard>();
            Play = new List<HSCard>();
            Setaside = new List<HSCard>();
        }

        public void Clear()
        {
            Hand.Clear();
            Graveyard.Clear();
            Deck.Clear();
            Play.Clear();
            Setaside.Clear();
        }


        //TAGS RELATED
        public void AddTag(string tag, string value)
        {
            GameTag gt = HsConstants.StringToTag(tag);
            int i = HsConstants.TagToInt(gt, value);
            if (Tags.ContainsKey(gt))
            {
                Tags[gt] = i;
            }
            else
            {
                Tags.Add(gt, i);
            }
        }

    }
}
