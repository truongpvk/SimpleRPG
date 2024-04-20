using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicProject
{
    public class SkillBuff : Skill
    {
        public float BuffDamage { get; set; }
        public float BuffHP { get; set; }
        public float BuffMana { get; set; }
        public float BuffArmor { get; set; }

        public SkillBuff() { }
        public SkillBuff(int id, string name,
            float cost_mana, float cost_hp, int time, 
            float dame = 0, float hp = 0, float mana = 0, float armor = 0, int type = 3) : 
            base(id, name, cost_mana, cost_hp, time, type)
        {
            BuffDamage = dame; BuffHP = hp; BuffMana = mana; BuffArmor = armor;
        }

        public float DamageIncrese(float damage) { return damage + BuffDamage * damage;}
        public float HitPointIncrese(float hp) { return hp + BuffHP * hp;}

        public float ManaIncrese(float mana) { return mana + BuffMana * mana; }
        public float ArmorIncrese(float armor) { return  armor + BuffArmor * armor;}


    }
}
