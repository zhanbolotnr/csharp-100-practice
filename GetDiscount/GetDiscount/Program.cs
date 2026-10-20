using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetDiscount
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double price1 = GetDiscountPrice(1000);
            Console.WriteLine(price1);

            double price2 = GetDiscountPrice(900, 25);
            Console.WriteLine(price2);
        }

        static double GetDiscountPrice(double total, double discount = 10)
        {
            return total - total * discount / 100;
        }
    }
}
