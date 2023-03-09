using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFramework
{
    internal class ProductDal
    {
        //data can be filtered by linq from database or from collection
        // filtering from collection is more expensive than database
        // if the data is large filtering from db is prefered always
        // filtering from db with linq is not case sensetive
        // filtering from collection with linq is case sensetive
        // to remove case sensetivity from collection ToLower() can be used.
        public List<Product> GetAll()
        {
            using (ETradeContext eTradeContext=new ETradeContext())
            {
                return eTradeContext.Products.ToList();
            }
        }

        public List<Product> SearchProduct(string key)
        {
            using (ETradeContext eTradeContext=new ETradeContext())
            {
                return eTradeContext.Products.Where(x=>x.Name.Contains(key)).ToList();
            }
        }

        public Product GetByID(int Id)
        {
            using (ETradeContext eTradeContext=new ETradeContext())
            {
                return eTradeContext.Products.FirstOrDefault(x=>x.Id==Id);
            }
        }

        public List<Product> GetMaxMin(decimal minValue, decimal maxValue)
        {
            using (ETradeContext eTradeContext=new ETradeContext())
            {
                return eTradeContext.Products.Where(x => x.UnitPrice >= minValue && x.UnitPrice <= maxValue).ToList();
            }
        }

        public void Add(Product product)
        {
            using (ETradeContext eTradeContext=new ETradeContext())
            {
                var entity = eTradeContext.Entry(product);
                entity.State=EntityState.Added;
                eTradeContext.SaveChanges();
            }
        }

        public void Update(Product product)
        {
            using (ETradeContext eTradeContext=new ETradeContext())
            {
                var entity=eTradeContext.Entry(product);
                entity.State=EntityState.Modified;
                eTradeContext.SaveChanges();
            }
        }

        public void Delete(Product product)
        {
            using (ETradeContext eTradeContext=new ETradeContext())
            {
                var entity = eTradeContext.Entry(product);
                entity.State = EntityState.Deleted;
                eTradeContext.SaveChanges();
            }
        }
    }
}
