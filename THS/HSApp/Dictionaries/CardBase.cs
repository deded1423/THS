using HearthDb;
using System;
using System.Collections.Generic;
using THS.HSApp.Dictionaries.Misc;

namespace THS.HSApp.Dictionaries
{
    public class CardBase
    {
        public Func<bool> DiscoverFunc;
        public string[] DiscoverArray;
        public Func<bool> ChooseFunc;
        public string[] ChooseArray;
        public Func<List<HSCard>> TargetFunc;
        public Func<bool> PlayFunc;

        public CardBase()
        {
            DiscoverFunc = Discover.NeverDiscover;
            DiscoverArray = null;
            ChooseFunc = Choose.NeverChoose;
            ChooseArray = null;
            TargetFunc = Target.NoTarget;
            PlayFunc = () => true;
        }
    }
}
