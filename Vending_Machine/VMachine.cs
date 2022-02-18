using System;
using Vending_Machine.VM;

namespace Vending_Machine
{
    public class VMachine
    {
        private static void ShowMenu()
        {
            Console.WriteLine(" ***********My Vendign Machine***********");
            Console.WriteLine(" <<<<Enter 1 to enter money in the machine");
            Console.WriteLine(" <<<<Enter 2 to show Product");
            Console.WriteLine(" <<<<Enter 3 to Buy a Product");
            Console.WriteLine(" <<<<Enter 4 to Quit");
        }

        private static void Main(string[] args)
        {


            var vm = new VendingMachine();


            var running = true;

            while (running)
                try
                {
                    int p;
                    do
                    {
                        Console.Clear();
                        ShowMenu();
                    } while (!int.TryParse(Console.ReadLine(), out p));

                    switch (p)
                    {
                        case 1:
                            vm.InsertMoney();
                            break;
                        case 2:
                            Console.Clear();
                            Console.Clear();
                            Console.WriteLine(vm.ShowAll());
                            Console.ReadKey();
                            break;
                        case 3:
                            vm.Purchase();
                            Console.ReadKey();
                            break;
                        case 4:
                            running = false;
                            break;

                        default:
                            Console.Clear();
                            ShowMenu();
                            break;
                    }
                }
                catch (Exception error)
                {
                    Console.Clear();
                    Console.WriteLine(error.Message);
                    Console.ReadKey();
                    Console.Clear();
                    ShowMenu();
                }
        }
    }
}