using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodNumberDouble
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = 12;
            DoubleNumber(ref x);
            Console.WriteLine(x);
        }

        static void DoubleNumber(ref int number)
        {
            number *= 2;
        }
    }
}
