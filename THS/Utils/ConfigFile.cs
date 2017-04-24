using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace THS.Utils
{
    static class ConfigFile
    {
        public static string HearthstonePath = null;
        public static string TwitchLoginName = null;
        public static string TwitchLoginOauth = null;
        public static bool SendTCP = false;
        public static string SendTCPIP = null;
        public static string SendTCPPort = null;
        public static bool ReceiveTCP = false;
        public static string ReceiveTCPIP = null;
        public static string ReceiveTCPPort = null;

        public static void readConfigFile()
        {

            try
            {
                IO.LogDebug("Loading App Settings");
                HearthstonePath = App.Default.HearthstonePath;
                TwitchLoginName = App.Default.TwitchLoginName;
                TwitchLoginOauth = App.Default.TwitchLoginOauth;
                SendTCP = App.Default.SendTCP;
                SendTCPIP = App.Default.SendTCPIP;
                SendTCPPort = App.Default.SendTCPPort.ToString();
                ReceiveTCP = App.Default.ReceiveTCP;
                ReceiveTCPIP = App.Default.ReceiveTCPIP;
                ReceiveTCPPort = App.Default.ReceiveTCPPort.ToString();
                IO.LogDebug("Loaded App Settings");
            }
            catch (Exception e)
            {
                IO.LogDebug("Error reading app settings");
                HearthstonePath = @"D:\Juegos\BattleNet\Hearthstone";
                TwitchLoginName = "deded1423";
                TwitchLoginOauth = "oauth:p26a360ks4lpg359oh5v8mbamsf3v1";
                SendTCP = false;
                SendTCPIP = "localhost";
                SendTCPPort = "8888";
            }
        }

        public static void saveConfigFile()
        {

            try
            {
                IO.LogDebug("Saving App settings");
                App.Default.HearthstonePath = HearthstonePath;
                App.Default.TwitchLoginName = TwitchLoginName;
                App.Default.TwitchLoginOauth = TwitchLoginOauth;
                IPAddress tmp;
                App.Default.SendTCP = SendTCP;
                if (IPAddress.TryParse(SendTCPIP, out tmp))
                    App.Default.SendTCPIP = SendTCPIP;
                App.Default.SendTCPPort = Convert.ToInt32(SendTCPPort);
                App.Default.ReceiveTCP = ReceiveTCP;
                if (IPAddress.TryParse(ReceiveTCPIP, out tmp))
                    App.Default.ReceiveTCPIP = ReceiveTCPIP;
                App.Default.ReceiveTCPPort = Convert.ToInt32(ReceiveTCPPort);
                App.Default.Save();
                IO.LogDebug("Saved App settings");
            }
            catch (Exception e)
            {
                Console.WriteLine("Error saving app settings");
            }

        }
    }
}
