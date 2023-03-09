using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    internal class Program
    {
        // if the delgate has return type, the last result is returned
        public delegate void MyDelegate();
        // one of the restriction of delegates is the parameters of the methods should be same.
        public delegate void MyDelegate2(string message);
        // if the delgate has return type, the last result is returned
        public delegate int MyDelegate3(int num1, int num2);
        static void Main(string[] args)
        {
            //DelegateMethod();
            //ActionMethod();
            Func<int, int, int> sumTwoNumber = Sum;
            Console.WriteLine(sumTwoNumber(2,4));

            Func<int> getRandomNumber = delegate ()
                {
                    Random random=new Random();
                    return random.Next(1,22);
                }
                ;
            Console.WriteLine(getRandomNumber());
            Func<int> getRandom2 = () => { Random random = new Random(); return random.Next(1, 222); };
            Console.WriteLine(getRandom2());
            Console.ReadLine();
        }

        private static void ActionMethod()
        {
            RunMethodByAction(
                            () =>
                            {
                                Console.WriteLine("Test from action");
                            }

                            );
        }

        public static int Sum(int num1,int num2)
        {
            return num1 + num2;
        }

        public static void RunMethodByAction(Action action)
        {
            action.Invoke();
        }

        private static void DelegateMethod()
        {
            CustomerManager customerManager = new CustomerManager();
            //customerManager.Warn(); customerManager.SendMessage();

            MyDelegate myDelegate = customerManager.SendMessage;
            myDelegate += customerManager.Warn;
            myDelegate();

            MyDelegate2 myDelegate2 = customerManager.SendMessage2;
            myDelegate2 += customerManager.Warn2;
            // one of the restriction of delegates is the parameters of the methods should be same.
            myDelegate2("same message");

            // if the delgate has return type, the last result is returned
            MyDelegate3 myDelegate3 = customerManager.Sum;
            Console.WriteLine(myDelegate3(2, 3));
            myDelegate3 += customerManager.Multiply;

            Console.WriteLine(myDelegate3(2, 3));
        }
    }

    class CustomerManager
    {
        public void SendMessage() { Console.WriteLine("Hello"); }
        public void Warn() { Console.WriteLine("Careful"); }
        public void SendMessage2(string message) { Console.WriteLine(message); }
        public void Warn2(string message) { Console.WriteLine(message); }
        public int Sum(int num1, int num2) { return num1 + num2; }
        public int Multiply(int num1, int num2) { return num1 * num2; }
    }
}
