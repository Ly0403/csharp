using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CustomerManager customerManager=new CustomerManager();
            customerManager.Add();
            customerManager.Update();

            Customer customer=new Customer();
            customer.Id= 1;
            customer.City = "ankara";
            customer.FirstName = "ahmet";
            customer.LastName = "kaya";

            Console.WriteLine(customer.FirstName);

            Customer customer1 = new Customer{
                Id = 2,
                FirstName = "mehmet",
                LastName="kaya",
                City="istanbul"
            };

            Console.WriteLine(customer1.FirstName);
            Console.ReadLine();
        }
    }
}
