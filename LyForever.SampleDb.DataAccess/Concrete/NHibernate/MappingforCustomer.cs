using FluentNHibernate.Mapping;
using LyForever.SampleDb.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LyForever.SampleDb.DataAccess.Concrete.NHibernate
{
    public class MappingforCustomer:ClassMap<Customer>
    {
        public MappingforCustomer()
        {
            Table(@"Customers");
            Id(x=>x.CustomerId).Column("CustomerID");
            Map(x=>x.City).Column("City");
        }
    }
}
