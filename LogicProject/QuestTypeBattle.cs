using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicProject
{
    public class QuestTypeBattle : Quest
    {
        public Monster QuestMonster { get; set; }
        public int RequireQuantity { get; set; }
        public int Counter { get; set; }
        public QuestTypeBattle() { }
        public QuestTypeBattle(int iD, string name,
            Monster monster, int quantity, int rewardExperience, int type = 2) :
            base(iD, name, rewardExperience, type)
        {
            QuestMonster = monster;
            RequireQuantity = quantity;
            Counter = 0;
        }
    }
}
