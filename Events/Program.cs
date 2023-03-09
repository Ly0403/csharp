using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            
            Product harddisk = new Product(50);
            harddisk.ProductName = "Harddisk";
            Product cellphone = new Product(50);
            cellphone.ProductName = "Cell Phone";

            cellphone.StockControlEvent += Cellphone_StockControlEvent;
            for (int i = 0; i < 10; i++)
            {
                harddisk.Sell(10);
                cellphone.Sell(10);
                Console.ReadLine();
            }
            Console.ReadLine();
        }

        private static void Cellphone_StockControlEvent()
        {
            Console.WriteLine("Cell phone is finishing");
        }
    }

    public delegate void StockControl();

    public class Product
    {
        public event StockControl StockControlEvent;
        int _stock;
        public Product(int stock)
        {
            _stock = stock;
        }
        public int Stock { 
            get
            {
                return _stock;
            }
            set
            {
                _stock = value;
                if (Stock<15&&StockControlEvent!=null)
                {
                    StockControlEvent();
                }
            }
        }
        public string ProductName { get; set; }

        public void Sell(int amount)
        {
            Console.WriteLine("The stock of {0} is {1} ", ProductName, Stock);
            Stock -= amount;
            
        }
    }
}
