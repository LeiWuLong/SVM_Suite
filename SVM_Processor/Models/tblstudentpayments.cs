using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SVM_Processor.Models
{
    public class tblstudentpayments
    {
        [Key]
        public int StudentPaymentId { get; set; }

        public double Fee { get; set; }

        public int PaymentType { get; set; }

    }
}
