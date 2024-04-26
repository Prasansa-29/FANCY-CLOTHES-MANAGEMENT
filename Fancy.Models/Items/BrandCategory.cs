using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fancy.Models.Items
{
    internal class BrandCategory
    {
        public int BrandCategoryId { get; set; }
        public string BrandName { get; set; } = "";
        public string BrandImageUrl { get; set; } = "";

        public List<Product> Products { get; set; }= new List<Product>();
    }
}
