using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace StructValue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Point p1 = new Point(15, 23);

            Point p2 = p1;

            p2.X = 100;

            Console.WriteLine(p1.X);
            Console.WriteLine(p2.X);
            
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
