using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Security.AccessControl;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using PostSharp.Patterns.Threading;
using THS.Utils;

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

        //TCP SHIT
        private TcpClient _tcp;
        private StreamWriter _tcpWriter;
        private StreamReader _tcpReader;
        private TcpListener _tcpListener;

        public LogHandler()
        {
            _powerReader = new LogReader("Power");
            _rachelleReader = new LogReader("Rachelle");
            _loadingscreenReader = new LogReader("LoadingScreen");
            _fullscreenReader = new LogReader("FullScreenFX");
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
            while (!_stop)
            {
                List<LogLine> newlines = null;
                if (ConfigFile.ReceiveTCP)
                {
                    //TODO: ARREGLAR ESTO
                    List<string> tcplines = GetTcpLogLines();
                    newlines = new List<LogLine>();
                    foreach (var tcpline in tcplines)
                    {
                        newlines.Add(new LogLine(tcpline, "Power"));
                    }
                }
                else
                {
                    newlines = GetLogLines();
                }
                foreach (var line in newlines)
                {
                    if (ConfigFile.SendTCP)
                    {
                        if (line.LogFile == "Power")
                        {
                            _tcpWriter.WriteLine(line);
                            _tcpWriter.Flush();
                            IO.LogDebug("CLIENT   " + line.ToString());
                        }
                    }
                    else
                    {
                        //TODO: COMPLETAR, CUANDO LEO EL LOG EN LOCAL
                        IO.LogDebug(line.ToString());
                    }

                }
                _running = false;
            }
        }

        private bool _stopServer = true;
        public ConcurrentQueue<LogLine> Lines = new ConcurrentQueue<LogLine>();
        [Background]
        public void ToggleServerLogReader()
        {
            _stopServer = !_stopServer;
            IO.LogDebug("Creating TCP SERVER" + ConfigFile.SendTCPIP + ":" + ConfigFile.SendTCPPort);
            _tcpListener = new TcpListener(IPAddress.Parse(ConfigFile.ReceiveTCPIP), int.Parse(ConfigFile.ReceiveTCPPort));
            _tcpListener.Start();
            _tcp = _tcpListener.AcceptTcpClient();
            _tcpReader = new StreamReader(_tcp.GetStream());
            while (!_stopServer)
            {
                List<string> newlines = GetTcpLogLines();
                //TODO: ARREGLAR ESTO
                List<LogLine> loglines = new List<LogLine>();
                foreach (var line in newlines)
                {
                    loglines = new List<LogLine>();
                    loglines.Add(new LogLine(line, "Power"));
                    Console.WriteLine("SERVER   " + line.ToString());

                }
                foreach (var log in loglines)
                {

                }
            }
            _running = false;
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

        public void Stop()
        {
            _stop = true;
            _fullscreenReader.Stop();
            _loadingscreenReader.Stop();
            _powerReader.Stop();
            _rachelleReader.Stop();
        }

        public List<string> GetTcpLogLines()
        {
            //TODO: Hacerlo
            List<string> lines = new List<string>();
            do
            {
                lines.Add(_tcpReader.ReadLine());
            } while (_tcpReader.Peek() != -1);
            return lines;
        }
    }
}