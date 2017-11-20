using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SVM_Processor.Models
{
    public class tblstudenthealthrecord
    {
        [Key]
        public int StudentHealthRecordId { get; set; }

        public int StudentId { get; set; }

        public string ChildsDoctor { get; set; }

        public string DoctorsBusinessNameAndAddress { get; set; }

        public string DoctorsContactNo { get; set; }

        public string PersonToNotify { get; set; }

        public string Relationship { get; set; }

        public string Address { get; set; }

        public bool Immunization { get; set; }

        public int HealthConcernId { get; set; }

        public string Allergies { get; set; }

        public string ConditionHindrance { get; set; }

        public string   SpecialCare { get; set; }

        public bool isDeleted { get; set; }
    }
}
