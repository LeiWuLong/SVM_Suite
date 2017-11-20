using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SVM_Processor.Models
{
    public class tbldimearlybirddiscount
    {
        [Key]
        public int EarlyBirdDiscountId { get; set; }

        public string EarlyBirdDescription { get; set; }

        public DateTime DiscountDate { get; set; }

        public decimal DiscountAmount { get; set; }

        public bool isDeleted { get; set; }
    }

}
