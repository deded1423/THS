using System;
using System.Collections.Concurrent;
using System.IO;
using System.Threading;
using THS.Utils;

namespace THS.HSImport
{
    public class LogReader
    {
        private FileStream _fs;
        public string Namespace;
        private string _filepath;
        private bool _stop;
        private bool _running;
        private Thread _thread;
        private LogHandler handler;
        public ConcurrentQueue<LogLine> Lines = new ConcurrentQueue<LogLine>();
        public LogReader(string name, LogHandler h)
        {
            Namespace = name;
            handler = h;
            _filepath = Path.Combine(ConfigFile.HearthstonePath, "Logs", Namespace + ".log");
        }

        public void Start()
        {

            if (_running)
                return;
            OpenFiles();
            _running = true;
            _stop = false;
            _thread = new Thread(ReadLog) { IsBackground = true };
            _thread.Name = Namespace + " Reader";
            IO.LogDebug("Creating Thread " + _thread.Name);
            _thread.Start();
        }
        public void CopyLog()
        {
            if (!File.Exists(Path.Combine(GlobalConstants.LogPath, "Logs", DateTime.Now + ".txt")))
            {
                var sw = new StreamWriter(new FileStream(Path.Combine(GlobalConstants.LogPath, "Logs", Namespace + DateTime.Now.ToString("_dd_MM_hh-mm-ss") + ".txt"), FileMode.CreateNew));
                if (File.Exists(_filepath))
                {
                    using (var fs = new FileStream(_filepath, FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
                    {
                        var sr = new StreamReader(fs);
                        IO.LogDebug("Beginning the copy", IO.DebugFile.LogReader);
                        Console.WriteLine(sr.EndOfStream);
                        while (!sr.EndOfStream)
                        {
                            sw.WriteLine(sr.ReadLine());
                            sw.Flush();
                        }
                        IO.LogDebug("Finalized the copy", IO.DebugFile.LogReader);
                        sw.Close();
                        fs.Close();
                    }
                }
            }
        }

        private void OpenFiles()
        {
            if (!File.Exists(_filepath)) return;
            _fs = new FileStream(_filepath, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
        }

        private void CloseFiles()
        {
            _fs?.Dispose();
        }

        public void ReadLog()
        {
            if (_fs == null)
            {
                while (_fs == null)
                {
                    OpenFiles();
                    Thread.Sleep(100);
                    if (_stop)
                    {
                        return;
                    }
                }
            }
            var sr = new StreamReader(_fs);
            string tmp;
            while (!_stop)
            {
                while (!sr.EndOfStream && ((tmp = sr.ReadLine()) != null))
                {
                    Lines.Enqueue(new LogLine(tmp, Namespace));
                    switch (Namespace)
                    {
                        case "Power":
                            handler.PowerWait.Set();
                            break;
                        case "Rachelle":
                            handler.RachelleWait.Set();
                            break;
                        case "LoadingScreen":
                            handler.LoadingScreenWait.Set();
                            break;
                        case "FullScreenFX":
                            handler.FullscreenWait.Set();
                            break;
                        default:
                            break;
                    }
                }

                Thread.Sleep(50);
            }
            CloseFiles();

        }

        public void Stop()
        {
            switch (Namespace)
            {
                case "Power":
                    handler.PowerWait.Set();
                    break;
                case "Rachelle":
                    handler.RachelleWait.Set();
                    break;
                case "LoadingScreen":
                    handler.LoadingScreenWait.Set();
                    break;
                case "FullScreenFX":
                    handler.FullscreenWait.Set();
                    break;
                default:
                    break;
            }
            _stop = true;
        }
    }
}
