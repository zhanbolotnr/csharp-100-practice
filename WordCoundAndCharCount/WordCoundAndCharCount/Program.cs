using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordCoundAndCharCount
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var result = AnalyzeText("Hello Zhanbolot Nurman");

            Console.WriteLine($"Words: {result.wordCount}");
            Console.WriteLine($"Characters: {result.charCount}");
        }

        static (int wordCount, int charCount) AnalyzeText(string text)
        {
            string[] words = text.Split(' ',
                (char)StringSplitOptions.RemoveEmptyEntries);

            int wordCount = words.Length;
            int charCount = text.Length;

            return (wordCount, charCount);
        }
    }
}
