using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Constructors
{
    internal class Program
    {
        //private variable begins with _
        static void Main(string[] args)
        {
            Customer customer = new Customer(44);
            customer.List();

            EmployeeManager employeeManager = new EmployeeManager(new DatabaseLogger());
            employeeManager.Add();


            PersonManager personManager = new PersonManager("product");
            personManager.Add();
            Console.ReadLine();
        }

        class Customer
        {
            private int _count=77;
            public Customer(int count)
            {
                _count = count;
            }
            public Customer()
            {
                
            }

            public void List()
            {
                Console.WriteLine("Listed {0} times!!",_count);
            }
        }

        class EmployeeManager
        {
            private ILogger _logger;

            public EmployeeManager(ILogger logger)
            {
                _logger = logger;   
            }

            public void Add() {
                _logger.Log();
                Console.WriteLine("Added!"); 
            }
        }

        interface ILogger
        {
            void Log();
        }
        class DatabaseLogger : ILogger
        {
            public void Log()
            {
                Console.WriteLine("Logged to database");
            }
        }

        class FileLogger : ILogger
        {
            public void Log() { Console.WriteLine("Logged to file"); }
        }

        class Base
        {
            private string _entity;
            public Base(string entity)
            {
                _entity = entity;   
            }
            protected void Message()
            {
                Console.WriteLine("{0} Message",_entity);
            }
        }

        class PersonManager:Base
        {
            public PersonManager(string entity):base(entity)
            {

            }
            public void Add()
            {
                Console.WriteLine("Added");
                // you may call from inheritance only protected internal or public not private
                Message();
            }
        }

        // static class can not be created
        // all sub items of static class should be static
        // class can be not static but some of the sub items can be static
        // static variables and methods can be called directly.
        // Non static variables and methods must be callled after creating instance


    }
}
