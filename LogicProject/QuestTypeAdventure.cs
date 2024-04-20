using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicProject
{
    public class QuestTypeAdventure : Quest
    {
        public Location QuestLocation { get; set; }

        public QuestTypeAdventure() { }
        public QuestTypeAdventure(int iD, string name, string description,
            Location location, int rewardExp, int type = 1) :
            base(iD, name, description, rewardExp, type)

        { QuestLocation = location; }
    }
}
