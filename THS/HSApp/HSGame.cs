using System;
using System.Collections.Generic;
using System.Threading;
using HearthDb;
using HearthDb.CardDefs;
using HearthDb.Enums;
using THS.HearthDb;
using THS.HSImport;
using THS.Utils;
using Type = HearthDb.Enums.Type;

namespace THS.HSApp
{
    public class HSGame
    {
        LogHandler _logHandler;

        // Cards

        //List<HSCard> _handUser = new List<HSCard>();
        //List<HSCard> _handOpponent = new List<HSCard>();
        //List<HSCard> _playedUser = new List<HSCard>();
        //List<HSCard> _playedOpponent = new List<HSCard>();
        //List<HSCard> _graveyardUser = new List<HSCard>();
        //List<HSCard> _graveyardOpponent = new List<HSCard>();
        //List<HSCard> _setasideUser = new List<HSCard>();
        //List<HSCard> _setasideOpponent = new List<HSCard>();
        //List<HSCard> _deckUser = new List<HSCard>();
        //List<HSCard> _deckOpponent = new List<HSCard>();
        List<HSCard> _enchantmentHsCards = new List<HSCard>();

        //Other
        public HSPlayer User;
        public HSPlayer Opponent;

        //Game Entity
        public Dictionary<string, int> TagsGE = new Dictionary<string, int>();
        public int NumGe;

        public HSGame(Windows.THS ths)
        {
            _logHandler = new LogHandler(ths, this);
            User = new HSPlayer();
            Opponent = new HSPlayer();
        }

        public void Start()
        {
            Thread _thread = new Thread(_logHandler.StartLogReader) { IsBackground = true, Name = "LogHandler" };
            _thread.Start();
        }

        public void Stop()
        {
            _logHandler.Stop();
        }
        //Non-Game methods
        public void CreateNewGame()
        {
            User.Clear();
            Opponent.Clear();
            TagsGE.Clear();
            NumGe = 0;
            User = new HSPlayer();
            Opponent = new HSPlayer();

            Utils.IO.LogDebug("Game Created", Utils.IO.DebugFile.Hs);
        }

        //REDO THIS MAYBE??
        public HSCard CreateCard(int id, Zone zone, int player, string cardid)
        {
            Utils.IO.LogDebug("Creating card: " + id + " zone: " + zone + " player: " + player + " cardId: " + cardid, IO.DebugFile.Hs);
            var card = new HSCard(id);
            if (cardid != "")
            {
                card.UpdateCard(cardid);
            }
            if (player == 1)
            {
                if (card.Card != null && card.Card.Type == CardType.HERO_POWER)
                {
                    User.AddHeroPower(card);
                }
                else if (card.Card != null && card.Card.Type == CardType.ENCHANTMENT)
                {
                    _enchantmentHsCards.Add(card);
                }
                else if (card.Card != null && card.Card.Type == CardType.HERO)
                {
                    User.Hero = card;
                    Utils.IO.LogDebug("Updated hero: " + User.PlayerId + " Hero: " + card.Card.Name);
                }
                else
                {
                    switch (zone)
                    {
                        case Zone.DECK:
                            User.Deck.Add(card);
                            break;
                        case Zone.SETASIDE:
                            User.Setaside.Add(card);
                            break;
                        case Zone.HAND:
                            User.Hand.Add(card);
                            break;
                        case Zone.GRAVEYARD:
                            User.Graveyard.Add(card);
                            break;
                        case Zone.PLAY:
                            User.Play.Add(card);
                            break;
                        default:
                            throw new ArgumentOutOfRangeException(nameof(zone), zone, null);
                    }
                }

            }
            else if (player == 2)
            {
                if (card.Card != null && card.Card.Type == CardType.HERO_POWER)
                {
                    Opponent.AddHeroPower(card);

                }
                else if (card.Card != null && card.Card.Type == CardType.ENCHANTMENT)
                {
                    _enchantmentHsCards.Add(card);
                }
                else if (card.Card != null && card.Card.Type == CardType.HERO)
                {
                    Opponent.Hero = card;
                    Utils.IO.LogDebug("Updated hero: " + Opponent.PlayerId + " Hero: " + card.Card.Name);
                }
                else
                {
                    switch (zone)
                    {
                        case Zone.DECK:
                            Opponent.Deck.Add(card);
                            break;
                        case Zone.SETASIDE:
                            Opponent.Setaside.Add(card);
                            break;
                        case Zone.HAND:
                            Opponent.Hand.Add(card);
                            break;
                        case Zone.GRAVEYARD:
                            Opponent.Graveyard.Add(card);
                            break;
                        case Zone.PLAY:
                            Opponent.Play.Add(card);
                            break;
                        default:
                            throw new ArgumentOutOfRangeException(nameof(zone), zone, null);
                    }
                }
            }
            return card;
        }

        //Methods that do something to the game

        public void AddCardToDeck(HSCard card, HSPlayer player)
        {
            if (player == User)
            {
                User.Deck.Add(card);
            }
            else
            {
                Opponent.Deck.Add(card);
            }
        }

        public void RemoveCardToDeck(HSCard card, HSPlayer player)
        {
            if (player == User)
            {
                User.Deck.Remove(card);
            }
            else
            {
                User.Deck.Remove(card);
            }
        }

        public void AddTagToGame(string tag, string value)
        {
            if (TagsGE.ContainsKey(tag))
            {
                Utils.IO.LogDebug("Changed GameEntityTag " + tag + " from " + TagsGE[tag] + " to " + value, IO.DebugFile.Hs);
                TagsGE[tag] = HsConstants.TagToInt(tag, value);
            }
            else
            {
                Utils.IO.LogDebug("Added GameEntityTag " + tag + " " + value, IO.DebugFile.Hs);
                TagsGE.Add(tag, HsConstants.TagToInt(tag, value));
            }
        }

        public void RemoveTagFromGame(string tag)
        {
            if (TagsGE.ContainsKey(tag))
            {
                Utils.IO.LogDebug("Removed GameEntityTag " + tag + " " + TagsGE[tag], IO.DebugFile.Hs);
                TagsGE.Remove(tag);
            }
        }

        public void AddTagToPlayer(string tag, string value, string player)
        {
            int i;
            int.TryParse(player, out i);
            if (player.Equals("opponent") || player.Equals(Opponent.PlayerName) || i == 2)
            {
                Opponent.AddTag(tag, value);
            }
            else if (player.Equals("player") || player.Equals(User.PlayerName) || i == 1)
            {
                User.AddTag(tag, value);
            }
        }

        public void Attack()
        {

        }

        //Methods that take info from the game

        public Step GetGameStep()
        {
            return (Step)TagsGE["STEP"];
        }

        public Step a()
        {
            return (Step)TagsGE["STEP"];
        }
    }
}