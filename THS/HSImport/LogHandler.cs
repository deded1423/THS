using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.IO;
using System.Linq;
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
                        match = PowerTaskList.BlockStartRegex.Match(line.Log);
                        switch (match.Groups["type"].Value)
                        {
                            case "POWER":
                                break;
                            case "TRIGGER":
                                var entity = match.Groups["entity"].Value;
                                var index = match.Groups["effectindex"].Value;
                                var target = match.Groups["target"].Value;

                                if (entity.Equals("GameEntity"))
                                {
                                    //MULLIGAN
                                    while (!PeekPowerLine().Log.Equals("BLOCK_END"))
                                    {
                                        if (PowerTaskList.TagChangeRegex.IsMatch(line.Log))
                                        {

                                        }
                                        else if (PowerTaskList.UpdatingEntityRegex.IsMatch(line.Log))
                                        {

                                        }
                                        else
                                        {

                                        }
                                    }
                                }

                                break;
                            case "DEATHS":
                                break;
                            case "ATTACK":
                                //TODO: Sin Terminar
                                var secmatch = LogRegex.EntityRegex.Match(match.Groups["entity"].Value);
                                var id = secmatch.Groups["id"].Value;
                                var player = secmatch.Groups["player"].Value;
                                var zone = Enum.Parse(typeof(Zone), secmatch.Groups["zone"].Value);
                                var zonePos = secmatch.Groups["zone"].Value;
                                secmatch = LogRegex.EntityRegex.Match(match.Groups["target"].Value);
                                var targetid = secmatch.Groups["id"].Value;
                                var targetplayer = secmatch.Groups["player"].Value;
                                var targetzone = Enum.Parse(typeof(Zone), secmatch.Groups["zone"].Value);
                                var targetzonePos = secmatch.Groups["zone"].Value;

                                break;
                        }
                    }
                    //else if (PowerTaskList.CardIdRegex.IsMatch(line.Log))
                    //{

                    //}
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
                            CreateGameLog();
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
                    if (line.Log.Contains("Block End=") || !line.Process.Contains("PowerTaskList"))
                    {
                        Utils.IO.LogDebug(line.ToString(), IO.DebugFile.LogDiscarted, false);
                    }
                    else
                    {
                        Utils.IO.LogDebug(line.ToString(), IO.DebugFile.LogReader, false);
                        return line;
                    }
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

        private void CreateGameLog()
        {
            LogLine temp;
            Match match;
            string str;

            _hsGame.CreateNewGame();
            temp = GetPowerLine();
            _hsGame.NumGe = int.Parse(PowerTaskList.GameEntityRegex.Match(temp.Log).Groups["id"].Value);
            while (PowerTaskList.TagRegex.IsMatch(PeekPowerLine().Log))
            {
                temp = GetPowerLine();
                match = PowerTaskList.TagRegex.Match(temp.Log);
                _hsGame.AddTagToGame(match.Groups["tag"].Value, match.Groups["value"].Value);

            }
            //PLAYER
            match = PowerTaskList.PlayerEntityRegex.Match(GetPowerLine().Log);
            _hsGame.User.GameAccountId = match.Groups["gameAccountId"].Value;
            _hsGame.User.PlayerId = match.Groups["playerId"].Value;
            Utils.IO.LogDebug("Updated playerId: " + match.Groups["gameAccountId"].Value);

            while (PowerTaskList.TagRegex.IsMatch(PeekPowerLine().Log))
            {
                temp = GetPowerLine();
                match = PowerTaskList.TagRegex.Match(temp.Log);
                _hsGame.AddTagToPlayer(match.Groups["tag"].Value, match.Groups["value"].Value, "1");

            }
            //OPPONENT
            match = PowerTaskList.PlayerEntityRegex.Match(GetPowerLine().Log);
            _hsGame.Opponent.GameAccountId = match.Groups["gameAccountId"].Value;
            _hsGame.Opponent.PlayerId = match.Groups["playerId"].Value;
            Utils.IO.LogDebug("Updated opponentId: " + match.Groups["gameAccountId"].Value);

            while (PowerTaskList.TagRegex.IsMatch(PeekPowerLine().Log))
            {
                temp = GetPowerLine();
                match = PowerTaskList.TagRegex.Match(temp.Log);
                _hsGame.AddTagToPlayer(match.Groups["tag"].Value, match.Groups["value"].Value, "2");

            }

            //CARDS
            temp = GetPowerLine();
            while (PowerTaskList.FullEntityUpdatingRegex.IsMatch(temp.Log))
            {
                match = PowerTaskList.FullEntityUpdatingRegex.Match(temp.Log);
                var id = int.Parse(match.Groups["id"].Value);
                Zone zone = (Zone)Enum.Parse(typeof(Zone), match.Groups["zone"].Value);
                var player = int.Parse(match.Groups["player"].Value);
                string cardId = match.Groups["cardId"].Value;

                var card = _hsGame.CreateCard(id, zone, player, cardId);
                while (PowerTaskList.TagRegex.IsMatch(PeekPowerLine().Log) && !PowerTaskList.TagChangeRegex.IsMatch(PeekPowerLine().Log))
                {
                    temp = GetPowerLine();
                    match = PowerTaskList.TagRegex.Match(temp.Log);
                    card.AddTag(match.Groups["tag"].Value, match.Groups["value"].Value);
                }
                temp = GetPowerLine();
            }
            //TAG_CHANGE
            //TODO: Manejar esto si hay una reconexion o algo asi

            temp = GetPowerLine();
            match = PowerTaskList.TagChangeRegex.Match(temp.Log);
            _hsGame.AddTagToGame("STATE", match.Groups["value"].Value);
            temp = GetPowerLine();
            match = PowerTaskList.TagChangeRegex.Match(temp.Log);
            _hsGame.Opponent.PlayerName = match.Groups["entity"].Value;
            _hsGame.AddTagToPlayer("PLAYSTATE", match.Groups["value"].Value, match.Groups["entity"].Value);
            temp = GetPowerLine();
            match = PowerTaskList.TagChangeRegex.Match(temp.Log);
            _hsGame.User.PlayerName = match.Groups["entity"].Value;
            _hsGame.AddTagToPlayer("PLAYSTATE", match.Groups["value"].Value, match.Groups["entity"].Value);


        }

    }
}