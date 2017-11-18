using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.IO;
using System.Net.Sockets;
using System.Threading;
using THS.Utils;

//TODO: Hay que pasar todo lo de twitch a lower case para que el regex no se lie
namespace THS.Twitch_Integration
{
    public class IrcClient
    {

        private string userName;
        private string _channel;
        private bool _stop = false;
        public string ip;
        public int port;

        private TcpClient tcpClient;
        private StreamReader inputStream;
        private StreamWriter outputStream;

        public ConcurrentQueue<CommandChat> Queue = new ConcurrentQueue<CommandChat>();

        public IrcClient()
        {
        }

        public void StartConnection(string _ip, int _port, string name, string auth)
        {
            userName = name;
            ip = _ip;
            port = _port;
            tcpClient = new TcpClient(ip, port);
            inputStream = new StreamReader(tcpClient.GetStream());
            outputStream = new StreamWriter(tcpClient.GetStream());

            outputStream.WriteLine("PASS " + auth);
            outputStream.WriteLine("NICK " + userName);
            outputStream.WriteLine("USER " + userName + " 8 * :" + userName);
            outputStream.Flush();
        }
        public void StartTwitchChat(object channel)
        {
            if (channel is string)
            {
                this._channel = (string)channel;
                JoinRoom((string)channel);
                while (!_stop)
                {

                    string msg = ReadMessage();
                    if (msg != null)
                    {
                        msg = msg.ToLower();
                        if (msg.Contains("tmi.twitch.tv"))
                        {
                            IO.LogDebug(msg, IO.DebugFile.Twitch);
                            continue;
                        }
                        var cmd = new CommandChat(msg);
                        if (cmd.Type != PlayType.Incorrect)
                        {
                            Queue.Enqueue(cmd);
                            IO.LogDebug(cmd.ToString(), IO.DebugFile.Twitch, false);
                        }
                        else
                        {
                            IO.LogDebug(msg, IO.DebugFile.Twitch);
                        }
                    }
                }
            }
        }

        public void JoinRoom(string channel)
        {
            Thread.Sleep(500);
            outputStream.WriteLine("JOIN #" + channel);
            outputStream.Flush();
        }

        private void SendIrcMessage(string message)
        {
            outputStream.WriteLine(message);
            outputStream.Flush();
        }

        public void SendChatMessage(string message)
        {
            if (ip == null)
            {
                IO.LogDebug(message, IO.DebugFile.Output, false);
            }
            else
            {
                SendIrcMessage(":" + userName + "!" + userName + "@" + userName + ".tmi.twitch.tv PRIVMSG #" + _channel + " :" + message);
            }
        }

        public string ReadMessage()
        {
            string message = null;
            if (!inputStream.EndOfStream)
            {
                message = inputStream.ReadLine();
            }
            if (message == null)
            {
                return "";
            }
            if (message.StartsWith("PING"))
            {
                var ip = message.Substring(4);
                SendIrcMessage("PONG" + ip);
                IO.LogDebug(message, IO.DebugFile.Twitch, false);
                return message;
            }
            if (message?.Contains("PRIVMSG") == true)
            {
                string[] msg = message.Split(':');
                return msg[2];
            }
            return message;
        }

        public void Stop()
        {
            _stop = true;
        }
    }
}