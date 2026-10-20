using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecursiveFactorial
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Factorial(6));
        }

        static long Factorial(int n)
        {
            if (n <= 1)
            {
                return 1;
            }

            return n * Factorial(n - 1);
        }
    }
}
