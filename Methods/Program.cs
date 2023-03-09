using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Pascal case the name of Project starts with Capital Letter.
            //Add();
            //Add();
            //Add();
            //Console.WriteLine(Add2(2));

            // ref or out keyword sends the memory location
            // ref and out usage is the same but the variable for ref sould be initialized. For out no need to initialize.
            // the varialbe for out should be set in the new method.
            // params to send random number of same data type

            int number1 = 99;
            int number2 = 20;
            //Console.WriteLine(Add3(out number1, number2));
            //Console.WriteLine(number1);
            //Console.WriteLine(multiply(2, 3,6));
            Console.WriteLine(Add4(2, 3, 6,8,7,8));
            Console.ReadLine();
        }
        static void Add()
        {
            Console.WriteLine("Added22");
        }
        static int Add2(int number1 = 10, int number2 = 1)
        {
            return number1 + number2;
        }
        static int Add3(out int number1, int number2)
        {
            number1 = 40;
            return number1 + number2;
        }
        static int multiply(int number1, int number2)
        {
            return number1 * number2;
        }
        static int multiply(int number1, int number2, int number3)
        {
            return number1 * number2 * number3;
        }
        static int Add4(params int[] numbers)
        {
            return numbers.Sum();
        }
    }
}
