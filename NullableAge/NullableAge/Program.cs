using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NullableAge
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int? number = 75;
            Console.WriteLine(number.HasValue);

            number = null;
            Console.WriteLine(number.HasValue);
        }
    }
}
