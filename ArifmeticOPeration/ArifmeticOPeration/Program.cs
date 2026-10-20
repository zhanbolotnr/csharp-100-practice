using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArifmeticPrimeOrNotPrime
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number: ");
            int number = int.Parse(Console.ReadLine());

            bool isPrime = true;

            if (number <= 1)
            {
                isPrime = false;
            }
            else
            {
                for (int i = 2; i < number; i++)
                {
                    if (number % 2 == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
            }

            if(isPrime)
                Console.WriteLine($"{number} - Prime number");
            else
                Console.WriteLine($"{number} - Not a prime number");

        }
    }
}
