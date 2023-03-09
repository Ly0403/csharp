using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace Attributes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer { Id = 1, Name = "Yücel", Age = 22 };
            CustomerDal customerDal = new CustomerDal();
            customerDal.AddNew(customer);
            Console.ReadLine();
        }
    }
    // AttributeTargets.All meas the attribute can be used both classess, methods, or variables
    // Allowmutiple can be used to use same attribute more than one
    [AttributeUsage(AttributeTargets.Property)]
    class RequiredCustomerPropertyAttribute : Attribute
    {

    }

    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Property, AllowMultiple = true)]
    class CustomerClassAtribute : Attribute
    {
        string _name;
        public CustomerClassAtribute(string name)
        {
            _name = name;
        }
    }

    [CustomerClassAtribute("textcustomer")]
    [CustomerClassAtribute("custometr4")]
    class Customer
    {
        public int Id { get; set; }
        [RequiredCustomerPropertyAttribute]
        public string Name { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
    }

    class CustomerDal
    {
        [Obsolete("Please use other method")]
        public void Add(Customer customer)
        {
            Console.WriteLine("{0},{1},{2},{3} are added!", customer.Id, customer.Name, customer.LastName, customer.Age);
        }

        public void AddNew(Customer customer)
        {
            Console.WriteLine("{0}, {1},{2},{3} added", customer.Id, customer.Name, customer.LastName, customer.Age);
        }
    }
}
