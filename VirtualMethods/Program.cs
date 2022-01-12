using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualMethods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SqlServer sqlServer = new SqlServer();
            sqlServer.Add();
            MySqlServer mySqlServer = new MySqlServer();
            mySqlServer.Add();
            Console.ReadKey();
        }
        class DataBase
        {
           public virtual void Add()
            {
                Console.WriteLine("Added by Default");
            }
            public virtual void Deleted()
            {
                Console.WriteLine("Deleted by Default");
            }
        }
        class SqlServer : DataBase
        {

        }
        class MySqlServer : DataBase
        {
            public override void Add()
            {
                base.Add();
                Console.WriteLine("-And use Mysql code-");
            }
            public override void Deleted()
            {
                base.Deleted();
                Console.WriteLine("-And use Mysql code-");
            }
        }
    }
}
