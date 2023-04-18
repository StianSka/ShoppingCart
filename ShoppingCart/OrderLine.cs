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
        public int Count { get; private set; }
        public int LinePrice => Product.Price * Count;
        public OrderLine(Product product, int count)
        {
            Product = product;
            Count = count;
        }

        public void ShowOrderLine()
        {
            Console.WriteLine($"  {Count} stk. {Product.Name} kr {Product.Price} = {LinePrice}");
        }
        public void UpdateLineCount(int count) { Count += count; }
    }
}
