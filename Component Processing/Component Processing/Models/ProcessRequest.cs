using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Component_Processing.Models
{
    public class ProcessRequest
    {
        public string Name { get; set; }
        [RegularExpression(@"^[0-9]{10}$", ErrorMessage = "Enter 10 Digits only")]
        public long ContactNumber { get; set; }
        [RegularExpression(@"^[0-9]{16}$", ErrorMessage = "Enter 16 Digits only")]
        public long CreditCardNumber { get; set; }
        public double CreditLimit { get; set; }
        public string ComponentType { get; set;}
        public string ComponentName { get; set; }
        public int Quantity { get; set; }
        public bool IsPriorityRequest { get; set; }

    }
}
