using NLayered.DataAccess.Abstract;
using NLayered.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace NLayered.DataAccess.Concrete.NHibernate
{
    public class NhbProductDal : IProductDal
    {
        public void Add(Product entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Product entity)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetAll(Expression<Func<Product, bool>> filter = null)
        {
            return new List<Product>
            { 
                new Product
                {
                    ProductId=1,CategoryId=1,ProductName="Laptop",QuantityPerUnit="1 in a box",UnitPrice=22,UnitsInStock=22
                }
            
            };
        }

        public Product GetProduct(Expression<Func<Product, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public void Update(Product entity)
        {
            throw new NotImplementedException();
        }
    }
}
