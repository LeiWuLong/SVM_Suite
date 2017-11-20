using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SVM_Processor.Models
{
    public class tbldimdateparameter
    {
        [Key]
        public int DateParameterId { get; set; }

        public string DatesDescription { get; set; }

        public DateTime FromDate { get; set; }

        public DateTime ToDate { get; set; }
        //continue this
    }
}
