using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicProject
{
    public class QuestItem
    {
        public Item Details { get; set; }
        public int Quantity { get; set; }
        public QuestItem() { }
        public QuestItem(Item item, int quantity = 1)
        {
            Details = item;
            Quantity = quantity;
        }
    }
}
