using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DistanceAandB
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Point p1 = new Point(3, 6);
            Point p2 = new Point(3, 4);

            Console.WriteLine(Distance(p1, p2));

        }
        static double Distance(Point a, Point b)
        {
            int dx = b.X - a.X;
            int dy = b.Y - a.Y;

            return Math.Sqrt(dx * dx + dy * dy);
        }
        struct Point
        {
            public int X;
            public int Y;

            public Point(int x, int y)
            {
                X = x;
                Y = y;
            }
        }
    }
}
