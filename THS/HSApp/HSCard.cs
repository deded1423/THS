using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using HearthDb;
using HearthDb.CardDefs;
using THS.HearthDb;
using THS.Utils;

namespace THS.HSApp
{
    public class HSCard
    {
        public int id;
        public Card Card;
        public Dictionary<string, int> Tags = new Dictionary<string, int>();
        public HSCard(int i)
        {
            id = i;
        }

        public override string ToString()
        {
            if (Card != null)
            {

                return "ID: " + id + ", Card: " + Card.Id;
            }
            else
            {
                return "ID: " + id;
            }
        }

        public void AddTag(string tag, string value)
        {
            if (!Tags.ContainsKey(tag))
            {
                Tags.Add(tag, HsConstants.TagToInt(tag, value));
                Utils.IO.LogDebug("Added Tag " + tag + " " + value, IO.DebugFile.Hs, false);
            }
            else
            {
                Tags[tag] = HsConstants.TagToInt(tag, value);
                Utils.IO.LogDebug("Changed Tag " + tag + " " + value, IO.DebugFile.Hs, false);
            }
        }
        public void RemoveTag(string tag)
        {
            if (Tags.ContainsKey(tag))
            {
                Tags.Remove(tag);
                Utils.IO.LogDebug("Removed Tag " + tag + " " + Tags[tag], IO.DebugFile.Hs, false);
            }
        }

        public void UpdateCard(string cardid)
        {
            Card = Cards.All[cardid];
            Utils.IO.LogDebug("Updated card " + id + " " + cardid, IO.DebugFile.Hs);
        }
    }
}
