using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text.RegularExpressions;
using System.Threading;
using THS.Utils;
using THS.HSApp;
using HearthDb.Enums;
using HearthDb;

namespace THS.HSImport
{
    class LogHandler
    {
        //TODO: Arreglar eso para manejar los errores que pueden ocurrir al abrir el archivo
        public LogReader PowerReader;
        public LogReader RachelleReader;
        public LogReader LoadingScreenReader;
        public LogReader FullscreenReader;
        private bool _stop;
        private bool _running;
        public HSGame Game;

        //UI SHIT
        private Windows.THS _ths;

        //PROCESSING SHIT   
        public LogHandler(Windows.THS ths, HSGame game)
        {
            PowerReader = new LogReader("Power");
            RachelleReader = new LogReader("Rachelle");
            LoadingScreenReader = new LogReader("LoadingScreen");
            FullscreenReader = new LogReader("FullScreenFX");
            _ths = ths;
            Game = game;
        }
        public void StartLogReader()
        {
            if (_running)
                return;
            PowerReader.Start();
            RachelleReader.Start();
            LoadingScreenReader.Start();
            FullscreenReader.Start();

            _stop = false;
            _running = true;
            while (!_stop)
            {
                ProcessPower();
            }

            _running = false;
        }
        public void Stop()
        {
            _stop = true;
            FullscreenReader.Stop();
            LoadingScreenReader.Stop();
            PowerReader.Stop();
            RachelleReader.Stop();
        }

        public void ProcessPower()
        {
            LogLine line, temp;
            Match match;
            string str;
            line = GetLine(PowerReader);
            if (PowerTaskList.BlockStartRegex.IsMatch(line.Log))
            {
                match = PowerTaskList.BlockStartRegex.Match(line.Log);
                if (match.Groups["type"].Value.Equals("TRIGGER"))
                {
                    BlockStartTrigger(line);
                }
            }
            else if (PowerTaskList.FullEntityCreatingRegex.IsMatch(line.Log))
            {

            }
            else if (PowerTaskList.FullEntityUpdatingRegex.IsMatch(line.Log))
            {

            }
            else if (PowerTaskList.EntityRegex.IsMatch(line.Log))
            {

            }
            else if (PowerTaskList.GameEntityRegex.IsMatch(line.Log)) // Hecho en BlockNull
            {

            }
            else if (PowerTaskList.PlayerEntityRegex.IsMatch(line.Log))
            {

            }
            else if (PowerTaskList.TagChangeRegex.IsMatch(line.Log))
            {
                TagChange(line);
            }
            else if (PowerTaskList.UpdatingEntityRegex.IsMatch(line.Log))
            {

            }
            else if (PowerTaskList.TagRegex.IsMatch(line.Log))
            {

            }
            else if (PowerTaskList.CountRegex.IsMatch(line.Log))
            {

            }
            else if (PowerTaskList.BlockNullRegex.IsMatch(line.Log))
            {
                if (PeekLine(PowerReader).Log.Equals("CREATE_GAME"))
                {
                    CreateGame(line);
                }
            }
            else if (PowerTaskList.SourceRegex.IsMatch(line.Log))
            {

            }
            else if (PowerTaskList.CurrentTaskListRegex.IsMatch(line.Log))
            {

            }
            else if (PowerTaskList.MetaDataRegex.IsMatch(line.Log))
            {

            }
            else if (PowerTaskList.OptionRegex.IsMatch(line.Log))
            {

            }
            else if (PowerTaskList.SelectedOptionRegex.IsMatch(line.Log))
            {

            }
            else if (PowerTaskList.InfoRegex.IsMatch(line.Log))
            {

            }
            else if (PowerTaskList.TargetRegex.IsMatch(line.Log))
            {

            }
            else
            {
                Utils.IO.LogDebug("NOT PROCESSED: " + line, IO.DebugFile.LogReader);
            }

        }


        private LogLine GetLine(LogReader log)
        {
            while (!_stop)
            {
                LogLine line;
                if (log.Lines.TryDequeue(out line))
                {
                    if (!line.Process.Contains("PowerTaskList"))
                    {
                        Utils.IO.LogDebug(line.ToString(), IO.DebugFile.LogDiscarted, false);
                    }
                    else
                    {
                        Utils.IO.LogDebug(line.ToString(), IO.DebugFile.LogReader, false);
                        return line;
                    }
                }
            }
            return null;
        }
        private LogLine PeekLine(LogReader log)
        {
            while (!_stop)
            {
                LogLine line;
                if (log.Lines.TryPeek(out line))
                {
                    return line;
                }
            }
            return null;
        }

