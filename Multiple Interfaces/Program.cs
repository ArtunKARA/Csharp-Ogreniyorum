using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multiple_Interfaces
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IWork[] workers = new IWork[3]
            {
                new Manager(),
                new Worker(),
                new Robot()

            };

            foreach (var item in workers)
            {
                item.Work();
            }

            Console.WriteLine("");

            IEat[] eat = { new Manager(),new Worker() };
            foreach (var item in eat)
            {
                item.Eat();
            }


            Console.ReadKey();
        }
        interface IWork
        {
            void Work();
        }
        interface IEat
        {
            void Eat();
        }
        interface IGetSalary
        {
            void GetSalary();
        }
        class Worker : IWork, IEat, IGetSalary
        {
            public void Eat()
            {
                Console.WriteLine("Eat food worker");
            }
            public void GetSalary()
            {
                Console.WriteLine("Pay Salary worker");
            }
            public void Work()
            {
                Console.WriteLine("Worker Working");
            }
        }
        class Manager : IWork, IEat, IGetSalary
        {
            public void Eat()
            {
                Console.WriteLine("Eat food maneger");
            }
            public void GetSalary()
            {
                Console.WriteLine("Pay Salary manager");
            }
            public void Work()
            {
                Console.WriteLine("Worker manager");
            }
        }
        class Robot : IWork
        {
            public void Work()
            {
                Console.WriteLine("Robot only Working");
            }
        }

    }
}
