using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Payment_Microservice.Repositories;
using Payment_Microservice.Exceptions;

namespace Payment_Microservice.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PaymentsController : ControllerBase
    {
        static readonly log4net.ILog log = log4net.LogManager.GetLogger(typeof(PaymentsController));
        private IPaymentRepository paymentRepositoryImp;
        public PaymentsController(IPaymentRepository payment)
        {
            this.paymentRepositoryImp = payment;
        }

        [HttpGet]
        [Route("/GetpaymentDetails/{requestId}/{cardNumber}/{creditLimit}/{processingCharge}")]
        public string GetpaymentDetails(int requestId, long cardNumber, double creditLimit, double processingCharge)
        {
            try
            {
                log.Info("in Payment Service");
                log.Info("Start GetBalance");
                return paymentRepositoryImp.processPaymentService(requestId, cardNumber, creditLimit, processingCharge);
            }
            catch (Exception e)
            {
                log.Error("Exception in GetpaymentDetails" + e.Message);
                throw new InvalidFormatException("Wrong type of the input provided...");
            }
        }
    }
}
