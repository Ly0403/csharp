using LyForever.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LyForever.SampleDb.Entities.Concrete
{
    public class Customer:IEntity
    {
        public virtual string CustomerId { get; set; }
        public virtual string City { get; set; }
    }
}
