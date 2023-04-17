﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCart
{
    internal class Product
    {
        public string Name { get; }
        public int Price { get; }

        public Product(string name, int price) 
        { 
            Name= name;
            Price= price;
        }
    }
}
