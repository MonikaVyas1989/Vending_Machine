﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Vending_Machine.Product
{
    public class Drink : Product
    {

        //public const string use = "Drink the drink";

        //public string Name = "Cola";
        //public int price = 15;
        //public string type = "drink";
        //public Drink()
        //{

        //}
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
        public override string Usage => "Drink the";
        public override string Type => "drink";
        public override string Name => "Cola";
        public override int Price => 15;
    }
}
