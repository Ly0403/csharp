using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //ForLoop();
            //WhileLoop();
            //DoWhile();
            //ForEachLoop();

            int[] numbers = { 11, 19,2,4,5,6 };
            foreach (var number in numbers)
            {
                if (checkTheNumber(number))
                {
                    Console.WriteLine("The {0} is not an asal number", number);
                }
                else
                {
                    Console.WriteLine("The {0} is an asal number", number);
                }
            }
            Console.ReadLine();
        }

        private static bool checkTheNumber(int number)
        {
            for (int i = 2; i < number; i++)
            {
                if (number % i == 0)
                {
                    return true;
                    
                }
            }
            return false;
        }

        private static void ForEachLoop()
        {
            string[] students = { "Ahmet", "Mehmet", "Mustafa" };
            foreach (var student in students)
            {
                //student="NewStudent" You can not change the values of loop inside foreach loop
                // innumberable means iterable arrays are innumberaber
                Console.WriteLine(student);
                Console.WriteLine("---");
            }
        }

        private static void DoWhile()
        {
            int number = 10;
            do
            {
                Console.WriteLine(number);
                number--;

            } while (number >= 22);
        }

        private static void WhileLoop()
        {
            int number = 100;
            while (number >= 0)
            {
                Console.WriteLine("The current number is {0}", number);
                number -= 2;
            }
        }

        private static void ForLoop()
        {
            for (int i = 100; i >= 1; i -= 2)
            {
                Console.WriteLine(i);
            }
        }
    }
}
