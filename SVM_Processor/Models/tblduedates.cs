using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SVM_Processor.Models
{
    public class tblduedates
    {
        [Key]
        public int DueDatesId { get; set; }

        public int PaymentTermId { get; set; }

        public DateTime DueDate { get; set; }

        public string DueDateDesc { get; set; }
    }
}
