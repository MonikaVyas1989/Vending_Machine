using System;
using System.Collections.Generic;
using System.Text;

namespace Vending_Machine.Product
{
    public abstract class Product
    {

        public string Use => $"{Name} {Usage} {Type}";
        public abstract string Usage { get; }
        public abstract string Type { get; }
        public abstract string Name { get; }
        public abstract int Price { get; }
        public string Examin => $"Product Name:{Name}\nProduct Price:{Price}\nProduct type:{Type}";
    }
}
