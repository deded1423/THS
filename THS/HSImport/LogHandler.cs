using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Net.Sockets;
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
        private HSGame _game;

        //TCP SHIT
        private TcpClient _tcp;
        private StreamWriter _tcpWriter;
        private StreamReader _tcpReader;
        private TcpListener _tcpListener;

        //UI SHIT
        private Windows.THS _ths;
        private int _count = 0;
        private int _countTCP = 0;

        public LogHandler(Windows.THS ths, HSGame game)
        {
            _powerReader = new LogReader("Power");
            _rachelleReader = new LogReader("Rachelle");
            _loadingscreenReader = new LogReader("LoadingScreen");
            _fullscreenReader = new LogReader("FullScreenFX");
            _ths = ths;
            _game = game;
        }
        [Background]
        public void StartLogReader()
        {
            if (_running)
                return;
            _powerReader.Start();
            _rachelleReader.Start();
            _loadingscreenReader.Start();
            _fullscreenReader.Start();
            if (ConfigFile.SendTCP)
            {
                try
                {
                    IO.LogDebug("Creating TCP" + ConfigFile.SendTCPIP + ":" + ConfigFile.SendTCPPort);
                    _tcp = new TcpClient(ConfigFile.SendTCPIP, int.Parse(ConfigFile.SendTCPPort));
                    _tcpWriter = new StreamWriter(_tcp.GetStream());
                }
                catch (Exception e)
                {
                    IO.LogDebug(e.ToString());
                    Stop();
                    return;
                }
            }
            else if (ConfigFile.ReceiveTCP)
            {
                IO.LogDebug("Creating TCP SERVER" + ConfigFile.SendTCPIP + ":" + ConfigFile.SendTCPPort);
                _tcpListener = new TcpListener(IPAddress.Parse(ConfigFile.ReceiveTCPIP),
                    int.Parse(ConfigFile.ReceiveTCPPort));
                _tcpListener.Start();
                _tcp = _tcpListener.AcceptTcpClient();
                _tcpReader = new StreamReader(_tcp.GetStream());
            }
            _stop = false;
            _running = true;
            List<LogLine> newlines = null;
            while (!_stop)
            {
                if (ConfigFile.ReceiveTCP)
                {
                    //TODO: ARREGLAR ESTO
                    List<string> tcplines = GetTcpLogLines();
                    newlines = new List<LogLine>();
                    _countTCP += newlines.Count;
                    _ths.SetText(_ths.LabelTCP, _countTCP.ToString());
                    foreach (var tcpline in tcplines)
                    {
                        newlines.Add(new LogLine(tcpline, "Power"));
                    }
                }
                else
                {
                    newlines = GetLogLines();
                }



                if (ConfigFile.SendTCP)
                {
                    foreach (LogLine line in newlines)
                    {
                        if (line.LogFile.Equals("Power"))
                        {
                            _tcpWriter.WriteLine(line);
                            _tcpWriter.Flush();
                            _countTCP += 1;
                            _ths.SetText(_ths.LabelTCP, _countTCP.ToString());
                            IO.LogDebug(line.ToString(), IO.DebugFile.Tcp, false);
                        }
                    }
                }
                else
                {
                    //TODO: COMPLETAR, CUANDO LEO EL LOG EN LOCAL O RECIBO CON TCP
                    ProcessLines(newlines);
                }

            }

            _running = false;
        }

        private bool _stopServer = true, _serverCreated = false;
        
        public void ToggleServerLogReader()
        {
            _stopServer = !_stopServer;
            if (!_stopServer && !_serverCreated)
            {
                IO.LogDebug("Creating TCP SERVER" + ConfigFile.SendTCPIP + ":" + ConfigFile.SendTCPPort);
                _tcpListener = new TcpListener(IPAddress.Parse(ConfigFile.ReceiveTCPIP), int.Parse(ConfigFile.ReceiveTCPPort));
                _tcpListener.Start();
                _tcp = _tcpListener.AcceptTcpClient();
                _tcp.ReceiveBufferSize = 32000;
                _tcpReader = new StreamReader(_tcp.GetStream());
                _serverCreated = true;
            }
            while (!_stopServer)
            {
                List<string> newlines = GetTcpLogLines();
                List<LogLine> loglines = new List<LogLine>();
                foreach (var line in newlines)
                {
                    loglines = new List<LogLine>();
                    loglines.Add(new LogLine(line, "Power"));
                    //IO.LogDebug(line.ToString(),IO.DebugFile.Tcp, false);

                }

                ProcessLines(loglines);
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

        public List<LogLine> GetLogLines()
        {
            LogLine line;
            List<LogLine> lines = new List<LogLine>();
            while (_powerReader.Lines.TryDequeue(out line))
            {
                lines.Add(line);
            }
            _count += lines.Count;
            _ths.SetText(_ths.LabelRead, _count.ToString());
            while (_fullscreenReader.Lines.TryDequeue(out line))
            {
                lines.Add(line);
            }
            while (_loadingscreenReader.Lines.TryDequeue(out line))
            {
                lines.Add(line);
            }
            while (_rachelleReader.Lines.TryDequeue(out line))
            {
                lines.Add(line);
            }
            return lines;

        }


        public List<string> GetTcpLogLines()
        {
            //TODO: Hacerlo
            List<string> lines = new List<string>();
            do
            {
                lines.Add(_tcpReader.ReadLine());
                var a = new StreamWriter(_tcp.GetStream());
            } while (_tcpReader.Peek() != -1);
            return lines;
        }

        public void ProcessLines(List<LogLine> list)
        {
            LogLine line;
            for (int i = 0; i < list.Count; i++)
            {
                line = list[i];
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
                            if (list[++i].Log == "CREATE_GAME")
                            {
                                _game.numGE = int.Parse(PowerTaskList.GameEntityRegex.Match(list[++i].Log).Groups["id"].Value);
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
                            Utils.IO.LogDebug("NOT PROCESSED: " + line,IO.DebugFile.LogReader,false);
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
        }
    }
}