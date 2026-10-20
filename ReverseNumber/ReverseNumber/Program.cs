using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number: ");
            string number = Console.ReadLine();

            for(int i = number.Length - 1; i >= 0; i--)
            {
                Console.Write(number[i]);
            }

        }
    }
}
