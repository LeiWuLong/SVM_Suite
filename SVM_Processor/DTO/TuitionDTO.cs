using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SVM_Processor.DTO
{
    public class TuitionDTO
    {
        public int DimTuitionId { get; set; }        

        public string EnrollmentCode { get; set; }

        public int PaymentTermId { get; set; }

        public string PaymentTermDesc { get; set; }

        public int LevelId { get; set; }

        public double Fee { get; set; }

        public int DownpaymentFee { get; set; }

        public int MiscFee { get; set; }

        public int PercentDiscount { get; set; }

        public int TuitMisc { get; set; }

        public int Divisor { get; set; }

        public int DiscountTypeId { get; set; }

        public double DiscountVal { get; set; }

        public string DiscountTypeDesc { get; set; }

        public string DiscountParam { get; set; }
    }
}
