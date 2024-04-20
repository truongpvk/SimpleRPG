using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicProject
{
    public class SkillHealing : Skill
    {
        public float HealingHitPoints { get; set; }
        public float HealingScale { get; set; }
        public float ReduceManaPoints {  get; set; }
        public float ReduceManaScale { get; set;}

        public SkillHealing() { }

        public SkillHealing(int id, string name, float cost_mp, float cost_hp, int time, 
            float heal = 0, float heal_scale = 0, float reduce = 0, float reduce_scale = 0, int type = 4) : 
            base(id, name, cost_mp, cost_hp, time, type)
        {
            HealingHitPoints = heal; HealingScale = heal_scale;
            ReduceManaPoints = reduce; ReduceManaScale = reduce_scale;
        }


        public float Healing(float scale_value) { return HealingHitPoints +  (scale_value * HealingScale);}
        public float ReduceMana(float scale_value) { return ReduceManaPoints + (scale_value * ReduceManaScale); }
    }
}
