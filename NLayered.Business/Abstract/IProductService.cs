using NLayered.DataAccess.Abstract;
using NLayered.DataAccess.Concrete.Entityframework;
using NLayered.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLayered.Business.Abstract
{
    public interface IProductService
    {
        void AddNewProduct(Product product);
        void DeleteProduct(Product product);
        List<Product> GetAll();
        List<Product> GetByCategoryId(int categoryId);
        List<Product> GetByProductName(string productName);
        void UpdateProduct(Product product);
    }
}
