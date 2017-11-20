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
    public partial class FrmStudentInformation : Form
    {
        public FrmStudentInformation()
        {
            InitializeComponent();
            this.Controls.Add(pbStudentImage);

        }

        IStudentService _studentService = new StudentService();
        IAssessmentService _assessmentService = new AssessmentService();
        string newPath;
        int newStudentId;

        //declare the variable
        string studentNo;
        string firstName;
        string middleName;
        string lastName;
        string dateOfBirth;
        string placeOfBirth;
        int genderId;
        string religion;
        string citizenship;
        string postalCode;
        string permanentAddress;

        int level;
        string schoolName;
        string schoolyear;
        string awardsReceived;

        int relationshipId;
        string famCitizenship;
        string famReligion;
        string famAddress;
        string famTelNo;
        string famMobileNo;
        string famEmail;
        string famOccupation;
        string famEmployerDetails;

        string famLastSchoolAttended;
        string famYearGraduated;
        string famEducationalAttainment;
        string famName;

        string childsDoctor;
        string doctorsBusinessNameAndAddress;
        string doctorsContact;
        string personToNotify;
        string relationship;
        string address;
        bool immunization;
        string allergies;
        int healthConcernId;
        string conditionHindrance;
        string specialCare;
        bool isEdit = false;

        int famId;
        int educId;

        List<tbldimeducationlevel> lstEducLevel;
        List<tblrelationship> lstRelationship;

        tblstudent student;
        List<tblstudenteducationalbackground> studentEducationalBackground;
        List<tblstudentfamily> studentFamily;
        tblstudenthealthrecord studentHealth;

        DataGridViewComboBoxCell colEmpty;

        const string defaultImage= @"D:\Projects\dotnet\SVM_Suite\SVM_Suite\SVM_Contracts\imgresource\images.png";
        



        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void frmStudentInformation_Load(object sender, EventArgs e)
        {
            pbStudentImage.Image = Image.FromFile(@"D:\Projects\dotnet\SVM_Suite\SVM_Suite\SVM_Contracts\imgresource\images.png");
            var a= pbStudentImage.ImageLocation;
            cmbGender.DataSource = _studentService.GetGender();
            cmbGender.ValueMember = "GenderId";
            cmbGender.DisplayMember = "GenderDesc";
           

            col_cmbLevel.DataSource = _studentService.GetEducationLevel();
            col_cmbLevel.ValueMember = "LevelId";
            col_cmbLevel.DisplayMember = "Level";

            col_cmbRelationship.DataSource = _studentService.GetRelationship();
            col_cmbRelationship.ValueMember = "RelationshipId";
            col_cmbRelationship.DisplayMember = "RelationshipName";

            cmbHealthConcern.DataSource = _studentService.GetHealthConcerns();
            cmbHealthConcern.ValueMember = "HealthConcernId";
            cmbHealthConcern.DisplayMember = "HealthConcernDesc";

            //siblings
            cmbSiblings.DataSource = _studentService.GetSiblings();
            cmbSiblings.ValueMember = "SiblingId";
            cmbSiblings.DisplayMember = "Siblings";
            cmbSiblings.SelectedIndex = -1;

            //honors
            cmbHonors.DataSource = _studentService.GetHonors();
            cmbHonors.ValueMember = "HonorId";
            cmbHonors.DisplayMember = "Honors";
            cmbHonors.SelectedIndex = -1;

            //referrals
            cmbReferrals.DataSource = _studentService.GetReferrals();
            cmbReferrals.ValueMember = "ReferralId";
            cmbReferrals.DisplayMember = "Referral";
            cmbReferrals.SelectedIndex = -1;

            btnEdit.Hide();
            btnSave.Show();

            //if (!String.IsNullOrEmpty(Global.selectedStudent.ToString()))
            if (Global.selectedStudent !=0)
            {
                //if has selected student , load the mofo
                LoadStudent();
            }
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            //######################### SAVING NEW RECORD#############################
            if (Global.isStudentEdit == false)
            {

                firstName = txtFirstName.Text;
                middleName = txtMiddleName.Text;
                lastName = txtLastName.Text;
                dateOfBirth = dpDateOfBirth.Text;
                placeOfBirth = txtPlaceOfBirth.Text;
                genderId = Convert.ToInt32(cmbGender.SelectedValue);
                religion = txtReligion.Text;
                citizenship = txtCitizenship.Text;
                postalCode = txtPostalCode.Text;
                permanentAddress = rtbPermanentAddress.Text;


                //save student
                newStudentId = _studentService.SaveStudent(firstName, middleName, lastName, dateOfBirth,
                    placeOfBirth, Convert.ToInt32(cmbGender.SelectedValue), txtReligion.Text, txtCitizenship.Text, txtPostalCode.Text,
                    rtbPermanentAddress.Text, !String.IsNullOrEmpty(newPath) ? newPath : defaultImage);

                //Aug 14,2017
                //save student to assessment table as 'On Assessment'
                //_assessmentService.InsertStudent(newStudentId,)


                if (newStudentId != 0)
                {
                    //Aug 14,2017
                    //save student to assessment table as 'On Assessment'

                    //student id ,section, validuntil(null as of now) , educationLevel
                    _assessmentService.InsertStudent(newStudentId, 0,null, 0);






                    //save educ background
                    for (int x = 0; x <= dgEducationalBackground.Rows.Count - 2; x++)
                    {

                        level = Convert.ToInt32(dgEducationalBackground.Rows[x].Cells["col_cmbLevel"].Value.ToString());
                        schoolName = dgEducationalBackground.Rows[x].Cells["colSchoolAndAddress"].Value != null ? dgEducationalBackground.Rows[x].Cells["colSchoolAndAddress"].Value.ToString() : string.Empty;
                        schoolyear = dgEducationalBackground.Rows[x].Cells["colSchoolYear"].Value != null ? dgEducationalBackground.Rows[x].Cells["colSchoolYear"].Value.ToString() : string.Empty;
                        awardsReceived = dgEducationalBackground.Rows[x].Cells["colAwardsReceived"].Value != null ? dgEducationalBackground.Rows[x].Cells["colAwardsReceived"].Value.ToString() : String.Empty;

                        //insert the records
                        _studentService.SaveEducationalBackground(level, schoolName, schoolyear, awardsReceived, newStudentId);
                    }


                    //insert family background
                    for (int y = 0; y <= dgFamilyBackground.Rows.Count - 2; y++)
                    {
                        relationshipId = Convert.ToInt32(dgFamilyBackground.Rows[y].Cells["col_cmbRelationship"].Value.ToString());
                        famCitizenship = dgFamilyBackground.Rows[y].Cells["colCitizenship"].Value != null ? dgFamilyBackground.Rows[y].Cells["colCitizenship"].Value.ToString() : string.Empty;
                        famReligion = dgFamilyBackground.Rows[y].Cells["colReligion"].Value != null ? dgFamilyBackground.Rows[y].Cells["colReligion"].Value.ToString() : string.Empty;
                        famAddress = dgFamilyBackground.Rows[y].Cells["colHomeAddress"].Value != null ? dgFamilyBackground.Rows[y].Cells["colHomeAddress"].Value.ToString() : string.Empty;
                        famTelNo = dgFamilyBackground.Rows[y].Cells["colTelNo"].Value != null ? dgFamilyBackground.Rows[y].Cells["colTelNo"].Value.ToString() : string.Empty;
                        famEmail = dgFamilyBackground.Rows[y].Cells["colEmail"].Value != null ? dgFamilyBackground.Rows[y].Cells["colEmail"].Value.ToString() : string.Empty;
                        famOccupation = dgFamilyBackground.Rows[y].Cells["colOccupation"].Value != null ? dgFamilyBackground.Rows[y].Cells["colOccupation"].Value.ToString() : string.Empty;
                        famEmployerDetails = dgFamilyBackground.Rows[y].Cells["colEmployerDetails"].Value != null ? dgFamilyBackground.Rows[y].Cells["colEmployerDetails"].Value.ToString() : string.Empty;
                        famYearGraduated = dgFamilyBackground.Rows[y].Cells["colYearGraduated"].Value != null ? dgFamilyBackground.Rows[y].Cells["colYearGraduated"].Value.ToString() : string.Empty;
                        famEducationalAttainment = dgFamilyBackground.Rows[y].Cells["colEducationalAttainment"].Value != null ? dgFamilyBackground.Rows[y].Cells["colEducationalAttainment"].Value.ToString() : string.Empty;
                        famName = dgFamilyBackground.Rows[y].Cells["colName"].Value.ToString();
                         //cmbStudentNo.DataSource = _studentService.GetAllStudents();
                        //cmbStudentNo.ValueMember = "StudentId";
                        //cmbStudentNo.DisplayMember = "StudentId";
                        //cmbStudentNo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
                        //cmbStudentNo.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                        //cmbStudentNo.AutoCompleteSource = AutoCompleteSource.ListItems;
                        //cmbStudentNo.SelectedIndex = -1;
                        //cmbStudentNo.SelectedValue = 0;
                        _studentService.SaveFamilyBackground(newStudentId, relationshipId, famCitizenship, famReligion, famAddress, famTelNo,
                            famMobileNo, famEmail, famOccupation, famEmployerDetails, famLastSchoolAttended, famYearGraduated, famEducationalAttainment, famName);
                    }

                    //insert health records
                    childsDoctor = txtChildsDoctor.Text;
                    doctorsContact = txtDoctorsContactNo.Text;
                    allergies = txtAllergies.Text;
                    doctorsBusinessNameAndAddress = rtbDoctorBizAddress.Text;
                    healthConcernId = Convert.ToInt32(cmbHealthConcern.SelectedValue);
                    immunization = cbComplete.Checked == true ? true : false;
                    specialCare = rtbSpecialProcedure.Text;

                    _studentService.SaveHealthBackground(newStudentId, childsDoctor, doctorsContact, doctorsBusinessNameAndAddress,
                        immunization, healthConcernId, allergies, conditionHindrance, specialCare);

                }

                MessageBox.Show("Student Saved");
                ClearForm();
            //     cmbStudentNo.DataSource = _studentService.GetAllStudents();
            //cmbStudentNo.ValueMember = "StudentId";
            //cmbStudentNo.DisplayMember = "StudentId";
            //cmbStudentNo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            //cmbStudentNo.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            //cmbStudentNo.AutoCompleteSource = AutoCompleteSource.ListItems;
            //cmbStudentNo.SelectedIndex = -1;
            //    cmbStudentNo.SelectedValue = 0;
            //    cmbStudentNo.Items.Clear();
            }
            //########################### editing new record #################################

            else

            {
                 _studentService.UpdateStudent(Global.selectedStudent,txtFirstName.Text, txtMiddleName.Text, txtLastName.Text, dpDateOfBirth.Text.ToString(),
                    txtPlaceOfBirth.Text, Convert.ToInt32(cmbGender.SelectedValue), txtReligion.Text, txtCitizenship.Text, txtPostalCode.Text,
                    rtbPermanentAddress.Text, !String.IsNullOrEmpty(newPath) ? newPath : defaultImage);

                for (int x = 0; x <= dgEducationalBackground.Rows.Count - 2; x++)
                {

                    level = Convert.ToInt32(dgEducationalBackground.Rows[x].Cells["Level"].Value.ToString());
                    schoolName = dgEducationalBackground.Rows[x].Cells["SchoolName"].Value != null ? dgEducationalBackground.Rows[x].Cells["SchoolName"].Value.ToString() : string.Empty;
                    schoolyear = dgEducationalBackground.Rows[x].Cells["SchoolYear"].Value != null ? dgEducationalBackground.Rows[x].Cells["SchoolYear"].Value.ToString() : string.Empty;
                    awardsReceived = dgEducationalBackground.Rows[x].Cells["AwardsReceived"].Value != null ? dgEducationalBackground.Rows[x].Cells["AwardsReceived"].Value.ToString() : String.Empty;
                    educId = Convert.ToInt32(dgEducationalBackground.Rows[x].Cells["EducLevelId"].Value);
                    //insert the records
                    _studentService.UpdateEducationalBackground(educId,level, schoolName, schoolyear, awardsReceived);
                }


                //insert family background
                for (int y = 0; y <= dgFamilyBackground.Rows.Count - 2; y++)
                {
                    relationshipId = Convert.ToInt32(dgFamilyBackground.Rows[y].Cells["StudentFamilyId"].Value.ToString());
                    famCitizenship = dgFamilyBackground.Rows[y].Cells["Citizenship"].Value != null ? dgFamilyBackground.Rows[y].Cells["citizenship"].Value.ToString() : string.Empty;
                    famReligion = dgFamilyBackground.Rows[y].Cells["Religion"].Value != null ? dgFamilyBackground.Rows[y].Cells["Religion"].Value.ToString() : string.Empty;
                    famAddress = dgFamilyBackground.Rows[y].Cells["Address"].Value != null ? dgFamilyBackground.Rows[y].Cells["Address"].Value.ToString() : string.Empty;
                    famTelNo = dgFamilyBackground.Rows[y].Cells["TelNo"].Value != null ? dgFamilyBackground.Rows[y].Cells["TelNo"].Value.ToString() : string.Empty;
                    famEmail = dgFamilyBackground.Rows[y].Cells["MobileNo"].Value != null ? dgFamilyBackground.Rows[y].Cells["MobileNo"].Value.ToString() : string.Empty;
                    famOccupation = dgFamilyBackground.Rows[y].Cells["Occupation"].Value != null ? dgFamilyBackground.Rows[y].Cells["Occupation"].Value.ToString() : string.Empty;
                    famEmployerDetails = dgFamilyBackground.Rows[y].Cells["EmployerBizAddress"].Value != null ? dgFamilyBackground.Rows[y].Cells["EmployerBizAddress"].Value.ToString() : string.Empty;
                    famYearGraduated = dgFamilyBackground.Rows[y].Cells["YearGraduated"].Value != null ? dgFamilyBackground.Rows[y].Cells["YearGraduated"].Value.ToString() : string.Empty;
                    famEducationalAttainment = dgFamilyBackground.Rows[y].Cells["EducationalAttainment"].Value != null ? dgFamilyBackground.Rows[y].Cells["EducationalAttainment"].Value.ToString() : string.Empty;
                    famName = dgFamilyBackground.Rows[y].Cells["Name"].Value.ToString();
                    famId = Convert.ToInt32(dgFamilyBackground.Rows[y].Cells["StudentFamilyId"].Value.ToString());

                    _studentService.UpdateFamilyBackground(famId, relationshipId, famCitizenship, famReligion, famAddress, famTelNo,
                        famMobileNo, famEmail, famOccupation, famEmployerDetails, famLastSchoolAttended, famYearGraduated, famEducationalAttainment, famName);
                }

                //insert health records
                childsDoctor = txtChildsDoctor.Text;
                doctorsContact = txtDoctorsContactNo.Text;
                allergies = txtAllergies.Text;
                doctorsBusinessNameAndAddress = rtbDoctorBizAddress.Text;
                healthConcernId = Convert.ToInt32(cmbHealthConcern.SelectedValue);
                immunization = cbComplete.Checked == true ? true : false;
                specialCare = rtbSpecialProcedure.Text;

                _studentService.SaveHealthBackground(newStudentId, childsDoctor, doctorsContact, doctorsBusinessNameAndAddress,
                    immunization, healthConcernId, allergies, conditionHindrance, specialCare);

            }
        }
        

        private void btnEdit_Click(object sender, EventArgs e)
        {
            txtFirstName.Enabled = true;
            txtMiddleName.Enabled = true;
            txtLastName.Enabled = true;
            dpDateOfBirth.Enabled = true;
            txtPlaceOfBirth.Enabled = true;
            cmbGender.Enabled = true;
            txtReligion.Enabled = true;
            txtCitizenship.Enabled = true;
            txtPostalCode.Enabled = true;
            rtbPermanentAddress.Enabled = true;
            btnUpload.Enabled = true;

            dgEducationalBackground.Enabled = true;
            dgFamilyBackground.Enabled = true;

            txtChildsDoctor.Enabled = true;
            txtDoctorsContactNo.Enabled = true;
            txtAllergies.Enabled = true;
            rtbDoctorBizAddress.Enabled = true;
            cbComplete.Enabled = true;
            cbIncomplete.Enabled = true;
            cmbHealthConcern.Enabled = true;


            rtbSpecialProcedure.Enabled = true;
            btnEdit.Hide();
            btnSave.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lblCaringSpecialProcedure_Click(object sender, EventArgs e)
        {

        }

        private void dgEducationalBackground_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void cmbStudentNo_SelectedIndexChanged(object sender, EventArgs e)
        {
 #region removedStudentInfoRendering
            //            int result;


            //            if (cmbStudentNo.SelectedValue != null)
            //            {
            


            //                if (int.TryParse(cmbStudentNo.SelectedValue.ToString(), out result))
            //                {
            //                    //disable buttons------------
            //                    txtFirstName.Enabled = false;
            //                    txtMiddleName.Enabled = false;
            //                    txtLastName.Enabled = false;
            //                    dpDateOfBirth.Enabled = false;
            //                    txtPlaceOfBirth.Enabled = false;
            //                    cmbGender.Enabled = false;
            //                    txtReligion.Enabled = false;
            //                    txtCitizenship.Enabled = false;
            //                    txtPostalCode.Enabled = false;
            //                    rtbPermanentAddress.Enabled = false;
            //                    btnUpload.Enabled = false;

            //                    dgEducationalBackground.Enabled = false;
            //                    dgFamilyBackground.Enabled = false;

            //                    txtChildsDoctor.Enabled = false;
            //                    txtDoctorsContactNo.Enabled = false;
            //                    txtAllergies.Enabled = false;
            //                    rtbDoctorBizAddress.Enabled = false;
            //                    cbComplete.Enabled = false;
            //                    cbIncomplete.Enabled = false;
            //                    cmbHealthConcern.Enabled = false;


            //                    rtbSpecialProcedure.Enabled = false;

            //                    btnSave.Hide();
            //                    btnEdit.Show();
            //                    isEdit = true;
            //                    //----------------------------



            //                    student = _studentService.GetStudent(Convert.ToInt32(cmbStudentNo.SelectedValue.ToString()));

            //                    if (student != null)
            //                    {
            //                        txtFirstName.Text = student.FirstName;
            //                        txtMiddleName.Text = student.MiddleName;
            //                        txtLastName.Text = student.LastName;
            //                        dpDateOfBirth.Text = student.DateOfBirth != dpDateOfBirth.MinDate ? student.DateOfBirth.ToString() : string.Empty;

            //                        txtPlaceOfBirth.Text = student.PlaceOfBirth;
            //                        cmbGender.SelectedValue = student.GenderId;
            //                        txtReligion.Text = student.Religion;
            //                        txtCitizenship.Text = student.Citizenship;
            //                        txtPostalCode.Text = student.PostalCode;
            //                        rtbPermanentAddress.Text = student.PermanentAddress;
            //                        pbStudentImage.Image = !string.IsNullOrEmpty(student.path) ? Image.FromFile(student.path) : Image.FromFile(defaultImage);
            //                        newPath = student.path;
            //                        //render family background
            //                    }


            //                    studentEducationalBackground = _studentService.GetEducationalBackground(Convert.ToInt32(cmbStudentNo.SelectedValue.ToString()));
            //                    if (studentEducationalBackground != null)
            //                    {
            //                        dgEducationalBackground.ClearSelection();
            //                        dgEducationalBackground.Columns.Clear();
            //                        dgFamilyBackground.ClearSelection();
            //                        dgFamilyBackground.Columns.Clear();


            //                        var educBindingList = new BindingList<tblstudenteducationalbackground>(studentEducationalBackground);
            //                        var educSource = new BindingSource(educBindingList, null);
            //                        dgEducationalBackground.DataSource = educSource;

            //                        DataGridViewComboBoxColumn lvlCol = new DataGridViewComboBoxColumn();
            //                        lvlCol.DataSource = _studentService.GetEducationLevel();
            //                        lvlCol.ValueMember = "LevelId";
            //                        lvlCol.DisplayMember = "Level";
            //                        lvlCol.DataPropertyName = "EducLevelId";
            //                        lvlCol.Name = "Level";

            //                        dgEducationalBackground.Columns.Insert(0, lvlCol);
            //                        dgEducationalBackground.Columns["EducLevelId"].HeaderText = "Level";
            //                        dgEducationalBackground.Columns["StudentId"].Visible = false;
            //                        dgEducationalBackground.Columns["IsDeleted"].Visible = false;
            //                        //dgEducationalBackground.Columns[7].Visible = false;
            //                        // dgEducationalBackground.Columns["LevelId"].Visible = false;
            //                        dgEducationalBackground.Columns["SchoolName"].HeaderText = "School Name and Address";
            //                        dgEducationalBackground.Columns["SchoolYear"].HeaderText= "School Year";
            //                        dgEducationalBackground.Columns["AwardsReceived"].HeaderText= "Awards Received";


            //                        studentFamily = _studentService.GetStudentFamily(Convert.ToInt32(cmbStudentNo.SelectedValue.ToString()));
            //                        if (studentFamily != null)
            //                        {
            //                            var famBindingList = new BindingList<tblstudentfamily>(studentFamily);
            //                            var famcSource = new BindingSource(famBindingList, null);
            //                            dgFamilyBackground.DataSource = famcSource;

            //                            DataGridViewComboBoxColumn cmbRelation = new DataGridViewComboBoxColumn();
            //                            // DataGridViewColumn cmbLevel = new DataGridViewColumn(bc);
            //                            cmbRelation.DataSource = _studentService.GetRelationship();
            //                            cmbRelation.ValueMember = "RelationshipId";
            //                            cmbRelation.DisplayMember = "RelationshipName";
            //                            cmbRelation.DataPropertyName = "RelationshipId";
            //                           // cmbRelation.Name = "Rel";

            //                            dgFamilyBackground.Columns[0].Visible = false;
            //                            dgFamilyBackground.Columns.Insert(1, cmbRelation);
            //                            dgFamilyBackground.Columns["name"].HeaderText = "Name";
            //                            dgFamilyBackground.Columns["citizenship"].HeaderText = "Citizenship";
            //                            dgFamilyBackground.Columns["Religion"].HeaderText = "Religion";
            //                            dgFamilyBackground.Columns["Address"].HeaderText = "Home Address";
            //                            dgFamilyBackground.Columns["TelNo"].HeaderText = "Tel No";
            //                            dgFamilyBackground.Columns["MobileNo"].HeaderText = "Mobile No";
            //                            dgFamilyBackground.Columns["eMail"].HeaderText = "Email";
            //                            dgFamilyBackground.Columns["occupation"].HeaderText = "Occupation";
            //                            dgFamilyBackground.Columns["EmployerBizAddress"].HeaderText = "Employer Business Name and Address";
            //                            dgFamilyBackground.Columns["Address"].HeaderText = "Home Address";
            //                            dgFamilyBackground.Columns["YearGraduated"].HeaderText = "Year Graduated";
            //                            dgFamilyBackground.Columns["EducationalAttainment"].HeaderText = "Educational Attainment";

            //                            //dgFamilyBackground.Columns.Add(cmbLevel);

            //                            dgFamilyBackground.Columns["IsDeleted"].Visible = false;
            //                            dgFamilyBackground.Columns["StudentId"].Visible = false;

            //                        }


            //                        studentHealth = _studentService.GetStudentHealthRecord(Convert.ToInt32(cmbStudentNo.SelectedValue.ToString()));
            //                        if (studentHealth != null)
            //                        {
            //                            txtChildsDoctor.Text = studentHealth.ChildsDoctor;
            //                            txtDoctorsContactNo.Text = studentHealth.DoctorsContactNo;
            //                            txtAllergies.Text = studentHealth.Allergies;
            //                            rtbDoctorBizAddress.Text = studentHealth.DoctorsBusinessNameAndAddress;
            //                            cbComplete.Checked = studentHealth.Immunization == true ? true : false;
            //                            cmbHealthConcern.SelectedValue = studentHealth.HealthConcernId;

            //                            immunization = cbComplete.Checked == true ? true : false;
            //                            rtbSpecialProcedure.Text = studentHealth.SpecialCare;
            //                        }

            //                    }
            //                }
            //            }
            #endregion
                   }

        private void dgFamilyBackground_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                Guid guidId = Guid.NewGuid();
                var fileName = this.openFileDialog1.FileName;
                System.IO.File.Copy(fileName, @"D:\Projects\dotnet\SVM_Suite\SVM_Suite\SVM_Contracts\imgresource\" + Path.GetFileNameWithoutExtension(fileName) + guidId.ToString()+  ".png"  );
                newPath = @"D:\Projects\dotnet\SVM_Suite\SVM_Suite\SVM_Contracts\imgresource\" + Path.GetFileNameWithoutExtension(fileName) + guidId.ToString() + ".png";
                pbStudentImage.Image = Image.FromFile(newPath);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
           // cmbStudentNo.Items.Clear();
            //cmbStudentNo.DataSource = _studentService.GetAllStudents();
            //cmbStudentNo.ValueMember = "StudentId";
            //cmbStudentNo.DisplayMember = "StudentId";
            //cmbStudentNo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            //cmbStudentNo.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            //cmbStudentNo.AutoCompleteSource = AutoCompleteSource.ListItems;
            //cmbStudentNo.SelectedIndex = -1;
            //cmbStudentNo.SelectedValue = 0;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        public void ClearForm()
        {
            txtFirstName.Clear();
            txtMiddleName.Clear();
            txtLastName.Clear();
            dpDateOfBirth.Text = DateTime.Now.ToString();
            txtPlaceOfBirth.Clear();
            cmbGender.SelectedIndex = 1;
            txtReligion.Clear();
            txtCitizenship.Clear();
            txtPostalCode.Clear();
            rtbPermanentAddress.Clear();


            dgEducationalBackground.Columns.Clear();
            dgFamilyBackground.Columns.Clear();

            txtChildsDoctor.Clear();
            txtDoctorsContactNo.Clear();
            txtAllergies.Clear();
            rtbDoctorBizAddress.Clear();
            cbComplete.Checked = false;
            cbIncomplete.Checked = true;
            cmbHealthConcern.SelectedIndex = 1;


            rtbSpecialProcedure.Clear();

            isEdit = false;
        }

        public void LoadStudent()
        {
            int result;


            //if (cmbStudentNo.SelectedValue != null)
            //{



            if (int.TryParse(Global.selectedStudent.ToString(), out result))
            {
                //disable buttons------------
                txtFirstName.Enabled = false;
                    txtMiddleName.Enabled = false;
                    txtLastName.Enabled = false;
                    dpDateOfBirth.Enabled = false;
                    txtPlaceOfBirth.Enabled = false;
                    cmbGender.Enabled = false;
                    txtReligion.Enabled = false;
                    txtCitizenship.Enabled = false;
                    txtPostalCode.Enabled = false;
                    rtbPermanentAddress.Enabled = false;
                    btnUpload.Enabled = false;
                txtStudentNo.ReadOnly = true;
                    dgEducationalBackground.Enabled = false;
                    dgFamilyBackground.Enabled = false;

                    txtChildsDoctor.Enabled = false;
                    txtDoctorsContactNo.Enabled = false;
                    txtAllergies.Enabled = false;
                    rtbDoctorBizAddress.Enabled = false;
                    cbComplete.Enabled = false;
                    cbIncomplete.Enabled = false;
                    cmbHealthConcern.Enabled = false;


                    rtbSpecialProcedure.Enabled = false;

                    btnSave.Hide();
                    btnEdit.Show();
                    isEdit = true;
                    //----------------------------



                    student = _studentService.GetStudent(Global.selectedStudent);

                    if (student != null)
                    {
                        txtStudentNo.Text = student.StudentId.ToString().PadLeft(4, '0') + " - " + student.AY.ToString();
                        txtFirstName.Text = student.FirstName;
                        txtMiddleName.Text = student.MiddleName;
                        txtLastName.Text = student.LastName;
                        dpDateOfBirth.Text = student.DateOfBirth != dpDateOfBirth.MinDate ? student.DateOfBirth.ToString() : string.Empty;

                        txtPlaceOfBirth.Text = student.PlaceOfBirth;
                        cmbGender.SelectedValue = student.GenderId;
                        txtReligion.Text = student.Religion;
                        txtCitizenship.Text = student.Citizenship;
                        txtPostalCode.Text = student.PostalCode;
                        rtbPermanentAddress.Text = student.PermanentAddress;
                        pbStudentImage.Image = !string.IsNullOrEmpty(student.path) ? Image.FromFile(student.path) : Image.FromFile(defaultImage);
                        newPath = student.path;
                        //render family background
                    }


                    studentEducationalBackground = _studentService.GetEducationalBackground(Global.selectedStudent);
                    if (studentEducationalBackground != null)
                    {
                        dgEducationalBackground.ClearSelection();
                        dgEducationalBackground.Columns.Clear();
                        dgFamilyBackground.ClearSelection();
                        dgFamilyBackground.Columns.Clear();


                        var educBindingList = new BindingList<tblstudenteducationalbackground>(studentEducationalBackground);
                        var educSource = new BindingSource(educBindingList, null);
                        
                        dgEducationalBackground.DataSource = educSource;

                        DataGridViewComboBoxColumn lvlCol = new DataGridViewComboBoxColumn();
                     lvlCol.Items.Insert(0, string.Empty);
                    lstEducLevel = _studentService.GetEducationLevel();
                    lstEducLevel.Insert(0, new tbldimeducationlevel { LevelId=0, Level=string.Empty });
                    lvlCol.DataSource = lstEducLevel;    
                    lvlCol.ValueMember = "LevelId";
                        lvlCol.DisplayMember = "Level";
                        lvlCol.DataPropertyName = "EducLevelId";
                        lvlCol.Name = "Level";
                                           
                        dgEducationalBackground.Columns.Insert(0, lvlCol);
                        dgEducationalBackground.Columns["EducLevelId"].HeaderText = "Level";
                        dgEducationalBackground.Columns["StudentId"].Visible = false;
                        dgEducationalBackground.Columns["IsDeleted"].Visible = false;
                        //dgEducationalBackground.Columns[7].Visible = false;
                        // dgEducationalBackground.Columns["LevelId"].Visible = false;
                        dgEducationalBackground.Columns["SchoolName"].HeaderText = "School Name and Address";
                        dgEducationalBackground.Columns["SchoolYear"].HeaderText = "School Year";
                        dgEducationalBackground.Columns["AwardsReceived"].HeaderText = "Awards Received";


                        studentFamily = _studentService.GetStudentFamily(Global.selectedStudent);
                        if (studentFamily != null)
                        {
                            var famBindingList = new BindingList<tblstudentfamily>(studentFamily);
                            var famcSource = new BindingSource(famBindingList, null);
                            dgFamilyBackground.DataSource = famcSource;

                            DataGridViewComboBoxColumn cmbRelation = new DataGridViewComboBoxColumn();
                        // DataGridViewColumn cmbLevel = new DataGridViewColumn(bc);
                        //cmbRelation.Items.Insert(0, String.Empty);
                        lstRelationship = _studentService.GetRelationship();
                        lstRelationship.Insert(0, new tblrelationship {RelationshipId=0, RelationshipName= String.Empty });
                        cmbRelation.DataSource = lstRelationship;
                            cmbRelation.ValueMember = "RelationshipId";
                            cmbRelation.DisplayMember = "RelationshipName";
                            cmbRelation.DataPropertyName = "RelationshipId";
                            

                            dgFamilyBackground.Columns["RelationshipId"].Visible = false;
                            dgFamilyBackground.Columns.Insert(1, cmbRelation);
                            dgFamilyBackground.Columns["name"].HeaderText = "Name";
                            dgFamilyBackground.Columns["citizenship"].HeaderText = "Citizenship";
                            dgFamilyBackground.Columns["Religion"].HeaderText = "Religion";
                            dgFamilyBackground.Columns["Address"].HeaderText = "Home Address";
                            dgFamilyBackground.Columns["TelNo"].HeaderText = "Tel No";
                            dgFamilyBackground.Columns["MobileNo"].HeaderText = "Mobile No";
                            dgFamilyBackground.Columns["eMail"].HeaderText = "Email";
                            dgFamilyBackground.Columns["occupation"].HeaderText = "Occupation";
                            dgFamilyBackground.Columns["EmployerBizAddress"].HeaderText = "Employer Business Name and Address";
                            dgFamilyBackground.Columns["Address"].HeaderText = "Home Address";
                            dgFamilyBackground.Columns["YearGraduated"].HeaderText = "Year Graduated";
                            dgFamilyBackground.Columns["EducationalAttainment"].HeaderText = "Educational Attainment";

                            //dgFamilyBackground.Columns.Add(cmbLevel);

                            dgFamilyBackground.Columns["IsDeleted"].Visible = false;
                            dgFamilyBackground.Columns["StudentId"].Visible = false;

                        }


                        studentHealth = _studentService.GetStudentHealthRecord(Global.selectedStudent);
                        if (studentHealth != null)
                        {
                            txtChildsDoctor.Text = studentHealth.ChildsDoctor;
                            txtDoctorsContactNo.Text = studentHealth.DoctorsContactNo;
                            txtAllergies.Text = studentHealth.Allergies;
                            rtbDoctorBizAddress.Text = studentHealth.DoctorsBusinessNameAndAddress;
                            cbComplete.Checked = studentHealth.Immunization == true ? true : false;
                            cmbHealthConcern.SelectedValue = studentHealth.HealthConcernId;

                            immunization = cbComplete.Checked == true ? true : false;
                            rtbSpecialProcedure.Text = studentHealth.SpecialCare;
                        }

                    }
                }
            //}
        }

        private void tabFurtherDetails_Click(object sender, EventArgs e)
        {

        }
    }
}
