using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayRepeat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 1, 2, 3, 4, 5 };

            for (int i = numbers.Length - 1; i >= 0; i--)
            {
                Console.Write(numbers[i]);
            }

        }
    }
}





//ArrayReverse
/*int[] numbers = {1, 2, 3, 4, 5};

            for (int i = numbers.Length - 1; i >= 0; i--)
            {
                Console.Write(numbers[i]);
            }*/


//FoundIndex
/*int[] numbers = { 4, 9, 12, 7, 23, 45 };

            Console.WriteLine("Enter number to search: ");
            int search = int.Parse(Console.ReadLine());

            int index = -1;

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] == search)
                {
                    index = i;
                    break;
                }
            }

            if (index != -1)
            {
                Console.WriteLine($"Found at index: {index}");
            }
            else
            {
                Console.WriteLine("Not found");
            }*/

//SumOfArrayDigits
/* int[] numbers = { 4, 9, 12, 7, 23, 45 };

            int sum = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                sum += numbers[i];
            }

            double average = (double)sum / numbers.Length;

            Console.WriteLine($"Sum: {sum}");
            Console.WriteLine($"Average: {average}");
           */

//Finding MaxAndMin
/* int[] numbers = { 4, 9, 12, 7, 23, 45};

       int max = numbers[0];
       int min = numbers[0];

       for (int i = 0; i < numbers.Length; i++)
       {
           if (numbers[i] > max)
           {
               max = numbers[i];
           }

           if (numbers[i] < min)
           {
               min = numbers[i];
           }
       }
       Console.WriteLine($"Maximum: {max}");
       Console.WriteLine($"Minimum: {min}");
       */

//объявление массива
/*int[] numbers = { 1, 2, 3, 4, 5 };

            for (int i = 0; i < numbers.Length; i++) 
            {
                Console.WriteLine(numbers[i]);
            }*/