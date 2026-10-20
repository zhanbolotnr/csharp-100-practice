using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindMaxInArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 1, 34, 5, 7, 12 };

            int max = FindMax(numbers);
            Console.WriteLine($"Maximum is: {max}");
        }

        static int FindMax(int[] numbers)
        {
            int max = numbers[0];

            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i] > max)
                {
                    max = numbers[i];
                }
            }

            return max;
        }
    }
}
