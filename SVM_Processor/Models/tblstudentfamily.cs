using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SVM_Processor.Models
{
    public class tblstudentfamily
    {
        [Key]
        public int StudentFamilyId { get; set; }

        public int StudentId { get; set; }

        public int RelationshipId { get; set; }

        public string Citizenship { get; set; }

        public string Religion { get; set; }

        public string Address { get; set; }

        public string TelNo { get; set; }

        public string MobileNo { get; set; }

        public string eMail { get; set; }

        public string Occupation { get; set; }

        public string EmployerBizAddress { get; set; }

        public string LastSchoolAttended { get; set; }

        public string YearGraduated { get; set; }

        public string EducationalAttainment { get; set; }

        public string Name { get; set; }

        public bool IsDeleted { get; set; }
    }
}
