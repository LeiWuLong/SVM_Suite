using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SVM_Processor.Models
{
    public class tbldimsection
    {
        [Key]
        public int SectionId { get; set; }

        public string SectionName { get; set; }

        public int EducationalLevel { get; set; }

        public bool isDeleted { get; set; }
    }
}
