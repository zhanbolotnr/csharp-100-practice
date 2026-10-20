using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DayOfWeekEnumParse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter day: ");
            string input = Console.ReadLine();

            DaysOfWeek day =
                (DaysOfWeek)Enum.Parse(typeof(DaysOfWeek), input);

            Console.WriteLine(day);
        }

        enum DaysOfWeek
        {
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday,
            Sunday
        }
    }
}
