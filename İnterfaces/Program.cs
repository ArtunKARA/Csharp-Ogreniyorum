using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace İnterfaces
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CustumerDal custumerDal = new CustumerDal();
            custumerDal.Add(new SqlServerCustumerDal());
            custumerDal.Add(new OracleCustumerDal());
            

            ICustumerDal[] custumerDals = new ICustumerDal[2]
            {
                new OracleCustumerDal(), new SqlServerCustumerDal()
            };
            Console.WriteLine("");

            foreach (var custumerDal1 in custumerDals)
            {
                custumerDal1.Update();
            }

            Console.WriteLine("");
            Costumers costumers = new Costumers()
            {
                Id = 1,
                FirstName = "Adnan",
                LastName = "Şenses",
                Address = "İskenderun"

            };
            Student studuents = new Student()
            {
                Id = 1,
                FirstName = "Artun",
                LastName = "Kara",
                Department = "Information System Engineer"
            };
            PersonManager manager = new PersonManager();
            
            manager.Add(studuents);
            manager.Add(costumers);
            Console.ReadKey();
        }
        interface IPerson
        {
            int Id { get; set; }
            string FirstName { get; set; }
            string LastName { get; set; }

        }
        class Costumers:IPerson
        {
            public int Id { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public string Address { get; set; }
        }
        class Student:IPerson
        {
            public int Id { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public string Department { get; set; }
        }
        class worker : IPerson
        {
            public int Id { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public string Department { get; set; }  
        }
        class PersonManager
        {
            public void Add(IPerson person)
            {
                Console.WriteLine(person.FirstName);
                Console.WriteLine(person.LastName);
                Console.WriteLine(person.Id);
                
            }
        }

    }
}
