using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructionDirector
{
    public class Builder
    {
        private Dictionary<int, Block> schedule = new();
        public int WorkedDays { get; set; } = 0;
        private int dayTime = 2000;
        public Color BuildingColor { get; set; }
        public Builder()
        {

        }
        public void AddBlockToSchedule(Block block, int day)
        {
            schedule[day] = block;
        }
        public void WorkOneDay()
        {
            Thread.Sleep(dayTime / 2);
            WorkedDays++;
            if (schedule.TryGetValue(WorkedDays, out Block block))
            {
                block.PaintToColor(BuildingColor);
                block.Build(dayTime / 2);
            }
            else
            {
                Thread.Sleep(dayTime / 2);
            }
        }
        public void RemoveFromSheduleIfExist(Block block)
        {
            if (schedule.ContainsValue(block))
            {
                schedule.Remove(block.DayOfBuild);
            }
        }
    }
}
