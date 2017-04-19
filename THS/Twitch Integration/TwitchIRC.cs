using System.IO;
using System.Net.Sockets;
using THS;

//TODO: Hay que pasar todo lo de twitch a lower case para que el regex no se lie
namespace THS.Twitch_Integration
{
     class IrcClient
    {

        private string userName;
        private string _channel;
        public bool stop = false;

        private TcpClient tcpClient;
        private StreamReader inputStream;
        private StreamWriter outputStream;

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
                while (!stop)
                {
                    string msg = ReadMessage();
                    Utils.IO.LogDebug(msg, Utils.IO.DebugFile.Twitch);
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
            // DEBUG: :deded1423!deded1423@deded1423.tmi.twitch.tv PRIVMSG #deded1423 :Hola
            string message = inputStream.ReadLine();
            if (message?.Contains("PRIVMSG") == true)
            {
                string[] msg = message.Split(':');
                return msg[2];
            }
            return message;
        }
        //:deded1423!deded1423@deded1423.tmi.twitch.tv PRIVMSG #deded1423 :aaaa
    }
}