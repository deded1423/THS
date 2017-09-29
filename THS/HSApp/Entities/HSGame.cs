using System;
using System.Collections.Generic;
using System.Threading;
using HearthDb;
using HearthDb.CardDefs;
using HearthDb.Enums;
using THS.HSImport;
using THS.Utils;
using Type = HearthDb.Enums.Type;

namespace THS.HSApp
{
    public class HSGame
    {
        LogHandler _logHandler;

        //// Cards
        public List<HSCard> EnchantmentHsCards = new List<HSCard>();

        //Other
        public HSPlayer User;
        public HSPlayer Opponent;

        //Game Entity
        public Dictionary<GameTag, int> Tags = new Dictionary<GameTag, int>();
        public int NumGe;
        public bool PlayersOrdered = false;

        public HSGame(Windows.THS ths)
        {
            _logHandler = new LogHandler(ths, this);
            User = new HSPlayer();
            Opponent = new HSPlayer();
        }

        public void Start() => (new Thread(_logHandler.StartLogReader) { IsBackground = true, Name = "Main Log Handler" }).Start();

        public void Stop() => _logHandler.Stop();

        //Non-Game methods
        public void ClearGame()
        {
            User.Clear();
            Opponent.Clear();
            Tags.Clear();
            NumGe = 0;
            User = new HSPlayer();
            Opponent = new HSPlayer();
            PlayersOrdered = false;

            Utils.IO.LogDebug("Game Cleared", Utils.IO.DebugFile.Hs);
        }

        //Create Things
        public void AddTag(string tag, string value)
        {
            GameTag gt = HsConstants.StringToTag(tag);
            int i = HsConstants.TagToInt(gt, value);
            if (Tags.ContainsKey(gt))
            {
                IO.LogDebug("Changed GE Tag: " + tag + " to " + i, IO.DebugFile.Hs, false);
                Tags[gt] = i;
            }
            else
            {
                IO.LogDebug("Added GE Tag: " + tag + " to " + i, IO.DebugFile.Hs, false);
                Tags.Add(gt, i);
            }
        }

        //Methods that do something to the game

        //Methods that take info from the game
        public bool IsMulliganDone() => ((Mulligan)Tags[GameTag.MULLIGAN_STATE]).Equals(Mulligan.DONE);

        public HSCard GetCard(int player, Zone zone, int id)
        {
            if (player == User.PlayerId)
            {
                if (User.Hero.Id == id)
                {
                    return User.Hero;
                }
                else if (User.HeroPower.Id == id)
                {
                    return User.HeroPower;
                }
                switch (zone)
                {
                    case Zone.INVALID:
                        break;
                    case Zone.PLAY:
                        return User.GetPlayId(id);
                    case Zone.DECK:
                        return User.GetDeckId(id);
                    case Zone.HAND:
                        return User.GetHandId(id);
                    case Zone.GRAVEYARD:
                        return User.GetGraveyardId(id);
                    case Zone.REMOVEDFROMGAME:
                        break;
                    case Zone.SETASIDE:
                        return User.GetSetasideId(id);
                    case Zone.SECRET:
                        break;
                    default:
                        throw new OverflowException();
                }
            }
            else if (player == Opponent.PlayerId)
            {
                if (Opponent.Hero.Id == id)
                {
                    return Opponent.Hero;
                }
                else if (Opponent.HeroPower.Id == id)
                {
                    return Opponent.HeroPower;
                }
                switch (zone)
                {
                    case Zone.INVALID:
                        break;
                    case Zone.PLAY:
                        return Opponent.GetPlayId(id);
                    case Zone.DECK:
                        return Opponent.GetDeckId(id);
                    case Zone.HAND:
                        return Opponent.GetHandId(id);
                    case Zone.GRAVEYARD:
                        return Opponent.GetGraveyardId(id);
                    case Zone.REMOVEDFROMGAME:
                        break;
                    case Zone.SETASIDE:
                        return Opponent.GetSetasideId(id);
                    case Zone.SECRET:
                        break;
                    default:
                        throw new OverflowException();
                }
            }
            return null;
        }
    }
}