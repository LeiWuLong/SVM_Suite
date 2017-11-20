using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SVM_Processor.Models
{
    public class tbldimenrollment
    {
        [System.ComponentModel.DataAnnotations.Key]
        public int DimEnrollmentId { get; set; }

        public string EnrollmentCode { get; set; }

        public int TuitMisc { get; set; }

        public int PaymentTermId { get; set; }

        public int LevelId { get; set; }
    }
}
