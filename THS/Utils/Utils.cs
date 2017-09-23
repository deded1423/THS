using System;
using System.IO;

namespace THS.Utils
{
    public class IO
    {
        public enum DebugFile
        {
            Twitch, Output, LogReader, Tcp, Hs, LogDiscarted, Input
        }
        private static StreamWriter[] _writerFiles = new StreamWriter[Enum.GetNames(typeof(DebugFile)).Length];


        public static bool OpenDebugFiles()
        { //TODO: Comprobar todas las mierdas para que se habran bien los archivos y eso, tambien lo de cerrar y todo eso (los archivos)
            if (!Directory.Exists(Path.Combine(GlobalConstants.LogPath, "Logs")))
            {
                Directory.CreateDirectory(Path.Combine(GlobalConstants.LogPath, "Logs"));
            }


            for (int i = 0; i < Enum.GetNames(typeof(DebugFile)).Length; i++)
            {
                var path = Path.Combine(GlobalConstants.LogPath, "Logs", ((DebugFile)i).ToString() + ".txt");
                if (!File.Exists(path))
                {
                    _writerFiles[i] = new StreamWriter(new FileStream(path, FileMode.CreateNew));
                }
                else
                {
                    _writerFiles[i] = new StreamWriter(path);
                }
            }

            return true;
        }

        public static void CloseDebugFiles()
        {
            foreach (var file in _writerFiles)
            {
                file?.Dispose();
            }
            //_twitchFile?.Dispose();
            //_outputFile?.Dispose();
            //_logreaderFile?.Dispose();
            //_tcpFile?.Dispose();
            //_hsFile?.Dispose();
        }
        public static void LogDebug(string message, IO.DebugFile file = DebugFile.Output, bool console = true)
        {
            _writerFiles[(int)file].WriteLine(DateTime.Now + " " + message);
            _writerFiles[(int)file].Flush();

            if (console)
            {

                Console.WriteLine(DateTime.Now + " " + message);
            }
        }

    }

    public class Misc
    {

        public static void CloseApp()
        {
            IO.CloseDebugFiles();
            if (System.Windows.Forms.Application.MessageLoop)
            {
                // WinForms app
                System.Windows.Forms.Application.Exit();
            }
            else
            {
                // Console app
                System.Environment.Exit(1);
            }
        }
    }
}
