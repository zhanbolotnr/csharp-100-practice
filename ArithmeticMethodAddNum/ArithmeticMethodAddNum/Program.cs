using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArithmeticMethodAddNum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int result = Addnumbers(10, 43);
            Console.WriteLine(result);
        }

        static int Addnumbers(int a, int b)
        {
            return a + b;
        }
    }
}
