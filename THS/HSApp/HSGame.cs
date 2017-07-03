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

        List<HSCard> _handPlayer = new List<HSCard>();
        List<HSCard> _handOpponent = new List<HSCard>();
        List<HSCard> _playedPlayer = new List<HSCard>();
        List<HSCard> _playedOpponent = new List<HSCard>();
        List<HSCard> _graveyardPlayer = new List<HSCard>();
        List<HSCard> _graveyardOpponent = new List<HSCard>();
        List<HSCard> _setasidePlayer = new List<HSCard>();
        List<HSCard> _setasideOpponent = new List<HSCard>();
        List<HSCard> _deckPlayer = new List<HSCard>();
        List<HSCard> _deckOpponent = new List<HSCard>();
        List<HSCard> _enchantmentHsCards = new List<HSCard>();

        //Other
        public HSPlayer _player;
        public HSPlayer _opponent;

        //Game Entity
        Dictionary<string, int> _tagsGE = new Dictionary<string, int>();
        public int numGE;

        public HSGame(Windows.THS ths)
        {
            _logHandler = new LogHandler(ths, this);
            _player = new HSPlayer();
            _opponent = new HSPlayer();
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

        //Methods that do something to the game
        public void CreateNewGame()
        {
            _handPlayer.Clear();
            _handOpponent.Clear();
            _graveyardPlayer.Clear();
            _graveyardOpponent.Clear();
            _deckPlayer.Clear();
            _deckOpponent.Clear();
            _tagsGE.Clear();
            numGE = 0;
            _player = new HSPlayer();
            _opponent = new HSPlayer();

            Utils.IO.LogDebug("Game Created", Utils.IO.DebugFile.Hs);
        }

        public void AddCardToDeck(HSCard card, HSPlayer player)
        {
            if (player == _player)
            {
                _handPlayer.Add(card);
            }
            else
            {
                _handOpponent.Add(card);
            }
        }
        public void RemoveCardToDeck(HSCard card, HSPlayer player)
        {
            if (player == _player)
            {
                _handPlayer.Remove(card);
            }
            else
            {
                _handOpponent.Remove(card);
            }
        }

        public void RemoveTagFromGame(string tag)
        {
            if (_tagsGE.ContainsKey(tag))
            {
                Utils.IO.LogDebug("Removed GameEntityTag " + tag + " " + _tagsGE[tag], IO.DebugFile.Hs);
                _tagsGE.Remove(tag);
            }
        }
        public void AddTagToGame(string tag, string value)
        {
            if (_tagsGE.ContainsKey(tag))
            {
                Utils.IO.LogDebug("Changed GameEntityTag " + tag + " from " + _tagsGE[tag] + " to " + value, IO.DebugFile.Hs);
                _tagsGE[tag] = HsConstants.TagToInt(tag, value);
            }
            else
            {
                Utils.IO.LogDebug("Added GameEntityTag " + tag + " " + value, IO.DebugFile.Hs);
                _tagsGE.Add(tag, HsConstants.TagToInt(tag, value));
            }
        }
        public void AddTagToPlayer(string s, string value, string player)
        {
            if (int.Parse(player) == 2 || player.Equals("opponent"))
            {
                _opponent.AddTag(s, value);
            }
            else if (int.Parse(player) == 1 || player.Equals("player"))
            {
                _player.AddTag(s, value);
            }
        }

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
                    _player.AddHeroPower(card);
                }
                else if (card.Card != null && card.Card.Type == CardType.ENCHANTMENT)
                {
                    _enchantmentHsCards.Add(card);
                }
                else if (card.Card != null && card.Card.Type == CardType.HERO)
                {
                    _player.Hero = card;
                    Utils.IO.LogDebug("Updated hero: " + _player.PlayerId + " Hero: " + card.Card.Name);
                }
                else
                {
                    switch (zone)
                    {
                        case Zone.DECK:
                            _deckPlayer.Add(card);
                            break;
                        case Zone.SETASIDE:
                            _setasidePlayer.Add(card);
                            break;
                        case Zone.HAND:
                            _handPlayer.Add(card);
                            break;
                        case Zone.GRAVEYARD:
                            _graveyardPlayer.Add(card);
                            break;
                        case Zone.PLAY:
                            _playedPlayer.Add(card);
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
                    _opponent.AddHeroPower(card);

                }
                else if (card.Card != null && card.Card.Type == CardType.ENCHANTMENT)
                {
                    _enchantmentHsCards.Add(card);
                }
                else if (card.Card != null && card.Card.Type == CardType.HERO)
                {
                    _opponent.Hero = card;
                    Utils.IO.LogDebug("Updated hero: " + _opponent.PlayerId + " Hero: " + card.Card.Name);
                }
                else
                {
                    switch (zone)
                    {
                        case Zone.DECK:
                            _deckOpponent.Add(card);
                            break;
                        case Zone.SETASIDE:
                            _setasideOpponent.Add(card);
                            break;
                        case Zone.HAND:
                            _handOpponent.Add(card);
                            break;
                        case Zone.GRAVEYARD:
                            _graveyardOpponent.Add(card);
                            break;
                        case Zone.PLAY:
                            _playedOpponent.Add(card);
                            break;
                        default:
                            throw new ArgumentOutOfRangeException(nameof(zone), zone, null);
                    }
                }
            }
            return card;
        }

        //Methods that take info from the game

        public Step GetStep()
        {
            return (Step)_tagsGE["STEP"];
        }
    }
}