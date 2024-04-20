using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicProject
{
    public class Treasure
    {
        public int TreasureExperience { get; set; }
        public bool TreasureOpen { get; set; }
        public List<TreasureItem> TreasureReward {  get; set; }

        public Treasure() { }
        public Treasure(int treasureExperience, bool treasureOpen)
        {
            TreasureExperience = treasureExperience;
            TreasureOpen = treasureOpen;
            TreasureReward = new List<TreasureItem>();
        }
    }
}
