using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PackagingAndDelivery_Microservise.Repositories
{
    public interface IPackageAndDeliveryRepositry
    {
        public double calculatePackagingAndDeliveryCharge(string Type, int count);
    }
}
