using System.Text.RegularExpressions;
using THS.Input;
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
            if (InstructionRegexType.PlayRegex.IsMatch(line))
            {
                Type = PlayType.Play;
                Match match = InstructionRegexType.PlayRegex.Match(line);
                if (int.Parse(match.Groups["handSize"].Value) < int.Parse(match.Groups["handNumber"].Value) || int.Parse(match.Groups["handSize"].Value) > 10)
                {
                    Type = PlayType.Incorrect;
                    return;
                }
                MouseMovement.PlayCard(int.Parse(match.Groups["handSize"].Value), int.Parse(match.Groups["handNumber"].Value) - 1);
            }
            else if (InstructionRegexType.PlayOnBoardRegex.IsMatch(line))
            {
                Type = PlayType.Play;
                Match match = InstructionRegexType.PlayOnBoardRegex.Match(line);
                if (int.Parse(match.Groups["handSize"].Value) < int.Parse(match.Groups["handNumber"].Value) || int.Parse(match.Groups["handSize"].Value) > 10 || int.Parse(match.Groups["boardSize"].Value) < int.Parse(match.Groups["boardNumber"].Value) || int.Parse(match.Groups["boardSize"].Value) > 7)
                {
                    Type = PlayType.Incorrect;
                    return;
                }
                if (match.Groups["enemy"].Value.Equals("e"))
                {
                    MouseMovement.PlayCardOn(int.Parse(match.Groups["handSize"].Value), int.Parse(match.Groups["handNumber"].Value) - 1, true, int.Parse(match.Groups["boardSize"].Value), int.Parse(match.Groups["boardNumber"].Value) - 1);
                }
                else
                {
                    MouseMovement.PlayCardOn(int.Parse(match.Groups["handSize"].Value), int.Parse(match.Groups["handNumber"].Value) - 1, false, int.Parse(match.Groups["boardSize"].Value), int.Parse(match.Groups["boardNumber"].Value) - 1);
                }

            }
            else if (InstructionRegexType.PlayOnHeroRegex.IsMatch(line))
            {
                Type = PlayType.Play;
                Match match = InstructionRegexType.PlayOnHeroRegex.Match(line);
                if (int.Parse(match.Groups["handSize"].Value) < int.Parse(match.Groups["handNumber"].Value) || int.Parse(match.Groups["handSize"].Value) > 10)
                {
                    Type = PlayType.Incorrect;
                    return;
                }
                if (match.Groups["enemy"].Value.Equals("e"))
                {
                    MouseMovement.PlayCardOn(int.Parse(match.Groups["handSize"].Value), int.Parse(match.Groups["handNumber"].Value) - 1, true, 0, 0, true);
                }
                else
                {
                    MouseMovement.PlayCardOn(int.Parse(match.Groups["handSize"].Value), int.Parse(match.Groups["handNumber"].Value) - 1, false, 0, 0, true);
                }
            }
            else if (InstructionRegexType.MulliganRegex.IsMatch(line))
            {
                Type = PlayType.Mulligan;
                Match match = InstructionRegexType.MulliganRegex.Match(line);
                if (match.Groups["coin"].Value.Equals(""))
                {
                    MouseMovement.Mulligan(int.Parse(match.Groups["first"].Value), int.Parse(match.Groups["second"].Value), int.Parse(match.Groups["third"].Value));
                }
                else
                {
                    MouseMovement.MulliganCoin(int.Parse(match.Groups["first"].Value), int.Parse(match.Groups["second"].Value), int.Parse(match.Groups["third"].Value), int.Parse(match.Groups["fourth"].Value));
                }
            }
            else if (InstructionRegexType.AttackBoardRegex.IsMatch(line))
            {
                Type = PlayType.Attack;
                Match match = InstructionRegexType.AttackBoardRegex.Match(line);
                if (int.Parse(match.Groups["boardSize"].Value) < int.Parse(match.Groups["boardNumber"].Value) || int.Parse(match.Groups["boardSize"].Value) > 7 || int.Parse(match.Groups["boardEnemySize"].Value) < int.Parse(match.Groups["boardEnemyNumber"].Value) || int.Parse(match.Groups["boardEnemySize"].Value) > 7)
                {
                    Type = PlayType.Incorrect;
                    return;
                }
                MouseMovement.AttackCard(int.Parse(match.Groups["boardSize"].Value), int.Parse(match.Groups["boardNumber"].Value) - 1, int.Parse(match.Groups["boardEnemySize"].Value), int.Parse(match.Groups["boardEnemyNumber"].Value) - 1);
            }
            else if (InstructionRegexType.AttackHeroRegex.IsMatch(line))
            {
                Type = PlayType.Attack;
                Match match = InstructionRegexType.AttackHeroRegex.Match(line);
                if (int.Parse(match.Groups["boardSize"].Value) < int.Parse(match.Groups["boardNumber"].Value) || int.Parse(match.Groups["boardSize"].Value) > 7)
                {
                    Type = PlayType.Incorrect;
                    return;
                }
                MouseMovement.AttackCard(int.Parse(match.Groups["boardSize"].Value), int.Parse(match.Groups["boardNumber"].Value) - 1, 0, 0, true);

            }
            else if (InstructionRegexType.AttackWithdHeroBoardRegex.IsMatch(line))
            {
                Type = PlayType.Attack;
                Match match = InstructionRegexType.AttackWithdHeroBoardRegex.Match(line);
                if (int.Parse(match.Groups["boardEnemySize"].Value) < int.Parse(match.Groups["boardEnemyNumber"].Value) || int.Parse(match.Groups["boardEnemySize"].Value) > 7)
                {
                    Type = PlayType.Incorrect;
                    return;
                }
                MouseMovement.AttackHero(int.Parse(match.Groups["boardEnemySize"].Value), int.Parse(match.Groups["boardEnemyNumber"].Value) - 1);
            }
            else if (InstructionRegexType.AttackWithHeroRegex.IsMatch(line))
            {
                Type = PlayType.Attack;
                Match match = InstructionRegexType.AttackWithHeroRegex.Match(line);
                MouseMovement.AttackHero(0, 0, true);

            }
            else if (InstructionRegexType.ChooseRegex.IsMatch(line))
            {
                Type = PlayType.Discover;
                Match match = InstructionRegexType.ChooseRegex.Match(line);
                if (int.Parse(match.Groups["card"].Value) > 2)
                {
                    Type = PlayType.Incorrect;
                    return;
                }
                MouseMovement.ChooseOne(int.Parse(match.Groups["card"].Value) - 1);
            }
            else if (InstructionRegexType.DiscoverRegex.IsMatch(line))
            {
                Type = PlayType.Discover;
                Match match = InstructionRegexType.DiscoverRegex.Match(line);
                if (int.Parse(match.Groups["card"].Value) > 3)
                {
                    Type = PlayType.Incorrect;
                    return;
                }
                MouseMovement.Discover(int.Parse(match.Groups["card"].Value) - 1);
            }
            else if (InstructionRegexType.EndRegex.IsMatch(line))
            {
                Type = PlayType.Other;
                Match match = InstructionRegexType.EndRegex.Match(line);
                MouseMovement.EndTurn();
            }
            else if (InstructionRegexType.PowerRegex.IsMatch(line))
            {
                Type = PlayType.HeroPower;
                Match match = InstructionRegexType.PowerRegex.Match(line);
                MouseMovement.Power();
            }
            else if (InstructionRegexType.PowerHeroRegex.IsMatch(line))
            {
                Type = PlayType.HeroPower;
                Match match = InstructionRegexType.PowerHeroRegex.Match(line);
                if (!match.Groups["enemy"].Value.Equals("e") && !match.Groups["enemy"].Value.Equals("f"))
                {
                    Type = PlayType.Incorrect;
                    return;
                }
                if (match.Groups["enemy"].Value.Equals("e"))
                {
                    MouseMovement.Power(true);
                }
                else
                {
                    MouseMovement.Power(false);
                }
            }
            else if (InstructionRegexType.PowerBoardRegex.IsMatch(line))
            {
                Type = PlayType.HeroPower;
                Match match = InstructionRegexType.PowerBoardRegex.Match(line);
                if (int.Parse(match.Groups["boardSize"].Value) < int.Parse(match.Groups["boardNumber"].Value) || int.Parse(match.Groups["boardSize"].Value) > 7 || (!match.Groups["enemy"].Value.Equals("e") && !match.Groups["enemy"].Value.Equals("f")))
                {
                    Type = PlayType.Incorrect;
                    return;
                }
                if (match.Groups["enemy"].Value.Equals("e"))
                {
                    MouseMovement.Power(int.Parse(match.Groups["boardSize"].Value), int.Parse(match.Groups["boardNumber"].Value) - 1, true);
                }
                else
                {
                    MouseMovement.Power(int.Parse(match.Groups["boardSize"].Value), int.Parse(match.Groups["boardNumber"].Value) - 1, false);
                }
            }
            else if (InstructionRegexType.EmoteRegex.IsMatch(line))
            {
                Type = PlayType.Other;
                Match match = InstructionRegexType.EmoteRegex.Match(line);
                switch (match.Groups["emote"].Value)
                {
                    case "hi":
                        MouseMovement.Emote(HSPoints.EmoteGreetings);
                        break;
                    case "wp":
                        MouseMovement.Emote(HSPoints.EmoteWellPlayed);
                        break;
                    case "ty":
                        MouseMovement.Emote(HSPoints.EmoteThanks);
                        break;
                    case "oh":
                        MouseMovement.Emote(HSPoints.EmoteWow);
                        break;
                    case "oo":
                        MouseMovement.Emote(HSPoints.EmoteOops);
                        break;
                    case "th":
                        MouseMovement.Emote(HSPoints.EmoteThreaten);
                        break;
                    default:
                        Type = PlayType.Incorrect;
                        return;
                }
            }
            else if (InstructionRegexType.QueueRegex.IsMatch(line))
            {
                Type = PlayType.Other;
                Match match = InstructionRegexType.QueueRegex.Match(line);
                if (int.Parse(match.Groups["deck"].Value) < 1 || int.Parse(match.Groups["deck"].Value) > 18 || (!match.Groups["mode"].Value.Equals("r") && !match.Groups["mode"].Value.Equals("c")) || (!match.Groups["wild"].Value.Equals("w") && !match.Groups["wild"].Value.Equals("s")))
                {
                    Type = PlayType.Incorrect;
                    return;
                }
                if (match.Groups["mode"].Value.Equals("r"))
                {
                    MouseMovement.Requeue(int.Parse(match.Groups["deck"].Value), true);
                }
                else
                {
                    MouseMovement.Requeue(int.Parse(match.Groups["deck"].Value), false);
                }

            }
            else if (InstructionRegexType.SilenceRegex.IsMatch(line))
            {
                Type = PlayType.Other;
                Match match = InstructionRegexType.SilenceRegex.Match(line);
                MouseMovement.Silence();

            }
            else if (InstructionRegexType.SeeDeckRegex.IsMatch(line))
            {
                Type = PlayType.Other;
                Match match = InstructionRegexType.SeeDeckRegex.Match(line);

                MouseMovement.SeeDeck();

            }
            else if (InstructionRegexType.ConcedeRegex.IsMatch(line))
            {
                Type = PlayType.Other;
                Match match = InstructionRegexType.ConcedeRegex.Match(line);

                MouseMovement.Concede();

            }
            else
            {
                Type = PlayType.Incorrect;
                return;
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
