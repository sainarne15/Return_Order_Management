using Component_Processing.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Component_Processing.Repositry
{
    public interface IComponentRepo
    {
        public ProcessResponse GetResponse(string Name, long ContactNumber, long CreditCardNumber, double CreditLimit,string ComponentType, string ComponentName, int Quantity, bool IsPriority);
        public string GetCompletion(int RequestId, long CreditCardNumber, double CreditLimit, double ProcessingCharge);
    }
}
