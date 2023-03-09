using NLayered.DataAccess.Abstract;
using NLayered.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace NLayered.DataAccess.Concrete.Entityframework
{
    public class EfProductDal:EfEntityRepository<Product,ProjectDbContext>,IProductDal
    {       
    }
}
