using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using HearthDb;
using HearthDb.CardDefs;
using THS.Utils;
using HearthDb.Enums;

namespace THS.HSApp
{
    public class HSCard
    {
        public int id;
        public Card Card;
        public Dictionary<GameTag, int> Tags = new Dictionary<GameTag, int>();

        public HSCard(int i)
        {
            id = i;
        }
    }
}
