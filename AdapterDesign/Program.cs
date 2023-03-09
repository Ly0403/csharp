using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterDesign
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CustomerManager customerManager = new CustomerManager(new FirstLogger(new SecondLogger()));
            customerManager.Save();

            Console.ReadLine();
        }
    }

    public class CustomerManager
    {
        private ILogger _logger;
        public CustomerManager(ILogger logger)
        {
            _logger = logger;
        }
        public void Save()
        {
            _logger.Log("user data");
            Console.WriteLine("Saved");
        }
    }

    public interface ILogger
    {
        void Log(string message);
    }

    public class FirstLogger : ILogger
    {
        private SecondLogger _secondLogger;
        public FirstLogger(SecondLogger secondLogger1)
        {
            _secondLogger = secondLogger1;
        }

        public void Log(string message)
        {
            _secondLogger.LogMessage(message);
            //Console.WriteLine("Logged by first Logger and message is {0}",message);
        }
    }

    public class SecondLogger 
    {
        public void LogMessage(string message)
        {
            Console.WriteLine("Logged by second Logger and message is {0}", message);
        }

    }
}
