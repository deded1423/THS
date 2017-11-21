using System;
using System.Collections.Generic;

namespace THS.HSApp.Dictionaries
{
    public static class CardDict
    {
        public static Dictionary<string, CardBase> Dict = new Dictionary<string, CardBase>();

        static CardDict()
        {
            MageDict.MageCORE(Dict);
            MageDict.MageEXPERT(Dict);
            MageDict.MageHOF(Dict);
            MageDict.MageNAXX(Dict);
            MageDict.MageGVG(Dict);
            MageDict.MageBRM(Dict);
            MageDict.MageTGT(Dict);
        }
        public static void UpdateGame(HSGame Game)
        {
            Util.Play.Game = Game;
            Util.Play.Core = Game.GameCore;
            Util.Target.Game = Game;
            Util.Target.Core = Game.GameCore;
        }
    }
}
