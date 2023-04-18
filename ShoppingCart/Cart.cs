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
        private int _totalPrice;

        public Cart() 
        {
            OrderLines = new List<OrderLine>();
            _totalPrice = 0;
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
                line.ShowOrderLine();
                totalPrice += line.LinePrice;
            }
            Console.WriteLine($"Totalpris: {totalPrice}");
        }

        public void AddToCart(Product product, int count)
        {
            var orderLine = OrderLines.FirstOrDefault(line => line.Product == product);
            if (orderLine == null)
            {
                OrderLines.Add(new OrderLine(product, count));
            } else 
            {
                orderLine.UpdateLineCount(count);
            }
            Console.WriteLine($"Du kjøpte {count} stk. {product.Name}");
        }
    }
}
