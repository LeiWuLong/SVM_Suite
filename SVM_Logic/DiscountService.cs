
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SVM_Processor.Models;
using SVM_Processor.DTO;
using SVM_Contracts;

namespace SVM_Logic
{
    public class DiscountService:IDiscountService
    {

        SVMContext svmContext = new SVMContext();

#region FamiyDiscount

        public List<tbldimfamassistdiscount> GetFamilyAssistanceDiscount()
        {
            List<tbldimfamassistdiscount> lstFamDiscounts = (from p in svmContext.tbldimfamassistdiscount
                                                             where p.isDeleted == false
                                                             select p).ToList();

            return lstFamDiscounts;
        }

        public List<tbldimscholarshipdiscount> GetScholarshipDiscount()
        {
            List<tbldimscholarshipdiscount> lstScholarshipDiscount = (from p in svmContext.tbldimscholarshipdiscount
                                                             where p.isDeleted == false
                                                             select p).ToList();

            return lstScholarshipDiscount;
        }

        public tbldimalumnidiscount GetAlumniDiscount()
        {
           tbldimalumnidiscount lstAlumni = (from p in svmContext.tbldimalumnidiscount
                                                                      where p.isDeleted == false
                                                                      select p).FirstOrDefault();

            return lstAlumni;
        }

        public List<tbldimearlybirddiscount> GetEarlyBirdDiscount()
        {
            List<tbldimearlybirddiscount> lstEarlyBird = (from p in svmContext.tbldimearlybirddiscount
                                              where p.isDeleted == false
                                              select p).ToList();

            return lstEarlyBird;
        }

        public void SaveFamilyAssistanceDiscount()
        {

        }

        public void SaveScholarshipDiscount()
        {

        }

        public void SaveAlumniDiscount()
        {

        }

        public void SaveEarlyBirdDiscount()
        {

        }

        public void UpdateFamilyAssistanceDiscount()
        {

        }

        public void UpdateScholarshipDiscount()
        {

        }

        public void UpdatelumniDiscount()
        {

        }

        public void UpdateEarlyBirdDiscount()
        {

        }

        #endregion


        public List<tbldimdiscounttype> GetDiscountTypes()
        {
            List<tbldimdiscounttype> lstDiscountTypes = (from p in svmContext.tbldimdiscounttype
                                                         where p.isDeleted == false
                                                         select p).ToList();

            return lstDiscountTypes;

          
        }

        public tbldiscount GetDiscount(int discountId)
        {
            tbldiscount lstDiscount = (from p in svmContext.tbldiscount
                                       where p.isDeleted == false && p.DiscountId == discountId
                                       select p).FirstOrDefault();
            return lstDiscount;
        }

        public List<tbldiscount> GetDiscountByTypeId(int discountTypeId)
        {
            List<tbldiscount> lstDiscount = (from p in svmContext.tbldiscount
                                       where p.isDeleted == false && p.DiscountTypeId == discountTypeId
                                       select p).ToList();
            return lstDiscount;
        }


        public void SaveDiscount(tbldiscount discount)
        {
            tbldiscount tblDiscount = new tbldiscount();

            tblDiscount.DiscountTypeId = discount.DiscountTypeId;
            tblDiscount.DiscountTypeVal = discount.DiscountTypeVal;
            tblDiscount.isDeleted = false;
            tblDiscount.DiscountTypeDesc = discount.DiscountTypeDesc;
            svmContext.tbldiscount.Add(tblDiscount);
            svmContext.SaveChanges();

        }

        public void UpdateDiscount(tbldiscount myDiscount)
        {
            tbldiscount tblDiscount = GetDiscount(myDiscount.DiscountId);

            tblDiscount.DiscountTypeVal = myDiscount.DiscountTypeVal;
            tblDiscount.DiscountTypeDesc = myDiscount.DiscountTypeDesc;
            svmContext.SaveChanges();
        }

        public void DeleteDiscount(int discountId)
        {
            tbldiscount tblDiscount = GetDiscount(discountId);

            tblDiscount.isDeleted = true;
            svmContext.SaveChanges();
        }
 
        //public List<tbldimfamassistdiscount> GetFamilyAssistanceDiscount();

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
    }
}
