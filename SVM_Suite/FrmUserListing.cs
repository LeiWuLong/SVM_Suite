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
using SVM_Processor.DTO;

namespace SVM_Suite
{
    public partial class FrmUserListing : Form
    {
        public FrmUserListing()
        {
            InitializeComponent();
        }

        IUserService _userService = new UserService();
        List<UserListingDTO> lstUsers = new List<UserListingDTO>();
        bool shouldSkip = true;
        bool isFromLoad = false;
        

        private void dgLoadEmployees_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FrmUserListing_Load(object sender, EventArgs e)
        {

            try
            {
                rbEmployeeName.Checked = true;
                lstUsers = _userService.LoadUserListing();
                var userBindingList = new BindingList<UserListingDTO>(lstUsers);
                var userBindingSource = new BindingSource(userBindingList, null);
                dgLoadEmployees.Columns.Clear();
                dgLoadEmployees.DataSource = userBindingSource;
                dgLoadEmployees.Columns["UserId"].Visible = false;
                dgLoadEmployees.Columns["EmployeeNo"].HeaderText = "Student Number";
                dgLoadEmployees.Columns["FirstName"].HeaderText = "First Name";
                dgLoadEmployees.Columns["MiddleName"].HeaderText = "Middle Name";
                dgLoadEmployees.Columns["LastName"].HeaderText = "Last Name";
                dgLoadEmployees.ReadOnly = true;

                lblSearchBy.Focus();
                dgLoadEmployees.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            }
            catch (Exception ex)
            {

            }
            finally
            {
                dgLoadEmployees.Rows[1].Selected = false;
                shouldSkip = false;
                isFromLoad = true;

            }
        }

        private void dgLoadEmployees_DoubleClick(object sender, EventArgs e)
        {
            int selectedrowindex = dgLoadEmployees.SelectedCells[0].RowIndex;

            DataGridViewRow selectedRow = dgLoadEmployees.Rows[selectedrowindex];

            int selectedUser = Convert.ToInt32(selectedRow.Cells["UserId"].Value);

            Global.selectedUser = selectedUser;
            Global.isUserEdit = true;

            FrmUserMaintenance frmUserMaintenance = new FrmUserMaintenance();
            frmUserMaintenance.ShowDialog();
        }

        private void rbEmployeeName_CheckedChanged(object sender, EventArgs e)
        {
            if (rbEmployeeName.Checked == true)
            {
                rbEmployeeNo.Checked = false;
            }
            else if (rbEmployeeNo.Checked == true)
            {
                rbEmployeeName.Checked = false;
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if (rbEmployeeNo.Checked == true)
            {   
                
                lstUsers = _userService.LoadUsersByEmpNo(txtSearch.Text.Trim());
                var studentBindingList = new BindingList<UserListingDTO>(lstUsers);
                var studentBindingSource = new BindingSource(studentBindingList, null);
                dgLoadEmployees.Columns.Clear();
                dgLoadEmployees.DataSource = studentBindingSource;
                dgLoadEmployees.Columns["UserId"].Visible = false;
                dgLoadEmployees.Columns["EmployeeNo"].HeaderText = "Student Number";
                dgLoadEmployees.Columns["FirstName"].HeaderText = "First Name";
                dgLoadEmployees.Columns["MiddleName"].HeaderText = "Middle Name";
                dgLoadEmployees.Columns["LastName"].HeaderText = "Last Name";
                dgLoadEmployees.ReadOnly = true;
            }
            else if (rbEmployeeName.Checked == true)
            {
                lstUsers = _userService.LoadUsersByName(txtSearch.Text.Trim());
                var studentBindingList = new BindingList<UserListingDTO>(lstUsers);
                var studentBindingSource = new BindingSource(studentBindingList, null);
                dgLoadEmployees.Columns.Clear();
                dgLoadEmployees.DataSource = studentBindingSource;
                dgLoadEmployees.Columns["UserId"].Visible = false;
                dgLoadEmployees.Columns["EmployeeNO"].HeaderText = "Student Number";
                dgLoadEmployees.Columns["FirstName"].HeaderText = "First Name";
                dgLoadEmployees.Columns["MiddleName"].HeaderText = "Middle Name";
                dgLoadEmployees.Columns["LastName"].HeaderText = "Last Name";
                dgLoadEmployees.ReadOnly = true;
            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            Global.isUserEdit = false;
            FrmUserMaintenance frmUserMaintenance = new FrmUserMaintenance();
            frmUserMaintenance.ShowDialog();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {

        }
    }
}
