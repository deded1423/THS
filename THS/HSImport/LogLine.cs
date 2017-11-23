using System;
using System.Text.RegularExpressions;
using THS.Utils;

namespace THS.HSImport
{
    public class LogLine
    {
        public DateTime Time;
        public string Process;
        public string Log;
        public string LogFile;
        public string Line;
        public LogLine()
        {
            Process = "";
            Log = "";
            LogFile = "";
            Line = "";
        }

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
            }
        }

        public override string ToString()
        {
            return Line + " L: " + Log;
        }

    }
}

