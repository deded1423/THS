using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Text.RegularExpressions;
using System.Threading;
using HearthDb.Enums;
using THS.Utils;
using THS.HSApp;

namespace THS.HSImport
{
    class LogHandler
    { //TODO: Arreglar eso para manejar los errores que pueden ocurrir al abrir el archivo
        private LogReader _powerReader;
        private LogReader _rachelleReader;
        private LogReader _loadingscreenReader;
        private LogReader _fullscreenReader;
        private bool _stop;
        private bool _running;
        private HSGame _hsGame;

        //UI SHIT
        private Windows.THS _ths;
        private int _count = 0;

        public LogHandler(Windows.THS ths, HSGame game)
        {
            _powerReader = new LogReader("Power");
            _rachelleReader = new LogReader("Rachelle");
            _loadingscreenReader = new LogReader("LoadingScreen");
            _fullscreenReader = new LogReader("FullScreenFX");
            _ths = ths;
            _hsGame = game;
        }
        public void StartLogReader()
        {
            if (_running)
                return;
            _powerReader.Start();
            _rachelleReader.Start();
            _loadingscreenReader.Start();
            _fullscreenReader.Start();

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
            _count = 0;
            _fullscreenReader.Stop();
            _loadingscreenReader.Stop();
            _powerReader.Stop();
            _rachelleReader.Stop();
        }

        public void CopyLogs()
        {
            _powerReader.CopyLog();
            _rachelleReader.CopyLog();
            _fullscreenReader.CopyLog();
            _loadingscreenReader.CopyLog();
        }

        //USELESS
        public ConcurrentQueue<LogLine> GetLogLines()
        {
            LogLine line;
            ConcurrentQueue<LogLine> lines = new ConcurrentQueue<LogLine>();
            while (_powerReader.Lines.TryDequeue(out line))
            {
                lines.Enqueue(line);
            }
            _count += lines.Count;
            _ths.SetText(_ths.LabelRead, _count.ToString());
            while (_fullscreenReader.Lines.TryDequeue(out line))
            {
                lines.Enqueue(line);
            }
            while (_loadingscreenReader.Lines.TryDequeue(out line))
            {
                lines.Enqueue(line);
            }
            while (_rachelleReader.Lines.TryDequeue(out line))
            {
                lines.Enqueue(line);
            }
            return lines;

        }

