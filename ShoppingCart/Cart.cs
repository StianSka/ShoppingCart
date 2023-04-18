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
            foreach (var line in OrderLines)
            {
                line.ShowOrderLine();
            }
            Console.WriteLine($"Totalpris: {GetTotalPrice()}");
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
                orderLine.UpdateLinePrice();
            }
            Console.WriteLine($"Du kjøpte {count} stk. {product.Name}");
        }

        private int GetTotalPrice()
        {
            _totalPrice = 0;
            foreach (var line in OrderLines)
            {
                _totalPrice += line.LinePrice;
            }
            return _totalPrice;
        }
    }
}
