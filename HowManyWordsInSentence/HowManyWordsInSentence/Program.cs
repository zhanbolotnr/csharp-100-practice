using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HowManyWordsInSentence
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter sentence: ");
            string sentence = Console.ReadLine();

            string[] words = sentence.Split(' ');
            Console.WriteLine($"Words: {words.Length}");
        }
    }
}
