using FluentValidation;
using NLayered.Business.Abstract;
using NLayered.Business.Utilities;
using NLayered.Business.ValidationRules.FluenValidation;
using NLayered.DataAccess.Abstract;
using NLayered.DataAccess.Concrete;
using NLayered.DataAccess.Concrete.Entityframework;
using NLayered.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace NLayered.Business.Concrete
{
    public class ProductManager:IProductService
    {
        IProductDal _productDal;
        public ProductManager(IProductDal productDal)
        {
            _productDal = productDal;
        }

        public void AddNewProduct(Product product)
        {
            ValidatorTool<Product>.Validate(new ProductValidator(),  product);
            _productDal.Add(product);
        }

        public void DeleteProduct(Product product)
        {
            try
            {
                _productDal.Delete(product);
            }
            catch
            {
                throw new Exception("error while delete");
            }           
        }

        public List<Product> GetAll()
        {
            return _productDal.GetAll();
        }

        public List<Product> GetByCategoryId(int categoryId)
        {
            return _productDal.GetAll(x=>x.CategoryId==categoryId);
        }

        public List<Product> GetByProductName(string productName)
        {
            return _productDal.GetAll(x => x.ProductName.Contains(productName));
        }

        public void UpdateProduct(Product product)
        {
            ValidatorTool<Product>.Validate(new ProductValidator(), product);
            _productDal.Update(product);
        }
    }
}
