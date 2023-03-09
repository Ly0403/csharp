using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Manager manager=new Manager();
            VicePresident vicePresident=new VicePresident();
            President president=new President();
            manager.SetSuccessor(vicePresident);
            vicePresident.SetSuccessor(president);
            Expense expense=new Expense() { ExpenseName="New Expense"};

            while (true)
            {
                Console.WriteLine("Please Enter Amount:");
                var inputExpenseAmount=Convert.ToDecimal(Console.ReadLine());
                expense.ExpenseAmount = inputExpenseAmount;
                manager.ExpenseHandler(expense);
            }

        }
    }

    class Expense
    {
        public string ExpenseName { get; set; }
        public decimal ExpenseAmount { get; set; }
    }

    abstract class ExpenseHandlerBase
    {
        protected ExpenseHandlerBase Successor;
        public void SetSuccessor(ExpenseHandlerBase successor)
        {
            Successor= successor;
        }
        public abstract void ExpenseHandler(Expense expense);
    }

    class Manager : ExpenseHandlerBase
    {
        public override void ExpenseHandler(Expense expense)
        {
            if (expense.ExpenseAmount<100)
            {
                Console.WriteLine("Expended by Manager");
            }
            else
            {
                Successor.ExpenseHandler(expense);
            }
        }
    }

    class VicePresident : ExpenseHandlerBase
    {
        public override void ExpenseHandler(Expense expense)
        {
            if (expense.ExpenseAmount >= 100 && expense.ExpenseAmount<1000)
            {
                Console.WriteLine("Expended by VicePresident");
            }
            else
            {
                Successor.ExpenseHandler(expense);
            }
        }
    }
    class President : ExpenseHandlerBase
    {
        public override void ExpenseHandler(Expense expense)
        {
            Console.WriteLine("Expended by President");
        }
    }

}
