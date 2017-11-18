using System;
using System.CodeDom.Compiler;
using System.Text.RegularExpressions;
using HearthDb.Enums;
using System.Collections.Generic;
using Type = System.Type;

namespace THS.Utils
{
    public class GlobalConstants
    {
        public static string LogPath = @"C:\";
    }
    public class InstructionRegexType
    { //TODO: Ver como se diferencian 2 cartas que son iguales
        public static Regex InstructionPlayRegex = new Regex(@"play\s+(?<name>(.+))");
        public static Regex InstructionPlayOnRegex = new Regex(@"play\s+(?<name>(.+))\s+on\s+(?<target>.+)");
        public static Regex InstructionHeroPowerRegex = new Regex(@"hp");
        public static Regex InstructionHeroPowerOnRegex = new Regex(@"hp\s+on\s+(?<target>.+)");
        public static Regex InstructionAttackRegex = new Regex(@"(?<name>.+)\s+attacks?\s+(?<target>.+)");
        public static Regex InstructionEndRegex = new Regex(@"^end turn$");

        public static Regex PlayRegex = new Regex(@"^play\s(?<handSize>(\d{1,2}))\s(?<handNumber>(\d{1,2}))$");
        public static Regex PlayOnBoardRegex = new Regex(@"^play\s(?<handSize>(\d{1,2}))\s(?<handNumber>(\d{1,2}))\s(?<enemy>([ef]))\s(?<boardSize>(\d))\s(?<boardNumber>(\d))$");
        public static Regex PlayOnHeroRegex = new Regex(@"^play\s(?<handSize>(\d{1,2}))\s(?<handNumber>(\d{1,2}))\s(?<enemy>([ef]))\shero$");
        public static Regex AttackBoardRegex = new Regex(@"^attack\s(?<boardSize>(\d))\s(?<boardNumber>(\d))\s(?<boardEnemySize>(\d))\s(?<boardEnemyNumber>(\d))$");
        public static Regex AttackHeroRegex = new Regex(@"^attack\s(?<boardSize>(\d))\s(?<boardNumber>(\d)) hero$");
        public static Regex AttackWithdHeroBoardRegex = new Regex(@"^attack\shero\s(?<boardEnemySize>(\d))\s(?<boardEnemyNumber>(\d))$");
        public static Regex AttackWithHeroRegex = new Regex(@"^attack\shero\shero$");
        public static Regex HeroPowerRegex = new Regex(@"^power$");
        public static Regex HeroPowerHeroRegex = new Regex(@"^power\s(?<enemy>([ef]))\shero$");
        public static Regex HeroPowerBoardRegex = new Regex(@"^power\s(?<enemy>([ef]))\s(?<boardSize>(\d))\s(?<boardNumber>(\d))$");

        public static Regex ChooseRegex = new Regex(@"^choose\s(?<card>(\d))$");
        public static Regex DiscoverRegex = new Regex(@"^discover\s(?<card>(\d))$");
        public static Regex MulliganRegex = new Regex(@"^mulligan\s(?<first>(\d))\s(?<second>(\d))\s(?<third>(\d))(\s(?<fourth>(\d)))*$");
        public static Regex EmoteRegex = new Regex(@"^emote\s(?<emote>(\w+))$");
        public static Regex QueueRegex = new Regex(@"^queue\s(?<deck>(\d{1,2}))$");
        public static Regex SilenceRegex = new Regex(@"^silence$");
        public static Regex SeeDeckRegex = new Regex(@"^deck$");
        public static Regex ConcedeRegex = new Regex(@"^concede$");


        public static Regex EndRegex = new Regex(@"^end$");
    }
    public enum PlayType
    {
        Play, HeroPower, Attack, Incorrect, Mulligan, Discover, Choose, Queue, Emote, Concede, EndTurn, SeeDeck, Other
    }

    public static class PowerTaskList
    {
        public static readonly Regex BlockStartRegex =
            new Regex(@"BLOCK_START BlockType=((?<type>(POWER|TRIGGER|DEATHS|ATTACK|PLAY|RITUAL|FATIGUE)).*Entity=(?<entity>.*) EffectCardId=(?<effectcardid>([\d-]*)) EffectIndex=(?<effectindex>[\d-]*) Target=(?<target>.*))");

