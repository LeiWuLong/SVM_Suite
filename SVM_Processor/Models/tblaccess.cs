using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SVM_Processor.Models
{
    public class tblaccess
    {
        [Key]
        public int AccessId { get; set; }
        public string AccessName { get; set; }

    }
}
