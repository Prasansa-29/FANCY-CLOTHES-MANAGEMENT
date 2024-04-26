using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace Fancy.Models.Items
{
    internal class Cart
    {
        public int CartId {  get; set; }    
        public int ProductId { get; set; }
        public string Id { get; set; }
        public DateTime DateTime { get; set; }= DateTime.Now;

        public virtual Product? Product { get; set; } 
     
        public List<Product> Products { get; set;} = new List<Product>();
        

    }
}
