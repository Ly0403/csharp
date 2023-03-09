using NHibernate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel.Activation;
using System.Text;
using System.Threading.Tasks;

namespace LyForever.Core.DataAccess.NHibernate
{
    // Helpers are used to import the helpers for the database
    // for each type of database a helper should be implemented
    public abstract class NHibernateHelper:IDisposable
    {
        //dbcontext in entity framework is session factory in nhibernate
        private ISessionFactory _sessionFactory;

        protected abstract ISessionFactory InitializeFactory();

        public virtual ISession OpenSession
        {
            get
            {
                return SessionFactory.OpenSession();
            }
        }

        //close the open session with dispose
        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }

        public virtual ISessionFactory SessionFactory 
        { 
            get 
            {
                return _sessionFactory ?? (_sessionFactory=InitializeFactory()); 
            } 
        }


    }
}
