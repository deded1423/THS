using System;
using System.Linq;
using System.Text.RegularExpressions;
using THS.Utils;

namespace THS.Twitch_Integration
{
    public class CommandChat
    {
        public PlayType Type;
        public string Name;
        public string Target;
        public string Other;
        public char NameUser;
        public int NamePos;
        public char TargetUser;
        public int TargetPos;

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
        //public CommandChat(string line)
        //{
        //    //Number Instruccion
        //    //TODO: Cambiar todo esto para que este bien
        //    if (InstructionRegexType.PlayRegex.IsMatch(line))
        //    {
        //        Type = PlayType.Play;
        //        Match match = InstructionRegexType.PlayRegex.Match(line);
        //        if (int.Parse(match.Groups["handSize"].Value) < int.Parse(match.Groups["handNumber"].Value) || int.Parse(match.Groups["handSize"].Value) > 10)
        //        {
        //            Type = PlayType.Incorrect;
        //            return;
        //        }
        //        MouseMovement.PlayCard(int.Parse(match.Groups["handSize"].Value), int.Parse(match.Groups["handNumber"].Value) - 1);
        //    }
        //    else if (InstructionRegexType.PlayOnBoardRegex.IsMatch(line))
        //    {
        //        Type = PlayType.Play;
        //        Match match = InstructionRegexType.PlayOnBoardRegex.Match(line);
        //        if (int.Parse(match.Groups["handSize"].Value) < int.Parse(match.Groups["handNumber"].Value) || int.Parse(match.Groups["handSize"].Value) > 10 || int.Parse(match.Groups["boardSize"].Value) < int.Parse(match.Groups["boardNumber"].Value) || int.Parse(match.Groups["boardSize"].Value) > 7)
        //        {
        //            Type = PlayType.Incorrect;
        //            return;
        //        }
        //        if (match.Groups["enemy"].Value.Equals("e"))
        //        {
        //            MouseMovement.PlayCardOn(int.Parse(match.Groups["handSize"].Value), int.Parse(match.Groups["handNumber"].Value) - 1, true, int.Parse(match.Groups["boardSize"].Value), int.Parse(match.Groups["boardNumber"].Value) - 1);
        //        }
        //        else
        //        {
        //            MouseMovement.PlayCardOn(int.Parse(match.Groups["handSize"].Value), int.Parse(match.Groups["handNumber"].Value) - 1, false, int.Parse(match.Groups["boardSize"].Value), int.Parse(match.Groups["boardNumber"].Value) - 1);
        //        }

        //    }
        //    else if (InstructionRegexType.PlayOnHeroRegex.IsMatch(line))
        //    {
        //        Type = PlayType.Play;
        //        Match match = InstructionRegexType.PlayOnHeroRegex.Match(line);
        //        if (int.Parse(match.Groups["handSize"].Value) < int.Parse(match.Groups["handNumber"].Value) || int.Parse(match.Groups["handSize"].Value) > 10)
        //        {
        //            Type = PlayType.Incorrect;
        //            return;
        //        }
        //        if (match.Groups["enemy"].Value.Equals("e"))
        //        {
        //            MouseMovement.PlayCardOn(int.Parse(match.Groups["handSize"].Value), int.Parse(match.Groups["handNumber"].Value) - 1, true, 0, 0, true);
        //        }
        //        else
        //        {
        //            MouseMovement.PlayCardOn(int.Parse(match.Groups["handSize"].Value), int.Parse(match.Groups["handNumber"].Value) - 1, false, 0, 0, true);
        //        }
        //    }
        //    else if (InstructionRegexType.MulliganRegex.IsMatch(line))
        //    {
        //        Type = PlayType.Mulligan;
        //        Match match = InstructionRegexType.MulliganRegex.Match(line);
        //        if (match.Groups["coin"].Value.Equals(""))
        //        {
        //            MouseMovement.Mulligan(int.Parse(match.Groups["first"].Value), int.Parse(match.Groups["second"].Value), int.Parse(match.Groups["third"].Value));
        //        }
        //        else
        //        {
        //            MouseMovement.MulliganCoin(int.Parse(match.Groups["first"].Value), int.Parse(match.Groups["second"].Value), int.Parse(match.Groups["third"].Value), int.Parse(match.Groups["fourth"].Value));
        //        }
        //    }
        //    else if (InstructionRegexType.AttackBoardRegex.IsMatch(line))
        //    {
        //        Type = PlayType.Attack;
        //        Match match = InstructionRegexType.AttackBoardRegex.Match(line);
        //        if (int.Parse(match.Groups["boardSize"].Value) < int.Parse(match.Groups["boardNumber"].Value) || int.Parse(match.Groups["boardSize"].Value) > 7 || int.Parse(match.Groups["boardEnemySize"].Value) < int.Parse(match.Groups["boardEnemyNumber"].Value) || int.Parse(match.Groups["boardEnemySize"].Value) > 7)
        //        {
        //            Type = PlayType.Incorrect;
        //            return;
        //        }
        //        MouseMovement.AttackCard(int.Parse(match.Groups["boardSize"].Value), int.Parse(match.Groups["boardNumber"].Value) - 1, int.Parse(match.Groups["boardEnemySize"].Value), int.Parse(match.Groups["boardEnemyNumber"].Value) - 1);
        //    }
        //    else if (InstructionRegexType.AttackHeroRegex.IsMatch(line))
        //    {
        //        Type = PlayType.Attack;
        //        Match match = InstructionRegexType.AttackHeroRegex.Match(line);
        //        if (int.Parse(match.Groups["boardSize"].Value) < int.Parse(match.Groups["boardNumber"].Value) || int.Parse(match.Groups["boardSize"].Value) > 7)
        //        {
        //            Type = PlayType.Incorrect;
        //            return;
        //        }
        //        MouseMovement.AttackCard(int.Parse(match.Groups["boardSize"].Value), int.Parse(match.Groups["boardNumber"].Value) - 1, 0, 0, true);

