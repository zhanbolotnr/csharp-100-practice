using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashsSetOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HashSet<int> numbers = new HashSet<int>();
            numbers.Add(1);
            numbers.Add(2);
            numbers.Add(3);
            numbers.Add(2);
            numbers.Add(3);

            foreach (int number in numbers)
            {
                Console.WriteLine(number);
            }
        }
    }
}
