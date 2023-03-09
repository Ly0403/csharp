using NLayered.Business.Abstract;
using NLayered.DataAccess.Abstract;
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
    public class CustomerManager : ICustomerService
    {
        private ICustomerDal _customerDal;
        public CustomerManager(ICustomerDal customerDal)
        {
            _customerDal= customerDal;
        }
        public void Add(Customer entity)
        {
            _customerDal.Add(entity);
        }

        public void Delete(Customer entity)
        {
            _customerDal.Delete(entity);
        }

        public List<Customer> GetAll(Expression<Func<Customer, bool>> filter = null)
        {
            return _customerDal.GetAll(filter);
        }

        public Customer GetProduct(Expression<Func<Customer, bool>> filter)
        {
            return _customerDal.GetProduct(filter);
        }

        public void Update(Customer entity)
        {
            _customerDal.Update(entity);
        }
    }
}
