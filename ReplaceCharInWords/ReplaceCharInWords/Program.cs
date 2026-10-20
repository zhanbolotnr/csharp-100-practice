using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReplaceCharInWords
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter text: ");
            string text = Console.ReadLine();

            Console.WriteLine("Character to replace: ");
            char oldChar = Console.ReadKey().KeyChar;

            Console.WriteLine();

            Console.WriteLine("New character: ");
            char newChar = Console.ReadKey().KeyChar;

            Console.WriteLine();

            char[] chars = text.ToCharArray();
            for (int i = 0; i < chars.Length; i++)
            {
                if (chars[i] == oldChar)
                {
                    chars[i] = newChar;
                }
            }
            string result = new string(chars);
            Console.WriteLine(result);
        }
    }
}
