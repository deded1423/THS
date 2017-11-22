using HearthDb;
using System;
using System.Collections.Generic;
using THS.HSApp.Dictionaries.Misc;

namespace THS.HSApp.Dictionaries
{
    public class CardBase
    {
        public bool HasDiscover;
        public bool HasChoose;
        public Func<List<HSCard>> TargetFunc;
        public Func<bool> PlayFunc;

        public CardBase()
        {
            HasDiscover = false;
            HasChoose = false;
            TargetFunc = Target.NoTarget;
            PlayFunc = () => true;
        }
    }
}
