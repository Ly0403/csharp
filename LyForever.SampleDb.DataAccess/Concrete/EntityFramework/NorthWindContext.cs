using LyForever.SampleDb.DataAccess.Concrete.EntityFramework.Mapping;
using LyForever.SampleDb.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LyForever.SampleDb.DataAccess.Concrete.EntityFramework
{
    public class NorthWindContext:DbContext
    {
        public NorthWindContext()
        {
            Database.SetInitializer<NorthWindContext>(null);
        }
        public DbSet<Product> products { get; set; }
        public DbSet<Customer> customers { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new ProductMap());
            modelBuilder.Configurations.Add(new CustomerMap());
        }
    }
}
