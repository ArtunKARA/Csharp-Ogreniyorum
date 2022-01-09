using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 2; i <= 100; i+=2)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("Finished! For");
            int number =0;
            while (number<100)
            {
                Console.WriteLine(number);
                number+=4;
            }
            Console.WriteLine("Finished! While");
            number = 0;
            do
            {
                number--;
                Console.WriteLine(number);
            } while (number>0);
            Console.WriteLine("Finished! Do While");
            string[] okcular = { "abraham", "gıral corc", "naycıl" };
            foreach (var item in okcular)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("adam okçular Finished! Foreach");





            Console.ReadKey();
        }
    }
}
