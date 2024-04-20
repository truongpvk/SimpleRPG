using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicProject
{
    public class QuestTypeCollection : Quest
    {
        public List<Item> RequireItems { get; set; }

        public QuestTypeCollection() { }
        public QuestTypeCollection(int iD, string name, string description, int rewardExperience, int type = 3) : 
            base(iD, name, description, rewardExperience, type)
        {
            RequireItems = new List<Item>();
        }
    }
}
