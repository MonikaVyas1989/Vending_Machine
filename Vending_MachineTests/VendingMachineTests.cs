using Vending_Machine.Product;
using Vending_Machine.VM;
using Xunit;

namespace Vending_MachineTests
{
    public class VendingMachineTests
    {
        [Theory]
        [InlineData(1)]
        [InlineData(5)]
        [InlineData(10)]
        [InlineData(20)]
        [InlineData(50)]
        [InlineData(100)]
        [InlineData(500)]
        [InlineData(1000)]
        public void InserCorrectCoinToMoneyPoolTest(int coin)
        {
            var vendingMachine = new VendingMachine();
            var result = vendingMachine.InsertMoney(coin);


            Assert.True(result);
        }

        [Theory]
        [InlineData(-1)]
        [InlineData(12)]
        [InlineData(32)]
        public void InsertInCorrectCoinToMoneyPoolTest(int coin)
        {
            var vendingMachine = new VendingMachine();
            var result = vendingMachine.InsertMoney(coin);
            Assert.False(result);
        }

        [Fact]
        public void InsertCoinMoneyPoolChangesTest()
        {
            const int coin = 50;

            var vendingMachine = new VendingMachine();
            vendingMachine.InsertMoney(coin);

            var result = vendingMachine.MoneyPool;
            Assert.Equal(coin, result);
        }

        [Fact]
        public void BuyDrinkMoneyPoolDecreasesTest()
        {
            var price = 15;
            var moneyPool = 50;

            var vendingMachine = new VendingMachine();
            vendingMachine.InsertMoney(50);
            vendingMachine.Purchase(new Drink());
            var result = vendingMachine.MoneyPool;
            Assert.Equal(moneyPool - price, result);
        }

        [Fact]
        public void BuySnackMoneyPoolDecreasesTest()
        {
            const int price = 25;
            const int moneyPool = 50;

            var vendingMachine = new VendingMachine();
            vendingMachine.InsertMoney(moneyPool);
            vendingMachine.Purchase(new Snack());
            var result = vendingMachine.MoneyPool;
            Assert.Equal(moneyPool - price, result);
        }

        [Fact]
        public void BuyPlayMoneyPoolDecreasesTest()
        {
            var price = 15;
            var moneyPool = 50;

            var vendingMachine = new VendingMachine();
            vendingMachine.InsertMoney(50);
            vendingMachine.Purchase(new Drink());
            var result = vendingMachine.MoneyPool;
            Assert.Equal(moneyPool - price, result);
        }

        [Fact]
        public void BuyDrinkNotEnoughMoneyTest()
        {
            const int moneyPool = 1;

            var vendingMachine = new VendingMachine();
            vendingMachine.InsertMoney(moneyPool);
            var result = vendingMachine.Purchase(new Drink());

            Assert.False(result);
        }

        [Fact]
        public void EndTransactionReturnsValueOfManyPoolTest()
        {
            const int coins = 1;

            var vendingMachine = new VendingMachine();
            vendingMachine.InsertMoney(coins);

            var result = vendingMachine.EndTransaction();
            Assert.Equal(coins, result);
        }

        [Fact]
        public void ShowAllContainsProductsExamin()
        {
            var vendingMachine = new VendingMachine();
            var drink = new Drink();
            var snack = new Snack();
            var play = new Play();

            var showAll = vendingMachine.ShowAll();

            Assert.Contains(showAll, drink.Examin);
            Assert.Contains(showAll, snack.Examin);
            Assert.Contains(showAll, play.Examin);
        }
    }
}