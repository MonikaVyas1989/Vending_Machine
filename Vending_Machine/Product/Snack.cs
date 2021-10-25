using System;
using System.Collections.Generic;
using System.Text;

namespace Vending_Machine.Product
{
    public class Snack : Productdetails 
    {

        public const string use = "Eat the Snack";

        public string Name = "Chips";
        public int price = 25;
        public string type = "Snack";

        public override int Price => this.price;
        public override string Examin
        {
            get { return $"Product Name:{Name}\nProduct Price:{price}\nProduct type:{type}"; }
        }
        public override string Use
        {
            get { return $"{this.Name} {use}"; }

            //throw new NotImplementedException();
        }
    }
}
