using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicProject
{
    public class QuestTypeCollection : Quest
    {
        public List<QuestItem> RequireItems = new List<QuestItem>();

        public QuestTypeCollection() { }
        public QuestTypeCollection(int iD, string name, int rewardExperience ,int type = 3,
            QuestItem first = null, QuestItem second = null, QuestItem third = null) :
            base(iD, name, rewardExperience, type)
        {
            RequireItems.Add(first);
            RequireItems.Add(second);
            RequireItems.Add(third);
        }


    }
}
