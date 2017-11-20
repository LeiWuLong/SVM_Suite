using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SVM_Processor.Models;
using SVM_Contracts;
using SVM_Logic;
namespace SVM_Suite
{
    public partial class FrmDueDateMaintenance : Form
    {
        public FrmDueDateMaintenance()
        {
            InitializeComponent();
        }

        IDueDatesService _dueDatesService = new DueDatesService();
        IPaymentService _paymentService = new PaymentService();
        List<tblduedates> lstDueDates = new List<tblduedates>();

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmDueDateMaintenance_Load(object sender, EventArgs e)
        {
            //set label
            lblDesc.Text = "Please set the corresponding due dates and description for each payment term";


            //load combobox
            cmbPaymentTerm.DataSource = _paymentService.GetPaymentTerms();
            cmbPaymentTerm.ValueMember = "PaymentTermId";
            cmbPaymentTerm.DisplayMember = "PaymentDesc";
            cmbPaymentTerm.SelectedIndex = -1;
            cmbPaymentTerm.Text = "--Select Payment Term---";

            //load gridview
            dgvDueDates.AutoGenerateColumns = false;
            dgvDueDates.ColumnCount = 3;
            dgvDueDates.Columns[1].Width = 200;
            dgvDueDates.Columns[2].Width = 200;

            dgvDueDates.Columns[1].Name = "Dates Description";
            dgvDueDates.Columns[2].Name = "Due Date";

            dgvDueDates.Columns[0].Visible = false;

        }

        private void cmbPaymentTerm_SelectionChangeCommitted(object sender, EventArgs e)
        {
            lstDueDates = _dueDatesService.GetDueDates(Convert.ToInt32(cmbPaymentTerm.SelectedValue));
            var dueDatesBindingList = new BindingList<tblduedates>(lstDueDates);
            var dueDatesSource = new BindingSource(dueDatesBindingList, null);
           

            //dgvDueDates.AutoGenerateColumns = false;
            //dgvDueDates.ColumnCount = lstDueDates==null ||lstDueDates.Count==0?  0:3;

            dgvDueDates.Columns[0].Name = "DueDatesId";
            dgvDueDates.Columns[0].Visible = false;
            dgvDueDates.Columns[0].DataPropertyName = "DueDatesId";

            dgvDueDates.Columns[1].Name = "Dates Description";
            dgvDueDates.Columns[1].Visible = true;
            dgvDueDates.Columns[1].DataPropertyName = "DueDateDesc";
            dgvDueDates.Columns[1].Width = 200;


            dgvDueDates.Columns[2].Name = "Due Date";
            dgvDueDates.Columns[2].Visible = true;
            dgvDueDates.Columns[2].DataPropertyName = "DueDate";
            dgvDueDates.Columns[2].Width = 200;

           
            dgvDueDates.DataSource = dueDatesSource;

        }
    }
}
