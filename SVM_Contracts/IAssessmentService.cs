using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SVM_Processor.Models;
using SVM_Processor.DTO;

namespace SVM_Contracts
{
    public interface IAssessmentService
    {

        void InsertStudent(int studentId, int sectionId, DateTime? validUntil, int educationalLevelId);

        tblassessment GetAssessment(int studentId);

        void UpdateTblAssessment(int studentId, int sectionId, int educationLevelId, int paymentTerm, double fullAmount
            ,double downpayment, double deferredAmount,double discountAmount,
            bool isAlumni, double siblingDiscount, double referralDiscount, bool isTransfer,
            double fullMisc,double deferredMisc, double originalTuitionFee);

        List<tbldimsection> GetSections(int educationLevel);

        List<TuitionDTO> GetFees(int levelId, int paymentTermId);

        List<TuitionDTO> GetDiscount();

       void  SaveSiblings(int studentId, int siblingId,int discountTypeId);

        void SaveReferral(int studentId, int referralId, int discountTypeId);

        List<StudentListingDTO> GetReferralSiblingGrid(int studentId, int discountType);

        AssessmentDTO GetAssessmentsDTO(int studentId);

        void RemoveReferralSiblings(int studentId);
    }
}
