using LyForever.SampleDb.DataAccess.Concrete.NHibernate;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace LyForever.SampleDb.DataAccess.Tests.NHibernateUnitTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            NHProductDal nHProductDal = new NHProductDal(new MSSQLHelper());
            var result=nHProductDal.GetAll();

            Assert.AreEqual(79,result.Count);

        }
    }
}
