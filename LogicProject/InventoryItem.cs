﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicProject
{
    public class InventoryItem
    {
        public Item Details {  get; set; }
        public int Quantity { get; set; }
        public InventoryItem() { }
        public InventoryItem(Item details, int quantity)
        {
            Details = details;
            Quantity = quantity;
        }
    }
}
