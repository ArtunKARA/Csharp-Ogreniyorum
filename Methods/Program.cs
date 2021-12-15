using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            //Add();
            //Console.WriteLine(Add2(2, 3));
            int number1 = 10;
            int number2 = 20;
            var result = Add3(ref number1, number2);
            int number3;
            int result2 = Add4(out number3, number2);
           
            Console.WriteLine(number1);
            Console.WriteLine(number2);
            Console.WriteLine(result);
            Console.WriteLine(result2);
            Console.WriteLine(Add5(6,8,7,6,54,4,5,543));





            Console.ReadLine();
        }

        static void Add()
        {
            Console.WriteLine("add");
        }

        static int Add2(int number1, int number2 = 41)
        {
            return number1 + number2;
        }

        static int Add3(ref int number1, int number2)
        {
            number1 = 12;
            return number1 + number2;
        }

        static int Add4(out int number3, int number2)
        {
            number3 = 39;
            return number3 + number2;
        }

        static int Add5(params int[] numbers) 
        {
            return numbers.Sum();
        }




    }
}
