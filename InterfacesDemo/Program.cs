using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
        }
        //SOLID principals: Interface Segregation
        IWorker [] worker = new IWorker[2]
        {
            new Manager(),new Robot()
        };
        
    }
    interface IWorker
    {
        void Work();
    }
    interface IEat
    {
        void Eat();
    }
    interface ISalary
    {
        void GetSalary();
    }

    class Manager : IWorker, IEat, ISalary
    {
        public void GetSalary() { }
        public void Eat() { }
        public void Work() { }
    }
    class Robot : IWorker
    {
        public void Work()
        {
            
        }
    }
}
