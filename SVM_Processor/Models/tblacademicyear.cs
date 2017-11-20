using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SVM_Processor.Models
{
    public class tblacademicyear
    {
        [Key]
        public int AcademicYearId { get; set; }

        public string AcademicYear { get; set; }

        public DateTime AYFrom { get; set; }

        public DateTime AYTo { get; set; }

        public int YearFrom { get; set; }

        public int YearTo { get; set; }

        public bool isCurrent { get; set; }
    }
}
