using HearthDb.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace THS.HSApp.Dictionaries.Misc
{
    public static class Target
    {
        public delegate bool funcBool(HSCard card);

        public static HSCore Core;
        public static HSGame Game;
        private static List<HSCard> list;

        public static List<HSCard> NoTarget()
        {
            list = new List<HSCard>();
            return list;
        }
        public static List<HSCard> SpellTargetMinionUser()
        {
            list = new List<HSCard>();
            foreach (var item in Game.GetUserMinions().Where(i => !i.CantTarget && !i.Immune))
            {
                list.Add(item);
            }
            return list;
        }
        public static List<HSCard> SpellTargetMinionEnemy()
        {
            list = new List<HSCard>();
            foreach (var item in Game.GetOpponentMinions().Where(i => !i.CantTarget && !i.Stealth && !i.Immune))
            {
                list.Add(item);
            }
            return list;
        }
        public static List<HSCard> SpellTargetMinionAll()
        {
            list = new List<HSCard>();
            foreach (var item in Game.GetOpponentMinions().Where(i => !i.CantTarget && !i.Stealth && !i.Immune))
            {
                list.Add(item);
            }
            foreach (var item in Game.GetUserMinions().Where(i => !i.CantTarget && !i.Immune))
            {
                list.Add(item);
            }
            return list;
        }
        public static List<HSCard> SpellTargetUser()
        {
            list = new List<HSCard>();
            foreach (var item in Game.GetUserMinions().Where(i => !i.CantTarget && !i.Immune))
            {
                list.Add(item);
            }
            if (!Game.User.Immune)
            {
                list.Add(Game.User.Hero);
            }
            return list;
        }
        public static List<HSCard> SpellTargetEnemy()
        {
            list = new List<HSCard>();
            foreach (var item in Game.GetOpponentMinions().Where(i => !i.CantTarget && !i.Stealth && !i.Immune))
            {
                list.Add(item);
            }
            if (!Game.Opponent.Stealth && !Game.Opponent.Immune)
            {
                list.Add(Game.Opponent.Hero);
            }
            return list;
        }
        public static List<HSCard> SpellTargetAll()
        {
            list = new List<HSCard>();
            foreach (var item in Game.GetOpponentMinions().Where(i => !i.CantTarget && !i.Stealth && !i.Immune))
            {
                list.Add(item);
            }
            if (!Game.Opponent.Stealth && !Game.Opponent.Immune)
            {
                list.Add(Game.Opponent.Hero);
            }
            foreach (var item in Game.GetUserMinions().Where(i => !i.CantTarget && !i.Immune))
            {
                list.Add(item);
            }
            if (!Game.User.Immune)
            {
                list.Add(Game.User.Hero);
            }
            return list;
        }
        public static List<HSCard> SpellTargetHero()
        {
            list = new List<HSCard>();
            if (!Game.Opponent.Stealth && !Game.Opponent.Immune)
            {
                list.Add(Game.Opponent.Hero);
            }
            if (!Game.User.Immune)
            {
                list.Add(Game.User.Hero);
            }
            return list;
        }
        public static List<HSCard> SpellTargetMinionUser(GameTag tag)
        {
            list = new List<HSCard>();
            foreach (var item in Game.GetUserMinions().Where(i => !i.CantTarget && !i.Immune && i.CheckTag(tag)))
            {
                list.Add(item);
            }
            return list;
        }
        public static List<HSCard> SpellTargetMinionEnemy(GameTag tag)
        {
            list = new List<HSCard>();
            foreach (var item in Game.GetOpponentMinions().Where(i => !i.CantTarget && !i.Stealth && !i.Immune && i.CheckTag(tag)))
            {
                list.Add(item);
            }
            return list;
        }
        public static List<HSCard> SpellTargetMinionAll(GameTag tag)
        {
            list = new List<HSCard>();
            foreach (var item in Game.GetOpponentMinions().Where(i => !i.CantTarget && !i.Stealth && !i.Immune && i.CheckTag(tag)))
            {
                list.Add(item);
            }
            foreach (var item in Game.GetUserMinions().Where(i => !i.CantTarget && !i.Immune && i.CheckTag(tag)))
            {
                list.Add(item);
            }
            return list;
        }
        public static List<HSCard> SpellTargetUser(GameTag tag)
        {
            list = new List<HSCard>();
            foreach (var item in Game.GetUserMinions().Where(i => !i.CantTarget && !i.Immune && i.CheckTag(tag)))
            {
                list.Add(item);
            }
            if (!Game.User.Immune && Game.User.CheckTag(tag))
            {
                list.Add(Game.User.Hero);
            }
            return list;
        }
        public static List<HSCard> SpellTargetEnemy(GameTag tag)
        {
            list = new List<HSCard>();
            foreach (var item in Game.GetOpponentMinions().Where(i => !i.CantTarget && !i.Stealth && !i.Immune && i.CheckTag(tag)))
            {
                list.Add(item);
            }
            if (!Game.Opponent.Stealth && !Game.Opponent.Immune && Game.Opponent.CheckTag(tag))
            {
                list.Add(Game.Opponent.Hero);
            }
            return list;
        }
        public static List<HSCard> SpellTargetAll(GameTag tag)
        {
            list = new List<HSCard>();
            foreach (var item in Game.GetOpponentMinions().Where(i => !i.CantTarget && !i.Stealth && !i.Immune && i.CheckTag(tag)))
            {
                list.Add(item);
            }
            if (!Game.Opponent.Stealth && !Game.Opponent.Immune && Game.Opponent.CheckTag(tag))
            {
                list.Add(Game.Opponent.Hero);
            }
            foreach (var item in Game.GetUserMinions().Where(i => !i.CantTarget && !i.Immune && i.CheckTag(tag)))
            {
                list.Add(item);
            }
            if (!Game.User.Immune && Game.User.CheckTag(tag))
            {
                list.Add(Game.User.Hero);
            }
            return list;
        }
        public static List<HSCard> SpellTargetHero(GameTag tag)
        {
            list = new List<HSCard>();
            if (!Game.Opponent.Stealth && !Game.Opponent.Immune && Game.Opponent.CheckTag(tag))
            {
                list.Add(Game.Opponent.Hero);
            }
            if (!Game.User.Immune && Game.User.CheckTag(tag))
            {
                list.Add(Game.User.Hero);
            }
            return list;
        }
        public static List<HSCard> SpellTargetMinionUser(funcBool f)
        {
            list = new List<HSCard>();
            foreach (var item in Game.GetUserMinions().Where(i => !i.CantTarget && !i.Immune && f(i)))
            {
                list.Add(item);
            }
            return list;
        }
        public static List<HSCard> SpellTargetMinionEnemy(funcBool f)
        {
            list = new List<HSCard>();
            foreach (var item in Game.GetOpponentMinions().Where(i => !i.CantTarget && !i.Stealth && !i.Immune && f(i)))
            {
                list.Add(item);
            }
            return list;
        }
        public static List<HSCard> SpellTargetMinionAll(funcBool f)
        {
            list = new List<HSCard>();
            foreach (var item in Game.GetOpponentMinions().Where(i => !i.CantTarget && !i.Stealth && !i.Immune && f(i)))
            {
                list.Add(item);
            }
            foreach (var item in Game.GetUserMinions().Where(i => !i.CantTarget && !i.Immune && f(i)))
            {
                list.Add(item);
            }
            return list;
        }
        public static List<HSCard> SpellTargetUser(funcBool f)
        {
            list = new List<HSCard>();
            foreach (var item in Game.GetUserMinions().Where(i => !i.CantTarget && !i.Immune && f(i)))
            {
                list.Add(item);
            }
            if (!Game.User.Immune && f(Game.User.Hero))
            {
                list.Add(Game.User.Hero);
            }
            return list;
        }
        public static List<HSCard> SpellTargetEnemy(funcBool f)
        {
            list = new List<HSCard>();
            foreach (var item in Game.GetOpponentMinions().Where(i => !i.CantTarget && !i.Stealth && !i.Immune && f(i)))
            {
                list.Add(item);
            }
            if (!Game.Opponent.Stealth && !Game.Opponent.Immune && f(Game.Opponent.Hero))
            {
                list.Add(Game.Opponent.Hero);
            }
            return list;
        }
        public static List<HSCard> SpellTargetAll(funcBool f)
        {
            list = new List<HSCard>();
            foreach (var item in Game.GetOpponentMinions().Where(i => !i.CantTarget && !i.Stealth && !i.Immune && f(i)))
            {
                list.Add(item);
            }
            if (!Game.Opponent.Stealth && !Game.Opponent.Immune && f(Game.Opponent.Hero))
            {
                list.Add(Game.Opponent.Hero);
            }
            foreach (var item in Game.GetUserMinions().Where(i => !i.CantTarget && !i.Immune && f(i)))
            {
                list.Add(item);
            }
            if (!Game.User.Immune && f(Game.User.Hero))
            {
                list.Add(Game.User.Hero);
            }
            return list;
        }
        public static List<HSCard> SpellTargetHero(funcBool f)
        {
            list = new List<HSCard>();
            if (!Game.Opponent.Stealth && !Game.Opponent.Immune && f(Game.Opponent.Hero))
            {
                list.Add(Game.Opponent.Hero);
            }
            if (!Game.User.Immune && f(Game.User.Hero))
            {
                list.Add(Game.User.Hero);
            }
            return list;
        }

        public static List<HSCard> SpellImmuneTargetMinionUser()
        {
            list = new List<HSCard>();
            foreach (var item in Game.GetUserMinions().Where(i => !i.CantTarget))
            {
                list.Add(item);
            }
            return list;
        }
        public static List<HSCard> SpellImmuneTargetMinionEnemy()
        {
            list = new List<HSCard>();
            foreach (var item in Game.GetOpponentMinions().Where(i => !i.CantTarget && !i.Stealth))
            {
                list.Add(item);
            }
            return list;
        }
        public static List<HSCard> SpellImmuneTargetMinionAll()
        {
            list = new List<HSCard>();
            foreach (var item in Game.GetOpponentMinions().Where(i => !i.CantTarget && !i.Stealth))
            {
                list.Add(item);
            }
            foreach (var item in Game.GetUserMinions().Where(i => !i.CantTarget))
            {
                list.Add(item);
            }
            return list;
        }
        public static List<HSCard> SpellImmuneTargetUser()
        {
            list = new List<HSCard>();
            foreach (var item in Game.GetUserMinions().Where(i => !i.CantTarget))
            {
                list.Add(item);
            }
            list.Add(Game.User.Hero);
            return list;
        }
        public static List<HSCard> SpellImmuneTargetEnemy()
        {
            list = new List<HSCard>();
            foreach (var item in Game.GetOpponentMinions().Where(i => !i.CantTarget && !i.Stealth))
            {
                list.Add(item);
            }
            if (!Game.Opponent.Stealth)
            {
                list.Add(Game.Opponent.Hero);
            }
            return list;
        }
        public static List<HSCard> SpellImmuneTargetAll()
        {
            list = new List<HSCard>();
            foreach (var item in Game.GetOpponentMinions().Where(i => !i.CantTarget && !i.Stealth))
            {
                list.Add(item);
            }
            if (!Game.Opponent.Stealth && !Game.Opponent.Immune)
            {
                list.Add(Game.Opponent.Hero);
            }
            foreach (var item in Game.GetUserMinions().Where(i => !i.CantTarget))
            {
                list.Add(item);
            }
            list.Add(Game.User.Hero);

            return list;
        }
        public static List<HSCard> SpellImmuneTargetHero()
        {
            list = new List<HSCard>();
            if (!Game.Opponent.Stealth)
            {
                list.Add(Game.Opponent.Hero);
            }
            list.Add(Game.User.Hero);
            return list;
        }
        public static List<HSCard> SpellImmuneTargetMinionUser(GameTag tag)
        {
            list = new List<HSCard>();
            foreach (var item in Game.GetUserMinions().Where(i => !i.CantTarget && i.CheckTag(tag)))
            {
                list.Add(item);
            }
            return list;
        }
        public static List<HSCard> SpellImmuneTargetMinionEnemy(GameTag tag)
        {
            list = new List<HSCard>();
            foreach (var item in Game.GetOpponentMinions().Where(i => !i.CantTarget && !i.Stealth && i.CheckTag(tag)))
            {
                list.Add(item);
            }
            return list;
        }
        public static List<HSCard> SpellImmuneTargetMinionAll(GameTag tag)
        {
            list = new List<HSCard>();
            foreach (var item in Game.GetOpponentMinions().Where(i => !i.CantTarget && !i.Stealth && i.CheckTag(tag)))
            {
                list.Add(item);
            }
            foreach (var item in Game.GetUserMinions().Where(i => !i.CantTarget && i.CheckTag(tag)))
            {
                list.Add(item);
            }
            return list;
        }
        public static List<HSCard> SpellImmuneTargetUser(GameTag tag)
        {
            list = new List<HSCard>();
            foreach (var item in Game.GetUserMinions().Where(i => !i.CantTarget && i.CheckTag(tag)))
            {
                list.Add(item);
            }
            if (Game.User.CheckTag(tag))
            {
                list.Add(Game.User.Hero);
            }
            return list;
        }
        public static List<HSCard> SpellImmuneTargetEnemy(GameTag tag)
        {
            list = new List<HSCard>();
            foreach (var item in Game.GetOpponentMinions().Where(i => !i.CantTarget && !i.Stealth && i.CheckTag(tag)))
            {
                list.Add(item);
            }
            if (!Game.Opponent.Stealth && Game.Opponent.CheckTag(tag))
            {
                list.Add(Game.Opponent.Hero);
            }
            return list;
        }
        public static List<HSCard> SpellImmuneTargetAll(GameTag tag)
        {
            list = new List<HSCard>();
            foreach (var item in Game.GetOpponentMinions().Where(i => !i.CantTarget && !i.Stealth && i.CheckTag(tag)))
            {
                list.Add(item);
            }
            if (!Game.Opponent.Stealth && Game.Opponent.CheckTag(tag))
            {
                list.Add(Game.Opponent.Hero);
            }
            foreach (var item in Game.GetUserMinions().Where(i => !i.CantTarget && i.CheckTag(tag)))
            {
                list.Add(item);
            }
            if (Game.User.CheckTag(tag))
            {
                list.Add(Game.User.Hero);
            }
            return list;
        }
        public static List<HSCard> SpellImmuneTargetHero(GameTag tag)
        {
            list = new List<HSCard>();
            if (!Game.Opponent.Stealth && Game.Opponent.CheckTag(tag))
            {
                list.Add(Game.Opponent.Hero);
            }
            if (Game.User.CheckTag(tag))
            {
                list.Add(Game.User.Hero);
            }
            return list;
        }
        public static List<HSCard> SpellImmuneTargetMinionUser(funcBool f)
        {
            list = new List<HSCard>();
            foreach (var item in Game.GetUserMinions().Where(i => !i.CantTarget && f(i)))
            {
                list.Add(item);
            }
            return list;
        }
        public static List<HSCard> SpellImmuneTargetMinionEnemy(funcBool f)
        {
            list = new List<HSCard>();
            foreach (var item in Game.GetOpponentMinions().Where(i => !i.CantTarget && !i.Stealth && f(i)))
            {
                list.Add(item);
            }
            return list;
        }
        public static List<HSCard> SpellImmuneTargetMinionAll(funcBool f)
        {
            list = new List<HSCard>();
            foreach (var item in Game.GetOpponentMinions().Where(i => !i.CantTarget && !i.Stealth && f(i)))
            {
                list.Add(item);
            }
            foreach (var item in Game.GetUserMinions().Where(i => !i.CantTarget && f(i)))
            {
                list.Add(item);
            }
            return list;
        }
        public static List<HSCard> SpellImmuneTargetUser(funcBool f)
        {
            list = new List<HSCard>();
            foreach (var item in Game.GetUserMinions().Where(i => !i.CantTarget && f(i)))
            {
                list.Add(item);
            }
            if (f(Game.User.Hero))
            {
                list.Add(Game.User.Hero);
            }
            return list;
        }
        public static List<HSCard> SpellImmuneTargetEnemy(funcBool f)
        {
            list = new List<HSCard>();
            foreach (var item in Game.GetOpponentMinions().Where(i => !i.CantTarget && !i.Stealth && f(i)))
            {
                list.Add(item);
            }
            if (!Game.Opponent.Stealth && f(Game.Opponent.Hero))
            {
                list.Add(Game.Opponent.Hero);
            }
            return list;
        }
        public static List<HSCard> SpellImmuneTargetAll(funcBool f)
        {
            list = new List<HSCard>();
            foreach (var item in Game.GetOpponentMinions().Where(i => !i.CantTarget && !i.Stealth && f(i)))
            {
                list.Add(item);
            }
            if (!Game.Opponent.Stealth && f(Game.Opponent.Hero))
            {
                list.Add(Game.Opponent.Hero);
            }
            foreach (var item in Game.GetUserMinions().Where(i => !i.CantTarget && f(i)))
            {
                list.Add(item);
            }
            if (f(Game.User.Hero))
            {
                list.Add(Game.User.Hero);
            }
            return list;
        }
        public static List<HSCard> SpellImmuneTargetHero(funcBool f)
        {
            list = new List<HSCard>();
            if (!Game.Opponent.Stealth && f(Game.Opponent.Hero))
            {
                list.Add(Game.Opponent.Hero);
            }
            if (f(Game.User.Hero))
            {
                list.Add(Game.User.Hero);
            }
            return list;
        }

        public static List<HSCard> MinionTargetMinionUser()
        {
            list = new List<HSCard>();
            foreach (var item in Game.GetUserMinions().Where(i => !i.Immune))
            {
                list.Add(item);
            }
            return list;
        }
        public static List<HSCard> MinionTargetMinionEnemy()
        {
            list = new List<HSCard>();
            foreach (var item in Game.GetOpponentMinions().Where(i => !i.Stealth && !i.Immune))
            {
                list.Add(item);
            }
            return list;
        }
        public static List<HSCard> MinionTargetMinionAll()
        {
            list = new List<HSCard>();
            foreach (var item in Game.GetOpponentMinions().Where(i => !i.Stealth && !i.Immune))
            {
                list.Add(item);
            }
            foreach (var item in Game.GetUserMinions().Where(i => !i.Immune))
            {
                list.Add(item);
            }
            return list;
        }
        public static List<HSCard> MinionTargetUser()
        {
            list = new List<HSCard>();
            foreach (var item in Game.GetUserMinions().Where(i => !i.Immune))
            {
                list.Add(item);
            }
            if (!Game.User.Immune)
            {
                list.Add(Game.User.Hero);
            }
            return list;
        }
        public static List<HSCard> MinionTargetEnemy()
        {
            list = new List<HSCard>();
            foreach (var item in Game.GetOpponentMinions().Where(i => !i.Stealth && !i.Immune))
            {
                list.Add(item);
            }
            if (!Game.Opponent.Stealth && !Game.Opponent.Immune)
            {
                list.Add(Game.Opponent.Hero);
            }
            return list;
        }
        public static List<HSCard> MinionTargetAll()
        {
            list = new List<HSCard>();
            foreach (var item in Game.GetOpponentMinions().Where(i => !i.Stealth && !i.Immune))
            {
                list.Add(item);
            }
            if (!Game.Opponent.Stealth && !Game.Opponent.Immune)
            {
                list.Add(Game.Opponent.Hero);
            }
            foreach (var item in Game.GetUserMinions().Where(i => !i.Immune))
            {
                list.Add(item);
            }
            if (!Game.User.Immune)
            {
                list.Add(Game.User.Hero);
            }
            return list;
        }
        public static List<HSCard> MinionTargetHero()
        {
            list = new List<HSCard>();
            if (!Game.Opponent.Stealth && !Game.Opponent.Immune)
            {
                list.Add(Game.Opponent.Hero);
            }
            if (!Game.User.Immune)
            {
                list.Add(Game.User.Hero);
            }
            return list;
        }
        public static List<HSCard> MinionTargetMinionUser(GameTag tag)
        {
            list = new List<HSCard>();
            foreach (var item in Game.GetUserMinions().Where(i => !i.Immune && i.CheckTag(tag)))
            {
                list.Add(item);
            }
            return list;
        }
        public static List<HSCard> MinionTargetMinionEnemy(GameTag tag)
        {
            list = new List<HSCard>();
            foreach (var item in Game.GetOpponentMinions().Where(i => !i.Stealth && !i.Immune && i.CheckTag(tag)))
            {
                list.Add(item);
            }
            return list;
        }
        public static List<HSCard> MinionTargetMinionAll(GameTag tag)
        {
            list = new List<HSCard>();
            foreach (var item in Game.GetOpponentMinions().Where(i => !i.Stealth && !i.Immune && i.CheckTag(tag)))
            {
                list.Add(item);
            }
            foreach (var item in Game.GetUserMinions().Where(i => !i.Immune && i.CheckTag(tag)))
            {
                list.Add(item);
            }
            return list;
        }
        public static List<HSCard> MinionTargetUser(GameTag tag)
        {
            list = new List<HSCard>();
            foreach (var item in Game.GetUserMinions().Where(i => !i.Immune && i.CheckTag(tag)))
            {
                list.Add(item);
            }
            if (!Game.User.Immune && Game.User.CheckTag(tag))
            {
                list.Add(Game.User.Hero);
            }
            return list;
        }
        public static List<HSCard> MinionTargetEnemy(GameTag tag)
        {
            list = new List<HSCard>();
            foreach (var item in Game.GetOpponentMinions().Where(i => !i.Stealth && !i.Immune && i.CheckTag(tag)))
            {
                list.Add(item);
            }
            if (!Game.Opponent.Stealth && !Game.Opponent.Immune && Game.Opponent.CheckTag(tag))
            {
                list.Add(Game.Opponent.Hero);
            }
            return list;
        }
        public static List<HSCard> MinionTargetAll(GameTag tag)
        {
            list = new List<HSCard>();
            foreach (var item in Game.GetOpponentMinions().Where(i => !i.Stealth && !i.Immune && i.CheckTag(tag)))
            {
                list.Add(item);
            }
            if (!Game.Opponent.Stealth && !Game.Opponent.Immune && Game.Opponent.CheckTag(tag))
            {
                list.Add(Game.Opponent.Hero);
            }
            foreach (var item in Game.GetUserMinions().Where(i => !i.Immune && i.CheckTag(tag)))
            {
                list.Add(item);
            }
            if (!Game.User.Immune && Game.User.CheckTag(tag))
            {
                list.Add(Game.User.Hero);
            }
            return list;
        }
        public static List<HSCard> MinionTargetHero(GameTag tag)
        {
            list = new List<HSCard>();
            if (!Game.Opponent.Stealth && !Game.Opponent.Immune && Game.Opponent.CheckTag(tag))
            {
                list.Add(Game.Opponent.Hero);
            }
            if (!Game.User.Immune && Game.User.CheckTag(tag))
            {
                list.Add(Game.User.Hero);
            }
            return list;
        }
        public static List<HSCard> MinionTargetMinionUser(funcBool f)
        {
            list = new List<HSCard>();
            foreach (var item in Game.GetUserMinions().Where(i => !i.Immune && f(i)))
            {
                list.Add(item);
            }
            return list;
        }
        public static List<HSCard> MinionTargetMinionEnemy(funcBool f)
        {
            list = new List<HSCard>();
            foreach (var item in Game.GetOpponentMinions().Where(i => !i.Stealth && !i.Immune && f(i)))
            {
                list.Add(item);
            }
            return list;
        }
        public static List<HSCard> MinionTargetMinionAll(funcBool f)
        {
            list = new List<HSCard>();
            foreach (var item in Game.GetOpponentMinions().Where(i => !i.Stealth && !i.Immune && f(i)))
            {
                list.Add(item);
            }
            foreach (var item in Game.GetUserMinions().Where(i => !i.Immune && f(i)))
            {
                list.Add(item);
            }
            return list;
        }
        public static List<HSCard> MinionTargetUser(funcBool f)
        {
            list = new List<HSCard>();
            foreach (var item in Game.GetUserMinions().Where(i => !i.Immune && f(i)))
            {
                list.Add(item);
            }
            if (!Game.User.Immune && f(Game.User.Hero))
            {
                list.Add(Game.User.Hero);
            }
            return list;
        }
        public static List<HSCard> MinionTargetEnemy(funcBool f)
        {
            list = new List<HSCard>();
            foreach (var item in Game.GetOpponentMinions().Where(i => !i.Stealth && !i.Immune && f(i)))
            {
                list.Add(item);
            }
            if (!Game.Opponent.Stealth && !Game.Opponent.Immune && f(Game.Opponent.Hero))
            {
                list.Add(Game.Opponent.Hero);
            }
            return list;
        }
        public static List<HSCard> MinionTargetAll(funcBool f)
        {
            list = new List<HSCard>();
            foreach (var item in Game.GetOpponentMinions().Where(i => !i.Stealth && !i.Immune && f(i)))
            {
                list.Add(item);
            }
            if (!Game.Opponent.Stealth && !Game.Opponent.Immune && f(Game.Opponent.Hero))
            {
                list.Add(Game.Opponent.Hero);
            }
            foreach (var item in Game.GetUserMinions().Where(i => !i.Immune && f(i)))
            {
                list.Add(item);
            }
            if (!Game.User.Immune && f(Game.User.Hero))
            {
                list.Add(Game.User.Hero);
            }
            return list;
        }
        public static List<HSCard> MinionTargetHero(funcBool f)
        {
            list = new List<HSCard>();
            if (!Game.Opponent.Stealth && !Game.Opponent.Immune && f(Game.Opponent.Hero))
            {
                list.Add(Game.Opponent.Hero);
            }
            if (!Game.User.Immune && f(Game.User.Hero))
            {
                list.Add(Game.User.Hero);
            }
            return list;
        }

        public static List<HSCard> MinionImmuneTargetMinionUser()
        {
            list = new List<HSCard>();
            foreach (var item in Game.GetUserMinions())
            {
                list.Add(item);
            }
            return list;
        }
        public static List<HSCard> MinionImmuneTargetMinionEnemy()
        {
            list = new List<HSCard>();
            foreach (var item in Game.GetOpponentMinions().Where(i => !i.Stealth))
            {
                list.Add(item);
            }
            return list;
        }
        public static List<HSCard> MinionImmuneTargetMinionAll()
        {
            list = new List<HSCard>();
            foreach (var item in Game.GetOpponentMinions().Where(i => !i.Stealth))
            {
                list.Add(item);
            }
            foreach (var item in Game.GetUserMinions())
            {
                list.Add(item);
            }
            return list;
        }
        public static List<HSCard> MinionImmuneTargetUser()
        {
            list = new List<HSCard>();
            foreach (var item in Game.GetUserMinions())
            {
                list.Add(item);
            }
            list.Add(Game.User.Hero);

            return list;
        }
        public static List<HSCard> MinionImmuneTargetEnemy()
        {
            list = new List<HSCard>();
            foreach (var item in Game.GetOpponentMinions().Where(i => !i.Stealth))
            {
                list.Add(item);
            }
            if (!Game.Opponent.Stealth)
            {
                list.Add(Game.Opponent.Hero);
            }
            return list;
        }
        public static List<HSCard> MinionImmuneTargetAll()
        {
            list = new List<HSCard>();
            foreach (var item in Game.GetOpponentMinions().Where(i => !i.Stealth))
            {
                list.Add(item);
            }
            if (!Game.Opponent.Stealth)
            {
                list.Add(Game.Opponent.Hero);
            }
            foreach (var item in Game.GetUserMinions())
            {
                list.Add(item);
            }
            list.Add(Game.User.Hero);

            return list;
        }
        public static List<HSCard> MinionImmuneTargetHero()
        {
            list = new List<HSCard>();
            if (!Game.Opponent.Stealth)
            {
                list.Add(Game.Opponent.Hero);
            }
            list.Add(Game.User.Hero);

            return list;
        }
        public static List<HSCard> MinionImmuneTargetMinionUser(GameTag tag)
        {
            list = new List<HSCard>();
            foreach (var item in Game.GetUserMinions().Where(i => i.CheckTag(tag)))
            {
                list.Add(item);
            }
            return list;
        }
        public static List<HSCard> MinionImmuneTargetMinionEnemy(GameTag tag)
        {
            list = new List<HSCard>();
            foreach (var item in Game.GetOpponentMinions().Where(i => !i.Stealth && i.CheckTag(tag)))
            {
                list.Add(item);
            }
            return list;
        }
        public static List<HSCard> MinionImmuneTargetMinionAll(GameTag tag)
        {
            list = new List<HSCard>();
            foreach (var item in Game.GetOpponentMinions().Where(i => !i.Stealth && i.CheckTag(tag)))
            {
                list.Add(item);
            }
            foreach (var item in Game.GetUserMinions().Where(i => i.CheckTag(tag)))
            {
                list.Add(item);
            }
            return list;
        }
        public static List<HSCard> MinionImmuneTargetUser(GameTag tag)
        {
            list = new List<HSCard>();
            foreach (var item in Game.GetUserMinions().Where(i => i.CheckTag(tag)))
            {
                list.Add(item);
            }
            if (Game.User.CheckTag(tag))
            {
                list.Add(Game.User.Hero);
            }
            return list;
        }
        public static List<HSCard> MinionImmuneTargetEnemy(GameTag tag)
        {
            list = new List<HSCard>();
            foreach (var item in Game.GetOpponentMinions().Where(i => !i.Stealth && i.CheckTag(tag)))
            {
                list.Add(item);
            }
            if (!Game.Opponent.Stealth && Game.Opponent.CheckTag(tag))
            {
                list.Add(Game.Opponent.Hero);
            }
            return list;
        }
        public static List<HSCard> MinionImmuneTargetAll(GameTag tag)
        {
            list = new List<HSCard>();
            foreach (var item in Game.GetOpponentMinions().Where(i => !i.Stealth && i.CheckTag(tag)))
            {
                list.Add(item);
            }
            if (!Game.Opponent.Stealth && Game.Opponent.CheckTag(tag))
            {
                list.Add(Game.Opponent.Hero);
            }
            foreach (var item in Game.GetUserMinions().Where(i => i.CheckTag(tag)))
            {
                list.Add(item);
            }
            if (Game.User.CheckTag(tag))
            {
                list.Add(Game.User.Hero);
            }
            return list;
        }
        public static List<HSCard> MinionImmuneTargetHero(GameTag tag)
        {
            list = new List<HSCard>();
            if (!Game.Opponent.Stealth && Game.Opponent.CheckTag(tag))
            {
                list.Add(Game.Opponent.Hero);
            }
            if (Game.User.CheckTag(tag))
            {
                list.Add(Game.User.Hero);
            }
            return list;
        }
        public static List<HSCard> MinionImmuneTargetMinionUser(funcBool f)
        {
            list = new List<HSCard>();
            foreach (var item in Game.GetUserMinions().Where(i => f(i)))
            {
                list.Add(item);
            }
            return list;
        }
        public static List<HSCard> MinionImmuneTargetMinionEnemy(funcBool f)
        {
            list = new List<HSCard>();
            foreach (var item in Game.GetOpponentMinions().Where(i => !i.Stealth && f(i)))
            {
                list.Add(item);
            }
            return list;
        }
        public static List<HSCard> MinionImmuneTargetMinionAll(funcBool f)
        {
            list = new List<HSCard>();
            foreach (var item in Game.GetOpponentMinions().Where(i => !i.Stealth && f(i)))
            {
                list.Add(item);
            }
            foreach (var item in Game.GetUserMinions().Where(i => f(i)))
            {
                list.Add(item);
            }
            return list;
        }
        public static List<HSCard> MinionImmuneTargetUser(funcBool f)
        {
            list = new List<HSCard>();
            foreach (var item in Game.GetUserMinions().Where(i => f(i)))
            {
                list.Add(item);
            }
            if (f(Game.User.Hero))
            {
                list.Add(Game.User.Hero);
            }
            return list;
        }
        public static List<HSCard> MinionImmuneTargetEnemy(funcBool f)
        {
            list = new List<HSCard>();
            foreach (var item in Game.GetOpponentMinions().Where(i => !i.Stealth && f(i)))
            {
                list.Add(item);
            }
            if (!Game.Opponent.Stealth && f(Game.Opponent.Hero))
            {
                list.Add(Game.Opponent.Hero);
            }
            return list;
        }
        public static List<HSCard> MinionImmuneTargetAll(funcBool f)
        {
            list = new List<HSCard>();
            foreach (var item in Game.GetOpponentMinions().Where(i => !i.Stealth && f(i)))
            {
                list.Add(item);
            }
            if (!Game.Opponent.Stealth && f(Game.Opponent.Hero))
            {
                list.Add(Game.Opponent.Hero);
            }
            foreach (var item in Game.GetUserMinions().Where(i => f(i)))
            {
                list.Add(item);
            }
            if (f(Game.User.Hero))
            {
                list.Add(Game.User.Hero);
            }
            return list;
        }
        public static List<HSCard> MinionImmuneTargetHero(funcBool f)
        {
            list = new List<HSCard>();
            if (!Game.Opponent.Stealth && f(Game.Opponent.Hero))
            {
                list.Add(Game.Opponent.Hero);
            }
            if (f(Game.User.Hero))
            {
                list.Add(Game.User.Hero);
            }
            return list;
        }

        public static List<HSCard> HasInHand(funcBool f, Func<List<HSCard>> act)
        {
            if (Game.GetUserHand().Any(i => f(i)))
            {
                return act();
            }
            else
            {
                return new List<HSCard>();
            }
        }
        public static List<HSCard> HasAtleastMinionOnBoard(int i, Func<List<HSCard>> act)
        {
            if (Game.GetUserMinions().Count >= i)
            {
                return act();
            }
            else
            {
                return new List<HSCard>();
            }
        }
        public static List<HSCard> MedivhsValet()
        {
            if (Game.GetUserSecret().Count != 0)
            {
                return MinionTargetAll();
            }
            else
            {
                return new List<HSCard>();
            }
        }
    }
}
