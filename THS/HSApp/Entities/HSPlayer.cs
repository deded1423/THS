﻿using System;
using System.Collections.Generic;
using HearthDb.Enums;
using THS.Utils;

namespace THS.HSApp
{
    public class HSPlayer
    {
        //INFO
        public int PlayerId;
        public int EntityId;
        public string PlayerName;
        public string GameAccountId;

        //INFO GAME
        public HSCard HeroPower;

        //GAME
        public List<HSCard> Hand;
        public List<HSCard> Graveyard;
        public List<HSCard> Removed;
        public List<HSCard> Deck;
        public List<HSCard> Play;
        public List<HSCard> Setaside;
        public List<HSCard> Secret;

        public Dictionary<GameTag, int> Tags = new Dictionary<GameTag, int>();
        public HSCard Hero;

        public HSPlayer()
        {
            Hand = new List<HSCard>();
            Graveyard = new List<HSCard>();
            Removed = new List<HSCard>();
            Deck = new List<HSCard>();
            Play = new List<HSCard>();
            Setaside = new List<HSCard>();
            Secret = new List<HSCard>();
        }

        //GETTERS GENERAL
        public int Attack
        {
            get
            {
                return Hero.Attack;
            }
        }
        public int Health
        {
            get
            {
                return Hero.TrueHealth;
            }
        }
        public int Armor
        {
            get
            {
                return Hero.Armor;
            }
        }
        public int Mana
        {
            get
            {
                return (Tags.ContainsKey(GameTag.RESOURCES) ? Tags[GameTag.RESOURCES] : 0) - (Tags.ContainsKey(GameTag.RESOURCES_USED) ? Tags[GameTag.RESOURCES_USED] : 0) + (Tags.ContainsKey(GameTag.TEMP_RESOURCES) ? Tags[GameTag.TEMP_RESOURCES] : 0);
            }
        }
        public int MaxMana
        {
            get
            {
                return (Tags.ContainsKey(GameTag.RESOURCES) ? Tags[GameTag.RESOURCES] : 0);
            }
        }
        public bool IsPlaying
        {
            get
            {
                if (Tags.ContainsKey(GameTag.CURRENT_PLAYER))
                {
                    return Tags[GameTag.CURRENT_PLAYER] == 1 ? true : false;
                }
                return false;
            }
        }
        public bool HasCombo
        {
            get
            {
                return Tags[GameTag.COMBO_ACTIVE] == 1 ? true : false;
            }
        }
        public HSCard Weapon
        {
            get
            {
                foreach (var card in Play)
                {
                    if (card.CardType.Equals(CardType.WEAPON))
                    {
                        return card;
                    }
                }
                return new HSCard();
            }
        }
        public bool Exhausted
        {
            get
            {
                return (Hero.Tags.ContainsKey(GameTag.EXHAUSTED) && Hero.Tags[GameTag.EXHAUSTED] == 1) ? true : false;
            }
        }
        public bool HeroPowerNeedsTarget
        {
            get
            {
                if (Hero.CardDB.Class == CardClass.MAGE || Hero.CardDB.Class == CardClass.PRIEST)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        // List<HSCard> Secret esta hecho arriba
        //public List<HSCard> Secrets
        //{
        //    get
        //    {
        //        List<HSCard> tmp = new List<HSCard>();
        //        foreach (var card in Play)
        //        {
        //            if (card.IsSecret)
        //            {
        //                tmp.Add(card);
        //            }
        //        }
        //        return tmp;
        //    }
        //}

        public void Clear()
        {
            IO.LogDebug("Clearing Player", IO.DebugFile.Hs);
            Hand.Clear();
            Graveyard.Clear();
            Deck.Clear();
            Play.Clear();
            Setaside.Clear();
            Secret.Clear();
            Removed.Clear();
            Tags.Clear();
            Hero = null;

            PlayerId = 0;
            EntityId = 0;
            PlayerName = null;
            GameAccountId = null;
        }


        //TAGS RELATED
        public void AddTag(string tag, string value)
        {
            GameTag gt = HsConstants.StringToTag(tag);
            int i = HsConstants.TagToInt(gt, value);
            if (Tags.ContainsKey(gt))
            {
                IO.LogDebug("Changed Player" + PlayerId + " Tag: " + tag + " to " + i, IO.DebugFile.Hs, false);
                Tags[gt] = i;
            }
            else
            {
                IO.LogDebug("Added Player" + PlayerId + " Tag: " + tag + " to " + i, IO.DebugFile.Hs, false);
                Tags.Add(gt, i);
            }
        }

        //GETTERS CARDS
        public HSCard GetHandCard(int id)
        {
            foreach (var card in Hand)
            {
                if (card.Id == id)
                {
                    return card;
                }
            }
            return null;
        }

        public HSCard GetDeckCard(int id)
        {
            foreach (var card in Deck)
            {
                if (card.Id == id)
                {
                    return card;
                }
            }
            return null;
        }

        public HSCard GetPlayCard(int id)
        {
            foreach (var card in Play)
            {
                if (card.Id == id)
                {
                    return card;
                }
            }
            return null;
        }

        public HSCard GetSetasideCard(int id)
        {
            foreach (var card in Setaside)
            {
                if (card.Id == id)
                {
                    return card;
                }
            }
            return null;
        }

        public HSCard GetGraveyardCard(int id)
        {
            foreach (var card in Graveyard)
            {
                if (card.Id == id)
                {
                    return card;
                }
            }
            return null;
        }

        public HSCard GetRemovedCard(int id)
        {
            foreach (var card in Removed)
            {
                if (card.Id == id)
                {
                    return card;
                }
            }
            return null;
        }

        public HSCard GetSecretCard(int id)
        {
            foreach (var card in Secret)
            {
                if (card.Id == id)
                {
                    return card;
                }
            }
            return null;
        }
        public List<HSCard> GetEnchantsOfCard(int id)
        {
            var tmp = new List<HSCard>();
            foreach (var card in Play)
            {
                if (card.Tags.ContainsKey(GameTag.ATTACHED) && Tags[GameTag.ATTACHED] == id)
                {
                    tmp.Add(card);
                }
            }
            return tmp;
        }

        public HSCard GetHandCard(string name)
        {
            foreach (var card in Hand)
            {
                if (card.Name.ToLower().Equals(name.ToLower()))
                {
                    return card;
                }
            }
            return null;
        }

        public HSCard GetDeckCard(string name)
        {
            foreach (var card in Deck)
            {
                if (card.Name.ToLower().Equals(name.ToLower()))
                {
                    return card;
                }
            }
            return null;
        }

        public HSCard GetPlayCard(string name)
        {
            foreach (var card in Play)
            {
                if (card.Name.ToLower().Equals(name.ToLower()))
                {
                    return card;
                }
            }
            return null;
        }

        public HSCard GetSetasideCard(string name)
        {
            foreach (var card in Setaside)
            {
                if (card.Name.ToLower().Equals(name.ToLower()))
                {
                    return card;
                }
            }
            return null;
        }

        public HSCard GetGraveyardCard(string name)
        {
            foreach (var card in Graveyard)
            {
                if (card.Name.ToLower().Equals(name.ToLower()))
                {
                    return card;
                }
            }
            return null;
        }

        public HSCard GetRemovedCard(string name)
        {
            foreach (var card in Removed)
            {
                if (card.Name.ToLower().Equals(name.ToLower()))
                {
                    return card;
                }
            }
            return null;
        }

        public HSCard GetSecretCard(string name)
        {
            foreach (var card in Secret)
            {
                if (card.Name.ToLower().Equals(name.ToLower()))
                {
                    return card;
                }
            }
            return null;
        }

    }
}
