using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //ExceptionIntro();
            try
            {
                Find();
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
            }

            HandleExceptionMethod(() =>
            {
                Find();
            });

            Console.ReadLine();
        }

        private static void HandleExceptionMethod(Action value)
        {
            try
            {
                value.Invoke();

            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
            }
        }

        private static void Find()
        {
            List<string> students = new List<string> { "Yücel", "Latifah", "Latiyuc" };

            if (students.Contains("Ahmet"))
            {
                Console.WriteLine("Record is in the list");
            }
            else
            {
                throw new RecordNotfoundException("Record is not in the list");
            }
        }

        private static void ExceptionIntro()
        {
            try
            {
                string[] students = new string[3] { "Yücel", "Latifah", "Latiyuc" };
                students[3] = "Ahmed";
            }
            catch (IndexOutOfRangeException exception)
            {
                Console.WriteLine(exception.Message);
            }
            catch (DivideByZeroException exception)
            {
                Console.WriteLine(exception.Message);
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
            }
        }
    }
}
