using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodBoolean
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool result = IsEven(24);
            Console.WriteLine(result);

        }


        static bool IsEven(int number)
        {
            return number % 2 == 0;
        }

    }
}
