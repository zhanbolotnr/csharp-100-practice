using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace MethodDivideAndRemainder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var result = Divide(19, 6);
            Console.WriteLine(result.quitonder);
            Console.WriteLine(result.remainder);
        }

        static (int quitonder, int remainder) Divide(int a, int b)
        {
            return (a / b, a % b);
        }
    }
}
