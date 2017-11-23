using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace THS.HSApp.Dictionaries.Misc
{
    class Discover
    {
        public static HSCore Core;
        public static HSGame Game;
        public delegate bool func(HSCard card);

        public static bool NeverDiscover()
        {
            return false;
        }
        public static bool AlwaysDiscover()
        {
            return true;
        }
    }
}
