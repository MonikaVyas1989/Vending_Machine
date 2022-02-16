using System;
using System.Collections.Generic;
using System.Text;

namespace Vending_Machine.Product
{
    public abstract class Productdetails
    {
       
        public abstract string Examin { get; }
        public abstract string Use { get; } 

        public abstract int Price { get; }
    }
}
