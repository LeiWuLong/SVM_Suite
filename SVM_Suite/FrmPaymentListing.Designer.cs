namespace SVM_Suite
{
    partial class FrmPaymentListing
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
            this.tbStudentNo = new System.Windows.Forms.RadioButton();
            this.rbStudentName = new System.Windows.Forms.RadioButton();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.dgLoadPayment = new System.Windows.Forms.DataGridView();
            this.colStudentNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMiddleName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmbModeOfPayment = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.colAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblSearchBy = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgLoadPayment)).BeginInit();
            this.SuspendLayout();
            // 
            // tbStudentNo
            // 
            this.tbStudentNo.AutoSize = true;
            this.tbStudentNo.Location = new System.Drawing.Point(128, 32);
            this.tbStudentNo.Name = "tbStudentNo";
            this.tbStudentNo.Size = new System.Drawing.Size(79, 17);
            this.tbStudentNo.TabIndex = 21;
            this.tbStudentNo.TabStop = true;
            this.tbStudentNo.Text = "Student No";
            this.tbStudentNo.UseVisualStyleBackColor = true;
            // 
            // rbStudentName
            // 
            this.rbStudentName.AutoSize = true;
            this.rbStudentName.Location = new System.Drawing.Point(128, 9);
            this.rbStudentName.Name = "rbStudentName";
            this.rbStudentName.Size = new System.Drawing.Size(53, 17);
            this.rbStudentName.TabIndex = 20;
            this.rbStudentName.TabStop = true;
            this.rbStudentName.Text = "Name";
            this.rbStudentName.UseVisualStyleBackColor = true;
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(213, 12);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(244, 20);
            this.txtSearch.TabIndex = 19;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(552, 354);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(99, 24);
            this.btnCancel.TabIndex = 18;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(439, 354);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(99, 24);
            this.btnNew.TabIndex = 17;
            this.btnNew.Text = "New";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // dgLoadPayment
            // 
            this.dgLoadPayment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgLoadPayment.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colStudentNo,
            this.colFirstName,
            this.colMiddleName,
            this.colLastName,
            this.cmbModeOfPayment,
            this.colAmount});
            this.dgLoadPayment.Location = new System.Drawing.Point(9, 67);
            this.dgLoadPayment.Name = "dgLoadPayment";
            this.dgLoadPayment.ReadOnly = true;
            this.dgLoadPayment.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgLoadPayment.Size = new System.Drawing.Size(668, 258);
            this.dgLoadPayment.TabIndex = 16;
            this.dgLoadPayment.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgLoadPayment_CellContentClick);
            this.dgLoadPayment.DoubleClick += new System.EventHandler(this.dgLoadPayment_DoubleClick);
            // 
            // colStudentNo
            // 
            this.colStudentNo.HeaderText = "Student No";
            this.colStudentNo.Name = "colStudentNo";
            this.colStudentNo.ReadOnly = true;
            this.colStudentNo.Width = 200;
            // 
            // colFirstName
            // 
            this.colFirstName.HeaderText = "First Name";
            this.colFirstName.Name = "colFirstName";
            this.colFirstName.ReadOnly = true;
            this.colFirstName.Width = 400;
            // 
            // colMiddleName
            // 
            this.colMiddleName.HeaderText = "Middle NAme";
            this.colMiddleName.Name = "colMiddleName";
            this.colMiddleName.ReadOnly = true;
            // 
            // colLastName
            // 
            this.colLastName.HeaderText = "Last Name";
            this.colLastName.Name = "colLastName";
            this.colLastName.ReadOnly = true;
            // 
            // cmbModeOfPayment
            // 
            this.cmbModeOfPayment.HeaderText = "Mode Of Pyment";
            this.cmbModeOfPayment.Name = "cmbModeOfPayment";
            this.cmbModeOfPayment.ReadOnly = true;
            // 
            // colAmount
            // 
            this.colAmount.HeaderText = "Amount";
            this.colAmount.Name = "colAmount";
            this.colAmount.ReadOnly = true;
            // 
            // lblSearchBy
            // 
            this.lblSearchBy.AutoSize = true;
            this.lblSearchBy.Location = new System.Drawing.Point(67, 12);
            this.lblSearchBy.Name = "lblSearchBy";
            this.lblSearchBy.Size = new System.Drawing.Size(59, 13);
            this.lblSearchBy.TabIndex = 15;
            this.lblSearchBy.Text = "Search By ";
            // 
            // FrmPaymentListing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(722, 429);
            this.Controls.Add(this.tbStudentNo);
            this.Controls.Add(this.rbStudentName);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.dgLoadPayment);
            this.Controls.Add(this.lblSearchBy);
            this.Name = "FrmPaymentListing";
            this.Text = "Payments Listing";
            this.Load += new System.EventHandler(this.FrmPaymentListing_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgLoadPayment)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton tbStudentNo;
        private System.Windows.Forms.RadioButton rbStudentName;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.DataGridView dgLoadPayment;
        private System.Windows.Forms.Label lblSearchBy;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStudentNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFirstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMiddleName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLastName;
        private System.Windows.Forms.DataGridViewComboBoxColumn cmbModeOfPayment;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAmount;
    }
}