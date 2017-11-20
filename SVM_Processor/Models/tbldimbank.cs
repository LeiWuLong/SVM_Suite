using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SVM_Processor.Models
{
    public class tbldimbank
    {
        [Key]
        public int BankId { get; set; }

        public string BankName { get; set; }

        public bool IsDeleted { get; set; }

    }
}
