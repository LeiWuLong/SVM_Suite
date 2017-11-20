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
using SVM_Logic;
using SVM_Contracts;

namespace SVM_Suite
{
    public partial class FrmUserAccessMaintenance : Form
    {
        public FrmUserAccessMaintenance()
        {

            InitializeComponent();


        }

        const int attempts = 0;
        const bool isLocked = false;
        const bool isActive = true;
        const bool isDeleted = false;
        int userId;

        IUserAccessService _userAccessService = new UserAccessService();
        IUserService _userService = new UserService();
        List<tblaccess> lstAccess = new List<tblaccess>();

        private void btnSave_Click(object sender, EventArgs e)
        {
            tbluseraccess employee = _userAccessService.GetAccess(Global.loggedUserId);

            //check if no blanks
            if ( txtCurrentPassword.Text != string.Empty
                && txtNewPassword.Text != string.Empty
                && txtRepeatPassword.Text != string.Empty
                )
            {
                if (txtCurrentPassword.Text.Trim() != employee.Password)
                {
                    MessageBox.Show("Incorrect Password");

                }
                else
                {
                    if (txtNewPassword.Text.Trim() != txtRepeatPassword.Text.Trim())
                    {
                        MessageBox.Show("Passwords do not match");
                        txtNewPassword.Focus();
                    }
                    else
                    {
                        _userAccessService.UpdatePassword(Global.loggedUserId, txtNewPassword.Text.Trim());
                        MessageBox.Show("Password Updated");
                        this.Close();
                    }
                }


                
              
                

                

              
            } //else do not insert
            else
            {
                

            }
        }

        private void frmUserMaintenance_Load(object sender, EventArgs e)
        {
            //specify combobox properties

           



            // SVMContext svmContext = new SVMContext();

            //lstAccess = _userAccessService.LoadAccess();

            //ddlAccessLevel.DataSource = lstAccess;
            //ddlAccessLevel.ValueMember = "AccessId";
            //ddlAccessLevel.DisplayMember = "AccessName";

            //validate fields , if satisfied then proceed with insert

            //if (Global.loggedUserAccess == 1) //1 is admin
            //{
            //    cmbEmployeeNo.DataSource = _userAccessService.LoadUsers();
            //    cmbEmployeeNo.ValueMember = "UserId";
            //    cmbEmployeeNo.DisplayMember = "EmployeeNo";
            //    cmbEmployeeNo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            //    cmbEmployeeNo.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            //    cmbEmployeeNo.AutoCompleteSource = AutoCompleteSource.ListItems;
            //}
            //else
            //{
            //    cmbEmployeeNo.DataSource = _userAccessService.GetSelectedUser(Global.loggedUserId);
            //    cmbEmployeeNo.ValueMember = "UserId";
            //    cmbEmployeeNo.DisplayMember = "EmployeeNo";
            //    cmbEmployeeNo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            //    cmbEmployeeNo.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            //    cmbEmployeeNo.AutoCompleteSource = AutoCompleteSource.ListItems;
            //}
            
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            
        }

        private void cmbEmpNo_KeyDown(object sender, KeyEventArgs e)
        {
            //if (e.KeyCode == Keys.Enter)
            //{
            //    if (!string.IsNullOrEmpty(cmbEmployeeNo.SelectedValue.ToString()))
            //    {
            //        userId = _userAccessService.GetSelectedUser(Convert.ToInt32(cmbEmployeeNo.SelectedValue));
            //        if (userId == 0)
            //        {
            //            //non existing emp no, for saving logic
            //            txtCurrentPassword.Focus();                    }
            //        else
            //        {
            //            //if valid existing employee number for edit
                       

            //        }
            //    }
            //    else
            //    {

            //    }
            //}
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtCurrentPassword.Clear();
            txtRepeatPassword.Clear();
            txtRepeatPassword.Clear();
        }

        private void txtCurrentPassword_Validated(object sender, EventArgs e)
        {
            var txt = (TextBox)sender;
            if (string.IsNullOrWhiteSpace(txtCurrentPassword.Text))
            {
                errorProvider1.SetError(txt, "Please fill required fields");
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_Validated(object sender, EventArgs e)
        {
            var txt = (TextBox)sender;
            if (string.IsNullOrWhiteSpace(txtCurrentPassword.Text))
            {
                errorProvider1.SetError(txt, "Please fill required fields");
            }
        }

        private void txtRepeatPassword_TextChanged(object sender, EventArgs e)
        {
            var txt = (TextBox)sender;
            if (string.IsNullOrWhiteSpace(txtCurrentPassword.Text))
            {
                errorProvider1.SetError(txt, "Please fill required fields");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //make clear
    }
}
