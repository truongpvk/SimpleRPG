using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicProject
{
    public class TreasureItem
    {
        public Item Items { get; set; }
        public int Quantity { get; set; }
        public TreasureItem() { }
        public TreasureItem(Item item, int quantity)
        {
            Items = item;
            Quantity = quantity;
        }
    }
}
