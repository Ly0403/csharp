using LyForever.Core.DataAccess;
using LyForever.SampleDb.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LyForever.SampleDb.DataAccess.Abstract
{
    //why we created product interface 
    //since the interface can have other properties than repo base
    public interface IProductDal : IEntityRepository<Product>
    {
    }
}
