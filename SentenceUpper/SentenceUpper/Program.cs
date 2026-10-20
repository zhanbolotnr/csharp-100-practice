using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SentenceUpper
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter sentence: ");
            string sentence = Console.ReadLine();

            string[] words = sentence.Split(' ');
            for (int i = 0; i < words.Length; i++)
            {
                if (words[i].Length > 0)
                {
                    words[i] =
                        char.ToUpper(words[i][0]) + 
                        words[i].Substring(1);
                }
            }
            string result = string.Join(" ", words);
            Console.WriteLine(result);
        }
    }
}
