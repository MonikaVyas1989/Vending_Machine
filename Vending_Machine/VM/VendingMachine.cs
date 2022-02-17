using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using Vending_Machine.Product;
using System.Threading.Tasks;

namespace Vending_Machine.VM
{
    public class VendingMachine : IVending
    {
  
        private readonly int[] money = { 1,5,10,20,50,100,500,1000};
        
        public static int MoneyPool { get; set;}

        public int EndTransaction()
        {

            Console.WriteLine("Here is your money back....");
            int leftMoney = MoneyPool;
            for (int i = money.Length - 1; i >= 0; i--)
            {
                int amount = leftMoney / money[i];
               
                if (amount > 0)
                {

                    MoneyPool = amount;
                }
            }


           return MoneyPool;
        }
        public void Purchase()
        {
            Drink drink = new Drink();
            Snack snack = new Snack();
            Play play = new Play();
           
            
          
            if (MoneyPool >= drink.Price || MoneyPool >= snack.Price || MoneyPool >= play.Price)
            {

                Console.WriteLine("Which Product Do you want to buy:");
                Console.WriteLine("select 1 for Drink");
                Console.WriteLine("select 2 for Snack");
                Console.WriteLine("select 3 for Toy");
                Console.WriteLine("Please press 0 to stop buying then Press 4 to Quit..");
                
               
                bool keepalive = true;

            

                while (keepalive)
                {
                        try
                        {

                            int choice = int.Parse(Console.ReadLine());


                            switch (choice)
                            {
                                case 1:
                                    if (MoneyPool >= drink.Price)
                                    {
                                        MoneyPool -= drink.Price;
                                        //str.Add(drink.Use);
                                        Console.WriteLine(drink.Use);
                                        Console.WriteLine("Do you want other to buy Product:");
                                        continue;
                                    }
                                    else
                                    {
                                        Console.WriteLine("You do not have enough money please enter 1 to insert money in Machine");
                                        InsertMoney();
                                    }
                                    break;
                                case 2:
                                    if (MoneyPool >= snack.Price)
                                    {
                                        MoneyPool -= snack.Price;
                                        Console.WriteLine(snack.Use);
                                        Console.WriteLine("Do you want other to buy Product:");
                                        continue;
                                    }
                                    else
                                    {
                                        Console.WriteLine("You do not have enough money please enter 1 to insert money in Machine");
                                        InsertMoney();
                                    }
                                    break;
                                case 3:
                                    if (MoneyPool >= play.Price)
                                    {
                                        MoneyPool -= play.Price;
                                        Console.WriteLine(play.Use);
                                        Console.WriteLine("Do you want other to buy Product:");
                                        continue;
                                    }
                                    else
                                    {
                                        Console.WriteLine("You do not have enough money please enter 1 to insert money in Machine");
                                        InsertMoney();
                                    }
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
                        catch
                        {
                            Console.WriteLine("Please enter number from Menu");
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
            Drink drink = new Drink();
            Snack snack = new Snack();
            Play play = new Play();

            Product.Product[] productinfo = new Product.Product[] { drink, snack, play };
            foreach(Product.Product  info in productinfo)
            {
                Console.WriteLine ( info.Examin);
                Console.WriteLine("\n");
            }
            return "";
        }
            
        public int  InsertMoney()
        {
           
            Console.WriteLine("How much do you want to insert");
            Console.WriteLine("1kr, 5kr, 10kr, 20kr, 50kr, 100kr, 500kr and 1000k....");
            Console.WriteLine($"Current balance: {MoneyPool}");
            
                
                for (int coin = 0; coin < money.Length; coin++)
                 {

              


                    int moneytoAdd = int.Parse(Console.ReadLine());

                    if (money.Contains(moneytoAdd))
                    {
                        MoneyPool += moneytoAdd;
                    }

                    else
                    {
                        Console.WriteLine("Insert valid amount from menu...");
                    }

                    Console.WriteLine($"x - return to the main menu\n");
                

                }

               
            
            
            return MoneyPool;
            
        }
       
     
        
    }
}
