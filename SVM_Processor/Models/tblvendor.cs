using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SVM_Processor.Models
{
    public class tblvendor
    {
        [Key]
        public int VendorId { get; set; }

        public string VendorName { get; set; }

        public string VendorCode { get; set; }

        public string VendorDescription { get; set; }

        public bool IsDeleted { get; set; }
    }
}
