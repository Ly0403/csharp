using LyForever.Core.DataAccess.NHibernate;
using LyForever.SampleDb.DataAccess.Abstract;
using LyForever.SampleDb.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LyForever.SampleDb.DataAccess.Concrete.NHibernate
{
    public class NhCustomerDal : NhbRepositoryBase<Customer>, ICustomerDal
    {
        public NhCustomerDal(NHibernateHelper nHibernateHelper) : base(nHibernateHelper)
        {
        }
    }
}
