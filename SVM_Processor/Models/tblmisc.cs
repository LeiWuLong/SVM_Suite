namespace SVM_Processor.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    
    public partial class tblmisc
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int MiscId { get; set; }

        //[StringLength(45)]
        //public string MiscDescription { get; set; }

        public float? MiscAmount { get; set; }

        public int DimMiscId { get; set; }
    }
}
