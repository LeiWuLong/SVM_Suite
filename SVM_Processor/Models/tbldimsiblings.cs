using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SVM_Processor.Models
{
    public class tbldimsiblings
    {
        [Key]
        public int SiblingId { get; set; }

        public string Siblings { get; set; }
    }
}
