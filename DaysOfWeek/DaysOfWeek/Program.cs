using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DaysOfWeek
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DayOfWeek day = DayOfWeek.Monday;

            switch (day)
            {
                case DayOfWeek.Monday:
                    Console.WriteLine("Beginning of the week");
                    break;

                case DayOfWeek.Friday:
                    Console.WriteLine("Almost the weekend");
                    break;

                case DayOfWeek.Saturday:
                case DayOfWeek.Sunday:
                    Console.WriteLine("Day off!");
                    break;

                default:
                    Console.WriteLine("An ordinary workday");
                    break;
            }
        }
        enum DayOfWeek
        {
            Monday,
            Tuedays,
            Wednesday,
            Thursday,
            Friday,
            Saturday,
            Sunday   
        }
    }
}
