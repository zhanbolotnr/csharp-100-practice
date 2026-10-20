using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NullOrValue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = null;

            string result = name ?? "Zhanbolot";

            Console.WriteLine(result);
        }
    }
}
