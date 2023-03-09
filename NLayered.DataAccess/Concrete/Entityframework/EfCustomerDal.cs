using NLayered.DataAccess.Abstract;
using NLayered.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLayered.DataAccess.Concrete.Entityframework
{
    // Interfaces are implementation and abstract class are inheritance
    public class EfCustomerDal:EfEntityRepository<Customer,ProjectDbContext>,ICustomerDal
    {
    }
}
