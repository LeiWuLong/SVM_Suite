using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SVM_Processor.Models
{
    public class discounttypedetail
    {
        [Key]
        public int DiscountTypeDetailId { get; set; }

        public string DiscountTypeCondition { get; set; }

       public bool isDeleted { get; set; }
    }
}
