using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Utilities utilities=new Utilities();
            List<Product> numbers = utilities.ListNames<Product>(
                new Product { Name="Yücel"},
                new Product { Name="Latifah"}
                );

            foreach(var number in numbers)
            {
                Console.WriteLine(number.Name);  
            }
            Console.ReadLine();
        }
    }

    class Utilities
    {
        public List<T> ListNames<T>(params T[] items)
        {
            return new List<T>( items); 
        }
    }
    interface ICustomerDal:IRepository<Customer>
    {
        void CustomMethod(int Number);
    }
    class Customer:IEntity
    {

    }

    interface IProductDal:IRepository<Product>
    {

    }
    interface IEntity { }
    class Product:IEntity
    {
        public string Name { get; set; }
    }
    // where T: class-> reference type
    // where T: new() -> constructor type
    // where T: IEntity -> IEntity implemented
    // new() always to the end
    // where T: struct -> only value types such as int bool
    interface IRepository<T> where T: class,IEntity, new()
    {
        List<T> GetAll();
        T GetEntity(int id);
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);

    }

    class ProductDal : IProductDal
    {
        public void Add(Product entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Product entity)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetAll()
        {
            throw new NotImplementedException();
        }

        public Product GetEntity(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(Product entity)
        {
            throw new NotImplementedException();
        }
    }

    class CustomerDal : ICustomerDal
    {
        public void Add(Customer entity)
        {
            throw new NotImplementedException();
        }

        public void CustomMethod(int Number)
        {
            throw new NotImplementedException();
        }

        public void Delete(Customer entity)
        {
            throw new NotImplementedException();
        }

        public List<Customer> GetAll()
        {
            throw new NotImplementedException();
        }

        public Customer GetEntity(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(Customer entity)
        {
            throw new NotImplementedException();
        }
    }
}
