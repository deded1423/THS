using System;
using System.Net;

namespace THS.Utils
{
    static class ConfigFile
    {
        public static string HearthstonePath;
        public static string TwitchLoginName;
        public static string TwitchLoginOauth;
        public static bool SendTCP;
        public static string SendTCPIP;
        public static string SendTCPPort;
        public static bool ReceiveTCP;
        public static string ReceiveTCPIP;
        public static string ReceiveTCPPort;

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
                IO.LogDebug("Error reading app settings: " + e);
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
                Console.WriteLine("Error saving app settings: " + e);
            }

        }
    }
}
