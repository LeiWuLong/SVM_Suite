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
    public class PaymentService : IPaymentService
    {
        SVMContext svmContext = new SVMContext();

        public List<PaymentsDTO> GetPayments()
        {
            List<PaymentsDTO> lstPayments = (from p in svmContext.tblpayment
                                             join q in svmContext.tblstudent

                                             on p.StudentId equals q.StudentId
                                             join r in svmContext.tbldimbank
                                             on p.BankId equals r.BankId


                                             where p.IsDeleted == false
                                             select new PaymentsDTO
                                             {
                                                 Amount = p.Amount,
                                                 StudentNo = q.StudentId.ToString(),//q.StudentId.ToString().PadLeft(4, '0') + " - " + q.AY.ToString(),
                                                 PaymentId=p.PaymentId,
                                                 StudentId = q.StudentId,
                                                 FirstName = q.FirstName,
                                                 MiddleName = q.MiddleName,
                                                 LastName = q.LastName,
                                                 BankName = r.BankName
                                               
                                             }).ToList();

            return lstPayments;
        }

        public PaymentsDTO GetPaymentById(int paymentId)
        {
            PaymentsDTO payments = (from p in svmContext.tblpayment
                                    join q in svmContext.tblstudent
                                    on p.StudentId equals q.StudentId
                                    where p.IsDeleted == false && p.PaymentId == paymentId
                                    select new PaymentsDTO
                                    {

                                        StudentNo = q.StudentNo,
                                        FirstName = q.FirstName,
                                        MiddleName = q.MiddleName,
                                        LastName = q.LastName
                                    }).FirstOrDefault();

            return payments;
        }

        public List<tblpayment> GetPaymentsByName(string studentName)
        {
            List<tblpayment> lstPayments = (from p in svmContext.tblpayment
                                            join q in svmContext.tblstudent
                                            on p.StudentId equals q.StudentId
                                            where p.IsDeleted == false &&
                                            q.StudentNo.Contains(studentName)


                                            select p).ToList();

            return lstPayments;
        }

        public void SavePayment(int studentId, decimal amount, int modeOfPayment, int? chequeNo, bool isDownpayment,
            bool isPromissory)
        {
            tblpayment tblPayment = new tblpayment();
            tblPayment.StudentId = studentId;
            tblPayment.Amount = amount;
            tblPayment.ModeOfPayment = modeOfPayment;
            tblPayment.ChequeNumber = chequeNo;
            tblPayment.isDownpayment =isDownpayment;
           // tblPayment.ispro

            svmContext.tblpayment.Add(tblPayment);
            svmContext.SaveChanges();
        }

        public List<PaymentsDTO> GetPaymentsByStudentId(int studentId)
        {
            List<PaymentsDTO> lstPayments = (from p in svmContext.tblpayment
                                             join q in svmContext.tblstudent
                                             on p.StudentId equals q.StudentId
                                             join r in svmContext.tblmodeofpayment
                                             on p.ModeOfPayment equals r.ModeOfPaymentId
                                             join s in svmContext.tblassessment                
                                             on p.StudentId equals s.StudentId            
                                             where p.IsDeleted == false
                                             && studentId == p.StudentId
                                             select new PaymentsDTO{
                                                 isTransferee=s.isTransferee,
                                                PaymentId=p.PaymentId,
                                                 Amount = p.Amount,
                                                 ModeOfPayment=r.ModeOfPaymentDesc,
                                                 TransactionDate=p.TransactionDate,
                                                 StudentNo = q.StudentNo,
                                                 FirstName = q.FirstName,
                                                 MiddleName = q.MiddleName,
                                                 LastName = q.LastName,
                                                 path=q.path,
                                                 Balance = p.Balance,
                                                 OriginalBalance = p.OriginalBalance,
                                                 DeferredMisc=s.DeferredMisc,
                                                 PaymentPerDue = s.PaymentPerDue
                                             }).ToList();

            return lstPayments;
        }

        public List<tblpayment> GetPaymentsByCode(string StudentNo)
        {
            List<tblpayment> lstPayments = (from p in svmContext.tblpayment
                                            join q in svmContext.tblstudent
                                            on p.StudentId equals q.StudentId
                                            where p.IsDeleted == false &&
                                            q.StudentNo.Contains(StudentNo)


                                            select p).ToList();

            return lstPayments;
        }

        public void Delete_Payment(int PaymentId)
        {
            tblpayment Payment = (from p in svmContext.tblpayment
                                  where p.PaymentId == PaymentId
                                  && p.IsDeleted == false
                                  select p).FirstOrDefault();
            svmContext.SaveChanges();
        }

        //public void UpdatePayment(int PaymentId, string PaymentCode, string PaymentName, string PaymentDesc)
        //{
        //    tblpayment Payment = (from p in svmContext.tblpayment
        //                        where p.PaymentId == PaymentId
        //                        && p.IsDeleted == false
        //                        select p).FirstOrDefault();

        //    Payment.PaymentCode = PaymentCode;
        //    Payment.PaymentName = PaymentName;
        //    Payment.PaymentDescription = PaymentDesc;
        //    svmContext.SaveChanges();
        //}

        public List<tblmodeofpayment> GetModeOfPayment()
        {
            List<tblmodeofpayment> lstModeOfPayment = (from p in svmContext.tblmodeofpayment
                                                       where p.IsDeleted == false
                                                       select p).ToList();

            return lstModeOfPayment;
        }

        public List<tbldimbank> GetBanks()
        {
            List<tbldimbank> lstGetBanks = (from p in svmContext.tbldimbank
                                         where p.IsDeleted == false
                                         select p).ToList();


            return lstGetBanks;
        }

        public List<tblpaymentterm> GetPaymentTerms()
        {
            List<tblpaymentterm> lstGetPaymentTerms = (from p in svmContext.tblpaymentterm
                                                       where p.isDeleted == false
                                                       select p).ToList();

            return lstGetPaymentTerms;
        }

        public List<PaymentsDTO> GetAssessmentListing()
        {
            List<PaymentsDTO> payments = (from p in svmContext.tblassessment
                                          join q in svmContext.tblstudent
                                          on p.StudentId equals q.StudentId
                                          let dateTo = (from r in svmContext.tbldimschoolyearparam select p.ValidUntil).FirstOrDefault()
                                    where p.isDeleted == false && p.ValidUntil <= dateTo 
                                    select new PaymentsDTO
                                    {

                                        StudentNo = q.StudentNo,
                                        FirstName = q.FirstName,
                                        MiddleName = q.MiddleName,
                                        LastName = q.LastName,
                                        StudentId = q.StudentId,
                                      
                                        
                                    }).ToList();

            return payments;
        }

        public List<tbldimdateparameter> GetDateParameters()
        {
            List<tbldimdateparameter> lstDateParameters = (from p in svmContext.tbldimdateparameter
                                                           select p).ToList();
            return lstDateParameters;
        }

        
    }
}
