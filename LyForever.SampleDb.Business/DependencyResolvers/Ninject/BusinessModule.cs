using LyForever.Core.DataAccess;
using LyForever.Core.DataAccess.EntityFramework;
using LyForever.Core.DataAccess.NHibernate;
using LyForever.SampleDb.Business.Abstract;
using LyForever.SampleDb.Business.Concrete.Managers;
using LyForever.SampleDb.DataAccess.Abstract;
using LyForever.SampleDb.DataAccess.Concrete.EntityFramework;
using LyForever.SampleDb.DataAccess.Concrete.NHibernate;
using Ninject.Modules;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LyForever.SampleDb.Business.DependencyResolvers.Ninject
{
    public class BusinessModule : NinjectModule
    {
        public override void Load()
        {
            Bind<IProductService>().To<ProductManager>().InSingletonScope();
            Bind<IProductDal>().To<EfProductDal>();

            Bind(typeof(IQueryableRepository<>)).To(typeof(EfQueryableRepository<>));
            Bind<DbContext>().To<NorthWindContext>();
            Bind<NHibernateHelper>().To<MSSQLHelper>();

        }
    }
}
