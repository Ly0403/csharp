using LyForever.Core.DataAccess.EntityFramework;
using LyForever.SampleDb.DataAccess.Abstract;
using LyForever.SampleDb.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LyForever.SampleDb.DataAccess.Concrete.EntityFramework
{
    public class EfCustomerDal:EfRepositoryBase<Customer,NorthWindContext>,ICustomerDal
    {
    }
}
