using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryCatchFinallyOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int a = 44;
                int b = 11;

                int result = a / b;
                Console.WriteLine(result);
            }
            catch
            {
                Console.WriteLine("Error");
            }
            finally
            {
                Console.WriteLine("Cleaning.....");
            }
        }
    }
}
