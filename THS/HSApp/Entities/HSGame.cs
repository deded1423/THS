using System;
using System.Collections.Generic;
using System.Threading;
using HearthDb;
using HearthDb.CardDefs;
using HearthDb.Enums;
using THS.HSImport;
using THS.Utils;
using Type = HearthDb.Enums.Type;

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

        public HSGame()
        {
            User = new HSPlayer();
            Opponent = new HSPlayer();
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

        public HSCard[] GetMulliganCards()
        {
            if (!((Step)Tags[GameTag.STEP]).Equals(Step.BEGIN_MULLIGAN))
            {
                return null;
            }
            return User.Hand.ToArray();
        }

        //Methods that take info from the game
        public HSCard GetCard(int player, Zone zone, int id)
        {
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
            }
            return null;
        }
    }
}