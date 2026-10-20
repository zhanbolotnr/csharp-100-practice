using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculateArea
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double circle = CalculateArea(5);
            double rectangle = CalculateArea(15, 12);

            Console.WriteLine(circle);
            Console.WriteLine(rectangle);
        }

        static double CalculateArea(double radius)
        {
            return Math.PI * radius * radius;
        }

        static double CalculateArea(double width, double height)
        {
            return width * height;
        }
    }
}
