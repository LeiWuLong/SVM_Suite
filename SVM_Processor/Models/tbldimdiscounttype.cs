using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SVM_Processor.Models
{
    public class tbldimdiscounttype
    {
        [Key]
        public int DiscountTypeId { get; set; }

        public string DiscountType { get; set; }

        public bool isDeleted { get; set; }   
    }
}
