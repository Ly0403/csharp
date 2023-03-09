using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Singleton
{
    public class Program
    {
        static void Main(string[] args)
        {
            var customerManager = CustomerManager.createSingleton();
            customerManager.Save();
        }

        
    }

    class CustomerManager
    {
        private static CustomerManager _customerManager;

        private static object _lockObject=new object();
        private CustomerManager() { }
        // when to use singleton
        // if the class is only perform operations and not store any data it is better use singleton
        // singleton classes can be created only once and store in memory
        // all other classes reach the singleton class
        // if the class is not used too much do not use singleton
        public static CustomerManager createSingleton()
        {
            // why using lock
            // in multithreading environment two threads can create singleton at the same time
            // lock is used to be sure only one class is created
            lock(_lockObject)
            {
                if (_customerManager==null)
                {
                    _customerManager = new CustomerManager();
                }
            }
            return _customerManager;
        }

        public void Save()
        {

        }
    }
}
