using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClothingStore.Command
{
    class SellCommand
    {
        private string cmd_product;
        private int cmd_color;
        private int cmd_size;
        private int total_proice = 0;


        /*
        * print menu choose product
        */
        private void PrintMenuProduct()
        {
            Console.WriteLine("---Sell Board---");
            Console.WriteLine("Select product type:");
            Console.WriteLine("A: T-Shirt ");
            Console.WriteLine("B: Dress Shirt ");


        }

        /*
        * print menu choose color
        */
        private void PrintMenuColor()
        {
            Console.WriteLine("Select color :");
            Console.WriteLine("1: Red ");
            Console.WriteLine("2: Blue ");


        }

        /*
       * print menu choose size
       */
        private void PrintMenuSize()
        {
            Console.WriteLine("Select size :");
            Console.WriteLine("1: S ");
            Console.WriteLine("2: M ");


        }



        /*
        * excute command from user select product type
        */
        private int RunCommandSelectProductType()
        {
            cmd_product = Console.ReadLine().ToUpper();

            bool invalid = false;

            int type_product = 0;

            // perform each command based on user input
            switch (cmd_product)
            {

                case "A":
                    type_product = 1;
                    break;

                case "B":
                    type_product = 2;
                    break;

                default:
                    invalid = true;
                    Console.WriteLine("Command {0} is not recongnized. Please try again.", cmd_product);
                    break;
            }
            if (invalid)
            {
                RunCommandSelectProductType();
            }

            return type_product;
        }


        /*
        * excute command from user select color 
        */
        private int RunCommandSelectColorType()
        {
            int.TryParse(Console.ReadLine(), out cmd_color);

            bool invalid = false;
            int type_color = 0;
            // perform each command based on user input
            switch (cmd_color)
            {

                case 1:
                    type_color = 1;
                    break;

                case 2:
                    type_color = 2;
                    break;

                default:
                    invalid = true;
                    Console.WriteLine("Command {0} is not recongnized. Please try again.", cmd_color);
                    break;
            }
            if (invalid)
            {
                RunCommandSelectColorType();
            }

            return type_color;
        }

        /*
        * excute command from user select Size 
        */
        private int RunCommandSelectSizeType()
        {
            int.TryParse(Console.ReadLine(), out cmd_size);

            bool invalid = false;
            int type_size = 0;
            // perform each command based on user input
            switch (cmd_size)
            {

                case 1:
                    type_size = 1;
                    break;

                case 2:
                    type_size = 2;
                    break;

                default:
                    invalid = true;
                    Console.WriteLine("Command {0} is not recongnized. Please try again.", type_size);
                    break;
            }
            if (invalid)
            {
                RunCommandSelectSizeType();
            }

            return type_size;
        }


        /*
        * print type 
        */
        private string PrintType(int product)
        {
            string type = "";
            if (product == 1)
            {
                type = "T-Shirt";
            }
            else if (product == 2)
            {
                type = "Dress Shirt";
            }

            return type;

        }

        /*
        * print price 
        */
        private int PrintPrice(int product)
        {
            int t_price = 0;
            //chekc product price
            if (product == 1)
            {
                t_price = Common.price_sell_tshirt;
            }
            else if (product == 2)
            {
                t_price = Common.price_sell_dress_shirt;
            }

            return t_price;

        }

        /*
        * print color 
        */
        private string PrintColor(int color)
        {
            string t_color = "";
            // check color
            if (color == 1)
            {
                t_color = Common.color[0];
            }
            else if (color == 1)
            {
                t_color = Common.color[1];
            }

            return t_color;
        }

        /*
        * print size 
        */
        private string PrintSize(int size)
        {
            string t_size = "";
            // check size
            if (size == 1)
            {
                t_size = Common.size[0];
            }
            else if (size == 2)
            {
                t_size = Common.size[1];
            }

            return t_size;
        }


        private void PrintProduct(int product, int color, int size)
        {
            Console.Write("- Product: {0} - color: {1} - size: {2}", PrintType(product), PrintColor(color), PrintSize(size));
        }


        public void Run()
        {
            ConsoleKeyInfo cki;

            do
            {
                PrintMenuProduct();
                int product = RunCommandSelectProductType();
                PrintMenuColor();
                int color = RunCommandSelectColorType();
                PrintMenuSize();
                int size = RunCommandSelectSizeType();
                int price = PrintPrice(product);
                total_proice = total_proice + price;
                PrintProduct(product, color, size);
                Console.WriteLine("Total Price: {0)", total_proice);
                cki = Console.ReadKey(false);
            }
            while (cki.Key != ConsoleKey.Escape);

        }
    }
}
