using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] students = new string[3];
            students[0] = "Ali";
            students[1] = "Veli";
            students[2] = "Deli";
            
            string[] students2 = { "Muhamer", "Deren", "Hüsametin" };
            

            foreach (var student in students2)
            {
                Console.WriteLine(student);
            }

            string[,] regions = new string[6,3]
            {
                {"İstanbul","Kocaeli","Bursa" },
                {"Ankara","Eskişehir","Konya" },
                {"İzmir","Manisa","Muğla" },
                {"Antalya","Adana","Mersin" },
                {"Diyarbakır","Gaziantep","Iğdır" },
                {"Rize","Trabzon","Samsun" },
            };
            Console.WriteLine(students2[0]);
            







            Console.WriteLine();
            Console.ReadLine();
        }
    }
}