        //    }
        //    else if (InstructionRegexType.AttackWithdHeroBoardRegex.IsMatch(line))
        //    {
        //        Type = PlayType.Attack;
        //        Match match = InstructionRegexType.AttackWithdHeroBoardRegex.Match(line);
        //        if (int.Parse(match.Groups["boardEnemySize"].Value) < int.Parse(match.Groups["boardEnemyNumber"].Value) || int.Parse(match.Groups["boardEnemySize"].Value) > 7)
        //        {
        //            Type = PlayType.Incorrect;
        //            return;
        //        }
        //        MouseMovement.AttackHero(int.Parse(match.Groups["boardEnemySize"].Value), int.Parse(match.Groups["boardEnemyNumber"].Value) - 1);
        //    }
        //    else if (InstructionRegexType.AttackWithHeroRegex.IsMatch(line))
        //    {
        //        Type = PlayType.Attack;
        //        Match match = InstructionRegexType.AttackWithHeroRegex.Match(line);
        //        MouseMovement.AttackHero(0, 0, true);

        //    }
        //    else if (InstructionRegexType.ChooseRegex.IsMatch(line))
        //    {
        //        Type = PlayType.Discover;
        //        Match match = InstructionRegexType.ChooseRegex.Match(line);
        //        if (int.Parse(match.Groups["card"].Value) > 2)
        //        {
        //            Type = PlayType.Incorrect;
        //            return;
        //        }
        //        MouseMovement.ChooseOne(int.Parse(match.Groups["card"].Value) - 1);
        //    }
        //    else if (InstructionRegexType.DiscoverRegex.IsMatch(line))
        //    {
        //        Type = PlayType.Discover;
        //        Match match = InstructionRegexType.DiscoverRegex.Match(line);
        //        if (int.Parse(match.Groups["card"].Value) > 3)
        //        {
        //            Type = PlayType.Incorrect;
        //            return;
        //        }
        //        MouseMovement.Discover(int.Parse(match.Groups["card"].Value) - 1);
        //    }
        //    else if (InstructionRegexType.EndRegex.IsMatch(line))
        //    {
        //        Type = PlayType.Other;
        //        Match match = InstructionRegexType.EndRegex.Match(line);
        //        MouseMovement.EndTurn();
        //    }
        //    else if (InstructionRegexType.HeroPowerRegex.IsMatch(line))
        //    {
        //        Type = PlayType.HeroPower;
        //        Match match = InstructionRegexType.HeroPowerRegex.Match(line);
        //        MouseMovement.Power();
        //    }
        //    else if (InstructionRegexType.HeroPowerHeroRegex.IsMatch(line))
        //    {
        //        Type = PlayType.HeroPower;
        //        Match match = InstructionRegexType.HeroPowerHeroRegex.Match(line);
        //        if (!match.Groups["enemy"].Value.Equals("e") && !match.Groups["enemy"].Value.Equals("f"))
        //        {
        //            Type = PlayType.Incorrect;
        //            return;
        //        }
        //        if (match.Groups["enemy"].Value.Equals("e"))
        //        {
        //            MouseMovement.Power(true);
        //        }
        //        else
        //        {
        //            MouseMovement.Power(false);
        //        }
        //    }
        //    else if (InstructionRegexType.HeroPowerBoardRegex.IsMatch(line))
        //    {
        //        Type = PlayType.HeroPower;
        //        Match match = InstructionRegexType.HeroPowerBoardRegex.Match(line);
        //        if (int.Parse(match.Groups["boardSize"].Value) < int.Parse(match.Groups["boardNumber"].Value) || int.Parse(match.Groups["boardSize"].Value) > 7 || (!match.Groups["enemy"].Value.Equals("e") && !match.Groups["enemy"].Value.Equals("f")))
        //        {
        //            Type = PlayType.Incorrect;
        //            return;
        //        }
        //        if (match.Groups["enemy"].Value.Equals("e"))
        //        {
        //            MouseMovement.Power(int.Parse(match.Groups["boardSize"].Value), int.Parse(match.Groups["boardNumber"].Value) - 1, true);
        //        }
        //        else
        //        {
        //            MouseMovement.Power(int.Parse(match.Groups["boardSize"].Value), int.Parse(match.Groups["boardNumber"].Value) - 1, false);
        //        }
        //    }
        //    else if (InstructionRegexType.EmoteRegex.IsMatch(line))
        //    {
        //        Type = PlayType.Other;
        //        Match match = InstructionRegexType.EmoteRegex.Match(line);
        //        switch (match.Groups["emote"].Value)
        //        {
        //            case "hi":
        //                MouseMovement.Emote(HSPoints.EmoteGreetings);
        //                break;
        //            case "wp":
        //                MouseMovement.Emote(HSPoints.EmoteWellPlayed);
        //                break;
        //            case "ty":
        //                MouseMovement.Emote(HSPoints.EmoteThanks);
        //                break;
        //            case "oh":
        //                MouseMovement.Emote(HSPoints.EmoteWow);
        //                break;
        //            case "oo":
        //                MouseMovement.Emote(HSPoints.EmoteOops);
        //                break;
        //            case "th":
        //                MouseMovement.Emote(HSPoints.EmoteThreaten);
        //                break;
        //            default:
        //                Type = PlayType.Incorrect;
        //                return;
        //        }
        //    }
        //    else if (InstructionRegexType.QueueRegex.IsMatch(line))
        //    {
        //        Type = PlayType.Other;
        //        Match match = InstructionRegexType.QueueRegex.Match(line);
        //        if (int.Parse(match.Groups["deck"].Value) < 1 || int.Parse(match.Groups["deck"].Value) > 18 || (!match.Groups["mode"].Value.Equals("r") && !match.Groups["mode"].Value.Equals("c")) || (!match.Groups["wild"].Value.Equals("w") && !match.Groups["wild"].Value.Equals("s")))
        //        {
        //            Type = PlayType.Incorrect;
        //            return;
        //        }
        //        if (match.Groups["mode"].Value.Equals("r"))
        //        {
        //            MouseMovement.Requeue(int.Parse(match.Groups["deck"].Value), true);
        //        }
        //        else
        //        {
        //            MouseMovement.Requeue(int.Parse(match.Groups["deck"].Value), false);
        //        }

