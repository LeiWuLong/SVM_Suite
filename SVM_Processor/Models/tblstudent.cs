using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SVM_Processor.Models
{
    public class tblstudent
    {
        
        [Key]
        public int StudentId { get; set; }

        public string StudentNo { get; set; }

        public string FirstName { get; set; }
            
        public string MiddleName { get; set; }
           
        public string LastName { get; set; }
        
        public DateTime DateOfBirth { get; set; }
        
        public string PlaceOfBirth { get; set; }
            
        public int GenderId { get; set; }
            
        public string Religion { get; set; }
            
        public string Citizenship { get; set; }
            
        public string PostalCode { get; set; }
            
        public string PermanentAddress { get; set; }

        public int EducationalLevelId { get; set; }

        public string SchoolNameAndAddress { get; set; }

        public int SchoolYear { get; set; }

        public string AwardsReceived { get; set; }

        public bool EmergencyContact { get; set; }

        public bool isDeleted { get; set; }

        public string path { get; set;  }

        public int AY { get; set; }
    }

}
