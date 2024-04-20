using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicProject
{
    public class PlayerQuest
    {
        public Quest Details { get; set; }
        public bool isComplete { get; set; }
        public PlayerQuest () { }
        public PlayerQuest (Quest quest, bool isComplete = false)
        {
            Details = quest;
            this.isComplete = isComplete;
        }
    }
}
