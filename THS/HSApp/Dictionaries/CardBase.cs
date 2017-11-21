using HearthDb;
using System;
using THS.HSApp.Dictionaries.Util;

namespace THS.HSApp.Dictionaries
{
    public class CardBase
    {
        public bool HasDiscover;
        public bool HasChoose;
        public Func<bool> TargetFunc;
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
