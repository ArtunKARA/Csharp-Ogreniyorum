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
            Console.WriteLine("Şehrin ilk harfi:" + city[0]);
            foreach (var item in city)
            {
                Console.Write(item + " ");
            }
            string city2 = "Kastomonu";
            Console.WriteLine();

            string sentence = "Lagardaş biz angara bebesiyiz labiz";


            int uzunluk = sentence.Length;
            Console.WriteLine(uzunluk);

            var kopya = sentence.Clone();
            kopya = kopya + "haa";
            Console.WriteLine("kopya");

            bool result = sentence.EndsWith("ğ");
            bool result2 = sentence.StartsWith("L");
            Console.WriteLine(result + " " + result2);

            int result3 = sentence.IndexOf("angara");
            int result4 = sentence.IndexOf(" ");
            int result5 = sentence.LastIndexOf(" ");
            Console.WriteLine(result3 + result4 + result5);

            var result7 = sentence.Insert(0, "Adamın biri:");
            Console.WriteLine(result7);

            var result8 = sentence.Substring(5, 10);
            Console.WriteLine(result8);

            var result9 = sentence.ToLower();
            var result10 = sentence.ToUpper();
            var result11 = sentence.Replace(" ","-");
            Console.WriteLine(result9+" "+result10);
            Console.WriteLine(result11);






            Console.ReadLine();
        }
    }
}
