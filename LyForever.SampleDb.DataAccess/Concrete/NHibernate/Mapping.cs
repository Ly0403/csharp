using FluentNHibernate.Mapping;
using LyForever.SampleDb.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LyForever.SampleDb.DataAccess.Concrete.NHibernate
{
    public class Mapping : ClassMap<Product>
    {
        public Mapping()
        {
            Table(@"Products");
            Id(x => x.ProductId).Column("ProductID");
            Map(x => x.ProductName).Column("ProductName");
            Map(x => x.CategoryId).Column("CategoryID");
            Map(x => x.UnitPice).Column("UnitPrice");
            Map(x => x.QuantityPerUnit).Column("QuantityPerUnit");
        }
    }
}
