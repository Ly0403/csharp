using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Type safe collection means all the items in the list is the same type
            // Arraylist is not type safe
            //ArrayListMethod();
            // Collection methods: Add, AddRange, Clear, Count, Contains
            // Indexof, Lastindexof, insert, Remove
            // remove() method removes first occurence in the list

            //NewMethod();

            Dictionary<string,string> dictionary= new Dictionary<string,string>();
            dictionary.Add("book", "kitap");
            dictionary.Add("table","masa");

            foreach(var item in dictionary)
            {
                Console.WriteLine(item.Key);
            }
            Console.WriteLine(dictionary.Count);
            Console.WriteLine(dictionary.ContainsKey("table"));

            Console.ReadLine();
        }

        private static void NewMethod()
        {
            List<Customer> customers = new List<Customer>
            {
                new Customer{Id=1,Name="Yücel"},
                new Customer{Id=2,Name="Latifah"}
            };

            var customer2 = new Customer { Id = 3, Name = "customer2name" };
            customers.Add(customer2);

            customers.AddRange(new Customer[]
            {
                new Customer{Id=4,Name="name4"},
                new Customer{Id=5,Name="name5"}
            });

            //customers.Clear();
            customers.Add(customer2);

            Console.WriteLine(customers.Contains(customer2));
            Console.WriteLine("The index of {0}", customers.IndexOf(customer2));
            Console.WriteLine("The last index of {0}", customers.LastIndexOf(customer2));
            customers.Insert(0, customer2);
            customers.RemoveAll(c => c.Name == "customer2name");
            foreach (var customer in customers)
            {
                Console.WriteLine(customer.Name);
            }
            Console.WriteLine(customers.Count);
        }

        private static void ArrayListMethod()
        {
            ArrayList cities = new ArrayList();
            cities.Add("Samsun");
            cities.Add(2);
            cities.Add('A');
            foreach (var city in cities)
            {
                Console.WriteLine(city);
            }
            cities.Add(3);
            Console.WriteLine("---------");
            foreach (var city in cities)
            {
                Console.WriteLine(city);
            }
        }
    }
    class Customer
    {
        public string Name { get; set; }
        public int Id { get; set; }
    }
}
