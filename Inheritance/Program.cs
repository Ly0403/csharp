using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person[] persons = new Person[3]
            {
                new Person
                {
                    Id= 1,FirstName="Yücel",Surname="Aydın"
                },
                new Student
                {
                    Id= 2,FirstName="Lati", Surname="Aydın",Department="ddd"
                },
                new Customer
                {
                    Id=3, FirstName="Test",Surname="d",City="dd"
                }
            };

            foreach(var person in persons)
            {
                Console.WriteLine(person.FirstName);
            }
            Console.ReadLine();
        }
    }
    class Person
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string Surname { get; set; }

    }
    class Customer : Person
    {
        public string City { get; set; }
    }

    class Student : Person
    {
        public string Department { get; set; }
    }
}
