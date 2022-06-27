using Component_Processing.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Component_Processing.Provider
{
    public class ComponentProvider: IComponentProvider
    {
        public ProcessResponse GetResponse(string type, int quantity, bool Priority)
        {
            double processAmount=0;
            int noOfDays;

            if (type.Equals("Integral"))
            {
                if (Priority)
                {
                    processAmount = 700;
                    noOfDays = 2;
                }
                else
                {
                    processAmount = 500;
                    noOfDays = 5;
                }
            }

            ProcessResponse response = new ProcessResponse();
            response.ProcessingCharge = processAmount;
            response.PackagingandDeliveryCharge = processAmount;
            response.DateOfDelivery = DateTime.Now;
            return response;
        }

    }
}
