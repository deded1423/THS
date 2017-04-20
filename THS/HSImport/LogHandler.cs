using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Security.AccessControl;
using System.Linq;
using System.Net.Sockets;
using System.Text;
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
        private TcpClient _tcp;

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

            _powerReader.Start();
            _rachelleReader.Start();
            _loadingscreenReader.Start();
            _fullscreenReader.Start();
            _stop = false;
            _running = true;
            while (!_stop)
            {
                var newlines = GetLogLines();
                foreach (var line in newlines)
                {
                    if (ConfigFile.SendTCP)
                    {
                        if (_tcp == null)
                        {
                            _tcp = new TcpClient(ConfigFile.TCPIP, 8888);
                        }

                    }
                    else
                    {
                        //TODO: COMPLETAR, CUANDO LEO EL LOG EN LOCAL
                    }
                }
            }
            _running = false;
        }

        public void CopyLogs()
        {
            _powerReader.CopyLog();
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
    }

    class PowerDecoder
    {
        public void Decode(string line)
        {
            if (PowerTaskList.BlockStartRegex.IsMatch(line))
            {

            }
            else if (PowerTaskList.CardIdRegex.IsMatch(line))
            {

            }
            else if (PowerTaskList.CreationRegex.IsMatch(line))
            {

            }
            else if (PowerTaskList.CreationTagRegex.IsMatch(line))
            {

            }
            else if (PowerTaskList.EntityRegex.IsMatch(line))
            {

            }
            else if (PowerTaskList.GameEntityRegex.IsMatch(line))
            {

            }
            else if (PowerTaskList.PlayerEntityRegex.IsMatch(line))
            {

            }
            else if (PowerTaskList.TagChangeRegex.IsMatch(line))
            {

            }
            else if (PowerTaskList.UpdatingEntityRegex.IsMatch(line))
            {

            }
            else
            {

            }
        }
    }
}