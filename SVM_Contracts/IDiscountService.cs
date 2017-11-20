using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SVM_Processor.Models;
using SVM_Processor.DTO;

namespace SVM_Contracts
{
    public interface IDiscountService
    {
        //List<tbldimfamassistdiscount> GetFamilyAssistanceDiscount();

        //List<tbldimscholarshipdiscount> GetScholarshipDiscount();

        //List<tbldimalumnidiscount> GetAlumniDiscount();

        //List<tbldimearlybirddiscount> GetEarlyBirdDiscount();

        //void SaveFamilyAssistanceDiscount();

        //void SaveScholarshipDiscount();

        //void SaveAlumniDiscount();

        //void SaveEarlyBirdDiscount();

        //void UpdateFamilyAssistanceDiscount();

        //void UpdateScholarshipDiscount();

        //void UpdateAlumniDiscount();

        //void UpdateEarlyBirdDiscount();

        List<tbldimdiscounttype> GetDiscountTypes();

        List<tbldiscount> GetDiscountByTypeId(int discountTypeId);

        tbldiscount GetDiscount(int discountTypeId);

        void SaveDiscount(tbldiscount discount);

        void UpdateDiscount(tbldiscount myDiscount);

        void DeleteDiscount(int discountId);
    }
}
