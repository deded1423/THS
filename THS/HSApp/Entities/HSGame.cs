using System;
using System.Collections.Generic;
using System.Threading;
using HearthDb;
using HearthDb.CardDefs;
using HearthDb.Enums;
using THS.HSImport;
using THS.Utils;
using Type = HearthDb.Enums.Type;
using THS.Twitch_Integration;

namespace THS.HSApp
{
    public class HSGame
    {

        //// Cards
        public List<HSCard> EnchantmentHsCards = new List<HSCard>();

        //Other
        public HSPlayer User;
        public HSPlayer Opponent;

        //Game Entity
        public Dictionary<GameTag, int> Tags = new Dictionary<GameTag, int>();
        public int NumGe;
        public bool PlayersOrdered = false;

        //USER
        private List<HSCard> OldHand;
        private List<HSCard> OldBoard;
        private List<HSCard> OldEnemyHand;
        private List<HSCard> OldEnemyBoard;
        public IrcClient irc;

        public HSGame(IrcClient i)
        {
            User = new HSPlayer();
            Opponent = new HSPlayer();
            irc = i;
        }


        //Non-Game methods
        public void ClearGame()
        {
            User.Clear();
            Opponent.Clear();
            Tags.Clear();
            NumGe = 0;
            User = new HSPlayer();
            Opponent = new HSPlayer();
            PlayersOrdered = false;

            Utils.IO.LogDebug("Game Cleared", Utils.IO.DebugFile.Hs);
        }

        //Create Things
        public void AddTag(string tag, string value)
        {
            GameTag gt = HsConstants.StringToTag(tag);
            int i = HsConstants.TagToInt(gt, value);
            if (Tags.ContainsKey(gt))
            {
                IO.LogDebug("Changed GE Tag: " + tag + " to " + i, IO.DebugFile.Hs, false);
                Tags[gt] = i;
            }
            else
            {

                IO.LogDebug("Added GE Tag: " + tag + " to " + i, IO.DebugFile.Hs, false);
                Tags.Add(gt, i);
            }

            //TRIGGERS TAGS GAME

            if (gt.Equals(GameTag.STEP) && i == (int)Step.BEGIN_MULLIGAN)
            {
                foreach (var item in GetMulliganCards())
                {
                    IO.LogDebug("Mulligan " + item, IO.DebugFile.Hs);
                }
            }
        }

