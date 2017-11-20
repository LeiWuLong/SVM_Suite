namespace SVM_Suite
{
    partial class FrmStudentInformation
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblDateOfBirth = new System.Windows.Forms.Label();
            this.dpDateOfBirth = new System.Windows.Forms.DateTimePicker();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.lblMiddleName = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtMiddleName = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtCitizenship = new System.Windows.Forms.TextBox();
            this.txtReligion = new System.Windows.Forms.TextBox();
            this.txtPlaceOfBirth = new System.Windows.Forms.TextBox();
            this.cmbGender = new System.Windows.Forms.ComboBox();
            this.rtbPermanentAddress = new System.Windows.Forms.RichTextBox();
            this.txtPostalCode = new System.Windows.Forms.TextBox();
            this.lblGender = new System.Windows.Forms.Label();
            this.lblPlaceOfBirth = new System.Windows.Forms.Label();
            this.lblCitizenship = new System.Windows.Forms.Label();
            this.lblReligion = new System.Windows.Forms.Label();
            this.lblPostalCode = new System.Windows.Forms.Label();
            this.lblPermanentAddress = new System.Windows.Forms.Label();
            this.lblStudentNo = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.tabFamilyBackground = new System.Windows.Forms.TabPage();
            this.dgFamilyBackground = new System.Windows.Forms.DataGridView();
            this.colStudentFamilyId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_cmbRelationship = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.colCitizenship = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colReligion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colHomeAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTelNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMobileNO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colOccupation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEmployerDetails = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLastSchool = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colYearGraduated = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEducationalAttainment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabEducationalBackground = new System.Windows.Forms.TabPage();
            this.dgEducationalBackground = new System.Windows.Forms.DataGridView();
            this.colLevelId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_cmbLevel = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.colSchoolAndAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSchoolYear = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAwardsReceived = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colIsDeleted = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tcStudentDetail = new System.Windows.Forms.TabControl();
            this.tabHealthRecord = new System.Windows.Forms.TabPage();
            this.cbIncomplete = new System.Windows.Forms.CheckBox();
            this.cbComplete = new System.Windows.Forms.CheckBox();
            this.lblDoctorsContact = new System.Windows.Forms.Label();
            this.txtDoctorsContactNo = new System.Windows.Forms.TextBox();
            this.rtbSpecialProcedure = new System.Windows.Forms.RichTextBox();
            this.lblCaringSpecialProcedure = new System.Windows.Forms.Label();
            this.lblAllergies = new System.Windows.Forms.Label();
            this.txtAllergies = new System.Windows.Forms.TextBox();
            this.lblImmunization = new System.Windows.Forms.Label();
            this.cmbHealthConcern = new System.Windows.Forms.ComboBox();
            this.lblHealthConcern = new System.Windows.Forms.Label();
            this.rtbDoctorBizAddress = new System.Windows.Forms.RichTextBox();
            this.lblDoctorBizAddress = new System.Windows.Forms.Label();
            this.lblDoctor = new System.Windows.Forms.Label();
            this.txtChildsDoctor = new System.Windows.Forms.TextBox();
            this.tabFurtherDetails = new System.Windows.Forms.TabPage();
            this.cmbHonors = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnUpload = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.btnClear = new System.Windows.Forms.Button();
            this.pbStudentImage = new System.Windows.Forms.PictureBox();
            this.txtStudentNo = new System.Windows.Forms.TextBox();
            this.cmbReferrals = new System.Windows.Forms.ComboBox();
            this.cmbSiblings = new System.Windows.Forms.ComboBox();
            this.tabFamilyBackground.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgFamilyBackground)).BeginInit();
            this.tabEducationalBackground.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgEducationalBackground)).BeginInit();
            this.tcStudentDetail.SuspendLayout();
            this.tabHealthRecord.SuspendLayout();
            this.tabFurtherDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbStudentImage)).BeginInit();
            this.SuspendLayout();
            // 
            // lblDateOfBirth
            // 
            this.lblDateOfBirth.AutoSize = true;
            this.lblDateOfBirth.Location = new System.Drawing.Point(33, 246);
            this.lblDateOfBirth.Name = "lblDateOfBirth";
            this.lblDateOfBirth.Size = new System.Drawing.Size(66, 13);
            this.lblDateOfBirth.TabIndex = 9;
            this.lblDateOfBirth.Text = "Date of Birth";
            // 
            // dpDateOfBirth
            // 
            this.dpDateOfBirth.Location = new System.Drawing.Point(105, 240);
            this.dpDateOfBirth.Name = "dpDateOfBirth";
            this.dpDateOfBirth.Size = new System.Drawing.Size(200, 20);
            this.dpDateOfBirth.TabIndex = 4;
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(42, 173);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(57, 13);
            this.lblFirstName.TabIndex = 7;
            this.lblFirstName.Text = "First Name";
            // 
            // lblMiddleName
            // 
            this.lblMiddleName.AutoSize = true;
            this.lblMiddleName.Location = new System.Drawing.Point(30, 207);
            this.lblMiddleName.Name = "lblMiddleName";
            this.lblMiddleName.Size = new System.Drawing.Size(69, 13);
            this.lblMiddleName.TabIndex = 6;
            this.lblMiddleName.Text = "Middle Name";
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(41, 139);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(58, 13);
            this.lblLastName.TabIndex = 5;
            this.lblLastName.Text = "Last Name";
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(105, 173);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(200, 20);
            this.txtFirstName.TabIndex = 2;
            this.txtFirstName.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtMiddleName
            // 
            this.txtMiddleName.Location = new System.Drawing.Point(105, 207);
            this.txtMiddleName.Name = "txtMiddleName";
            this.txtMiddleName.Size = new System.Drawing.Size(200, 20);
            this.txtMiddleName.TabIndex = 3;
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(106, 136);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(199, 20);
            this.txtLastName.TabIndex = 1;
            // 
            // txtCitizenship
            // 
            this.txtCitizenship.Location = new System.Drawing.Point(521, 166);
            this.txtCitizenship.Name = "txtCitizenship";
            this.txtCitizenship.Size = new System.Drawing.Size(200, 20);
            this.txtCitizenship.TabIndex = 8;
            // 
            // txtReligion
            // 
            this.txtReligion.Location = new System.Drawing.Point(521, 136);
            this.txtReligion.Name = "txtReligion";
            this.txtReligion.Size = new System.Drawing.Size(200, 20);
            this.txtReligion.TabIndex = 7;
            // 
            // txtPlaceOfBirth
            // 
            this.txtPlaceOfBirth.Location = new System.Drawing.Point(105, 275);
            this.txtPlaceOfBirth.Name = "txtPlaceOfBirth";
            this.txtPlaceOfBirth.Size = new System.Drawing.Size(200, 20);
            this.txtPlaceOfBirth.TabIndex = 5;
            // 
            // cmbGender
            // 
            this.cmbGender.FormattingEnabled = true;
            this.cmbGender.Location = new System.Drawing.Point(105, 312);
            this.cmbGender.Name = "cmbGender";
            this.cmbGender.Size = new System.Drawing.Size(121, 21);
            this.cmbGender.TabIndex = 6;
            // 
            // rtbPermanentAddress
            // 
            this.rtbPermanentAddress.Location = new System.Drawing.Point(521, 230);
            this.rtbPermanentAddress.Name = "rtbPermanentAddress";
            this.rtbPermanentAddress.Size = new System.Drawing.Size(274, 119);
            this.rtbPermanentAddress.TabIndex = 10;
            this.rtbPermanentAddress.Text = "";
            // 
            // txtPostalCode
            // 
            this.txtPostalCode.Location = new System.Drawing.Point(521, 198);
            this.txtPostalCode.Name = "txtPostalCode";
            this.txtPostalCode.Size = new System.Drawing.Size(118, 20);
            this.txtPostalCode.TabIndex = 9;
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Location = new System.Drawing.Point(57, 315);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(42, 13);
            this.lblGender.TabIndex = 20;
            this.lblGender.Text = "Gender";
            // 
            // lblPlaceOfBirth
            // 
            this.lblPlaceOfBirth.AutoSize = true;
            this.lblPlaceOfBirth.Location = new System.Drawing.Point(33, 282);
            this.lblPlaceOfBirth.Name = "lblPlaceOfBirth";
            this.lblPlaceOfBirth.Size = new System.Drawing.Size(72, 13);
            this.lblPlaceOfBirth.TabIndex = 21;
            this.lblPlaceOfBirth.Text = "Place Of Birth";
            // 
            // lblCitizenship
            // 
            this.lblCitizenship.AutoSize = true;
            this.lblCitizenship.Location = new System.Drawing.Point(461, 166);
            this.lblCitizenship.Name = "lblCitizenship";
            this.lblCitizenship.Size = new System.Drawing.Size(57, 13);
            this.lblCitizenship.TabIndex = 22;
            this.lblCitizenship.Text = "Citizenship";
            // 
            // lblReligion
            // 
            this.lblReligion.AutoSize = true;
            this.lblReligion.Location = new System.Drawing.Point(473, 143);
            this.lblReligion.Name = "lblReligion";
            this.lblReligion.Size = new System.Drawing.Size(45, 13);
            this.lblReligion.TabIndex = 23;
            this.lblReligion.Text = "Religion";
            // 
            // lblPostalCode
            // 
            this.lblPostalCode.AutoSize = true;
            this.lblPostalCode.Location = new System.Drawing.Point(454, 201);
            this.lblPostalCode.Name = "lblPostalCode";
            this.lblPostalCode.Size = new System.Drawing.Size(64, 13);
            this.lblPostalCode.TabIndex = 24;
            this.lblPostalCode.Text = "Postal Code";
            // 
            // lblPermanentAddress
            // 
            this.lblPermanentAddress.AutoSize = true;
            this.lblPermanentAddress.Location = new System.Drawing.Point(419, 233);
            this.lblPermanentAddress.Name = "lblPermanentAddress";
            this.lblPermanentAddress.Size = new System.Drawing.Size(99, 13);
            this.lblPermanentAddress.TabIndex = 25;
            this.lblPermanentAddress.Text = "Permanent Address";
            // 
            // lblStudentNo
            // 
            this.lblStudentNo.AutoSize = true;
            this.lblStudentNo.Location = new System.Drawing.Point(221, 29);
            this.lblStudentNo.Name = "lblStudentNo";
            this.lblStudentNo.Size = new System.Drawing.Size(84, 13);
            this.lblStudentNo.TabIndex = 28;
            this.lblStudentNo.Text = "Student Number";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(464, 606);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 29;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(649, 606);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 30;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(746, 606);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 31;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(464, 606);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 23);
            this.btnEdit.TabIndex = 32;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // tabFamilyBackground
            // 
            this.tabFamilyBackground.Controls.Add(this.dgFamilyBackground);
            this.tabFamilyBackground.Location = new System.Drawing.Point(4, 22);
            this.tabFamilyBackground.Name = "tabFamilyBackground";
            this.tabFamilyBackground.Padding = new System.Windows.Forms.Padding(3);
            this.tabFamilyBackground.Size = new System.Drawing.Size(755, 196);
            this.tabFamilyBackground.TabIndex = 1;
            this.tabFamilyBackground.Text = "Family Background";
            this.tabFamilyBackground.UseVisualStyleBackColor = true;
            // 
            // dgFamilyBackground
            // 
            this.dgFamilyBackground.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgFamilyBackground.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colStudentFamilyId,
            this.colName,
            this.col_cmbRelationship,
            this.colCitizenship,
            this.colReligion,
            this.colHomeAddress,
            this.colTelNo,
            this.colMobileNO,
            this.colEmail,
            this.colOccupation,
            this.colEmployerDetails,
            this.colLastSchool,
            this.colYearGraduated,
            this.colEducationalAttainment});
            this.dgFamilyBackground.Location = new System.Drawing.Point(4, 6);
            this.dgFamilyBackground.Name = "dgFamilyBackground";
            this.dgFamilyBackground.Size = new System.Drawing.Size(745, 162);
            this.dgFamilyBackground.TabIndex = 0;
            this.dgFamilyBackground.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgFamilyBackground_CellContentClick);
            // 
            // colStudentFamilyId
            // 
            this.colStudentFamilyId.HeaderText = "Family Id";
            this.colStudentFamilyId.Name = "colStudentFamilyId";
            // 
            // colName
            // 
            this.colName.HeaderText = "Name";
            this.colName.Name = "colName";
            // 
            // col_cmbRelationship
            // 
            this.col_cmbRelationship.HeaderText = "Relationship";
            this.col_cmbRelationship.Name = "col_cmbRelationship";
            // 
            // colCitizenship
            // 
            this.colCitizenship.HeaderText = "Citizenship";
            this.colCitizenship.Name = "colCitizenship";
            // 
            // colReligion
            // 
            this.colReligion.HeaderText = "Religion";
            this.colReligion.Name = "colReligion";
            // 
            // colHomeAddress
            // 
            this.colHomeAddress.HeaderText = "Home Address";
            this.colHomeAddress.Name = "colHomeAddress";
            // 
            // colTelNo
            // 
            this.colTelNo.HeaderText = "Tel No";
            this.colTelNo.Name = "colTelNo";
            // 
            // colMobileNO
            // 
            this.colMobileNO.HeaderText = "Mobile No";
            this.colMobileNO.Name = "colMobileNO";
            // 
            // colEmail
            // 
            this.colEmail.HeaderText = "Email";
            this.colEmail.Name = "colEmail";
            // 
            // colOccupation
            // 
            this.colOccupation.HeaderText = "Occupation";
            this.colOccupation.Name = "colOccupation";
            // 
            // colEmployerDetails
            // 
            this.colEmployerDetails.HeaderText = "Employer, Business Address and Contact";
            this.colEmployerDetails.Name = "colEmployerDetails";
            this.colEmployerDetails.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colEmployerDetails.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // colLastSchool
            // 
            this.colLastSchool.HeaderText = "Last School Attended";
            this.colLastSchool.Name = "colLastSchool";
            // 
            // colYearGraduated
            // 
            this.colYearGraduated.HeaderText = "Year Graduated";
            this.colYearGraduated.Name = "colYearGraduated";
            // 
            // colEducationalAttainment
            // 
            this.colEducationalAttainment.HeaderText = "Educational Attainment";
            this.colEducationalAttainment.Name = "colEducationalAttainment";
            this.colEducationalAttainment.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colEducationalAttainment.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // tabEducationalBackground
            // 
            this.tabEducationalBackground.Controls.Add(this.dgEducationalBackground);
            this.tabEducationalBackground.Location = new System.Drawing.Point(4, 22);
            this.tabEducationalBackground.Name = "tabEducationalBackground";
            this.tabEducationalBackground.Padding = new System.Windows.Forms.Padding(3);
            this.tabEducationalBackground.Size = new System.Drawing.Size(755, 196);
            this.tabEducationalBackground.TabIndex = 0;
            this.tabEducationalBackground.Text = "Educational Background";
            this.tabEducationalBackground.UseVisualStyleBackColor = true;
            // 
            // dgEducationalBackground
            // 
            this.dgEducationalBackground.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgEducationalBackground.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colLevelId,
            this.col_cmbLevel,
            this.colSchoolAndAddress,
            this.colSchoolYear,
            this.colAwardsReceived,
            this.colIsDeleted});
            this.dgEducationalBackground.Location = new System.Drawing.Point(4, 3);
            this.dgEducationalBackground.Name = "dgEducationalBackground";
            this.dgEducationalBackground.Size = new System.Drawing.Size(748, 190);
            this.dgEducationalBackground.TabIndex = 0;
            this.dgEducationalBackground.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgEducationalBackground_CellContentClick);
            // 
            // colLevelId
            // 
            this.colLevelId.HeaderText = "Level Id";
            this.colLevelId.Name = "colLevelId";
            this.colLevelId.Visible = false;
            // 
            // col_cmbLevel
            // 
            this.col_cmbLevel.HeaderText = "Level";
            this.col_cmbLevel.Name = "col_cmbLevel";
            this.col_cmbLevel.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.col_cmbLevel.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // colSchoolAndAddress
            // 
            this.colSchoolAndAddress.HeaderText = "School Name and Address";
            this.colSchoolAndAddress.Name = "colSchoolAndAddress";
            // 
            // colSchoolYear
            // 
            this.colSchoolYear.HeaderText = "School Year";
            this.colSchoolYear.Name = "colSchoolYear";
            // 
            // colAwardsReceived
            // 
            this.colAwardsReceived.HeaderText = "Awards Received";
            this.colAwardsReceived.Name = "colAwardsReceived";
            // 
            // colIsDeleted
            // 
            this.colIsDeleted.HeaderText = "Is Deleted";
            this.colIsDeleted.Name = "colIsDeleted";
            this.colIsDeleted.Visible = false;
            // 
            // tcStudentDetail
            // 
            this.tcStudentDetail.Controls.Add(this.tabEducationalBackground);
            this.tcStudentDetail.Controls.Add(this.tabFamilyBackground);
            this.tcStudentDetail.Controls.Add(this.tabHealthRecord);
            this.tcStudentDetail.Controls.Add(this.tabFurtherDetails);
            this.tcStudentDetail.Location = new System.Drawing.Point(36, 355);
            this.tcStudentDetail.Name = "tcStudentDetail";
            this.tcStudentDetail.SelectedIndex = 0;
            this.tcStudentDetail.Size = new System.Drawing.Size(763, 222);
            this.tcStudentDetail.TabIndex = 5;
            // 
            // tabHealthRecord
            // 
            this.tabHealthRecord.Controls.Add(this.cbIncomplete);
            this.tabHealthRecord.Controls.Add(this.cbComplete);
            this.tabHealthRecord.Controls.Add(this.lblDoctorsContact);
            this.tabHealthRecord.Controls.Add(this.txtDoctorsContactNo);
            this.tabHealthRecord.Controls.Add(this.rtbSpecialProcedure);
            this.tabHealthRecord.Controls.Add(this.lblCaringSpecialProcedure);
            this.tabHealthRecord.Controls.Add(this.lblAllergies);
            this.tabHealthRecord.Controls.Add(this.txtAllergies);
            this.tabHealthRecord.Controls.Add(this.lblImmunization);
            this.tabHealthRecord.Controls.Add(this.cmbHealthConcern);
            this.tabHealthRecord.Controls.Add(this.lblHealthConcern);
            this.tabHealthRecord.Controls.Add(this.rtbDoctorBizAddress);
            this.tabHealthRecord.Controls.Add(this.lblDoctorBizAddress);
            this.tabHealthRecord.Controls.Add(this.lblDoctor);
            this.tabHealthRecord.Controls.Add(this.txtChildsDoctor);
            this.tabHealthRecord.Location = new System.Drawing.Point(4, 22);
            this.tabHealthRecord.Name = "tabHealthRecord";
            this.tabHealthRecord.Padding = new System.Windows.Forms.Padding(3);
            this.tabHealthRecord.Size = new System.Drawing.Size(755, 196);
            this.tabHealthRecord.TabIndex = 2;
            this.tabHealthRecord.Text = "Health Record";
            this.tabHealthRecord.UseVisualStyleBackColor = true;
            // 
            // cbIncomplete
            // 
            this.cbIncomplete.AutoSize = true;
            this.cbIncomplete.Checked = true;
            this.cbIncomplete.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbIncomplete.Location = new System.Drawing.Point(606, 46);
            this.cbIncomplete.Name = "cbIncomplete";
            this.cbIncomplete.Size = new System.Drawing.Size(78, 17);
            this.cbIncomplete.TabIndex = 17;
            this.cbIncomplete.Text = "Incomplete";
            this.cbIncomplete.UseVisualStyleBackColor = true;
            // 
            // cbComplete
            // 
            this.cbComplete.AutoSize = true;
            this.cbComplete.Location = new System.Drawing.Point(520, 46);
            this.cbComplete.Name = "cbComplete";
            this.cbComplete.Size = new System.Drawing.Size(70, 17);
            this.cbComplete.TabIndex = 16;
            this.cbComplete.Text = "Complete";
            this.cbComplete.UseVisualStyleBackColor = true;
            // 
            // lblDoctorsContact
            // 
            this.lblDoctorsContact.AutoSize = true;
            this.lblDoctorsContact.Location = new System.Drawing.Point(17, 46);
            this.lblDoctorsContact.Name = "lblDoctorsContact";
            this.lblDoctorsContact.Size = new System.Drawing.Size(61, 13);
            this.lblDoctorsContact.TabIndex = 15;
            this.lblDoctorsContact.Text = "Contact No";
            // 
            // txtDoctorsContactNo
            // 
            this.txtDoctorsContactNo.Location = new System.Drawing.Point(138, 43);
            this.txtDoctorsContactNo.Name = "txtDoctorsContactNo";
            this.txtDoctorsContactNo.Size = new System.Drawing.Size(160, 20);
            this.txtDoctorsContactNo.TabIndex = 14;
            // 
            // rtbSpecialProcedure
            // 
            this.rtbSpecialProcedure.Location = new System.Drawing.Point(417, 98);
            this.rtbSpecialProcedure.Name = "rtbSpecialProcedure";
            this.rtbSpecialProcedure.Size = new System.Drawing.Size(264, 77);
            this.rtbSpecialProcedure.TabIndex = 13;
            this.rtbSpecialProcedure.Text = "";
            // 
            // lblCaringSpecialProcedure
            // 
            this.lblCaringSpecialProcedure.AutoSize = true;
            this.lblCaringSpecialProcedure.Location = new System.Drawing.Point(414, 75);
            this.lblCaringSpecialProcedure.Name = "lblCaringSpecialProcedure";
            this.lblCaringSpecialProcedure.Size = new System.Drawing.Size(145, 13);
            this.lblCaringSpecialProcedure.TabIndex = 12;
            this.lblCaringSpecialProcedure.Text = "Special procedures for caring";
            this.lblCaringSpecialProcedure.Click += new System.EventHandler(this.lblCaringSpecialProcedure_Click);
            // 
            // lblAllergies
            // 
            this.lblAllergies.AutoSize = true;
            this.lblAllergies.Location = new System.Drawing.Point(17, 78);
            this.lblAllergies.Name = "lblAllergies";
            this.lblAllergies.Size = new System.Drawing.Size(46, 13);
            this.lblAllergies.TabIndex = 10;
            this.lblAllergies.Text = "Allergies";
            // 
            // txtAllergies
            // 
            this.txtAllergies.Location = new System.Drawing.Point(138, 75);
            this.txtAllergies.Name = "txtAllergies";
            this.txtAllergies.Size = new System.Drawing.Size(160, 20);
            this.txtAllergies.TabIndex = 9;
            // 
            // lblImmunization
            // 
            this.lblImmunization.AutoSize = true;
            this.lblImmunization.Location = new System.Drawing.Point(421, 46);
            this.lblImmunization.Name = "lblImmunization";
            this.lblImmunization.Size = new System.Drawing.Size(68, 13);
            this.lblImmunization.TabIndex = 7;
            this.lblImmunization.Text = "Immunization";
            // 
            // cmbHealthConcern
            // 
            this.cmbHealthConcern.FormattingEnabled = true;
            this.cmbHealthConcern.Location = new System.Drawing.Point(520, 9);
            this.cmbHealthConcern.Name = "cmbHealthConcern";
            this.cmbHealthConcern.Size = new System.Drawing.Size(161, 21);
            this.cmbHealthConcern.TabIndex = 6;
            // 
            // lblHealthConcern
            // 
            this.lblHealthConcern.AutoSize = true;
            this.lblHealthConcern.Location = new System.Drawing.Point(421, 12);
            this.lblHealthConcern.Name = "lblHealthConcern";
            this.lblHealthConcern.Size = new System.Drawing.Size(81, 13);
            this.lblHealthConcern.TabIndex = 5;
            this.lblHealthConcern.Text = "Health Concern";
            // 
            // rtbDoctorBizAddress
            // 
            this.rtbDoctorBizAddress.Location = new System.Drawing.Point(20, 129);
            this.rtbDoctorBizAddress.Name = "rtbDoctorBizAddress";
            this.rtbDoctorBizAddress.Size = new System.Drawing.Size(278, 46);
            this.rtbDoctorBizAddress.TabIndex = 4;
            this.rtbDoctorBizAddress.Text = "";
            // 
            // lblDoctorBizAddress
            // 
            this.lblDoctorBizAddress.AutoSize = true;
            this.lblDoctorBizAddress.Location = new System.Drawing.Point(17, 106);
            this.lblDoctorBizAddress.Name = "lblDoctorBizAddress";
            this.lblDoctorBizAddress.Size = new System.Drawing.Size(181, 13);
            this.lblDoctorBizAddress.TabIndex = 3;
            this.lblDoctorBizAddress.Text = "Doctor\'sBusiness Name and Address";
            this.lblDoctorBizAddress.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblDoctor
            // 
            this.lblDoctor.AutoSize = true;
            this.lblDoctor.Location = new System.Drawing.Point(17, 13);
            this.lblDoctor.Name = "lblDoctor";
            this.lblDoctor.Size = new System.Drawing.Size(115, 13);
            this.lblDoctor.TabIndex = 1;
            this.lblDoctor.Text = "Name of Child\'s Doctor";
            // 
            // txtChildsDoctor
            // 
            this.txtChildsDoctor.Location = new System.Drawing.Point(138, 10);
            this.txtChildsDoctor.Name = "txtChildsDoctor";
            this.txtChildsDoctor.Size = new System.Drawing.Size(160, 20);
            this.txtChildsDoctor.TabIndex = 0;
            // 
            // tabFurtherDetails
            // 
            this.tabFurtherDetails.Controls.Add(this.cmbReferrals);
            this.tabFurtherDetails.Controls.Add(this.cmbSiblings);
            this.tabFurtherDetails.Controls.Add(this.cmbHonors);
            this.tabFurtherDetails.Controls.Add(this.label4);
            this.tabFurtherDetails.Controls.Add(this.label3);
            this.tabFurtherDetails.Controls.Add(this.label2);
            this.tabFurtherDetails.Location = new System.Drawing.Point(4, 22);
            this.tabFurtherDetails.Name = "tabFurtherDetails";
            this.tabFurtherDetails.Padding = new System.Windows.Forms.Padding(3);
            this.tabFurtherDetails.Size = new System.Drawing.Size(755, 196);
            this.tabFurtherDetails.TabIndex = 3;
            this.tabFurtherDetails.Text = "Enrollee Background";
            this.tabFurtherDetails.UseVisualStyleBackColor = true;
            this.tabFurtherDetails.Click += new System.EventHandler(this.tabFurtherDetails_Click);
            // 
            // cmbHonors
            // 
            this.cmbHonors.FormattingEnabled = true;
            this.cmbHonors.Location = new System.Drawing.Point(115, 12);
            this.cmbHonors.Name = "cmbHonors";
            this.cmbHonors.Size = new System.Drawing.Size(121, 21);
            this.cmbHonors.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(59, 112);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Referrals";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Siblings in SVM";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Honors Received";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(389, 245);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 33;
            // 
            // btnUpload
            // 
            this.btnUpload.Location = new System.Drawing.Point(154, 96);
            this.btnUpload.Name = "btnUpload";
            this.btnUpload.Size = new System.Drawing.Size(75, 23);
            this.btnUpload.TabIndex = 34;
            this.btnUpload.Text = "Upload";
            this.btnUpload.UseVisualStyleBackColor = true;
            this.btnUpload.Click += new System.EventHandler(this.btnUpload_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(555, 606);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 35;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // pbStudentImage
            // 
            this.pbStudentImage.Image = global::SVM_Suite.Properties.Resources.images;
            this.pbStudentImage.Location = new System.Drawing.Point(23, 12);
            this.pbStudentImage.Name = "pbStudentImage";
            this.pbStudentImage.Size = new System.Drawing.Size(125, 118);
            this.pbStudentImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbStudentImage.TabIndex = 26;
            this.pbStudentImage.TabStop = false;
            // 
            // txtStudentNo
            // 
            this.txtStudentNo.Location = new System.Drawing.Point(196, 49);
            this.txtStudentNo.Name = "txtStudentNo";
            this.txtStudentNo.Size = new System.Drawing.Size(193, 20);
            this.txtStudentNo.TabIndex = 36;
            // 
            // cmbReferrals
            // 
            this.cmbReferrals.FormattingEnabled = true;
            this.cmbReferrals.Location = new System.Drawing.Point(113, 109);
            this.cmbReferrals.Name = "cmbReferrals";
            this.cmbReferrals.Size = new System.Drawing.Size(121, 21);
            this.cmbReferrals.TabIndex = 5;
            // 
            // cmbSiblings
            // 
            this.cmbSiblings.FormattingEnabled = true;
            this.cmbSiblings.Location = new System.Drawing.Point(114, 58);
            this.cmbSiblings.Name = "cmbSiblings";
            this.cmbSiblings.Size = new System.Drawing.Size(121, 21);
            this.cmbSiblings.TabIndex = 4;
            // 
            // FrmStudentInformation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(872, 653);
            this.Controls.Add(this.txtStudentNo);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnUpload);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lblStudentNo);
            this.Controls.Add(this.pbStudentImage);
            this.Controls.Add(this.lblPermanentAddress);
            this.Controls.Add(this.lblPostalCode);
            this.Controls.Add(this.lblReligion);
            this.Controls.Add(this.lblCitizenship);
            this.Controls.Add(this.lblPlaceOfBirth);
            this.Controls.Add(this.lblGender);
            this.Controls.Add(this.txtPostalCode);
            this.Controls.Add(this.rtbPermanentAddress);
            this.Controls.Add(this.cmbGender);
            this.Controls.Add(this.txtPlaceOfBirth);
            this.Controls.Add(this.txtReligion);
            this.Controls.Add(this.txtCitizenship);
            this.Controls.Add(this.lblLastName);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.txtMiddleName);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.lblDateOfBirth);
            this.Controls.Add(this.tcStudentDetail);
            this.Controls.Add(this.dpDateOfBirth);
            this.Controls.Add(this.lblMiddleName);
            this.Controls.Add(this.lblFirstName);
            this.Name = "FrmStudentInformation";
            this.Text = "Student Maintenance";
            this.Load += new System.EventHandler(this.frmStudentInformation_Load);
            this.tabFamilyBackground.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgFamilyBackground)).EndInit();
            this.tabEducationalBackground.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgEducationalBackground)).EndInit();
            this.tcStudentDetail.ResumeLayout(false);
            this.tabHealthRecord.ResumeLayout(false);
            this.tabHealthRecord.PerformLayout();
            this.tabFurtherDetails.ResumeLayout(false);
            this.tabFurtherDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbStudentImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lblDateOfBirth;
        private System.Windows.Forms.DateTimePicker dpDateOfBirth;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Label lblMiddleName;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtMiddleName;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtCitizenship;
        private System.Windows.Forms.TextBox txtReligion;
        private System.Windows.Forms.TextBox txtPlaceOfBirth;
        private System.Windows.Forms.ComboBox cmbGender;
        private System.Windows.Forms.RichTextBox rtbPermanentAddress;
        private System.Windows.Forms.TextBox txtPostalCode;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.Label lblPlaceOfBirth;
        private System.Windows.Forms.Label lblCitizenship;
        private System.Windows.Forms.Label lblReligion;
        private System.Windows.Forms.Label lblPostalCode;
        private System.Windows.Forms.Label lblPermanentAddress;
        private System.Windows.Forms.PictureBox pbStudentImage;
        private System.Windows.Forms.Label lblStudentNo;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.TabPage tabFamilyBackground;
        private System.Windows.Forms.DataGridView dgFamilyBackground;
        private System.Windows.Forms.TabPage tabEducationalBackground;
        private System.Windows.Forms.DataGridView dgEducationalBackground;
        private System.Windows.Forms.TabControl tcStudentDetail;
        private System.Windows.Forms.TabPage tabHealthRecord;
        private System.Windows.Forms.RichTextBox rtbDoctorBizAddress;
        private System.Windows.Forms.Label lblDoctorBizAddress;
        private System.Windows.Forms.Label lblDoctor;
        private System.Windows.Forms.TextBox txtChildsDoctor;
        private System.Windows.Forms.Label lblCaringSpecialProcedure;
        private System.Windows.Forms.Label lblAllergies;
        private System.Windows.Forms.TextBox txtAllergies;
        private System.Windows.Forms.Label lblImmunization;
        private System.Windows.Forms.ComboBox cmbHealthConcern;
        private System.Windows.Forms.Label lblHealthConcern;
        private System.Windows.Forms.Label lblDoctorsContact;
        private System.Windows.Forms.TextBox txtDoctorsContactNo;
        private System.Windows.Forms.RichTextBox rtbSpecialProcedure;
        private System.Windows.Forms.CheckBox cbIncomplete;
        private System.Windows.Forms.CheckBox cbComplete;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnUpload;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStudentFamilyId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colName;
        private System.Windows.Forms.DataGridViewComboBoxColumn col_cmbRelationship;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCitizenship;
        private System.Windows.Forms.DataGridViewTextBoxColumn colReligion;
        private System.Windows.Forms.DataGridViewTextBoxColumn colHomeAddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTelNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMobileNO;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn colOccupation;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEmployerDetails;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLastSchool;
        private System.Windows.Forms.DataGridViewTextBoxColumn colYearGraduated;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEducationalAttainment;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLevelId;
        private System.Windows.Forms.DataGridViewComboBoxColumn col_cmbLevel;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSchoolAndAddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSchoolYear;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAwardsReceived;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIsDeleted;
        private System.Windows.Forms.TextBox txtStudentNo;
        private System.Windows.Forms.TabPage tabFurtherDetails;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbHonors;
        private System.Windows.Forms.ComboBox cmbReferrals;
        private System.Windows.Forms.ComboBox cmbSiblings;
    }
}