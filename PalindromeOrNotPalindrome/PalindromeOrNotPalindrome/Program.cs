using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PalindromeOrNotPalindrome
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter text: ");
            string text = Console.ReadLine();

            string reversed = "";
            for (int i = text.Length - 1; i >= 0; i--)
            {
                reversed = reversed + text[i];
            }
            if (text == reversed)
            {
                Console.WriteLine("Palindrome");
            }
            else
            {
                Console.WriteLine("Not Palindrome");
            }

        }
    }
}
