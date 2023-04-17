namespace ShoppingCart
{
    internal class SimpleShoppingCartDemo
    {
        public static void Run()
        {
            Product[] stock = new[] {
                new Product("A",40),
                new Product("B",70),
                new Product("C",30)
            };
            Cart cart = new Cart();

            cart.ShowCartContent();
            Console.WriteLine();

            cart.AddToCart(stock[0], 1);
            cart.ShowCartContent();
            Console.WriteLine();

            cart.AddToCart(stock[1], 3);
            cart.ShowCartContent();
            Console.WriteLine();

            cart.AddToCart(stock[0], 4);
            cart.ShowCartContent();
           
        }
    }
}
