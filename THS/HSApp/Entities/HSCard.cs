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
        }
        public int ZonePos
        {
            get
            {
                return Tags[GameTag.ZONE_POSITION];
            }
        }
        public int Controller
        {
            get
            {
                return Tags[GameTag.CONTROLLER];
            }
        }
        public CardType CardType
        {
            get
            {
                return (CardType)Tags[GameTag.CARDTYPE];
            }

        }
        public int Attack
        {
            get
            {
                return Tags[GameTag.ATK];
            }
        }
        public int Health
        {
            get
            {
                return Tags[GameTag.HEALTH];
            }
        }
        public int Damage
        {
            get
            {
                return Tags[GameTag.DAMAGE];
            }
        }
        public CardType TrueHealth
        {
            get
            {
                return (CardType)Tags[GameTag.CARDTYPE];
            }
        }

        public override string ToString() => "ID: " + Id + " " + CardDB?.Name + " Zone: " + Zone;
    }
}
