using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListOfStudentsOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> names = new List<string>();
            List<int> grades = new List<int>();

            names.Add("Zhanbolot");
            grades.Add(85);

            names.Add("Anna");
            grades.Add(90);

            names.Add("Talgat");
            grades.Add(80);

            for (int i = 0; i < names.Count; i++)
            {
                Console.WriteLine(
                    $"{names[i]}: {grades[i]}"
                );
            }

            int sum = 0;
            for (int i = 0; i < grades.Count; i++)
            {
                sum += grades[i];
            }
            double average = (double)sum / grades.Count;
            Console.WriteLine($"Average: {average}");
        }
    }
}
