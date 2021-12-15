using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CustomerManager customerManager = new CustomerManager();
            customerManager.add();
            customerManager.update();

            ProductManager productManager = new ProductManager();
            productManager.add();
            productManager.update();

            Customer customer = new Customer();
            customer.Id = 121232;
            customer.LastName = "Cebesoy";
            customer.FistName = "Ali";
            customer.City = "Adana";
            
            Customer customer2 = new Customer()
            {
                Id =437637, City ="Şırnak",LastName ="Uludereli",FistName ="Adnan"
            };
            




            Console.ReadKey();
        }
    }
    class CustomerManager
    {
        public void add()
        {
            Console.WriteLine("Customer Added");
        }
        public void update()
        {
            Console.WriteLine("Cusutumers Update");
        }
    }

    class ProductManager
    {
        public void add()
        {
            Console.WriteLine("Product Added");
        }
        public void update()
        {
            Console.WriteLine("Product Update");
        }
    }


}
