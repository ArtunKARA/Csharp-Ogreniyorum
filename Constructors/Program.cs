using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructors
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CustomerManager customerManager = new CustomerManager(10);
            customerManager.Add();
            customerManager.List();
            Product product = new Product { Id=3,Name="Laptop"};
            Product product2 = new Product(3,"Car");



            Console.ReadKey();
        }
        class CustomerManager 
        {
            private int _count;
            public CustomerManager(int count)
            {
                _count = count;
            }
            public CustomerManager()
            {

            }
            public void Add() 
            {
                Console.WriteLine("Cutomer Added");
            }
            public void List()
            {
                Console.WriteLine("Customer {0} List",_count);
            }
        }
        class Product 
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public Product()
            {

            }
            private string _name;
            private int _id;
            public Product(int id ,string name)
            {
                _id= id;
                _name= name;
            }


        }
        
    }
}
