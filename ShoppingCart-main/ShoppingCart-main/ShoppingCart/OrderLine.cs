using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCart
{
    internal class OrderLine
    {
        public Product Product { get; }
        public int Count { get; set; }

        public OrderLine(Product product, int count)
        {
            Product = product;
            Count = count;  
        }
    }
}
