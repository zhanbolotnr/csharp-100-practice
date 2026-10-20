using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodOPtionalParam
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int result1 = Sum(1, 3, 5, 6);
            int result2 = Sum(10, 30, 70, 90);

            Console.WriteLine(result1);
            Console.WriteLine(result2);
        }

        static int Sum(params int[] numbers)
        {
            int sum = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                sum += numbers[i];
            }

            return sum;
        }
    }
}
