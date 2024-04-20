using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicProject
{
    public class QuestType
    {
        public int ID {  get; set; }
        public string Type { get; set; }
        public QuestType() { }
        public QuestType(int iD, string questType)
        {
            ID = iD;
            Type = questType;
        }
    }
}
