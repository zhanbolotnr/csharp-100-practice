using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrequencyWordsDictionary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = "Hello world Hello Hello from Kyrgyzstan";

            string[] words = text.Split(' ');

            Dictionary<string, int> frequency =
                new Dictionary<string, int>();

            foreach (string word in words)
            {
                if (frequency.ContainsKey(word))
                {
                    frequency[word]++;
                }
                else
                {
                    frequency[word] = 1;
                }
            }
            foreach (var pair in frequency)
            {
                Console.WriteLine($"{pair.Key}: {pair.Value}");
            }
        }
    }
}