        public static readonly Regex CardIdRegex =
            new Regex(@"cardId=(?<cardId>(\w+))");
        public static readonly Regex FullEntityUpdatingRegex =
            new Regex(@"FULL_ENTITY - Updating.*id=(?<id>(\d+)).*zone=(?<zone>(\w+)).*player=(?<player>(\w*)).*CardID=(?<cardId>(\w*))");
        public static readonly Regex TagRegex =
            new Regex(@"^tag=(?<tag>(\w+))\ value=(?<value>(\w+))");

        public static readonly Regex EntityRegex =
            new Regex(@"(?=id=(?<id>(\d+)))(?=name=(?<name>(\w+)))?(?=zone=(?<zone>(\w+)))?(?=zonePos=(?<zonePos>(\d+)))?(?=cardId=(?<cardId>(\w+)))?(?=player=(?<player>(\d+)))?(?=type=(?<type>(\w+)))?");

        public static readonly Regex GameEntityRegex =
            new Regex(@"GameEntity\ EntityID=(?<id>(\d+))");

        public static readonly Regex PlayerEntityRegex =
            new Regex(@"Player\ EntityID=(?<id>(\d+))\ PlayerID=(?<playerId>(\d+))\ GameAccountId=(?<gameAccountId>(.+))");

        public static readonly Regex TagChangeRegex =
            new Regex(@"TAG_CHANGE\ Entity=(?<entity>(.+))\ tag=(?<tag>(\w+))\ value=(?<value>(\w+))");

        public static readonly Regex UpdatingEntityRegex =
            new Regex(@"SHOW_ENTITY\ -\ Updating\ Entity=(?<entity>(.+))\ CardID=(?<cardId>(\w*))");

        //NUEVO
        public static readonly Regex HideEntityRegex =
            new Regex(@"HIDE_ENTITY\ -\ Entity=(?<entity>(.+))\ tag=(?<tag>(\w+))\ value=(?<value>(\w+))");
        public static readonly Regex FullEntityCreatingRegex =
            new Regex(@"FULL_ENTITY - Creating.*ID=(?<id>(\d+)).*CardID=(?<cardId>([\w.]*))");
        public static readonly Regex CountRegex =
            new Regex(@"Count=(?<id>(\d*))");
        public static readonly Regex BlockNullRegex =
            new Regex(@"Block Start=\(null\)");
        public static readonly Regex CurrentTaskListRegex =
            new Regex(@"m_currentTaskList=(?<id>\d*)");
        public static readonly Regex SourceRegex =
            new Regex(@"Source=(?<source>\w*)");
        public static readonly Regex MetaDataRegex =
            new Regex(@"META_DATA - Meta=(?<meta>\w*) Data=(?<data>\d*) Info=(?<info>\d*)");
        public static readonly Regex OptionRegex =
            new Regex(@"option (?<option>\d*) type=(?<type>(END_TURN|POWER)) mainEntity=(?<mainentity>.*) error=(?<error>.*) errorParam=(?<errorParam>.*)");
        public static readonly Regex SelectedOptionRegex =
            new Regex(@"selectedOption=(?<option>\d*) selectedSubOption=(?<suboption>[\d-]*) selectedTarget=(?<target>\d*) selectedPosition=(?<position>\d*)");
        public static readonly Regex InfoRegex =
            new Regex(@"Info\[(?<id>\d*)\] = (?<result>.*)");
        public static readonly Regex TargetRegex =
            new Regex(@"target (?<target>\d*) entity=(?<entity>.*) error=(?<error>.*) errorParam=(?<errorParam>.*)");

    }

    public static class LogRegex
    {
        public static readonly Regex EntityRegex =
            new Regex(@"\[entityName=(?<name>.*) id=(?<id>.*) zone=(?<zone>.*) zonePos=(?<zonePos>.*) cardId=(?<cardId>.*) player=(?<player>.*)\]");
        public static readonly Regex BlockStartRegex =
            new Regex(@"BLOCK_START.*BlockType=((?<type>(POWER|TRIGGER|DEATHS|ATTACK)).*Entity=(?<entity>.*) EffectCardId=(?<effectcardid>([\d-]*)) EffectIndex=(?<effectindex>[\d-]*) Target=(?<target>[\d-]*))");
    }


    public class HsConstants
    {
        public static int TagToInt(GameTag tag, string value)
        {
            int temp;
            if (int.TryParse(value, out temp))
            {
                return temp;
            }
            return (int)Enum.Parse(Dictionaries.TagTypes[tag], value);
        }
        public static GameTag StringToTag(string tag)
        {
            return (GameTag)Enum.Parse(typeof(GameTag), tag);
        }
    }
}
