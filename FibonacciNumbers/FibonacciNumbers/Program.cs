using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FibonacciNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many Fibonacci numbers? ");
            int num = int.Parse(Console.ReadLine());

            int a0 = 0;
            int a1 = 1;

            for (int i = 0; i < num; i++)
            {
                Console.WriteLine(a0);
                int next = a0 + a1;

                a0 = a1;
                a1 = next;
            }
        }
    }
}
