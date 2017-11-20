using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SVM_Processor.Models
{
    public class tblpayment
    {
        [Key]
        public int PaymentId { get; set; }

        public int StudentId { get; set; }

        public int ModeOfPayment { get; set; }

        public decimal Amount { get; set; }

        public int? ChequeNumber { get; set; }

        public int BankId { get; set; }

        public bool IsDeleted { get; set; }

        public DateTime TransactionDate { get; set; }

        public decimal Balance { get; set; }

        public decimal OriginalBalance { get; set; }

        public bool isDownpayment { get; set; }

        public bool isPromissory { get; set; }

        public int SchoolYearId { get; set; }

        public double PenalizedFee { get; set; }
    }
}
