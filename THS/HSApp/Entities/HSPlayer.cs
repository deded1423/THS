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
        public bool Enemy;

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
        public bool CheckTag(GameTag tag)
        {
            if (Tags.ContainsKey(tag))
            {
                return (Tags[tag] == 1 ? true : false);
            }
            return false;
        }
        public bool Stealth
        {
            get
            {
                if (Tags.ContainsKey(GameTag.STEALTH))
                {
                    return Tags[GameTag.STEALTH] == 1 ? true : false;
                }
                return false;
            }
        }
        public bool Immune
        {
            get
            {
                if (Tags.ContainsKey(GameTag.IMMUNE))
                {
                    return Tags[GameTag.IMMUNE] == 1 ? true : false;
                }
                return false;
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

        public HSCard GetHandCard(string name, int num, bool exact = false, int precision = 4)
        {
            List<HSCard> cards = new List<HSCard>();

            foreach (var card in Hand)
            {
                if (card.Name.ToLower().Equals(name.ToLower()))
                {
                    cards.Add(card);
                }
            }

            if (!exact && cards.Count == 0)
            {

                bool repeated = false;
                cards = new List<HSCard>();
                foreach (var card in Hand)
                {
                    if (name.Length >= precision && card.Name.ToLower().Contains(name.ToLower()))
                    {
                        if (repeated && cards[0].Name.Equals(card.Name) && num == 0) return null;
                        cards.Add(card);
                        repeated = true;
                    }
                }
            }
            if (num == 0)
            {
                return cards[0];
            }
            else if (cards.Count >= num)
            {
                return cards[num - 1];
            }
            return null;
        }

        public HSCard GetDeckCard(string name, int num, bool exact = false, int precision = 4)
        {
            List<HSCard> cards = new List<HSCard>();

            foreach (var card in Hand)
            {
                if (card.Name.ToLower().Equals(name.ToLower()))
                {
                    cards.Add(card);
                }
            }

            if (!exact && cards.Count == 0)
            {

                bool repeated = false;
                cards = new List<HSCard>();
                foreach (var card in Hand)
                {
                    if (name.Length >= precision && card.Name.ToLower().Contains(name.ToLower()))
                    {
                        if (repeated && cards[0].Name.Equals(card.Name) && num == 0) return null;
                        cards.Add(card);
                        repeated = true;
                    }
                }
            }
            if (num == 0)
            {
                return cards[0];
            }
            else if (cards.Count >= num)
            {
                return cards[num - 1];
            }
            return null;
        }

        public HSCard GetPlayCard(string name, int num, bool exact = false, int precision = 4)
        {
            List<HSCard> cards = new List<HSCard>();

            foreach (var card in Play)
            {
                if (card.Name.ToLower().Equals(name.ToLower()))
                {
                    cards.Add(card);
                }
            }

            if (!exact && cards.Count == 0)
            {

                bool repeated = false;
                cards = new List<HSCard>();
                foreach (var card in Play)
                {
                    if (name.Length >= precision && card.Name.ToLower().Contains(name.ToLower()))
                    {
                        if (repeated && cards[0].Name.Equals(card.Name) && num == 0) return null;
                        cards.Add(card);
                        repeated = true;
                    }
                }
            }
            if (num == 0)
            {
                return cards[0];
            }
            else if (cards.Count >= num)
            {
                return cards[num - 1];
            }
            return null;
        }

        public HSCard GetSetasideCard(string name, int num, bool exact = true, int precision = 4)
        {
            foreach (var card in Setaside)
            {
                if (card.Name.ToLower().Equals(name.ToLower()))
                {
                    return card;
                }
            }

            if (!exact)
            {

                bool repeated = false;
                HSCard correct = null;
                foreach (var card in Setaside)
                {
                    if (name.Length >= precision && card.Name.ToLower().Contains(name.ToLower()))
                    {
                        if (repeated) return null;
                        correct = card;
                    }
                }
                return correct;
            }
            return null;
        }

        public HSCard GetGraveyardCard(string name, int num, bool exact = true, int precision = 4)
        {
            foreach (var card in Graveyard)
            {
                if (card.Name.ToLower().Equals(name.ToLower()))
                {
                    return card;
                }
            }

            if (!exact)
            {

                bool repeated = false;
                HSCard correct = null;
                foreach (var card in Graveyard)
                {
                    if (name.Length >= precision && card.Name.ToLower().Contains(name.ToLower()))
                    {
                        if (repeated) return null;
                        correct = card;
                    }
                }
                return correct;
            }
            return null;
        }

        public HSCard GetRemovedCard(string name, int num, bool exact = true, int precision = 4)
        {
            foreach (var card in Removed)
            {
                if (card.Name.ToLower().Equals(name.ToLower()))
                {
                    return card;
                }
            }

            if (!exact)
            {

                bool repeated = false;
                HSCard correct = null;
                foreach (var card in Removed)
                {
                    if (name.Length >= precision && card.Name.ToLower().Contains(name.ToLower()))
                    {
                        if (repeated) return null;
                        correct = card;
                    }
                }
                return correct;
            }
            return null;
        }

        public HSCard GetSecretCard(string name, int num, bool exact = true, int precision = 4)
        {
            foreach (var card in Secret)
            {
                if (card.Name.ToLower().Equals(name.ToLower()))
                {
                    return card;
                }
            }

            if (!exact)
            {

                bool repeated = false;
                HSCard correct = null;
                foreach (var card in Secret)
                {
                    if (name.Length >= precision && card.Name.ToLower().Contains(name.ToLower()))
                    {
                        if (repeated) return null;
                        correct = card;
                    }
                }
                return correct;
            }
            return null;
        }

        public bool EqualsHeroName(string name, bool noothernames = false, bool exact = false, int precision = 4)
        {
            if (name.ToLower().Equals(Hero.Name.ToLower()))
            {
                return true;
            }
            if (!noothernames)
            {
                if (!Enemy)
                {
                    foreach (var item in HsConstants.UserHeroNames)
                    {
                        name.ToLower().Equals(item.ToLower());
                    }
                }
                else
                {
                    foreach (var item in HsConstants.EnemyHeroNames)
                    {
                        name.ToLower().Equals(item.ToLower());
                    }
                }
            }
            if (!exact)
            {
                if (name.Length >= precision && Hero.Name.ToLower().Contains(name.ToLower()))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            return false;
        }

    }
}
