using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    public class Program
    {
        static void Main(string[] args)
        {
            CustomerManager customerManager=new CustomerManager(new FactoryLogger2());
            customerManager.Save();
            Console.ReadLine();
        }
    }

    interface IFactoryLogger
    {
        ILogger CreateLogger();
    }

    class FactoryLogger : IFactoryLogger
    {
        public ILogger CreateLogger()
        {
            return new Logger1();
        }
    }

    class FactoryLogger2 : IFactoryLogger
    {
        public ILogger CreateLogger()
        {
            return new Logger2();
        }
    }

    interface ILogger
    {
        void Log();
    }

    class Logger1:ILogger
    {
        public void Log()
        {
            Console.WriteLine("Logged by Logger1!");
        }
    }

    class Logger2:ILogger
    {
        public void Log()
        {
            Console.WriteLine("Logged by Logger2!");
        }
    }

    class CustomerManager
    {
        private IFactoryLogger _logger;
        public CustomerManager(IFactoryLogger logger)
        {
            _logger=logger;
        }
        public void Save()
        {
            Console.WriteLine("Saved!");
            _logger.CreateLogger().Log();
        }
    }
}
