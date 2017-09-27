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
        LogHandler _logHandler;

        // Cards

        List<HSCard> HandUser = new List<HSCard>();
        List<HSCard> HandOpponent = new List<HSCard>();
        List<HSCard> PlayedUser = new List<HSCard>();
        List<HSCard> PlayedOpponent = new List<HSCard>();
        List<HSCard> GraveyardUser = new List<HSCard>();
        List<HSCard> GraveyardOpponent = new List<HSCard>();
        List<HSCard> SetasideUser = new List<HSCard>();
        List<HSCard> SetasideOpponent = new List<HSCard>();
        List<HSCard> DeckUser = new List<HSCard>();
        List<HSCard> DeckOpponent = new List<HSCard>();
        List<HSCard> EnchantmentHsCards = new List<HSCard>();

        //Other
        public HSPlayer User;
        public HSPlayer Opponent;

        //Game Entity
        public Dictionary<GameTag, int> TagsGE = new Dictionary<GameTag, int>();
        public int NumGe;

        public HSGame(Windows.THS ths)
        {
            _logHandler = new LogHandler(ths, this);
            User = new HSPlayer();
            Opponent = new HSPlayer();
        }

        public void Start()
        {
            Thread _thread = new Thread(_logHandler.StartLogReader) { IsBackground = true, Name = "Main Log Handler" };
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

        //Create Things
        public HSCard CreateCard(int id, Zone zone, int player, string cardid)
        {
            Utils.IO.LogDebug("Creating card: " + id + " zone: " + zone + " player: " + player + " cardId: " + cardid, IO.DebugFile.Hs);
            var card = new HSCard(id);
            if (cardid != "")
            {
                //card.UpdateCard(cardid);
            }
            if (player == 1)
            {
                if (card.Card != null && card.Card.Type == CardType.HERO_POWER)
                {
                    //User.AddHeroPower(card);
                }
                else if (card.Card != null && card.Card.Type == CardType.ENCHANTMENT)
                {
                    EnchantmentHsCards.Add(card);
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
                    //Opponent.AddHeroPower(card);

                }
                else if (card.Card != null && card.Card.Type == CardType.ENCHANTMENT)
                {
                    EnchantmentHsCards.Add(card);
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

        public void AddTag(string tag, string value)
        {

        }
        //Methods that do something to the game

        //Methods that take info from the game

    }
}