using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using Vending_Machine.Product;

namespace Vending_MachineTests
{
    public class DrinkTest
    {
        [Fact]
        public void ExaminTest()
        {
            int price= 15;
            string name = "Cola";
            string type = "drink";
            Drink drink = new Drink();

            string result = drink.Examin;
            Assert.Equal($"Product Name:{name}\nProduct Price:{price}\nProduct type:{type}", result);

        }
        [Fact]
        public void UseTest()
        {
            Drink drink = new Drink();
            string message = $"{drink.Name} Drink the drink";

            string result = drink.Use;
            Assert.Equal(message, result);
        }
        [Fact]
        public void PriceTest()
        {
            Drink drink = new Drink();
            int price = 15;
            int res = drink.Price;
            Assert.Equal(price, res);
        }
    }
}
