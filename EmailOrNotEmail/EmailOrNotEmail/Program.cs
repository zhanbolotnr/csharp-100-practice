using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmailOrNotEmail
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter email: ");
            string email = Console.ReadLine();

            if (email.Contains("@") && email.Contains("."))
            {
                Console.WriteLine("Email looks valid");
            }
            else
            {
                Console.WriteLine("Invalid email");
            }
        }
    }
}
