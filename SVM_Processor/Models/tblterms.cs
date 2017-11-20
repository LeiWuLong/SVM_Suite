namespace SVM_Processor.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

   
    public partial class tblterms
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int TermId { get; set; }

        public int? TuitionId { get; set; }

        public int? OrderNumber { get; set; }

        public DateTime? DueDate { get; set; }

        public float? Amount { get; set; }
    }
}
