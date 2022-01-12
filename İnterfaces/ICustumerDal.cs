using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace İnterfaces
{
    internal interface ICustumerDal
    {
        void Add();
        void Remove();
        void Update();
    }
    class SqlServerCustumerDal : ICustumerDal
    {
        public void Add()
        {
            Console.WriteLine("SqlAdd");
        }
        public void Remove()
        {
            Console.WriteLine("SqlRemove");
        }
        public void Update()
        {
            Console.WriteLine("SqlUpdate");
        }
    }
    class OracleCustumerDal:ICustumerDal
    {
        public void Add()
        {
            Console.WriteLine("OracleAdd");
        }
        public void Remove()
        {
            Console.WriteLine("OracleRemove");
        }
        public void Update()
        {
            Console.WriteLine("OracleUpdate");
        }
    }
    class CustumerDal
    {
       public void Add(ICustumerDal custumerDal)
        {
            custumerDal.Add();
        }
        public void Remove(ICustumerDal custumerDal)
        {
            custumerDal.Remove();
        }
        public void Update(ICustumerDal custumerDal)
        {
            custumerDal.Update();
        }
    }
   
}
