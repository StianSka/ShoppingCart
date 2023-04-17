using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCart
{
    internal class Cart
    {
        public List<OrderLine> OrderLines { get; }

        public Cart() 
        {
            OrderLines = new List<OrderLine>();
        }

        public void ShowCartContent()
        {
            if (OrderLines.Count == 0)
            {
                Console.WriteLine("Handlekurven er tom.");
                return;
            }
            var totalPrice = 0;
            foreach (var line in OrderLines)
            {
                totalPrice += line.Product.Price * line.Count;
                Console.WriteLine($"  {line.Count} stk. {line.Product.Name} kr {line.Product.Price} = {line.Product.Price * line.Count}");
            }
            Console.WriteLine($"Totalpris: {totalPrice}");
        }

        public void AddToCart(Product product, int count)
        {
            foreach (var line in OrderLines)
            {
                if (product == line.Product) { 
                    line.Count += count;
                    Console.WriteLine($"Du kjøpte {count} stk. {product.Name}");
                    return;
                }
            }
            OrderLines.Add( new OrderLine(product,count)); 
            Console.WriteLine($"Du kjøpte {count} stk. {product.Name}");
        }
    }
}
