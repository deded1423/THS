using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using THS.HSApp.Dictionaries.Util;

namespace THS.HSApp.Dictionaries
{
    class MageDict
    {
        private static CardBase foo;
        public static void MageCORE(Dictionary<string, CardBase> Dict)
        {
            //Polymorph
            foo = new CardBase();
            foo.TargetFunc = Target.AlwaysTarget;
            foo.PlayFunc = Play.SpellTargetMinionAll;
            Dict.Add("CS2_022", foo);
            //Arcane Intellect
            foo = new CardBase();
            Dict.Add("CS2_023", foo);
            //Frostbolt
            foo = new CardBase();
            foo.TargetFunc = Target.AlwaysTarget;
            foo.PlayFunc = Play.SpellTargetAll;
            Dict.Add("CS2_024", foo);
            //Arcane Explosion
            foo = new CardBase();
            Dict.Add("CS2_025", foo);
            //Frost Nova
            foo = new CardBase();
            Dict.Add("CS2_026", foo);
            //Mirror Image
            foo = new CardBase();
            foo.PlayFunc = Play.SpellSummonMinion;
            Dict.Add("CS2_027", foo);
            //Fire Ball
            foo = new CardBase();
            foo.TargetFunc = Target.AlwaysTarget;
            foo.PlayFunc = Play.SpellTargetAll;
            Dict.Add("CS2_029", foo);
            //Flamestrike
            foo = new CardBase();
            Dict.Add("CS2_032", foo);
            //Water Elemental
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("CS2_033", foo);
            //Fireblast
            foo = new CardBase();
            foo.TargetFunc = Target.AlwaysTarget;
            foo.PlayFunc = Play.SpellTargetAll;
            Dict.Add("CS2_034", foo);
            //Mirror Image (Minion)
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("CS2_mirror", foo);
            //Mirror Image (Minion)
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("EX1_277", foo);
        }
        public static void MageEXPERT(Dictionary<string, CardBase> Dict)
        {
            //Blizzard
            foo = new CardBase();
            Dict.Add("CS2_028", foo);
            //Ethereal Arcanist
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("EX1_274", foo);
            //Cone of Cold
            foo = new CardBase();
            foo.TargetFunc = Target.AlwaysTarget;
            foo.PlayFunc = Play.SpellTargetMinionAll;
            Dict.Add("EX1_275", foo);
            //Pyroblast
            foo = new CardBase();
            foo.TargetFunc = Target.AlwaysTarget;
            foo.PlayFunc = Play.SpellTargetAll;
            Dict.Add("EX1_279", foo);
            //Counterspell
            foo = new CardBase();
            foo.PlayFunc = () => Play.SpellSecret("EX1_287");
            Dict.Add("EX1_287", foo);
            //Ice Barrier
            foo = new CardBase();
            foo.PlayFunc = () => Play.SpellSecret("EX1_289");
            Dict.Add("EX1_289", foo);
            //Mirror Entity
            foo = new CardBase();
            foo.PlayFunc = () => Play.SpellSecret("EX1_294");
            Dict.Add("EX1_294", foo);
            //Ice Block
            foo = new CardBase();
            foo.PlayFunc = () => Play.SpellSecret("EX1_295");
            Dict.Add("EX1_295", foo);
            //Archmage Antonidas
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("EX1_559", foo);
            //Vaporize
            foo = new CardBase();
            foo.PlayFunc = () => Play.SpellSecret("EX1_594");
            Dict.Add("EX1_594", foo);
            //Sorcerer's Apprentice
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("EX1_608", foo);
            //Kirin Tor Mage
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("EX1_612", foo);
            //Mana Wrym
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("NEW1_012", foo);
            //Spellbender
            foo = new CardBase();
            foo.PlayFunc = () => Play.SpellSecret("tt_010");
            Dict.Add("tt_010", foo);
            //Spellbender (Minion)
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("tt_010a", foo);
        }
        public static void MageHOF(Dictionary<string, CardBase> Dict)
        {
            //Ice Lance
            foo = new CardBase();
            foo.TargetFunc = Target.AlwaysTarget;
            foo.PlayFunc = Play.SpellTargetAll;
            Dict.Add("CS2_031", foo);
        }
        public static void MageNAXX(Dictionary<string, CardBase> Dict)
        {
            //Duplicate
            foo = new CardBase();
            foo.PlayFunc = () => Play.SpellSecret("FP1_018");
            Dict.Add("FP1_018", foo);
        }
        public static void MageGVG(Dictionary<string, CardBase> Dict)
        {
            //Flamecannon
            foo = new CardBase();
            foo.PlayFunc = Play.SpellRandomTargetMinionEnemy;
            Dict.Add("GVG_001", foo);
            //Snowchugger
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("GVG_002", foo);
            //Unstable Portal
            foo = new CardBase();
            Dict.Add("GVG_003", foo);
            //Goblin Blastmage
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("GVG_004", foo);
            //Echo of Medivh 
            foo = new CardBase();
            Dict.Add("GVG_005", foo);
            //Flame Leviathan
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("GVG_007", foo);
            //Wee Spellstopper
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("GVG_112", foo);
            //Soot Spewer
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("GVG_123", foo);
        }
        public static void MageBRM(Dictionary<string, CardBase> Dict)
        {
            //Flamewalker
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("BRM_002", foo);
            //Dragon's Breath
            foo = new CardBase();
            foo.TargetFunc = Target.AlwaysTarget;
            foo.PlayFunc = Play.SpellTargetAll;
            Dict.Add("BRM_003", foo);
        }
        public static void MageTGT(Dictionary<string, CardBase> Dict)
        {
            //Flame Lance
            foo = new CardBase();
            foo.TargetFunc = Target.AlwaysTarget;
            foo.PlayFunc = Play.SpellTargetMinionAll;
            Dict.Add("AT_001", foo);
            //Effigy
            foo = new CardBase();
            foo.PlayFunc = () => Play.SpellSecret("AT_002");
            Dict.Add("AT_002", foo);
            //Fallen Hero
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("AT_003", foo);
            //Arcane Blast
            foo = new CardBase();
            foo.TargetFunc = Target.AlwaysTarget;
            foo.PlayFunc = Play.SpellTargetMinionAll;
            Dict.Add("AT_004", foo);
            //Polymorph: Boar
            foo = new CardBase();
            foo.PlayFunc = Play.SpellTargetMinionAll;
            Dict.Add("AT_005", foo);
            //Dalaran Aspirant
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("AT_006", foo);
            //Spellslinger
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("AT_007", foo);
            //Coldarra Drake
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("AT_008", foo);
            //Rhonin
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("AT_009", foo);
            //Fireblast Rank 2
            foo = new CardBase();
            foo.TargetFunc = Target.AlwaysTarget;
            foo.PlayFunc = Play.SpellTargetAll;
            Dict.Add("AT_132_MAGE", foo);
        }
        public static void MageLOE(Dictionary<string, CardBase> Dict)
        {
            //Forgotten Torch
            foo = new CardBase();
            foo.TargetFunc = Target.AlwaysTarget;
            foo.PlayFunc = Play.SpellTargetAll;
            Dict.Add("LOE_002", foo);
            //Roaring Torch
            foo = new CardBase();
            foo.TargetFunc = Target.AlwaysTarget;
            foo.PlayFunc = Play.SpellTargetAll;
            Dict.Add("LOE_002t", foo);
            //Ethereal Conjurer
            foo = new CardBase();
            foo.HasDiscover = true;
            foo.PlayFunc = Play.Minion;
            Dict.Add("LOE_003", foo);
            //Animated Armor
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("LOE_119", foo);
        }
        public static void MageOG(Dictionary<string, CardBase> Dict)
        {
            //Shatter
            foo = new CardBase();
            foo.TargetFunc = Target.AlwaysTarget;
            foo.PlayFunc = () => Play.SpellTargetMinionAllWithTag(HearthDb.Enums.GameTag.FROZEN);
            Dict.Add("OG_081", foo);
            //Twilight Flamecaller
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("OG_083", foo);
            //Demented Frostcaller
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("OG_085", foo);
            //Forbidden Flame
            foo = new CardBase();
            foo.TargetFunc = Target.AlwaysTarget;
            foo.PlayFunc = Play.SpellTargetMinionAll;
            Dict.Add("OG_086", foo);
            //Servant of Yogg-Saron
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("OG_087", foo);
            //Cabalist's Tome
            foo = new CardBase();
            Dict.Add("OG_090", foo);
            //Anomalus
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("LOE_002", foo);
            //Faceless Summoner
            foo = new CardBase();
            foo.PlayFunc = Play.SpellTargetAll;
            Dict.Add("OG_207", foo);
            //Cult Sorcerer
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("OG_303", foo);
        }
        public static void MageKARA(Dictionary<string, CardBase> Dict)
        {
            //Babbling Book
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("KAR_009", foo);
            //Forbidden Flame
            foo = new CardBase();
            foo.TargetFunc = Target.AlwaysTarget;
            foo.PlayFunc = Play.SpellTargetAll;
            Dict.Add("KAR_076", foo);
            //Medivh's Valet
            foo = new CardBase();
            foo.TargetFunc = Target.MedivhsValet;
            foo.PlayFunc = Play.Minion;
            Dict.Add("OG_086", foo);
        }
        public static void MageGANGS(Dictionary<string, CardBase> Dict)
        {
            //Freezing Potion
            foo = new CardBase();
            foo.TargetFunc = Target.AlwaysTarget;
            foo.PlayFunc = Play.SpellTargetEnemy;
            Dict.Add("CFM_021", foo);
            //Volcanic Potion
            foo = new CardBase();
            Dict.Add("CFM_065", foo);
            //Kabal Lackey
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("CFM_066", foo);
            //Potion of Polymorph
            foo = new CardBase();
            foo.PlayFunc = () => Play.SpellSecret("CFM_620");
            Dict.Add("CFM_620", foo);
            //Greater Arcane Missiles
            foo = new CardBase();
            Dict.Add("CFM_623", foo);
            //Manic Soulcaster
            foo = new CardBase();
            foo.TargetFunc = Target.OneFriendlyBoard;
            foo.PlayFunc = Play.Minion;
            Dict.Add("CFM_660", foo);
            //Cryomancer
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("CFM_671", foo);
            //Inkmaster Solia
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("CFM_687", foo);
            //Kabal Crystal Runner
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("CFM 760", foo);
        }
        public static void MageUNGORO(Dictionary<string, CardBase> Dict)
        {
            //Flame geyser
            foo = new CardBase();
            foo.TargetFunc = Target.AlwaysTarget;
            foo.PlayFunc = Play.SpellTargetAll;
            Dict.Add("UNG_018", foo);
            //Arcanologist
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("UNG_020", foo);
            //Steam Surger
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("UNG_021", foo);
            //Mana Bind
            foo = new CardBase();
            foo.PlayFunc = () => Play.SpellSecret("UNG_024");
            Dict.Add("UNG_024", foo);
            //Pyros
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("UNG_027", foo);
            //Pyros 6 
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("UNG_027t2", foo);
            //Pyros 10 
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("UNG_027t4", foo);
            //Open the Waygate
            foo = new CardBase();
            Dict.Add("UNG_028", foo);
            //Time Warp
            foo = new CardBase();
            Dict.Add("UNG_028t", foo);
            //Shimmering Tempest
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("UNG_846", foo);
            //Primordial Glyph
            foo = new CardBase();
            foo.HasDiscover = true;
            Dict.Add("UNG_941", foo);
            //Molten Reflection
            foo = new CardBase();
            foo.TargetFunc = Target.AlwaysTarget;
            foo.PlayFunc = Play.SpellTarget;
            Dict.Add("UNG_948", foo);
            //Meteor
            foo = new CardBase();
            foo.TargetFunc = Target.AlwaysTarget;
            foo.PlayFunc = Play.SpellTargetMinionAll;
            Dict.Add("UNG_955", foo);
        }
        public static void MageICECROWN(Dictionary<string, CardBase> Dict)
        {
            //Ice Walker
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("ICC_068", foo);
            //Ghastly Conjurer
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("ICC_069", foo);
            //Frozen Clone
            foo = new CardBase();
            foo.PlayFunc = ()=> Play.SpellSecret("ICC_082");
            Dict.Add("ICC_082", foo);
            //Doomed Apprentice
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("ICC_083", foo);
            //Glacial Mysteries
            foo = new CardBase();
            Dict.Add("ICC_086", foo);
            //Coldwraith
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("ICC_252", foo);
            //Simulacrum
            foo = new CardBase();
            foo.PlayFunc = Play.MinionInHand;
            Dict.Add("ICC_823", foo);
            //Frost Lich Jaina
            foo = new CardBase();
            Dict.Add("ICC_833", foo);
            //Water Elemental
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("ICC_833t", foo);
            //Breath of Sindragosas
            foo = new CardBase();
            foo.PlayFunc = Play.SpellRandomTargetMinionEnemy;
            Dict.Add("ICC_836", foo);
            //Sindragosa
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("ICC_838", foo);
            //Frozen Champion
            foo = new CardBase();
            foo.PlayFunc = Play.Minion;
            Dict.Add("ICC_838t", foo);
        }
        public static void MageTB(Dictionary<string, CardBase> Dict)
        {

        }
    }
}
