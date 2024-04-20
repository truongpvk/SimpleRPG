using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicProject
{
    public class Weapon : Item
    {
        public float MaximumDamage { get; set; }

        public Weapon() { }
        public Weapon(int id, string name, float maximumDamage) : base(id, name)
        {
            MaximumDamage = maximumDamage;
        }
    }
}
