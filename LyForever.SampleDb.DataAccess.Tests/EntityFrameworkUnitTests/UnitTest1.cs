using LyForever.SampleDb.DataAccess.Concrete.EntityFramework;
using LyForever.SampleDb.DataAccess.Concrete.NHibernate;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace LyForever.SampleDb.DataAccess.Tests.EntityFrameworkUnitTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            NhCustomerDal nhCustomerDal = new NhCustomerDal(new MSSQLHelper());
            var result = nhCustomerDal.GetAll();

            Assert.AreEqual(91,result.Count);
        }
    }
}
