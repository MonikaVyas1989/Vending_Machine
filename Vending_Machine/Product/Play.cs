using System;
using System.Collections.Generic;
using System.Text;

namespace Vending_Machine.Product
{
    public class Play : Product
    {
        public override string Usage => "Play with";
        public override string Type => "Toy";
        public override string Name => "Ball";
        public override int Price => 20;
        //public const string use = "Play with Toy";

        //public string Name = "Ball";
        //public int price = 20;
        //public string type = "Toy";

        //public override int Price => this.price;
        //public override string Examin
        //{
        //    get { return $"Product Name:{Name}\nProduct Price:{price}\nProduct type:{type}"; }
        //}
        //public override string Use
        //{
        //    get { return $"{this.Name} {use}"; }

        //    //throw new NotImplementedException();
        //}

    }

    }
