using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SVM_Processor.Models
{
    public class tbldimeducationlevel
    {
        [Key]
        public int LevelId { get; set; }

        public string Level { get; set; }
    }
}
