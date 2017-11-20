using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SVM_Processor.Models
{
    public class tblmodeofpayment
    {
        [Key]
        public int ModeOfPaymentId { get; set; }

        public string ModeOfPaymentDesc { get; set; }

        public bool IsDeleted { get; set; }
    }
}
