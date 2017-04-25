using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

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
        Play, HeroPower,Attack, Incorrect
    }
    public enum CardZone
    {
        Deck, Player, Opponent, Graveyard
    }

    public static class PowerTaskList
    {
        public static readonly Regex BlockStartRegex =
            new Regex(@"BLOCK_START.*BlockType=(?<type>(POWER|TRIGGER)).*id=(?<id>\d*).*(cardId=(?<Id>(\w*))).*Target=(?<target>(.+))");

        public static readonly Regex CardIdRegex =
            new Regex(@"cardId=(?<cardId>(\w+))");
        public static readonly Regex CreationRegex =
            new Regex(@"FULL_ENTITY - Updating.*id=(?<id>(\d+)).*zone=(?<zone>(\w+)).*CardID=(?<cardId>(\w*))");
        public static readonly Regex CreationTagRegex =
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

        public static readonly Regex CreateGameRegex =
            new Regex(@"");
    }
}
