using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicProject
{
    public class LivingCreature
    {
        public float CurrentHitPoint { get; set; }
        public float MaximumHitPoint { get; set; }
        public float MaximumDamage { get; set; }
        public float MaxArmor { get; set; }

        public LivingCreature() { }
        public LivingCreature(float currentHitPoint, float maximumHitPoint, float max_damage, float maxArmor)
        {
            CurrentHitPoint = currentHitPoint; MaximumHitPoint = maximumHitPoint;
            MaximumDamage = max_damage; MaxArmor = maxArmor;
        }
    }
}
