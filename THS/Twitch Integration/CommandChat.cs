using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using THS.Utils;

namespace THS.Twitch_Integration
{
    class CommandChat
    {
        public PlayType Type;
        public string Name;
        public string Target;

        public CommandChat(PlayType type)
        {

            this.Type = type;
            this.Name = null;
            this.Target = null;
        }
        public CommandChat(PlayType type, string Name)
        {
            this.Type = type;
            this.Name = Name;
            this.Target = null;
        }

        public CommandChat(PlayType type, string Name, string Target)
        {
            this.Type = type;
            this.Name = Name;
            this.Target = Target;
        }
        public CommandChat(string line)
        {

        }
    }
}
