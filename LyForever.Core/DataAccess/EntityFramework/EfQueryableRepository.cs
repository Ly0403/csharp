using LyForever.Core.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LyForever.Core.DataAccess.EntityFramework
{
    public class EfQueryableRepository<T> : IQueryableRepository<T> where T : class,IEntity,new()
    {
        private DbContext _dbContext;
        private IDbSet<T> _dbSet;
        public EfQueryableRepository(DbContext dbContext)
        {
            _dbContext= dbContext;
        }

        //public IQueryable<T> OnlySelect {
        //    get
        //    {
        //        return this.Fill;
        //    } 
        //}

        public IQueryable<T> OnlySelect => this.Fill;


        protected virtual IDbSet<T> Fill
        {
            get
            {
                if (_dbSet==null)
                {
                    return _dbContext.Set<T>();
                }
                return _dbSet;            
            }
        }



    }
}
