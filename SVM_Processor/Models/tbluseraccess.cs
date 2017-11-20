namespace SVM_Processor.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

   
    
    public partial class tbluseraccess
    {
       [Key]
       public int UserAccessId { get; set; }

        public int AccessId { get; set; }

        public int UserId { get; set; }

        [StringLength(15)]
        public string UserName { get; set; }

        [StringLength(15)]
        public string Password { get; set; }

        public int? Attempts { get; set; }

        public bool? IsLocked { get; set; }

        public bool? IsActive { get; set; }

        public DateTime? CreatedDate { get; set; }

        public int? CreatedBy { get; set; }

        public int? LastModifiedBy { get; set; }

        public bool isDeleted { get; set; }
    }
}
