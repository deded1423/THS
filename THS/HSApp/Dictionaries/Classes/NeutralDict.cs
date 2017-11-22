using HearthDb.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using THS.HSApp.Dictionaries.Misc;

namespace THS.HSApp.Dictionaries
{
    class NeutralDict
    {
        private static CardBase foo;
        public static void Update(Dictionary<string, CardBase> Dict)
        {

            CORE(Dict);
            EXPERT(Dict);
            HOF(Dict);
            NAXX(Dict);
            GVG(Dict);
            BRM(Dict);
            TGT(Dict);
            LOE(Dict);
            OG(Dict);
            KARA(Dict);
            GANGS(Dict);
            UNGORO(Dict);
            ICECROWN(Dict);
            TB(Dict);
        }
        public static void CORE(Dictionary<string, CardBase> Dict)
        {
            //Goldshire Footman <b>Taunt</b>
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("CS1_042", foo);
            //Magma Rager 
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("CS2_118", foo);
            //Oasis Snapjaw 
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("CS2_119", foo);
            //River Crocolisk 
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("CS2_120", foo);
            //Frostwolf Grunt <b>Taunt</b>
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("CS2_121", foo);
            //Raid Leader Your other minions have +1 Attack.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("CS2_122", foo);
            //Wolfrider <b>Charge</b>
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("CS2_124", foo);
            //Ironfur Grizzly <b>Taunt</b>
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("CS2_125", foo);
            //Silverback Patriarch <b>Taunt</b>
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("CS2_127", foo);
            //Stormwind Knight <b>Charge</b>
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("CS2_131", foo);
            //Ironforge Rifleman <b>Battlecry:</b> Deal 1 damage.
            foo = new CardBase();
            foo.TargetFunc = Target.MinionImmuneTargetAll;
            foo.PlayFunc = Play.Minion;
            Dict.Add("CS2_141", foo);
            //Kobold Geomancer <b>Spell Damage +1</b>
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("CS2_142", foo);
            //Gnomish Inventor <b>Battlecry:</b> Draw a card.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("CS2_147", foo);
            //Stormpike Commando <b>Battlecry:</b> Deal 2 damage.
            foo = new CardBase();
            foo.TargetFunc = Target.MinionImmuneTargetAll;
            foo.PlayFunc = Play.Minion;
            Dict.Add("CS2_150", foo);
            //Archmage <b>Spell Damage +1</b>
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("CS2_155", foo);
            //Lord of the Arena <b>Taunt</b>
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("CS2_162", foo);
            //Murloc Raider 
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("CS2_168", foo);
            //Stonetusk Boar <b>Charge</b>
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("CS2_171", foo);
            //Bloodfen Raptor 
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("CS2_172", foo);
            //Bluegill Warrior <b>Charge</b>
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("CS2_173", foo);
            //Sen'jin Shieldmasta <b>Taunt</b>
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("CS2_179", foo);
            //Chillwind Yeti 
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("CS2_182", foo);
            //War Golem 
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("CS2_186", foo);
            //Booty Bay Bodyguard <b>Taunt</b>
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("CS2_187", foo);
            //Elven Archer <b>Battlecry:</b> Deal 1 damage.
            foo = new CardBase();
            foo.TargetFunc = Target.MinionImmuneTargetAll;
            foo.PlayFunc = Play.Minion;
            Dict.Add("CS2_189", foo);
            //Razorfen Hunter <b>Battlecry:</b> Summon a 1/1 Boar.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("CS2_196", foo);
            //Ogre Magi <b>Spell Damage +1</b>
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("CS2_197", foo);
            //Boulderfist Ogre 
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("CS2_200", foo);
            //Core Hound 
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("CS2_201", foo);
            //Reckless Rocketeer <b>Charge</b>
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("CS2_213", foo);
            //Stormwind Champion Your other minions have +1/+1.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("CS2_222", foo);
            //Frostwolf Warlord <b>Battlecry:</b> Gain +1/+1 for each other friendly minion on the battlefield.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("CS2_226", foo);
            //Boar 
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("CS2_boar", foo);
            //Sheep 
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("CS2_tk1", foo);
            //Darkscale Healer <b>Battlecry:</b> Restore 2 Health to all friendly characters.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("DS1_055", foo);
            //Voodoo Doctor <b>Battlecry:</b> Restore 2 Health.
            foo = new CardBase();
            foo.TargetFunc = Target.MinionImmuneTargetAll;
            foo.PlayFunc = Play.Minion;
            Dict.Add("EX1_011", foo);
            //Novice Engineer <b>Battlecry:</b> Draw a card.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("EX1_015", foo);
            //Shattered Sun Cleric <b>Battlecry:</b> Give a friendly minion +1/+1.
            foo = new CardBase();
            foo.TargetFunc = Target.MinionImmuneTargetMinionUser;
            foo.PlayFunc = Play.Minion;
            Dict.Add("EX1_019", foo);
            //Dragonling Mechanic <b>Battlecry:</b> Summon a 2/1 Mechanical Dragonling.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("EX1_025", foo);
            //Mechanical Dragonling 
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("EX1_025t", foo);
            //Acidic Swamp Ooze <b>Battlecry:</b> Destroy your opponent's weapon.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("EX1_066", foo);
            //Gurubashi Berserker Whenever this minion takes damage, gain +3 Attack.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("EX1_399", foo);
            //Murloc Tidehunter <b>Battlecry:</b> Summon a 1/1 Murloc Scout.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("EX1_506", foo);
            //Murloc Scout 
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("EX1_506a", foo);
            //Grimscale Oracle Your other Murlocs have +1 Attack.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("EX1_508", foo);
            //Dalaran Mage <b>Spell Damage +1</b>
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("EX1_582", foo);
            //Nightblade <b>Battlecry: </b>Deal 3 damage to the enemy hero.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("EX1_593", foo);
            //Avatar of the Coin <i>You lost the coin flip, but gained a friend.</i>
            foo = new CardBase();
            Dict.Add("GAME_002", foo);
            //The Coin Gain 1 Mana Crystal this turn only.
            foo = new CardBase();
            Dict.Add("GAME_005", foo);
            //NOOOOOOOOOOOO Somehow, the card you USED to have has been deleted.  Here, have this one instead!
            foo = new CardBase();
            Dict.Add("GAME_006", foo);
            //Frog <b>Taunt</b>
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("hexfrog", foo);
            //Skeleton <b></b>
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("skele11", foo);

        }
        public static void EXPERT(Dictionary<string, CardBase> Dict)
        {
            //Fen Creeper <b>Taunt</b>
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("CS1_069", foo);
            //Earthen Ring Farseer <b>Battlecry:</b> Restore 3 Health.
            foo = new CardBase();
            foo.TargetFunc = Target.MinionImmuneTargetAll;
            foo.PlayFunc = Play.Minion;
            Dict.Add("CS2_117", foo);
            //Southsea Deckhand Has <b>Charge</b> while you have a weapon equipped.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("CS2_146", foo);
            //Silver Hand Knight <b>Battlecry:</b> Summon a 2/2 Squire.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("CS2_151", foo);
            //Squire 
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("CS2_152", foo);
            //Ravenholdt Assassin <b>Stealth</b>
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("CS2_161", foo);
            //Young Dragonhawk <b>Windfury</b>
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("CS2_169", foo);
            //Injured Blademaster <b>Battlecry:</b> Deal 4 damage to HIMSELF.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("CS2_181", foo);
            //Abusive Sergeant <b>Battlecry:</b> Give a minion +2 Attack this turn.
            foo = new CardBase();
            foo.TargetFunc = Target.MinionImmuneTargetMinionAll;
            foo.PlayFunc = Play.Minion;
            Dict.Add("CS2_188", foo);
            //Ironbeak Owl <b>Battlecry:</b> <b>Silence</b> a minion.
            foo = new CardBase();
            foo.TargetFunc = Target.MinionImmuneTargetMinionAll;
            foo.PlayFunc = Play.Minion;
            Dict.Add("CS2_203", foo);
            //Spiteful Smith <b>Enrage:</b> Your weapon has +2 Attack.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("CS2_221", foo);
            //Venture Co. Mercenary Your minions cost (3) more.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("CS2_227", foo);
            //Wisp 
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("CS2_231", foo);
            //Whelp 
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("ds1_whelptoken", foo);
            //Lightwarden Whenever a character is healed, gain +2 Attack.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("EX1_001", foo);
            //The Black Knight <b>Battlecry:</b> Destroy an enemy minion with <b>Taunt</b>.
            foo = new CardBase();
            foo.TargetFunc = () => Target.MinionImmuneTargetMinionEnemy(HearthDb.Enums.GameTag.TAUNT);
            foo.PlayFunc = Play.Minion;
            Dict.Add("EX1_002", foo);
            //Young Priestess At the end of your turn, give another random friendly minion +1 Health.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("EX1_004", foo);
            //Big Game Hunter <b>Battlecry:</b> Destroy a minion with 7 or more Attack.
            foo = new CardBase();
            foo.TargetFunc = () => Target.MinionImmuneTargetMinionAll((card) => card.Attack >= 7);
            foo.PlayFunc = Play.Minion;
            Dict.Add("EX1_005", foo);
            //Alarm-o-Bot [x]At the start of your turn, swap this minion with a random one in your hand.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("EX1_006", foo);
            //Acolyte of Pain Whenever this minion takes damage, draw a card.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("EX1_007", foo);
            //Argent Squire <b>Divine Shield</b>
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("EX1_008", foo);
            //Angry Chicken <b>Enrage:</b> +5 Attack.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("EX1_009", foo);
            //Worgen Infiltrator <b>Stealth</b>
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("EX1_010", foo);
            //Bloodmage Thalnos <b>Spell Damage +1</b>. <b>Deathrattle:</b> Draw a card.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("EX1_012", foo);
            //King Mukla <b>Battlecry:</b> Give your opponent 2 Bananas.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("EX1_014", foo);
            //Bananas Give a minion +1/+1.
            foo = new CardBase();
            foo.TargetFunc = Target.SpellImmuneTargetMinionAll;
            foo.PlayFunc = Play.SpellImmuneTargetMinionAll;
            Dict.Add("EX1_014t", foo);
            //Jungle Panther <b>Stealth</b>
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("EX1_017", foo);
            //Scarlet Crusader <b>Divine Shield</b>
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("EX1_020", foo);
            //Thrallmar Farseer <b>Windfury</b>
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("EX1_021", foo);
            //Silvermoon Guardian <b>Divine Shield</b>
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("EX1_023", foo);
            //Stranglethorn Tiger <b>Stealth</b>
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("EX1_028", foo);
            //Leper Gnome <b>Deathrattle:</b> Deal 2 damage to the enemy hero.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("EX1_029", foo);
            //Sunwalker <b>Taunt</b> <b> Divine Shield </b>
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("EX1_032", foo);
            //Windfury Harpy <b>Windfury</b>
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("EX1_033", foo);
            //Twilight Drake <b>Battlecry:</b> Gain +1 Health for each card in your hand.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("EX1_043", foo);
            //Questing Adventurer Whenever you play a card, gain +1/+1.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("EX1_044", foo);
            //Ancient Watcher Can't attack.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("EX1_045", foo);
            //Dark Iron Dwarf <b>Battlecry:</b> Give a minion +2 Attack this turn.
            foo = new CardBase();
            foo.TargetFunc = Target.MinionImmuneTargetMinionAll;
            foo.PlayFunc = Play.Minion;
            Dict.Add("EX1_046", foo);
            //Spellbreaker <b>Battlecry:</b> <b>Silence</b> a minion.
            foo = new CardBase();
            foo.TargetFunc = Target.MinionImmuneTargetMinionAll;
            foo.PlayFunc = Play.Minion;
            Dict.Add("EX1_048", foo);
            //Youthful Brewmaster <b>Battlecry:</b> Return a friendly minion from the battlefield to your hand.
            foo = new CardBase();
            foo.TargetFunc = Target.MinionImmuneTargetMinionUser;
            foo.PlayFunc = Play.Minion;
            Dict.Add("EX1_049", foo);
            //Coldlight Oracle <b>Battlecry:</b> Each player draws 2 cards.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("EX1_050", foo);
            //Mana Addict Whenever you cast a spell, gain +2 Attack this turn.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("EX1_055", foo);
            //Ancient Brewmaster <b>Battlecry:</b> Return a friendly minion from the battlefield to your hand.
            foo = new CardBase();
            foo.TargetFunc = Target.MinionImmuneTargetMinionUser;
            foo.PlayFunc = Play.Minion;
            Dict.Add("EX1_057", foo);
            //Sunfury Protector <b>Battlecry:</b> Give adjacent minions <b>Taunt</b>.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("EX1_058", foo);
            //Crazed Alchemist <b>Battlecry:</b> Swap the Attack and Health of a minion.
            foo = new CardBase();
            foo.TargetFunc = Target.MinionImmuneTargetMinionAll;
            foo.PlayFunc = Play.Minion;
            Dict.Add("EX1_059", foo);
            //Argent Commander <b>Charge</b> <b> Divine Shield </b>
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("EX1_067", foo);
            //Pint-Sized Summoner The first minion you play each turn costs (1) less.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("EX1_076", foo);
            //Secretkeeper Whenever a <b>Secret</b> is played, gain +1/+1.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("EX1_080", foo);
            //Mad Bomber <b>Battlecry:</b> Deal 3 damage randomly split between all other characters.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("EX1_082", foo);
            //Tinkmaster Overspark [x]<b>Battlecry:</b> Transform another random minion into a 5 / 5 Devilsaur or a 1 / 1 Squirrel.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("EX1_083", foo);
            //Mind Control Tech [x]<b>Battlecry:</b> If your opponent has 4 or more minions, take control of one at random.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("EX1_085", foo);
            //Arcane Golem <b>Battlecry:</b> Give your opponent a Mana Crystal.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("EX1_089", foo);
            //Defender of Argus <b>Battlecry:</b> Give adjacent minions +1/+1 and <b>Taunt</b>.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("EX1_093", foo);
            //Gadgetzan Auctioneer Whenever you cast a spell, draw a card.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("EX1_095", foo);
            //Loot Hoarder <b>Deathrattle:</b> Draw a card.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("EX1_096", foo);
            //Abomination <b>Taunt</b>. <b>Deathrattle:</b> Deal 2 damage to ALL characters.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("EX1_097", foo);
            //Lorewalker Cho Whenever a player casts a spell, put a copy into the other player’s hand.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("EX1_100", foo);
            //Demolisher At the start of your turn, deal 2 damage to a random enemy.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("EX1_102", foo);
            //Coldlight Seer <b>Battlecry:</b> Give your other Murlocs +2 Health.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("EX1_103", foo);
            //Mountain Giant Costs (1) less for each other card in your hand.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("EX1_105", foo);
            //Cairne Bloodhoof <b>Deathrattle:</b> Summon a 4/5 Baine Bloodhoof.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("EX1_110", foo);
            //Baine Bloodhoof 
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("EX1_110t", foo);
            //Leeroy Jenkins <b>Charge</b>. <b>Battlecry:</b> Summon two 1/1 Whelps for your opponent.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("EX1_116", foo);
            //Whelp 
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("EX1_116t", foo);
            //Dire Wolf Alpha Adjacent minions have +1 Attack.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("EX1_162", foo);
            //Emperor Cobra <b>Poisonous</b>
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("EX1_170", foo);
            //Baron Geddon At the end of your turn, deal 2 damage to ALL other characters.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("EX1_249", foo);
            //Frost Elemental <b>Battlecry:</b> <b>Freeze</b> a character.
            foo = new CardBase();
            foo.TargetFunc = Target.MinionImmuneTargetAll;
            foo.PlayFunc = Play.Minion;
            Dict.Add("EX1_283", foo);
            //Tauren Warrior <b>Taunt</b> <b> Enrage:</b> +3 Attack.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("EX1_390", foo);
            //Amani Berserker <b>Enrage:</b> +3 Attack
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("EX1_393", foo);
            //Mogu'shan Warden <b>Taunt</b>
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("EX1_396", foo);
            //Shieldbearer <b>Taunt</b>
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("EX1_405", foo);
            //Raging Worgen <b>Enrage:</b> <b>Windfury</b> and +1 Attack.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("EX1_412", foo);
            //Murloc Warleader Your other Murlocs have +2 Attack.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("EX1_507", foo);
            //Murloc Tidecaller Whenever you summon a Murloc, gain +1 Attack.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("EX1_509", foo);
            //Harvest Golem <b>Deathrattle:</b> Summon a 2/1 Damaged Golem.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("EX1_556", foo);
            //Nat Pagle At the start of your turn, you have a 50% chance to draw an extra card.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("EX1_557", foo);
            //Harrison Jones <b>Battlecry:</b> Destroy your opponent's weapon and draw cards equal to its Durability.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("EX1_558", foo);
            //Nozdormu Players only have 15 seconds to take their turns.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("EX1_560", foo);
            //Alexstrasza <b>Battlecry:</b> Set a hero's remaining Health to 15.
            foo = new CardBase();
            foo.TargetFunc = Target.MinionImmuneTargetHero;
            foo.PlayFunc = Play.Minion;
            Dict.Add("EX1_561", foo);
            //Onyxia <b>Battlecry:</b> Summon 1/1 Whelps until your side of the battlefield is full.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("EX1_562", foo);
            //Malygos <b>Spell Damage +5</b>
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("EX1_563", foo);
            //Faceless Manipulator <b>Battlecry:</b> Choose a minion and become a copy of it.
            foo = new CardBase();
            foo.TargetFunc = Target.MinionImmuneTargetMinionAll;
            foo.PlayFunc = Play.Minion;
            Dict.Add("EX1_564", foo);
            //Ysera At the end of your turn, add a Dream Card to your hand.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("EX1_572", foo);
            //The Beast <b>Deathrattle:</b> Summon a 3/3 Finkle Einhorn for your opponent.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("EX1_577", foo);
            //Priestess of Elune <b>Battlecry:</b> Restore 4 Health to your hero.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("EX1_583", foo);
            //Ancient Mage <b>Battlecry:</b> Give adjacent minions <b>Spell Damage +1</b>.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("EX1_584", foo);
            //Sea Giant Costs (1) less for each other minion on the battlefield.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("EX1_586", foo);
            //Blood Knight <b>Battlecry:</b> All minions lose <b>Divine Shield</b>. Gain +3/+3 for each Shield lost.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("EX1_590", foo);
            //Cult Master Whenever one of your other minions dies, draw a card.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("EX1_595", foo);
            //Imp Master [x]At the end of your turn, deal 1 damage to this minion and summon a 1 / 1 Imp.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("EX1_597", foo);
            //Imp 
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("EX1_598", foo);
            //Illidan Stormrage Whenever you play a card, summon a 2/1 Flame of Azzinoth.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("EX1_614", foo);
            //Flame of Azzinoth 
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("EX1_614t", foo);
            //Mana Wraith ALL minions cost (1) more.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("EX1_616", foo);
            //Molten Giant Costs (1) less for each damage your hero has taken.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("EX1_620", foo);
            //Finkle Einhorn 
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("EX1_finkle", foo);
            //Squirrel 
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("EX1_tk28", foo);
            //Devilsaur 
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("EX1_tk29", foo);
            //Hungry Crab <b>Battlecry:</b> Destroy a Murloc and gain +2/+2.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("NEW1_017", foo);
            //Bloodsail Raider <b>Battlecry:</b> Gain Attack equal to the Attack of your weapon.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("NEW1_018", foo);
            //Knife Juggler [x]After you summon a minion, deal 1 damage to a random enemy.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("NEW1_019", foo);
            //Wild Pyromancer After you cast a spell, deal 1 damage to ALL minions.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("NEW1_020", foo);
            //Doomsayer At the start of your turn, destroy ALL minions.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("NEW1_021", foo);
            //Dread Corsair <b>Taunt</b> Costs(1) less per Attack ofyour weapon.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("NEW1_022", foo);
            //Faerie Dragon Can't be targeted by spells or Hero Powers.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("NEW1_023", foo);
            //Captain Greenskin <b>Battlecry:</b> Give your weapon +1/+1.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("NEW1_024", foo);
            //Bloodsail Corsair [x]<b>Battlecry:</b> Remove  1 Durability from your opponent's weapon.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("NEW1_025", foo);
            //Violet Teacher Whenever you cast a spell, summon a 1/1 Violet Apprentice.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("NEW1_026", foo);
            //Violet Apprentice 
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("NEW1_026t", foo);
            //Southsea Captain Your other Pirates have +1/+1.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("NEW1_027", foo);
            //Millhouse Manastorm <b>Battlecry:</b> Enemy spells cost (0) next turn.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("NEW1_029", foo);
            //Deathwing <b>Battlecry:</b> Destroy all other minions and discard your hand.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("NEW1_030", foo);
            //Master Swordsmith At the end of your turn, give another random friendly minion +1 Attack.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("NEW1_037", foo);
            //Gruul At the end of each turn, gain +1/+1 .
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("NEW1_038", foo);
            //Hogger At the end of your turn, summon a 2/2 Gnoll with <b>Taunt</b>.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("NEW1_040", foo);
            //Gnoll <b>Taunt</b>
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("NEW1_040t", foo);
            //Stampeding Kodo <b>Battlecry:</b> Destroy a random enemy minion with 2 or less Attack.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("NEW1_041", foo);
            //Damaged Golem 
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("skele21", foo);
            //Flesheating Ghoul Whenever a minion dies, gain +1 Attack.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("tt_004", foo);

        }
        public static void HOF(Dictionary<string, CardBase> Dict)
        {
            //Sylvanas Windrunner <b>Deathrattle:</b> Take control of a random enemy minion.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("EX1_016", foo);
            //Old Murk-Eye <b>Charge</b>. Has +1 Attack for each other Murloc on the battlefield.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("EX1_062", foo);
            //Gelbin Mekkatorque <b>Battlecry:</b> Summon an AWESOME invention.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("EX1_112", foo);
            //Azure Drake <b>Spell Damage +1</b>. <b>Battlecry:</b> Draw a card.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("EX1_284", foo);
            //Ragnaros the Firelord Can't attack. At the end of your turn, deal 8 damage to a random enemy.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("EX1_298", foo);
            //Homing Chicken At the start of your turn, destroy this minion and draw 3 cards.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("Mekka1", foo);
            //Repair Bot At the end of your turn, restore 6 Health to a damaged character.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("Mekka2", foo);
            //Emboldener 3000 At the end of your turn, give a random minion +1/+1.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("Mekka3", foo);
            //Poultryizer At the start of your turn, transform a random minion into a 1/1 Chicken.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("Mekka4", foo);
            //Chicken <i>Hey Chicken!</i>
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("Mekka4t", foo);
            //Captain's Parrot <b>Battlecry:</b> Draw a Pirate from your deck.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("NEW1_016", foo);
            //Elite Tauren Chieftain <b>Battlecry:</b> Give both players the power to ROCK! (with a Power Chord card)
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("PRO_001", foo);
            //I Am Murloc Summon three, four, or five 1/1 Murlocs.
            foo = new CardBase();
            foo.PlayFunc = Play.SpellSummonMinion;
            Dict.Add("PRO_001a", foo);
            //Murloc 
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("PRO_001at", foo);
            //Rogues Do It... Deal $4 damage. Draw a card.
            foo = new CardBase();
            foo.PlayFunc = Play.SpellTargetAll;
            Dict.Add("PRO_001b", foo);
            //Power of the Horde Summon a random Horde Warrior.
            foo = new CardBase();
            foo.PlayFunc = Play.SpellSummonMinion;
            Dict.Add("PRO_001c", foo);

        }
        public static void NAXX(Dictionary<string, CardBase> Dict)
        {
            //Zombie Chow <b>Deathrattle:</b> Restore 5 Health to the enemy hero.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("FP1_001", foo);
            //Haunted Creeper <b>Deathrattle:</b> Summon two 1/1 Spectral Spiders.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("FP1_002", foo);
            //Spectral Spider 
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("FP1_002t", foo);
            //Echoing Ooze <b>Battlecry:</b> Summon an exact copy of this minion at the end of the turn.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("FP1_003", foo);
            //Mad Scientist <b>Deathrattle:</b> Put a <b>Secret</b> from your deck into the battlefield.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("FP1_004", foo);
            //Shade of Naxxramas <b>Stealth.</b> At the start of your turn, gain +1/+1.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("FP1_005", foo);
            //Deathcharger <b>Charge. Deathrattle:</b> Deal 3 damage to your hero.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("FP1_006", foo);
            //Nerubian Egg <b>Deathrattle:</b> Summon a 4/4 Nerubian.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("FP1_007", foo);
            //Nerubian 
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("FP1_007t", foo);
            //Spectral Knight Can't be targeted by spells or Hero Powers.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("FP1_008", foo);
            //Deathlord <b>Taunt. Deathrattle:</b> Your opponent puts a minion from their deck into the battlefield.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("FP1_009", foo);
            //Maexxna <b>Poisonous</b>
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("FP1_010", foo);
            //Sludge Belcher <b>Taunt Deathrattle:</ b > Summon a 1 / 2 Slime with < b > Taunt </ b >.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("FP1_012", foo);
            //Slime <b>Taunt</b>
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("FP1_012t", foo);
            //Kel'Thuzad At the end of each turn, summon all friendly minions that died this turn.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("FP1_013", foo);
            //Stalagg <b>Deathrattle:</b> If Feugen also died this game, summon Thaddius.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("FP1_014", foo);
            //Thaddius 
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("FP1_014t", foo);
            //Feugen <b>Deathrattle:</b> If Stalagg also died this game, summon Thaddius.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("FP1_015", foo);
            //Wailing Soul <b>Battlecry: Silence</b> your other minions.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("FP1_016", foo);
            //Nerub'ar Weblord Minions with <b>Battlecry</b> cost (2) more.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("FP1_017", foo);
            //Unstable Ghoul <b>Taunt</b>. <b>Deathrattle:</b> Deal 1 damage to all minions.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("FP1_024", foo);
            //Stoneskin Gargoyle At the start of your turn, restore this minion to full Health.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("FP1_027", foo);
            //Undertaker Whenever you summon a minion with <b>Deathrattle</b>, gain +1 Attack.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("FP1_028", foo);
            //Dancing Swords <b>Deathrattle:</b> Your opponent draws a card.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("FP1_029", foo);
            //Loatheb <b>Battlecry:</b> Enemy spells cost (5) more next turn.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("FP1_030", foo);
            //Baron Rivendare Your minions trigger their <b>Deathrattles</b> twice.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("FP1_031", foo);

            //Patchwerk 
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("NAX10_01", foo);
            //Patchwerk 
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("NAX10_01H", foo);
            //Hook <b>Deathrattle:</b> Put this weapon into your hand.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("NAX10_02", foo);
            //Hook <b>Windfury</b> < b > Deathrattle:</ b > Put this weapon into your hand.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("NAX10_02H", foo);
            //Hateful Strike <b>Hero Power</b> Destroy a minion.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("NAX10_03", foo);
            //Hateful Strike <b>Hero Power</b> Destroy a minion.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("NAX10_03H", foo);
            //Grobbulus 
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("NAX11_01", foo);
            //Grobbulus 
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("NAX11_01H", foo);
            //Poison Cloud <b>Hero Power</b> Deal 1 damage to all minions. If any die, summon a slime.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("NAX11_02", foo);
            //Poison Cloud <b>Hero Power</b> Deal 2 damage to all enemies. If any die, summon a slime.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("NAX11_02H", foo);
            //Fallout Slime 
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("NAX11_03", foo);
            //Mutating Injection Give a minion +4/+4 and <b>Taunt</b>.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("NAX11_04", foo);
            //Gluth 
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("NAX12_01", foo);
            //Gluth 
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("NAX12_01H", foo);
            //Decimate <b>Hero Power</b> Change the Health of all minions to 1.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("NAX12_02", foo);
            //Decimate <b>Hero Power</b> Change the Health of enemy minions to 1.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("NAX12_02H", foo);
            //Jaws Whenever a minion with <b>Deathrattle</b> dies, gain +2 Attack.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("NAX12_03", foo);
            //Jaws Whenever a minion with <b>Deathrattle</b> dies, gain +2 Attack.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("NAX12_03H", foo);
            //Enrage Give your hero +6 Attack this turn.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("NAX12_04", foo);
            //Thaddius 
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("NAX13_01", foo);
            //Thaddius 
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("NAX13_01H", foo);
            //Polarity Shift <b>Hero Power</b> Swap the Attack and Health of all minions.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("NAX13_02", foo);
            //Supercharge Give your minions +2 Health.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("NAX13_03", foo);
            //Feugen 
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("NAX13_04H", foo);
            //Stalagg 
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("NAX13_05H", foo);
            //Sapphiron 
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("NAX14_01", foo);
            //Sapphiron 
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("NAX14_01H", foo);
            //Frost Breath <b>Hero Power</b> Destroy all enemy minions that aren't <b>Frozen</b>.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("NAX14_02", foo);
            //Frozen Champion Permanently Frozen.  Adjacent minions are Immune to Frost Breath.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("NAX14_03", foo);
            //Pure Cold Deal $8 damage to the enemy hero, and <b>Freeze</b> it.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("NAX14_04", foo);
            //Kel'Thuzad 
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("NAX15_01", foo);
            //Kel'Thuzad 
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("NAX15_01H", foo);
            //Frost Blast <b>Hero Power</b> Deal 2 damage to the enemy hero and < b > Freeze </ b > it.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("NAX15_02", foo);
            //Frost Blast <b>Hero Power</b> Deal 3 damage to the enemy hero and < b > Freeze </ b > it.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("NAX15_02H", foo);
            //Guardian of Icecrown <b>Taunt</b>
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("NAX15_03n", foo);
            //Guardian of Icecrown <b>Taunt</b>
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("NAX15_03t", foo);
            //Chains <b>Hero Power</b> Take control of a random enemy minion until end of turn.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("NAX15_04", foo);
            //Chains <b>Hero Power</b> Take control of a random enemy minion.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("NAX15_04H", foo);
            //Mr. Bigglesworth <i>This is Kel'Thuzad's kitty.</i>
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("NAX15_05", foo);
            //Anub'Rekhan 
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("NAX1_01", foo);
            //Nerubian 
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("NAX1_03", foo);
            //Skitter <b>Hero Power</b> Summon a 3 / 1 Nerubian.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("NAX1_04", foo);
            //Locust Swarm Deal $3 damage to all enemy minions. Restore #3 Health to your hero.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("NAX1_05", foo);
            //Anub'Rekhan 
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("NAX1h_01", foo);
            //Nerubian 
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("NAX1h_03", foo);
            //Skitter <b>Hero Power</b> Summon a 4 / 4 Nerubian.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("NAX1h_04", foo);
            //Grand Widow Faerlina 
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("NAX2_01", foo);
            //Grand Widow Faerlina 
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("NAX2_01H", foo);
            //Rain of Fire <b>Hero Power</b> Fire a missile for each card in your opponent's hand.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("NAX2_03", foo);
            //Rain of Fire <b>Hero Power</b> Fire a missile for each card in your opponent's hand.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("NAX2_03H", foo);
            //Worshipper Your hero has +1 Attack on your turn.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("NAX2_05", foo);
            //Worshipper Your hero has +3 Attack on your turn.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("NAX2_05H", foo);
            //Maexxna 
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("NAX3_01", foo);
            //Maexxna 
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("NAX3_01H", foo);
            //Web Wrap <b>Hero Power</b> Return a random enemy minion to your opponent's hand.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("NAX3_02", foo);
            //Web Wrap <b>Hero Power</b> Return 2 random enemy minions to your opponent's hand.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("NAX3_02H", foo);
            //Necrotic Poison Destroy a minion.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("NAX3_03", foo);
            //Skeleton 
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("NAX4_03", foo);
            //Skeleton 
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("NAX4_03H", foo);
            //Raise Dead <b>Passive Hero Power</b> Whenever an enemy dies, raise a 1 / 1 Skeleton.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("NAX4_04", foo);
            //Raise Dead <b>Passive Hero Power</b> Whenever an enemy dies, raise a 5 / 5 Skeleton.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("NAX4_04H", foo);
            //Plague Destroy all non-Skeleton minions.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("NAX4_05", foo);
            //Eruption <b>Hero Power</b> Deal 2 damage to the left-most enemy minion.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("NAX5_02", foo);
            //Eruption <b>Hero Power</b> Deal 3 damage to the left-most enemy minion.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("NAX5_02H", foo);
            //Mindpocalypse Both players draw 2 cards and gain a Mana Crystal.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("NAX5_03", foo);
            //Loatheb 
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("NAX6_01", foo);
            //Loatheb 
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("NAX6_01H", foo);
            //Necrotic Aura <b>Hero Power</b> Deal 3 damage to the enemy hero.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("NAX6_02", foo);
            //Necrotic Aura <b>Hero Power</b>  Deal 3 damage to the enemy hero.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("NAX6_02H", foo);
            //Deathbloom Deal $5 damage to a minion. Summon a Spore.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("NAX6_03", foo);
            //Spore <b>Deathrattle:</b> Give all enemy minions +8 Attack.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("NAX6_03t", foo);
            //Sporeburst Deal $1 damage to all enemy minions. Summon a Spore.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("NAX6_04", foo);
            //Instructor Razuvious 
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("NAX7_01", foo);
            //Instructor Razuvious 
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("NAX7_01H", foo);
            //Understudy <b>Taunt</b>
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("NAX7_02", foo);
            //Unbalancing Strike <b>Hero Power</b> Deal 3 damage.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("NAX7_03", foo);
            //Unbalancing Strike <b>Hero Power</b> Deal 4 damage.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("NAX7_03H", foo);
            //Massive Runeblade Deals double damage to heroes.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("NAX7_04", foo);
            //Massive Runeblade Deals double damage to heroes.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("NAX7_04H", foo);
            //Mind Control Crystal Activate the Crystal to control the Understudies!
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("NAX7_05", foo);
            //Gothik the Harvester 
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("NAX8_01", foo);
            //Gothik the Harvester 
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("NAX8_01H", foo);
            //Harvest <b>Hero Power</b> Draw a card.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("NAX8_02", foo);
            //Harvest <b>Hero Power</b> Draw a card.Gain a Mana Crystal.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("NAX8_02H", foo);
            //Unrelenting Trainee <b>Deathrattle:</b> Summon a Spectral Trainee for your opponent.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("NAX8_03", foo);
            //Spectral Trainee At the start of your turn, deal 1 damage to your hero.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("NAX8_03t", foo);
            //Unrelenting Warrior <b>Deathrattle:</b> Summon a Spectral Warrior for your opponent.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("NAX8_04", foo);
            //Spectral Warrior At the start of your turn, deal 1 damage to your hero.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("NAX8_04t", foo);
            //Unrelenting Rider <b>Deathrattle:</b> Summon a Spectral Rider for your opponent.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("NAX8_05", foo);
            //Spectral Rider At the start of your turn, deal 1 damage to your hero.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("NAX8_05t", foo);
            //Baron Rivendare 
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("NAX9_01", foo);
            //Baron Rivendare 
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("NAX9_01H", foo);
            //Lady Blaumeux Your hero is <b>Immune</b>.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("NAX9_02", foo);
            //Lady Blaumeux Your hero is <b>Immune</b>.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("NAX9_02H", foo);
            //Thane Korth'azz Your hero is <b>Immune</b>.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("NAX9_03", foo);
            //Thane Korth'azz Your hero is <b>Immune</b>.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("NAX9_03H", foo);
            //Sir Zeliek Your hero is <b>Immune</b>.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("NAX9_04", foo);
            //Sir Zeliek Your hero is <b>Immune</b>.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("NAX9_04H", foo);
            //Runeblade Has +3 Attack if the other Horsemen are dead.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("NAX9_05", foo);
            //Runeblade Has +6 Attack if the other Horsemen are dead.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("NAX9_05H", foo);
            //Unholy Shadow <b>Hero Power</b> Draw 2 cards.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("NAX9_06", foo);
            //Mark of the Horsemen Give your minions and your weapon +1/+1.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("NAX9_07", foo);
            //Necroknight <b>Deathrattle:</b> Destroy the minions next to this one as well.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("NAXM_001", foo);
            //Skeletal Smith <b>Deathrattle:</b> Destroy your opponent's weapon.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("NAXM_002", foo);

        }
        public static void GVG(Dictionary<string, CardBase> Dict)
        {
            //Mechwarper Your Mechs cost (1) less.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("GVG_006", foo);
            //Cogmaster Has +2 Attack while you have a Mech.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("GVG_013", foo);
            //Fel Reaver Whenever your opponent plays a card, remove the top 3 cards of your deck.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("GVG_016", foo);
            //Gallywix's Coin Gain 1 Mana Crystal this turn only. < i > (Won't trigger Gallywix.)</i>
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("GVG_028t", foo);
            //Spider Tank 
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("GVG_044", foo);
            //Puddlestomper 
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("GVG_064", foo);
            //Ogre Brute 50% chance to attack the wrong enemy.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("GVG_065", foo);
            //Stonesplinter Trogg Whenever your opponent casts a spell, gain +1 Attack.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("GVG_067", foo);
            //Burly Rockjaw Trogg Whenever your opponent casts a spell, gain +2 Attack.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("GVG_068", foo);
            //Antique Healbot <b>Battlecry:</b> Restore 8 Health to your hero.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("GVG_069", foo);
            //Salty Dog 
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("GVG_070", foo);
            //Lost Tallstrider 
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("GVG_071", foo);
            //Kezan Mystic <b>Battlecry:</b> Take control of a random enemy <b>Secret</b>.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("GVG_074", foo);
            //Ship's Cannon After you summon a Pirate, deal 2 damage to a random enemy.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("GVG_075", foo);
            //Explosive Sheep <b>Deathrattle:</b> Deal 2 damage to all minions.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("GVG_076", foo);
            //Mechanical Yeti <b>Deathrattle:</b> Give each player a <b>Spare Part.</b>
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("GVG_078", foo);
            //Force-Tank MAX <b>Divine Shield</b>
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("GVG_079", foo);
            //Gilblin Stalker <b>Stealth</b>
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("GVG_081", foo);
            //Clockwork Gnome <b>Deathrattle:</b> Add a <b>Spare Part</b> card to your hand.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("GVG_082", foo);
            //Flying Machine <b>Windfury</b>
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("GVG_084", foo);
            //Annoy-o-Tron <b>Taunt</b> < b > Divine Shield </ b >
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("GVG_085", foo);
            //Illuminator If you control a <b>Secret</b> at the end of your turn, restore 4 Health to your hero.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("GVG_089", foo);
            //Madder Bomber <b>Battlecry:</b> Deal 6 damage randomly split between all other characters.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("GVG_090", foo);
            //Arcane Nullifier X-21 <b>Taunt</b> Can't be targeted by spells or Hero Powers.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("GVG_091", foo);
            //Gnomish Experimenter <b>Battlecry:</b> Draw a card. If it's a minion, transform it into a Chicken.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("GVG_092", foo);
            //Chicken 
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("GVG_092t", foo);
            //Target Dummy <b>Taunt</b>
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("GVG_093", foo);
            //Jeeves At the end of each player's turn, that player draws until they have 3 cards.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("GVG_094", foo);
            //Goblin Sapper Has +4 Attack while your opponent has 6 or more cards in hand.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("GVG_095", foo);
            //Piloted Shredder <b>Deathrattle:</b> Summon a random 2-Cost minion.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("GVG_096", foo);
            //Lil' Exorcist <b>Taunt</b> < b > Battlecry:</ b > Gain + 1 / +1 for each enemy < b > Deathrattle </ b > minion.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("GVG_097", foo);
            //Gnomeregan Infantry <b>Charge</b> < b > Taunt </ b >
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("GVG_098", foo);
            //Bomb Lobber <b>Battlecry:</b> Deal 4 damage to a random enemy minion.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("GVG_099", foo);
            //Tinkertown Technician <b>Battlecry:</b> If you have a Mech, gain +1/+1 and add a <b>Spare Part</b> to your hand.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("GVG_102", foo);
            //Micro Machine At the start of each turn, gain +1 Attack.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("GVG_103", foo);
            //Hobgoblin Whenever you play a 1-Attack minion, give it +2/+2.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("GVG_104", foo);
            //Piloted Sky Golem <b>Deathrattle:</b> Summon a random 4-Cost minion.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("GVG_105", foo);
            //Junkbot Whenever a friendly Mech dies, gain +2/+2.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("GVG_106", foo);
            //Enhance-o Mechano <b>Battlecry:</b> Give your other minions <b>Windfury</b>, <b>Taunt</b>, or <b>Divine Shield</b> < i > (at random)</ i >.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("GVG_107", foo);
            //Recombobulator <b>Battlecry:</b> Transform a friendly minion into a random minion with the same Cost.
            foo = new CardBase();
            foo.TargetFunc = Target.MinionImmuneTargetMinionUser;
            foo.PlayFunc = Play.Minion;
            Dict.Add("GVG_108", foo);
            //Mini-Mage <b>Stealth</b> < b > Spell Damage + 1 </ b >
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("GVG_109", foo);
            //Dr. Boom <b>Battlecry:</b> Summon two 1/1 Boom Bots. <i>WARNING: Bots may explode.</i>
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("GVG_110", foo);
            //Boom Bot <b>Deathrattle:</b> Deal 1-4 damage to a random enemy.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("GVG_110t", foo);
            //Mimiron's Head At the start of your turn, if you have at least 3 Mechs, destroy them all and form V-07-TR-0N.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("GVG_111", foo);
            //V-07-TR-0N <b>Charge</b> < b > Mega - Windfury </ b > < i > (Can attack four times a turn.)</ i >
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("GVG_111t", foo);
            //Mogor the Ogre All minions have a 50% chance to attack the wrong enemy.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("GVG_112", foo);
            //Foe Reaper 4000 Also damages the minions next to whomever it attacks.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("GVG_113", foo);
            //Sneed's Old Shredder <b>Deathrattle:</b> Summon a random <b>Legendary</b> minion.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("GVG_114", foo);
            //Toshley <b>Battlecry and Deathrattle:</b> Add a <b>Spare Part</b> card to your hand.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("GVG_115", foo);
            //Mekgineer Thermaplugg Whenever an enemy minion dies, summon a Leper Gnome.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("GVG_116", foo);
            //Gazlowe Whenever you cast a 1-mana spell, add a random Mech to your hand.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("GVG_117", foo);
            //Troggzor the Earthinator Whenever your opponent casts a spell, summon a Burly Rockjaw Trogg.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("GVG_118", foo);
            //Blingtron 3000 <b>Battlecry:</b> Equip a random weapon for each player.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("GVG_119", foo);
            //Hemet Nesingwary <b>Battlecry:</b> Destroy a Beast.
            foo = new CardBase();
            foo.TargetFunc = () => Target.MinionImmuneTargetMinionAll((card) => card.Race.Equals(Race.BEAST));
            foo.PlayFunc = Play.Minion;
            Dict.Add("GVG_120", foo);
            //Clockwork Giant Costs (1) less for each card in your opponent's hand.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("GVG_121", foo);
            //Armor Plating Give a minion +1 Health.
            foo = new CardBase();
            foo.TargetFunc = Target.SpellImmuneTargetMinionAll;
            foo.PlayFunc = Play.SpellImmuneTargetMinionAll;
            Dict.Add("PART_001", foo);
            //Time Rewinder Return a friendly minion to your hand.
            foo = new CardBase();
            foo.TargetFunc = Target.SpellImmuneTargetMinionUser;
            foo.PlayFunc = Play.SpellImmuneTargetMinionUser;
            Dict.Add("PART_002", foo);
            //Rusty Horn Give a minion <b>Taunt</b>.
            foo = new CardBase();
            foo.TargetFunc = Target.SpellImmuneTargetMinionAll;
            foo.PlayFunc = Play.SpellImmuneTargetMinionAll;
            Dict.Add("PART_003", foo);
            //Finicky Cloakfield Give a friendly minion <b>Stealth</b> until your next turn.
            foo = new CardBase();
            foo.TargetFunc = Target.SpellImmuneTargetMinionUser;
            foo.PlayFunc = Play.SpellImmuneTargetMinionUser;
            Dict.Add("PART_004", foo);
            //Emergency Coolant <b>Freeze</b> a minion.
            foo = new CardBase();
            foo.TargetFunc = Target.SpellImmuneTargetMinionAll;
            foo.PlayFunc = Play.SpellImmuneTargetMinionAll;
            Dict.Add("PART_005", foo);
            //Reversing Switch Swap a minion's Attack and Health.
            foo = new CardBase();
            foo.TargetFunc = Target.SpellImmuneTargetMinionAll;
            foo.PlayFunc = Play.SpellImmuneTargetMinionAll;
            Dict.Add("PART_006", foo);
            //Whirling Blades Give a minion +1 Attack.
            foo = new CardBase();
            foo.TargetFunc = Target.SpellImmuneTargetMinionAll;
            foo.PlayFunc = Play.SpellImmuneTargetMinionAll;
            Dict.Add("PART_007", foo);

        }
        public static void BRM(Dictionary<string, CardBase> Dict)
        {
            //Whelp 
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("BRM_004t", foo);
            //Grim Patron Whenever this minion survives damage, summon another Grim Patron.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("BRM_019", foo);
            //Dragonkin Sorcerer Whenever <b>you</b> target this minion with a spell, gain +1/+1.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("BRM_020", foo);
            //Dragon Egg Whenever this minion takes damage, summon a 2/1 Whelp.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("BRM_022", foo);
            //Black Whelp 
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("BRM_022t", foo);
            //Drakonid Crusher <b>Battlecry:</b> If your opponent has 15 or less Health, gain +3/+3.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("BRM_024", foo);
            //Volcanic Drake Costs (1) less for each minion that died this turn.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("BRM_025", foo);
            //Hungry Dragon <b>Battlecry:</b> Summon a random 1-Cost minion for your opponent.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("BRM_026", foo);
            //Majordomo Executus <b>Deathrattle:</b> Replace your hero with Ragnaros, the Firelord.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("BRM_027", foo);
            //Ragnaros the Firelord 
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("BRM_027h", foo);
            //DIE, INSECT! <b>Hero Power</b> Deal $8 damage to a random enemy.
            foo = new CardBase();
            foo.PlayFunc = Play.SpellRandomTargetEnemy;
            Dict.Add("BRM_027p", foo);
            //DIE, INSECTS! <b>Hero Power</b> Deal $8 damage to a random enemy.TWICE.
            foo = new CardBase();
            foo.PlayFunc = Play.SpellRandomTargetEnemy;
            Dict.Add("BRM_027pH", foo);
            //Emperor Thaurissan At the end of your turn, reduce the Cost of cards in your hand by (1).
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("BRM_028", foo);
            //Rend Blackhand <b>Battlecry:</b> If you're holding a Dragon, destroy a <b>Legendary</b> minion.
            foo = new CardBase();
            foo.TargetFunc = () => Target.HasInHand((card) => card.Race.Equals(Race.DRAGON),
                () => Target.MinionImmuneTargetMinionAll((card) => card.Rarity.Equals(Rarity.LEGENDARY)));
            foo.PlayFunc = Play.Minion;
            Dict.Add("BRM_029", foo);
            //Nefarian <b>Battlecry:</b> Add 2 random spells to your hand <i>(from your opponent's class)</i>.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("BRM_030", foo);
            //Tail Swipe Deal $4 damage.
            foo = new CardBase();
            foo.TargetFunc = Target.SpellTargetAll;
            foo.PlayFunc = Play.SpellTargetAll;
            Dict.Add("BRM_030t", foo);
            //Chromaggus Whenever you draw a card, put another copy into your hand.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("BRM_031", foo);
            //Blackwing Technician <b>Battlecry:</b> If you're holding a Dragon, gain +1/+1.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("BRM_033", foo);
            //Blackwing Corruptor <b>Battlecry:</b> If you're holding a Dragon, deal 3 damage.
            foo = new CardBase();
            foo.TargetFunc = () => Target.HasInHand((card) => card.Race.Equals(Race.DRAGON), Target.MinionTargetAll);
            foo.PlayFunc = Play.Minion;
            Dict.Add("BRM_034", foo);

            //Coren Direbrew 
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("BRMA01_1", foo);
            //Coren Direbrew 
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("BRMA01_1H", foo);
            //Pile On! <b>Hero Power</b> Put a minion from each deck into the battlefield.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("BRMA01_2", foo);
            //Pile On! <b>Hero Power</b> Put two minions from your deck and one from your opponent's into the battlefield.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("BRMA01_2H", foo);
            //Dark Iron Bouncer Always wins Brawls.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("BRMA01_3", foo);
            //Get 'em! Summon four 1/1 Dwarves with <b>Taunt</b>.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("BRMA01_4", foo);
            //Guzzler <b>Taunt</b>
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("BRMA01_4t", foo);
            //High Justice Grimstone 
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("BRMA02_1", foo);
            //High Justice Grimstone 
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("BRMA02_1H", foo);
            //Jeering Crowd <b>Hero Power</b> Summon a 1 / 1 Spectator with < b > Taunt </ b >.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("BRMA02_2", foo);
            //Jeering Crowd <b>Hero Power</b> Summon a 1 / 1 Spectator with < b > Taunt </ b >.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("BRMA02_2H", foo);
            //Dark Iron Spectator <b>Taunt</b>
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("BRMA02_2t", foo);
            //Emperor Thaurissan 
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("BRMA03_1", foo);
            //Emperor Thaurissan 
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("BRMA03_1H", foo);
            //Power of the Firelord <b>Hero Power</b> Deal 30 damage.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("BRMA03_2", foo);
            //Moira Bronzebeard Thaurissan's Hero Power can't be used. Never attacks minions unless they have < b > Taunt </ b >.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("BRMA03_3", foo);
            //Moira Bronzebeard Thaurissan's Hero Power can't be used. Never attacks minions unless they have < b > Taunt </ b >.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("BRMA03_3H", foo);
            //Garr 
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("BRMA04_1", foo);
            //Garr 
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("BRMA04_1H", foo);
            //Magma Pulse <b>Hero Power</b> Deal 1 damage to all minions.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("BRMA04_2", foo);
            //Firesworn <b>Deathrattle:</b> Deal 1 damage to the enemy hero for each Firesworn that died this turn.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("BRMA04_3", foo);
            //Firesworn <b>Deathrattle:</b> Deal 3 damage to the enemy hero for each Firesworn that died this turn.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("BRMA04_3H", foo);
            //Rock Out Summon 3 Firesworn. <b>Overload:</b> (2)
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("BRMA04_4", foo);
            //Rock Out Summon 3 Firesworn. <b>Overload:</b> (2)
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("BRMA04_4H", foo);
            //Baron Geddon 
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("BRMA05_1", foo);
            //Baron Geddon 
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("BRMA05_1H", foo);
            //Ignite Mana <b>Hero Power</b> Deal 5 damage to the enemy hero if they have any unspent Mana.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("BRMA05_2", foo);
            //Ignite Mana <b>Hero Power</b> Deal 10 damage to the enemy hero if they have any unspent Mana.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("BRMA05_2H", foo);
            //Living Bomb Choose an enemy minion. If it lives until your next turn, deal $5 damage to all enemies.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("BRMA05_3", foo);
            //Living Bomb Choose an enemy minion. If it lives until your next turn, deal $10 damage to all enemies.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("BRMA05_3H", foo);
            //Majordomo Executus 
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("BRMA06_1", foo);
            //Majordomo Executus 
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("BRMA06_1H", foo);
            //The Majordomo <b>Hero Power</b> Summon a 1 / 3 Flamewaker Acolyte.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("BRMA06_2", foo);
            //The Majordomo <b>Hero Power</b> Summon a 3 / 3 Flamewaker Acolyte.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("BRMA06_2H", foo);
            //Ragnaros the Firelord 
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("BRMA06_3", foo);
            //Ragnaros the Firelord 
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("BRMA06_3H", foo);
            //Flamewaker Acolyte 
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("BRMA06_4", foo);
            //Flamewaker Acolyte 
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("BRMA06_4H", foo);
            //Highlord Omokk 
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("BRMA07_1", foo);
            //Highlord Omokk 
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("BRMA07_1H", foo);
            //ME SMASH <b>Hero Power</b> Destroy a random damaged enemy minion.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("BRMA07_2", foo);
            //ME SMASH <b>Hero Power</b> Destroy a random enemy minion.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("BRMA07_2H", foo);
            //TIME FOR SMASH Deal $5 damage to a random enemy. Gain 5 Armor.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("BRMA07_3", foo);
            //General Drakkisath 
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("BRMA08_1", foo);
            //General Drakkisath 
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("BRMA08_1H", foo);
            //Intense Gaze <b>Passive Hero Power</b> All cards cost(1).Players are capped at 1 Mana Crystal.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("BRMA08_2", foo);
            //Intense Gaze <b>Passive Hero Power</b> All cards cost(1).You are capped at 2 Mana Crystals, and opponent at 1.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("BRMA08_2H", foo);
            //Drakkisath's Command Destroy a minion. Gain 10 Armor.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("BRMA08_3", foo);
            //Rend Blackhand 
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("BRMA09_1", foo);
            //Rend Blackhand 
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("BRMA09_1H", foo);
            //Open the Gates <b>Hero Power</b> Summon three 1 / 1 Whelps.Get a new Hero Power.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("BRMA09_2", foo);
            //Open the Gates <b>Hero Power</b> Summon three 2 / 2 Whelps.Get a new Hero Power.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("BRMA09_2H", foo);
            //Whelp 
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("BRMA09_2Ht", foo);
            //Whelp 
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("BRMA09_2t", foo);
            //Old Horde <b>Hero Power</b> Summon two 1 / 1 Orcs with < b > Taunt </ b >.Get a new Hero Power.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("BRMA09_3", foo);
            //Old Horde <b>Hero Power</b> Summon two 2 / 2 Orcs with < b > Taunt </ b >.Get a new Hero Power.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("BRMA09_3H", foo);
            //Old Horde Orc <b>Taunt</b>
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("BRMA09_3Ht", foo);
            //Old Horde Orc <b>Taunt</b>
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("BRMA09_3t", foo);
            //Blackwing <b>Hero Power</b> Summon a 3 / 1 Dragonkin.Get a new Hero Power.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("BRMA09_4", foo);
            //Blackwing <b>Hero Power</b> Summon a 5 / 4 Dragonkin.Get a new Hero Power.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("BRMA09_4H", foo);
            //Dragonkin 
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("BRMA09_4Ht", foo);
            //Dragonkin 
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("BRMA09_4t", foo);
            //Dismount <b>Hero Power</b> Summon Gyth. Get a new Hero Power.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("BRMA09_5", foo);
            //Dismount <b>Hero Power</b> Summon Gyth. Get a new Hero Power.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("BRMA09_5H", foo);
            //Gyth 
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("BRMA09_5Ht", foo);
            //Gyth 
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("BRMA09_5t", foo);
            //The True Warchief Destroy a Legendary minion.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("BRMA09_6", foo);
            //Razorgore the Untamed 
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("BRMA10_1", foo);
            //Razorgore the Untamed 
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("BRMA10_1H", foo);
            //The Rookery <b>Hero Power</b>  Give all Corrupted Eggs +1 Health, then summon one.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("BRMA10_3", foo);
            //The Rookery <b>Hero Power</b> Give all Corrupted Eggs +1 Health, then summon one.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("BRMA10_3H", foo);
            //Corrupted Egg When this minion has 4 or more Health, it hatches.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("BRMA10_4", foo);
            //Corrupted Egg When this minion has 5 or more Health, it hatches.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("BRMA10_4H", foo);
            //Chromatic Drake 
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("BRMA10_5", foo);
            //Chromatic Drake 
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("BRMA10_5H", foo);
            //Razorgore's Claws Whenever a Corrupted Egg dies, gain +1 Attack.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("BRMA10_6", foo);
            //Vaelastrasz the Corrupt 
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("BRMA11_1", foo);
            //Vaelastrasz the Corrupt 
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("BRMA11_1H", foo);
            //Essence of the Red <b>Hero Power</b> Each player draws 2 cards.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("BRMA11_2", foo);
            //Essence of the Red <b>Hero Power</b> Each player draws 3 cards.Gain a Mana Crystal.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("BRMA11_2H", foo);
            //Burning Adrenaline Deal $2 damage to the enemy hero.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("BRMA11_3", foo);
            //Chromaggus 
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("BRMA12_1", foo);
            //Mutation <b>Hero Power</b> Discard a random card.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("BRMA12_10", foo);
            //Chromaggus 
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("BRMA12_1H", foo);
            //Brood Affliction <b>Hero Power</b> At the end of your turn, add a Brood Affliction card to your opponent's hand.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("BRMA12_2", foo);
            //Brood Affliction <b>Hero Power</b> At the end of your turn, add a Brood Affliction card to your opponent's hand.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("BRMA12_2H", foo);
            //Brood Affliction: Red While this is in your hand, take 1 damage at the start of your turn.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("BRMA12_3", foo);
            //Brood Affliction: Red While this is in your hand, take 3 damage at the start of your turn.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("BRMA12_3H", foo);
            //Brood Affliction: Green While this is in your hand, restore 2 health to your opponent at the start of your turn.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("BRMA12_4", foo);
            //Brood Affliction: Green While this is in your hand, restore 6 health to your opponent at the start of your turn.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("BRMA12_4H", foo);
            //Brood Affliction: Blue While this is in your hand, Chromaggus' spells cost (1) less.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("BRMA12_5", foo);
            //Brood Affliction: Blue While this is in your hand, Chromaggus' spells cost (3) less.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("BRMA12_5H", foo);
            //Brood Affliction: Black While this is in your hand, whenever Chromaggus draws a card, he gets another copy of it.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("BRMA12_6", foo);
            //Brood Affliction: Black While this is in your hand, whenever Chromaggus draws a card, he gets another copy of it.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("BRMA12_6H", foo);
            //Brood Affliction: Bronze While this is in your hand, Chromaggus' minions cost (1) less.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("BRMA12_7", foo);
            //Brood Affliction: Bronze While this is in your hand, Chromaggus' minions cost (3) less.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("BRMA12_7H", foo);
            //Chromatic Mutation Transform a minion into a 2/2 Chromatic Dragonkin.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("BRMA12_8", foo);
            //Chromatic Dragonkin Whenever your opponent casts a spell, gain +2/+2.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("BRMA12_8t", foo);
            //Chromatic Dragonkin 
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("BRMA12_9", foo);
            //Lord Victor Nefarius 
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("BRMA13_1", foo);
            //Lord Victor Nefarius 
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("BRMA13_1H", foo);
            //True Form <b>Hero Power</b> Let the games begin!
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("BRMA13_2", foo);
            //True Form <b>Hero Power</b> Let the games begin!
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("BRMA13_2H", foo);
            //Nefarian 
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("BRMA13_3", foo);
            //Nefarian 
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("BRMA13_3H", foo);
            //Wild Magic <b>Hero Power</b> Put a random spell from your opponent's class into your hand.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("BRMA13_4", foo);
            //Wild Magic <b>Hero Power</b>  Put a random spell from your opponent's class into your hand.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("BRMA13_4H", foo);
            //Son of the Flame <b>Battlecry:</b> Deal 6 damage.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("BRMA13_5", foo);
            //Living Lava <b>Taunt</b>
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("BRMA13_6", foo);
            //Whirling Ash <b>Windfury</b>
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("BRMA13_7", foo);
            //DIE, INSECT! Deal $8 damage to a random enemy.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("BRMA13_8", foo);
            //Omnotron Defense System 
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("BRMA14_1", foo);
            //Activate! <b>Hero Power</b> Activate a random Tron.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("BRMA14_10", foo);
            //Activate! <b>Hero Power</b>  Activate a random Tron.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("BRMA14_10H", foo);
            //Recharge Fill all empty Mana Crystals.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("BRMA14_11", foo);
            //Magmaw <b>Taunt</b>
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("BRMA14_12", foo);
            //Omnotron Defense System 
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("BRMA14_1H", foo);
            //Activate Arcanotron <b>Hero Power</b> Activate Arcanotron!
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("BRMA14_2", foo);
            //Activate Arcanotron <b>Hero Power</b> Activate Arcanotron!
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("BRMA14_2H", foo);
            //Arcanotron Both players have <b>Spell Damage +2</b>.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("BRMA14_3", foo);
            //Activate Toxitron <b>Hero Power</b> Activate Toxitron!
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("BRMA14_4", foo);
            //Activate Toxitron <b>Hero Power</b> Activate Toxitron!
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("BRMA14_4H", foo);
            //Toxitron At the start of your turn, deal 1 damage to all other minions.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("BRMA14_5", foo);
            //Toxitron At the start of your turn, deal 1 damage to all other minions.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("BRMA14_5H", foo);
            //Activate Electron <b>Hero Power</b> Activate Electron!
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("BRMA14_6", foo);
            //Activate Electron <b>Hero Power</b> Activate Electron!
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("BRMA14_6H", foo);
            //Electron All spells cost (3) less.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("BRMA14_7", foo);
            //Electron All spells cost (3) less.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("BRMA14_7H", foo);
            //Activate Magmatron <b>Hero Power</b>  Activate Magmatron!
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("BRMA14_8", foo);
            //Activate Magmatron <b>Hero Power</b> Activate Magmatron!
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("BRMA14_8H", foo);
            //Magmatron Whenever a player plays a card, Magmatron deals 2 damage to them.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("BRMA14_9", foo);
            //Magmatron Whenever a player plays a card, Magmatron deals 2 damage to them.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("BRMA14_9H", foo);
            //Maloriak 
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("BRMA15_1", foo);
            //Maloriak 
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("BRMA15_1H", foo);
            //The Alchemist <b>Passive Hero Power</b>  Whenever a minion is summoned, swap its Attack and Health.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("BRMA15_2", foo);
            //The Alchemist <b>Passive Hero Power</b> Minions' Attack and Health are swapped. Your minions have + 2 / +2.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("BRMA15_2H", foo);
            //Release the Aberrations! Summon 3 Aberrations.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("BRMA15_3", foo);
            //Aberration <b>Charge</b>
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("BRMA15_4", foo);
            //Atramedes 
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("BRMA16_1", foo);
            //Atramedes 
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("BRMA16_1H", foo);
            //Echolocate <b>Hero Power</b>Equip a weapon that grows as your opponent plays cards.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("BRMA16_2", foo);
            //Echolocate <b>Hero Power</b>Equip a weapon that grows as your opponent plays cards.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("BRMA16_2H", foo);
            //Sonic Breath Deal $3 damage to a minion. Give your weapon +3 Attack.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("BRMA16_3", foo);
            //Reverberating Gong Destroy your opponent's weapon.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("BRMA16_4", foo);
            //Dragonteeth Whenever your opponent plays a card, gain +1 Attack.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("BRMA16_5", foo);
            //Nefarian 
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("BRMA17_2", foo);
            //Nefarian 
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("BRMA17_2H", foo);
            //Onyxia 
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("BRMA17_3", foo);
            //Onyxia 
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("BRMA17_3H", foo);
            //LAVA! Deal $2 damage to all minions.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("BRMA17_4", foo);
            //Bone Minions <b>Hero Power</b>Summon two 2 / 1 Bone Constructs.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("BRMA17_5", foo);
            //Bone Minions <b>Hero Power</b>Summon two 4 / 2 Bone Constructs.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("BRMA17_5H", foo);
            //Bone Construct 
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("BRMA17_6", foo);
            //Bone Construct 
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("BRMA17_6H", foo);
            //Chromatic Prototype <b>Taunt</b>
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("BRMA17_7", foo);
            //Nefarian Strikes! <b>Hero Power</b>Nefarian rains fire from above!
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("BRMA17_8", foo);
            //Nefarian Strikes! <b>Hero Power</b>Nefarian rains fire from above!
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("BRMA17_8H", foo);
            //Onyxiclaw 
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("BRMA17_9", foo);
            //Flameheart Draw 2 cards.Gain 4 Armor.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("BRMA_01", foo);

        }
        public static void TGT(Dictionary<string, CardBase> Dict)
        {
            //Boar <b>Charge</b>
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("AT_005t", foo);
            //Twilight Guardian <b>Battlecry:</b> If you're holding a Dragon, gain +1 Attack and <b>Taunt</b>.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("AT_017", foo);
            //Skycap'n Kragg <b>Charrrrrge</b> Costs(1) less for each friendly Pirate.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("AT_070", foo);
            //Garrison Commander You can use your Hero Power twice a turn.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("AT_080", foo);
            //Lowly Squire <b>Inspire:</b> Gain +1 Attack.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("AT_082", foo);
            //Dragonhawk Rider <b>Inspire:</b> Gain <b>Windfury</b> this turn.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("AT_083", foo);
            //Lance Carrier <b>Battlecry:</b> Give a friendly minion +2 Attack.
            foo = new CardBase();
            foo.TargetFunc = Target.MinionImmuneTargetMinionUser;
            foo.PlayFunc = Play.Minion;
            Dict.Add("AT_084", foo);
            //Maiden of the Lake Your Hero Power costs (1).
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("AT_085", foo);
            //Saboteur <b>Battlecry:</b> Your opponent's Hero Power costs (5) more next turn.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("AT_086", foo);
            //Argent Horserider <b>Charge</b> < b > Divine Shield </ b >
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("AT_087", foo);
            //Mogor's Champion 50% chance to attack the wrong enemy.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("AT_088", foo);
            //Boneguard Lieutenant <b>Inspire:</b> Gain +1 Health.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("AT_089", foo);
            //Mukla's Champion <b>Inspire:</b> Give your other minions +1/+1.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("AT_090", foo);
            //Tournament Medic <b>Inspire:</b> Restore 2 Health to your hero.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("AT_091", foo);
            //Ice Rager 
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("AT_092", foo);
            //Frigid Snobold <b>Spell Damage +1</b>
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("AT_093", foo);
            //Flame Juggler <b>Battlecry:</b> Deal 1 damage to a random enemy.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("AT_094", foo);
            //Silent Knight <b>Stealth</b> < b > Divine Shield </ b >
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("AT_095", foo);
            //Clockwork Knight <b>Battlecry:</b> Give a friendly Mech +1/+1.
            foo = new CardBase();
            foo.TargetFunc = () => Target.MinionImmuneTargetMinionUser((card) => card.Race.Equals(Race.MECHANICAL));
            foo.PlayFunc = Play.Minion;
            Dict.Add("AT_096", foo);
            //Tournament Attendee <b>Taunt</b>
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("AT_097", foo);
            //Sideshow Spelleater <b>Battlecry:</b> Copy your opponent's Hero Power.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("AT_098", foo);
            //Kodorider <b>Inspire:</b> Summon a 3/5 War Kodo.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("AT_099", foo);
            //War Kodo 
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("AT_099t", foo);
            //Silver Hand Regent <b>Inspire:</b> Summon a 1/1 Silver Hand Recruit.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("AT_100", foo);
            //Pit Fighter 
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("AT_101", foo);
            //Captured Jormungar 
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("AT_102", foo);
            //North Sea Kraken <b>Battlecry:</b> Deal 4 damage.
            foo = new CardBase();
            foo.TargetFunc = Target.MinionTargetAll;
            foo.PlayFunc = Play.Minion;
            Dict.Add("AT_103", foo);
            //Injured Kvaldir <b>Battlecry:</b> Deal 3 damage to this minion.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("AT_105", foo);
            //Light's Champion <b>Battlecry:</b> <b>Silence</b> a Demon.
            foo = new CardBase();
            foo.TargetFunc = () => Target.MinionImmuneTargetAll((card) => card.Race.Equals(Race.DEMON));
            foo.PlayFunc = Play.Minion;
            Dict.Add("AT_106", foo);
            //Armored Warhorse <b>Battlecry:</b> Reveal a minion in each deck. If yours costs more, gain <b>Charge</b>.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("AT_108", foo);
            //Argent Watchman Can't attack. < b > Inspire:</ b > Can attack as normal this turn.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("AT_109", foo);
            //Coliseum Manager <b>Inspire:</b> Return this minion to your hand.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("AT_110", foo);
            //Refreshment Vendor <b>Battlecry:</b> Restore 4 Health to each hero.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("AT_111", foo);
            //Master Jouster <b>Battlecry:</b> Reveal a minion in each deck. If yours costs more, gain <b>Taunt</b> and <b>Divine Shield</b>.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("AT_112", foo);
            //Recruiter <b>Inspire:</b> Add a 2/2 Squire to your hand.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("AT_113", foo);
            //Evil Heckler <b>Taunt</b>
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("AT_114", foo);
            //Fencing Coach <b>Battlecry:</b> The next time you use your Hero Power, it costs (2) less.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("AT_115", foo);
            //Master of Ceremonies <b>Battlecry:</b> If you have a minion with <b>Spell Damage</b>, gain +2/+2.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("AT_117", foo);
            //Grand Crusader <b>Battlecry:</b> Add a random Paladin card to your hand.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("AT_118", foo);
            //Kvaldir Raider <b>Inspire:</b> Gain +2/+2.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("AT_119", foo);
            //Frost Giant Costs (1) less for each time you used your Hero Power this game.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("AT_120", foo);
            //Crowd Favorite Whenever you play a card with <b>Battlecry</b>, gain +1/+1.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("AT_121", foo);
            //Gormok the Impaler <b>Battlecry:</b> If you have at least 4 other minions, deal 4 damage.
            foo = new CardBase();
            foo.TargetFunc = () => Target.HasAtleastMinionOnBoard(4, Target.MinionTargetAll);
            foo.PlayFunc = Play.Minion;
            Dict.Add("AT_122", foo);
            //Chillmaw [x]<b>Taunt</b> < b > Deathrattle:</ b > If you're holding a Dragon, deal 3 damage to all minions.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("AT_123", foo);
            //Bolf Ramshield Whenever your hero takes damage, this minion takes it instead.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("AT_124", foo);
            //Icehowl <b>Charge</b> Can't attack heroes.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("AT_125", foo);
            //Nexus-Champion Saraad <b>Inspire:</b> Add a random spell to your hand.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("AT_127", foo);
            //The Skeleton Knight <b>Deathrattle:</b> Reveal a minion in each deck. If yours costs more, return this to your hand.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("AT_128", foo);
            //Fjola Lightbane Whenever <b>you</b> target this minion with a spell, gain <b>Divine Shield.</b>
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("AT_129", foo);
            //Eydis Darkbane Whenever <b>you</b> target this minion with a spell, deal 3 damage to a random enemy.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("AT_131", foo);
            //Justicar Trueheart <b>Battlecry:</b> Replace your starting Hero Power with a better one.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("AT_132", foo);
            //Gadgetzan Jouster <b>Battlecry:</b> Reveal a minion in each deck. If yours costs more, gain +1/+1.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("AT_133", foo);

        }
        public static void LOE(Dictionary<string, CardBase> Dict)
        {
        }
        public static void OG(Dictionary<string, CardBase> Dict)
        {
        }
        public static void KARA(Dictionary<string, CardBase> Dict)
        {
        }
        public static void GANGS(Dictionary<string, CardBase> Dict)
        {
        }
        public static void UNGORO(Dictionary<string, CardBase> Dict)
        {
        }
        public static void ICECROWN(Dictionary<string, CardBase> Dict)
        {
        }
        public static void TB(Dictionary<string, CardBase> Dict)
        {
        }
    }
}
