using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicProject
{
    public class LootItem
    {
        public Item Details { get; set; }
        public int minimumQuantity { get; set; }
        public int maximumQuantity { get; set; }
        public float DropRate { get; set; }

        public LootItem() { }
        public LootItem(Item details, int minimumQuantity, int maximumQuantity, float dropRate)
        {
            Details = details;
            this.minimumQuantity = minimumQuantity;
            this.maximumQuantity = maximumQuantity;
            DropRate = dropRate;
        }
    }
}
