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
using SVM_Logic;

namespace SVM_Suite
{
    public partial class FrmVendorListing : Form
    {
       
        public FrmVendorListing()
        {
            InitializeComponent();
        }


        IVendorService _vendorService = new VendorService();

        private void dgLoadVendors_DoubleClick(object sender, EventArgs e)
        {
            int selectedrowindex = dgLoadVendors.SelectedCells[0].RowIndex;

            DataGridViewRow selectedRow = dgLoadVendors.Rows[selectedrowindex];

            int selectedVendor = Convert.ToInt32(selectedRow.Cells["VendorId"].Value);

            Global.selectedId = selectedVendor;
            Global.isEdit = true;


            Type type = Type.GetType("SVM_Suite." + Global.formToOpen);
            Form instance = (Form)Activator.CreateInstance(type);

            instance.ShowDialog(this);

            //FrmStudentInformation frmStudentInfo = new FrmStudentInformation();
            //frmStudentInfo.Show();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            Global.selectedId = 0;
            Global.isEdit = false;

            FrmVendorMaintenance frmVendorMaintenance = new FrmVendorMaintenance();
            frmVendorMaintenance.ShowDialog();
        }

        private void FrmVendorListing_Load(object sender, EventArgs e)
        {
            try
            {
                LoadVendors();

                lblSearchBy.Focus();


                //load items




            }
            catch (Exception ex)
            {

            }
            finally
            {
                // dgLoadStudents.Rows[1].Selected = false;
                // shouldSkip = false;
                //isFromLoad = true;

            }
        }

        private void rbName_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if (rbVendorName.Checked == true)
            {
                //if by name
                List<tblvendor> lstVendor = _vendorService.GetVendorsByName(txtSearch.Text);
                var vendorBindingList = new BindingList<tblvendor>(lstVendor);
                var vendorBindingSource = new BindingSource(vendorBindingList, null);
                dgLoadVendors.Columns.Clear();
                dgLoadVendors.DataSource = vendorBindingSource;
                dgLoadVendors.Columns["VendorId"].Visible = false;
                dgLoadVendors.Columns["VendorCode"].HeaderText = "Vendor Code";
                dgLoadVendors.Columns["VendorName"].HeaderText = "Vendor Name";
                dgLoadVendors.Columns["IsDeleted"].Visible = false;
                //dgLoadVendors.Columns["MiddleName"].HeaderText = "Middle Name";
                //dgLoadVendors.Columns["LastName"].HeaderText = "Last Name";
                dgLoadVendors.ReadOnly = true;
            }
            else
            {
                //if by code
                List<tblvendor> lstVendor = _vendorService.GetVendorsByCode(txtSearch.Text);
                var vendorBindingList = new BindingList<tblvendor>(lstVendor);
                var vendorBindingSource = new BindingSource(vendorBindingList, null);
                dgLoadVendors.Columns.Clear();
                dgLoadVendors.DataSource = vendorBindingSource;
                dgLoadVendors.Columns["VendorId"].Visible = false;
                dgLoadVendors.Columns["VendorCode"].HeaderText = "Vendor Code";
                dgLoadVendors.Columns["VendorName"].HeaderText = "Vendor Name";
                dgLoadVendors.Columns["IsDeleted"].Visible = false;
                //dgLoadVendors.Columns["MiddleName"].HeaderText = "Middle Name";
                //dgLoadVendors.Columns["LastName"].HeaderText = "Last Name";
                dgLoadVendors.ReadOnly = true;
            }
        }

        private void lblSearchBy_Click(object sender, EventArgs e)
        {

        }

        private void dgLoadVendors_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void rbVendorName_CheckedChanged(object sender, EventArgs e)
        {
            if (rbVendorName.Checked == true)
            {
                rbVendorCode.Checked = false;
            }
        }

        private void rbVendorCode_CheckedChanged(object sender, EventArgs e)
        {
            if (rbVendorCode.Checked == true)
            {
                rbVendorName.Checked = false;
            }
        }

        public void LoadVendors()
        {
            rbVendorName.Checked = true;
            List<tblvendor> lstVendor = _vendorService.GetVendors();
            var vendorBindingList = new BindingList<tblvendor>(lstVendor);
            var vendorBindingSource = new BindingSource(vendorBindingList, null);
            dgLoadVendors.Columns.Clear();
            dgLoadVendors.DataSource = vendorBindingSource;
            dgLoadVendors.Columns["VendorId"].Visible = false;
            dgLoadVendors.Columns["VendorCode"].HeaderText = "Vendor Code";
            dgLoadVendors.Columns["VendorName"].HeaderText = "Vendor Name";
            dgLoadVendors.Columns["IsDeleted"].Visible = false;
            //dgLoadVendors.Columns["MiddleName"].HeaderText = "Middle Name";
            //dgLoadVendors.Columns["LastName"].HeaderText = "Last Name";
            dgLoadVendors.ReadOnly = true;
            FrmVendorListing frmVendorListing = new FrmVendorListing();
            frmVendorListing.Refresh();
        }
    }
}