using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fancy.Models.Items
{
    internal class ProductImages
    {
        public int ImageId { get; set; }
        public string ImageUrl { get; set; } = "";
        public bool DefaultImage {  get; set; }

    }
}
