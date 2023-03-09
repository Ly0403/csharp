using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype_Design
{
    public class Program
    {
        static void Main(string[] args)
        {
            //prototypes can be used to descrease the cost of new() methods
            Customer customer1=new Customer()
            {
                PersonalId= 1,City="Ankara",Firstname="Yücel",Surname="Aydın"
            };
            //customer2 is created from customer1 but without a new() operation
            //customer2.firstname is a reference type but the result is changed
            // the reason is customer2 is created in another pğlace inside the memory
            // memory places of customer1 and customer2 is different
            Customer customer2=(Customer)customer1.Clone();
            customer2.Firstname = "Latifah";
            Console.WriteLine(customer1.Firstname);
            Console.WriteLine(customer2.Firstname);
            

            //Recap Value and Reference Types
            int valueType = 1;
            int valueType2 = 2;
            valueType2 = valueType;
            valueType = 3;
            Console.WriteLine(valueType2);
            string refType = "AAA";
            string refType2 = "BBB";
            refType2= refType;
            refType ="BBB";
            Console.WriteLine(refType);

            Console.ReadLine();
        }
    }

    public abstract class Person
    {
        public abstract Person Clone();
        public int PersonalId { get; set; }
        public string Firstname { get; set; }
        public string Surname { get; set; }
    }

    public class Customer : Person
    {
        public string City { get; set; }
        public override Person Clone()
        {
            return (Person)MemberwiseClone();
        }
    }
}
