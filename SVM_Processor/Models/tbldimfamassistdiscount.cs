using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SVM_Processor.Models
{
    public class tbldimfamassistdiscount
    {
        [System.ComponentModel.DataAnnotations.Key]
        public int FamDiscountId { get; set; }

        public string FamDiscountDesc { get; set; }

        public decimal FamDiscountPercent { get; set; }
        
        public bool isDeleted { get; set; }
    }
}
