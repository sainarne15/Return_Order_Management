using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Payment_Microservice.Models;
using Payment_Microservice.Exceptions;


namespace Payment_Microservice.Repositories
{
    public class PaymentRepository : IPaymentRepository
    {
        private readonly PaymentDetails paymentDetails;
		static readonly log4net.ILog log = log4net.LogManager.GetLogger(typeof(PaymentRepository));
		public PaymentRepository()
        {
			paymentDetails = new PaymentDetails();
        }
		public string processPaymentService(int RequestId, long cardNumber, double creditLimit, double processingCharge)
        {
			log.Info("Payment service started");

			try
			{
				paymentDetails.CardNumber = cardNumber;
				paymentDetails.RequestId = RequestId;
				paymentDetails.CreditLimit = creditLimit - processingCharge;
				paymentDetails.ProcessingCharge = processingCharge;

			}
			catch (Exception)
			{
				throw new InvalidFormatException("Wrong type of the input provided...");
			}


            if (paymentDetails.CreditLimit >= 0)
            {
				log.Info("Payment service ended");
				return Convert.ToString(paymentDetails.CreditLimit);
			}
            else
            {
				log.Info("Cannot deduct Processing charge >> card limit exceed");
				return "-1";
			}
		}
    }
}
