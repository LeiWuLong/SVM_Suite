using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SVM_Processor.Models
{
    public class tbldimreferrals
    {
        [Key]
        public int ReferralId { get; set; }

        public string Referral { get; set; }
    }
}
