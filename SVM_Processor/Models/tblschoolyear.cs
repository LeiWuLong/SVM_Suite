namespace SVM_Processor.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

   
    public partial class tblschoolyear
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int SchoolYearId { get; set; }

        public DateTime? SchoolYearFrom { get; set; }

        public DateTime? SchoolYearTo { get; set; }
    }
}
