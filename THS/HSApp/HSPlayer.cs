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
        public string CardClass;
        public HSCard HeroPower;


        //GAME
        private List<HSCard> Hand { get; set; }
        private List<HSCard> Graveyard { get; set; }
        private List<HSCard> Deck { get; set; }
        private Dictionary<string, int> Tags = new Dictionary<string, int>();

        public HSPlayer()
        {
            Hand = new List<HSCard>();
            Graveyard = new List<HSCard>();
            Deck = new List<HSCard>();
        }

        public void AddTag(string tag, string value)
        {
            if (Tags.ContainsKey(tag))
            {
                Utils.IO.LogDebug("Changed player " + PlayerId + " tag " + tag + " " + Tags[tag] + " to " + value, IO.DebugFile.Hs);
                Tags[tag] = HsConstants.TagToInt(tag, value);
            }
            else
            {
                Utils.IO.LogDebug("Added player " + PlayerId + " tag " + tag + " " + value, IO.DebugFile.Hs);
                Tags.Add(tag, HsConstants.TagToInt(tag, value));
            }
        }
        public void RemoveTag(string tag)
        {
            if (Tags.ContainsKey(tag))
            {
                Utils.IO.LogDebug("Removed player " + PlayerId + " tag " + tag + " " + Tags[tag], IO.DebugFile.Hs);
                Tags.Remove(tag);
            }
        }


        //TAGS RELATED

        public int GetHealth()
        {
            return Tags["HEALTH"];
        }

    }
}
