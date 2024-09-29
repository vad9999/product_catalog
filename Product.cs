﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace product_catalog
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public double Price { get; set; }
        public Fabricator   Fabricator { get; set; } = null!;
        public int Quantity { get; set; }
        public string Specification { get; set; }
        public string Path { get; set; } = null!;
    }
}
