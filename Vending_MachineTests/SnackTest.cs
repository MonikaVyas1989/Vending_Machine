using System;
using System.Collections.Generic;
using System.Text;
using Vending_Machine.Product;
using Xunit;

namespace Vending_MachineTests
{
    public class SnackTest
    {
        [Fact]
        public void ExaminTest()
        {
            string name = "Chips";
            int price = 25;
            string type = "Snack";

            Snack snack = new Snack();

            string result = snack.Examin;
            Assert.Equal($"Product Name:{name}\nProduct Price:{price}\nProduct type:{type}", result);

        }
        [Fact]
        public void UseTest()
        {

            Snack snack = new Snack();
            string message = $"{snack.Name} Eat the Snack";

            string result = snack.Use;
            Assert.Equal(message, result);
        }
        [Fact]
        public void PriceTest()
        {
            Snack snack = new Snack();
            int price = 25;
            int res = snack.Price;
            Assert.Equal(price, res);
        }
    }
}
