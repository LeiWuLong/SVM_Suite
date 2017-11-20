using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SVM_Processor.Models;
using SVM_Processor.DTO;

namespace SVM_Contracts
{
    public interface ITuitionService
    {
        void SaveFee
            (double amount, int dimTuitionid);

         List<tbldimenrollment> GetAllDimEnrollment();

        List<TuitionDTO> GetTuition();


    }
}
