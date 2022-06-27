using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PackagingAndDelivery_Microservise.Models;
using PackagingAndDelivery_Microservise.Exceptions;

namespace PackagingAndDelivery_Microservise.Repositories
{
    public class PackageAndDeliveryRepositry : IPackageAndDeliveryRepositry
    {
        static readonly log4net.ILog log = log4net.LogManager.GetLogger(typeof(PackageAndDeliveryRepositry));
        private readonly PackagingAndDelivery packagingAndDelivery;
		double totalCharge = 0;

		public PackageAndDeliveryRepositry()
        {
			packagingAndDelivery = new PackagingAndDelivery();

		}

		public double calculatePackagingAndDeliveryCharge(string type, int count)
		{
			log.Info("=========Begin======calculatePackagingAndDeliveryCharge()");
			if (type.Equals("Integral", StringComparison.OrdinalIgnoreCase))
				{
				log.Info("Integral");
				packagingAndDelivery.packagingCost=100;
				packagingAndDelivery.deliveryCost=200;

			}
			else if (type.Equals("Accessory", StringComparison.OrdinalIgnoreCase))
			{
				log.Info("Accessory");
				packagingAndDelivery.packagingCost=50;
				packagingAndDelivery.deliveryCost=100;
			}
			else if (type.Equals("Protective sheath", StringComparison.OrdinalIgnoreCase))
			{
				packagingAndDelivery.packagingCost=50;
			}
			else
			{
				throw new ComponentTyepNotFoundException("Component Type: " + type + "not found.");
			}

			totalCharge = (packagingAndDelivery.packagingCost + packagingAndDelivery.deliveryCost) * count;
			log.Info("=========End======calculatePackagingAndDeliveryCharge()");

			return totalCharge;

		}



	}
}
