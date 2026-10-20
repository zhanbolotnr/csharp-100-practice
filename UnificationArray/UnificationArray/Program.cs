using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnificationArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers1 = { 1, 2, 3, 4, 5 };
            int[] numbers2 = { 6, 7, 8, 9, 10 };

            int[] result = new int[numbers1.Length + numbers2.Length];

            for (int i = 0; i < numbers1.Length; i++)
            {
                result[i] = numbers1[i];
            }

            for (int i = 0; i < numbers2.Length; i++)
            {
                result[numbers1.Length + i] = numbers2[i];
            }

            foreach (int number in result)
            {
                Console.Write(number + " ");
            }
        }
    }
}
