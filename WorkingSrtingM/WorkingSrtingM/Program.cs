using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkingSrtingM
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter text: ");
            string text = Console.ReadLine().ToLower();

            int vowels = 0;
            int consonants = 0;

            foreach (char c in text)
            {
                if ("aeiou".Contains(c))
                {
                    vowels++;
                }
                else if (char.IsLetter(c))
                {
                    consonants++;
                }
                
            }
            Console.WriteLine($"Vowels: {vowels}");
            Console.WriteLine($"Consonants: {consonants}");
        }
    }
}
