using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>();

            numbers.Add(11); 
            numbers.Add(12);
            numbers.Add(13);
            numbers.Add(14);
            numbers.Add(15);

            foreach (int number in numbers)
            {
                Console.WriteLine(number);
            }

        }
    }
}
