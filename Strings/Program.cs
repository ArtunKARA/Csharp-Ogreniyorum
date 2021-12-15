using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string city = "Ankara";
            Console.WriteLine("Şehrin ilk harfi:"+city[0]);
            foreach (var item in city)
            {
                Console.Write(item + " ");
            }
            string city2 = "Kastomonu";
            Console.WriteLine();
           
            string sentence = "Lagardaş biz angara bebesiyiz labiz";
            Console.WriteLine(sentence.Length);





           Console.ReadLine();
        }
    }
}
