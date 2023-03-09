using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultitonDesign
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Product.GetProduct("product1").id);
            Console.WriteLine(Product.GetProduct("product2").id);
            Console.WriteLine(Product.GetProduct("product2").id);
            Console.WriteLine(Product.GetProduct("product1").id);

            Console.ReadLine();

        }
    }

    class Product
    {
        private static Dictionary<string, Product> _products = new Dictionary<string, Product>();
        private static object _lock = new object();
        public Guid id { get; set; }
        private Product() 
        {
            id = Guid.NewGuid();
        }

        public static Product GetProduct(string brand)
        {
            lock (_lock)
            {
                if (!_products.ContainsKey(brand))
                {
                    _products.Add(brand, new Product());
                }
            }
            return _products[brand];
        }


    }
}
