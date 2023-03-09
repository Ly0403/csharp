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
            SqlServerDb db = new SqlServerDb();db.Add();
            MySqlDb mySqlDb= new MySqlDb();mySqlDb.Add();
            Console.ReadLine();
        }
    }
    class Database
    {
        public virtual void Add()
        {
            Console.WriteLine("Default Add");
        }
    }
    class SqlServerDb : Database
    {
        public override void Add()
        {
            Console.WriteLine("Sql Add");
            //base.Add();
        }

    }
    class MySqlDb : Database
    {

    }
}
