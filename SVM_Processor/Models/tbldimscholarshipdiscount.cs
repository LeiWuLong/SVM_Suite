using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SVM_Processor.Models
{
    public class tbldimscholarshipdiscount
    {
        [Key]
        public int ScholarshipDiscountId { get; set; }

        public string ScholarshipDesc { get; set; }

        public decimal ScholarshipDiscount { get; set; }

        public bool isDeleted { get; set; }
    }
}
