﻿using System;
using System.IO;

namespace THS.Utils
{
    // ReSharper disable once InconsistentNaming
    public class IO
    {
        private static StreamWriter _twitchFile;
        private static StreamWriter _outputFile;
        private static StreamWriter _logreaderFile;

        public enum DebugFile
        {
            Twitch, Output, LogReader
        }

        public static bool OpenDebugFiles()
        { //TODO: Comprobar todas las mierdas para que se habran bien los archivos y eso, tambien lo de cerrar y todo eso (los archivos)
            if (!Directory.Exists(Path.Combine(GlobalConstants.LogPath, "Logs")))
            {
                Directory.CreateDirectory(Path.Combine(GlobalConstants.LogPath, "Logs"));
            }
            //Open Twitch.txt
            if (!File.Exists(Path.Combine(GlobalConstants.LogPath, "Logs", "Twitch.txt")))
            {
                _twitchFile = new StreamWriter(new FileStream(Path.Combine(GlobalConstants.LogPath, "Logs", "Twitch.txt"), FileMode.CreateNew));
            }
            else
            {
                _twitchFile = new StreamWriter(Path.Combine(GlobalConstants.LogPath, "Logs", "Twitch.txt"));
            }
            //Open LogReader.txt
            if (!File.Exists(Path.Combine(GlobalConstants.LogPath, "Logs", "LogReader.txt")))
            {
                _logreaderFile = new StreamWriter(new FileStream(Path.Combine(GlobalConstants.LogPath, "Logs", "LogReader.txt"), FileMode.CreateNew));
            }
            else
            {
                _logreaderFile = new StreamWriter(Path.Combine(GlobalConstants.LogPath, "Logs", "LogReader.txt"));
            }

            //Open Output.txt
            if (!File.Exists(Path.Combine(GlobalConstants.LogPath, "Logs", "Output.txt")))
            {
                _outputFile = new StreamWriter(new FileStream(Path.Combine(GlobalConstants.LogPath, "Logs", "Output.txt"), FileMode.CreateNew));
            }
            else
            {
                _outputFile = new StreamWriter(Path.Combine(GlobalConstants.LogPath, "Logs", "Output.txt"));
            }
            return true;
        }

        public static void CloseDebugFiles()
        {
            _twitchFile?.Dispose();
            _outputFile?.Dispose();
            _logreaderFile?.Dispose();
        }
        public static void LogDebug(string message, IO.DebugFile file = DebugFile.Output, bool console = true)
        {
            switch (file)
            {
                case DebugFile.Twitch:
                    _twitchFile.WriteLine(DateTime.Now + " " + message);
                    _twitchFile.Flush();
                    break;
                case DebugFile.Output:
                    _outputFile.WriteLine(DateTime.Now + " " + message);
                    _outputFile.Flush();
                    break;
                case DebugFile.LogReader:
                    _logreaderFile.WriteLine(DateTime.Now + " " + message);
                    _logreaderFile.Flush();
                    break;
                default:
                    throw new ArgumentOutOfRangeException(nameof(file), file, null);
            }
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
