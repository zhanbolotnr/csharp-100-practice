using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsingStreamWr
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (StreamWriter writer = new StreamWriter("test.txt"))
            {
                writer.WriteLine("Hello");
                writer.WriteLine("C#");
            }

            Console.WriteLine("Ready.");
        }
    }
}
