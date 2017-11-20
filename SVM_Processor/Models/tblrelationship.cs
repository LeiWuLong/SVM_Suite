using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SVM_Processor.Models
{
    public class tblrelationship
    {
        [Key]
        public int RelationshipId {get;set;}

        public string RelationshipName { get; set; }
    }
}
