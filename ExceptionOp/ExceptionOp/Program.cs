using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionOp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CheckSide(-5);
        }
        static void CheckSide(double side)
        {
            if (side <= 0)
            {
                throw new ArgumentException("Side must be greater than zero");
            }
            Console.WriteLine($"Side: {side}");
        }
    }
}
