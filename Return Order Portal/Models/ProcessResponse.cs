using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Return_Order_Portal.Models
{
    public class ProcessResponse
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int RequestId { get; set; }

        public int ProcessingCharge { get; set; }

        public int PackagingAndDeliveryCharge { get; set; }

        public DateTime DateOfDelivery { get; set; }
    }
}
