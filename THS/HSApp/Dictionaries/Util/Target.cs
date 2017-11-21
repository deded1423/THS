using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace THS.HSApp.Dictionaries.Util
{
    public static class Target
    {
        public static HSCore Core;
        public static HSGame Game;
        public static bool NoTarget()
        {
            return false;
        }
        public static bool AlwaysTarget()
        {
            return true;
        }
        public static bool MedivhsValet()
        {
            if (Game.GetUserSecret().Count != 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool OneFriendlyBoard()
        {
            if (Game.GetUserMinions().Count != 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
