using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClothingStore.Command;

namespace ClothingStore
{
    class InventorySystem
    {
        private int parameters;

        /*
        * start the program
        */
        public void Run()
        {
            // print welcome msgs and request commands
            PrintWelcome();
            RequestCommand();
        }

        /*
        * print welcome messsage
        */
        private void PrintWelcome()
        {
            Console.WriteLine("Welcome to Clothing Management System");
            Console.WriteLine("Please select function:");
            Console.WriteLine("1: Buy");
            Console.WriteLine("2: Sell");
            Console.WriteLine("3: Quit");
        }

        /*
        * execute commands according with user 
        */
        private void RequestCommand()
        {
            int.TryParse( Console.ReadLine(), out parameters);

            bool quit = false;

            // perform each command based on user input
            switch (parameters)
            {
                
                case 1:
                    BuyCommand buy = new BuyCommand();
                    buy.Run();
                    break;
                
                case 2:
                    SellCommand sell = new SellCommand();
                    sell.Run();
                    break;                
                case 3:
                    Quit();
                    quit = true;
                    break;
               
                default:
                    Console.WriteLine("Command {0} is not recongnized. Please try again.", parameters);
                    break;
            }

            if (!quit)
            {
                RequestCommand();
            }
        }

        /*
        * check if a parameter is valid
        */
        private bool IsValidPameter(int paramNumber)
        {
            try
            {
                if (parameters == 1 || parameters ==2 || parameters==3)
                {
                    return true;
                }
                else
                {
                    Console.WriteLine("Invalid no of arguments");
                }
            }
            catch
            {
                Console.WriteLine("Invalid no of arguments.");
            }

            return false;
        }

        public void Quit()
        {
            Console.WriteLine("Thank you for using Clothing Management System");
        }
    }
}
