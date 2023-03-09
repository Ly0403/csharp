using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReferencesandValues
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int, bool, char etc is value type
            // class, interface, abstract, string, array etc is ereference type

            int number1 = 11;
            int number2 = 22;

            number2 = number1;

            number1 = 33;
            Console.WriteLine(number2);

            String[] text1 = new String[] { "AAA" };
            String[] text2 = new String[] { "BBB" };


            text2 = text1;
            text1[0] = "text3";
            Console.WriteLine(text2[0]);

            Console.ReadLine();
        }
    }
}
