using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SVM_Processor.Models;

namespace SVM_Processor.Models
{
    public class tblassessment
    {
        [Key]
        public int AssessmentId { get; set; }

        public int StudentId { get; set; }

        public int Section { get; set; }

        public int Status { get; set; }

        public int EducationalLevel { get; set; }

        public DateTime? ValidUntil { get; set; }

        public bool isDeleted { get; set; }

        public int PaymentTerm { get; set; }

        public double FullAmount { get; set; }

        public double Downpayment { get; set; }

        public double PaymentPerDue { get; set; }

        public double Discount { get; set; }

      

       // public List<tbldimdiscounttype> EligibleDiscount { get; set; }

        public string path { get; set; }

        public DateTime DateCreated { get; set; }

        public bool isAlumni { get; set; }

        public double SiblingDiscount { get; set; }

        public double ReferralDiscount { get; set; }

        public bool isTransferee { get; set; }

        public double FullMisc { get; set; }

        public double DeferredMisc { get; set; }

        public double OriginalAmount { get; set; }

        public int AY { get; set; }
    }
}
