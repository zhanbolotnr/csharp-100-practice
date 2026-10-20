using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CordinatePoint
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Point p;

            p.x = 5;
            p.y = 20;

            Console.WriteLine($"Point: ({p.x}, {p.y})");

        }
        struct Point
        {
            public int x; 
            public int y;
        }
    }
}
