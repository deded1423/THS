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
using HearthDb;
using HearthDb.Enums;

namespace THS.HSImport
{
    class LogHandler
    {
        //TODO: La lectura del log no se si esta preparada para meterse  en un juego reconectado
        public LogReader PowerReader;
        public LogReader RachelleReader;
        public LogReader LoadingScreenReader;
        public LogReader FullscreenReader;
        Thread PowerHandler;
        Thread RachelleHandler;
        Thread LoadingScreenHandler;
        Thread FullscreenHandler;
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
            PowerHandler = new Thread(ProcessPower) { Name = "Power Handler" };
            LoadingScreenHandler = new Thread(ProcessLoadingScreen) { Name = "LoadingScreen Handler" };
            PowerHandler.Start();

            //TODO: Arreglar porque no sale bien las listas(Tags) si esta PowerHandler y LoadingScreenHandler a la vez
            //LoadingScreenHandler.Start();

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
            while (!_stop)
            {
                LogLine line, temp;
                Match match;
                string str;
                line = GetLine(PowerReader);
                //TODO: Mirar a ver si se utilizan todas las REGEX para quitarlas
                if (PowerTaskList.BlockStartRegex.IsMatch(line.Log))
                {
                    match = PowerTaskList.BlockStartRegex.Match(line.Log);
                    //Igual hay que cambiar estos metodos para que hgan algo con el bloque completo porque solo miran las lineas por separado
                    if (match.Groups["type"].Value.Equals("TRIGGER"))
                    {
                        BlockStartTrigger(line);
                    }
                    else if (match.Groups["type"].Value.Equals("PLAY"))
                    {
                        BlockStartPlay(line);
                    }
                    else if (match.Groups["type"].Value.Equals("ATTACK"))
                    {
                        BlockStartAttack(line);
                    }
                    else if (match.Groups["type"].Value.Equals("POWER"))
                    {
                        BlockStartPower(line);
                    }
                    else if (match.Groups["type"].Value.Equals("DEATHS"))
                    {
                        BlockStartDeaths(line);
                    }
                    else
                    {
                        throw new IndexOutOfRangeException();
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
                        continue;
                    }
                    BlockNull(line);
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

        }

        public void ProcessLoadingScreen()
        {
            while (!_stop)
            {
                LogLine line = GetLine(LoadingScreenReader);
                if (true)
                {

                }
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
            Game.ClearGame();
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
            if (match.Groups["entity"].Value.Equals("GameEntity"))
            {
                Game.AddTag(match.Groups["tag"].Value, match.Groups["value"].Value);
            }
            else if (match.Groups["entity"].Value.Equals(Game.User.PlayerName))
            {
                Game.User.AddTag(match.Groups["tag"].Value, match.Groups["value"].Value);
            }
            else if (match.Groups["entity"].Value.Equals(Game.Opponent.PlayerName))
            {
                Game.Opponent.AddTag(match.Groups["tag"].Value, match.Groups["value"].Value);
            }
            else if (LogRegex.EntityRegex.IsMatch(match.Groups["entity"].Value))
            {
                Match matchEntity = LogRegex.EntityRegex.Match(match.Groups["entity"].Value);
                HSCard card = Game.GetCard(int.Parse(matchEntity.Groups["player"].Value), (Zone)HsConstants.TagToInt(GameTag.ZONE, matchEntity.Groups["zone"].Value), int.Parse(matchEntity.Groups["id"].Value));
                if (HsConstants.StringToTag(match.Groups["tag"].Value).Equals(GameTag.ZONE))
                {
                    //Cambiar la zona de la carta en las variables
                    Zone oldzone = card.Zone;
                    card.AddTag(match.Groups["tag"].Value, match.Groups["value"].Value);
                    MoveCard(card, oldzone);
                }
                else
                {
                    card.AddTag(match.Groups["tag"].Value, match.Groups["value"].Value);
                }
            }
            else
            {
                throw new IndexOutOfRangeException();
            }
        }

        private void UpdatingEntity(LogLine line)
        {
            Match match = PowerTaskList.UpdatingEntityRegex.Match(line.Log);
            Match matchEntity = LogRegex.EntityRegex.Match(match.Groups["entity"].Value);
            if (!Game.PlayersOrdered)
            {
                if (matchEntity.Groups["player"].Value.Equals("2"))
                {
                    HSPlayer tmp = Game.User;
                    Game.User = Game.Opponent;
                    Game.Opponent = tmp;
                }
                Game.PlayersOrdered = true;
            }
            HSCard card = Game.GetCard(int.Parse(matchEntity.Groups["player"].Value), (Zone)HsConstants.TagToInt(GameTag.ZONE, matchEntity.Groups["zone"].Value), int.Parse(matchEntity.Groups["id"].Value));
            if (card.CardDB == null)
            {
                card.CardDB = Cards.All[match.Groups["cardId"].Value];
            }
            while (PowerTaskList.TagRegex.IsMatch(PeekLine(PowerReader).Log))
            {
                var a = GetLine(PowerReader).Log;
                match = PowerTaskList.TagRegex.Match(a);
                if (HsConstants.StringToTag(match.Groups["tag"].Value).Equals(GameTag.ZONE))
                {
                    Zone oldzone = card.Zone;
                    card.AddTag(match.Groups["tag"].Value, match.Groups["value"].Value);
                    MoveCard(card, oldzone);
                }
                else
                {
                    card.AddTag(match.Groups["tag"].Value, match.Groups["value"].Value);
                }
            }
            IO.LogDebug("Updated card " + card, IO.DebugFile.Hs);
        }

        private void FullEntityUpdating(LogLine line)
        {
            Match match = PowerTaskList.FullEntityUpdatingRegex.Match(line.Log);
            HSCard card = Game.GetCard(int.Parse(match.Groups["player"].Value), (Zone)HsConstants.TagToInt(GameTag.ZONE, match.Groups["zone"].Value), int.Parse(match.Groups["id"].Value));
            if (card == null)
            {
                card = CreateCard(int.Parse(match.Groups["id"].Value), match.Groups["cardId"].Value);
            }
            else
            {
                if (card.CardDB == null)
                {
                    card.CardDB = Cards.All[match.Groups["cardId"].Value];
                }
                while (PowerTaskList.TagRegex.IsMatch(PeekLine(PowerReader).Log))
                {
                    var a = GetLine(PowerReader).Log;
                    match = PowerTaskList.TagRegex.Match(a);
                    card.AddTag(match.Groups["tag"].Value, match.Groups["value"].Value);
                }
            }
            IO.LogDebug("Updated card " + card, IO.DebugFile.Hs);
        }

        private void HideEntity(LogLine line)
        {
            Match match = PowerTaskList.HideEntityRegex.Match(line.Log);
            if (LogRegex.EntityRegex.IsMatch(match.Groups["entity"].Value))
            {
                Match matchEntity = LogRegex.EntityRegex.Match(match.Groups["entity"].Value);
                HSCard card = Game.GetCard(int.Parse(matchEntity.Groups["player"].Value), (Zone)HsConstants.TagToInt(GameTag.ZONE, matchEntity.Groups["zone"].Value), int.Parse(matchEntity.Groups["id"].Value));
                Match matchPeek = PowerTaskList.TagChangeRegex.Match(PeekLine(PowerReader).Log);
                if (HsConstants.StringToTag(match.Groups["tag"].Value).Equals(GameTag.ZONE))
                {
                    Zone oldzone = card.Zone;
                    card.AddTag(match.Groups["tag"].Value, match.Groups["value"].Value);
                    MoveCard(card, oldzone);
                }
                else
                {
                    throw new IndexOutOfRangeException();
                }
            }
            else
            {
                throw new IndexOutOfRangeException();
            }

        }

        private void BlockStartTrigger(LogLine line)
        {
            LogLine logLine;
            while (!PeekLine(PowerReader).Log.Contains("Block End=") && !PeekLine(PowerReader).Log.Contains("BLOCK_END"))
            {
                logLine = GetLine(PowerReader);
                if (PowerTaskList.TagChangeRegex.IsMatch(logLine.Log))
                {
                    TagChange(logLine);
                }
                else if (PowerTaskList.UpdatingEntityRegex.IsMatch(logLine.Log))
                {
                    UpdatingEntity(logLine);
                }
                else if (PowerTaskList.FullEntityUpdatingRegex.IsMatch(logLine.Log))
                {
                    FullEntityUpdating(logLine);
                }
                else if (PowerTaskList.HideEntityRegex.IsMatch(logLine.Log))
                {
                    HideEntity(logLine);
                }
                else if (PowerTaskList.MetaDataRegex.IsMatch(logLine.Log))
                {
                    //TODO:COMPLETAR
                }
                else if (PowerTaskList.InfoRegex.IsMatch(logLine.Log))
                {
                    //TODO:COMPLETAR
                }
                else
                {
                    throw new IndexOutOfRangeException();
                }
            }
            line = GetLine(PowerReader);
        }

        private void BlockStartPlay(LogLine line)
        {
            LogLine logLine;
            while (!PeekLine(PowerReader).Log.Contains("Block End=") && !PeekLine(PowerReader).Log.Contains("BLOCK_END"))
            {
                logLine = GetLine(PowerReader);
                if (PowerTaskList.TagChangeRegex.IsMatch(logLine.Log))
                {
                    TagChange(logLine);
                }
                else if (PowerTaskList.UpdatingEntityRegex.IsMatch(logLine.Log))
                {
                    UpdatingEntity(logLine);
                }
                else if (PowerTaskList.FullEntityUpdatingRegex.IsMatch(logLine.Log))
                {
                    FullEntityUpdating(logLine);
                }
                else if (PowerTaskList.HideEntityRegex.IsMatch(logLine.Log))
                {
                    HideEntity(logLine);
                }
                else
                {
                    throw new IndexOutOfRangeException();
                }
            }
            line = GetLine(PowerReader);
        }

        private void BlockStartAttack(LogLine line)
        {
            //throw new NotImplementedException();
            LogLine logLine;
            while (!PeekLine(PowerReader).Log.Contains("Block End=") && !PeekLine(PowerReader).Log.Contains("BLOCK_END"))
            {
                logLine = GetLine(PowerReader);
                if (PowerTaskList.TagChangeRegex.IsMatch(logLine.Log))
                {
                    TagChange(logLine);
                }
                else if (PowerTaskList.UpdatingEntityRegex.IsMatch(logLine.Log))
                {
                    UpdatingEntity(logLine);
                }
                else if (PowerTaskList.FullEntityUpdatingRegex.IsMatch(logLine.Log))
                {
                    FullEntityUpdating(logLine);
                }
                else if (PowerTaskList.HideEntityRegex.IsMatch(logLine.Log))
                {
                    HideEntity(logLine);
                }
                else if (PowerTaskList.MetaDataRegex.IsMatch(logLine.Log))
                {
                    //TODO:COMPLETAR
                }
                else if (PowerTaskList.InfoRegex.IsMatch(logLine.Log))
                {
                    //TODO:COMPLETAR
                }
                else
                {
                    throw new IndexOutOfRangeException();
                }
            }
            line = GetLine(PowerReader);
        }

        private void BlockStartPower(LogLine line)
        {
            //throw new NotImplementedException();
            LogLine logLine;
            while (!PeekLine(PowerReader).Log.Contains("Block End=") && !PeekLine(PowerReader).Log.Contains("BLOCK_END"))
            {
                logLine = GetLine(PowerReader);
                if (PowerTaskList.TagChangeRegex.IsMatch(logLine.Log))
                {
                    TagChange(logLine);
                }
                else if (PowerTaskList.UpdatingEntityRegex.IsMatch(logLine.Log))
                {
                    UpdatingEntity(logLine);
                }
                else if (PowerTaskList.FullEntityUpdatingRegex.IsMatch(logLine.Log))
                {
                    FullEntityUpdating(logLine);
                }
                else if (PowerTaskList.HideEntityRegex.IsMatch(logLine.Log))
                {
                    HideEntity(logLine);
                }
                else if (PowerTaskList.MetaDataRegex.IsMatch(logLine.Log))
                {
                    //TODO:COMPLETAR
                }
                else if (PowerTaskList.InfoRegex.IsMatch(logLine.Log))
                {
                    //TODO:COMPLETAR
                }
                else
                {
                    throw new IndexOutOfRangeException();
                }
            }
            line = GetLine(PowerReader);
        }

        private void BlockStartDeaths(LogLine line)
        {
            //throw new NotImplementedException();
            LogLine logLine;
            while (!PeekLine(PowerReader).Log.Contains("Block End=") && !PeekLine(PowerReader).Log.Contains("BLOCK_END"))
            {
                logLine = GetLine(PowerReader);
                if (PowerTaskList.TagChangeRegex.IsMatch(logLine.Log))
                {
                    TagChange(logLine);
                }
                else if (PowerTaskList.UpdatingEntityRegex.IsMatch(logLine.Log))
                {
                    UpdatingEntity(logLine);
                }
                else if (PowerTaskList.FullEntityUpdatingRegex.IsMatch(logLine.Log))
                {
                    FullEntityUpdating(logLine);
                }
                else if (PowerTaskList.HideEntityRegex.IsMatch(logLine.Log))
                {
                    HideEntity(logLine);
                }
                else
                {
                    throw new IndexOutOfRangeException();
                }
            }
            line = GetLine(PowerReader);
        }

        private void BlockNull(LogLine line)
        {
            while (!PeekLine(PowerReader).Log.Contains("Block End=") && !PeekLine(PowerReader).Log.Contains("BLOCK_END"))
            {
                line = GetLine(PowerReader);
                if (PowerTaskList.TagChangeRegex.IsMatch(line.Log))
                {
                    TagChange(line);
                }
                else
                {
                    throw new IndexOutOfRangeException();
                }
            }
            line = GetLine(PowerReader);
        }

        private HSCard CreateCard(int id, string cardId)
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
            if (card.Controller == Game.User.PlayerId)
            {
                if (card.CardDB != null && card.CardType == CardType.HERO)
                {
                    Game.User.Hero = card;
                    return card;
                }
                else if (card.CardDB != null && card.CardType == CardType.HERO_POWER)
                {
                    Game.User.HeroPower = card;
                    return card;
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
            else if (card.Controller == Game.Opponent.PlayerId)
            {
                if (card.CardDB != null && card.CardType == CardType.HERO)
                {
                    Game.Opponent.Hero = card;
                    return card;
                }
                else if (card.CardDB != null && card.CardType == CardType.HERO_POWER)
                {
                    Game.Opponent.HeroPower = card;
                    return card;
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
            return card;
        }

        private void MoveCard(HSCard card, Zone oldzone)
        {
            if (card.Equals(oldzone)) return;
            switch (oldzone)
            {
                case Zone.INVALID:
                    break;
                case Zone.PLAY:
                    if (card.Controller == Game.User.PlayerId)
                    {
                        Game.User.Play.Remove(card);
                        IO.LogDebug("Removed User " + oldzone + " card id: " + card.Id, IO.DebugFile.Hs);
                    }
                    else if (card.Controller == Game.Opponent.PlayerId)
                    {
                        Game.Opponent.Play.Remove(card);
                        IO.LogDebug("Removed Opponent " + oldzone + " card id: " + card.Id, IO.DebugFile.Hs);
                    }
                    break;
                case Zone.DECK:
                    if (card.Controller == Game.User.PlayerId)
                    {
                        Game.User.Deck.Remove(card);
                        IO.LogDebug("Removed User " + oldzone + " card id: " + card.Id, IO.DebugFile.Hs);
                    }
                    else if (card.Controller == Game.Opponent.PlayerId)
                    {
                        Game.Opponent.Deck.Remove(card);
                        IO.LogDebug("Removed Opponent " + oldzone + " card id: " + card.Id, IO.DebugFile.Hs);
                    }
                    break;
                case Zone.HAND:
                    if (card.Controller == Game.User.PlayerId)
                    {
                        Game.User.Hand.Remove(card);
                        IO.LogDebug("Removed User " + oldzone + " card id: " + card.Id, IO.DebugFile.Hs);
                    }
                    else if (card.Controller == Game.Opponent.PlayerId)
                    {
                        Game.Opponent.Hand.Remove(card);
                        IO.LogDebug("Removed Opponent " + oldzone + " card id: " + card.Id, IO.DebugFile.Hs);
                    }
                    break;
                case Zone.GRAVEYARD:
                    if (card.Controller == Game.User.PlayerId)
                    {
                        Game.User.Graveyard.Remove(card);
                        IO.LogDebug("Removed User " + oldzone + " card id: " + card.Id, IO.DebugFile.Hs);
                    }
                    else if (card.Controller == Game.Opponent.PlayerId)
                    {
                        Game.Opponent.Graveyard.Remove(card);
                        IO.LogDebug("Removed Opponent " + oldzone + " card id: " + card.Id, IO.DebugFile.Hs);
                    }
                    break;
                case Zone.REMOVEDFROMGAME:
                    break;
                case Zone.SETASIDE:
                    if (card.Controller == Game.User.PlayerId)
                    {
                        Game.User.Setaside.Remove(card);
                        IO.LogDebug("Removed User " + oldzone + " card id: " + card.Id, IO.DebugFile.Hs);
                    }
                    else if (card.Controller == Game.Opponent.PlayerId)
                    {
                        Game.Opponent.Setaside.Remove(card);
                        IO.LogDebug("Removed Opponent " + oldzone + " card id: " + card.Id, IO.DebugFile.Hs);
                    }
                    break;
                case Zone.SECRET:
                    break;
                default:
                    throw new OverflowException();
            }
            switch ((Zone)card.Tags[GameTag.ZONE])
            {
                case Zone.INVALID:
                    break;
                case Zone.PLAY:
                    if (card.Controller == Game.User.PlayerId)
                    {
                        Game.User.Play.Add(card);
                        IO.LogDebug("Added User " + Zone.PLAY + " card id: " + card.Id, IO.DebugFile.Hs);
                    }
                    else if (card.Controller == Game.Opponent.PlayerId)
                    {
                        Game.Opponent.Play.Add(card);
                        IO.LogDebug("Added Opponent " + Zone.PLAY + " card id: " + card.Id, IO.DebugFile.Hs);
                    }
                    break;
                case Zone.DECK:
                    if (card.Controller == Game.User.PlayerId)
                    {
                        Game.User.Deck.Add(card);
                        IO.LogDebug("Added User " + Zone.DECK + " card id: " + card.Id, IO.DebugFile.Hs);
                    }
                    else if (card.Controller == Game.Opponent.PlayerId)
                    {
                        Game.Opponent.Deck.Add(card);
                        IO.LogDebug("Added Opponent " + Zone.DECK + " card id: " + card.Id, IO.DebugFile.Hs);
                    }
                    break;
                case Zone.HAND:
                    if (card.Controller == Game.User.PlayerId)
                    {
                        Game.User.Hand.Add(card);
                        IO.LogDebug("Added User " + Zone.HAND + " card id: " + card.Id, IO.DebugFile.Hs);
                    }
                    else if (card.Controller == Game.Opponent.PlayerId)
                    {
                        Game.Opponent.Hand.Add(card);
                        IO.LogDebug("Added Opponent " + Zone.HAND + " card id: " + card.Id, IO.DebugFile.Hs);
                    }
                    break;
                case Zone.GRAVEYARD:
                    if (card.Controller == Game.User.PlayerId)
                    {
                        Game.User.Graveyard.Add(card);
                        IO.LogDebug("Added User " + Zone.GRAVEYARD + " card id: " + card.Id, IO.DebugFile.Hs);
                    }
                    else if (card.Controller == Game.Opponent.PlayerId)
                    {
                        Game.Opponent.Graveyard.Add(card);
                        IO.LogDebug("Added Opponent " + Zone.GRAVEYARD + " card id: " + card.Id, IO.DebugFile.Hs);
                    }
                    break;
                case Zone.REMOVEDFROMGAME:
                    break;
                case Zone.SETASIDE:
                    if (card.Controller == Game.User.PlayerId)
                    {
                        Game.User.Setaside.Add(card);
                        IO.LogDebug("Added User " + Zone.SETASIDE + " card id: " + card.Id, IO.DebugFile.Hs);
                    }
                    else if (card.Controller == Game.Opponent.PlayerId)
                    {
                        Game.Opponent.Setaside.Add(card);
                        IO.LogDebug("Added Opponent " + Zone.SETASIDE + " card id: " + card.Id, IO.DebugFile.Hs);
                    }
                    break;
                case Zone.SECRET:
                    break;
                default:
                    throw new OverflowException();
            }
        }

    }
}