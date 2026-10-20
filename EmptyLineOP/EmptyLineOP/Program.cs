using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmptyLineOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> lines = new List<string>();

            while (true)
            {
                string input = Console.ReadLine();

                if (string.IsNullOrEmpty(input))
                {
                    break;
                }

                lines.Add(input);
            }

            foreach (string line in lines)
            {
                Console.WriteLine(line);
            }
        }
    }
}
