using LyForever.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel.Activation;
using System.Text;
using System.Threading.Tasks;

namespace LyForever.Core.DataAccess.NHibernate
{
    public class NhbQueryableRepository<T> : IQueryableRepository<T> where T : class, IEntity, new()
    {
        private NHibernateHelper _nHibernateHelper;

        private IQueryable<T> _entities;
        public NhbQueryableRepository(NHibernateHelper nHibernateHelper)
        {
            _nHibernateHelper= nHibernateHelper;
        }



        public IQueryable<T> OnlySelect => this.Entities;

        public virtual IQueryable<T> Entities
        {
            get
            {
                return _entities??(_nHibernateHelper.OpenSession.Query<T>());
            }
        }
    }
}
