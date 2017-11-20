using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SVM_Processor.Models;
using SVM_Processor;
using SVM_Contracts;

namespace SVM_Logic
{
   public  class DueDatesService: IDueDatesService
    {
        SVMContext svmContext = new SVMContext();

        public List<tblduedates> GetDueDates(int paymentTermId)
        {
            List<tblduedates> lstDueDates = (from p in svmContext.tblduedates
                                             where p.PaymentTermId == paymentTermId
                                             select p).OrderBy(x=>x.DueDate).ToList();

            return lstDueDates;
        }
    }
}
