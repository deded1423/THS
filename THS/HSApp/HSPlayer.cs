using System.Collections.Generic;
using THS.Utils;

namespace THS.HSApp
{
    public class HSPlayer
    {
        private List<HSCard> Hand { get; set; }
        private List<HSCard> Graveyard { get; set; }
        private List<HSCard> Deck { get; set; }
        private Dictionary<string, int> Tags = new Dictionary<string, int>();
        public string playerID;

        public HSPlayer()
        {
            Hand = new List<HSCard>();
            Graveyard = new List<HSCard>();
            Deck = new List<HSCard>();
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
    }
}