        //Methods that do something to the game
        public void SendLogs()
        {
            if (User.Tags.ContainsKey(GameTag.MULLIGAN_STATE) && User.Tags[GameTag.MULLIGAN_STATE] != (int)Mulligan.DONE)
            {
                return;
            }
            if (OldHand == null)
            {
                OldHand = new List<HSCard>();
                foreach (var card in GetUserHand())
                {
                    OldHand.Add(card);
                }
            }
            if (OldBoard == null)
            {
                OldBoard = new List<HSCard>();
                foreach (var card in GetUserBoard())
                {
                    OldBoard.Add(card);
                }
            }
            if (OldEnemyHand == null)
            {
                OldEnemyHand = new List<HSCard>();
                foreach (var card in GetOpponentHand())
                {
                    OldEnemyHand.Add(card);
                }
            }
            if (OldEnemyBoard == null)
            {
                OldEnemyBoard = new List<HSCard>();
                foreach (var card in GetOpponentBoard())
                {
                    OldEnemyBoard.Add(card);
                }
            }
            List<HSCard> Hand = GetUserHand();
            List<HSCard> Board = GetUserBoard();
            List<HSCard> EnemyHand = GetOpponentHand();
            List<HSCard> EnemyBoard = GetOpponentBoard();

            if (Hand.Count != OldHand.Count)
            {
                string send;
                send = "Hand " + Hand.Count;
                foreach (var c in Hand)
                {
                    send = send + "_[";
                    send = send + c.Name + ",";
                    send = send + c.Attack + ",";
                    send = send + c.TrueHealth + ",";
                    send = send + (c.DivineShield ? 1 : 0) + ",";
                    send = send + (c.Taunt ? 1 : 0) + ",";
                    send = send + (c.Lifesteal ? 1 : 0) + ",";
                    send = send + (c.Charge ? 1 : 0) + ",";
                    send = send + (c.Windfury ? 1 : 0) + ",";
                    send = send + (c.Exhausted ? 1 : 0) + ",";
                    send = send + (c.Stealth ? 1 : 0) + "]";
                }
                irc.SendChatMessage(send);
                OldHand = Hand;
            }
            else
            {
                foreach (var card in Hand)
                {
                    if (!card.Name.Equals(OldHand[card.ZonePos - 1].Name) || !card.TrueHealth.Equals(OldHand[card.ZonePos - 1].TrueHealth) ||
                        !card.Attack.Equals(OldHand[card.ZonePos - 1].Attack) || !card.DivineShield.Equals(OldHand[card.ZonePos - 1].DivineShield) ||
                        !card.Taunt.Equals(OldHand[card.ZonePos - 1].Taunt) || !card.Lifesteal.Equals(OldHand[card.ZonePos - 1].Lifesteal) ||
                        !card.Charge.Equals(OldHand[card.ZonePos - 1].Charge) || !card.Windfury.Equals(OldHand[card.ZonePos - 1].Windfury) ||
                        !card.Exhausted.Equals(OldHand[card.ZonePos - 1].Exhausted) || !card.Stealth.Equals(OldHand[card.ZonePos - 1].Stealth))
                    {
                        string send;
                        send = "Hand " + Hand.Count;
                        foreach (var c in Hand)
                        {
                            send = send + "_[";
                            send = send + c.Name + ",";
                            send = send + c.Attack + ",";
                            send = send + c.TrueHealth + ",";
                            send = send + (c.DivineShield ? 1 : 0) + ",";
                            send = send + (c.Taunt ? 1 : 0) + ",";
                            send = send + (c.Lifesteal ? 1 : 0) + ",";
                            send = send + (c.Charge ? 1 : 0) + ",";
                            send = send + (c.Windfury ? 1 : 0) + ",";
                            send = send + (c.Exhausted ? 1 : 0) + ",";
                            send = send + (c.Stealth ? 1 : 0) + "]";
                        }
                        irc.SendChatMessage(send);
                        OldHand = Hand;
                        break;
                    }
                }
            }

            if (Board.Count != OldBoard.Count)
            {
                string send;
                send = "Board " + Board.Count;
                foreach (var c in Board)
                {
                    send = send + "_[";
                    send = send + c.Name + ",";
                    send = send + c.Attack + ",";
                    send = send + c.TrueHealth + ",";
                    send = send + (c.DivineShield ? 1 : 0) + ",";
                    send = send + (c.Taunt ? 1 : 0) + ",";
                    send = send + (c.Lifesteal ? 1 : 0) + ",";
                    send = send + (c.Charge ? 1 : 0) + ",";
                    send = send + (c.Windfury ? 1 : 0) + ",";
                    send = send + (c.Exhausted ? 1 : 0) + ",";
                    send = send + (c.Stealth ? 1 : 0) + "]";
                }
                irc.SendChatMessage(send);
                OldBoard = Board;
            }
            else
            {
                foreach (var card in Board)
                {
                    if (card.ZonePos == -1)
                    {
                        continue;
                    }
                    if (!card.Name.Equals(OldBoard[(card.ZonePos == 0) ? 0 : (card.ZonePos - 1)].Name) ||
                        !card.TrueHealth.Equals(OldBoard[(card.ZonePos == 0) ? 0 : (card.ZonePos - 1)].TrueHealth) ||
                        !card.Attack.Equals(OldBoard[(card.ZonePos == 0) ? 0 : (card.ZonePos - 1)].Attack) ||
                        !card.DivineShield.Equals(OldBoard[(card.ZonePos == 0) ? 0 : (card.ZonePos - 1)].DivineShield) ||
                        !card.Taunt.Equals(OldBoard[(card.ZonePos == 0) ? 0 : (card.ZonePos - 1)].Taunt) ||
                        !card.Lifesteal.Equals(OldBoard[(card.ZonePos == 0) ? 0 : (card.ZonePos - 1)].Lifesteal) ||
                        !card.Charge.Equals(OldBoard[(card.ZonePos == 0) ? 0 : (card.ZonePos - 1)].Charge) ||
                        !card.Windfury.Equals(OldBoard[(card.ZonePos == 0) ? 0 : (card.ZonePos - 1)].Windfury) ||
                        !card.Exhausted.Equals(OldBoard[(card.ZonePos == 0) ? 0 : (card.ZonePos - 1)].Exhausted) ||
                        !card.Stealth.Equals(OldBoard[(card.ZonePos == 0) ? 0 : (card.ZonePos - 1)].Stealth))
                    {
                        string send;
                        send = "Board " + Board.Count;
                        foreach (var c in Board)
                        {
                            send = send + "_[";
                            send = send + c.Name + ",";
                            send = send + c.Attack + ",";
                            send = send + c.TrueHealth + ",";
                            send = send + (c.DivineShield ? 1 : 0) + ",";
                            send = send + (c.Taunt ? 1 : 0) + ",";
                            send = send + (c.Lifesteal ? 1 : 0) + ",";
                            send = send + (c.Charge ? 1 : 0) + ",";
                            send = send + (c.Windfury ? 1 : 0) + ",";
                            send = send + (c.Exhausted ? 1 : 0) + ",";
                            send = send + (c.Stealth ? 1 : 0) + "]";
                        }
                        irc.SendChatMessage(send);
                        OldBoard = Board;
                        break;
                    }
                }
            }

            if (EnemyHand.Count != OldEnemyHand.Count)
            {
                string send;
                send = "EnemyHand " + EnemyHand.Count;
                foreach (var c in EnemyHand)
                {
                    send = send + "_[";
                    send = send + c.Name + ",";
                    send = send + c.Attack + ",";
                    send = send + c.TrueHealth + ",";
                    send = send + (c.DivineShield ? 1 : 0) + ",";
                    send = send + (c.Taunt ? 1 : 0) + ",";
                    send = send + (c.Lifesteal ? 1 : 0) + ",";
                    send = send + (c.Charge ? 1 : 0) + ",";
                    send = send + (c.Windfury ? 1 : 0) + ",";
                    send = send + (c.Exhausted ? 1 : 0) + ",";
                    send = send + (c.Stealth ? 1 : 0) + "]";
                }
                irc.SendChatMessage(send);
                OldEnemyHand = EnemyHand;
            }
            else
            {
                foreach (var card in EnemyHand)
                {
                    if (!card.Name.Equals(OldEnemyHand[card.ZonePos - 1].Name) || !card.TrueHealth.Equals(OldEnemyHand[card.ZonePos - 1].TrueHealth) || !card.Attack.Equals(OldEnemyHand[card.ZonePos - 1].Attack) || !card.DivineShield.Equals(OldEnemyHand[card.ZonePos - 1].DivineShield) || !card.Taunt.Equals(OldEnemyHand[card.ZonePos - 1].Taunt) || !card.Lifesteal.Equals(OldEnemyHand[card.ZonePos - 1].Lifesteal) || !card.Charge.Equals(OldEnemyHand[card.ZonePos - 1].Charge) || !card.Windfury.Equals(OldEnemyHand[card.ZonePos - 1].Windfury) || !card.Exhausted.Equals(OldEnemyHand[card.ZonePos - 1].Exhausted) || !card.Stealth.Equals(OldEnemyHand[card.ZonePos - 1].Stealth))
                    {
                        string send;
                        send = "EnemyHand " + EnemyHand.Count;
                        foreach (var c in EnemyHand)
                        {
                            send = send + "_[";
                            send = send + c.Name + ",";
                            send = send + c.Attack + ",";
                            send = send + c.TrueHealth + ",";
                            send = send + (c.DivineShield ? 1 : 0) + ",";
                            send = send + (c.Taunt ? 1 : 0) + ",";
                            send = send + (c.Lifesteal ? 1 : 0) + ",";
                            send = send + (c.Charge ? 1 : 0) + ",";
                            send = send + (c.Windfury ? 1 : 0) + ",";
                            send = send + (c.Exhausted ? 1 : 0) + ",";
                            send = send + (c.Stealth ? 1 : 0) + "]";
                        }
                        irc.SendChatMessage(send);
                        OldEnemyHand = EnemyHand;
                        break;
                    }
                }
            }
            if (EnemyBoard.Count != OldEnemyBoard.Count)
            {
                string send;
                send = "EnemyBoard " + EnemyBoard.Count;
                foreach (var c in EnemyBoard)
                {
                    send = send + "_[";
                    send = send + c.Name + ",";
                    send = send + c.Attack + ",";
                    send = send + c.TrueHealth + ",";
                    send = send + (c.DivineShield ? 1 : 0) + ",";
                    send = send + (c.Taunt ? 1 : 0) + ",";
                    send = send + (c.Lifesteal ? 1 : 0) + ",";
                    send = send + (c.Charge ? 1 : 0) + ",";
                    send = send + (c.Windfury ? 1 : 0) + ",";
                    send = send + (c.Exhausted ? 1 : 0) + ",";
                    send = send + (c.Stealth ? 1 : 0) + "]";
                }
                irc.SendChatMessage(send);
                OldEnemyBoard = EnemyBoard;
            }
            else
            {
                foreach (var card in EnemyBoard)
                {
                    if (card.ZonePos == -1)
                    {
                        continue;
                    }
                    if (!card.Name.Equals(OldEnemyBoard[(card.ZonePos == 0) ? 0 : (card.ZonePos - 1)].Name) ||
                        !card.TrueHealth.Equals(OldEnemyBoard[(card.ZonePos == 0) ? 0 : (card.ZonePos - 1)].TrueHealth) ||
                        !card.Attack.Equals(OldEnemyBoard[(card.ZonePos == 0) ? 0 : (card.ZonePos - 1)].Attack) ||
                        !card.DivineShield.Equals(OldEnemyBoard[(card.ZonePos == 0) ? 0 : (card.ZonePos - 1)].DivineShield) ||
                        !card.Taunt.Equals(OldEnemyBoard[(card.ZonePos == 0) ? 0 : (card.ZonePos - 1)].Taunt) ||
                        !card.Lifesteal.Equals(OldEnemyBoard[(card.ZonePos == 0) ? 0 : (card.ZonePos - 1)].Lifesteal) ||
                        !card.Charge.Equals(OldEnemyBoard[(card.ZonePos == 0) ? 0 : (card.ZonePos - 1)].Charge) ||
                        !card.Windfury.Equals(OldEnemyBoard[(card.ZonePos == 0) ? 0 : (card.ZonePos - 1)].Windfury) ||
                        !card.Exhausted.Equals(OldEnemyBoard[(card.ZonePos == 0) ? 0 : (card.ZonePos - 1)].Exhausted) ||
                        !card.Stealth.Equals(OldEnemyBoard[(card.ZonePos == 0) ? 0 : (card.ZonePos - 1)].Stealth))
                    {
                        string send;
                        send = "EnemyBoard " + EnemyBoard.Count;
                        foreach (var c in EnemyBoard)
                        {
                            send = send + "_[";
                            send = send + c.Name + ",";
                            send = send + c.Attack + ",";
                            send = send + c.TrueHealth + ",";
                            send = send + (c.DivineShield ? 1 : 0) + ",";
                            send = send + (c.Taunt ? 1 : 0) + ",";
                            send = send + (c.Lifesteal ? 1 : 0) + ",";
                            send = send + (c.Charge ? 1 : 0) + ",";
                            send = send + (c.Windfury ? 1 : 0) + ",";
                            send = send + (c.Exhausted ? 1 : 0) + ",";
                            send = send + (c.Stealth ? 1 : 0) + "]";
                        }
                        irc.SendChatMessage(send);
                        OldEnemyBoard = EnemyBoard;
                        break;
                    }
                }
            }

        }
        //Methods of info
        public void Debug()
        {
            IO.LogDebug("-----------DEBUGGING GAME-----------");
            IO.LogDebug("NumGE = " + NumGe);
            IO.LogDebug("Ordered = " + PlayersOrdered);
            IO.LogDebug("Tags = " + Tags.Count);
            foreach (var item in Tags)
            {
                IO.LogDebug("\t\t" + item.Key + " = " + item.Value);
            }
            IO.LogDebug("\t\t-----User-----");
            IO.LogDebug("\t\t\tName = " + User.PlayerName);
            IO.LogDebug("\t\t\tPlayerId = " + User.PlayerId);
            IO.LogDebug("\t\t\tEntityId = " + User.EntityId);
            IO.LogDebug("\t\t\tGameAccount = " + User.GameAccountId);
            IO.LogDebug("\t\t\tTags = " + User.Tags.Count);
            foreach (var item in User.Tags)
            {
                IO.LogDebug("\t\t\t\t" + item.Key + " = " + item.Value);
            }
            IO.LogDebug("\t\t\tHero = " + User.Hero);
            IO.LogDebug("\t\t\tHero Power = " + User.HeroPower);
            IO.LogDebug("\t\t\tHand = " + User.Hand.Count);
            foreach (var item in User.Hand)
            {
                IO.LogDebug("\t\t\t\t" + item);
            }
            IO.LogDebug("\t\t\tDeck = " + User.Deck.Count);
            foreach (var item in User.Deck)
            {
                IO.LogDebug("\t\t\t\t" + item);
            }
            IO.LogDebug("\t\t\tPlay = " + User.Play.Count);
            foreach (var item in User.Play)
            {
                IO.LogDebug("\t\t\t\t" + item);
            }
            IO.LogDebug("\t\t\tGraveyard = " + User.Graveyard.Count);
            foreach (var item in User.Graveyard)
            {
                IO.LogDebug("\t\t\t\t" + item);
            }
            IO.LogDebug("\t\t\tSetaside = " + User.Setaside.Count);
            foreach (var item in User.Setaside)
            {
                IO.LogDebug("\t\t\t\t" + item);
            }

            IO.LogDebug("\t\t-----Opponent-----");
            IO.LogDebug("\t\t\tName = " + Opponent.PlayerName);
            IO.LogDebug("\t\t\tPlayerId = " + Opponent.PlayerId);
            IO.LogDebug("\t\t\tEntityId = " + Opponent.EntityId);
            IO.LogDebug("\t\t\tGameAccount = " + Opponent.GameAccountId);
            IO.LogDebug("\t\t\tTags = " + Opponent.Tags.Count);
            foreach (var item in Opponent.Tags)
            {
                IO.LogDebug("\t\t\t\t" + item.Key + " = " + item.Value);
            }
            IO.LogDebug("\t\t\tHero = " + Opponent.Hero);
            IO.LogDebug("\t\t\tHero Power = " + Opponent.HeroPower);
            IO.LogDebug("\t\t\tHand = " + Opponent.Hand.Count);
            foreach (var item in Opponent.Hand)
            {
                IO.LogDebug("\t\t\t\t" + item);
            }
            IO.LogDebug("\t\t\tDeck = " + Opponent.Deck.Count);
            foreach (var item in Opponent.Deck)
            {
                IO.LogDebug("\t\t\t\t" + item);
            }
            IO.LogDebug("\t\t\tPlay = " + Opponent.Play.Count);
            foreach (var item in Opponent.Play)
            {
                IO.LogDebug("\t\t\t\t" + item);
            }
            IO.LogDebug("\t\t\tGraveyard = " + Opponent.Graveyard.Count);
            foreach (var item in Opponent.Graveyard)
            {
                IO.LogDebug("\t\t\t\t" + item);
            }
            IO.LogDebug("\t\t\tSetaside = " + Opponent.Setaside.Count);
            foreach (var item in Opponent.Setaside)
            {
                IO.LogDebug("\t\t\t\t" + item);
            }
        }

