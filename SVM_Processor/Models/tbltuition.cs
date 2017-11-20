namespace SVM_Processor.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

  
    public partial class tbltuition
    {
        [Key]
        public int TuitionId { get; set; }
        
        //public int LevelId { get; set; }

        public double Fee { get; set; }

        //public double MiscFee { get; set; }

        //public int PaymentTerm { get; set; }

        public int DimEnrollmentId { get; set; }

        //TYPE OF 
        //--Grade Level

        //PERCETAGE DISCOUNT


        //[Key]
        //[DatabaseGenerated(DatabaseGeneratedOption.None)]
        //public int TuitionId { get; set; }

        //[StringLength(45)]
        //public string TuitionDescription { get; set; }

        //public float? TotalAmount { get; set; }

        //public bool? IsInstallment { get; set; }

        //public int? NumOfTerms { get; set; }

        //public float? Discount { get; set; }

        //public float? Misc { get; set; }

        //public float? TuitionFee { get; set; }

        //public int? CreatedBy { get; set; }

        //public DateTime? CreatedDate { get; set; }

        //public int? ModifiedBy { get; set; }

        //public DateTime? LastModifiedDate { get; set; }
    }
}
