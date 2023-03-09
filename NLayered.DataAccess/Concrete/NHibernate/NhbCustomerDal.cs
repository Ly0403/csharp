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
    public class NhbCustomerDal : ICustomerDal
    {
        public void Add(Customer entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Customer entity)
        {
            throw new NotImplementedException();
        }

        public List<Customer> GetAll(Expression<Func<Customer, bool>> filter = null)
        {
            return new List<Customer>
            {
                new Customer
                {
                    CustomerId="AppTec",CompanyName="appTec",ContactName="Apptec360",ContactTitle="Mr"
                }
            };
        }

        public Customer GetProduct(Expression<Func<Customer, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public void Update(Customer entity)
        {
            throw new NotImplementedException();
        }
    }
}
