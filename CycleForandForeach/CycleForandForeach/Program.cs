using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CycleForandForeach
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int secretNumber = 12;
            int guess;

            do
            {
                Console.WriteLine("Guess the number: "); // угадай пароля или угадай секретное число
                guess = int.Parse(Console.ReadLine());

                if (guess != secretNumber)
                {
                    Console.WriteLine("Wrong! Try again!!!");
                }
            }
            while (guess != secretNumber);
            Console.WriteLine("Correct"); 

        }
    }
}
/*  int number = 10;

            while (number >= 1)                       // Обратный отсчет
            {
                Console.WriteLine(number);
                number--;
            }
            Console.WriteLine("LiftOff!");*/

/*Console.WriteLine("Enter the number: ");
            int num = int.Parse(Console.ReadLine());

            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"{num} x {i} = {num * i}");
            }*/


/*Console.WriteLine("Enter the number: ");
            int number = int.Parse(Console.ReadLine());

            if (number < 0)
            {
                Console.WriteLine("Number must be positive");  //вычисление Factorial
            }
            else
            {
                long factorial = 1;

                for (int i = 1; i <= number; i++)
                {
                    factorial *= i;
                }
                Console.WriteLine($"{number}! = {factorial}");
            }*/


/* for (int i = 1; i <= 50; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
            }*/


/*for (int i = 1; i <= 100; i++)
            {
                Console.WriteLine(i);
            }*/
