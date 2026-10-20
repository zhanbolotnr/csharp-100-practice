using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionStList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> gadgets = new List<string>();

            gadgets.Add("Phone");
            gadgets.Add("Ipad");
            gadgets.Add("Notebook");

            gadgets.Remove("Notebook");

            if (gadgets.Contains("SmartClock"))
            {
                Console.WriteLine("SmartClock exists");
            }

            foreach (string items in gadgets)
            {
                Console.WriteLine(items);
            }
        }
    }
}
