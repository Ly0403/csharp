using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    internal interface ICustomerDal
    {
        void Add();
        void Update();
        void Delete();

    }

    class MSSqlServerDal : ICustomerDal
    {
        public void Add() { Console.WriteLine("MSSql Added"); }
        public void Update() { Console.WriteLine("MSSql Updated"); }
        public void Delete() { Console.WriteLine("MSSql Deleted"); }

    }

    class MySqlServerDal : ICustomerDal
    {
        public void Add() { Console.WriteLine("MySql Added"); }
        public void Update() { Console.WriteLine("MySql Updated"); }
        public void Delete() { Console.WriteLine("MySql Deleted"); }

    }

    class PostgreDal : ICustomerDal
    {
        public void Add() { Console.WriteLine("PostgreSQL Added"); }
        public void Update() { Console.WriteLine("PostgreSQL Updated"); }
        public void Delete() { Console.WriteLine("PostgreSQL Deleted"); }

    }

    class CustomerManager
    {
        public void Add(ICustomerDal customerDal)
        {
            customerDal.Add();
        }
    }
}
