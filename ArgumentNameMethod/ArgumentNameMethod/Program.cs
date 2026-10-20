using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArgumentNameMethod
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter name: ");
            string name = Console.ReadLine();

            Console.Write("Enter age: ");
            int age = int.Parse(Console.ReadLine());

            Console.Write("Enter position: ");
            string position = Console.ReadLine();

            PrintEmployee(
                name: name,
                age: age,
                position: position);
        }

        static void PrintEmployee(string name, int age, string position)
        {
            Console.WriteLine();
            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"Age: {age}");
            Console.WriteLine($"Job: {position}");

        }
    }
}
