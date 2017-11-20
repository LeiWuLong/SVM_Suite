using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SVM_Processor.Models
{
    public class tblhealthconcern
    {
        [Key]
        public int HealthConcernId { get; set; }

        public string HealthConcernDesc { get; set; }

    }
}
