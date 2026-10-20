using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeleteDublicateInArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 1, 2, 2, 2, 5, 4, 5, 1, 3, 4, 3 };

            Array.Sort(numbers);

            for (int i = 0; i < numbers.Length; i++)
            {
                bool IsDuplicate = false;
                for (int j = 0; j < i; j++)
                {
                    if (numbers[i] == numbers[j])
                    {
                        IsDuplicate = true;
                        break;
                    }
                }

                if (!IsDuplicate)
                {
                    Console.Write(numbers[i] + " ");
                }
            }
        }
    }
}
