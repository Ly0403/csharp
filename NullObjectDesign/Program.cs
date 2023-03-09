using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NullObjectDesign
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CustomerManagerTest customerManagerTest= new CustomerManagerTest();
            customerManagerTest.Test();
            Console.ReadLine();
        }
    }

    interface ILogger
    {
        void Log();
    }
    class NLogger : ILogger
    {
        public void Log()
        {
            Console.WriteLine("Logged by NLogger");
        }
    }

    class Net4Logger : ILogger
    {
        public void Log()
        {
            Console.WriteLine("Logged by Net4Logger");
        }
    }

    class CustomerManager
    {
        private ILogger _iLogger;
        public CustomerManager(ILogger logger)
        {
                _iLogger= logger;
        }
        public void Save()
        {
            Console.WriteLine("Saved");
            _iLogger.Log();
        }
    }
    // why to use singleton design for testlogger?
    // the reason is not to create a new instance evert yime
    // use everytime same instance since the operationsa are always same.
    class TestLogger : ILogger
    {
        private static ILogger _logger;
        private static object _lock = new object();

        private TestLogger() { }

        public static ILogger GetLogger()
        {
            lock (_lock)
            {
                if (_logger==null)
                {
                    _logger = new TestLogger();
                }
                return _logger;
            }
        }


        public void Log()
        {
            
        }
    }
    class CustomerManagerTest
    {
        public void Test()
        {
            CustomerManager customerManager = new CustomerManager(TestLogger.GetLogger());
            customerManager.Save();
        }
        
    }
}
