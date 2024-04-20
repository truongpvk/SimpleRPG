using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicProject
{
    public class Potion : Item
    {
        public float HealHP { get; set; }
        public int ReduceMana { get; set; }

        public Potion() { }

        public Potion(int id, string name, float heal, int reduce) : base(id, name)
        {
            HealHP = heal; ReduceMana = reduce;
        }
    }
}
