using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadeDesign
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CustomerManager customerManager = new CustomerManager(new FacadeClass());
            customerManager.Save();

            Console.ReadLine();
        }
    }
    public class Logging
    {
        public void Log()
        {
            Console.WriteLine("Logged");
        }
    }

    public class Caching
    {
        public void Cache()
        {
            Console.WriteLine("Cached");
        }
    }

    public class FacadeClass
    {
        public Logging logging;
        public Caching caching;

        public FacadeClass()
        {
            logging = new Logging();
            caching = new Caching();
        }
    }

    public class CustomerManager
    {
        private FacadeClass _facadeClass;
        public CustomerManager(FacadeClass facadeClass)
        {
            _facadeClass=facadeClass;
        }

        public void Save()
        {
            _facadeClass.logging.Log();
            _facadeClass.caching.Cache();
            Console.WriteLine("Saved");
        }
    }

}
