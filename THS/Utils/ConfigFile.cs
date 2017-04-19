using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
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
        public static string TCPIP = null;
        public static string TCPPort = null;

        public static void readConfigFile()
        {

            try
            {
                IO.LogDebug("Loading App Settings");
                HearthstonePath = App.Default.HearthstonePath;
                TwitchLoginName = App.Default.TwitchLoginName;
                TwitchLoginOauth = App.Default.TwitchLoginOauth;
                SendTCP = App.Default.SendTCP;
                TCPIP = App.Default.TCPIP;
                TCPPort = App.Default.TCPPort;
                IO.LogDebug("Loaded App Settings");
            }
            catch (Exception e)
            {
                IO.LogDebug("Error reading app settings");
                HearthstonePath = @"D:\Juegos\BattleNet\Hearthstone";
                TwitchLoginName = "deded1423";
                TwitchLoginOauth = "oauth:p26a360ks4lpg359oh5v8mbamsf3v1";
                SendTCP = false;
                TCPIP = "localhost";
                TCPPort = "8888";
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
                App.Default.SendTCP = SendTCP;
                App.Default.TCPIP = TCPIP;
                App.Default.TCPPort = TCPPort;
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
