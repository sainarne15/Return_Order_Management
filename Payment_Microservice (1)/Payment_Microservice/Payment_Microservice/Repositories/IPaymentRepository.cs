using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Payment_Microservice.Models;

namespace Payment_Microservice.Repositories
{
    public interface IPaymentRepository
    {
        public string processPaymentService(int RequestId, long cardNumber, double creditLimit, double processingCharge);
    }
}
