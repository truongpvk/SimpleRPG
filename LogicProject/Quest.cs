using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicProject
{
    public class Quest
    {
        public int ID {  get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int RewardExperience { get; set; }
        public int Type { get; set; }

        public Quest() { }
        public Quest(int iD, string name, string description, int rewardExperience, int type)
        {
            ID = iD;
            Name = name;
            Description = description;
            RewardExperience = rewardExperience;
            Type = type;
        }
    }
}
