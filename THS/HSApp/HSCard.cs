using System.Security.Cryptography.X509Certificates;
using HearthDb;
using HearthDb.CardDefs;

namespace THS.HSApp
{
    public class HSCard : Card
    {
        public int id;
        public HSCard(Entity entity) : base(entity)
        {
            
        }
    }
}
