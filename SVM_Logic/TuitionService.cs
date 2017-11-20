using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SVM_Contracts;
using SVM_Processor.Models;
using SVM_Processor.DTO;


namespace SVM_Logic
{
    public class TuitionService : ITuitionService
    {

        SVMContext svmContext = new SVMContext();

        public List<tbldimenrollment> GetAllDimEnrollment()
        {

            List<tbldimenrollment> lstDimEnrollment = (from p in svmContext.tbldimenrollment
                                                       select p).ToList();

            return lstDimEnrollment;
        }

        public void SaveFee(double amount, int dimTuitionid)
        {

            tbltuition tuition = (from p in svmContext.tbltuition
                                  where p.DimEnrollmentId == dimTuitionid
                                  select p).FirstOrDefault();

            if (tuition != null)
            {
                svmContext.tbltuition.Remove(tuition);
            }

            tbltuition newTuition = new tbltuition();

            newTuition.Fee = amount;
            newTuition.DimEnrollmentId = dimTuitionid;
            newTuition.TuitionId = dimTuitionid;//as of now , use as same with tuitionId
            svmContext.tbltuition.Add(newTuition);
            svmContext.SaveChanges();

        }

        public List<TuitionDTO> GetTuition()
        {
            List<TuitionDTO> lstTuition = (from p in svmContext.tbltuition
                                           join q in svmContext.tbldimenrollment
                                           on p.DimEnrollmentId equals q.DimEnrollmentId
                                           select new TuitionDTO{
                                               DimTuitionId = p.DimEnrollmentId,
                                               Fee=p.Fee,
                                               EnrollmentCode=q.EnrollmentCode,
                                               
                                           }).ToList();




            return lstTuition;
        }
    }
}