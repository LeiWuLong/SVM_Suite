using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SVM_Processor.Models
{
    public class tbldimalumnidiscount
    {
        [Key]
        public int AlumniDiscountId { get; set; }

        public string AlumniDiscountDesc { get; set; }

        public decimal AlumniDiscountPercent { get; set; }

        public DateTime ModifiedDate { get; set; }

        public bool isDeleted { get; set; }
    }
}
