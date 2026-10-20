using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CubeOfNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Cube(4));
        }

        static int Cube(int numbers)
        {
            return numbers* numbers * numbers;
        }
    }
}
