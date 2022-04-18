using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace AccessModifiers
{
    internal class Program
    {
        static void Main(string[] args)
        {
        }
        class Custemer 
        {
            protected int Id { get; set; }
            public void Save() 
            {

            }
            public void Delete() 
            {
            
            }
        }
        class Student:Custemer
        {
            
        }
        public class Course 
        {
         public string Name { get; set; }

        }
    }
}
