using System.Text.RegularExpressions;
using THS.Utils;

namespace THS.Twitch_Integration
{
    class CommandChat
    {
        public PlayType Type;
        public string Name;
        public string Target;

        public CommandChat(PlayType type)
        {

            this.Type = type;
            this.Name = null;
            this.Target = null;
        }
        public CommandChat(PlayType type, string Name)
        {
            this.Type = type;
            this.Name = Name;
            this.Target = null;
        }

        public CommandChat(PlayType type, string Name, string Target)
        {
            this.Type = type;
            this.Name = Name;
            this.Target = Target;
        }
        public CommandChat(string line)
        {
            if (InstructionRegexType.InstructionHeroPowerOnRegex.IsMatch(line))
            {
                Type = PlayType.HeroPower;
                Match match = InstructionRegexType.InstructionHeroPowerOnRegex.Match(line);
                Name = match.Groups["name"].Value;
                Target = match.Groups["target"].Value;
            }
            else if (InstructionRegexType.InstructionHeroPowerRegex.IsMatch(line))
            {
                Type = PlayType.HeroPower;
                Match match = InstructionRegexType.InstructionHeroPowerRegex.Match(line);
                Name = match.Groups["name"].Value;
                Target = null;
            }
            else if (InstructionRegexType.InstructionPlayOnRegex.IsMatch(line))
            {
                Type = PlayType.Play;
                Match match = InstructionRegexType.InstructionPlayOnRegex.Match(line);
                Name = match.Groups["name"].Value;
                Target = match.Groups["target"].Value;
            }
            else if (InstructionRegexType.InstructionPlayRegex.IsMatch(line))
            {
                Type = PlayType.Play;
                Match match = InstructionRegexType.InstructionPlayRegex.Match(line);
                Name = match.Groups["name"].Value;
                Target = null;
            }
            else if (InstructionRegexType.InstructionAttackRegex.IsMatch(line))
            {
                Type = PlayType.Attack;
                Match match = InstructionRegexType.InstructionAttackRegex.Match(line);
                Name = match.Groups["name"].Value;
                Target = match.Groups["target"].Value;
            }
            else
            {
                Type = PlayType.Incorrect;
                Name = null;
                Target = null;
            }
        }
        
        public override string ToString()
        {
            if (Type == PlayType.Incorrect)
            {
                return "PlayType: " + Type;
            }
            return "PlayType: " + Type + " // Name: " + Name + " Target: " + Target;
        }
    }
}
