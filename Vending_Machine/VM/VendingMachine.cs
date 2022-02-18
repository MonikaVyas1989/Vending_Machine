using System;
using System.Linq;
using Vending_Machine.Product;

namespace Vending_Machine.VM
{
    public class VendingMachine : IVending
    {
        private readonly int[] money = { 1, 5, 10, 20, 50, 100, 500, 1000 };

        public int MoneyPool { get; set; }

        public int EndTransaction()
        {
            Console.WriteLine("Here is your money back....");
            var coins = MoneyPool;
            MoneyPool = 0;
            return coins;
        }

        private bool PurchaseOrInsertMoney(Product.Product product)
        {
            if (Purchase(product))
            {
                Console.ReadKey();
                return true;
            }

            Console.WriteLine(
                "You do not have enough money please enter 1 to insert money in Machine");
            InsertMoney();
            return false;
        }

        public bool Purchase(Product.Product product)
        {
            if (MoneyPool < product.Price) return false;
            MoneyPool -= product.Price;
            Console.WriteLine(product.Use);
            return true;

        }

        public void Purchase()
        {
            var drink = new Drink();
            var snack = new Snack();
            var play = new Play();


            if (MoneyPool >= drink.Price || MoneyPool >= snack.Price || MoneyPool >= play.Price)
            {
                var keepalive = true;
                while (keepalive)
                {
                    int choice;
                    do
                    {
                        Console.Clear();
                        Console.WriteLine("Money pool: {0}", MoneyPool);
                        Console.WriteLine("Which Product Do you want to buy:");
                        Console.WriteLine("select 1 for Drink");
                        Console.WriteLine("select 2 for Snack");
                        Console.WriteLine("select 3 for Toy");
                        Console.WriteLine("Please press 0 to stop buying then Press 4 to Quit..");
                    } while (!int.TryParse(Console.ReadLine(), out choice));


                    switch (choice)
                    {
                        case 1:
                            PurchaseOrInsertMoney(new Drink());
                            break;
                        case 2:
                            PurchaseOrInsertMoney(new Snack());
                            break;
                        case 3:
                            PurchaseOrInsertMoney(new Play());
                            break;
                        case 0:
                            Console.WriteLine(EndTransaction());
                            keepalive = false;
                            break;
                        default:
                            Console.WriteLine("Please choose number from the menu...");
                            break;
                    }
                }
            }
            else
            {
                Console.WriteLine("You do not have money please enter 1 to insert money in Machine");
            }
        }

        public string ShowAll()
        {
            var drink = new Drink();
            var snack = new Snack();
            var play = new Play();

            Product.Product[] productinfo = { drink, snack, play };
            foreach (var info in productinfo)
            {
                Console.WriteLine(info.Examin);
                Console.WriteLine("\n");
            }

            return "";
        }

        public int InsertMoney()
        {
            int moneyToAdd;
            do
            {
                Console.Clear();
                Console.WriteLine("How much do you want to insert");
                Console.WriteLine("1kr, 5kr, 10kr, 20kr, 50kr, 100kr, 500kr and 1000k....");
                Console.WriteLine($"Current balance: {MoneyPool}");
            } while (!int.TryParse(Console.ReadLine(), out moneyToAdd));

            if (!money.Contains(moneyToAdd))
            {
                Console.WriteLine("Incorrect denomination");
                Console.ReadKey();
                return MoneyPool;
            }
            if (!InsertMoney(moneyToAdd))
                Console.WriteLine("Insert valid amount from menu...");

            Console.WriteLine("x - return to the main menu\n");
            Console.ReadKey();

            return MoneyPool;
        }

        public bool InsertMoney(int moneyToAdd)
        {
            if (!money.Contains(moneyToAdd)) return false;
            MoneyPool += moneyToAdd;
            return true;
        }

    }
}