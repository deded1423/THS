using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Collections.Concurrent;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using THS.Utils;
using PostSharp.Patterns.Threading;

namespace THS.HSImport
{
    class LogReader
    {
        private FileStream _fs;
        public string Namespace;
        private string _filepath;
        private bool _stop;
        private bool _running;
        private Thread _thread;
        public ConcurrentQueue<LogLine> Lines = new ConcurrentQueue<LogLine>();
        public LogReader(string name)
        {
            Namespace = name;
            _filepath = Path.Combine(Utils.GlobalConstants.HearthstonePath, "Logs", Namespace + ".log");
        }

        public void Start()
        {   //TODO: Comprobar que pasa cuando no esta abierto el hs y se inicia y luego se inicia el hs, de momento lo voy a hacer como si se iniciara antes que el hs
            //TODO: hacer que se lea cuando se haga "update" del log, creo que ya esta hecho pero hay que hacer comprobaciones
            OpenFiles();
            if (_running)
                return;
            _running = true;
            _stop = false;
            _thread = new Thread(ReadLog) { IsBackground = true };
            _thread.Name = Namespace;
            IO.LogDebug("Creating Thread " + _thread.Name);
            _thread.Start();
        }
        public void CopyLog()
        {
            if (!File.Exists(Path.Combine(GlobalConstants.LogPath, "Logs", DateTime.Now + ".txt")))
            {
                var sw = new StreamWriter(new FileStream(Path.Combine(GlobalConstants.LogPath, "Logs", DateTime.Now.ToString("dd_MM_hh-mm-ss") + ".txt"), FileMode.CreateNew));
                if (File.Exists(_filepath))
                {
                    using (var fs = new FileStream(_filepath, FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
                    {
                        var sr = new StreamReader(fs);
                        IO.LogDebug("Beginning the copy");
                        Console.WriteLine(sr.EndOfStream);
                        while (!sr.EndOfStream)
                        {
                            sw.WriteLine(sr.ReadLine());
                            sw.Flush();
                        }
                        IO.LogDebug("Finalized the copy", IO.DebugFile.LogReader);
                        sw.Dispose();
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
            while (!_stop)
            {
                if (File.Exists(_filepath))
                {

                    var sr = new StreamReader(_fs);
                    string tmp;
                    //IO.LogDebug("Reading file", IO.DebugFile.LogReader);
                    while (!sr.EndOfStream && ((tmp = sr.ReadLine()) != null))
                    {
                        Lines.Enqueue(new LogLine(tmp, Namespace));
                        IO.LogDebug(tmp, IO.DebugFile.LogReader, false);
                    }
                    //IO.LogDebug("Finalized", IO.DebugFile.LogReader);
                }
                Thread.Sleep(1000);
            }
        }
    }
}
