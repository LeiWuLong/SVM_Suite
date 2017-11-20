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
using SVM_Processor.Models;
using SVM_Processor.DTO;
using SVM_Logic;

namespace SVM_Suite
{
    public partial class FrmPaymentListing : Form
    {
        public FrmPaymentListing()
        {
            InitializeComponent();
        }


        IPaymentService _paymentService = new PaymentService();
        //List<StudentListingDTO> lstStudents = new List<StudentListingDTO>();

        private void FrmPaymentListing_Load(object sender, EventArgs e)
        {
            try
            {
                rbStudentName.Checked = true;
                List<PaymentsDTO> lstPayments = _paymentService.GetAssessmentListing();
                var paymentBindingList = new BindingList<PaymentsDTO>(lstPayments);
                var paymentgLoadPaymentSource = new BindingSource(paymentBindingList, null);
                dgLoadPayment.Columns.Clear();  
               
                dgLoadPayment.AutoGenerateColumns = false;
                dgLoadPayment.ColumnCount = 5;

                dgLoadPayment.Columns[0].Name = "colStudentNo";
                dgLoadPayment.Columns[0].HeaderText = "Student Number";
                dgLoadPayment.Columns[0].DataPropertyName = "StudentNo";

                dgLoadPayment.Columns[1].Name = "colFirstName";
                dgLoadPayment.Columns[1].HeaderText = "First Name";
                dgLoadPayment.Columns[1].DataPropertyName = "FirstName";

                dgLoadPayment.Columns[2].Name = "colMiddleName";
                dgLoadPayment.Columns[2].HeaderText = "Middle Name";
                dgLoadPayment.Columns[2].DataPropertyName = "MiddleName";

                dgLoadPayment.Columns[3].Name = "colLastName";
                dgLoadPayment.Columns[3].HeaderText = "Last  Name";
                dgLoadPayment.Columns[3].DataPropertyName = "LastName";

                dgLoadPayment.Columns[4].Name = "colStudentId";
                dgLoadPayment.Columns[4].DataPropertyName = "StudentId";
                dgLoadPayment.Columns[4].Visible = false;

                dgLoadPayment.DataSource = paymentgLoadPaymentSource;

                //dgLoadPayment.Columns["StudentId"].Visible = false;
                //dgLoadPayment.Columns["PaymentId"].Visible = false;
                //dgLoadPayment.Columns["StudentNo"].HeaderText = "Student Number";
                //dgLoadPayment.Columns["FirstName"].HeaderText = "First Name";
                //dgLoadPayment.Columns["MiddleName"].HeaderText = "Middle Name";
                //dgLoadPayment.Columns["LastName"].HeaderText = "Last Name";
                dgLoadPayment.ReadOnly = true;

                lblSearchBy.Focus();
                //dgLoadStudents.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            }
            catch (Exception ex)
            {

            }
            finally
            {
                //dgLoadStudents.Rows[1].Selected = false;
                //shouldSkip = false;
                //isFromLoad = true;

            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            FrmPaymentMaintenance frmPaymentMaintenance = new FrmPaymentMaintenance();
            frmPaymentMaintenance.Show();
        }

        private void dgLoadPayment_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgLoadPayment_DoubleClick(object sender, EventArgs e)
        {
            int selectedrowindex = dgLoadPayment.SelectedCells[0].RowIndex;

            DataGridViewRow selectedRow = dgLoadPayment.Rows[selectedrowindex];

            //dont need you
           // int selectedPayment = Convert.ToInt32(selectedRow.Cells["PaymentId"].Value);
            
            Global.selectedStudent = Convert.ToInt32(selectedRow.Cells["colStudentId"].Value);
          //  Global.selectedId = selectedPayment;
            Global.isEdit = true;


            Type type = Type.GetType("SVM_Suite." + Global.formToOpen);
            Form instance = (Form)Activator.CreateInstance(type);

            instance.ShowDialog();

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
