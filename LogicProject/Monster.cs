using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicProject
{
    public class Monster : LivingCreature
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int DropExp { get; set; }
        public List<LootItem> LootTable { get; set; }
        public Monster() { }
        public Monster(int id, string name, 
            float current_hp, float max_hp, float damage, float armor, int drop_exp) : base(current_hp, max_hp, damage, armor)
        {
            ID = id; Name = name; DropExp = drop_exp;
            LootTable = new List<LootItem>();
        }
    }
}
