using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SVM_Processor.Models;
using SVM_Processor.DTO;

namespace SVM_Contracts
{
    public interface IPaymentService
    {
        List<PaymentsDTO> GetPayments();

        PaymentsDTO GetPaymentById(int PaymentId);

        void SavePayment(int studentId, decimal amount, int modeOfPayment, int? chequeNo,  bool isDownpayment, bool isPromissory);

        List<PaymentsDTO> GetPaymentsByStudentId(int studentId);

        List<tblmodeofpayment> GetModeOfPayment();

        List<tblpaymentterm> GetPaymentTerms();

        List<tblpayment> GetPaymentsByName(string studentName);

        List<PaymentsDTO> GetAssessmentListing();

        List<tbldimdateparameter> GetDateParameters();


    }
}
