using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SVM_Processor.DTO
{
    public class PaymentsDTO
    {
        public int PaymentId { get; set; }

        public int StudentId { get; set; }

        public string FirstName { get; set; }

        public string MiddleName { get; set; }

        public string LastName { get; set; }

        public string StudentNo { get; set; }

        public decimal Amount { get; set; }

        public string BankName {get;set;}       

        public int ModeOfPaymentId { get; set; }

        public string ModeOfPayment { get; set; }

        public DateTime TransactionDate { get; set; }

        public string path { get; set; }

        public decimal Balance { get; set; }

        public decimal OriginalBalance { get; set; }

        public int PaymentTerm { get; set; }

        public string PaymentTermDesc { get; set; }

        public decimal DiscountAmount { get; set; }

        public bool isTransferee { get; set; }
     
        public double FullMisc { get; set; }

        public double DeferredMisc { get; set; }
     
        public double PaymentPerDue { get; set; }
    }
}
