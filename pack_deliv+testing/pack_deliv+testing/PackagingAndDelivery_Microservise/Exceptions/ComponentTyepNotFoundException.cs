using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PackagingAndDelivery_Microservise.Exceptions
{
    public class ComponentTyepNotFoundException : Exception
    {
        public ComponentTyepNotFoundException(string message) : base(message)
        {
            
        }
    }
}
