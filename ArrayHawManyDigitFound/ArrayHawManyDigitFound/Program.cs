using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayHawManyDigitFound
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 1, 3, 3, 1, 5, 5 };

            Console.WriteLine("Enter the number: ");
            int search = int.Parse(Console.ReadLine());

            int count = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] == search)
                {
                    count++;
                }
            }
            Console.WriteLine($"Found {count} times");
        }
    }
}
