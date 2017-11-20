using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SVM_Processor.Models
{
    public class tblpaymentterm
    {
        [Key]
        public int PaymentTermId { get; set; }
        
        public string PaymentDesc { get; set; }

        public int PaymentDivisor { get; set; }

        public bool isDeleted { get; set; }
    }
}
