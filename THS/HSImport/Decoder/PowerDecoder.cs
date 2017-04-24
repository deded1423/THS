using THS.Utils;

namespace THS.HSImport
{
    class PowerDecoder
    {
        public void Decode(string line)
        {
            if (PowerTaskList.BlockStartRegex.IsMatch(line))
            {

            }
            else if (PowerTaskList.CardIdRegex.IsMatch(line))
            {

            }
            else if (PowerTaskList.CreationRegex.IsMatch(line))
            {

            }
            else if (PowerTaskList.CreationTagRegex.IsMatch(line))
            {

            }
            else if (PowerTaskList.EntityRegex.IsMatch(line))
            {

            }
            else if (PowerTaskList.GameEntityRegex.IsMatch(line))
            {

            }
            else if (PowerTaskList.PlayerEntityRegex.IsMatch(line))
            {

            }
            else if (PowerTaskList.TagChangeRegex.IsMatch(line))
            {

            }
            else if (PowerTaskList.UpdatingEntityRegex.IsMatch(line))
            {

            }
            else
            {

            }
        }
    }
}