        //Main Methods for processing
        private void CreateGame(LogLine line)
        {
            LogLine logline;
            Match match;
            IO.LogDebug("Creating game", IO.DebugFile.Hs);
            logline = GetLine(PowerReader);
            logline = GetLine(PowerReader);
            while (PowerTaskList.TagRegex.IsMatch(PeekLine(PowerReader).Log))
            {
                match = PowerTaskList.TagRegex.Match(GetLine(PowerReader).Log);
                Game.AddTag(match.Groups["tag"].Value, match.Groups["value"].Value);
            }
            //User
            match = PowerTaskList.PlayerEntityRegex.Match(GetLine(PowerReader).Log);
            Game.User.EntityId = int.Parse(match.Groups["id"].Value);
            Game.User.PlayerId = int.Parse(match.Groups["playerId"].Value);
            Game.User.GameAccountId = match.Groups["gameAccountId"].Value;
            while (PowerTaskList.TagRegex.IsMatch(PeekLine(PowerReader).Log))
            {
                match = PowerTaskList.TagRegex.Match(GetLine(PowerReader).Log);
                Game.User.AddTag(match.Groups["tag"].Value, match.Groups["value"].Value);
            }
            //Opponent
            match = PowerTaskList.PlayerEntityRegex.Match(GetLine(PowerReader).Log);
            Game.Opponent.EntityId = int.Parse(match.Groups["id"].Value);
            Game.Opponent.PlayerId = int.Parse(match.Groups["playerId"].Value);
            Game.Opponent.GameAccountId = match.Groups["gameAccountId"].Value;
            while (PowerTaskList.TagRegex.IsMatch(PeekLine(PowerReader).Log))
            {
                match = PowerTaskList.TagRegex.Match(GetLine(PowerReader).Log);
                Game.Opponent.AddTag(match.Groups["tag"].Value, match.Groups["value"].Value);
            }
            while (PowerTaskList.FullEntityUpdatingRegex.IsMatch(PeekLine(PowerReader).Log))
            {
                match = PowerTaskList.FullEntityUpdatingRegex.Match(GetLine(PowerReader).Log);
                CreateCard(int.Parse(match.Groups["id"].Value), match.Groups["cardId"].Value);
            }
            //GameEntity
            match = PowerTaskList.TagChangeRegex.Match(GetLine(PowerReader).Log);
            Game.AddTag(match.Groups["tag"].Value, match.Groups["value"].Value);
            //User
            match = PowerTaskList.TagChangeRegex.Match(GetLine(PowerReader).Log);
            Game.User.AddTag(match.Groups["tag"].Value, match.Groups["value"].Value);
            Game.User.PlayerName = match.Groups["entity"].Value;
            //Opponent
            match = PowerTaskList.TagChangeRegex.Match(GetLine(PowerReader).Log);
            Game.Opponent.AddTag(match.Groups["tag"].Value, match.Groups["value"].Value);
            Game.Opponent.PlayerName = match.Groups["entity"].Value;
            if (!GetLine(PowerReader).Log.Contains("Block End="))
            {
                throw new NotImplementedException();
            }
        }
        private void TagChange(LogLine line)
        {
            Match match = PowerTaskList.TagChangeRegex.Match(line.Log);
            switch (match.Groups["entity"].Value)
            {
                default:
                    throw new OverflowException();
            }
        }
        private void BlockStartTrigger(LogLine line)
        {
            LogLine logLine;
            while (!PeekLine(PowerReader).Log.Contains("Block End="))
            {
                logLine = GetLine(PowerReader);
                if (PowerTaskList.TagChangeRegex.IsMatch(line.Log))
                {
                    TagChange(logLine);
                }
            }
        }
        private void CreateCard(int id, string cardId)
        {
            HSCard card = new HSCard(id);
            Match match;
            while (PowerTaskList.TagRegex.IsMatch(PeekLine(PowerReader).Log))
            {
                var a = GetLine(PowerReader).Log;
                match = PowerTaskList.TagRegex.Match(a);
                card.AddTag(match.Groups["tag"].Value, match.Groups["value"].Value);
            }
            if (cardId != "")
            {
                card.CardDB = Cards.All[cardId];
            }
            else
            {
                card.CardDB = null;
            }
            if (card.Controller == 1)
            {
                if (card.CardDB != null && card.CardType == CardType.HERO)
                {
                    Game.User.Hero = card;
                    return;
                }
                else if (card.CardDB != null && card.CardType == CardType.HERO_POWER)
                {
                    Game.User.HeroPower = card;
                    return;
                }
                switch (card.Zone)
                {
                    case Zone.INVALID:
                        break;
                    case Zone.PLAY:
                        break;
                    case Zone.DECK:
                        Game.User.Deck.Add(card);
                        break;
                    case Zone.HAND:
                        Game.User.Hand.Add(card);
                        break;
                    case Zone.GRAVEYARD:
                        Game.User.Graveyard.Add(card);
                        break;
                    case Zone.REMOVEDFROMGAME:
                        break;
                    case Zone.SETASIDE:
                        Game.User.Setaside.Add(card);
                        break;
                    case Zone.SECRET:
                        break;
                    default:
                        throw new OverflowException();
                }

            }
            else
            {
                if (card.CardDB != null && card.CardType == CardType.HERO)
                {
                    Game.Opponent.Hero = card;
                    return;
                }
                else if (card.CardDB != null && card.CardType == CardType.HERO_POWER)
                {
                    Game.Opponent.HeroPower = card;
                    return;
                }
                switch (card.Zone)
                {
                    case Zone.INVALID:
                        break;
                    case Zone.PLAY:
                        break;
                    case Zone.DECK:
                        Game.Opponent.Deck.Add(card);
                        break;
                    case Zone.HAND:
                        Game.Opponent.Hand.Add(card);
                        break;
                    case Zone.GRAVEYARD:
                        Game.Opponent.Graveyard.Add(card);
                        break;
                    case Zone.REMOVEDFROMGAME:
                        break;
                    case Zone.SETASIDE:
                        Game.Opponent.Setaside.Add(card);
                        break;
                    case Zone.SECRET:
                        break;
                    default:
                        throw new OverflowException();
                }
            }
            IO.LogDebug("Created card " + card.Id + " " + card.CardDB?.Name + " Zone: " + card.Zone + " Controller: " + card.Controller + " " + card.CardDB?.Type, IO.DebugFile.Hs);
        }
    }
}