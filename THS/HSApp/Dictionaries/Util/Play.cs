using HearthDb.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using THS;

namespace THS.HSApp.Dictionaries.Util
{
    public static class Play
    {
        public static HSCore Core;
        public static HSGame Game;

        public static bool SpellTargetMinion()
        {
            if (Game.GetUserMinions().Any(i => !i.CantTarget && !i.Immune))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool SpellTargetMinionEnemy()
        {
            if (Game.GetOpponentMinions().Any(i => !i.CantTarget && !i.Stealth && !i.Immune))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool SpellTargetMinionAll()
        {
            if (Game.GetOpponentMinions().Any(i => !i.CantTarget && !i.Stealth && !i.Immune))
            {
                return true;
            }
            else
            {
                if (Game.GetUserMinions().Any(i => !i.CantTarget && !i.Immune))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
        public static bool SpellTarget()
        {
            if (Game.GetUserMinions().Any(i => !i.CantTarget && !i.Immune))
            {
                return true;
            }
            else
            {
                if (!Game.User.Stealth && !Game.Opponent.Immune)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
        public static bool SpellTargetEnemy()
        {
            if (Game.GetOpponentMinions().Any(i => !i.CantTarget && !i.Stealth && !i.Immune))
            {
                return true;
            }
            else
            {
                if (!Game.Opponent.Stealth && !Game.Opponent.Immune)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
        public static bool SpellTargetAll()
        {
            if (Game.GetOpponentMinions().Any(i => !i.CantTarget && !i.Stealth && !i.Immune))
            {
                return true;
            }
            else
            {
                if (!Game.Opponent.Stealth && !Game.Opponent.Immune)
                {
                    return true;
                }
                else
                {
                    if (Game.GetUserMinions().Any(i => !i.CantTarget && !i.Immune))
                    {
                        return true;
                    }
                    else
                    {
                        if (!Game.User.Immune)
                        {
                            return true;
                        }
                        else
                        {
                            return false;
                        }
                    }
                }
            }
        }
        public static bool SpellTargetMinionWithTag(GameTag tag)
        {
            if (Game.GetUserMinions().Any(i => !i.CantTarget && !i.Immune && i.CheckTag(tag)))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool SpellTargetMinionEnemyWithTag(GameTag tag)
        {
            if (Game.GetOpponentMinions().Any(i => !i.CantTarget && !i.Stealth && !i.Immune && i.CheckTag(tag)))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool SpellTargetMinionAllWithTag(GameTag tag)
        {
            if (Game.GetOpponentMinions().Any(i => !i.CantTarget && !i.Stealth && !i.Immune && i.CheckTag(tag)))
            {
                return true;
            }
            else
            {
                if (Game.GetUserMinions().Any(i => !i.CantTarget && !i.Immune && i.CheckTag(tag)))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
        public static bool SpellTargetWithTag(GameTag tag)
        {
            if (Game.GetUserMinions().Any(i => !i.CantTarget && !i.Immune && i.CheckTag(tag)))
            {
                return true;
            }
            else
            {
                if (!Game.User.Stealth && !Game.User.Immune && Game.User.CheckTag(tag))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
        public static bool SpellTargetEnemyWithTag(GameTag tag)
        {
            if (Game.GetOpponentMinions().Any(i => !i.CantTarget && !i.Stealth && !i.Immune && i.CheckTag(tag)))
            {
                return true;
            }
            else
            {
                if (!Game.Opponent.Stealth && !Game.Opponent.Immune && Game.Opponent.CheckTag(tag))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
        public static bool SpellTargetAllWithTag(GameTag tag)
        {
            if (Game.GetOpponentMinions().Any(i => !i.CantTarget && !i.Stealth && !i.Immune && i.CheckTag(tag)))
            {
                return true;
            }
            else
            {
                if (!Game.Opponent.Stealth && !Game.Opponent.Immune && Game.Opponent.CheckTag(tag))
                {
                    return true;
                }
                else
                {
                    if (Game.GetUserMinions().Any(i => !i.CantTarget && !i.Immune && i.CheckTag(tag)))
                    {
                        return true;
                    }
                    else
                    {
                        if (!Game.User.Immune && Game.User.CheckTag(tag))
                        {
                            return true;
                        }
                        else
                        {
                            return false;
                        }
                    }
                }
            }
        }
        public static bool SpellRandomTargetMinionEnemy()
        {
            if (Game.GetOpponentMinions().Any(i => !i.Immune))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool SpellRandomTargetMinion()
        {
            if (Game.GetUserMinions().Any(i => !i.Immune))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool SpellSummonMinion()
        {
            if (Game.GetUserMinions().Count == 7)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        public static bool SpellSecret(string id)
        {
            if (Game.GetUserSecret().Count == 5)
            {
                return false;
            }
            if (Game.GetUserSecret().Any(i => i.Id.Equals(id)))
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        public static bool MinionInHand()
        {
            if (Game.GetUserHand().Any(i => i.CardType.Equals(CardType.MINION)))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool Minion()
        {
            if (Game.GetUserMinions().Count == 7)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }

}
