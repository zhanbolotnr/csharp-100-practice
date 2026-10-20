using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmptyBasketOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<(string name, decimal price)> cart =
                 new List<(string, decimal)>
                 {
                     ("Ipad", 500),
                     ("SmartClock", 150),
                     ("Imac", 800)
                 };
            decimal total = 0;

            foreach (var item in cart)
            {
                Console.WriteLine($"{item.name}: {item.price}");
                total += item.price;
            }

            Console.WriteLine($"Total: {total}");
        }
    }
}
