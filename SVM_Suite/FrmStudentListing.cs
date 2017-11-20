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
    public partial class FrmStudentListing : Form
    {
        public FrmStudentListing()
        {
            InitializeComponent();
        }

        public FrmStudentListing(FrmAssessment frmConstAssess)
        {
            frmVarAssess = frmConstAssess;
            InitializeComponent();
        }

        public delegate void UpdateDelegate(object sender, UpdateEventArgs args);
        public event UpdateDelegate UpdateEventHandler;
        FrmAssessment frmVarAssess;

        IStudentService _studentService = new StudentService();
        List<StudentListingDTO> lstStudents = new List<StudentListingDTO>();
        
        bool shouldSkip = true;
        bool isFromLoad = false;


        public class UpdateEventArgs : EventArgs
        {
            public string Data { get; set; }
        }

        protected void raiseUpdate()
        {
            UpdateEventArgs args = new UpdateEventArgs();
            UpdateEventHandler?.Invoke(this, args);
        }

        private void FrmStudentListing_Load(object sender, EventArgs e)
        {
            try
            {
                rbName.Checked = true;
                lstStudents = _studentService.LoadStudents();
                var studentBindingList = new BindingList<StudentListingDTO>(lstStudents);
                var studentBindingSource = new BindingSource(studentBindingList, null);
                dgLoadStudents.Columns.Clear();
                dgLoadStudents.DataSource = studentBindingSource;
                dgLoadStudents.Columns["StudentId"].Visible = false;
                dgLoadStudents.Columns["StudentNo"].HeaderText = "Student Number";
                dgLoadStudents.Columns["FirstName"].HeaderText = "First Name";
                dgLoadStudents.Columns["MiddleName"].HeaderText = "Middle Name";
                dgLoadStudents.Columns["LastName"].HeaderText = "Last Name";
                dgLoadStudents.ReadOnly = true;

                lblSearchBy.Focus();

                if (Global.formToOpen == "AddStudent" || Global.formToOpen == "AddReferral")
                {
                    btnEdit.Visible = false;
                    btnNew.Visible = false;
                }
                //dgLoadStudents.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            }
            catch (Exception ex)
            {

            }
            finally
            {
                dgLoadStudents.Rows[1].Selected = false;
                shouldSkip = false;
                isFromLoad = true;

            }
        }

        private void dgLoadStudents_SelectionChanged(object sender, EventArgs e)
        {
            // if (shouldSkip == false)
            //{ 
            //         if (dgLoadStudents.SelectedRows.Count > 0)
            //            {

            //            int selectedrowindex = dgLoadStudents.SelectedCells[0].RowIndex;

            //            DataGridViewRow selectedRow = dgLoadStudents.Rows[selectedrowindex];

            //            int selectedStudent = Convert.ToInt32(selectedRow.Cells["StudentId"].Value);

            //            Global.selectedStudent = selectedStudent;

            //            FrmStudentInformation frmStudentInfo = new FrmStudentInformation();
            //            frmStudentInfo.Show();
            //            }
            //}
        }

        private void dgLoadStudents_ReadOnlyChanged(object sender, EventArgs e)
        {
            if (dgLoadStudents.SelectedRows.Count > 0)
            {
                int selectedrowindex = dgLoadStudents.SelectedCells[0].RowIndex;

                DataGridViewRow selectedRow = dgLoadStudents.Rows[selectedrowindex];

                string a = Convert.ToString(selectedRow.Cells["StudentNo"].Value);


            }
        }

        private void dgLoadStudents_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {

            dgLoadStudents.ClearSelection();
            dgLoadStudents.Rows[0].Selected = false;
        }

        private void dgLoadStudents_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            lstStudents = _studentService.LoadStudents();
            var studentBindingList = new BindingList<StudentListingDTO>(lstStudents);
            var studentBindingSource = new BindingSource(studentBindingList, null);
            dgLoadStudents.Columns.Clear();
            dgLoadStudents.DataSource = studentBindingSource;
            dgLoadStudents.Columns["StudentId"].Visible = false;
            dgLoadStudents.Columns["StudentNo"].HeaderText = "Student Number";
            dgLoadStudents.Columns["FirstName"].HeaderText = "First Name";
            dgLoadStudents.Columns["MiddleName"].HeaderText = "Middle Name";
            dgLoadStudents.Columns["LastName"].HeaderText = "Last Name";
            dgLoadStudents.ReadOnly = true;


        }

        private void dgLoadStudents_DoubleClick(object sender, EventArgs e)
        {
            int selectedrowindex = dgLoadStudents.SelectedCells[0].RowIndex;

            DataGridViewRow selectedRow = dgLoadStudents.Rows[selectedrowindex];

            int selectedStudent = Convert.ToInt32(selectedRow.Cells["StudentId"].Value);

            Global.selectedStudent = selectedStudent;
            Global.isStudentEdit = true;

            if(Global.formToOpen.Contains("Frm"))
            { 
                //if double click from student list grid is  *SUPPOSED* to open a window/form
                //like opening 'student info' window upon double click of student

            Type type = Type.GetType("SVM_Suite."+Global.formToOpen);
            Form instance = (Form)Activator.CreateInstance(type);
            instance.ShowDialog();
            }
            else
            {
                //if double click from student list grid is   *NOT*  to open a window/form
                //like adding student name to a list (hence referral and sibling from assessment window)

                // FrmAssessment frmAssessment = new FrmAssessment();

                // frmAssessment.UpdateSiblingGrid();

                raiseUpdate();

            }


            //FrmStudentInformation frmStudentInfo = new FrmStudentInformation();
            //frmStudentInfo.Show();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            //int selectedrowindex = dgLoadStudents.SelectedCells[0].RowIndex;

            //DataGridViewRow selectedRow = dgLoadStudents.Rows[selectedrowindex];

            //int selectedStudent = Convert.ToInt32(selectedRow.Cells["StudentId"].Value);

            //Global.selectedStudent = selectedStudent;

            ////set bool flag
            //Global.isStudentEdit = false;

            //if (Global.formToOpen == "StudentInfo")
            //{
            //    FrmStudentInformation frmStudentInfo = new FrmStudentInformation();
            //    frmStudentInfo.Show();
            //}
            //else if (Global.formToOpen == "Assessment")
            //{
            //    FrmAssessment frmAssessment = new FrmAssessment();
            //    frmAssessment.ShowDialog();
            //}
            FrmStudentInformation frmStudentInformation = new FrmStudentInformation();
            frmStudentInformation.ShowDialog();
        }

        private void rbName_CheckedChanged(object sender, EventArgs e)
        {
            if (rbName.Checked == true)
            {
                rbStudentNo.Checked = false;
            }
        }

        private void rbStudentNo_CheckedChanged(object sender, EventArgs e)
        {
            if (rbStudentNo.Checked == true)
            {
                rbName.Checked = false;
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if (rbName.Checked == true)
            {
                lstStudents = _studentService.LoadStudentsByName(txtSearch.Text.Trim());
                var studentBindingList = new BindingList<StudentListingDTO>(lstStudents);
                var studentBindingSource = new BindingSource(studentBindingList, null);
                dgLoadStudents.Columns.Clear();
                dgLoadStudents.DataSource = studentBindingSource;
                dgLoadStudents.Columns["StudentId"].Visible = false;
                dgLoadStudents.Columns["StudentNo"].HeaderText = "Student Number";
                dgLoadStudents.Columns["FirstName"].HeaderText = "First Name";
                dgLoadStudents.Columns["MiddleName"].HeaderText = "Middle Name";
                dgLoadStudents.Columns["LastName"].HeaderText = "Last Name";
                dgLoadStudents.ReadOnly = true;
            }
            else if (rbStudentNo.Checked == true)
            {
                lstStudents = _studentService.LoadStudentsByNumber(txtSearch.Text.Trim());
                var studentBindingList = new BindingList<StudentListingDTO>(lstStudents);
                var studentBindingSource = new BindingSource(studentBindingList, null);
                dgLoadStudents.Columns.Clear();
                dgLoadStudents.DataSource = studentBindingSource;
                dgLoadStudents.Columns["StudentId"].Visible = false;
                dgLoadStudents.Columns["StudentNo"].HeaderText = "Student Number";
                dgLoadStudents.Columns["FirstName"].HeaderText = "First Name";
                dgLoadStudents.Columns["MiddleName"].HeaderText = "Middle Name";
                dgLoadStudents.Columns["LastName"].HeaderText = "Last Name";
                dgLoadStudents.ReadOnly = true;
            }
        }
    }
}
