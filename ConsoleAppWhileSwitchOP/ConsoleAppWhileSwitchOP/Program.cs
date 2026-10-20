using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppWhileSwitchOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool running = true;

            while (running)
            {
                Console.WriteLine("1.Say Hello");
                Console.WriteLine("2. Add numbers");
                Console.WriteLine("3. Exit");

                Console.Write("Choose: ");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        Console.WriteLine("Hello");
                        break;
                    case "2":

                        Console.Write("Enter number a: ");
                        int a = int.Parse(Console.ReadLine());

                        Console.Write("Enter the number b: ");
                        int b = int.Parse(Console.ReadLine());

                        Console.WriteLine(a + b);
                        break;

                    case "0":
                        running = false;
                        break;

                    default:
                        Console.WriteLine("Unknown option!");
                        break;
                }
            }
        }
    }
}
