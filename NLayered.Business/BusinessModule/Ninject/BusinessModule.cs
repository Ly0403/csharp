using Ninject.Modules;
using NLayered.Business.Abstract;
using NLayered.Business.Concrete;
using NLayered.DataAccess.Abstract;
using NLayered.DataAccess.Concrete.Entityframework;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLayered.Business.BusinessModule.Ninject
{
    public class BusinessModule:NinjectModule
    {
        public override void Load()
        {
            Bind<IProductService>().To<ProductManager>();
            Bind<IProductDal>().To<EfProductDal>();

            Bind<ICategoryService>().To<CategoryManager>();
            Bind<ICategoryDal>().To<EfCategoryDal>();   
        }
    }
}
