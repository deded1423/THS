using System;
using THS.Utils;

namespace THS.HSImport
{
    static class PowerDecoder
    {
        public static void Decode(LogLine line)
        {
            if (PowerTaskList.BlockStartRegex.IsMatch(line.Line))
            {
            }
            else if (PowerTaskList.CardIdRegex.IsMatch(line.Line))
            {

            }
            else if (PowerTaskList.CreationRegex.IsMatch(line.Line))
            {

            }
            else if (PowerTaskList.CreationTagRegex.IsMatch(line.Line))
            {

            }
            else if (PowerTaskList.EntityRegex.IsMatch(line.Line))
            {

            }
            else if (PowerTaskList.GameEntityRegex.IsMatch(line.Line))
            {

            }
            else if (PowerTaskList.PlayerEntityRegex.IsMatch(line.Line))
            {

            }
            else if (PowerTaskList.TagChangeRegex.IsMatch(line.Line))
            {

            }
            else if (PowerTaskList.UpdatingEntityRegex.IsMatch(line.Line))
            {

            }
            else if (PowerTaskList.CreateGameRegex.IsMatch(line.Line))
            {
                
            }
            else
            {
                //Console.WriteLine("NOT PROCESSED: "+ line);
            }
        }

    }
}