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
        public HSCard(int i, Dictionary<string, int> tags)
        {
            id = i;
            Tags = tags;
        }


        public void AddTag(string tag, string value)
        {
            if (!Tags.ContainsKey(tag))
            {
                Tags.Add(tag, HsConstants.TagToInt(tag, value));
            }
        }
        public void RemoveTag(string tag)
        {
            if (Tags.ContainsKey(tag))
            {
                Tags.Remove(tag);
            }
        }
        public void ChangeTag(string tag, string value)
        {
            if (Tags.ContainsKey(tag))
            {
                Tags[tag] = HsConstants.TagToInt(tag, value);
            }
        }

        public void UpdateCard(string cardid)
        {
            Card = Cards.All[cardid];
        }
    }
}
