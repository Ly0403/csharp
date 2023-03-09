using LyForever.Core.Aspects.Postsharp;
using LyForever.Core.CrossCuttingConcerns.Caching.MicrosoftCache;
using LyForever.Core.CrossCuttingConcerns.Validation.FluentValidation;
using LyForever.SampleDb.Business.Abstract;
using LyForever.SampleDb.Business.Validation.FluentValidation;
using LyForever.SampleDb.DataAccess.Abstract;
using LyForever.SampleDb.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace LyForever.SampleDb.Business.Concrete.Managers
{
    public class ProductManager : IProductService
    {
        private IProductDal _iProductDal;
        // why dependency injection?
        // since the framework can be entityframework or nhibernate
        // to reduce the dependency for the framework
        public ProductManager(IProductDal iProductDal)
        {
            _iProductDal = iProductDal;
        }

        //Aspect oriented programming
        //running code before or after the method
        //postsharp is one of the aspect framework
        // the advantages of postsharp is to be part of method after the build
        [FluentValidatorAspect(typeof(ProductValidation))]
        [CacheRemoveAspect(typeof(MicrosoftCacheManager))]
        public void Add(Product product)
        {
            ValidatorTool.FluentValidate(new ProductValidation(), product);
            _iProductDal.Add(product);
        }

        [CacheManagerAspect(typeof(MicrosoftCacheManager),60)]
        public List<Product> GetAll()
        {
            return _iProductDal.GetAll();
        }

        public Product GetById(int id)
        {
            return _iProductDal.Get(x=>x.ProductId==id);
        }

        [TransactionScopeAspect]
        public void Transaction(Product product1,Product product2)
        {
            _iProductDal.Add(product1);
            _iProductDal.Update(product2);
            //bad usage of transaction scope
            //using (TransactionScope scope=new TransactionScope())
            //{
            //    try
            //    {
            //        _iProductDal.Add(product1);
            //        _iProductDal.Add(product2);
            //        scope.Complete();
            //    }
            //    catch
            //    {
            //        scope.Dispose();
            //    }
            //}                
        }

        [FluentValidatorAspect (typeof(ProductValidation))]
        public void Update(Product product)
        {
            _iProductDal.Update(product);
        }
    }
}
