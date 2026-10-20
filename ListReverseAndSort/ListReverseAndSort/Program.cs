using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListReverseAndSort
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>()
            {
                3, 12, 7, 8, 1,9
            };

            numbers.Sort();
            numbers.Reverse();

            foreach (int number in numbers)
            {
                Console.WriteLine(number);
            }
        }
    }
}
