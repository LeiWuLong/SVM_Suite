﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SVM_Processor.Models
{
    public class tblgender
    {
        [Key]
        public int GenderId { get; set; }

        public string GenderDesc { get; set; }
    }
}
