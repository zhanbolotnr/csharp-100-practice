using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumOfAllDigits
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number: ");
            int number = int.Parse(Console.ReadLine());

            int sum = 0;

            while (number > 0)
            {
                int digit = number % 10;

                sum += digit;

                number /= 10;
            }
            Console.WriteLine($"Sum = {sum}");

        }
    }
}