        public bool IsMulliganDone() => ((Mulligan)Tags[GameTag.MULLIGAN_STATE]).Equals(Mulligan.DONE);


        //Methods that take info from the game
        public HSCard GetCard(int player, Zone zone, int id)
        {
            //Mira todas las cartas porque sino da fallo al cambiar de posicion de deck a hand 
            HSCard card;
            if (player == User.PlayerId)
            {
                if (User.Hero.Id == id)
                {
                    return User.Hero;
                }
                else if (User.HeroPower.Id == id)
                {
                    return User.HeroPower;
                }
                if ((card = User.GetPlayId(id)) != null) return card;
                if ((card = User.GetDeckId(id)) != null) return card;
                if ((card = User.GetHandId(id)) != null) return card;
                if ((card = User.GetGraveyardId(id)) != null) return card;
                if ((card = User.GetSetasideId(id)) != null) return card;
                if ((card = User.GetRemovedId(id)) != null) return card;
                if ((card = User.GetSecretId(id)) != null) return card;

            }
            else if (player == Opponent.PlayerId)
            {
                if (Opponent.Hero.Id == id)
                {
                    return Opponent.Hero;
                }
                else if (Opponent.HeroPower.Id == id)
                {
                    return Opponent.HeroPower;
                }
                if ((card = Opponent.GetPlayId(id)) != null) return card;
                if ((card = Opponent.GetDeckId(id)) != null) return card;
                if ((card = Opponent.GetHandId(id)) != null) return card;
                if ((card = Opponent.GetGraveyardId(id)) != null) return card;
                if ((card = Opponent.GetSetasideId(id)) != null) return card;
                if ((card = Opponent.GetRemovedId(id)) != null) return card;
                if ((card = Opponent.GetSecretId(id)) != null) return card;
            }
            return null;
        }

