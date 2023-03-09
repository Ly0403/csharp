using Ninject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjectionDesign
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // the reason to use IoC containers is to optimaze the performnce
            // IoC consumes less resource than new() 
            IKernel kernel=new StandardKernel();
            kernel.Bind<ICustomerDal>().To<EfCustomerDal>();
            CustomerManager customerManager = new CustomerManager(kernel.Get<ICustomerDal>());
            customerManager.Save();
            Console.ReadLine();
        }
    }

    interface ICustomerDal
    {
        void SaveToDb();
    }

    class EfCustomerDal:ICustomerDal
    {
        public void SaveToDb()
        {
            Console.WriteLine("The data is saved to db with Entity framework");
        }
    }

    class NhbCustomerDal:ICustomerDal
    {
        public void SaveToDb()
        {
            Console.WriteLine("The data is saved to db with NHibernate framework");
        }
    }

    class CustomerManager
    {
        ICustomerDal _customerDal;
        public CustomerManager(ICustomerDal customerDal)
        {
                _customerDal= customerDal;
        }
        public void Save()
        {
            _customerDal.SaveToDb();
        }
    }

}
