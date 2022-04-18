using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClasses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataBase oracle = new Oracle();
            oracle.Add();
            oracle.Delete();
            SplServer splServer = new SplServer();
            splServer.Add();
            splServer.Delete();
            Console.ReadKey();
        }
        abstract class DataBase
        {
            public void Add()
            {
                Console.WriteLine("Add by defult");
            }
            abstract public void Delete();
        }
        class SplServer : DataBase
        {
            public override void Delete()
            {
                Console.WriteLine("Deleted by Sqlserver");
            }
        }
        class Oracle : DataBase
        {
            public override void Delete()
            {
                Console.WriteLine("Deleted by Oracle");
            }
        }
    }
}
