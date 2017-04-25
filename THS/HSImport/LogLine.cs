using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using THS.Utils;

namespace THS.HSImport
{
    class LogLine
    {
        public DateTime Time;
        public string Process;
        public string Log;
        public string LogFile;
        public string Line;

        public LogLine(string line, string logFile)
        {
            var regexRachelle = new Regex(@"^(D|W) (?<ts>([\d:.]+)) (?<process>([\w.:]+))([-\s]+)(?<log>(.*))$");
            var regexSimple = new Regex(@"^(D|W) (?<ts>([\d:.]+)) (?<process>([\w.()]+))");
            var regex = new Regex(@"^(D|W) (?<ts>([\d:.]+)) (?<process>([\w.()]+))([-\s]+)(?<log>(.*))$");
            Match match = null;
            if (regex.IsMatch(line))
            {
                match = regex.Match(line);
            }
            else
            {
                if (regexRachelle.IsMatch(line))
                {
                    match = regexRachelle.Match(line);
                }
                else
                {
                    if (regexSimple.IsMatch(line))
                    {
                        match = regexSimple.Match(line);
                    }
                    else
                    {
                        IO.LogDebug("ERROR IN LOGLINE: " + line + " // " + logFile, IO.DebugFile.LogReader);
                    }
                }
            }

            Line = line;
            DateTime time;
            if (DateTime.TryParse(match.Groups["ts"].Value, out time))
            {
                Time = DateTime.Today.Add(time.TimeOfDay);
                if (Time > DateTime.Now)
                    Time = Time.AddDays(-1);
                Log = match.Groups["log"].Value;
                Process = match.Groups["process"].Value;
                LogFile = logFile;
                if (LogFile.Equals("FullScreenFX"))
                {

                }
            }
        }

        public override string ToString()
        {
            return "Process: " + Process + " // Log: " + Log + " // LogFile: " + LogFile + " // " + Line;
        }

        public void SortLine()
        {
            switch (LogFile)
            {
                case "Power":
                    //PowerDecoder.Decode(this);
                    if (Process.Contains("GameState"))
                    {
                        IO.LogDebug(Log, IO.DebugFile.Output,false);
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
