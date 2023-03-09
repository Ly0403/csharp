using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //InterfacesIntro();
            // You can not create new instance from interface
            // Interface and Abstract is intangible object
            // Class and methods tangible object
            // CallDals();

            ICustomerDal[] customerDals = new ICustomerDal[3]
            {
                new MSSqlServerDal(),new MySqlServerDal(), new PostgreDal()
            };
            foreach (var item in customerDals)
            {
                item.Add();
            }
            Console.ReadLine();
        }

        private static void CallDals()
        {
            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(new MSSqlServerDal());


            CustomerManager customerManager2 = new CustomerManager();
            customerManager2.Add(new MySqlServerDal());
        }

        private static void InterfacesIntro()
        {
            PersonManager personManager = new PersonManager();
            personManager.Add(new Student { Id = 1, FirstName = "Lati", LastName = "AYDIN", Department = "Samsun" });
        }

        interface IPerson
        {
            int Id { get; set; }
            string FirstName { get; set; }
            string LastName { get; set; }
        }

        class Customer : IPerson
        {
            public int Id { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }

            public string City { get; set; }
        }

        class Student : IPerson
        {
            public int Id { get; set; }
            public string FirstName { get; set; }

            public string LastName { get; set; }

            public string Department { get; set; }
        }

        class PersonManager
        {

            public void Add(IPerson customer)
            {
                Console.WriteLine(customer.FirstName);
            }

        }



    }
}
