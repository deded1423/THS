using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using HearthDb;
using HearthDb.CardDefs;
using THS.Utils;
using HearthDb.Enums;

namespace THS.HSApp
{
    public class HSCard
    {
        public int Id;
        public Card CardDB;
        public Dictionary<GameTag, int> Tags = new Dictionary<GameTag, int>();

        public HSCard(int i)
        {
            Id = i;
        }

        //Tags
        public void AddTag(string tag, string value)
        {
            GameTag gt = HsConstants.StringToTag(tag);
            int i = HsConstants.TagToInt(gt, value);
            if (Tags.ContainsKey(gt))
            {
                IO.LogDebug("Changed " + Id + " " + CardDB?.Name + " Tag: " + tag + " to " + i, IO.DebugFile.Hs, false);
                Tags[gt] = i;
            }
            else
            {
                IO.LogDebug("Added " + Id + " " + CardDB?.Name + " Tag: " + tag + " to " + i, IO.DebugFile.Hs, false);
                Tags.Add(gt, i);
            }
        }
        public Zone Zone
        {
            get
            {
                return (Zone)Tags[GameTag.ZONE];
            }

            set
            {
                Tags[GameTag.ZONE] = (int)value;
            }
        }
        public int Controller
        {
            get
            {
                return Tags[GameTag.CONTROLLER];
            }

            set
            {
                Tags[GameTag.CONTROLLER] = value;
            }
        }

        public CardType CardType
        {
            get
            {
                return (CardType)Tags[GameTag.CARDTYPE];
            }

            set
            {
                Tags[GameTag.CARDTYPE] = (int)value;
            }
        }
    }
}
