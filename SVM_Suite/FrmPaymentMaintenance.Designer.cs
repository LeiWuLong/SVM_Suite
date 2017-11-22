namespace SVM_Suite
{
    partial class FrmPaymentMaintenance
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.txtStudentNo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtStudentName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.pbStudent = new System.Windows.Forms.PictureBox();
            this.txtChequeNo = new System.Windows.Forms.TextBox();
            this.lblChequeNo = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbModeOfPayment = new System.Windows.Forms.ComboBox();
            this.dgvStudentPayments = new System.Windows.Forms.DataGridView();
            this.cbPromisory = new System.Windows.Forms.CheckBox();
            this.txtTuitionAmountDue = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.lblTodayIs = new System.Windows.Forms.Label();
            this.lblTransactionDate = new System.Windows.Forms.Label();
            this.grpTuition = new System.Windows.Forms.GroupBox();
            this.txtMiscAmountDue = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtTotalRemainingBal = new System.Windows.Forms.TextBox();
            this.lblTotalAmount = new System.Windows.Forms.Label();
            this.txtTotalAmount = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbDownpayment = new System.Windows.Forms.CheckBox();
            this.cbTransferee = new System.Windows.Forms.CheckBox();
            this.txtEarlyBird = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.lblPenalty = new System.Windows.Forms.Label();
            this.lblEarlyBird = new System.Windows.Forms.Label();
            this.txtPenalty = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbStudent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudentPayments)).BeginInit();
            this.grpTuition.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(292, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Amount";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(48, 229);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 13);
            this.label3.TabIndex = 2;
            // 
            // txtAmount
            // 
            this.txtAmount.Location = new System.Drawing.Point(351, 77);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(136, 20);
            this.txtAmount.TabIndex = 5;
            this.txtAmount.TextChanged += new System.EventHandler(this.txtAmount_TextChanged);
            // 
            // txtStudentNo
            // 
            this.txtStudentNo.Location = new System.Drawing.Point(351, 39);
            this.txtStudentNo.Name = "txtStudentNo";
            this.txtStudentNo.Size = new System.Drawing.Size(136, 20);
            this.txtStudentNo.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(274, 42);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Student No";
            // 
            // txtStudentName
            // 
            this.txtStudentName.Location = new System.Drawing.Point(594, 41);
            this.txtStudentName.Name = "txtStudentName";
            this.txtStudentName.Size = new System.Drawing.Size(173, 20);
            this.txtStudentName.TabIndex = 10;
            this.txtStudentName.TextChanged += new System.EventHandler(this.txtStudentName_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(513, 41);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Student Name";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(541, 581);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 11;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(645, 581);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 12;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // pbStudent
            // 
            this.pbStudent.Image = global::SVM_Suite.Properties.Resources.images;
            this.pbStudent.Location = new System.Drawing.Point(12, 12);
            this.pbStudent.Name = "pbStudent";
            this.pbStudent.Size = new System.Drawing.Size(225, 228);
            this.pbStudent.TabIndex = 13;
            this.pbStudent.TabStop = false;
            // 
            // txtChequeNo
            // 
            this.txtChequeNo.Location = new System.Drawing.Point(594, 113);
            this.txtChequeNo.Name = "txtChequeNo";
            this.txtChequeNo.Size = new System.Drawing.Size(136, 20);
            this.txtChequeNo.TabIndex = 15;
            this.txtChequeNo.TextChanged += new System.EventHandler(this.txtChequeNo_TextChanged);
            // 
            // lblChequeNo
            // 
            this.lblChequeNo.AutoSize = true;
            this.lblChequeNo.Location = new System.Drawing.Point(527, 113);
            this.lblChequeNo.Name = "lblChequeNo";
            this.lblChequeNo.Size = new System.Drawing.Size(61, 13);
            this.lblChequeNo.TabIndex = 14;
            this.lblChequeNo.Text = "Cheque No";
            this.lblChequeNo.Click += new System.EventHandler(this.lblChequeNo_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(498, 79);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Mode of payment";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // cmbModeOfPayment
            // 
            this.cmbModeOfPayment.FormattingEnabled = true;
            this.cmbModeOfPayment.Location = new System.Drawing.Point(593, 76);
            this.cmbModeOfPayment.Name = "cmbModeOfPayment";
            this.cmbModeOfPayment.Size = new System.Drawing.Size(137, 21);
            this.cmbModeOfPayment.TabIndex = 3;
            this.cmbModeOfPayment.SelectedIndexChanged += new System.EventHandler(this.cmbModeOfPayment_SelectedIndexChanged);
            this.cmbModeOfPayment.SelectionChangeCommitted += new System.EventHandler(this.cmbModeOfPayment_SelectionChangeCommitted);
            this.cmbModeOfPayment.SelectedValueChanged += new System.EventHandler(this.cmbModeOfPayment_SelectedValueChanged);
            // 
            // dgvStudentPayments
            // 
            this.dgvStudentPayments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStudentPayments.Location = new System.Drawing.Point(358, 286);
            this.dgvStudentPayments.Name = "dgvStudentPayments";
            this.dgvStudentPayments.Size = new System.Drawing.Size(362, 274);
            this.dgvStudentPayments.TabIndex = 18;
            // 
            // cbPromisory
            // 
            this.cbPromisory.AutoSize = true;
            this.cbPromisory.Location = new System.Drawing.Point(623, 230);
            this.cbPromisory.Name = "cbPromisory";
            this.cbPromisory.Size = new System.Drawing.Size(97, 17);
            this.cbPromisory.TabIndex = 19;
            this.cbPromisory.Text = "Promisory Note";
            this.cbPromisory.UseVisualStyleBackColor = true;
            // 
            // txtTuitionAmountDue
            // 
            this.txtTuitionAmountDue.Location = new System.Drawing.Point(152, 19);
            this.txtTuitionAmountDue.Name = "txtTuitionAmountDue";
            this.txtTuitionAmountDue.ReadOnly = true;
            this.txtTuitionAmountDue.Size = new System.Drawing.Size(136, 20);
            this.txtTuitionAmountDue.TabIndex = 23;
            this.txtTuitionAmountDue.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(37, 22);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(101, 13);
            this.label8.TabIndex = 22;
            this.label8.Text = "Tuition Amount Due";
            // 
            // lblTodayIs
            // 
            this.lblTodayIs.AutoSize = true;
            this.lblTodayIs.Location = new System.Drawing.Point(562, 12);
            this.lblTodayIs.Name = "lblTodayIs";
            this.lblTodayIs.Size = new System.Drawing.Size(50, 13);
            this.lblTodayIs.TabIndex = 24;
            this.lblTodayIs.Text = "Today is ";
            // 
            // lblTransactionDate
            // 
            this.lblTransactionDate.AutoSize = true;
            this.lblTransactionDate.Location = new System.Drawing.Point(608, 12);
            this.lblTransactionDate.Name = "lblTransactionDate";
            this.lblTransactionDate.Size = new System.Drawing.Size(70, 13);
            this.lblTransactionDate.TabIndex = 25;
            this.lblTransactionDate.Text = "Today\'s Time";
            // 
            // grpTuition
            // 
            this.grpTuition.Controls.Add(this.txtMiscAmountDue);
            this.grpTuition.Controls.Add(this.label11);
            this.grpTuition.Controls.Add(this.txtTuitionAmountDue);
            this.grpTuition.Controls.Add(this.label8);
            this.grpTuition.Controls.Add(this.txtTotalRemainingBal);
            this.grpTuition.Controls.Add(this.lblTotalAmount);
            this.grpTuition.Controls.Add(this.txtTotalAmount);
            this.grpTuition.Controls.Add(this.label12);
            this.grpTuition.Location = new System.Drawing.Point(15, 253);
            this.grpTuition.Name = "grpTuition";
            this.grpTuition.Size = new System.Drawing.Size(337, 197);
            this.grpTuition.TabIndex = 26;
            this.grpTuition.TabStop = false;
            this.grpTuition.Text = "Fees";
            this.grpTuition.Enter += new System.EventHandler(this.grpTuition_Enter);
            // 
            // txtMiscAmountDue
            // 
            this.txtMiscAmountDue.Location = new System.Drawing.Point(152, 57);
            this.txtMiscAmountDue.Name = "txtMiscAmountDue";
            this.txtMiscAmountDue.ReadOnly = true;
            this.txtMiscAmountDue.Size = new System.Drawing.Size(136, 20);
            this.txtMiscAmountDue.TabIndex = 23;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(59, 64);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(52, 13);
            this.label11.TabIndex = 22;
            this.label11.Text = "Misc Due";
            // 
            // txtTotalRemainingBal
            // 
            this.txtTotalRemainingBal.Location = new System.Drawing.Point(152, 135);
            this.txtTotalRemainingBal.Name = "txtTotalRemainingBal";
            this.txtTotalRemainingBal.Size = new System.Drawing.Size(136, 20);
            this.txtTotalRemainingBal.TabIndex = 31;
            this.txtTotalRemainingBal.TextChanged += new System.EventHandler(this.txtTotalRemainingBal_TextChanged);
            // 
            // lblTotalAmount
            // 
            this.lblTotalAmount.AutoSize = true;
            this.lblTotalAmount.Location = new System.Drawing.Point(45, 106);
            this.lblTotalAmount.Name = "lblTotalAmount";
            this.lblTotalAmount.Size = new System.Drawing.Size(93, 13);
            this.lblTotalAmount.TabIndex = 28;
            this.lblTotalAmount.Text = "Total Amount Due";
            // 
            // txtTotalAmount
            // 
            this.txtTotalAmount.Location = new System.Drawing.Point(152, 99);
            this.txtTotalAmount.Name = "txtTotalAmount";
            this.txtTotalAmount.ReadOnly = true;
            this.txtTotalAmount.Size = new System.Drawing.Size(136, 20);
            this.txtTotalAmount.TabIndex = 29;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(12, 141);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(126, 13);
            this.label12.TabIndex = 30;
            this.label12.Text = "Total Remaining Balance";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(358, 270);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 13);
            this.label1.TabIndex = 32;
            this.label1.Text = "TRANSACTION LOG";
            // 
            // cbDownpayment
            // 
            this.cbDownpayment.AutoSize = true;
            this.cbDownpayment.Location = new System.Drawing.Point(495, 230);
            this.cbDownpayment.Name = "cbDownpayment";
            this.cbDownpayment.Size = new System.Drawing.Size(94, 17);
            this.cbDownpayment.TabIndex = 33;
            this.cbDownpayment.Text = "Downpayment";
            this.cbDownpayment.UseVisualStyleBackColor = true;
            // 
            // cbTransferee
            // 
            this.cbTransferee.AutoSize = true;
            this.cbTransferee.Location = new System.Drawing.Point(390, 230);
            this.cbTransferee.Name = "cbTransferee";
            this.cbTransferee.Size = new System.Drawing.Size(77, 17);
            this.cbTransferee.TabIndex = 34;
            this.cbTransferee.Text = "Transferee";
            this.cbTransferee.UseVisualStyleBackColor = true;
            // 
            // txtEarlyBird
            // 
            this.txtEarlyBird.Location = new System.Drawing.Point(351, 150);
            this.txtEarlyBird.Name = "txtEarlyBird";
            this.txtEarlyBird.Size = new System.Drawing.Size(136, 20);
            this.txtEarlyBird.TabIndex = 36;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(258, 153);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 13);
            this.label7.TabIndex = 35;
            this.label7.Text = "Early Bird Dcnt";
            // 
            // lblPenalty
            // 
            this.lblPenalty.AutoSize = true;
            this.lblPenalty.Location = new System.Drawing.Point(292, 116);
            this.lblPenalty.Name = "lblPenalty";
            this.lblPenalty.Size = new System.Drawing.Size(42, 13);
            this.lblPenalty.TabIndex = 39;
            this.lblPenalty.Text = "Penalty";
            // 
            // lblEarlyBird
            // 
            this.lblEarlyBird.AutoSize = true;
            this.lblEarlyBird.Location = new System.Drawing.Point(541, 156);
            this.lblEarlyBird.Name = "lblEarlyBird";
            this.lblEarlyBird.Size = new System.Drawing.Size(41, 13);
            this.lblEarlyBird.TabIndex = 40;
            this.lblEarlyBird.Text = "label14";
            // 
            // txtPenalty
            // 
            this.txtPenalty.Location = new System.Drawing.Point(351, 113);
            this.txtPenalty.Name = "txtPenalty";
            this.txtPenalty.Size = new System.Drawing.Size(136, 20);
            this.txtPenalty.TabIndex = 41;
            // 
            // FrmPaymentMaintenance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(772, 621);
            this.Controls.Add(this.txtPenalty);
            this.Controls.Add(this.lblEarlyBird);
            this.Controls.Add(this.lblPenalty);
            this.Controls.Add(this.txtEarlyBird);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cbTransferee);
            this.Controls.Add(this.cbDownpayment);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.grpTuition);
            this.Controls.Add(this.lblTransactionDate);
            this.Controls.Add(this.lblTodayIs);
            this.Controls.Add(this.cbPromisory);
            this.Controls.Add(this.dgvStudentPayments);
            this.Controls.Add(this.txtChequeNo);
            this.Controls.Add(this.lblChequeNo);
            this.Controls.Add(this.pbStudent);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtStudentName);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtStudentNo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtAmount);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmbModeOfPayment);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "FrmPaymentMaintenance";
            this.Text = "Accept Payments";
            this.Load += new System.EventHandler(this.FrmPaymentMaintenance_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbStudent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudentPayments)).EndInit();
            this.grpTuition.ResumeLayout(false);
            this.grpTuition.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.TextBox txtStudentNo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtStudentName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.PictureBox pbStudent;
        private System.Windows.Forms.TextBox txtChequeNo;
        private System.Windows.Forms.Label lblChequeNo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbModeOfPayment;
        private System.Windows.Forms.DataGridView dgvStudentPayments;
        private System.Windows.Forms.CheckBox cbPromisory;
        private System.Windows.Forms.TextBox txtTuitionAmountDue;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblTodayIs;
        private System.Windows.Forms.Label lblTransactionDate;
        private System.Windows.Forms.GroupBox grpTuition;
        private System.Windows.Forms.TextBox txtMiscAmountDue;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtTotalAmount;
        private System.Windows.Forms.Label lblTotalAmount;
        private System.Windows.Forms.TextBox txtTotalRemainingBal;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox cbDownpayment;
        private System.Windows.Forms.CheckBox cbTransferee;
        private System.Windows.Forms.TextBox txtEarlyBird;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblPenalty;
        private System.Windows.Forms.Label lblEarlyBird;
        private System.Windows.Forms.TextBox txtPenalty;
    }
}