using System.Collections.Generic;
using HearthDb.Enums;
using THS.Utils;

namespace THS.HSApp
{
    public class HSPlayer
    {
        //INFO
        public string PlayerId;
        public string PlayerName;
        public string GameAccountId;

        //INFO GAME
        public string CardClass;

        public int Health
        {
            get { return Hero.Tags["HEALTH"]; }
            set { Hero.Tags["HEALTH"] = value; }
        }

        public int DeckSize => Deck.Count;
        public int GraveyardSize => Graveyard.Count;
        public int PlaySize => Play.Count;
        public int SetasideSize => Setaside.Count;

        public HSCard HeroPower;


        //GAME
        public List<HSCard> Hand { get; set; }
        public List<HSCard> Graveyard { get; set; }
        public List<HSCard> Deck { get; set; }
        public List<HSCard> Play { get; set; }
        public List<HSCard> Setaside { get; set; }

        public Dictionary<string, int> playerTags = new Dictionary<string, int>();
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
        public void AddTag(string tag, string value)
        {
            if (playerTags.ContainsKey(tag))
            {
                Utils.IO.LogDebug("Changed player " + PlayerId + " tag " + tag + " " + playerTags[tag] + " to " + value, IO.DebugFile.Hs, false);
                playerTags[tag] = HsConstants.TagToInt(tag, value);
            }
            else
            {
                Utils.IO.LogDebug("Added player " + PlayerId + " tag " + tag + " " + value, IO.DebugFile.Hs, false);
                playerTags.Add(tag, HsConstants.TagToInt(tag, value));
            }
        }
        public void RemoveTag(string tag)
        {
            if (playerTags.ContainsKey(tag))
            {
                Utils.IO.LogDebug("Removed player " + PlayerId + " tag " + tag + " " + playerTags[tag], IO.DebugFile.Hs);
                playerTags.Remove(tag);
            }
        }

        public void AddHeroPower(HSCard hp)
        {
            HeroPower = hp;
            Utils.IO.LogDebug("Updated HP of player: " + PlayerId + " Class: " + hp.Card.Class);
        }
        //TAGS RELATED

        public int GetHealth()
        {
            return playerTags["HEALTH"];
        }
        public int GetClass()
        {
            return playerTags["HEALTH"];
        }

    }
}
