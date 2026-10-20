using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayCopy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers1 = { 10, 20, 30, 40, 50 };

            int[] numbers2 = new int[numbers1.Length];

            for (int i = 0; i < numbers1.Length; i++)
            {
                numbers2[i] = numbers1[i];
            }

            Console.WriteLine();                     //это чтобы вывести массив в консоль

            Console.WriteLine("First array: ");
            for (int i = 0; i < numbers1.Length; i++)
            {
                Console.Write(numbers1[i] + " ");
            }

            Console.WriteLine();

            Console.WriteLine("Second array: ");
            for (int i = 0; i < numbers2.Length; i++)
            {
                Console.Write(numbers2[i] + " ");
            }
        }
    }
}
