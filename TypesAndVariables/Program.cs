using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace TypesAndVariables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Integer variable
            // 32 bit for integer 64 bit for long
            // 16 bit for short
            // 8 bit is byte
            char a = 'A';
            string city = "Ankara";
            byte number4 = 255;
            short number1= 32767;
            int number2 = 2147483647;
            long number3= 9223372036854775807;
            string akk = "sss";
            Console.WriteLine("The string is {0}", akk[0]);
            double aaa = 40.4;
            decimal bbb = 333.6m;
            var variable01 = 10.5;
            Console.ReadLine();
        }
    }
}
