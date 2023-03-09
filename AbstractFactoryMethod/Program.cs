using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryMethod
{
    public class Program
    {
        static void Main(string[] args)
        {
            CustomerManager customerManager = new CustomerManager(new Factory2());
            customerManager.Get();

            Console.ReadLine();
        }
    }

    public abstract class Logger
    {
        public abstract void Log();
        public void Save()
        {
            Console.WriteLine("Savedd");
        }
    }

    public class NLogger : Logger
    {
        public override void Log()
        {
            Console.WriteLine("Logged by NLogger");
        }        
    }
    public class PLogger : Logger
    {
        public override void Log()
        {
            Console.WriteLine("Logged by PLogger");
        }
    }

    //Cacher
    public abstract class Cacher
    {
        public abstract void Cache();
    }

    public class MemCacheCcher : Cacher
    {
        public override void Cache()
        {
            Console.WriteLine("Cached by memcache");
        }
    }

    public class RedisCacher : Cacher
    {
        public override void Cache()
        {
            Console.WriteLine("cached by Redis");
        }
    }


    public abstract class Mainfactory
    {
        public abstract Logger Createlogger();
        public abstract Cacher CreateCacher();
    }

    public class Factory1 : Mainfactory
    {
        public override Cacher CreateCacher()
        {
            return new RedisCacher();
        }

        public override Logger Createlogger()
        {
            return new PLogger();
        }
    }

    public class Factory2 : Mainfactory
    {
        public override Cacher CreateCacher()
        {
            return new RedisCacher();
        }

        public override Logger Createlogger()
        {
            return new NLogger();
        }
    }
    public class Factory3 : Mainfactory
    {
        public override Cacher CreateCacher()
        {
            return new MemCacheCcher();
        }

        public override Logger Createlogger()
        {
            return new PLogger();
        }
    }

    public class CustomerManager
    {
        private Mainfactory _mainfactory;
        public CustomerManager(Mainfactory mainfactory)
        {
            _mainfactory = mainfactory; 
        }

        public void Get()
        {
            Console.WriteLine("all items are retrieved");
            _mainfactory.Createlogger().Log();
            _mainfactory.CreateCacher().Cache();
        }
    }

}
