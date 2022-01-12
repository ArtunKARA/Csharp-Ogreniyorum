using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person[] persons = new Person[]
            {
            new Person { Id= 1234,Name="Aref",Surname="Pıstıran"}
            ,new Stundent{Id=4321,Name="Azetin",Surname="Bastıran"}
            };
            
            foreach(var person in persons)
            {
                Console.WriteLine(person.Name);
                Console.WriteLine(person.Surname);
                Console.WriteLine(person.Id);
                Console.WriteLine("");
            }
            Console.ReadKey();

        }
        class Person
        {
            public string Name { get; set; }
            public string Surname { get; set; }
            public int Id { get; set; }

        }
        class Stundent : Person
        {
            public string School { get; set; }
        }

    }
}
