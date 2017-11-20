namespace SVM_Suite
{
    partial class FrmAssessment
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtStudentNo = new System.Windows.Forms.TextBox();
            this.txtStudentName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbSection = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbEducationLevel = new System.Windows.Forms.ComboBox();
            this.lblGrades = new System.Windows.Forms.Label();
            this.btnAssess = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.txtStatus = new System.Windows.Forms.TextBox();
            this.cmbPaymentTerm = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDeferred = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtDiscount = new System.Windows.Forms.TextBox();
            this.lblDiscount = new System.Windows.Forms.Label();
            this.grpMisc = new System.Windows.Forms.GroupBox();
            this.grpFees = new System.Windows.Forms.GroupBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtTotalMiscTuit = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.txtDownpayment = new System.Windows.Forms.TextBox();
            this.Downpayment = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbTransferee = new System.Windows.Forms.CheckBox();
            this.btnRemoveReferral = new System.Windows.Forms.Button();
            this.btnAddReferral = new System.Windows.Forms.Button();
            this.btnRemoveSibling = new System.Windows.Forms.Button();
            this.btnAddSibling = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.cbAlumni = new System.Windows.Forms.CheckBox();
            this.dgvReferral = new System.Windows.Forms.DataGridView();
            this.dgvSibling = new System.Windows.Forms.DataGridView();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.grpFullBalance = new System.Windows.Forms.GroupBox();
            this.txtDeferredMisc = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtFullMisc = new System.Windows.Forms.TextBox();
            this.pbStudent = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.grpMisc.SuspendLayout();
            this.grpFees.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReferral)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSibling)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.grpFullBalance.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbStudent)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(271, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Student Number";
            // 
            // txtStudentNo
            // 
            this.txtStudentNo.Location = new System.Drawing.Point(394, 14);
            this.txtStudentNo.Name = "txtStudentNo";
            this.txtStudentNo.Size = new System.Drawing.Size(178, 20);
            this.txtStudentNo.TabIndex = 1;
            // 
            // txtStudentName
            // 
            this.txtStudentName.Location = new System.Drawing.Point(393, 55);
            this.txtStudentName.Name = "txtStudentName";
            this.txtStudentName.Size = new System.Drawing.Size(179, 20);
            this.txtStudentName.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(271, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Student Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(271, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Section";
            // 
            // cmbSection
            // 
            this.cmbSection.FormattingEnabled = true;
            this.cmbSection.Location = new System.Drawing.Point(394, 94);
            this.cmbSection.Name = "cmbSection";
            this.cmbSection.Size = new System.Drawing.Size(178, 21);
            this.cmbSection.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(271, 135);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Status";
            // 
            // cmbEducationLevel
            // 
            this.cmbEducationLevel.FormattingEnabled = true;
            this.cmbEducationLevel.Location = new System.Drawing.Point(394, 171);
            this.cmbEducationLevel.Name = "cmbEducationLevel";
            this.cmbEducationLevel.Size = new System.Drawing.Size(178, 21);
            this.cmbEducationLevel.TabIndex = 9;
            this.cmbEducationLevel.SelectedIndexChanged += new System.EventHandler(this.cmbEducationLevel_SelectedIndexChanged);
            // 
            // lblGrades
            // 
            this.lblGrades.AutoSize = true;
            this.lblGrades.Location = new System.Drawing.Point(271, 179);
            this.lblGrades.Name = "lblGrades";
            this.lblGrades.Size = new System.Drawing.Size(92, 13);
            this.lblGrades.TabIndex = 8;
            this.lblGrades.Text = "Educational Level";
            // 
            // btnAssess
            // 
            this.btnAssess.Location = new System.Drawing.Point(594, 682);
            this.btnAssess.Name = "btnAssess";
            this.btnAssess.Size = new System.Drawing.Size(122, 23);
            this.btnAssess.TabIndex = 10;
            this.btnAssess.Text = "Enroll Student";
            this.btnAssess.UseVisualStyleBackColor = true;
            this.btnAssess.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(722, 682);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 11;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // txtStatus
            // 
            this.txtStatus.Location = new System.Drawing.Point(394, 132);
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.Size = new System.Drawing.Size(178, 20);
            this.txtStatus.TabIndex = 12;
            this.txtStatus.TextChanged += new System.EventHandler(this.txtStatus_TextChanged);
            // 
            // cmbPaymentTerm
            // 
            this.cmbPaymentTerm.FormattingEnabled = true;
            this.cmbPaymentTerm.Location = new System.Drawing.Point(394, 209);
            this.cmbPaymentTerm.Name = "cmbPaymentTerm";
            this.cmbPaymentTerm.Size = new System.Drawing.Size(178, 21);
            this.cmbPaymentTerm.TabIndex = 14;
            this.cmbPaymentTerm.Text = "---Select Payment Term---";
            this.cmbPaymentTerm.SelectedIndexChanged += new System.EventHandler(this.cmbPaymentTerm_SelectedIndexChanged);
            this.cmbPaymentTerm.SelectionChangeCommitted += new System.EventHandler(this.cmbPaymentTerm_SelectionChangeCommitted);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(271, 217);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Payment Term";
            // 
            // txtDeferred
            // 
            this.txtDeferred.Location = new System.Drawing.Point(107, 27);
            this.txtDeferred.Name = "txtDeferred";
            this.txtDeferred.ReadOnly = true;
            this.txtDeferred.Size = new System.Drawing.Size(154, 20);
            this.txtDeferred.TabIndex = 17;
            this.txtDeferred.TextChanged += new System.EventHandler(this.txtDeferred_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(4, 34);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Deferred Fee";
            // 
            // txtDiscount
            // 
            this.txtDiscount.Location = new System.Drawing.Point(107, 53);
            this.txtDiscount.Name = "txtDiscount";
            this.txtDiscount.ReadOnly = true;
            this.txtDiscount.Size = new System.Drawing.Size(154, 20);
            this.txtDiscount.TabIndex = 19;
            this.txtDiscount.Text = "0";
            this.txtDiscount.TextChanged += new System.EventHandler(this.txtDiscount_TextChanged);
            // 
            // lblDiscount
            // 
            this.lblDiscount.AutoSize = true;
            this.lblDiscount.Location = new System.Drawing.Point(4, 60);
            this.lblDiscount.Name = "lblDiscount";
            this.lblDiscount.Size = new System.Drawing.Size(49, 13);
            this.lblDiscount.TabIndex = 18;
            this.lblDiscount.Text = "Discount";
            // 
            // grpMisc
            // 
            this.grpMisc.Controls.Add(this.txtDiscount);
            this.grpMisc.Controls.Add(this.label6);
            this.grpMisc.Controls.Add(this.lblDiscount);
            this.grpMisc.Controls.Add(this.txtDeferred);
            this.grpMisc.Location = new System.Drawing.Point(297, 278);
            this.grpMisc.Name = "grpMisc";
            this.grpMisc.Size = new System.Drawing.Size(282, 94);
            this.grpMisc.TabIndex = 20;
            this.grpMisc.TabStop = false;
            this.grpMisc.Text = "Balance";
            // 
            // grpFees
            // 
            this.grpFees.Controls.Add(this.label12);
            this.grpFees.Controls.Add(this.txtTotalMiscTuit);
            this.grpFees.Controls.Add(this.label7);
            this.grpFees.Controls.Add(this.txtTotal);
            this.grpFees.Location = new System.Drawing.Point(9, 278);
            this.grpFees.Name = "grpFees";
            this.grpFees.Size = new System.Drawing.Size(282, 94);
            this.grpFees.TabIndex = 21;
            this.grpFees.TabStop = false;
            this.grpFees.Text = "Fees";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(4, 60);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(108, 13);
            this.label12.TabIndex = 18;
            this.label12.Text = "Full Misc And  Tuition";
            // 
            // txtTotalMiscTuit
            // 
            this.txtTotalMiscTuit.Location = new System.Drawing.Point(118, 53);
            this.txtTotalMiscTuit.Name = "txtTotalMiscTuit";
            this.txtTotalMiscTuit.ReadOnly = true;
            this.txtTotalMiscTuit.Size = new System.Drawing.Size(154, 20);
            this.txtTotalMiscTuit.TabIndex = 19;
            this.txtTotalMiscTuit.TextChanged += new System.EventHandler(this.txtTotalMiscTuit_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(4, 34);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Full Tuition";
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(118, 27);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(154, 20);
            this.txtTotal.TabIndex = 17;
            this.txtTotal.TextChanged += new System.EventHandler(this.txtTotal_TextChanged_1);
            // 
            // txtDownpayment
            // 
            this.txtDownpayment.Location = new System.Drawing.Point(393, 248);
            this.txtDownpayment.Name = "txtDownpayment";
            this.txtDownpayment.ReadOnly = true;
            this.txtDownpayment.Size = new System.Drawing.Size(179, 20);
            this.txtDownpayment.TabIndex = 25;
            // 
            // Downpayment
            // 
            this.Downpayment.AutoSize = true;
            this.Downpayment.Location = new System.Drawing.Point(271, 248);
            this.Downpayment.Name = "Downpayment";
            this.Downpayment.Size = new System.Drawing.Size(75, 13);
            this.Downpayment.TabIndex = 24;
            this.Downpayment.Text = "Downpayment";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbTransferee);
            this.groupBox1.Controls.Add(this.btnRemoveReferral);
            this.groupBox1.Controls.Add(this.btnAddReferral);
            this.groupBox1.Controls.Add(this.btnRemoveSibling);
            this.groupBox1.Controls.Add(this.btnAddSibling);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.cbAlumni);
            this.groupBox1.Controls.Add(this.dgvReferral);
            this.groupBox1.Controls.Add(this.dgvSibling);
            this.groupBox1.Location = new System.Drawing.Point(9, 374);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(880, 262);
            this.groupBox1.TabIndex = 23;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Additional Info";
            // 
            // cbTransferee
            // 
            this.cbTransferee.AutoSize = true;
            this.cbTransferee.Location = new System.Drawing.Point(223, 19);
            this.cbTransferee.Name = "cbTransferee";
            this.cbTransferee.Size = new System.Drawing.Size(133, 17);
            this.cbTransferee.TabIndex = 10;
            this.cbTransferee.Text = "Considered Transferee";
            this.cbTransferee.UseVisualStyleBackColor = true;
            // 
            // btnRemoveReferral
            // 
            this.btnRemoveReferral.Location = new System.Drawing.Point(485, 230);
            this.btnRemoveReferral.Name = "btnRemoveReferral";
            this.btnRemoveReferral.Size = new System.Drawing.Size(75, 23);
            this.btnRemoveReferral.TabIndex = 9;
            this.btnRemoveReferral.Text = "Remove";
            this.btnRemoveReferral.UseVisualStyleBackColor = true;
            this.btnRemoveReferral.Click += new System.EventHandler(this.btnRemoveReferral_Click);
            // 
            // btnAddReferral
            // 
            this.btnAddReferral.Location = new System.Drawing.Point(404, 231);
            this.btnAddReferral.Name = "btnAddReferral";
            this.btnAddReferral.Size = new System.Drawing.Size(75, 23);
            this.btnAddReferral.TabIndex = 8;
            this.btnAddReferral.TabStop = false;
            this.btnAddReferral.Text = "Add";
            this.btnAddReferral.UseVisualStyleBackColor = true;
            this.btnAddReferral.Click += new System.EventHandler(this.btnAddReferral_Click);
            // 
            // btnRemoveSibling
            // 
            this.btnRemoveSibling.Location = new System.Drawing.Point(91, 230);
            this.btnRemoveSibling.Name = "btnRemoveSibling";
            this.btnRemoveSibling.Size = new System.Drawing.Size(75, 23);
            this.btnRemoveSibling.TabIndex = 7;
            this.btnRemoveSibling.Text = "Remove";
            this.btnRemoveSibling.UseVisualStyleBackColor = true;
            // 
            // btnAddSibling
            // 
            this.btnAddSibling.Location = new System.Drawing.Point(10, 231);
            this.btnAddSibling.Name = "btnAddSibling";
            this.btnAddSibling.Size = new System.Drawing.Size(75, 23);
            this.btnAddSibling.TabIndex = 6;
            this.btnAddSibling.TabStop = false;
            this.btnAddSibling.Text = "Add";
            this.btnAddSibling.UseVisualStyleBackColor = true;
            this.btnAddSibling.Click += new System.EventHandler(this.btnAddSibling_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(403, 47);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(49, 13);
            this.label10.TabIndex = 5;
            this.label10.Text = "Referrals";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(8, 47);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(80, 13);
            this.label9.TabIndex = 4;
            this.label9.Text = "Siblings in SVM";
            // 
            // cbAlumni
            // 
            this.cbAlumni.AutoSize = true;
            this.cbAlumni.Location = new System.Drawing.Point(7, 19);
            this.cbAlumni.Name = "cbAlumni";
            this.cbAlumni.Size = new System.Drawing.Size(191, 17);
            this.cbAlumni.TabIndex = 2;
            this.cbAlumni.Text = "Check if eligible for alumni discount";
            this.cbAlumni.UseVisualStyleBackColor = true;
            this.cbAlumni.CheckedChanged += new System.EventHandler(this.cbAlumni_CheckedChanged);
            // 
            // dgvReferral
            // 
            this.dgvReferral.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReferral.Location = new System.Drawing.Point(406, 63);
            this.dgvReferral.Name = "dgvReferral";
            this.dgvReferral.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvReferral.Size = new System.Drawing.Size(363, 150);
            this.dgvReferral.TabIndex = 1;
            this.dgvReferral.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvReferral_CellContentClick);
            this.dgvReferral.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvReferral_CellContentDoubleClick);
            this.dgvReferral.DoubleClick += new System.EventHandler(this.dgvReferral_DoubleClick);
            // 
            // dgvSibling
            // 
            this.dgvSibling.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSibling.Location = new System.Drawing.Point(8, 63);
            this.dgvSibling.Name = "dgvSibling";
            this.dgvSibling.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSibling.Size = new System.Drawing.Size(368, 150);
            this.dgvSibling.TabIndex = 0;
            this.dgvSibling.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSibling_CellContentClick);
            this.dgvSibling.DoubleClick += new System.EventHandler(this.dgvSibling_DoubleClick);
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            this.fileSystemWatcher1.Changed += new System.IO.FileSystemEventHandler(this.fileSystemWatcher1_Changed);
            // 
            // grpFullBalance
            // 
            this.grpFullBalance.Controls.Add(this.txtDeferredMisc);
            this.grpFullBalance.Controls.Add(this.label8);
            this.grpFullBalance.Controls.Add(this.label11);
            this.grpFullBalance.Controls.Add(this.txtFullMisc);
            this.grpFullBalance.Location = new System.Drawing.Point(585, 278);
            this.grpFullBalance.Name = "grpFullBalance";
            this.grpFullBalance.Size = new System.Drawing.Size(282, 94);
            this.grpFullBalance.TabIndex = 24;
            this.grpFullBalance.TabStop = false;
            this.grpFullBalance.Text = "Balance";
            // 
            // txtDeferredMisc
            // 
            this.txtDeferredMisc.Location = new System.Drawing.Point(107, 53);
            this.txtDeferredMisc.Name = "txtDeferredMisc";
            this.txtDeferredMisc.ReadOnly = true;
            this.txtDeferredMisc.Size = new System.Drawing.Size(154, 20);
            this.txtDeferredMisc.TabIndex = 19;
            this.txtDeferredMisc.Text = "0";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(4, 34);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(48, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "Full Misc";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(4, 60);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(73, 13);
            this.label11.TabIndex = 18;
            this.label11.Text = "Deferred Misc";
            // 
            // txtFullMisc
            // 
            this.txtFullMisc.Location = new System.Drawing.Point(107, 27);
            this.txtFullMisc.Name = "txtFullMisc";
            this.txtFullMisc.ReadOnly = true;
            this.txtFullMisc.Size = new System.Drawing.Size(154, 20);
            this.txtFullMisc.TabIndex = 17;
            // 
            // pbStudent
            // 
            this.pbStudent.Image = global::SVM_Suite.Properties.Resources.images;
            this.pbStudent.Location = new System.Drawing.Point(12, 12);
            this.pbStudent.Name = "pbStudent";
            this.pbStudent.Size = new System.Drawing.Size(225, 228);
            this.pbStudent.TabIndex = 15;
            this.pbStudent.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(640, 209);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 26;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FrmAssessment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(904, 716);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtDownpayment);
            this.Controls.Add(this.grpFullBalance);
            this.Controls.Add(this.Downpayment);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grpFees);
            this.Controls.Add(this.grpMisc);
            this.Controls.Add(this.pbStudent);
            this.Controls.Add(this.cmbPaymentTerm);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtStatus);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAssess);
            this.Controls.Add(this.cmbEducationLevel);
            this.Controls.Add(this.lblGrades);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmbSection);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtStudentName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtStudentNo);
            this.Controls.Add(this.label1);
            this.Name = "FrmAssessment";
            this.Text = "Student Assessment";
            this.Load += new System.EventHandler(this.FrmAssessment_Load);
            this.grpMisc.ResumeLayout(false);
            this.grpMisc.PerformLayout();
            this.grpFees.ResumeLayout(false);
            this.grpFees.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReferral)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSibling)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.grpFullBalance.ResumeLayout(false);
            this.grpFullBalance.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbStudent)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtStudentNo;
        private System.Windows.Forms.TextBox txtStudentName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbSection;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbEducationLevel;
        private System.Windows.Forms.Label lblGrades;
        private System.Windows.Forms.Button btnAssess;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TextBox txtStatus;
        private System.Windows.Forms.ComboBox cmbPaymentTerm;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pbStudent;
        private System.Windows.Forms.TextBox txtDeferred;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtDiscount;
        private System.Windows.Forms.Label lblDiscount;
        private System.Windows.Forms.GroupBox grpMisc;
        private System.Windows.Forms.GroupBox grpFees;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvSibling;
        private System.Windows.Forms.CheckBox cbAlumni;
        private System.Windows.Forms.DataGridView dgvReferral;
        private System.Windows.Forms.Button btnRemoveSibling;
        private System.Windows.Forms.Button btnAddSibling;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnRemoveReferral;
        private System.Windows.Forms.Button btnAddReferral;
        private System.Windows.Forms.TextBox txtDownpayment;
        private System.Windows.Forms.Label Downpayment;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.CheckBox cbTransferee;
        private System.Windows.Forms.GroupBox grpFullBalance;
        private System.Windows.Forms.TextBox txtDeferredMisc;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtFullMisc;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtTotalMiscTuit;
        private System.Windows.Forms.Button button1;
    }
}