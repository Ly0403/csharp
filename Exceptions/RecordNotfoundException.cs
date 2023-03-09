using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions
{
    internal class RecordNotfoundException:Exception
    {
        public RecordNotfoundException(string message):base(message)
        {
                
        }
    }
}
