using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwitchPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the temperature: ");
            int temp = int.Parse(Console.ReadLine());

            switch (temp)   // temperature
            {
                case  int t when t <= 0:
                    Console.WriteLine("Very cold");
                    break;

                case int t when t <= 10:
                    Console.WriteLine("Cold");
                    break;
                case int t when t <= 20:
                    Console.WriteLine("Chilly");
                    break;
                case int t when t <= 30:
                    Console.WriteLine("Warm");
                    break;
                default:
                    Console.WriteLine("HOT!!!");
                    break;

            }
        }
    }
}
