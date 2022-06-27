using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Payment_Microservice.Models
{
    public class PaymentDetails
    {
		[Key]
		public int RequestId { get; set; }

		[RegularExpression(@"^[0-9]{16}$", ErrorMessage = "Enter 16 Digits only")]
		public long CardNumber { get; set; }



		public double CreditLimit { get; set; }


		public double ProcessingCharge { get; set; }
	}
}
