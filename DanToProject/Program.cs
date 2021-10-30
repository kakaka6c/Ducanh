using System;
using System.Collections.Generic;
namespace DanToProject
{
    class Program
    {
        public static int total = 0;
        public static string value = "";
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            string choice = "y";

            while (choice == "y")
            {
                DoTask();
                Console.Write("Press any key to continue !!!...");
                string b = Console.ReadLine();
                Console.Clear();
                Console.Write("Do you want oder more ? (y/n): ");
                choice = Console.ReadLine().ToLower();
            }
            GB();


        }
        static void PrintStore()
        {
            System.Console.WriteLine("    Select Bread Store   ");
            System.Console.WriteLine("_________________________");
            System.Console.WriteLine("(1): Da Nang Bread Store ");
            System.Console.WriteLine("(2): Sai Gon Bread Store ");
            System.Console.WriteLine("(3): Hue Bread Store     ");
        }
        static void PrintMenu()
        {

            System.Console.WriteLine("     Welcome to Bread Store             ");
            System.Console.WriteLine("----------------------------------------");
            System.Console.WriteLine("                 -Menu-                 ");
            System.Console.WriteLine("1.Garlic            20,000vnđ            ");
            System.Console.WriteLine("2.Pate              15,000vnđ            ");
            System.Console.WriteLine("3.Mixed             30,000vnđ            ");
            System.Console.WriteLine("----------------------------------------");

        }

        static void DoTask()
        {
            PrintStore();
            Console.Write("Input your option : ");
            int option = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            switch (option)
            {
                case 1:
                    {
                        PrintMenu();
                        DNSelectBread();
                        break;
                    }
                case 2:
                    {
                        PrintMenu();
                        SGSelectBread();
                        break;
                    }
                case 3:
                    {
                        PrintMenu();
                        HueSelectBread();
                        break;
                    }
                case 0: Quit(); break;
                default: ShowError(); break;
            }

        }

        static void Quit()
        {
            Console.WriteLine("Exit Pragram");
        }

        static void GB()
        {
            Console.WriteLine("Goodbye! Have a good meal !");
        }

        static void ShowError()
        {
            Console.WriteLine("Invalid option ");
        }
        static bool Invalid_text(string txt)
        {
            foreach (var ch in txt)
            {
                if (Char.IsSymbol(ch) )
                {
                    return true;
                }
            }
            return false;
        }
        static string Return_val()
        {
            string choice, val;
            string[] values = new string[3] { "garlic", "pate", "mixed" };
            System.Console.Write("Enter your Bread: ");
            val = Console.ReadLine();
            while (Invalid_text(val) || Convert.ToInt32(val) > 3)
            {
                   System.Console.WriteLine("Please try again ... !!");
                   System.Console.Write("Enter your Bread: ");
                   val = Console.ReadLine();

            }
            choice = values[Convert.ToInt32(val) - 1];
            value = choice;
            return choice;
        }
        static void DNSelectBread()
        {
            string type = Return_val();
            var DN = new DNBreadStore();
            DN.OrderPizza(type);
            int cost = Bill(type);
            Console.WriteLine("Your bill: " + cost);
        }
        static void SGSelectBread()
        {
            string type = Return_val();
            var SG = new SGBreadStore();
            SG.OrderPizza(type);
            int cost = Bill(type);
            Console.WriteLine("Your bill: " + cost);
        }
        static void HueSelectBread()
        {
            string type = Return_val();
            var Hue = new HueBreadStore();
            Hue.OrderPizza(type);
            int cost = Bill(type);
            Console.WriteLine("Your bill: " + cost);
        }
        static int Bill(string type)
        {
            int cost = 0;
            if (value == "garlic" ) { cost = 20000; }
            else if (value == "pate" ) { cost = 15000; }
            else if (value == "mixed" ) { cost = 30000; }
            else { }
            total += cost;
            return total;
        }
    }
}
