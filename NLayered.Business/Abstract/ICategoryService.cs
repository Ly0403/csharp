using NLayered.DataAccess.Abstract;
using NLayered.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLayered.Business.Abstract
{
    public interface ICategoryService
    {
        List<Category> GetAll();
    }
}