        public void ProcessPower()
        {
            LogLine line, temp;
            Match match;
            string str;
            line = GetPowerLine();
            switch (line.LogFile)
            {
                case "Power":
                    if (PowerTaskList.BlockStartRegex.IsMatch(line.Log))
                    {

                    }
                    else if (PowerTaskList.CardIdRegex.IsMatch(line.Log))
                    {

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
                        match = PowerTaskList.TagChangeRegex.Match(line.Log);
                        if (match.Groups["entity"].Value == "GameEntity")
                        {
                            _hsGame.AddTagToGame(match.Groups["tag"].Value, match.Groups["value"].Value);
                        }
                        else
                        {

                        }
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
                        temp = GetPowerLine();
                        if (temp.Log == "CREATE_GAME")
                        {
                            _hsGame.CreateNewGame();
                            temp = GetPowerLine();
                            _hsGame.numGE = int.Parse(PowerTaskList.GameEntityRegex.Match(temp.Log).Groups["id"].Value);
                            while (PowerTaskList.TagRegex.IsMatch(PeekPowerLine().Log))
                            {
                                temp = GetPowerLine();
                                match = PowerTaskList.TagRegex.Match(temp.Log);
                                _hsGame.AddTagToGame(match.Groups["tag"].Value, match.Groups["value"].Value);

                            }
                            //PLAYER
                            match = PowerTaskList.PlayerEntityRegex.Match(GetPowerLine().Log);
                            str = match.Groups["playerId"].Value;
                            if (int.Parse(str) == 2)
                            {
                                _hsGame._opponent.PlayerId = match.Groups["gameAccountId"].Value;
                                Utils.IO.LogDebug("Updated opponentId: " + match.Groups["gameAccountId"].Value);
                            }
                            else if (int.Parse(str) == 1)
                            {
                                _hsGame._player.PlayerId = match.Groups["gameAccountId"].Value;
                                Utils.IO.LogDebug("Updated playerId: " + match.Groups["gameAccountId"].Value);
                            }
                            while (PowerTaskList.TagRegex.IsMatch(PeekPowerLine().Log))
                            {
                                temp = GetPowerLine();
                                match = PowerTaskList.TagRegex.Match(temp.Log);
                                _hsGame.AddTagToPlayer(match.Groups["tag"].Value, match.Groups["value"].Value, str);

                            }
                            //OPPONENT
                            match = PowerTaskList.PlayerEntityRegex.Match(GetPowerLine().Log);
                            str = match.Groups["playerId"].Value;
                            if (int.Parse(str) == 2)
                            {
                                _hsGame._opponent.GameAccountId = match.Groups["gameAccountId"].Value;
                                Utils.IO.LogDebug("Updated opponentId: " + match.Groups["gameAccountId"].Value);
                            }
                            else if (int.Parse(str) == 1)
                            {
                                _hsGame._player.GameAccountId = match.Groups["gameAccountId"].Value;
                                Utils.IO.LogDebug("Updated playerId: " + match.Groups["gameAccountId"].Value);
                            }
                            while (PowerTaskList.TagRegex.IsMatch(PeekPowerLine().Log))
                            {
                                temp = GetPowerLine();
                                match = PowerTaskList.TagRegex.Match(temp.Log);
                                _hsGame.AddTagToPlayer(match.Groups["tag"].Value, match.Groups["value"].Value, str);

                            }
                            //CARDS
                            while (PowerTaskList.FullEntityUpdatingRegex.IsMatch(PeekPowerLine().Log))
                            {
                                match = PowerTaskList.FullEntityUpdatingRegex.Match(GetPowerLine().Log);
                                var id = int.Parse(match.Groups["id"].Value);
                                Zone zone = (Zone)Enum.Parse(typeof(Zone), match.Groups["zone"].Value);
                                var player = int.Parse(match.Groups["player"].Value);
                                string cardId = match.Groups["cardId"].Value;
                                var tags = new Dictionary<string, int>();
                                while (PowerTaskList.TagRegex.IsMatch(PeekPowerLine().Log) && !PowerTaskList.TagChangeRegex.IsMatch(PeekPowerLine().Log))
                                {
                                    temp = GetPowerLine();
                                    match = PowerTaskList.TagRegex.Match(temp.Log);
                                    tags.Add(match.Groups["tag"].Value, HsConstants.TagToInt(match.Groups["tag"].Value, match.Groups["value"].Value));
                                }
                                if (cardId == "" || (!cardId.Contains("HERO") && !cardId.Contains("CS2")))
                                {
                                    _hsGame.CreateCard(id, zone, player, cardId, tags);
                                }
                                else if (cardId.Contains("CS2"))
                                {
                                    if (player == 1)
                                    {
                                        var hp = new HSCard(id, tags);
                                        hp.UpdateCard(cardId);
                                        _hsGame._player.HeroPower = hp;
                                        Utils.IO.LogDebug("Updated HP of player: " + cardId + " Class: " + cardId);
                                    }
                                    else if (player == 2)
                                    {
                                        var hp = new HSCard(id, tags);
                                        hp.UpdateCard(cardId);
                                        _hsGame._opponent.HeroPower = hp;
                                        Utils.IO.LogDebug("Updated HP of player: " + cardId + " Class: " + cardId);
                                    }
                                }
                                else
                                {
                                    if (player == 1)
                                    {
                                        _hsGame._player.PlayerId = id.ToString();
                                        _hsGame._player.CardClass = cardId;
                                        Utils.IO.LogDebug("Updated playerId: " + id + " Class: " + cardId);
                                    }
                                    else if (player == 2)
                                    {
                                        _hsGame._opponent.PlayerId = id.ToString();
                                        _hsGame._opponent.CardClass = cardId;
                                        Utils.IO.LogDebug("Updated OpponentId: " + id + " Class:" + cardId);
                                    }
                                }
                            }
                            //TAG CHANGE
                            match = PowerTaskList.TagChangeRegex.Match(GetPowerLine().Log);
                            _hsGame.AddTagToGame(match.Groups["tag"].Value, match.Groups["value"].Value);

                            match = PowerTaskList.TagChangeRegex.Match(GetPowerLine().Log);
                            _hsGame._player.PlayerName = match.Groups["entity"].Value;
                            _hsGame._player.AddTag(match.Groups["tag"].Value, match.Groups["value"].Value);

                            match = PowerTaskList.TagChangeRegex.Match(GetPowerLine().Log);
                            _hsGame._opponent.PlayerName = match.Groups["entity"].Value;
                            _hsGame._opponent.AddTag(match.Groups["tag"].Value, match.Groups["value"].Value);


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
                        Utils.IO.LogDebug("NOT PROCESSED: " + line, IO.DebugFile.LogReader, false);
                    }

                    break;
                case "Rachelle":
                    break;
                case "LoadingScreen":
                    break;
                case "FullScreenFX":
                    break;

            }
        }

        private LogLine GetPowerLine()
        {
            while (true)
            {
                LogLine line;
                if (_powerReader.Lines.TryDequeue(out line))
                {
                    //    _count++;
                    //    _ths.SetText(_ths.LabelRead, _count.ToString());
                    Utils.IO.LogDebug(line.ToString(), IO.DebugFile.LogReader, false);
                    return line;
                }

                Thread.Sleep(0);
            }
        }
        private LogLine PeekPowerLine()
        {
            while (true)
            {
                LogLine line;
                if (_powerReader.Lines.TryPeek(out line))
                {
                    //    _count++;
                    //    _ths.SetText(_ths.LabelRead, _count.ToString());
                    return line;
                }

                Thread.Sleep(0);
            }
        }
    }
}