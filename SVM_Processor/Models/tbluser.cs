namespace SVM_Processor.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

  
    public partial class tbluser
    {
        [Key]

        public int UserId { get; set; }
        
        public string EmployeeNo { get; set; }

        [StringLength(45)]
        public string FirstName { get; set; }

        [StringLength(30)]
        public string MiddleName { get; set; }

        [StringLength(30)]
        public string LastName { get; set; }

        public string Path { get; set; }


        [StringLength(20)]
        public string MobileNo { get; set; }

        [StringLength(30)]
        public string Email { get; set; }

        [Column(TypeName = "blob")]
        public byte[] Photo { get; set; }

        public int? CreatedBy { get; set; }

        public DateTime? CreatedDate { get; set; }

        public DateTime? LastModifiedDate { get; set; }

        public int? LastModifiedBy { get; set; }

        public bool isDeleted { get; set;  }
    }
}
