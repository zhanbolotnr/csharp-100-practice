using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneBookOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> phonebook =
                new Dictionary<string, string>();

            phonebook.Add("Zhanbolot", "507-5050");
            phonebook.Add("Admin", "778-3737");

            Console.WriteLine(phonebook["Zhanbolot"]);
        }
    }
}
