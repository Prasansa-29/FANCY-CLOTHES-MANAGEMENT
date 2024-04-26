﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fancy.Models.Items
{
    internal class Product
    {
     public int ProductId { get; set; }
        public string ProductName { get; set; } = "";
        public string ShortDescription { get; set; } = "";

        public decimal Price { get; set; }
        public int Quantity { get; set; }
        public string Size { get; set; } = "";

        public string Color { get; set; } = "";

        public int Sold { get; set; }
        public DateTime Uploaded_Date { get; set; }
        public bool IsAvailable { get; set; }

        public int BrandCategoryId { get; set; }

        public virtual BrandCategory BrandCategory { get; set; } 
    }
}
