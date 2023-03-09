using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositeDesign
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee employee1 = new Employee() { Name="Yücel"};
            Employee employee2 = new Employee() { Name = "Latifah" };
            Employee employee3 = new Employee() { Name = "Ahmet" };
            Employee employee4 = new Employee() { Name = "Mehmet" };
            Contractor contractor = new Contractor() { Name = "Huseyin" };
            employee1.Add(employee2);
            employee2.Add(employee3);
            employee1.Add(employee4);
            employee4.Add(contractor);
            Console.WriteLine(employee1.Name);
            foreach (var item in employee1)
            {
                Console.WriteLine("  {0}",item.Name);
                foreach (var item2 in (Employee)item)
                {
                    Console.WriteLine("     {0}", item2.Name);
                }
            }
            Console.ReadLine();
        }
    }

    interface IPerson
    {
        string Name { get; set; }
    }

    class Contractor : IPerson
    {
        public string Name { get; set; }
    }

    class Employee : IPerson,IEnumerable<IPerson>
    {
        private List<IPerson> _subordinates=new List<IPerson>();
        public void Add(IPerson person)
        {
            _subordinates.Add(person);
        }

        public void Delete(IPerson person)
        {
            _subordinates.Remove(person);
        }

        public IPerson GetPerson(int item)
        {
            return _subordinates[item];
        }
        public string Name { get; set; }

        public IEnumerator<IPerson> GetEnumerator()
        {
            foreach (var person in _subordinates)
            {
                yield return person;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }

}
