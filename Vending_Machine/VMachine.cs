using System;
using Vending_Machine.VM;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;



namespace Vending_Machine
{
    public class VMachine
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" ***********My Vendign Machine***********");
            Console.WriteLine(" <<<<Enter 1 to enter money in the machine");
            Console.WriteLine(" <<<<Enter 2 to show Product");
            Console.WriteLine(" <<<<Enter 3 to Buy a Product");
            Console.WriteLine(" <<<<Enter 4 to Quit");



            VendingMachine vm = new VendingMachine();
            

            bool running = true;
            
            while (running)
            {
                try
                {
                    int p = int.Parse(Console.ReadLine());
                    switch (p)
                    {
                        case 1:
                            vm.InsertMoney();
                            break;
                        case 2:
                            Console.WriteLine(vm.ShowAll());
                            break;
                        case 3:
                            vm.Purchase();
                            break;
                        case 4:
                            running = false;
                            break;

                        default:
                            Console.WriteLine("Please Choose from a Menu");
                            break;
                    }
            }
            catch
            {
                Console.WriteLine("Please enter valid number value");
            }

        }





    }


        
    }
}
