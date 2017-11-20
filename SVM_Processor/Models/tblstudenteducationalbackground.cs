using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SVM_Processor.Models
{
    public class tblstudenteducationalbackground
    {
        [Key]
        public int LevelId { get; set; }

        public int EducLevelId { get; set; }

        public int StudentId { get; set; }

        public string SchoolName { get; set; }

        public string SchoolYear { get; set; }

        public string AwardsReceived { get; set; }

        public bool IsDeleted { get; set; }
    }
}
