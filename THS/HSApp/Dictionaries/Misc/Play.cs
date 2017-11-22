using HearthDb.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using THS;

namespace THS.HSApp.Dictionaries.Misc
{
    public static class Play
    {
        public static HSCore Core;
        public static HSGame Game;
        public delegate bool func(HSCard card);

        public static bool SpellTargetMinionUser()
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
        public static bool SpellTargetUser()
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
        public static bool SpellTargetHero()
        {
            if (!Game.Opponent.Stealth && !Game.Opponent.Immune)
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
        public static bool SpellTargetMinionUser(GameTag tag)
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
        public static bool SpellTargetMinionEnemy(GameTag tag)
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
        public static bool SpellTargetMinionAll(GameTag tag)
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
        public static bool SpellTargetUser(GameTag tag)
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
        public static bool SpellTargetEnemy(GameTag tag)
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
        public static bool SpellTargetAll(GameTag tag)
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
        public static bool SpellTargetHero(GameTag tag)
        {
            if (!Game.Opponent.Stealth && !Game.Opponent.Immune && Game.Opponent.CheckTag(tag))
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
        public static bool SpellTargetMinionUser(func f)
        {
            if (Game.GetUserMinions().Any(i => !i.CantTarget && !i.Immune && f(i)))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool SpellTargetMinionEnemy(func f)
        {
            if (Game.GetOpponentMinions().Any(i => !i.CantTarget && !i.Stealth && !i.Immune && f(i)))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool SpellTargetMinionAll(func f)
        {
            if (Game.GetOpponentMinions().Any(i => !i.CantTarget && !i.Stealth && !i.Immune && f(i)))
            {
                return true;
            }
            else
            {
                if (Game.GetUserMinions().Any(i => !i.CantTarget && !i.Immune && f(i)))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
        public static bool SpellTargetUser(func f)
        {
            if (Game.GetUserMinions().Any(i => !i.CantTarget && !i.Immune && f(i)))
            {
                return true;
            }
            else
            {
                if (!Game.User.Immune && f(Game.User.Hero))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
        public static bool SpellTargetEnemy(func f)
        {
            if (Game.GetOpponentMinions().Any(i => !i.CantTarget && !i.Stealth && !i.Immune && f(i)))
            {
                return true;
            }
            else
            {
                if (!Game.Opponent.Stealth && !Game.Opponent.Immune && f(Game.Opponent.Hero))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
        public static bool SpellTargetAll(func f)
        {
            if (Game.GetOpponentMinions().Any(i => !i.CantTarget && !i.Stealth && !i.Immune && f(i)))
            {
                return true;
            }
            else
            {
                if (!Game.Opponent.Stealth && !Game.Opponent.Immune && f(Game.Opponent.Hero))
                {
                    return true;
                }
                else
                {
                    if (Game.GetUserMinions().Any(i => !i.CantTarget && !i.Immune && f(i)))
                    {
                        return true;
                    }
                    else
                    {
                        if (!Game.User.Immune && f(Game.User.Hero))
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
        public static bool SpellTargetHero(func f)
        {
            if (!Game.Opponent.Stealth && !Game.Opponent.Immune && f(Game.Opponent.Hero))
            {
                return true;
            }
            else
            {
                if (!Game.User.Immune && f(Game.User.Hero))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }


        public static bool SpellImmuneTargetMinionUser()
        {
            if (Game.GetUserMinions().Any(i => !i.CantTarget))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool SpellImmuneTargetMinionEnemy()
        {
            if (Game.GetOpponentMinions().Any(i => !i.CantTarget && !i.Stealth))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool SpellImmuneTargetMinionAll()
        {
            if (Game.GetOpponentMinions().Any(i => !i.CantTarget && !i.Stealth))
            {
                return true;
            }
            else
            {
                if (Game.GetUserMinions().Any(i => !i.CantTarget))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
        public static bool SpellImmuneTargetUser()
        {
            if (Game.GetUserMinions().Any(i => !i.CantTarget))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool SpellImmuneTargetEnemy()
        {
            if (Game.GetOpponentMinions().Any(i => !i.CantTarget && !i.Stealth))
            {
                return true;
            }
            else
            {
                if (!Game.Opponent.Stealth)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
        public static bool SpellImmuneTargetAll()
        {
            if (Game.GetOpponentMinions().Any(i => !i.CantTarget && !i.Stealth))
            {
                return true;
            }
            else
            {
                if (!Game.Opponent.Stealth)
                {
                    return true;
                }
                else
                {
                    if (Game.GetUserMinions().Any(i => !i.CantTarget))
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
        public static bool SpellImmuneTargetHero()
        {
            if (!Game.Opponent.Stealth)
            {
                return true;
            }
            else
            {
                return false;

            }
        }
        public static bool SpellImmuneTargetMinionUser(GameTag tag)
        {
            if (Game.GetUserMinions().Any(i => !i.CantTarget && i.CheckTag(tag)))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool SpellImmuneTargetMinionEnemy(GameTag tag)
        {
            if (Game.GetOpponentMinions().Any(i => !i.CantTarget && !i.Stealth && i.CheckTag(tag)))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool SpellImmuneTargetMinionAll(GameTag tag)
        {
            if (Game.GetOpponentMinions().Any(i => !i.CantTarget && !i.Stealth && i.CheckTag(tag)))
            {
                return true;
            }
            else
            {
                if (Game.GetUserMinions().Any(i => !i.CantTarget && i.CheckTag(tag)))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
        public static bool SpellImmuneTarget(GameTag tag)
        {
            if (Game.GetUserMinions().Any(i => !i.CantTarget && i.CheckTag(tag)))
            {
                return true;
            }
            else
            {
                if (Game.User.CheckTag(tag))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
        public static bool SpellImmuneTargetEnemy(GameTag tag)
        {
            if (Game.GetOpponentMinions().Any(i => !i.CantTarget && !i.Stealth && i.CheckTag(tag)))
            {
                return true;
            }
            else
            {
                if (!Game.Opponent.Stealth && Game.Opponent.CheckTag(tag))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
        public static bool SpellImmuneTargetAll(GameTag tag)
        {
            if (Game.GetOpponentMinions().Any(i => !i.CantTarget && !i.Stealth && i.CheckTag(tag)))
            {
                return true;
            }
            else
            {
                if (!Game.Opponent.Stealth && Game.Opponent.CheckTag(tag))
                {
                    return true;
                }
                else
                {
                    if (Game.GetUserMinions().Any(i => !i.CantTarget && i.CheckTag(tag)))
                    {
                        return true;
                    }
                    else
                    {
                        if (Game.User.CheckTag(tag))
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
        public static bool SpellImmuneTargetHero(GameTag tag)
        {
            if (!Game.Opponent.Stealth && Game.Opponent.CheckTag(tag))
            {
                return true;
            }
            else
            {
                if (Game.User.CheckTag(tag))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
        public static bool SpellImmuneTargetMinionUser(func f)
        {
            if (Game.GetUserMinions().Any(i => !i.CantTarget && f(i)))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool SpellImmuneTargetMinionEnemy(func f)
        {
            if (Game.GetOpponentMinions().Any(i => !i.CantTarget && !i.Stealth && f(i)))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool SpellImmuneTargetMinionAll(func f)
        {
            if (Game.GetOpponentMinions().Any(i => !i.CantTarget && !i.Stealth && f(i)))
            {
                return true;
            }
            else
            {
                if (Game.GetUserMinions().Any(i => !i.CantTarget && f(i)))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
        public static bool SpellImmuneTargetUser(func f)
        {
            if (Game.GetUserMinions().Any(i => !i.CantTarget && f(i)))
            {
                return true;
            }
            else
            {
                if (f(Game.User.Hero))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
        public static bool SpellImmuneTargetEnemy(func f)
        {
            if (Game.GetOpponentMinions().Any(i => !i.CantTarget && !i.Stealth && f(i)))
            {
                return true;
            }
            else
            {
                if (!Game.Opponent.Stealth && f(Game.Opponent.Hero))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
        public static bool SpellImmuneTargetAll(func f)
        {
            if (Game.GetOpponentMinions().Any(i => !i.CantTarget && !i.Stealth && f(i)))
            {
                return true;
            }
            else
            {
                if (!Game.Opponent.Stealth && f(Game.Opponent.Hero))
                {
                    return true;
                }
                else
                {
                    if (Game.GetUserMinions().Any(i => !i.CantTarget && f(i)))
                    {
                        return true;
                    }
                    else
                    {
                        if (f(Game.User.Hero))
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
        public static bool SpellImmuneTargetHero(func f)
        {
            if (!Game.Opponent.Stealth && f(Game.Opponent.Hero))
            {
                return true;
            }
            else
            {
                if (f(Game.User.Hero))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        public static bool SpellImmuneRandomTargetMinionUser()
        {
            if (Game.GetUserMinions().Any())
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool SpellImmuneRandomTargetMinionEnemy()
        {
            if (Game.GetOpponentMinions().Any())
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool SpellRandomTargetMinionUser()
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
        public static bool SpellRandomTargetEnemy()
        {
            if (Game.GetOpponentMinions().Any(i => !i.Immune))
            {
                return true;
            }
            else
            {
                if (!Game.Opponent.Hero.Immune)
                {
                    return true;
                }
                else
                {
                    return false;
                }
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
