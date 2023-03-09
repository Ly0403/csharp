using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RecapProject1.Model;

namespace RecapProject1
{
    public class ProductDal
    {
        public List<Product> GetAll()
        {
            using (ProductDbContext productDbContext = new ProductDbContext())
            {
                return productDbContext.Products.ToList();
            }
        }

        public List<Product> GetByCategoryId(int categoryId)
        {
            using (ProductDbContext productDbContext = new ProductDbContext())
            {
                return productDbContext.Products.Where(x=>x.CategoryId==categoryId).ToList();
            }
        }

        public List<Product> GetByProductName(string productName,int categoryId)
        {
            using (ProductDbContext productDbContext=new ProductDbContext())
            {
                return productDbContext.Products.Where(x=>x.ProductName.Contains(productName)&&x.CategoryId==categoryId).ToList(); 
            }
        }

        public List<Category> GetCategories()
        {
            using (ProductDbContext productDbContext = new ProductDbContext())
            {
                return productDbContext.Categories.ToList();
            }
        }
    }
}
