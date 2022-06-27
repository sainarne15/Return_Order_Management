using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Component_Processing.Models
{
    public class ProcessResponse
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int RequestId { get; set; }
        public double ProcessingCharge { get; set; }
        public double PackagingandDeliveryCharge { get; set; }
        public DateTime DateOfDelivery { get; set; }
    }
}
