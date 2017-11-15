using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using HearthDb;
using HearthDb.CardDefs;
using THS.Utils;
using HearthDb.Enums;
using System;

namespace THS.HSApp
{
    [Serializable]
    public class HSCard
    {
        public int Id;
        public Card CardDB;
        public Dictionary<GameTag, int> Tags = new Dictionary<GameTag, int>();

        public HSCard()
        {
        }

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

        public string Name
        {
            get
            {
                if (CardDB != null)
                {
                    return CardDB.Name;
                }
                return "";
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
                if (Tags.ContainsKey(GameTag.ZONE_POSITION))
                {
                    return Tags[GameTag.ZONE_POSITION];
                }
                return 0;
            }
        }
        public int Controller
        {
            get
            {
                if (Tags.ContainsKey(GameTag.CONTROLLER))
                {
                    return Tags[GameTag.CONTROLLER];
                }
                return 0;
            }
        }
        public CardType CardType
        {
            get
            {
                if (Tags.ContainsKey(GameTag.CARDTYPE))
                {
                    return (CardType)Tags[GameTag.CARDTYPE];
                }
                return CardType.INVALID;
            }

        }
        public int Attack
        {
            get
            {
                if (Tags.ContainsKey(GameTag.ATK))
                {
                    return Tags[GameTag.ATK];
                }
                return 0;
            }
        }
        public int Health
        {
            get
            {
                if (Tags.ContainsKey(GameTag.HEALTH))
                {
                    return Tags[GameTag.HEALTH];
                }
                return 0;
            }
        }
        public int ManaCost
        {
            get
            {
                if (Tags.ContainsKey(GameTag.COST))
                {
                    return Tags[GameTag.COST];
                }
                return 0;
            }
        }
        public int Damage
        {
            get
            {
                return Tags[GameTag.DAMAGE];
            }
        }
        public int TrueHealth
        {
            get
            {
                if (Tags.ContainsKey(GameTag.DAMAGE))
                {
                    return Health - Tags[GameTag.DAMAGE];
                }
                return Health;
            }
        }
        public bool DivineShield
        {
            get
            {
                if (Tags.ContainsKey(GameTag.DIVINE_SHIELD))
                {
                    return Tags[GameTag.DIVINE_SHIELD] == 1 ? true : false;
                }
                return false;
            }
        }
        public bool Charge
        {
            get
            {
                if (Tags.ContainsKey(GameTag.CHARGE))
                {
                    return (Tags[GameTag.CHARGE] == 1 ? true : false);
                }
                return false;
            }
        }
        public bool Lifesteal
        {
            get
            {
                if (Tags.ContainsKey(GameTag.LIFESTEAL))
                {
                    return Tags[GameTag.LIFESTEAL] == 1 ? true : false;
                }
                return false;
            }
        }
        public bool Taunt
        {
            get
            {
                if (Tags.ContainsKey(GameTag.TAUNT))
                {
                    return Tags[GameTag.TAUNT] == 1 ? true : false;
                }
                return false;
            }
        }
        public bool Stealth
        {
            get
            {
                if (Tags.ContainsKey(GameTag.STEALTH))
                {
                    return Tags[GameTag.STEALTH] == 1 ? true : false;
                }
                return false;
            }
        }
        public bool Windfury
        {
            get
            {
                if (Tags.ContainsKey(GameTag.WINDFURY))
                {
                    return Tags[GameTag.WINDFURY] == 1 ? true : false;
                }
                return false;
            }
        }
        public bool Exhausted
        {
            get
            {
                if (Tags.ContainsKey(GameTag.EXHAUSTED))
                {
                    return Tags[GameTag.EXHAUSTED] == 1 ? true : false;
                }
                return false;
            }
        }
        public int Armor
        {
            get
            {
                if (CardType.Equals(CardType.HERO) && Tags.ContainsKey(GameTag.ARMOR))
                {
                    return Tags[GameTag.ARMOR];
                }
                return 0;
            }
        }
        public bool IsSecret
        {
            get
            {
                if (Tags.ContainsKey(GameTag.SECRET))
                {
                    return true;
                }
                return false;
            }
        }

        public override string ToString() => "ID: " + Id + " " + CardDB?.Name + " Zone: " + Zone + " Attack: " + (Tags.ContainsKey(GameTag.ATK) ? Attack.ToString() : "N/A") + " Health: " + (Tags.ContainsKey(GameTag.HEALTH) ? TrueHealth.ToString() : "N/A");
    }
}
