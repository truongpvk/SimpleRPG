using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicProject
{
    public class SkillAttack : Skill
    {
        public float BaseDamage { get; set; }
        public float ScaledDamage { get; set; }

        public SkillAttack() { }

        public SkillAttack(int id, string name, float baseDamage, float scaleDamage,
            float cost_mp, float cost_hp, int time, int type = 1) : base(id, name, cost_mp, cost_hp, time, type)
        {
            BaseDamage = baseDamage; ScaledDamage = scaleDamage;
        }
        public float OutputDamage(Player player) { return BaseDamage + (player.MaximumDamage * ScaledDamage); }
    }
}
