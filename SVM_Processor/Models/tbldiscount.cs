using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SVM_Processor.Models
{
    public class tbldiscount
    {
        [Key]
        public int DiscountId { get; set; }

        public int DiscountTypeId { get; set; }

        public string DiscountTypeDesc { get; set; }

        public double DiscountTypeVal { get; set; }

        public bool isDeleted { get; set; }
    }
}
