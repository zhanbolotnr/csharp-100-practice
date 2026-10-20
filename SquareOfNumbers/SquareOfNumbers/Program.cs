using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SquareOfNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int Square(int number)
            {
                return number * number;
            }

            int result = Square(8);
            Console.WriteLine(result);
        }
    }
}