        //    }
        //    else if (InstructionRegexType.SilenceRegex.IsMatch(line))
        //    {
        //        Type = PlayType.Other;
        //        Match match = InstructionRegexType.SilenceRegex.Match(line);
        //        MouseMovement.Silence();

        //    }
        //    else if (InstructionRegexType.SeeDeckRegex.IsMatch(line))
        //    {
        //        Type = PlayType.Other;
        //        Match match = InstructionRegexType.SeeDeckRegex.Match(line);

        //        MouseMovement.SeeDeck();

        //    }
        //    else if (InstructionRegexType.ConcedeRegex.IsMatch(line))
        //    {
        //        Type = PlayType.Other;
        //        Match match = InstructionRegexType.ConcedeRegex.Match(line);

        //        MouseMovement.Concede();

        //    }
        //    else
        //    {
        //        Type = PlayType.Incorrect;
        //        return;
        //    }
        //}

        public CommandChat(string line)
        {
            line = line.ToLower();
            //Full Instructions
            if (InstructionRegexType.InstructionPlayOnRegex.IsMatch(line))
            {
                Match match = InstructionRegexType.InstructionPlayOnRegex.Match(line);
                Type = PlayType.Play;
                NamePos = 0;
                TargetPos = 0;
                Name = new string(match.Groups["name"].Value.ToCharArray().Reverse().ToArray());
                Match matchsub = InstructionRegexType.InstructionNameRegex.Match(Name);
                if (!matchsub.Groups["nameuser"].Value.Equals(""))
                {
                    NameUser = matchsub.Groups["nameuser"].Value.ToCharArray()[0];
                    Name = Name.Remove(0, 2);
                }
                if (!matchsub.Groups["namepos"].Value.Equals(""))
                {
                    NamePos = int.Parse(matchsub.Groups["namepos"].Value);
                    Name = Name.Remove(0, 2);
                }
                Name = new string(Name.ToCharArray().Reverse().ToArray());

                Target = new string(match.Groups["target"].Value.ToCharArray().Reverse().ToArray());
                matchsub = InstructionRegexType.InstructionNameRegex.Match(Target);
                if (!matchsub.Groups["nameuser"].Value.Equals(""))
                {
                    TargetUser = matchsub.Groups["nameuser"].Value.ToCharArray()[0];
                    Target = Target.Remove(0, 2);
                }
                if (!matchsub.Groups["namepos"].Value.Equals(""))
                {
                    TargetPos = int.Parse(matchsub.Groups["namepos"].Value);
                    Target = Target.Remove(0, 2);
                }
                Target = new string(Target.ToCharArray().Reverse().ToArray());
            }
            else if (InstructionRegexType.InstructionPlayRegex.IsMatch(line))
            {
                Match match = InstructionRegexType.InstructionPlayRegex.Match(line);
                Type = PlayType.Play;
                NamePos = 0;
                TargetPos = 0;
                Name = new string(match.Groups["name"].Value.ToCharArray().Reverse().ToArray());
                Match matchsub = InstructionRegexType.InstructionNameRegex.Match(Name);
                if (!matchsub.Groups["nameuser"].Value.Equals(""))
                {
                    NameUser = matchsub.Groups["nameuser"].Value.ToCharArray()[0];
                    Name = Name.Remove(0, 2);
                }
                if (!matchsub.Groups["namepos"].Value.Equals(""))
                {
                    NamePos = int.Parse(matchsub.Groups["namepos"].Value);
                    Name = Name.Remove(0, 2);
                }
                Name = new string(Name.ToCharArray().Reverse().ToArray());
            }
            else if (InstructionRegexType.InstructionHeroPowerOnRegex.IsMatch(line))
            {
                Match match = InstructionRegexType.InstructionHeroPowerOnRegex.Match(line);
                Type = PlayType.HeroPower;
                TargetPos = 0;
                Target = new string(match.Groups["target"].Value.ToCharArray().Reverse().ToArray());
                Match matchsub = InstructionRegexType.InstructionNameRegex.Match(Target);
                if (!matchsub.Groups["nameuser"].Value.Equals(""))
                {
                    TargetUser = matchsub.Groups["nameuser"].Value.ToCharArray()[0];
                    Target = Target.Remove(0, 2);
                }
                if (!matchsub.Groups["namepos"].Value.Equals(""))
                {
                    TargetPos = int.Parse(matchsub.Groups["namepos"].Value);
                    Target = Target.Remove(0, 2);
                }
                Target = new string(Target.ToCharArray().Reverse().ToArray());
            }
            else if (InstructionRegexType.InstructionHeroPowerRegex.IsMatch(line))
            {
                Match match = InstructionRegexType.InstructionHeroPowerRegex.Match(line);
                Type = PlayType.HeroPower;
            }
            else if (InstructionRegexType.InstructionAttackRegex.IsMatch(line))
            {
                Match match = InstructionRegexType.InstructionAttackRegex.Match(line);
                Type = PlayType.Attack;
                NamePos = 0;
                TargetPos = 0;
                Name = new string(match.Groups["name"].Value.ToCharArray().Reverse().ToArray());
                Match matchsub = InstructionRegexType.InstructionNameRegex.Match(Name);
                if (!matchsub.Groups["nameuser"].Value.Equals(""))
                {
                    Name = Name.Remove(0, 2);
                }
                if (!matchsub.Groups["namepos"].Value.Equals(""))
                {
                    NamePos = int.Parse(matchsub.Groups["namepos"].Value);
                    Name = Name.Remove(0, 2);
                }
                Name = new string(Name.ToCharArray().Reverse().ToArray());

                Target = new string(match.Groups["target"].Value.ToCharArray().Reverse().ToArray());
                matchsub = InstructionRegexType.InstructionNameRegex.Match(Target);
                if (!matchsub.Groups["nameuser"].Value.Equals(""))
                {
                    Target = Target.Remove(0, 2);
                }
                if (!matchsub.Groups["namepos"].Value.Equals(""))
                {
                    TargetPos = int.Parse(matchsub.Groups["namepos"].Value);
                    Target = Target.Remove(0, 2);
                }
                Target = new string(Target.ToCharArray().Reverse().ToArray());
            }
            else if (InstructionRegexType.InstructionEndRegex.IsMatch(line))
            {
                Match match = InstructionRegexType.InstructionEndRegex.Match(line);
                Type = PlayType.EndTurn;
            }
            //TODO:Mirar Discover / Choose con la memoria 
            else if (InstructionRegexType.ChooseRegex.IsMatch(line))
            {
                Type = PlayType.Choose;
                Match match = InstructionRegexType.ChooseRegex.Match(line);
                if (int.Parse(match.Groups["card"].Value) > 2)
                {
                    Type = PlayType.Incorrect;
                    return;
                }
                Other = match.Groups["card"].Value;
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
                Other = match.Groups["card"].Value;
            }
            else if (InstructionRegexType.MulliganRegex.IsMatch(line))
            {
                Type = PlayType.Mulligan;
                Match match = InstructionRegexType.MulliganRegex.Match(line);
                if (match.Groups["fourth"].Value.Equals(""))
                {
                    Other = match.Groups["first"].Value + match.Groups["second"].Value + match.Groups["third"].Value;
                }
                else
                {
                    Other = match.Groups["first"].Value + match.Groups["second"].Value + match.Groups["third"].Value + match.Groups["fourth"].Value;
                }
            }
            else if (InstructionRegexType.QueueRegex.IsMatch(line))
            {
                Type = PlayType.Queue;
                Match match = InstructionRegexType.QueueRegex.Match(line);
                if (int.Parse(match.Groups["deck"].Value) < 1 || int.Parse(match.Groups["deck"].Value) > 18)
                {
                    Type = PlayType.Incorrect;
                    return;
                }
                Other = match.Groups["deck"].Value;

            }
            else if (InstructionRegexType.EmoteRegex.IsMatch(line))
            {
                Type = PlayType.Emote;
                Match match = InstructionRegexType.EmoteRegex.Match(line);
                Other = match.Groups["emote"].Value;
                if (Other.Equals("greetings") || Other.Equals("wellplayed") || Other.Equals("thanks") || Other.Equals("wow") || Other.Equals("oops") || Other.Equals("threaten"))
                {
                    return;
                }
                Type = PlayType.Incorrect;
                Other = null;
                return;
            }
            else if (InstructionRegexType.SilenceRegex.IsMatch(line))
            {
                Type = PlayType.Emote;
                Match match = InstructionRegexType.SilenceRegex.Match(line);
                Other = "silence";

            }
            else if (InstructionRegexType.SeeDeckRegex.IsMatch(line))
            {
                Type = PlayType.SeeDeck;
                Match match = InstructionRegexType.SeeDeckRegex.Match(line);
                Other = "deck";

            }
            else if (InstructionRegexType.ConcedeRegex.IsMatch(line))
            {
                Type = PlayType.Concede;
                Match match = InstructionRegexType.ConcedeRegex.Match(line);
            }
            else
            {
                Type = PlayType.Incorrect;
                return;
            }
        }
        public override string ToString()
        {
            return "PlayType: " + Type + " // Name: " + Name + " Target: " + Target + " Other: " + Other;
        }
    }
}
