using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SVM_Processor.Models
{
    public class tblsiblingreferralmap
    {
        [Key]
        public int SiblingReferralMapId { get; set; }

        public int ReferredStudentId { get; set; }

        public int StudentId { get; set; }

        public int SYId {get;set;}

        public int DiscountTypeId { get; set; }
    }
}
