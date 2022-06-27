using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PackagingAndDelivery_Microservise.Repositories;
using PackagingAndDelivery_Microservise.Exceptions;

namespace PackagingAndDelivery_Microservise.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PackageAndDeliveryController : ControllerBase
    {
        static readonly log4net.ILog log = log4net.LogManager.GetLogger(typeof(PackageAndDeliveryController));
        private readonly IPackageAndDeliveryRepositry packageAndDelivery;

        public PackageAndDeliveryController(IPackageAndDeliveryRepositry package)
        {
            this.packageAndDelivery = package;
        }

        [HttpGet]
        [Route("/getPackagingDeliveryCharge/{type}/{count}")]
        public double PackagingAndDeliveryCharge(string type , int count)
        {
            try
            {
                return packageAndDelivery.calculatePackagingAndDeliveryCharge(type, count);

            }
            catch (Exception e)
            {
                throw new ComponentTyepNotFoundException("Component Type: " + type + "not found.");
            }
        }
    }
    
}
