﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Inventory.Data
{
    public class Products
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int CategoryId { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
    }
}
