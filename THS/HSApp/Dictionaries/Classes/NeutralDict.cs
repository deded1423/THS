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
            foo.TargetFunc = () => Target.MinionImmuneTargetMinionAll((card) => card.Race.Equals(Race.MURLOC));
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
            //Eye of Hakkar Take a secret from your opponent's deck and put it into the battlefield.
            foo = new CardBase();
            Dict.Add("LOE_008", foo);
            //Eye of Hakkar Take a secret from your opponent's deck and put it into the battlefield.
            foo = new CardBase();
            Dict.Add("LOE_008H", foo);
            //Reno Jackson <b>Battlecry:</b> If your deck has no duplicates, fully heal your hero.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("LOE_011", foo);
            //Rock <b>Taunt</b>
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("LOE_016t", foo);
            //Map to the Golden Monkey Shuffle the Golden Monkey into your deck. Draw a card.
            foo = new CardBase();
            Dict.Add("LOE_019t", foo);
            //Golden Monkey <b>Taunt</b> < b > Battlecry:</ b > Replace your hand and deck with<b> Legendary</ b > minions.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("LOE_019t2", foo);
            //Rolling Boulder At the end of your turn, destroy the minion to the left.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("LOE_024t", foo);
            //Jeweled Scarab <b>Battlecry: Discover</b> a 3 - Cost card.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("LOE_029", foo);
            //Naga Sea Witch Your cards cost (5).
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("LOE_038", foo);
            //Gorillabot A-3 <b>Battlecry:</b> If you control another Mech, <b>Discover</b> a Mech.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("LOE_039", foo);
            //Huge Toad <b>Deathrattle:</b> Deal 1 damage to a random enemy.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("LOE_046", foo);
            //Tomb Spider <b>Battlecry: Discover</b> a Beast.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("LOE_047", foo);
            //Djinni of Zephyrs After you cast a spell on another friendly minion, cast a copy of it on this one.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("LOE_053", foo);
            //Anubisath Sentinel <b>Deathrattle:</b> Give a random friendly minion +3/+3.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("LOE_061", foo);
            //Fossilized Devilsaur <b>Battlecry:</b> If you control a Beast, gain <b>Taunt</b>.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("LOE_073", foo);
            //Sir Finley Mrrgglton <b>Battlecry: Discover</b> a new basic Hero Power.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("LOE_076", foo);
            //Brann Bronzebeard Your <b>Battlecries</b> trigger twice.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("LOE_077", foo);
            //Elise Starseeker <b>Battlecry:</b> Shuffle the 'Map to the Golden Monkey'   into your deck.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("LOE_079", foo);
            //Summoning Stone Whenever you cast a spell, summon a random minion of the same Cost.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("LOE_086", foo);
            //Wobbling Runts <b>Deathrattle:</b> Summon three 2/2 Runts.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("LOE_089", foo);
            //Rascally Runt 
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("LOE_089t", foo);
            //Wily Runt 
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("LOE_089t2", foo);
            //Grumbly Runt 
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("LOE_089t3", foo);
            //Arch-Thief Rafaam <b>Battlecry: Discover</b> a powerful Artifact.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("LOE_092", foo);
            //Eerie Statue Can’t attack unless it’s the only minion in the battlefield.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("LOE_107", foo);
            //Ancient Shade <b>Battlecry:</b> Shuffle an 'Ancient Curse' into your deck that deals 7 damage to you when drawn.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("LOE_110", foo);
            //Ancient Curse When you draw this, take 7 damage and draw a card.
            foo = new CardBase();
            Dict.Add("LOE_110t", foo);

            //Sun Raider Phaerix 
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("LOEA01_01", foo);
            //Sun Raider Phaerix 
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("LOEA01_01h", foo);
            //Blessings of the Sun <b>Passive Hero Power</b> Whoever controls the Rod of the Sun is < b > Immune.</ b >
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("LOEA01_02", foo);
            //Blessings of the Sun <b>Passive Hero Power</b> Phaerix is < b > Immune </ b > while he controls the Rod of the Sun.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("LOEA01_02h", foo);
            //Rod of the Sun <b>Deathrattle:</b> Surrender this to your opponent.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("LOEA01_11", foo);
            //Rod of the Sun <b>Deathrattle:</b> Surrender this to your opponent.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("LOEA01_11h", foo);
            //Tol'vir Hoplite <b>Deathrattle:</b> Deal 5 damage to both heroes.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("LOEA01_12", foo);
            //Tol'vir Hoplite <b>Deathrattle:</b> Deal 5 damage to both heroes.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("LOEA01_12h", foo);
            //Zinaar 
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("LOEA02_01", foo);
            //Zinaar 
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("LOEA02_01h", foo);
            //Djinn’s Intuition Draw a card. Give your opponent a Wish.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("LOEA02_02", foo);
            //Djinn’s Intuition Draw a card. Gain a Mana Crystal. Give your opponent a Wish.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("LOEA02_02h", foo);
            //Wish for Power <b>Discover</b> a spell.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("LOEA02_03", foo);
            //Wish for Valor <b>Discover</b> a (4)-Cost card.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("LOEA02_04", foo);
            //Wish for Glory <b>Discover</b> a minion.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("LOEA02_05", foo);
            //Wish for More Wishes Gain 2 Wishes.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("LOEA02_06", foo);
            //Wish for Companionship <b>Discover</b> a Companion.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("LOEA02_10", foo);
            //Temple Escape 
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("LOEA04_01", foo);
            //Temple Escape 
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("LOEA04_01h", foo);
            //Escape! Encounter new obstacles!
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("LOEA04_02", foo);
            //Escape! Encounter new obstacles!
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("LOEA04_02h", foo);
            //Pit of Spikes <b>Choose Your Path!</b>
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("LOEA04_06", foo);
            //Swing Across Take 10 damage or no damage, at random.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("LOEA04_06a", foo);
            //Walk Across Gingerly Take 5 damage.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("LOEA04_06b", foo);
            //Orsis Guard <b>Divine Shield</b>
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("LOEA04_13bt", foo);
            //Orsis Guard <b>Divine Shield</b>
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("LOEA04_13bth", foo);
            //Giant Insect 
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("LOEA04_23", foo);
            //Giant Insect 
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("LOEA04_23h", foo);
            //Anubisath Temple Guard 
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("LOEA04_24", foo);
            //Anubisath Temple Guard 
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("LOEA04_24h", foo);
            //Seething Statue At the end of your turn, deal 2 damage to all enemies.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("LOEA04_25", foo);
            //Seething Statue At the end of your turn, deal 5 damage to all enemies.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("LOEA04_25h", foo);
            //Animated Statue You've disturbed the ancient statue...
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("LOEA04_27", foo);
            //A Glowing Pool <b>Drink?</b>
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("LOEA04_28", foo);
            //Drink Deeply Draw a card.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("LOEA04_28a", foo);
            //Wade Through Gain a Mana Crystal
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("LOEA04_28b", foo);
            //The Eye <b>Choose Your Path!</b>
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("LOEA04_29", foo);
            //Touch It Restore 10 Health to your hero.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("LOEA04_29a", foo);
            //Investigate the Runes Draw 2 cards.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("LOEA04_29b", foo);
            //The Darkness <b>Take the Shortcut?</b>
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("LOEA04_30", foo);
            //Take the Shortcut Get 1 turn closer to the Exit! Encounter a 7/7 War Golem.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("LOEA04_30a", foo);
            //No Way! Do nothing.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("LOEA04_31b", foo);
            //Chieftain Scarvash 
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("LOEA05_01", foo);
            //Chieftain Scarvash 
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("LOEA05_01h", foo);
            //Trogg Hate Minions! <b>Passive Hero Power</b> Enemy minions cost(2) more.Swap at the start of your turn.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("LOEA05_02", foo);
            //Trogg Hate Minions! <b>Passive Hero Power</b> Enemy minions cost(2) more.Swap at the start of your turn.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("LOEA05_02a", foo);
            //Trogg Hate Minions! <b>Passive Hero Power</b> Enemy minions cost(11).Swap at the start of your turn.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("LOEA05_02h", foo);
            //Trogg Hate Minions! <b>Passive Hero Power</b> Enemy minions cost(11).Swap at the start of your turn.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("LOEA05_02ha", foo);
            //Trogg Hate Spells! <b>Passive Hero Power</b> Enemy spells cost(2) more.Swap at the start of your turn.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("LOEA05_03", foo);
            //Trogg Hate Spells! <b>Passive Hero Power</b> Enemy spells cost(11).Swap at the start of your turn.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("LOEA05_03h", foo);
            //Stonesculpting <b>Hero Power</b> Summon a 0 / 2 Statue for both players.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("LOEA06_02", foo);
            //Stonesculpting <b>Hero Power</b> Summon a Statue for both players.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("LOEA06_02h", foo);
            //Earthen Statue 
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("LOEA06_02t", foo);
            //Earthen Statue 
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("LOEA06_02th", foo);
            //Animate Earthen Give your minions +1/+1 and <b>Taunt</b>.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("LOEA06_03", foo);
            //Animate Earthen Give your minions +3/+3 and <b>Taunt</b>.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("LOEA06_03h", foo);
            //Shattering Spree Destroy all Statues. For each destroyed, deal 1 damage.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("LOEA06_04", foo);
            //Shattering Spree Destroy all Statues. For each destroyed, deal 3 damage.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("LOEA06_04h", foo);
            //Mine Cart 
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("LOEA07_01", foo);
            //Mine Shaft 
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("LOEA07_02", foo);
            //Mine Shaft 
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("LOEA07_02h", foo);
            //Flee the Mine! Escape the Troggs!
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("LOEA07_03", foo);
            //Flee the Mine! Escape the Troggs!
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("LOEA07_03h", foo);
            //Chasing Trogg 
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("LOEA07_09", foo);
            //Debris <b>Taunt.</b>
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("LOEA07_11", foo);
            //Earthen Pursuer 
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("LOEA07_12", foo);
            //Lumbering Golem 
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("LOEA07_14", foo);
            //Dynamite Deal $10 damage.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("LOEA07_18", foo);
            //Boom! Deal $3 damage to all enemy minions.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("LOEA07_20", foo);
            //Barrel Forward Get 1 turn closer to the Exit!
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("LOEA07_21", foo);
            //Spiked Decoy <b>Taunt</b> Can't attack.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("LOEA07_24", foo);
            //Mechanical Parrot 
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("LOEA07_25", foo);
            //Consult Brann Draw 3 cards.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("LOEA07_26", foo);
            //Repairs Restore 10 Health.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("LOEA07_28", foo);
            //Throw Rocks <b>Hero Power</b> Deal 3 damage to a random enemy minion.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("LOEA07_29", foo);
            //Archaedas 
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("LOEA08_01", foo);
            //Archaedas 
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("LOEA08_01h", foo);
            //Lord Slitherspear 
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("LOEA09_1", foo);
            //Hungry Naga 
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("LOEA09_10", foo);
            //Hungry Naga 
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("LOEA09_11", foo);
            //Hungry Naga 
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("LOEA09_12", foo);
            //Hungry Naga 
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("LOEA09_13", foo);
            //Lord Slitherspear 
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("LOEA09_1H", foo);
            //Enraged! Give your hero +2 attack this turn.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("LOEA09_2", foo);
            //Enraged! Give your hero +5 attack this turn.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("LOEA09_2H", foo);
            //Getting Hungry <b>Hero Power</b> Summon a Hungry Naga.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("LOEA09_3", foo);
            //Getting Hungry <b>Hero Power</b> Summon a 1 / 1 Hungry Naga.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("LOEA09_3b", foo);
            //Getting Hungry <b>Hero Power</b> Summon a 2 / 1 Hungry Naga.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("LOEA09_3c", foo);
            //Getting Hungry <b>Hero Power</b> Summon a 5 / 1 Hungry Naga.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("LOEA09_3d", foo);
            //Endless Hunger <b>Hero Power</b> Summon a Hungry Naga.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("LOEA09_3H", foo);
            //Rare Spear Whenever your opponent plays a Rare card, gain +1/+1.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("LOEA09_4", foo);
            //Rare Spear Whenever your opponent plays a Rare card, gain +1/+1.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("LOEA09_4H", foo);
            //Hungry Naga 
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("LOEA09_5", foo);
            //Hungry Naga 
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("LOEA09_5H", foo);
            //Slithering Archer <b>Battlecry:</b> Deal 1 damage.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("LOEA09_6", foo);
            //Slithering Archer <b>Battlecry:</b> Deal 2 damage to all enemy minions.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("LOEA09_6H", foo);
            //Cauldron <b>Taunt</b> < b > Deathrattle:</ b > Save Sir Finley and stop the Naga onslaught!
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("LOEA09_7", foo);
            //Cauldron <b>Taunt</b> < b > Deathrattle:</ b > Save Sir Finley!
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("LOEA09_7H", foo);
            //Slithering Guard <b>Taunt</b>
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("LOEA09_8", foo);
            //Slithering Guard <b>Taunt</b>
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("LOEA09_8H", foo);
            //Naga Repellent Destroy all Hungry Naga.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("LOEA09_9", foo);
            //Naga Repellent Change the Attack of all Hungry Naga to 1.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("LOEA09_9H", foo);
            //Giantfin 
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("LOEA10_1", foo);
            //Giantfin 
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("LOEA10_1H", foo);
            //Mrglmrgl MRGL! <b>Hero Power</b> Draw cards until you have as many in hand as your opponent.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("LOEA10_2", foo);
            //Mrglmrgl MRGL! <b>Hero Power</b> Draw 2 cards.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("LOEA10_2H", foo);
            //Murloc Tinyfin 
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("LOEA10_3", foo);
            //Mrgl Mrgl Nyah Nyah Summon 3 Murlocs that died this game.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("LOEA10_5", foo);
            //Mrgl Mrgl Nyah Nyah Summon 5 Murlocs that died this game.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("LOEA10_5H", foo);
            //Lady Naz'jar 
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("LOEA12_1", foo);
            //Lady Naz'jar 
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("LOEA12_1H", foo);
            //Pearl of the Tides At the end of your turn, replace all minions with new ones that cost (1) more.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("LOEA12_2", foo);
            //Pearl of the Tides At the end of your turn, replace all minions with new ones. Yours cost (1) more.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("LOEA12_2H", foo);
            //Skelesaurus Hex 
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("LOEA13_1", foo);
            //Skelesaurus Hex 
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("LOEA13_1h", foo);
            //Ancient Power <b>Hero Power</b> Give each player a random card. It costs (0).
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("LOEA13_2", foo);
            //Ancient Power <b>Hero Power</b> Add a random card to your hand.It costs (0).
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("LOEA13_2H", foo);
            //The Steel Sentinel 
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("LOEA14_1", foo);
            //The Steel Sentinel 
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("LOEA14_1H", foo);
            //Platemail Armor <b>Passive Hero Power</b> Your Hero can only take 1 damage at a time.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("LOEA14_2", foo);
            //Platemail Armor <b>Passive Hero Power</b> Your Hero and your minions can only take 1 damage at a time.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("LOEA14_2H", foo);
            //Rafaam 
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("LOEA15_1", foo);
            //Rafaam 
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("LOEA15_1H", foo);
            //Unstable Portal <b>Hero Power</b> Add a random minion to your hand.It costs (3) less.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("LOEA15_2", foo);
            //Unstable Portal <b>Hero Power</b> Add a random minion to your hand.It costs (3) less.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("LOEA15_2H", foo);
            //Boneraptor <b>Battlecry:</b>Take control of your opponent's weapon.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("LOEA15_3", foo);
            //Boneraptor <b>Battlecry:</b>Take control of your opponent's weapon.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("LOEA15_3H", foo);
            //Rafaam 
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("LOEA16_1", foo);
            //Hakkari Blood Goblet Transform a minion into a 2/1 Pit Snake.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("LOEA16_10", foo);
            //Crown of Kael'thas Deal $10 damage randomly split among ALL characters.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("LOEA16_11", foo);
            //Medivh's Locket Replace your hand with Unstable Portals.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("LOEA16_12", foo);
            //Eye of Orsis <b>Discover</b> a minion and gain 3 copies of it.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("LOEA16_13", foo);
            //Khadgar's Pipe Put a random spell into each player's hand.  Yours costs (0).
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("LOEA16_14", foo);
            //Ysera's Tear Gain 4 Mana Crystals this turn only.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("LOEA16_15", foo);
            //Rummage Find an artifact.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("LOEA16_16", foo);
            //Rummage Find an artifact.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("LOEA16_16H", foo);
            //Animated Statue 
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("LOEA16_17", foo);
            //Zinaar At the end of your turn, gain a wish.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("LOEA16_18", foo);
            //Zinaar At the end of your turn, gain a wish.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("LOEA16_18H", foo);
            //Sun Raider Phaerix At the end of your turn, add a Blessing of the Sun to your hand.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("LOEA16_19", foo);
            //Sun Raider Phaerix Your other minions are <b>Immune</b>.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("LOEA16_19H", foo);
            //Rafaam 
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("LOEA16_1H", foo);
            //Staff of Origination <b>Passive Hero Power</b> Your hero is < b > Immune </ b > while the staff charges.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("LOEA16_2", foo);
            //Blessing of the Sun Give a minion <b>Immune</b> this turn.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("LOEA16_20", foo);
            //Chieftain Scarvash Enemy cards cost (1) more.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("LOEA16_21", foo);
            //Chieftain Scarvash Enemy cards cost (2) more.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("LOEA16_21H", foo);
            //Archaedas At the end of your turn, turn a random enemy minion into a 0/2 Statue.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("LOEA16_22", foo);
            //Archaedas At the end of your turn, turn a random enemy minion into a 0/2 Statue.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("LOEA16_22H", foo);
            //Lord Slitherspear At the end of your turn, summon 1/1 Hungry Naga for each enemy minion.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("LOEA16_23", foo);
            //Lord Slitherspear At the end of your turn, summon 1/1 Hungry Naga for each enemy minion.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("LOEA16_23H", foo);
            //Giantfin At the end of your turn, draw until you have as many cards as your opponent.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("LOEA16_24", foo);
            //Giantfin At the end of your turn, draw 2 cards.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("LOEA16_24H", foo);
            //Lady Naz'jar At the end of your turn, replace all other minions with new ones of the same Cost.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("LOEA16_25", foo);
            //Lady Naz'jar At the end of your turn, replace all other minions with new ones of the same Cost.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("LOEA16_25H", foo);
            //Skelesaurus Hex At the end of your turn, give each player a random card. It costs (0).
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("LOEA16_26", foo);
            //Skelesaurus Hex At the end of your turn, put a random card in your hand. It costs (0).
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("LOEA16_26H", foo);
            //The Steel Sentinel This minion can only take 1 damage at a time.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("LOEA16_27", foo);
            //The Steel Sentinel This minion can only take 1 damage at a time.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("LOEA16_27H", foo);
            //Staff of Origination <b>Passive Hero Power</b> Your hero is < b > Immune </ b >.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("LOEA16_2H", foo);
            //Lantern of Power Give a minion +10/+10.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("LOEA16_3", foo);
            //Timepiece of Horror Deal $10 damage randomly split among all enemies.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("LOEA16_4", foo);
            //Mirror of Doom Fill your board with 3/3 Mummy Zombies.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("LOEA16_5", foo);
            //Mummy Zombie 
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("LOEA16_5t", foo);
            //Shard of Sulfuras Deal $5 damage to ALL characters.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("LOEA16_6", foo);
            //Benediction Splinter Restore #10 Health to ALL characters.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("LOEA16_7", foo);
            //Putress' Vial Destroy a random enemy minion.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("LOEA16_8", foo);
            //Lothar's Left Greave Deal $3 damage to all enemies.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("LOEA16_9", foo);
            //Looming Presence Draw 2 cards. Gain 4 Armor.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("LOEA_01", foo);
            //Looming Presence Draw 3 cards. Gain 6 Armor.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("LOEA_01H", foo);

        }
        public static void OG(Dictionary<string, CardBase> Dict)
        {
            //Silithid Swarmer Can only attack if your hero attacked this turn.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("OG_034", foo);
            //Y'Shaarj, Rage Unbound At the end of your turn, put a minion from your deck into the battlefield.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("OG_042", foo);
            //Evolved Kobold <b>Spell Damage +2</b>
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("OG_082", foo);
            //Darkspeaker <b>Battlecry:</b> Swap stats with a friendly minion.
            foo = new CardBase();
            foo.TargetFunc = Target.MinionImmuneTargetMinionUser;
            foo.PlayFunc = Play.Minion;
            Dict.Add("OG_102", foo);
            //Mukla, Tyrant of the Vale <b>Battlecry:</b> Add 2 Bananas to your hand.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("OG_122", foo);
            //Shifter Zerus Each turn this is in your hand, transform it into a random minion.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("OG_123", foo);
            //Twin Emperor Vek'lor [x]<b><b>Taunt</b> Battlecry:</ b > If your C'Thun has at least 10 Attack, summon another Emperor.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("OG_131", foo);
            //N'Zoth, the Corruptor <b>Battlecry:</b> Summon your <b>Deathrattle</b> minions that died this game.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("OG_133", foo);
            //Yogg-Saron, Hope's End <b>Battlecry:</b> Cast a random spell for each spell you've cast this game <i>(targets chosen randomly)</i>.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("OG_134", foo);
            //Nerubian Prophet At the start of your turn, reduce this card's Cost by (1).
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("OG_138", foo);
            //Faceless Behemoth 
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("OG_141", foo);
            //Eldritch Horror 
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("OG_142", foo);
            //Psych-o-Tron <b>Taunt</b> < b > Divine Shield </ b >
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("OG_145", foo);
            //Corrupted Healbot <b>Deathrattle:</b> Restore 8 Health to the enemy hero.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("OG_147", foo);
            //Aberrant Berserker <b>Enrage:</b> +2 Attack.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("OG_150", foo);
            //Tentacle of N'Zoth <b>Deathrattle:</b> Deal 1 damage to all minions.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("OG_151", foo);
            //Grotesque Dragonhawk <b>Windfury</b>
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("OG_152", foo);
            //Bog Creeper <b>Taunt</b>
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("OG_153", foo);
            //Bilefin Tidehunter <b>Battlecry:</b> Summon a 1/1 Ooze with <b>Taunt</b>.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("OG_156", foo);
            //Ooze <b>Taunt</b>
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("OG_156a", foo);
            //Zealous Initiate <b>Deathrattle:</b> Give a random friendly minion +1/+1.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("OG_158", foo);
            //Corrupted Seer <b>Battlecry:</b> Deal 2 damage to all non-Murloc minions.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("OG_161", foo);
            //Disciple of C'Thun <b>Battlecry:</b> Deal 2 damage. Give your C'Thun +2/+2 <i>(wherever it is)</i>.
            foo = new CardBase();
            foo.TargetFunc = Target.MinionTargetAll;
            foo.PlayFunc = Play.Minion;
            Dict.Add("OG_162", foo);
            //Blood of The Ancient One If you control two of these at the end of your turn, merge them into 'The Ancient One'.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("OG_173", foo);
            //The Ancient One 
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("OG_173a", foo);
            //Faceless Shambler <b>Taunt</b> < b > Battlecry:</ b > Copy a friendly minion's Attack and Health.
            foo = new CardBase();
            foo.TargetFunc = Target.MinionImmuneTargetMinionUser;
            foo.PlayFunc = Play.Minion;
            Dict.Add("OG_174", foo);
            //Validated Doomsayer At the start of your turn, set this minion's Attack to 7.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("OG_200", foo);
            //Twisted Worgen <b>Stealth</b>
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("OG_247", foo);
            //Am'gam Rager 
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("OG_248", foo);
            //Infested Tauren <b>Taunt</b> < b > Deathrattle:</ b > Summon a 2 / 2 Slime.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("OG_249", foo);
            //Slime 
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("OG_249a", foo);
            //Eater of Secrets <b>Battlecry:</b> Destroy all enemy <b>Secrets</b>. Gain +1/+1 for each.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("OG_254", foo);
            //Doomcaller <b>Battlecry:</b> Give your C'Thun +2/+2 <i>(wherever it is).</i> If it's dead, shuffle it into your deck.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("OG_255", foo);
            //Spawn of N'Zoth <b>Deathrattle:</b> Give your minions +1/+1.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("OG_256", foo);
            //Nerubian Soldier 
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("OG_270a", foo);
            //Scaled Nightmare At the start of your turn, double this minion's Attack.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("OG_271", foo);
            //Twilight Summoner <b>Deathrattle:</b> Summon a 5/5 Faceless Destroyer.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("OG_272", foo);
            //Faceless Destroyer 
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("OG_272t", foo);
            //C'Thun <b>Battlecry:</b> Deal damage equal to this minion's Attack randomly split among all enemies.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("OG_279", foo);
            //C'Thun <b>Battlecry:</b> Deal damage equal to this minion's Attack randomly split among all enemies.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("OG_280", foo);
            //Beckoner of Evil <b>Battlecry:</b> Give your C'Thun +2/+2 <i>(wherever it is).</i>
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("OG_281", foo);
            //C'Thun's Chosen [x]<b>Divine Shield</b> < b > Battlecry:</ b > Give your C'Thun + 2 / +2 < i > (wherever it is).</ i >
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("OG_283", foo);
            //Twilight Geomancer [x]<b>Taunt</b> < b > Battlecry:</ b > Give your C'Thun < b > Taunt </ b > < i > (wherever it is).</ i >
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("OG_284", foo);
            //Twilight Elder At the end of your turn, give your C'Thun +1/+1 <i>(wherever it is).</i>
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("OG_286", foo);
            //Ancient Harbinger At the start of your turn, put a 10-Cost minion from your deck into your hand.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("OG_290", foo);
            //Cult Apothecary <b>Battlecry:</b> For each enemy minion, restore 2 Health to your hero.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("OG_295", foo);
            //The Boogeymonster Whenever this attacks and kills a minion, gain +2/+2.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("OG_300", foo);
            //Deathwing, Dragonlord <b>Deathrattle:</b> Put all Dragons from your hand into the battlefield.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("OG_317", foo);
            //Hogger, Doom of Elwynn Whenever this minion takes damage, summon a 2/2 Gnoll with <b>Taunt</b>.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("OG_318", foo);
            //Gnoll <b>Taunt</b>
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("OG_318t", foo);
            //Twin Emperor Vek'nilash <b>Taunt</b>
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("OG_319", foo);
            //Midnight Drake <b>Battlecry:</b> Gain +1 Attack for each other card in your hand.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("OG_320", foo);
            //Crazed Worshipper <b>Taunt.</b> Whenever this minion takes damage, give your C'Thun +1/+1 <i>(wherever it is).</i>
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("OG_321", foo);
            //Blackwater Pirate Your weapons cost (2) less.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("OG_322", foo);
            //Polluted Hoarder <b>Deathrattle:</b> Draw a card.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("OG_323", foo);
            //Duskboar 
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("OG_326", foo);
            //Squirming Tentacle <b>Taunt</b>
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("OG_327", foo);
            //Cyclopian Horror <b>Taunt</b>. <b>Battlecry:</b> Gain      +1 Health for each enemy minion.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("OG_337", foo);
            //Nat, the Darkfisher At the start of your opponent's turn, they have a 50% chance to draw an extra card.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("OG_338", foo);
            //Skeram Cultist <b>Battlecry:</b> Give your C'Thun +2/+2 <i>(wherever it is).</i>
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("OG_339", foo);
            //Soggoth the Slitherer <b>Taunt</b> Can't be targeted by spells or Hero Powers.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("OG_340", foo);

        }
        public static void KARA(Dictionary<string, CardBase> Dict)
        {
            //Pompous Thespian <b>Taunt</b>
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("KAR_011", foo);
            //Runic Egg <b>Deathrattle:</b> Draw a card.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("KAR_029", foo);
            //Cellar Spider 
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("KAR_030", foo);
            //Pantry Spider <b>Battlecry:</b> Summon a 1 / 3 Spider.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("KAR_030a", foo);
            //Book Wyrm <b>Battlecry:</b> If you're holding a Dragon, destroy an enemy minion with 3 or less Attack.
            foo = new CardBase();
            foo.TargetFunc = () => Target.HasInHand((card) => card.Race.Equals(Race.DRAGON), () => Target.MinionImmuneTargetMinionEnemy((card) => card.Attack <= 3));
            foo.PlayFunc = Play.Minion;
            Dict.Add("KAR_033", foo);
            //Arcane Anomaly Whenever you cast a spell, give this minion +1 Health.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("KAR_036", foo);
            //Avian Watcher <b>Battlecry:</b> If you control a <b>Secret</b>, gain +1/+1 and<b> Taunt</ b >.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("KAR_037", foo);
            //Moat Lurker <b>Battlecry:</b> Destroy a minion. <b>Deathrattle:</b> Resummon it.
            foo = new CardBase();
            foo.TargetFunc = Target.MinionImmuneTargetMinionAll;
            foo.PlayFunc = Play.Minion;
            Dict.Add("KAR_041", foo);
            //Moroes <b>Stealth</b> At the end of your turn, summon a 1 / 1 Steward.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("KAR_044", foo);
            //Steward 
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("KAR_044a", foo);
            //The Curator <b>Taunt</b> < b > Battlecry:</ b > Draw a Beast, Dragon, and Murloc from your deck.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("KAR_061", foo);
            //Netherspite Historian <b>Battlecry:</b> If you're holding a Dragon, <b>Discover</b> a Dragon.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("KAR_062", foo);
            //Zoobot <b>Battlecry:</b> Give a random friendly Beast, Dragon, and Murloc +1/+1.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("KAR_095", foo);
            //Prince Malchezaar [x]When the game starts, add 5 extra<b> Legendary</ b > minions to your deck.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("KAR_096", foo);
            //Medivh, the Guardian <b>Battlecry:</b> Equip Atiesh, Greatstaff of the Guardian.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("KAR_097", foo);
            //Atiesh [x]After you cast a spell, summon a random minion of that Cost. Lose 1 Durability.
            foo = new CardBase();
            Dict.Add("KAR_097t", foo);
            //Barnes <b>Battlecry:</b> Summon a 1/1 copy of a random minion in your deck.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("KAR_114", foo);
            //Menagerie Magician <b>Battlecry:</b> Give a random friendly Beast, Dragon, and Murloc +2/+2.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("KAR_702", foo);
            //Arcanosmith <b>Battlecry:</b> Summon a 0/5 minion with <b>Taunt</b>.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("KAR_710", foo);
            //Animated Shield <b>Taunt</b>
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("KAR_710m", foo);
            //Arcane Giant [x]Costs (1) less for each spell you've cast this game.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("KAR_711", foo);
            //Violet Illusionist During your turn, your hero is <b>Immune</b>.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("KAR_712", foo);

            //Magic Mirror 
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("KAR_A01_01", foo);
            //Magic Mirror 
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("KAR_A01_01H", foo);
            //Reflections <b>Passive Hero Power</b> Whenever a minion is played, summon a 1 / 1 copy of it.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("KAR_A01_02", foo);
            //Reflections <b>Passive Hero Power</b> Whenever a minion is played, Magic Mirror summons a 1 / 1 copy of it.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("KAR_A01_02H", foo);
            //Plate 
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("KAR_A02_01", foo);
            //Plate 
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("KAR_A02_01H", foo);
            //Spoon 
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("KAR_A02_02", foo);
            //Spoon 
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("KAR_A02_02H", foo);
            //Fork Plates have <b>Charge</b>.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("KAR_A02_03", foo);
            //Fork Plates have <b>Charge</b>.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("KAR_A02_03H", foo);
            //Knife Plates have <b>Taunt</b>.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("KAR_A02_04", foo);
            //Knife Plates have <b>Taunt</b>.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("KAR_A02_04H", foo);
            //Cup Plates have +1 Attack.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("KAR_A02_05", foo);
            //Cup Plates have +3 Attack.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("KAR_A02_05H", foo);
            //Pitcher <b>Battlecry:</b> Give a minion +2/+2.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("KAR_A02_06", foo);
            //Pitcher <b>Battlecry:</b> Give a minion +3/+3.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("KAR_A02_06H", foo);
            //Set the Table Give your Plates +1/+1.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("KAR_A02_09", foo);
            //Set the Table Give your Plates +2/+2.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("KAR_A02_09H", foo);
            //Pour a Round Draw a card for each of your Plates.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("KAR_A02_10", foo);
            //Tossing Plates Summon five 1/1 Plates.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("KAR_A02_11", foo);
            //Silverware Golem 
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("KAR_A02_12", foo);
            //Silverware Golem 
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("KAR_A02_12H", foo);
            //Be Our Guest <b>Hero Power</b> Summon a 1 / 1 Plate.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("KAR_A02_13", foo);
            //Be Our Guest <b>Hero Power</b> Summon two 1 / 1 Plates.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("KAR_A02_13H", foo);
            //Black Pawn <b>Auto-Attack:</b> Deal 1 damage to the enemies opposite this minion.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("KAR_A10_01", foo);
            //White Pawn <b>Auto-Attack:</b> Deal 1 damage to the enemies opposite this minion.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("KAR_A10_02", foo);
            //Black Rook <b>Auto-Attack:</b> Deal 2 damage to the enemies opposite this minion.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("KAR_A10_03", foo);
            //White Rook <b>Auto-Attack:</b> Deal 2 damage to the enemies opposite this minion.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("KAR_A10_04", foo);
            //White Bishop <b>Auto-Attack:</b> Restore 2 Health to adjacent minions.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("KAR_A10_05", foo);
            //Black Bishop <b>Auto-Attack:</b> Restore 2 Health to adjacent minions.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("KAR_A10_06", foo);
            //Black Knight <b>Charge</b>. Can't Attack Heroes.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("KAR_A10_07", foo);
            //White Knight <b>Charge</b>. Can't Attack Heroes.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("KAR_A10_08", foo);
            //White Queen <b>Auto-Attack:</b> Deal 4 damage to the enemies opposite this minion.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("KAR_A10_09", foo);
            //Black Queen <b>Auto-Attack:</b> Deal 4 damage to the enemies opposite this minion.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("KAR_A10_10", foo);
            //Castle <b>Hero Power</b> < b > Discover </ b > a chess piece.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("KAR_A10_22", foo);
            //Castle <b>Hero Power</b> Move a friendly minion left.Repeatable.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("KAR_A10_22H", foo);
            //Cheat <b>Hero Power</b> Destroy the left - most enemy minion.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("KAR_A10_33", foo);
            //White King 
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("KAR_a10_Boss1", foo);
            //White King 
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("KAR_a10_Boss1H", foo);
            //Black King 
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("KAR_a10_Boss2", foo);
            //Black King 
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("KAR_a10_Boss2H", foo);
            //Prince Malchezaar 
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("KARA_00_01", foo);
            //Prince Malchezaar 
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("KARA_00_01H", foo);
            //Legion <b>Hero Power</b> Summon a 6 / 6 Abyssal.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("KARA_00_02", foo);
            //Legion <b>Hero Power</b> Summon a 6 / 6 Abyssal.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("KARA_00_02H", foo);
            //Medivh 
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("KARA_00_03c", foo);
            //Brilliance <b>Hero Power</b> Draw 3 cards.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("KARA_00_04", foo);
            //Brilliance <b>Hero Power</b> Draw 3 cards.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("KARA_00_04H", foo);
            //Dorothee Minions to the left have <b>Charge</b>. Minions to the right have <b>Taunt</b>.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("KARA_04_01", foo);
            //The Crone 
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("KARA_04_01h", foo);
            //The Crone 
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("KARA_04_01heroic", foo);
            //Twister <b>Hero Power</b> Deal 100 damage.Can't be used if Dorothee is alive.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("KARA_04_02hp", foo);
            //Flying Monkey <b>Charge</b>
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("KARA_04_05", foo);
            //Flying Monkey <b>Charge</b>
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("KARA_04_05h", foo);
            //Kindly Grandmother 
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("KARA_05_01b", foo);
            //Big Bad Wolf 
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("KARA_05_01h", foo);
            //Big Bad Wolf 
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("KARA_05_01hheroic", foo);
            //Trembling <b>Passive Hero Power</b> Enemy minions are 1/1 and cost (1).
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("KARA_05_01hp", foo);
            //Trembling <b>Passive Hero Power</b> Minions cost (1). Enemy minions are 1/1.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("KARA_05_01hpheroic", foo);
            //Big Bad Claws 
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("KARA_05_02", foo);
            //Big Bad Claws 
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("KARA_05_02heroic", foo);
            //Romulo Julianne is <b>Immune</b>.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("KARA_06_01", foo);
            //Romulo Julianne is <b>Immune</b>.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("KARA_06_01heroic", foo);
            //Julianne 
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("KARA_06_02", foo);
            //Julianne 
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("KARA_06_02heroic", foo);
            //True Love <b>Hero Power</b> If you don't have Romulo, summon him.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("KARA_06_03hp", foo);
            //True Love <b>Hero Power</b> If you don't have Romulo, summon him.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("KARA_06_03hpheroic", foo);
            //Curator 
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("KARA_07_01", foo);
            //Curator 
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("KARA_07_01heroic", foo);
            //Gallery Protection <b>Passive Hero Power</b>  Your hero has<b> Taunt</ b >.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("KARA_07_02", foo);
            //Murloc Escaping! Summon a random Murloc.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("KARA_07_03", foo);
            //Murlocs Escaping! Summon two random Murlocs.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("KARA_07_03heroic", foo);
            //Stampeding Beast! Summon a random Beast.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("KARA_07_05", foo);
            //Stampeding Beast! Summon a random Beast.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("KARA_07_05heroic", foo);
            //Demons Loose! Summon a random Demon.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("KARA_07_06", foo);
            //Demons Loose! Summon a random Demon.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("KARA_07_06heroic", foo);
            //Haywire Mech! Summon a random Mech.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("KARA_07_07", foo);
            //Haywire Mech! Summon a random Mech.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("KARA_07_07heroic", foo);
            //Dragons Free! Summon a random Dragon.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("KARA_07_08", foo);
            //Dragons Free! Summon a random Dragon.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("KARA_07_08heroic", foo);
            //Netherspite 
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("KARA_08_01", foo);
            //Netherspite 
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("KARA_08_01H", foo);
            //Nether Rage <b>Hero Power</b> Give your hero + 3 Attack this turn.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("KARA_08_02", foo);
            //Nether Rage <b>Hero Power</b> Give your hero + 8 Attack this turn.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("KARA_08_02H", foo);
            //Nether Breath [x]Change the Health of all enemy minions to 1.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("KARA_08_03", foo);
            //Nether Breath [x]Change the Health of all enemy minions to 1.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("KARA_08_03H", foo);
            //Empowerment Give your hero +8 Attack this turn.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("KARA_08_04", foo);
            //Terrifying Roar Return an enemy minion to your opponent's hand.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("KARA_08_05", foo);
            //Terrifying Roar Return an enemy minion to your opponent's hand.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("KARA_08_05H", foo);
            //Blue Portal The character in the blue beam only takes 1 damage at a time.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("KARA_08_06", foo);
            //Red Portal The character in the red beam has <b>Windfury</b>.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("KARA_08_08", foo);
            //Terestian Illhoof 
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("KARA_09_01", foo);
            //Terestian Illhoof 
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("KARA_09_01heroic", foo);
            //Curator 
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("KARA_09_02", foo);
            //Many Imps! Summon 2 Icky Imps.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("KARA_09_03", foo);
            //Icky Imp <b>Deathrattle:</b> Resummon this minion and Illhoof loses 2 Health.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("KARA_09_03a", foo);
            //Icky Imp <b>Deathrattle:</b> Resummon this minion and Illhoof loses 2 Health.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("KARA_09_03a_heroic", foo);
            //Many Imps! Summon 2 Icky Imps.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("KARA_09_03heroic", foo);
            //Dark Pact <b>Passive Hero Power</b> Only Icky Imps can damage Illhoof!
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("KARA_09_04", foo);
            //Summon Kil'rek Summon Kil'rek.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("KARA_09_05", foo);
            //Summon Kil'rek Summon Kil'rek.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("KARA_09_05heroic", foo);
            //Shadow Volley Deal $3 damage to all non-Demon minions.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("KARA_09_06", foo);
            //Shadow Volley Deal $3 damage to all non-Demon minions.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("KARA_09_06heroic", foo);
            //Steal Life Deal $5 damage. Restore #5 Health to your hero.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("KARA_09_07", foo);
            //Steal Life Deal $5 damage. Restore #5 Health to your hero.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("KARA_09_07heroic", foo);
            //Nightbane 
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("KARA_11_01", foo);
            //Nightbane 
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("KARA_11_01heroic", foo);
            //Manastorm <b>Passive Hero Power</b> Players start with 10 Mana Crystals.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("KARA_11_02", foo);
            //Ley Lines [x]<b>Passive Hero Power</b> Both players have <b> Spell Damage + 3 </ b >.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("KARA_12_02", foo);
            //Ley Lines [x]<b>Passive Hero Power</b> Both players have <b> Spell Damage + 5 </ b >.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("KARA_12_02H", foo);
            //Prince Malchezaar 
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("KARA_13_06", foo);
            //Prince Malchezaar 
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("KARA_13_06H", foo);
            //Shadow Bolt Volley Deal $4 damage to three random enemies.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("KARA_13_11", foo);
            //Demonic Presence Draw 2 cards. Gain 10 Armor.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("KARA_13_12", foo);
            //Demonic Presence Draw 3 cards. Gain 10 Armor.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("KARA_13_12H", foo);
            //Legion <b>Hero Power</b> Summon a 6 / 6 Abyssal.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("KARA_13_13", foo);
            //Legion <b>Hero Power</b> Summon two 6 / 6 Abyssals.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("KARA_13_13H", foo);
            //Atiesh [x]After you cast a spell, summon a random minion of that Cost. Lose 1 Durability.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("KARA_13_26", foo);

        }
        public static void GANGS(Dictionary<string, CardBase> Dict)
        {
            //Wind-up Burglebot Whenever this attacks a minion and survives, draw a card.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("CFM_025", foo);
            //Street Trickster <b>Spell Damage +1</b>
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("CFM_039", foo);
            //Red Mana Wyrm Whenever  you cast a spell, gain +2 Attack.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("CFM_060", foo);
            //Kooky Chemist <b>Battlecry:</b> Swap the Attack and Health of a minion.
            foo = new CardBase();
            foo.TargetFunc = Target.MinionImmuneTargetMinionAll;
            foo.PlayFunc = Play.Minion;
            Dict.Add("CFM_063", foo);
            //Blubber Baron Whenever you summon a <b>Battlecry</b> minion while this is in your hand, gain +1/+1.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("CFM_064", foo);
            //Hozen Healer <b>Battlecry</b>: Restore a minion to full Health.
            foo = new CardBase();
            foo.TargetFunc = Target.MinionImmuneTargetMinionAll;
            foo.PlayFunc = Play.Minion;
            Dict.Add("CFM_067", foo);
            //Weasel Tunneler <b>Deathrattle:</b> Shuffle this minion into your opponent's deck.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("CFM_095", foo);
            //Mistress of Mixtures <b>Deathrattle:</b> Restore 4 Health to each hero.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("CFM_120", foo);
            //Grimestreet Informant [x]<b>Battlecry:</b> <b>Discover</b> a Hunter, Paladin, or Warrior card.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("CFM_321", foo);
            //Small-Time Buccaneer Has +2 Attack while you have a weapon equipped.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("CFM_325", foo);
            //Fight Promoter [x]<b>Battlecry:</b> If you control a minion with 6 or more Health, draw two cards.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("CFM_328", foo);
            //Sergeant Sally <b>Deathrattle:</b> Deal damage equal to this minion's Attack to all enemy minions.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("CFM_341", foo);
            //Finja, the Flying Star [x]<b>Stealth</b> Whenever this attacks and kills a minion, summon 2 Murlocs from your deck.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("CFM_344", foo);
            //Fel Orc Soulfiend At the start of your turn, deal 2 damage to this minion.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("CFM_609", foo);
            //Kabal Chemist <b>Battlecry:</b> Add a random Potion to your hand.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("CFM_619", foo);
            //Kazakus [x]<b>Battlecry:</b> If your deck has no duplicates, create a custom spell.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("CFM_621", foo);
            //Kabal Demon 
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("CFM_621_m2", foo);
            //Kabal Demon 
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("CFM_621_m3", foo);
            //Kabal Demon 
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("CFM_621_m4", foo);
            //Sheep 
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("CFM_621_m5", foo);
            //Kazakus Potion {0} { 1}
            foo = new CardBase();
            Dict.Add("CFM_621t", foo);
            //Netherbloom Summon a 2/2 Demon.
            foo = new CardBase();
            Dict.Add("CFM_621t10", foo);
            //Lesser Potion Create a 1-Cost spell.
            foo = new CardBase();
            Dict.Add("CFM_621t11", foo);
            //Greater Potion Create a 5-Cost spell.
            foo = new CardBase();
            Dict.Add("CFM_621t12", foo);
            //Superior Potion Create a 10-Cost spell.
            foo = new CardBase();
            Dict.Add("CFM_621t13", foo);
            //Kazakus Potion {0} { 1}
            foo = new CardBase();
            Dict.Add("CFM_621t14", foo);
            //Kazakus Potion {0} { 1}
            foo = new CardBase();
            Dict.Add("CFM_621t15", foo);
            //Heart of Fire Deal $5 damage.
            foo = new CardBase();
            foo.TargetFunc = Target.MinionTargetAll;
            foo.PlayFunc = Play.SpellTargetAll;
            Dict.Add("CFM_621t16", foo);
            //Stonescale Oil Gain 7 Armor.
            foo = new CardBase();
            Dict.Add("CFM_621t17", foo);
            //Felbloom Deal $4 damage to all minions.
            foo = new CardBase();
            Dict.Add("CFM_621t18", foo);
            //Icecap <b>Freeze</b> 2 random enemy minions.
            foo = new CardBase();
            Dict.Add("CFM_621t19", foo);
            //Heart of Fire Deal $3 damage.
            foo = new CardBase();
            foo.TargetFunc = Target.MinionTargetAll;
            foo.PlayFunc = Play.SpellTargetAll;
            Dict.Add("CFM_621t2", foo);
            //Netherbloom Summon a 5/5 Demon.
            foo = new CardBase();
            Dict.Add("CFM_621t20", foo);
            //Mystic Wool Polymorph a random enemy minion.
            foo = new CardBase();
            Dict.Add("CFM_621t21", foo);
            //Kingsblood Draw 2 cards.
            foo = new CardBase();
            Dict.Add("CFM_621t22", foo);
            //Shadow Oil Add 2 random Demons to your hand.
            foo = new CardBase();
            Dict.Add("CFM_621t23", foo);
            //Goldthorn Give your minions +4 Health.
            foo = new CardBase();
            Dict.Add("CFM_621t24", foo);
            //Heart of Fire Deal $8 damage.
            foo = new CardBase();
            foo.TargetFunc = Target.MinionTargetAll;
            foo.PlayFunc = Play.SpellTargetAll;
            Dict.Add("CFM_621t25", foo);
            //Stonescale Oil Gain 10 Armor.
            foo = new CardBase();
            Dict.Add("CFM_621t26", foo);
            //Icecap <b>Freeze</b> 3 random enemy minions.
            foo = new CardBase();
            Dict.Add("CFM_621t27", foo);
            //Netherbloom Summon an 8/8 Demon.
            foo = new CardBase();
            Dict.Add("CFM_621t28", foo);
            //Mystic Wool Transform all minions into 1/1 Sheep.
            foo = new CardBase();
            Dict.Add("CFM_621t29", foo);
            //Stonescale Oil Gain 4 Armor.
            foo = new CardBase();
            Dict.Add("CFM_621t3", foo);
            //Kingsblood Draw 3 cards.
            foo = new CardBase();
            Dict.Add("CFM_621t30", foo);
            //Shadow Oil Add 3 random Demons to your hand.
            foo = new CardBase();
            Dict.Add("CFM_621t31", foo);
            //Goldthorn Give your minions +6 Health.
            foo = new CardBase();
            Dict.Add("CFM_621t32", foo);
            //Felbloom Deal $6 damage to all minions.
            foo = new CardBase();
            Dict.Add("CFM_621t33", foo);
            //Ichor of Undeath Summon a friendly minion that died this game.
            foo = new CardBase();
            Dict.Add("CFM_621t37", foo);
            //Ichor of Undeath Summon 2 friendly minions that died this game.
            foo = new CardBase();
            Dict.Add("CFM_621t38", foo);
            //Ichor of Undeath Summon 3 friendly minions that died this game.
            foo = new CardBase();
            Dict.Add("CFM_621t39", foo);
            //Felbloom Deal $2 damage to all minions.
            foo = new CardBase();
            Dict.Add("CFM_621t4", foo);
            //Icecap <b>Freeze</b> a random enemy minion.
            foo = new CardBase();
            Dict.Add("CFM_621t5", foo);
            //Goldthorn Give your minions +2 Health.
            foo = new CardBase();
            Dict.Add("CFM_621t6", foo);
            //Kingsblood Draw a card.
            foo = new CardBase();
            Dict.Add("CFM_621t8", foo);
            //Shadow Oil Add a random Demon to your hand.
            foo = new CardBase();
            Dict.Add("CFM_621t9", foo);
            //Patches the Pirate [x]<b>Charge</b> After you play a Pirate, summon this minion from your deck.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("CFM_637", foo);
            //Backstreet Leper [x]<b>Deathrattle:</b> Deal 2 damage to the enemy hero.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("CFM_646", foo);
            //Blowgill Sniper <b>Battlecry:</b> Deal 1 damage.
            foo = new CardBase();
            foo.TargetFunc = Target.MinionTargetAll;
            foo.PlayFunc = Play.Minion;
            Dict.Add("CFM_647", foo);
            //Big-Time Racketeer <b>Battlecry:</b> Summon a 6/6 Ogre.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("CFM_648", foo);
            //"Little Friend" 
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("CFM_648t", foo);
            //Kabal Courier <b>Battlecry:</b> <b>Discover</b> a Mage, Priest, or Warlock card.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("CFM_649", foo);
            //Naga Corsair <b>Battlecry:</b> Give your weapon +1 Attack.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("CFM_651", foo);
            //Second-Rate Bruiser [x]<b>Taunt</b> Costs(2) less if your opponent has at least three minions.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("CFM_652", foo);
            //Hired Gun <b>Taunt</b>
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("CFM_653", foo);
            //Friendly Bartender At the end of your turn, restore 1 Health to your hero.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("CFM_654", foo);
            //Toxic Sewer Ooze <b>Battlecry:</b> Remove 1 Durability from your opponent's weapon.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("CFM_655", foo);
            //Streetwise Investigator <b>Battlecry:</b> Enemy minions lose <b>Stealth</b>.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("CFM_656", foo);
            //Backroom Bouncer Whenever a friendly minion dies, gain +1 Attack.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("CFM_658", foo);
            //Gadgetzan Socialite <b>Battlecry:</b> Restore 2 Health.
            foo = new CardBase();
            foo.TargetFunc = Target.MinionImmuneTargetAll;
            foo.PlayFunc = Play.Minion;
            Dict.Add("CFM_659", foo);
            //Worgen Greaser 
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("CFM_665", foo);
            //Grook Fu Master <b>Windfury</b>
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("CFM_666", foo);
            //Bomb Squad [x]<b>Battlecry:</b> Deal 5 damage to an enemy minion. < b > Deathrattle:</ b > Deal 5 damage to your hero.
            foo = new CardBase();
            foo.TargetFunc = Target.MinionTargetMinionAll;
            foo.PlayFunc = Play.Minion;
            Dict.Add("CFM_667", foo);
            //Doppelgangster <b>Battlecry:</b> Summon 2 copies of this minion.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("CFM_668", foo);
            //Doppelgangster <b>Battlecry:</b> Summon 2 copies of this minion.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("CFM_668t", foo);
            //Doppelgangster <b>Battlecry:</b> Summon 2 copies of this minion.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("CFM_668t2", foo);
            //Burgly Bully Whenever your opponent casts a spell, add a Coin to your hand.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("CFM_669", foo);
            //Mayor Noggenfogger All targets are chosen randomly.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("CFM_670", foo);
            //Madam Goya <b>Battlecry:</b> Choose a friendly minion. Swap it with a minion in your deck.
            foo = new CardBase();
            foo.TargetFunc = Target.MinionImmuneTargetMinionUser;
            foo.PlayFunc = Play.Minion;
            Dict.Add("CFM_672", foo);
            //Don Han'Cho <b>Battlecry:</b> Give a random minion in your hand +5/+5.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("CFM_685", foo);
            //Spiked Hogrider <b>Battlecry:</b> If an enemy minion has <b>Taunt</b>, gain <b>Charge</b>.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("CFM_688", foo);
            //Jade Golem 
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("CFM_712_t01", foo);
            //Jade Golem 
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("CFM_712_t02", foo);
            //Jade Golem 
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("CFM_712_t03", foo);
            //Jade Golem 
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("CFM_712_t04", foo);
            //Jade Golem 
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("CFM_712_t05", foo);
            //Jade Golem 
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("CFM_712_t06", foo);
            //Jade Golem 
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("CFM_712_t07", foo);
            //Jade Golem 
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("CFM_712_t08", foo);
            //Jade Golem 
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("CFM_712_t09", foo);
            //Jade Golem 
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("CFM_712_t10", foo);
            //Jade Golem 
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("CFM_712_t11", foo);
            //Jade Golem 
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("CFM_712_t12", foo);
            //Jade Golem 
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("CFM_712_t13", foo);
            //Jade Golem 
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("CFM_712_t14", foo);
            //Jade Golem 
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("CFM_712_t15", foo);
            //Jade Golem 
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("CFM_712_t16", foo);
            //Jade Golem 
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("CFM_712_t17", foo);
            //Jade Golem 
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("CFM_712_t18", foo);
            //Jade Golem 
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("CFM_712_t19", foo);
            //Jade Golem 
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("CFM_712_t20", foo);
            //Jade Golem 
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("CFM_712_t21", foo);
            //Jade Golem 
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("CFM_712_t22", foo);
            //Jade Golem 
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("CFM_712_t23", foo);
            //Jade Golem 
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("CFM_712_t24", foo);
            //Jade Golem 
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("CFM_712_t25", foo);
            //Jade Golem 
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("CFM_712_t26", foo);
            //Jade Golem 
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("CFM_712_t27", foo);
            //Jade Golem 
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("CFM_712_t28", foo);
            //Jade Golem 
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("CFM_712_t29", foo);
            //Jade Golem 
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("CFM_712_t30", foo);
            //Jade Spirit <b>Battlecry:</b> Summon a <b>Jade Golem</b>.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("CFM_715", foo);
            //Dirty Rat [x]<b>Taunt</b> < b > Battlecry:</ b > Your opponent summons a random minion from their hand.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("CFM_790", foo);
            //Wrathion <b>Taunt</b>. <b>Battlecry:</b> Draw cards until you draw one that isn't a Dragon.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("CFM_806", foo);
            //Auctionmaster Beardo After you cast a spell, refresh your Hero Power.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("CFM_807", foo);
            //Genzo, the Shark Whenever this attacks, both players draw until they have 3 cards.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("CFM_808", foo);
            //Tanaris Hogchopper [x]<b>Battlecry:</b> If your opponent's hand is empty, gain<b> Charge</ b >.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("CFM_809", foo);
            //Leatherclad Hogleader <b>Battlecry:</b> If your opponent has 6 or more cards in hand, gain <b>Charge</b>.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("CFM_810", foo);
            //Daring Reporter Whenever your opponent draws a card, gain +1/+1.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("CFM_851", foo);
            //Lotus Agents <b>Battlecry:</b> <b>Discover</b> a Druid, Rogue, or Shaman card.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("CFM_852", foo);
            //Grimestreet Smuggler <b>Battlecry:</b> Give a random minion in your hand +1/+1.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("CFM_853", foo);
            //Ancient of Blossoms <b>Taunt</b>
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("CFM_854", foo);
            //Defias Cleaner <b>Battlecry:</b> <b>Silence</b> a minion with <b>Deathrattle</b>.
            foo = new CardBase();
            foo.TargetFunc = () => Target.MinionImmuneTargetMinionAll((card) => card.Deathrattle);
            foo.PlayFunc = Play.Minion;
            Dict.Add("CFM_855", foo);
            //Aya Blackpaw  <b>Battlecry and Deathrattle:</b> Summon a <b>Jade Golem</b>.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("CFM_902", foo);

        }
        public static void UNGORO(Dictionary<string, CardBase> Dict)
        {
            //Stubborn Gastropod <b>Taunt</b>, <b>Poisonous</b>
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("ICC_828t2", foo);
            //Giant Wasp <b>Stealth</b>, <b>Poisonous</b>
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("ICC_828t3", foo);
            //Pterrordax Hatchling <b><b>Battlecry:</b> Adapt</b>.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("UNG_001", foo);
            //Volcanosaur <b>Battlecry:</b> <b>Adapt</b>, then <b>Adapt</b>.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("UNG_002", foo);
            //Ravasaur Runt <b>Battlecry:</b> If you control at least 2 other minions, <b>Adapt.</b>
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("UNG_009", foo);
            //Sated Threshadon <b>Deathrattle:</b> Summon three 1/1 Murlocs.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("UNG_010", foo);
            //Tol'vir Stoneshaper [x]<b>Battlecry:</b> If you played an Elemental last turn, gain <b> Taunt</ b > and < b > DivineShield </ b >.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("UNG_070", foo);
            //Giant Mastodon <b>Taunt</b>
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("UNG_071", foo);
            //Stonehill Defender <b>Taunt</b> < b > Battlecry:</ b > < b > Discover </ b > a < b > Taunt </ b > minion.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("UNG_072", foo);
            //Rockpool Hunter <b>Battlecry:</b> Give a friendly Murloc +1/+1.
            foo = new CardBase();
            foo.TargetFunc = () => Target.MinionImmuneTargetMinionUser((card) => card.Race.Equals(Race.MURLOC));
            foo.PlayFunc = Play.Minion;
            Dict.Add("UNG_073", foo);
            //Vicious Fledgling After this minion attacks a hero, <b>Adapt</b>.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("UNG_075", foo);
            //Eggnapper <b>Deathrattle:</b> Summon two 1/1 Raptors.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("UNG_076", foo);
            //Raptor 
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("UNG_076t1", foo);
            //Frozen Crusher After this minion attacks, <b>Freeze</b> it.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("UNG_079", foo);
            //Thunder Lizard <b>Battlecry</b>: If you played an Elemental last turn, <b>Adapt</b>.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("UNG_082", foo);
            //Devilsaur Egg <b>Deathrattle:</b> Summon a 5/5 Devilsaur.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("UNG_083", foo);
            //Devilsaur 
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("UNG_083t1", foo);
            //Fire Plume Phoenix <b>Battlecry:</b> Deal 2 damage.
            foo = new CardBase();
            foo.TargetFunc = Target.MinionTargetAll;
            foo.PlayFunc = Play.Minion;
            Dict.Add("UNG_084", foo);
            //Emerald Hive Queen Your minions cost (2) more.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("UNG_085", foo);
            //Bittertide Hydra Whenever this minion takes damage, deal 3 damage to your hero.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("UNG_087", foo);
            //Tortollan Primalist <b>Battlecry:</b> <b>Discover</b> a spell and cast it with random targets.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("UNG_088", foo);
            //Gentle Megasaur <b>Battlecry:</b> <b>Adapt</b> your Murlocs.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("UNG_089", foo);
            //Charged Devilsaur <b>Charge</b> < b > Battlecry:</ b > Can't attack heroes this turn.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("UNG_099", foo);
            //Bright-Eyed Scout <b>Battlecry:</b> Draw a card. Change its Cost to (5).
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("UNG_113", foo);
            //Primalfin 
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("UNG_201t", foo);
            //Glacial Shard <b>Battlecry:</b> <b>Freeze</b> an enemy.
            foo = new CardBase();
            foo.TargetFunc = Target.MinionImmuneTargetEnemy;
            foo.PlayFunc = Play.Minion;
            Dict.Add("UNG_205", foo);
            //Nesting Roc <b>Battlecry:</b> If you control at least 2 other minions, gain <b>Taunt</b>.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("UNG_801", foo);
            //Emerald Reaver <b>Battlecry:</b> Deal 1 damage to each hero.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("UNG_803", foo);
            //Ultrasaur 
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("UNG_806", foo);
            //Golakka Crawler <b>Battlecry:</b> Destroy a Pirate and gain +1/+1.
            foo = new CardBase();
            foo.TargetFunc = () => Target.MinionImmuneTargetMinionAll((card) => card.Race.Equals(Race.PIRATE));
            foo.PlayFunc = Play.Minion;
            Dict.Add("UNG_807", foo);
            //Stubborn Gastropod <b>Taunt</b> < b > Poisonous </ b >
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("UNG_808", foo);
            //Fire Fly <b>Battlecry</b>: Add a 1/2 Elemental to your hand.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("UNG_809", foo);
            //Flame Elemental 
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("UNG_809t1", foo);
            //Stegodon <b>Taunt</b>
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("UNG_810", foo);
            //Sabretooth Stalker <b>Stealth</b>
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("UNG_812", foo);
            //Stormwatcher <b>Windfury</b>
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("UNG_813", foo);
            //Giant Wasp <b>Stealth</b> < b > Poisonous </ b >
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("UNG_814", foo);
            //Servant of Kalimos [x]<b>Battlecry:</b> If you played an Elemental last turn, < b > Discover </ b > an Elemental.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("UNG_816", foo);
            //Volatile Elemental <b>Deathrattle:</b> Deal 3 damage to a random enemy minion.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("UNG_818", foo);
            //Hemet, Jungle Hunter <b>Battlecry:</b> Destroy all cards in your deck that cost (3) or less.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("UNG_840", foo);
            //The Voraxx [x]After you cast a spell on this minion, summon a 1 / 1 Plant and cast another copy on it.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("UNG_843", foo);
            //Humongous Razorleaf Can't attack.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("UNG_844", foo);
            //Igneous Elemental <b>Deathrattle:</b> Add two 1/2 Elementals to your hand.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("UNG_845", foo);
            //Blazecaller <b>Battlecry:</b> If you played an Elemental last turn, deal 5 damage.
            foo = new CardBase();
            foo.TargetFunc = Target.MinionTargetAll;
            foo.PlayFunc = Play.Minion;
            Dict.Add("UNG_847", foo);
            //Primordial Drake [x]<b>Taunt</b> < b > Battlecry:</ b > Deal 2 damage to all other minions.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("UNG_848", foo);
            //Elise the Trailblazer <b>Battlecry:</b> Shuffle a sealed <b>Un'Goro</b> pack into your deck.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("UNG_851", foo);
            //Un'Goro Pack Add 5 <b>Journey to Un'Goro</b> cards to your hand.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("UNG_851t1", foo);
            //Spiritsinger Umbra After you summon a minion, trigger its <b>Deathrattle</b> effect.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("UNG_900", foo);
            //Ozruk [x]<b>Taunt</b> < b > Battlecry:</ b > Gain + 5 Health for each Elemental you played last turn.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("UNG_907", foo);
            //Tar Creeper <b>Taunt</b> Has + 2 Attack during your opponent's turn.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("UNG_928", foo);
            //DIE, INSECT! <b>Hero Power</b> Deal $8 damage to a random enemy.
            foo = new CardBase();
            foo.TargetFunc = Target.MinionTargetEnemy;
            foo.PlayFunc = Play.Minion;
            Dict.Add("UNG_934t2", foo);
            //Primalfin Lookout <b>Battlecry:</b> If you control another Murloc, <b>Discover</b> a Murloc.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("UNG_937", foo);
            //Gluttonous Ooze <b>Battlecry:</b> Destroy your opponent's weapon and gain Armor equal to its Attack.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("UNG_946", foo);
            //Shrouding Mist <b>Stealth</b> until your next turn.
            foo = new CardBase();
            Dict.Add("UNG_999t10", foo);
            //Poison Spit <b>Poisonous</b>
            foo = new CardBase();
            Dict.Add("UNG_999t13", foo);
            //Volcanic Might +1/+1
            foo = new CardBase();
            Dict.Add("UNG_999t14", foo);
            //Living Spores <b>Deathrattle:</b> Summon two 1/1 Plants.
            foo = new CardBase();
            Dict.Add("UNG_999t2", foo);
            //Plant 
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("UNG_999t2t1", foo);
            //Flaming Claws +3 Attack
            foo = new CardBase();
            Dict.Add("UNG_999t3", foo);
            //Rocky Carapace +3 Health
            foo = new CardBase();
            Dict.Add("UNG_999t4", foo);
            //Liquid Membrane Can't be targeted by spells or Hero Powers.
            foo = new CardBase();
            Dict.Add("UNG_999t5", foo);
            //Massive <b>Taunt</b>
            foo = new CardBase();
            Dict.Add("UNG_999t6", foo);
            //Lightning Speed <b>Windfury</b>
            foo = new CardBase();
            Dict.Add("UNG_999t7", foo);
            //Crackling Shield <b>Divine Shield</b>
            foo = new CardBase();
            Dict.Add("UNG_999t8", foo);

        }
        public static void ICECROWN(Dictionary<string, CardBase> Dict)
        {
            //Phantom Freebooter <b>Battlecry:</b> Gain stats equal to your weapon's.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("ICC_018", foo);
            //Skelemancer <b>Deathrattle:</b> If it's your opponent's turn, summon an 8/8 Skeleton.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("ICC_019", foo);
            //Skeletal Flayer 
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("ICC_019t", foo);
            //Snowflipper Penguin 
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("ICC_023", foo);
            //Rattling Rascal [x]<b>Battlecry:</b> Summon a 5 / 5 Skeleton. < b > Deathrattle:</ b > Summon one for your opponent. 
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("ICC_025", foo);
            //Skeletal Enforcer 
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("ICC_025t", foo);
            //Grim Necromancer <b>Battlecry:</b> Summon two 1/1 Skeletons.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("ICC_026", foo);
            //Skeleton 
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("ICC_026t", foo);
            //Bone Drake <b>Deathrattle:</b> Add a random Dragon to your hand.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("ICC_027", foo);
            //Sunborne Val'kyr <b>Battlecry:</b> Give adjacent minions +2 Health.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("ICC_028", foo);
            //Cobalt Scalebane At the end of your turn, give another random friendly minion +3 Attack.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("ICC_029", foo);
            //Night Howler Whenever this minion takes damage, gain + 2 Attack.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("ICC_031", foo);
            //Venomancer <b>Poisonous</b>
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("ICC_032", foo);
            //Vryghoul [x]<b>Deathrattle:</b> If it's your opponent's turn, summon a 2 / 2 Ghoul.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("ICC_067", foo);
            //Acherus Veteran <b>Battlecry:</b> Give a friendly minion +1 Attack.
            foo = new CardBase();
            foo.TargetFunc = Target.MinionImmuneTargetMinionUser;
            foo.PlayFunc = Play.Minion;
            Dict.Add("ICC_092", foo);
            //Tuskarr Fisherman <b>Battlecry:</b> Give a friendly minion <b>Spell Damage +1</b>.
            foo = new CardBase();
            foo.TargetFunc = Target.MinionImmuneTargetMinionUser;
            foo.PlayFunc = Play.Minion;
            Dict.Add("ICC_093", foo);
            //Fallen Sun Cleric <b>Battlecry:</b> Give a friendly minion +1/+1.
            foo = new CardBase();
            foo.TargetFunc = Target.MinionImmuneTargetMinionUser;
            foo.PlayFunc = Play.Minion;
            Dict.Add("ICC_094", foo);
            //Furnacefire Colossus <b>Battlecry:</b> Discard all weapons from your hand and gain their stats.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("ICC_096", foo);
            //Grave Shambler Whenever your weapon is destroyed, gain +1/+1.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("ICC_097", foo);
            //Tomb Lurker [x]<b>Battlecry:</b> Add a random < b > Deathrattle </ b > minion that died this game to your hand.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("ICC_098", foo);
            //Ticking Abomination <b>Deathrattle:</b> Deal 5 damage to your minions.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("ICC_099", foo);
            //Deadscale Knight <b>Lifesteal</b>
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("ICC_220", foo);
            //Corpse Raiser [x]<b>Battlecry:</b> Give a friendly minion "<b>Deathrattle:</b> Resummon this minion."
            foo = new CardBase();
            foo.TargetFunc = Target.MinionImmuneTargetMinionUser;
            foo.PlayFunc = Play.Minion;
            Dict.Add("ICC_257", foo);
            //The Lich King [x]<b>Taunt</b> At the end of your turn, add a random < b > Death Knight </ b > card to your hand.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("ICC_314", foo);
            //Saronite Chain Gang <b>Taunt</b> < b > Battlecry:</ b > Summon a copy of this minion.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("ICC_466", foo);
            //Deathspeaker <b>Battlecry:</b> Give a friendly minion <b>Immune</b> this turn.
            foo = new CardBase();
            foo.TargetFunc = Target.MinionImmuneTargetMinionUser;
            foo.PlayFunc = Play.Minion;
            Dict.Add("ICC_467", foo);
            //Wretched Tiller Whenever this minion attacks, deal 2 damage to the enemy hero.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("ICC_468", foo);
            //Transmute Spirit <b>Hero Power:</b> Transform a friendly minion into a random one that costs (1) more.
            foo = new CardBase();
            foo.TargetFunc = Target.SpellImmuneTargetMinionUser;
            foo.PlayFunc = Play.SpellImmuneTargetMinionUser;
            Dict.Add("ICC_481p", foo);
            //Happy Ghoul Costs (0) if your hero was healed this turn.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("ICC_700", foo);
            //Skulking Geist <b>Battlecry:</b> Destroy all 1 - Cost spells in both hands and decks.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("ICC_701", foo);
            //Shallow Gravedigger <b>Deathrattle:</b> Add a random <b>Deathrattle</b> minion to your hand.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("ICC_702", foo);
            //Bonemare <b>Battlecry:</b> Give a friendly minion +4/+4 and <b>Taunt</b>.
            foo = new CardBase();
            foo.TargetFunc = Target.MinionImmuneTargetMinionUser;
            foo.PlayFunc = Play.Minion;
            Dict.Add("ICC_705", foo);
            //Nerubian Unraveler Spells cost (2) more.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("ICC_706", foo);
            //Zombeast 
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("ICC_800h3t", foo);
            //Deathaxe Punisher <b>Battlecry:</b> Give a random <b>Lifesteal</b> minion in your hand +2/+2.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("ICC_810", foo);
            //Meat Wagon [x]<b>Deathrattle:</b> Summon a minion from your deck with less Attack than this minion.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("ICC_812", foo);
            //Build-A-Beast <b>Hero Power</b> Craft a custom Zombeast.
            foo = new CardBase();
            Dict.Add("ICC_828p", foo);
            //The Four Horsemen [x]<b>Hero Power</b> Summon a 2 / 2 Horseman. If you have all 4, destroy the enemy hero.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("ICC_829p", foo);
            //Siphon Life <b>Hero Power</b> < b > Lifesteal </ b > Deal $3 damage.
            foo = new CardBase();
            foo.TargetFunc = Target.SpellTargetAll;
            foo.PlayFunc = Play.SpellTargetAll;
            Dict.Add("ICC_831p", foo);
            //Plague Lord [x]<b>Hero Power</b> < b > Choose One -</ b > +3 Attack this turn; or Gain 3 Armor.
            foo = new CardBase();
            Dict.Add("ICC_832p", foo);
            //Icy Touch <b>Hero Power</b> Deal $1 damage.If this kills a minion, summon a Water Elemental.
            foo = new CardBase();
            foo.TargetFunc = Target.SpellTargetAll;
            foo.PlayFunc = Play.SpellTargetAll;
            Dict.Add("ICC_833h", foo);
            //Prince Keleseth <b>Battlecry:</b> If your deck has no 2-Cost cards, give all minions in your deck +1/+1.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("ICC_851", foo);
            //Prince Taldaram <b>Battlecry:</b> If your deck has no 3-Cost cards, transform into a 3/3 copy of a minion.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("ICC_852", foo);
            //Prince Valanar <b>Battlecry:</b> If your deck has no 4-Cost cards, gain <b>Lifesteal</b> and <b>Taunt</b>.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("ICC_853", foo);
            //Arfus <b>Deathrattle:</b> Add a random <b>Death Knight</b> card to your hand.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("ICC_854", foo);
            //Hyldnir Frostrider <b>Battlecry:</b> <b>Freeze</b> your other minions.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("ICC_855", foo);
            //Spellweaver <b>Spell Damage +2</b>
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("ICC_856", foo);
            //Necrotic Geist Whenever one of your other minions dies, summon a 2/2 Ghoul.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("ICC_900", foo);
            //Ghoul 
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("ICC_900t", foo);
            //Drakkari Enchanter Your end of turn effects trigger twice.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("ICC_901", foo);
            //Mindbreaker Hero Powers are disabled.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("ICC_902", foo);
            //Wicked Skeleton <b>Battlecry:</b> Gain +1/+1 for each minion that died this turn.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("ICC_904", foo);
            //Bloodworm <b>Lifesteal</b>
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("ICC_905", foo);
            //Keening Banshee Whenever you play a card, remove the top 3 cards of your deck.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("ICC_911", foo);
            //Corpsetaker [x]<b>Battlecry:</b> Gain <b>Taunt</b> if your deck has a<b> Taunt</ b > minion. Repeat for < b > Divine Shield </ b >, < b > Lifesteal </ b >, < b > Windfury </ b >.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("ICC_912", foo);
            //Tainted Zealot <b>Divine Shield</b> < b > Spell Damage + 1 </ b >
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("ICC_913", foo);

            //The Lich King 
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("ICCA01_001", foo);
            //Ghoul <b>Taunt</b>
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("ICCA01_004t", foo);
            //Eager Rogue Deals no damage while attacking.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("ICCA01_007", foo);
            //Terrible Tank 
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("ICCA01_008", foo);
            //Needy Hunter Whenever this minion attacks, add a Coin to your hand.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("ICCA01_009", foo);
            //A. F. Kay Can't attack.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("ICCA01_010", foo);
            //Warlock on Fire At the end of your turn, deal 1 damage to this minion.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("ICCA01_011", foo);
            //Secrets of the Citadel 
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("ICCA03_001", foo);
            //Sindragosa 
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("ICCA04_001", foo);
            //Block of Ice 
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("ICCA04_004", foo);
            //Frost Breath <b>Hero Power</b> Permanently<b> Freeze</ b > all enemy minions.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("ICCA04_008p", foo);
            //Frost Breath <b>Triggered Power</b> At 20 Health, transforms all enemy minions into blocks of ice.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("ICCA04_009p", foo);
            //Frost Breath <b>Triggered Power</b> At 10 Health, transforms all enemy minions into blocks of ice.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("ICCA04_010p", foo);
            //Ice Claw <b>Hero Power</b> Deal $2 damage.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("ICCA04_011p", foo);
            //Blood-Queen Lana'thel 
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("ICCA05_001", foo);
            //Vampiric Bite <b>Hero Power</b> Give a non - Vampire + 2 / +2.You < i > must </ i > use this.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("ICCA05_002p", foo);
            //Sleeping Acolyte 
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("ICCA05_003", foo);
            //Vampiric Leech <b>Hero Power</b> < b > Lifesteal </ b > Deal $3 damage.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("ICCA05_004p", foo);
            //Lord Marrowgar 
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("ICCA06_001", foo);
            //Skeletal Reconstruction <b>Hero Power</b> Restore your hero to full Health.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("ICCA06_002p", foo);
            //Bryn'troll, the Bone Arbiter <b>Windfury</b>
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("ICCA06_003", foo);
            //Bone Storm Deal $1 damage to all enemies. Draw a card.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("ICCA06_004", foo);
            //Bone Spike At the start of your turn, deal 15 damage to the enemy hero.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("ICCA06_005", foo);
            //Professor Putricide 
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("ICCA07_001", foo);
            //Professor Putricide 
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("ICCA07_001h2", foo);
            //Professor Putricide 
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("ICCA07_001h3", foo);
            //Mad Science <b>Passive Hero Power</b> All<b> Secrets</ b > cost(0).
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("ICCA07_002p", foo);
            //Madder Science <b>Passive Hero Power</b> All weapons cost(1).
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("ICCA07_003p", foo);
            //Growing Ooze At the start of your turn, gain +1/+1.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("ICCA07_004", foo);
            //Maddest Science <b>Passive Hero Power</b> All cards cost(5). Because SCIENCE!
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("ICCA07_005p", foo);
            //Festergut At the end of your turn, deal 3 damage to all enemy minions.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("ICCA07_008", foo);
            //Tentacles 
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("ICCA07_020", foo);
            //The Lich King 
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("ICCA08_001", foo);
            //The Scourge <b>Hero Power</b> Summon a 2 / 2 Ghoul.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("ICCA08_002p", foo);
            //Ghoul 
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("ICCA08_002t", foo);
            //Val'kyr Shadowguard At the start of your turn, destroy a random enemy minion and this one.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("ICCA08_017", foo);
            //Harvest of Souls <b>Passive Hero Power</b> You are < b > Immune </ b > if you control a Trapped Soul.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("ICCA08_032p", foo);
            //Trapped Soul 
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("ICCA08_033", foo);
            //Blood Rune <b>Passive Hero Power</b> Can only take damage from weapons.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("ICCA09_001p", foo);
            //Blood Beast At the start of your turn, restore 3 Health to your hero.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("ICCA09_001t1", foo);
            //Deathbringer Saurfang 
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("ICCA09_002", foo);
            //Valithria Dreamwalker Can't attack or be attacked while damaged.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("ICCA10_001", foo);
            //Lady Deathwhisper 
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("ICCA10_009", foo);
            //Whisper of Death [x]<b>Hero Power</b> Damage all enemy minions until they have 1 Health.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("ICCA10_009p", foo);
            //Skeletal Knight <b>Deathrattle:</b> Add a < b > Knights of the Frozen Throne</ b > card to your opponent's hand.
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("ICCA11_001", foo);

        }
        public static void TB(Dictionary<string, CardBase> Dict)
        {
        }
    }
}
