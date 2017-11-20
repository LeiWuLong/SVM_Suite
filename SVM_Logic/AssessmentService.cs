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
    public class AssessmentService:IAssessmentService
    {

        SVMContext svmContext = new SVMContext();


        public void InsertStudent(int studentId, int sectionId, DateTime? validUntil, int educationalLevelId)
        {
            tblassessment tblAssessment = new tblassessment();

            tblAssessment.StudentId =studentId;
           
            tblAssessment.Status = 1; //for on assessment
            tblAssessment.Section = 0;
            tblAssessment.EducationalLevel = 0;
            tblAssessment.PaymentTerm = 0;
            tblAssessment.ValidUntil = null;

            svmContext.tblassessment.Add(tblAssessment);

            svmContext.SaveChanges();
        }

        public tblassessment GetAssessment(int studentId)
        {
            tblassessment assessment = (from p in svmContext.tblassessment
                                        join q in svmContext.tblstudent
                                           on p.StudentId equals q.StudentId
                                           //join r in svmContext.tbltuition 
                                          // on p.EducationalLevel equals r.DimEnrollmentId
                                         //  join s in svmContext.tblmisc 
                                           //on p.EducationalLevel equals s.DimMiscId
                                        where p.StudentId == studentId
                                        select p).FirstOrDefault();

            return assessment;
        }

        public void UpdateTblAssessment(int studentId, int sectionId, int educationLevelId,int paymenTerm,
                                        double fullAmount , double downpayment, double deferredAmount,double discountAmount
                                        ,bool isAlumni,double siblingDiscount, double referralDiscount, bool isTransfer,
                                        double fullMisc,double deferredMisc,double originalTuitionFee)
        {
            tblassessment updateRecord = GetAssessment(studentId);
            updateRecord.Section = sectionId;
            updateRecord.Status = 2; //enrolled
            updateRecord.EducationalLevel = educationLevelId;
            updateRecord.FullAmount = fullAmount;
            updateRecord.Downpayment = downpayment;
            updateRecord.PaymentPerDue = deferredAmount;
            updateRecord.Discount = discountAmount;
            updateRecord.isAlumni = isAlumni;
            updateRecord.SiblingDiscount = siblingDiscount;
            updateRecord.ReferralDiscount = referralDiscount;
            updateRecord.isTransferee = isTransfer;
            updateRecord.FullMisc = fullMisc;
            updateRecord.DeferredMisc = deferredMisc;
            updateRecord.OriginalAmount = originalTuitionFee;
            svmContext.SaveChanges();
        }

        public List<tbldimsection> GetSections(int educationLevel)
        {
            List<tbldimsection> sections = (from p in svmContext.tbldimsection
                                            where p.isDeleted != true 
                                        select p).ToList();

            return sections;
        }

        public List<TuitionDTO> GetFees(int levelId, int paymentTermId)
        {
            List<TuitionDTO> lstFees = (from p in svmContext.tbltuition
                                join q in svmContext.tbldimenrollment
                                on p.DimEnrollmentId equals q.DimEnrollmentId
                                join r in svmContext.tblpaymentterm
                                on q.PaymentTermId equals r.PaymentTermId
                                where r.PaymentTermId != 5           //5 is 'downpayment'
                                && q.LevelId == levelId && q.PaymentTermId == paymentTermId
                                select new TuitionDTO
                                {
                                   Fee =p.Fee,
                                   PaymentTermId = q.PaymentTermId,
                                   LevelId=q.LevelId,
                                   TuitMisc=q.TuitMisc,
                                   Divisor = r.PaymentDivisor,
                                   PaymentTermDesc = r.PaymentDesc
                                }).ToList();

            return lstFees;
        }

        public List<TuitionDTO> GetDiscount()
        {
            List<TuitionDTO> lstDiscount = (from p in svmContext.tbldiscount
                                            join r in svmContext.tbldimdiscounttype
                                            on p.DiscountTypeId equals r.DiscountTypeId
                                            
                                            select new TuitionDTO
                                            {
                                                DiscountTypeId = p.DiscountTypeId,
                                                DiscountTypeDesc = r.DiscountType,
                                                DiscountVal = p.DiscountTypeVal,
                                                DiscountParam = p.DiscountTypeDesc
                                            }).ToList();

            return lstDiscount;
        }

        public void SaveSiblings(int studentId, int siblingId, int discountTypeId)
        {
            tblsiblingreferralmap tblMap = new tblsiblingreferralmap();

            tblMap.StudentId = studentId;
            tblMap.ReferredStudentId = siblingId;
            tblMap.DiscountTypeId = discountTypeId;
            svmContext.tblsiblingreferralmap.Add(tblMap);
            svmContext.SaveChanges();
        }

        public void SaveReferral(int studentId, int referralId, int discountTypeId)
        {
            tblsiblingreferralmap tblMap = new tblsiblingreferralmap();

            tblMap.StudentId = studentId;
            tblMap.ReferredStudentId = referralId;
            tblMap.DiscountTypeId = discountTypeId;
            svmContext.tblsiblingreferralmap.Add(tblMap);
            svmContext.SaveChanges();
        }

        public List<StudentListingDTO> GetReferralSiblingGrid(int studentId,int discountType)
        {
            List<StudentListingDTO> lstReferralSibling = (from p in svmContext.tblsiblingreferralmap
                                                    join q in svmContext.tblstudent
                                                    on p.ReferredStudentId equals q.StudentId
                                                    where p.StudentId == studentId
                                                    && p.DiscountTypeId == discountType
                                                    select new StudentListingDTO
                                                    {
                                                        StudentId = p.ReferredStudentId,
                                                        StudentNo=q.StudentNo,
                                                        FirstName = q.FirstName,
                                                        MiddleName = q.MiddleName,
                                                        LastName = q.LastName
                                                    }).ToList();

            return lstReferralSibling;
        }

        public void RemoveReferralSiblings(int studentId)
        {
            //var lstSiblingReferralMap = svmContext.tblsiblingreferralmap.
            //    Where(x => x.StudentId == studentId).ToList();
            //svmContext.tblsiblingreferralmap.RemoveRange(lstSiblingReferralMap);
            //svmContext.SaveChanges();

            int deletedRows = svmContext.Database.ExecuteSqlCommand("delete from tblsiblingreferralmap where studentId = "
                 + studentId);
        }


        public AssessmentDTO GetAssessmentsDTO(int studentId)
        {
            AssessmentDTO assessment = (from p in svmContext.tblassessment
                                               join q in svmContext.tblstudent
                                                  on p.StudentId equals q.StudentId
                                               //join r in svmContext.tbltuition 
                                               // on p.EducationalLevel equals r.DimEnrollmentId
                                               //  join s in svmContext.tblmisc 
                                               //on p.EducationalLevel equals s.DimMiscId
                                               where p.StudentId == studentId
                                               
            select new AssessmentDTO
                                             {
                                                
                                                 FirstName = q.FirstName,
                                                 MiddleName = q.MiddleName,
                                                 LastName = q.LastName,
                                                 path = q.path,
                                                 StudentNo = q.StudentNo
                                                
                                             }).FirstOrDefault();

            return assessment;
        }

    }
}
