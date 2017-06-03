using System;
using THS.Utils;

namespace THS.HSImport
{
    static class PowerDecoder
    {
        public static void Decode(LogLine line)
        {
            if (PowerTaskList.BlockStartRegex.IsMatch(line.Log))
            {
            }
            else if (PowerTaskList.CardIdRegex.IsMatch(line.Log))
            {

            }
            else if (PowerTaskList.FullEntityCreatingRegex.IsMatch(line.Log))
            {

            }
            else if (PowerTaskList.FullEntityUpdatingRegex.IsMatch(line.Log))
            {

            }
            else if (PowerTaskList.EntityRegex.IsMatch(line.Log))
            {

            }
            else if (PowerTaskList.GameEntityRegex.IsMatch(line.Log))
            {

            }
            else if (PowerTaskList.PlayerEntityRegex.IsMatch(line.Log))
            {

            }
            else if (PowerTaskList.TagChangeRegex.IsMatch(line.Log))
            {

            }
            else if (PowerTaskList.UpdatingEntityRegex.IsMatch(line.Log))
            {

            }
            else if (PowerTaskList.TagRegex.IsMatch(line.Log))
            {

            }
            else if (line.Log.Equals("CREATE_GAME"))
            {
                
            }
            else if (line.Log.Equals("BLOCK_END"))
            {

            }
            else if (PowerTaskList.CountRegex.IsMatch(line.Log))
            {

            }
            else if (PowerTaskList.BlockNullRegex.IsMatch(line.Log))
            {

            }
            else if (PowerTaskList.SourceRegex.IsMatch(line.Log))
            {

            }
            else if (PowerTaskList.CurrentTaskListRegex.IsMatch(line.Log))
            {

            }
            else if (PowerTaskList.MetaDataRegex.IsMatch(line.Log))
            {

            }
            else if (PowerTaskList.OptionRegex.IsMatch(line.Log))
            {

            }
            else if (PowerTaskList.SelectedOptionRegex.IsMatch(line.Log))
            {

            }
            else if (PowerTaskList.InfoRegex.IsMatch(line.Log))
            {

            }
            else if (PowerTaskList.TargetRegex.IsMatch(line.Log))
            {

            }
            else
            {
                Console.WriteLine("NOT PROCESSED: "+ line);
            }
        }

    }
}