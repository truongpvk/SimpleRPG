using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicProject
{
    public class Skill
    {
        public int ID {  get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public float CostMP { get; set; }
        public float CostHP { get; set; }
        public int CooldownTime { get; set; }
        public int Type { get; set; }

        public Skill() { } 

        public Skill(int iD, string name, float costMP, float costHP, int time,int type)
        {
            ID = iD; Name = name;
            CostMP = costMP; CostHP = costHP;
            CooldownTime = time;
            Type = type;
        }
    }
}
