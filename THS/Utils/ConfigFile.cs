using System;
using System.Collections.Specialized;

namespace THS.Utils
{
    static class ConfigFile
    {
        public static string HearthstonePath;
        public static string TwitchLoginName;
        public static string TwitchLoginOauth;
        public static StringDictionary TwitchCommands;

        public static void readConfigFile()
        {

            try
            {
                IO.LogDebug("Loading App Settings");
                HearthstonePath = App.Default.HearthstonePath;
                TwitchLoginName = App.Default.TwitchLoginName;
                TwitchLoginOauth = App.Default.TwitchLoginOauth;
                TwitchCommands = App.Default.TwitchCommands;
                IO.LogDebug("Loaded App Settings");
            }
            catch (Exception e)
            {
                IO.LogDebug("Error reading app settings: " + e);
                HearthstonePath = @"D:\Juegos\BattleNet\Hearthstone";
                TwitchLoginName = "deded1423";
                TwitchLoginOauth = "oauth:p26a360ks4lpg359oh5v8mbamsf3v1";
                TwitchCommands = new StringDictionary();
            }
        }

        public static void SaveConfigFile()
        {

            try
            {
                IO.LogDebug("Saving App settings");
                App.Default.HearthstonePath = HearthstonePath;
                App.Default.TwitchLoginName = TwitchLoginName;
                App.Default.TwitchLoginOauth = TwitchLoginOauth;
                App.Default.TwitchCommands = TwitchCommands;
                App.Default.Save();
                IO.LogDebug("Saved App settings");
            }
            catch (Exception e)
            {
                Console.WriteLine("Error, saving app settings: " + e);
            }

        }
    }
}
