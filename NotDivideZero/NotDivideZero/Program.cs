using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotDivideZero
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int n = 25;
                int n2 = 0;

                int result = n / n2;

                Console.WriteLine(result);

            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Cannot divide by zero! ");
            }
        }
    }
}
