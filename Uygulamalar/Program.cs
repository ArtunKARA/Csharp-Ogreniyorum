using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uygulamalar
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Dünya");
            Console.ReadLine();

            int sayi1 = 1453;
            Console.WriteLine("Hocam Fatih İstanbulu {0} yılında feth etti.", sayi1);
            Console.ReadLine();
            double sayi4 = 21.5;
            decimal sayi5 = 21.1234556m;
            char karakter = 'A';
            bool condition = true;
            int sayi1 = 234;
            long sayi2 = 2345;
            short sayi3 = 12;
            var sayi6 = 24;
            sayi6 = 'a';
            Console.WriteLine("İnt tipi ile sayı {0}", sayi1);
            Console.WriteLine("Long tipi ile sayı {0}", sayi2);
            Console.WriteLine("Long tipi ile sayı {0}", sayi3);
            Console.WriteLine("Karakter tutucu {0}", karakter);
            Console.WriteLine("Karakterin ASKİ koduna donünüşümüş hali {0}", (int)karakter);
            Console.WriteLine("Ondalıklı sayı {0}", sayi4);
            Console.WriteLine("Uzun ondalıklı sayı {0}", sayi5);
            Console.WriteLine("Var kontu dönüşüm {0}", sayi6);
            Console.WriteLine(day.Mondays);
            Console.ReadLine();




        }
        enum day
        {
            Mondays,Tuseday,Wednesday,Thursday,Sunday
        }
    }
}
