using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace THS.HSApp.Dictionaries.Misc
{
    class Choose
    {
        public static HSCore Core;
        public static HSGame Game;
        public delegate bool func(HSCard card);

        public static bool NeverChoose()
        {
            return false;
        }
        public static bool AlwaysChoose()
        {
            return true;
        }
    }
}
