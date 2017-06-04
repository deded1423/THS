﻿using System;
using System.Collections.Generic;
using System.Threading;
using HearthDb;
using HearthDb.CardDefs;
using HearthDb.Enums;
using THS.HearthDb;
using THS.HSImport;
using THS.Utils;

namespace THS.HSApp
{
    public class HSGame
    {
        LogHandler _logHandler;

        // Cards

        List<HSCard> _handPlayer = new List<HSCard>();
        List<HSCard> _handOpponent = new List<HSCard>();
        List<HSCard> _graveyardPlayer = new List<HSCard>();
        List<HSCard> _graveyardOpponent = new List<HSCard>();
        List<HSCard> _deckPlayer = new List<HSCard>();
        List<HSCard> _deckOpponent = new List<HSCard>();

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

        public void AddTagToGame(string tag, string value)
        {
            if (!_tagsGE.ContainsKey(tag))
            {
                _tagsGE.Add(tag, HsConstants.TagToInt(tag, value));
            }
        }
        public void RemoveTagFromGame(string tag)
        {
            if (_tagsGE.ContainsKey(tag))
            {
                _tagsGE.Remove(tag);
            }
        }
        public void ChangeTagFromGame(string tag, string value)
        {
            if (_tagsGE.ContainsKey(tag))
            {
                _tagsGE[tag] = HsConstants.TagToInt(tag, value);
            }
        }
        public void AddTagToPlayer(string value, string s, string player)
        {
            if (int.Parse(player) == 2)
            {
                _opponent.AddTag(value, s);
            }
            else if (int.Parse(player) == 1)
            {
                _player.AddTag(value, s);
            }
        }

        public void CreateCard(int id, object zone, int player, string cardid, Dictionary<string, int> tags)
        {
            if (player == 1)
            {
                Card a = Cards.All["AT_105"];
            }
            else if (player == 2)
            {

            }
        }
        //Methods that take info from the game

    }
}