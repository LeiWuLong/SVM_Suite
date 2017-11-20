using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SVM_Processor.Models
{
    public class tbldimassessmentstatus
    {
        [Key]
        public int AssessmentStatusKey { get; set; }

        public string Status { get; set; }

        public int StatusCode { get; set; }
    }
}
