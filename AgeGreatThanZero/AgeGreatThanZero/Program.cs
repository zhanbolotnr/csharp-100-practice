using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgeGreatThanZero
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CheckAge(29);
        }

        static void CheckAge(int age)
        {
            if (age < 0)
            {
                throw new ArgumentException(nameof(age),
                    "Age cannot be negative"
                    );
            }

            Console.WriteLine($"Age: {age}");
        }

    }
}
