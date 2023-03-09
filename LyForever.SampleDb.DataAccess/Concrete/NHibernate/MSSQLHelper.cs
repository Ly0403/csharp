using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using LyForever.Core.DataAccess.NHibernate;
using NHibernate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace LyForever.SampleDb.DataAccess.Concrete.NHibernate
{
    public class MSSQLHelper : NHibernateHelper
    {
        protected override ISessionFactory InitializeFactory()
        {
            return Fluently.Configure().Database(MsSqlConfiguration.MsSql2012.ConnectionString(c=>c.FromConnectionStringWithKey("NorthWindContext")))
                .Mappings(t=>t.FluentMappings.AddFromAssembly(Assembly.GetExecutingAssembly())).BuildSessionFactory();
        }
    }
}
