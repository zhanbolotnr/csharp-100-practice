using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecursiveDegree
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int resutlt = Square(3, 3);
            Console.WriteLine(resutlt);
        }

        static int Square(int number, int degree)
        {
            if (degree == 0)
            {
                return 1;
            }

            return number * Square(number, degree - 1);
        }
    }
}
