using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.IO;
using System.Net.Sockets;
using System.Text.RegularExpressions;
using THS;
using THS.Utils;

//TODO: Hay que pasar todo lo de twitch a lower case para que el regex no se lie
namespace THS.Twitch_Integration
{
    class IrcClient
    {

        private string userName;
        private string _channel;
        private bool _stop = false;

        private TcpClient tcpClient;
        private StreamReader inputStream;
        private StreamWriter outputStream;

        private ConcurrentQueue<CommandChat> _queue = new ConcurrentQueue<CommandChat>();

        public IrcClient(string ip, int port, string userName, string password)
        {
            this.userName = userName;

            tcpClient = new TcpClient(ip, port);
            inputStream = new StreamReader(tcpClient.GetStream());
            outputStream = new StreamWriter(tcpClient.GetStream());

            outputStream.WriteLine("PASS " + password);
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
                    msg = msg.ToLower();
                    var cmd = new CommandChat(msg);
                    if (cmd.Type != PlayType.Incorrect)
                    {
                        _queue.Enqueue(cmd);
                        Utils.IO.LogDebug(cmd.ToString(), Utils.IO.DebugFile.Twitch, false);
                    }
                    else
                    {
                        Utils.IO.LogDebug(msg, Utils.IO.DebugFile.Twitch);
                    }
                }
            }
        }

        public void JoinRoom(string channel)
        {

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
            SendIrcMessage(":" + userName + "!" + userName + "@" + userName + ".tmi.twitch.tv PRIVMSG #" + _channel + " :" + message);
        }

        public string ReadMessage()
        {
            string message = inputStream.ReadLine();
            if (message?.Contains("PRIVMSG") == true)
            {
                string[] msg = message.Split(':');
                return msg[2];
            }
            return message;
        }

        public List<CommandChat> GetCommandChats()
        {
            List<CommandChat> list = new List<CommandChat>();
            foreach (var commandChat in _queue)
            {
                list.Add(commandChat);
            }
            return list;
        }
    }
}