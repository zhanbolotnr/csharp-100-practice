using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringBuilderSBS
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StringBuilder st = new StringBuilder();

            for (int i = 0; i < 1000; i++)
            {
                st.Append("Hello ");
            }
            string result = st.ToString();
            Console.WriteLine(result);
        }
    }
}
