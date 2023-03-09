using FluentValidation;
using LyForever.SampleDb.Business.Concrete.Managers;
using LyForever.SampleDb.DataAccess.Abstract;
using LyForever.SampleDb.Entities.Concrete;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System;

namespace LyForever.SampleDb.Business.Tests
{
    [TestClass]
    public class ProductManagerTest
    {
        [ExpectedException(typeof(ValidationException))]
        [TestMethod]
        public void product_manager_validation_test()
        {
            // why to use mock framwork
            // IPropductDal is data access layer
            // we are testing business layer
            // SOLID principal
            Mock<IProductDal> mock = new Mock<IProductDal>();
            ProductManager manager = new ProductManager(mock.Object);
            manager.Add(new Product() { ProductName="cA"});
        }
    }
}
