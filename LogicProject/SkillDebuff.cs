using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace LogicProject
{
    public class SkillDebuff : Skill
    {
        public float DebuffHP { get; set; }
        public float DebuffMP { get; set; }
        public float DebuffDamage { get; set; }
        public float DebuffArmor { get; set; }

        public SkillDebuff() { }
        public SkillDebuff(int id, string name, float cost_mp, float cost_hp, int time, 
            float hp = 0, float mp = 0, float damage = 0, float armor = 0, int type = 5) : base(id, name, cost_mp, cost_hp, time, type)
        {
            DebuffHP = hp;
            DebuffMP = mp;
            DebuffDamage = damage;
            DebuffArmor = armor;
        }
    }
}
