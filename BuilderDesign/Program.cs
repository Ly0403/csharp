using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderDesign
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ProductDirector productDirector = new ProductDirector();
            BuilderBase builderBase=new OldCustomerBuilder();
            productDirector.CreateProduct(builderBase);

            Console.WriteLine(builderBase.GetPRoduct().ProductName);
            Console.WriteLine(builderBase.GetPRoduct().ProductId);
            Console.ReadLine();

            
        }
    }

    class ProductModel
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
    }

    abstract class BuilderBase
    {
        public abstract ProductModel GetPRoduct();
    }

    class NewCustomerBuilder : BuilderBase
    {

        public override ProductModel GetPRoduct()
        {
            return new ProductModel()
            {
                ProductId = 1,
                ProductName = "New"
            };
        }
    }
    class OldCustomerBuilder : BuilderBase
    {
        public override ProductModel GetPRoduct()
        {
            return new ProductModel()
            {
                ProductId = 2,
                ProductName = "Old"
            };
        }
    }

    class ProductDirector
    {
        public void CreateProduct(BuilderBase builderBase)
        {
            builderBase.GetPRoduct();
        }
    }
}
