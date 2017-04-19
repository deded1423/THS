using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace THS.HSImport
{
    class LogLine
    {
        public DateTime Time;
        public string Process;
        public string Log;
        public string LogFile;

        public LogLine(string line, string logFile)
        {
            var regex = new Regex(@"^(D|W) (?<ts>([\d:.]+)) (?<process>([\w.()]+)) (-\s+) (?<log>(.*))$");

            var match = regex.Match(line);
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
    }
}
