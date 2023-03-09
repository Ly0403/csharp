using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strings
{
    internal class Program
    {
        static void Main(string[] args)
        {
           //NewMethod();
            string sentence = "This the string lesson";
            var result = sentence.Length;
            var result2 = sentence.Clone();
            var result3 = sentence.EndsWith("onuyhu");
            var result4 = sentence.StartsWith("This");
            var result5 = sentence.IndexOf(" ");
            var result6 = sentence.IndexOf("the");
            var result7 = sentence.LastIndexOf(" ");
            var result8 = sentence.Insert(5,"Hello, ");
            var result9 = sentence.Substring(2,3);
            var result10 = sentence.ToUpper();
            var result11 = sentence.Replace("the","the last");
            var result12 = sentence.Remove(2,3);

            Console.WriteLine(result12);
            Console.ReadLine();
        }

        private static void NewMethod()
        {
            string city = "Erzurum";
            foreach (var item in city)
            {
                Console.WriteLine(item);
            }
            string city2 = "Sivas";
            Console.WriteLine("The first city is {0}, The second city is {1}", city, city2);
        }
    }
}
