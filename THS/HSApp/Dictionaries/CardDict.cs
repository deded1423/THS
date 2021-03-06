﻿using System;
using System.Collections.Generic;
using THS.HSApp.Dictionaries.Classes;
using THS.Utils;

namespace THS.HSApp.Dictionaries
{
    public static class CardDict
    {
        public static Dictionary<string, CardBase> Dict = new Dictionary<string, CardBase>();

        static CardDict()
        {
            NeutralDict.Update(Dict);
            MageDict.Update(Dict);
            RogueDict.Update(Dict);
            DruidDict.Update(Dict);
            HunterDict.Update(Dict);
            PaladinDict.Update(Dict);
            PriestDict.Update(Dict);
            ShamanDict.Update(Dict);
            WarlockDict.Update(Dict);
            WarriorDict.Update(Dict);
        }
        public static void UpdateGame(HSGame Game)
        {
            Misc.Play.Game = Game;
            Misc.Play.Core = Game.GameCore;
            Misc.Target.Game = Game;
            Misc.Target.Core = Game.GameCore;
            Misc.Discover.Game = Game;
            Misc.Discover.Core = Game.GameCore;
            Misc.Choose.Game = Game;
            Misc.Choose.Core = Game.GameCore;
        }
        public static CardBase GetCard(string id)
        {
            if (Dict.ContainsKey(id))
            {
                return Dict[id];
            }
            else
            {
                IO.LogDebug("NO CARD IN DB"+ id);
                return new CardBase();
            }
        }

    }
}
