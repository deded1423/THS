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

        private LogLine GetLine(LogReader log)
        {
            while (!_stop)
            {
                LogLine line;
                if (log.Lines.TryDequeue(out line))
                {
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

        //Methods for processing
        private void BlockNull(LogLine line)
        {
            LogLine logline;
            Match match;
            if (PeekLine(PowerReader).Log.Equals("CREATE_GAME"))
            {
                IO.LogDebug("Creating game", IO.DebugFile.Hs);
                logline = GetLine(PowerReader);
                logline = GetLine(PowerReader);
                while (PowerTaskList.TagRegex.IsMatch(PeekLine(PowerReader).Log))
                {
                    match = PowerTaskList.TagRegex.Match(GetLine(PowerReader).Log);
                    Game.AddTag(match.Groups["tag"].Value, match.Groups["value"].Value);
                }
            }
        }
    }
}