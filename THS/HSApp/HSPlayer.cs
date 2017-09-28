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
            IO.LogDebug("Clearing Player", IO.DebugFile.Hs);
            Hand.Clear();
            Graveyard.Clear();
            Deck.Clear();
            Play.Clear();
            Setaside.Clear();
            Tags.Clear();
            Hero = null;

            PlayerId = 0;
            EntityId = 0;
            PlayerName = null;
            GameAccountId = null;
        }


        //TAGS RELATED
        public void AddTag(string tag, string value)
        {
            GameTag gt = HsConstants.StringToTag(tag);
            int i = HsConstants.TagToInt(gt, value);
            if (Tags.ContainsKey(gt))
            {
                IO.LogDebug("Changed Player" + PlayerId + " Tag: " + tag + " to " + i, IO.DebugFile.Hs, false);
                Tags[gt] = i;
            }
            else
            {
                IO.LogDebug("Added Player" + PlayerId + " Tag: " + tag + " to " + i, IO.DebugFile.Hs, false);
                Tags.Add(gt, i);
            }
        }

        //GETTERS
        public HSCard GetHandId(int id)
        {
            foreach (var card in Hand)
            {
                if (card.Id == id)
                {
                    return card;
                }
            }
            return null;
        }

        public HSCard GetDeckId(int id)
        {
            foreach (var card in Deck)
            {
                if (card.Id == id)
                {
                    return card;
                }
            }
            return null;
        }

        public HSCard GetPlayId(int id)
        {
            foreach (var card in Play)
            {
                if (card.Id == id)
                {
                    return card;
                }
            }
            return null;
        }

        public HSCard GetSetasideId(int id)
        {
            foreach (var card in Setaside)
            {
                if (card.Id == id)
                {
                    return card;
                }
            }
            return null;
        }

        public HSCard GetGraveyardId(int id)
        {
            foreach (var card in Graveyard)
            {
                if (card.Id == id)
                {
                    return card;
                }
            }
            return null;
        }

    }
}
