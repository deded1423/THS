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
    }
    public enum PlayType
    {
        Play, HeroPower, Attack, Incorrect
    }
    public enum CardZone
    {
        Deck, Player, Opponent, Graveyard
    }

    public static class PowerTaskList
    {
        public static readonly Regex BlockStartRegex =
            new Regex(@"BLOCK_START.*BlockType=((?<type>(POWER|TRIGGER|DEATHS)).*Entity=(?<entity>.*) EffectCardId=(?<effectcardid>([\d-]*)) EffectIndex=(?<effectindex>[\d-]*) Target=(?<target>[\d-]*))");

        public static readonly Regex CardIdRegex =
            new Regex(@"cardId=(?<cardId>(\w+))");
        public static readonly Regex FullEntityUpdatingRegex =
            new Regex(@"FULL_ENTITY - Updating.*id=(?<id>(\d+)).*zone=(?<zone>(\w+)).*player=(?<player>(\w*)).*CardID=(?<cardId>(\w*))");
        public static readonly Regex TagRegex =
            new Regex(@"tag=(?<tag>(\w+))\ value=(?<value>(\w+))");

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
        public static readonly Regex FullEntityCreatingRegex =
            new Regex(@"FULL_ENTITY - Creating.*ID=(?<id>(\d+)).*CardID=(?<cardId>([\w.]*))");
        public static readonly Regex CountRegex =
            new Regex(@"Count=(?<id>(\d*))");
        public static readonly Regex BlockNullRegex =
            new Regex(@"Block (Start|End)=\(null\)");
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

    public class HsConstants
    {
        public static Dictionary<string, System.Type> TagTypes = new Dictionary<string, System.Type>
        {
            {"ZONE", typeof(Zone)},
            {"CARDTYPE", typeof(CardType)},
            {"FACTION", typeof(Faction)},
            {"RARITY", typeof(Rarity)},
            {"STATE", typeof(State)},
            {"PLAYSTATE", typeof(PlayState)},
            {"CLASS", typeof(CardClass)},
            {"CARDRACE", typeof(Race)},
            {"CARDSET", typeof(CardSet)},
        };

        public static int TagToInt(string tag, string value)
        {
            int temp;
            if (int.TryParse(value, out temp))
            {
                return temp;
            }
            return (int)Enum.Parse(TagTypes[tag], value);
        }
    }
}
