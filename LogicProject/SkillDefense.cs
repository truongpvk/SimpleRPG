using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicProject
{
    public class SkillDefense : Skill
    {
        public float DamageDecreased { get; set; }

        public SkillDefense() { }

        public SkillDefense(int id, string name, float damageDecreased,
            float cost_mp, float cost_hp, int time, int type = 2) : base(id, name, cost_mp, cost_hp, time, type)
        {
            DamageDecreased = damageDecreased;
        }
    }
}
