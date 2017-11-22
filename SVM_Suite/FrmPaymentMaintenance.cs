using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SVM_Contracts;
using SVM_Logic;
using SVM_Processor.DTO;
using SVM_Processor.Models;


namespace SVM_Suite
{
    public partial class FrmPaymentMaintenance : Form
    {
        public FrmPaymentMaintenance()
        {
            InitializeComponent();
        }

        SVMContext svmContext = new SVMContext();
        IPaymentService _paymentService = new PaymentService();
        IAssessmentService _assessmentService = new AssessmentService();
        IDueDatesService _dueDatesService = new DueDatesService();

        List<TuitionDTO> lstDiscount = new List<TuitionDTO>();
        List<tblduedates> lstDueDates = new List<tblduedates>();

        double tuition;
        double computedBirdieDiscount;
        DateTime dateLow;
        DateTime dateHigh;
        double penalizedFee;

        private void FrmPaymentMaintenance_Load(object sender, EventArgs e)
        {
            cbTransferee.Enabled = false;
            //eager load discounts
            lstDiscount = _assessmentService.GetDiscount();
           
            var lstScholarshipRegular = lstDiscount.Where(x => x.DiscountTypeId == 6).ToList();
            var lstScholarshipTransferee = lstDiscount.Where(x => x.DiscountTypeId == 5).ToList();
            var lstEarlyBird = lstDiscount.Where(x => x.DiscountTypeId == 3).ToList();


            //siblingDiscountType = lstSibling[0].DiscountTypeId;
            //referralDiscountType = lstReferral[0].DiscountTypeId;



           // combobox mode of payment
            PaymentsDTO payments = _paymentService.GetPaymentById(Global.selectedId);

            cmbModeOfPayment.DataSource = _paymentService.GetModeOfPayment();
            cmbModeOfPayment.ValueMember = "ModeOfPaymentId";
            cmbModeOfPayment.DisplayMember = "ModeOfPaymentDesc";
            cmbModeOfPayment.SelectedIndex = 0;

            lblTransactionDate.Text = DateTime.Now.ToShortDateString();
            //combobox payment term (first/second/third/fourth grading)
            

            //load the payments grid
            
            List<PaymentsDTO> lstPayments = _paymentService.GetPaymentsByStudentId(Global.selectedStudent);
            AssessmentDTO assessmentDTO = _assessmentService.GetAssessmentsDTO(Global.selectedStudent);
            var studPaymentBindingList = new BindingList<PaymentsDTO>(lstPayments);
            var studPaymentBindingSource = new BindingSource(studPaymentBindingList, null);

  //###################      singit the textboxex    ######################
            var lstAssessment = _assessmentService.GetAssessment(Global.selectedStudent);
            txtMiscAmountDue.Text = lstAssessment.DeferredMisc.ToString();
            txtTuitionAmountDue.Text = lstAssessment.PaymentPerDue.ToString();
            txtTotalAmount.Text = (Convert.ToDouble(txtMiscAmountDue.Text) + Convert.ToDouble(txtMiscAmountDue.Text)).ToString("#.##");

            //determine due dates
            lstDueDates = _dueDatesService.GetDueDates(lstAssessment.PaymentTerm);
            
            //get high and low for dates
            dateLow= lstDueDates.Where(x=>x.DueDate <= DateTime.Now).
                              OrderBy(x => x.DueDate).LastOrDefault().DueDate;

            dateHigh = lstDueDates.Where(x => x.DueDate >= DateTime.Now).
                             OrderBy(x => x.DueDate).LastOrDefault().DueDate;

            if (lstPayments.Count >= 1)
            {
               // cbTransferee.Checked = assessmentDTO.isTransferree;
                //this is not downpayment
            }
            else //if no payment given yet, 
            {
                cbDownpayment.Checked = true;

                penalizedFee = DateTime.Now > lstDueDates[0].DueDate ? Convert.ToDouble(txtTuitionAmountDue.Text) +
                         ((Convert.ToDouble(txtTuitionAmountDue.Text) / 100) * 3.5) : 0;

                txtPenalty.Text = ((Convert.ToDouble(txtTuitionAmountDue.Text) / 100) * 3.5).ToString("#.##");
                cbTransferee.Checked = false;


               
            }

            //payment term annual or downpayment  and not late for anything (no penalty)                                                    
            if ((lstAssessment.PaymentTerm == 1 || cbDownpayment.Checked == true) && penalizedFee == 0)
            {
                //early bird discount
                TuitionDTO earlyBirdVal = lstDiscount.Where(x => x.DiscountTypeId == 3
                                  && Convert.ToDateTime(x.DiscountParam) >= DateTime.Now).
                                  OrderBy(x => x.DiscountVal).LastOrDefault();

                txtEarlyBird.Text = (Convert.ToDouble(earlyBirdVal.DiscountVal) *
                    (lstAssessment.OriginalAmount)/100).ToString("#.##");

                lblEarlyBird.Visible = true;
                lblEarlyBird.Text = "Early Bird for " + Convert.ToDateTime(earlyBirdVal.DiscountParam).ToShortDateString()
                 + " ," + (earlyBirdVal.DiscountVal) + "%";


                txtTotalAmount.Text = (Convert.ToDouble(txtPenalty.Text) + Convert.ToDouble(txtTotalAmount.Text)
                                      - Convert.ToDouble(txtEarlyBird.Text)).ToString("#.##");


            }
            else
            {
                lblEarlyBird.Visible = false;
                txtTotalAmount.Text = (Convert.ToDouble(txtPenalty.Text) + Convert.ToDouble(txtTotalAmount.Text) + Convert.ToDouble(txtMiscAmountDue.Text)).ToString("#.##");


            }
            //txtTotalAmountBal.Text = (lstAssessment.FullAmount - (Convert.ToDouble(txtAmount.Text))).ToString("#.##"); 


            txtTotalRemainingBal.Text = (lstAssessment.FullAmount).ToString("#.##");
            PaymentsDTO lastPayment = lstPayments.LastOrDefault();

            //txtRemainingMiscBal.Text =Convert.ToDouble(txtMiscAmountDue.Text) - lastPayment.
 //####################/till here                    #######################


            
            pbStudent.Image = Image.FromFile(lstAssessment.path);

            dgvStudentPayments.AutoGenerateColumns = false;

            dgvStudentPayments.ColumnCount = 6;

            dgvStudentPayments.Columns[0].Name = "colAmount";
            dgvStudentPayments.Columns[0].HeaderText = "Amount";
            dgvStudentPayments.Columns[0].DataPropertyName = "Amount";

            //dgvStudentPayments.Columns[1].Name = "colBank";
            //dgvStudentPayments.Columns[1].HeaderText = "Bank";
            //dgvStudentPayments.Columns[1].DataPropertyName = "BankName";

            dgvStudentPayments.Columns[1].Name = "colModeOfPayment";
            dgvStudentPayments.Columns[1].HeaderText = "Mode Of Payment";
            dgvStudentPayments.Columns[1].DataPropertyName = "ModeOfPayment";   

            dgvStudentPayments.Columns[2].Name = "colTransactionDate";
            dgvStudentPayments.Columns[2].HeaderText = "Transaction Date";
            dgvStudentPayments.Columns[2].DataPropertyName = "TransactionDate";

            dgvStudentPayments.Columns[3].Name = "colRemaniningBalance";
            dgvStudentPayments.Columns[3].HeaderText = "Remaining Balance";
            dgvStudentPayments.Columns[3].DataPropertyName = "Balance";

            dgvStudentPayments.Columns[4].Name = "colOriginalBalance";
            dgvStudentPayments.Columns[4].HeaderText = "Original Balance";
            dgvStudentPayments.Columns[4].DataPropertyName = "OriginalBalance";

            dgvStudentPayments.DataSource = studPaymentBindingSource;

            //fill the textboxes
            txtStudentName.Text = assessmentDTO.FirstName  + " " + assessmentDTO.MiddleName.ToString() +  " " + assessmentDTO.LastName.ToString();
            txtStudentNo.Text = assessmentDTO.StudentNo;

            //txtBalance.Text = lstPayments[lstPayments.Count - 1].Balance.ToString();

            //load payment term

            //cmbPaymentTerm.DataSource = _paymentService.GetDateParameters();
            //cmbPaymentTerm.ValueMember = "DateParameterId";
            //cmbPaymentTerm.DisplayMember = "DatesDescription";
            //cmbPaymentTerm.SelectedIndex = -1;



          
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //check if downpayment
            if (cbDownpayment.Checked == true)
            {
                //penalizedfee = datetime.now > lstduedates[0].duedate ? convert.todouble(txttuitionamountdue.text) +
                //         ((convert.todouble(txttuitionamountdue.text)/100) * 3.5) : 0;
            }
            //till here

            _paymentService.SavePayment(Global.selectedId, Convert.ToDecimal(txtAmount.Text),
                Convert.ToInt32(cmbModeOfPayment.SelectedValue), Convert.ToInt32(txtChequeNo.Text),
                 cbDownpayment.Checked,  cbPromisory.Checked);

            MessageBox.Show("Payment Saved");
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void cmbModeOfPayment_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbModeOfPayment.SelectedValue.ToString() == "1")
            {
                lblChequeNo.Visible = false;
                txtChequeNo.Visible = false;
            }
            else if (cmbModeOfPayment.SelectedValue.ToString() == "2")
            {
                lblChequeNo.Visible = true;
                txtChequeNo.Visible = true;

            }
        }

        private void cmbModeOfPayment_SelectionChangeCommitted(object sender, EventArgs e)
        {
           
        }

        private void cmbModeOfPayment_SelectedValueChanged(object sender, EventArgs e)
        {
            //if (cmbModeOfPayment.SelectedValue.ToString() == "1")
            //{
            //    lblChequeNo.Visible = false;
            //    txtChequeNo.Visible = false;
            //}
            //else if (cmbModeOfPayment.SelectedValue.ToString() == "2")
            //{
            //    lblChequeNo.Visible = true;
            //    txtChequeNo.Visible = true;

            //}
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtChequeNo_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblChequeNo_Click(object sender, EventArgs e)
        {

        }

        private void txtStudentName_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void cmbScholarship_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void grpTuition_Enter(object sender, EventArgs e)
        {

        }

        private void txtAmount_TextChanged(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txtAmount.Text))
            {
                txtTotalRemainingBal.Text = (Convert.ToDouble(txtTotalRemainingBal.Text) - Convert.ToDouble(txtAmount.Text)).ToString("#.##");
            }
        }

        private void txtTotalRemainingBal_TextChanged(object sender, EventArgs e)
        {

           

        }
    }
}
