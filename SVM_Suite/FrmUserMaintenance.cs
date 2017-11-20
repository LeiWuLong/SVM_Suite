using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SVM_Logic;
using SVM_Processor.Models;
using SVM_Contracts;
using System.IO;

namespace SVM_Suite
{
    public partial class FrmUserMaintenance : Form
    {
        public FrmUserMaintenance()
        {
            InitializeComponent();

        }

        IUserService _userService = new UserService();
        IUserAccessService _userAccessService = new UserAccessService();
        int userId;
        int lastUserId;
        const string defaultImage = @"D:\Projects\dotnet\SVM_Suite\SVM_Suite\SVM_Contracts\imgresource\images.png";
        string newPath;

        List<tblaccess> lstAccess = new List<tblaccess>();

        private void FrmUserMaintenance_Load(object sender, EventArgs e)
        {
            btnEdit.Visible = false;

            lstAccess = _userAccessService.LoadAccess();

            cmbAccessLevel.DataSource = lstAccess;
            cmbAccessLevel.ValueMember = "AccessId";
            cmbAccessLevel.DisplayMember = "AccessName";

            if (Global.isUserEdit == true)
            {
                //edit user
                //if valid existing employee number for edit
                tbluser empDetails = new tbluser();
                tbluseraccess empUserAccess = new tbluseraccess();
                empDetails = _userService.GetEmployee(Global.selectedUser);
                empUserAccess = _userAccessService.GetAccess(Global.selectedUser);


                cmbAccessLevel.SelectedValue = empUserAccess.AccessId;
                txtUsername.Text = empDetails.UserId.ToString();
                txtEmpNo.Text = empDetails.EmployeeNo;
                txtContact.Text = empDetails.MobileNo;
                txtFirstName.Text = empDetails.FirstName;
                txtMiddleName.Text = empDetails.MiddleName;
                txtLastName.Text = empDetails.LastName;
                                // cmbSuffix.SelectedValue = empDetails.Suffix;
                txtEmail.Text = empDetails.Email;
                txtContact.Text = empDetails.MobileNo;

                //disable the fields
                txtEmpNo.Enabled = false;
                txtFirstName.Enabled = false;
                txtMiddleName.Enabled = false;
                txtLastName.Enabled = false;
                txtEmail.Enabled = false;
                txtContact.Enabled = false;
                txtUsername.Enabled = false;
                btnUpload.Enabled = false;
                //cmbSuffix.Enabled = false;
                pbUserImage.Image = Image.FromFile(String.IsNullOrEmpty(empDetails.Path) ? defaultImage : empDetails.Path);
                btnSave.Hide();
                btnEdit.Show();


            }
            else if (Global.isUserEdit == false)
            {
                //new input
                pbUserImage.Image = Image.FromFile(@"D:\Projects\dotnet\SVM_Suite\SVM_Suite\SVM_Contracts\imgresource\images.png");
                

                lstAccess = _userAccessService.LoadAccess();
                cmbAccessLevel.Enabled = true;

                txtEmpNo.Focus();
            }

            //cmbEmployeeNo.DataSource = _userService.LoadUsers();
            //cmbEmployeeNo.Enabled = true;



            btnEdit.Show();
            btnSave.Hide();

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }
        private void cmbEmployeeNo_SelectedIndexChanged(object sender, EventArgs e)
        {
           // MessageBox.Show("changed!");
        }

        private void cmbEmployeeNo_KeyPress(object sender, KeyPressEventArgs e)
        {

           
        }

