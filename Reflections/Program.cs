using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Reflections
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Computations computations = new Computations(2,5);
            //Console.WriteLine(computations.SumTwo(2,3));
            //Console.WriteLine(computations.SumTwo2());

            var type = typeof(Computations);

            //Computations computations=(Computations)Activator.CreateInstance(type,2,6);
            //Console.WriteLine(computations.SumTwo2());

            var instance = Activator.CreateInstance(type, 3, 4);
            //MethodInfo methodInfo=instance.GetType().GetMethod("Multiply2");
            //Console.WriteLine(methodInfo.Invoke(instance, null));

            var methods = instance.GetType().GetMethods();
            foreach (var method in methods) { 
                Console.WriteLine(method.Name); 
                var parameters=method.GetParameters();
                foreach (var param in parameters)
                {
                    Console.WriteLine(param.Name);
                }
                var attribues = method.GetCustomAttributes();
                foreach (var attribue in attribues) { Console.WriteLine(attribue); }
            }






            Console.ReadLine();
        }
    }
    class CustomAttribute : Attribute
    {

    }
    class Computations
    {
        int _number1;
        int _number2;
        public Computations(int number1, int number2)
        {
            _number1 = number1;
            _number2 = number2;
        }
        [CustomAttribute]
        public int SumTwo(int number1, int number2)
        {
            return number1 + number2;
        }
        public int Multiply(int number1, int number2)
        {
            return number1 * number2;
        }

        public int SumTwo2()
        {
            return _number1 + _number2;
        }
        public int Multiply2()
        {
            return _number1 * _number2;
        }
    }
}
