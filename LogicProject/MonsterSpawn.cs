using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicProject
{
    public class MonsterSpawn
    {
        public Monster Details { get; set; }
        public int currentQuantity
        {
            get { return Quantity; }
            set { currentQuantity = value; }
        }
        public int Quantity { get; set; }

        public MonsterSpawn() { }
        public MonsterSpawn(Monster details, int quantity = 1)
        {
            Details = details;
            Quantity = quantity;
        }
    }
}