        private void cmbEmployeeNo_KeyDown(object sender, KeyEventArgs e)
        {

            //if (e.KeyCode == Keys.Enter)
            //{
            //    if (cmbEmployeeNo.SelectedValue!=null)
            //    {
            //        userId = _userService.GetSelectedUser(Convert.ToInt32(cmbEmployeeNo.SelectedValue));
            //        if (userId == 0)
            //        {
            //            //non existing emp no, for saving logic
            //            txtFirstName.Focus();
            //        }
            //        else
            //        {
            //            //if valid existing employee number for edit
            //            tbluser empDetails = new tbluser();
            //            tbluseraccess empUserAccess = new tbluseraccess();
            //            empDetails= _userService.GetEmployee((Convert.ToInt32(cmbEmployeeNo.SelectedValue)));
            //            empUserAccess = _userAccessService.GetAccess((Convert.ToInt32(cmbEmployeeNo.SelectedValue)));


            //            cmbAccessLevel.SelectedValue = empUserAccess.AccessId;
            //            txtFirstName.Text = empDetails.FirstName;
            //            txtMiddleName.Text = empDetails.MiddleName;
            //            txtLastName.Text = empDetails.LastName;
            //           // cmbSuffix.SelectedValue = empDetails.Suffix;
            //            txtEmail.Text = empDetails.Email;
            //            txtContact.Text = empDetails.MobileNo;

            //            //disable the fields

            //            txtFirstName.Enabled = false;
            //            txtMiddleName.Enabled = false;
            //            txtLastName.Enabled = false;
            //            txtEmail.Enabled = false;
            //            txtContact.Enabled = false;
            //            txtUsername.Enabled = false;
            //            btnUpload.Enabled = false;
            //            //cmbSuffix.Enabled = false;
            //            pbUserImage.Image = Image.FromFile(String.IsNullOrEmpty(empDetails.Path)?defaultImage:empDetails.Path);
            //            btnSave.Hide();
            //            btnEdit.Show();
            //        }
            //    }
            //    else
            //    {

            //    }
            //}
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (Global.isUserEdit == true)
            {
                if (string.IsNullOrEmpty(txtEmpNo.Text))
                {
                    //this is for saving
                    DialogResult dialogSave = MessageBox.Show("Proceed with saving?", "Save User", MessageBoxButtons.YesNo);
                    if (dialogSave == DialogResult.Yes)
                    {

                        //save user
                        lastUserId = _userService.SaveUser(txtFirstName.Text, txtMiddleName.Text,
                            txtLastName.Text, txtContact.Text, txtEmail.Text,
                            null, Global.loggedUserId, DateTime.Now, null, null, !String.IsNullOrEmpty(newPath) ? newPath : defaultImage);


                        //give user access
                        _userAccessService.SaveUserAccess(Convert.ToInt32(cmbAccessLevel.SelectedValue), lastUserId, txtUsername.Text, txtPassword.Text.Trim(), 0, false, true, DateTime.Now,
                            Global.loggedUserId, null, false);

                        MessageBox.Show("User has been created");
                        Global.isUserEdit = false;

                    }
                }

                else
                {

                    //this is for update
                    DialogResult dialogUpdate = MessageBox.Show("User has been edited. Save changes?", "Edit User", MessageBoxButtons.YesNo);
                    if (dialogUpdate == DialogResult.Yes)
                    {
                        //this is update
                        _userService.UpdateUser(txtEmpNo.Text.Trim(), txtFirstName.Text, txtMiddleName.Text,
                            txtLastName.Text, txtContact.Text, txtEmail.Text,
                            null, null, null, DateTime.Now, Global.loggedUserId, Global.selectedUser
                            , !String.IsNullOrEmpty(newPath) ? newPath : defaultImage);
                        MessageBox.Show("User has been updated");
                        //update access
                        //_userAccessService.UpdateUserAccess(Convert.ToInt32(cmbAccessLevel.SelectedValue), Convert.ToInt32(cmbEmployeeNo.SelectedValue),
                        //    txtUsername.Text, "password",0,
                        //    false, true, null, null, Global.loggedUserId, false);
                    }
                    else if (dialogUpdate == DialogResult.No)
                    {
                        //do nothing

                    }




                }
            }
        }
        

        private void btnDelete_Click(object sender, EventArgs e)
        {
            //if (!string.IsNullOrEmpty(cmbEmployeeNo.SelectedValue.ToString()))
            //{
            //    DialogResult dialogResult = MessageBox.Show("Deleting user cannot be undone. \n Proceed?", "Delete", MessageBoxButtons.YesNo);
            //    if (dialogResult == DialogResult.Yes)
            //    {
            //        //this is update
            //        _userService.DeleteUser(Convert.ToInt32(cmbEmployeeNo.SelectedValue));
                        
            //    }
            //    else if (dialogResult == DialogResult.No)
            //    {
            //        //do nothing

            //    }
            //}
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            
                txtEmpNo.Enabled = true;
                txtFirstName.Enabled = true;
                txtMiddleName.Enabled = true;
                txtLastName.Enabled = true;
                txtEmail.Enabled = true;
                txtContact.Enabled = true;
                txtUsername.Enabled = true;
                btnUpload.Enabled = true;
               // cmbSuffix.Enabled = true;

                btnEdit.Hide();
                btnSave.Show();
            
           
        }

        private void txtFirstName_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmbEmployeeNo_Validated(object sender, EventArgs e)
        {
            var cmb = (ComboBox)sender;
            if (string.IsNullOrWhiteSpace(txtEmpNo.Text))
            {
                errorProvider1.SetError(cmb, "Please fill required fields");
            }
        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                Guid guidId = Guid.NewGuid();
                var fileName = this.openFileDialog1.FileName;
                System.IO.File.Copy(fileName, @"D:\Projects\dotnet\SVM_Suite\SVM_Suite\SVM_Contracts\imgresource\" + Path.GetFileNameWithoutExtension(fileName)+ guidId + ".png");
                newPath = @"D:\Projects\dotnet\SVM_Suite\SVM_Suite\SVM_Contracts\imgresource\" + Path.GetFileNameWithoutExtension(fileName) + guidId + ".png";
                pbUserImage.Image = Image.FromFile(newPath);
            }
        }

        //for validation, use code below

        //        foreach (Control c in this.Controls)
        //{
        //    if (c is TextBox)
        //    {
        //        // your logic here
        //    }
        //}
    }
}
