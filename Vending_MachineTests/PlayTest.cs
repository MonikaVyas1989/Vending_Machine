using System;
using System.Collections.Generic;
using System.Text;
using Vending_Machine.Product;
using Xunit;

namespace Vending_MachineTests
{
    public class PlayTest
    {
        [Fact]
        public void ExaminTest()
        {
            string name = "Ball";
            int price = 20;
            string type = "Toy";
            Play play = new Play();
            string result = play.Examin;
            Assert.Equal($"Product Name:{name}\nProduct Price:{price}\nProduct type:{type}", result);

        }
        [Fact]
        public void UseTest()
        {
            Play play = new Play();
            string message = $"{play.Name} Play with Toy";

            string result = play.Use;
            Assert.Equal(message, result);
        }
        [Fact]
        public void PriceTest()
        {
            Play play = new Play();
            int price = 20;
            int res = play.Price;
            Assert.Equal(price, res);
        }
    }
}