        public List<HSCard> GetMulliganCards()
        {
            if (!((Step)Tags[GameTag.STEP]).Equals(Step.BEGIN_MULLIGAN))
            {
                return null;
            }
            return User.Hand;
        }

        public List<HSCard> GetUserHand()
        {
            List<HSCard> tmp = new List<HSCard>();
            foreach (var card in User.Hand)
            {
                tmp.Add(card);
            }
            tmp.Sort((x, y) => x.ZonePos - y.ZonePos);
            return tmp;
        }
        public List<HSCard> GetOpponentHand()
        {
            List<HSCard> tmp = new List<HSCard>();
            foreach (var card in Opponent.Hand)
            {
                tmp.Add(card);
            }
            tmp.Sort((x, y) => x.ZonePos - y.ZonePos);
            return tmp;
        }
        public List<HSCard> GetUserBoard()
        {
            List<HSCard> tmp = new List<HSCard>();
            foreach (var card in User.Play)
            {
                if (!card.Tags.ContainsKey(GameTag.ATTACHED) && !card.Tags.ContainsKey(GameTag.LINKED_ENTITY))
                {
                    tmp.Add(card);
                }
            }
            tmp.Sort((x, y) => x.ZonePos - y.ZonePos);
            return tmp;
        }
        public List<HSCard> GetOpponentBoard()
        {
            List<HSCard> tmp = new List<HSCard>();
            foreach (var card in Opponent.Play)
            {
                if (!card.Tags.ContainsKey(GameTag.ATTACHED) && !card.Tags.ContainsKey(GameTag.LINKED_ENTITY))
                {
                    tmp.Add(card);
                }
            }
            tmp.Sort((x, y) => x.ZonePos - y.ZonePos);
            return tmp;
        }
        public List<HSCard> GetUserDeadMinion()
        {
            List<HSCard> tmp = new List<HSCard>();
            foreach (var card in User.Graveyard)
            {
                if (card.CardType == CardType.MINION)
                {
                    tmp.Add(card);
                }
            }
            tmp.Sort((x, y) => x.ZonePos - y.ZonePos);
            return tmp;
        }
        public List<HSCard> GetOpponentDeadMinion()
        {
            List<HSCard> tmp = new List<HSCard>();
            foreach (var card in Opponent.Graveyard)
            {
                if (card.CardType == CardType.MINION)
                {
                    tmp.Add(card);
                }
            }
            tmp.Sort((x, y) => x.ZonePos - y.ZonePos);
            return tmp;
        }
    }
}