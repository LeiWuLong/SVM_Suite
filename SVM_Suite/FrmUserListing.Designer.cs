namespace SVM_Suite
{
    partial class FrmUserListing
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
            this.rbEmployeeNo = new System.Windows.Forms.RadioButton();
            this.rbEmployeeName = new System.Windows.Forms.RadioButton();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.dgLoadEmployees = new System.Windows.Forms.DataGridView();
            this.colStudentNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStudentName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblSearchBy = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgLoadEmployees)).BeginInit();
            this.SuspendLayout();
            // 
            // rbEmployeeNo
            // 
            this.rbEmployeeNo.AutoSize = true;
            this.rbEmployeeNo.Location = new System.Drawing.Point(131, 35);
            this.rbEmployeeNo.Name = "rbEmployeeNo";
            this.rbEmployeeNo.Size = new System.Drawing.Size(88, 17);
            this.rbEmployeeNo.TabIndex = 14;
            this.rbEmployeeNo.TabStop = true;
            this.rbEmployeeNo.Text = "Employee No";
            this.rbEmployeeNo.UseVisualStyleBackColor = true;
            // 
            // rbEmployeeName
            // 
            this.rbEmployeeName.AutoSize = true;
            this.rbEmployeeName.Location = new System.Drawing.Point(131, 12);
            this.rbEmployeeName.Name = "rbEmployeeName";
            this.rbEmployeeName.Size = new System.Drawing.Size(53, 17);
            this.rbEmployeeName.TabIndex = 13;
            this.rbEmployeeName.TabStop = true;
            this.rbEmployeeName.Text = "Name";
            this.rbEmployeeName.UseVisualStyleBackColor = true;
            this.rbEmployeeName.CheckedChanged += new System.EventHandler(this.rbEmployeeName_CheckedChanged);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(216, 15);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(244, 20);
            this.txtSearch.TabIndex = 12;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(555, 357);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(99, 24);
            this.btnCancel.TabIndex = 11;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(442, 357);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(99, 24);
            this.btnNew.TabIndex = 10;
            this.btnNew.Text = "New";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // dgLoadEmployees
            // 
            this.dgLoadEmployees.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgLoadEmployees.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colStudentNumber,
            this.colStudentName});
            this.dgLoadEmployees.Location = new System.Drawing.Point(12, 70);
            this.dgLoadEmployees.Name = "dgLoadEmployees";
            this.dgLoadEmployees.ReadOnly = true;
            this.dgLoadEmployees.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgLoadEmployees.Size = new System.Drawing.Size(668, 258);
            this.dgLoadEmployees.TabIndex = 9;
            this.dgLoadEmployees.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgLoadEmployees_CellContentClick);
            this.dgLoadEmployees.DoubleClick += new System.EventHandler(this.dgLoadEmployees_DoubleClick);
            // 
            // colStudentNumber
            // 
            this.colStudentNumber.HeaderText = "Employee Number";
            this.colStudentNumber.Name = "colStudentNumber";
            this.colStudentNumber.ReadOnly = true;
            this.colStudentNumber.Width = 200;
            // 
            // colStudentName
            // 
            this.colStudentName.HeaderText = "Name";
            this.colStudentName.Name = "colStudentName";
            this.colStudentName.ReadOnly = true;
            this.colStudentName.Width = 400;
            // 
            // lblSearchBy
            // 
            this.lblSearchBy.AutoSize = true;
            this.lblSearchBy.Location = new System.Drawing.Point(70, 15);
            this.lblSearchBy.Name = "lblSearchBy";
            this.lblSearchBy.Size = new System.Drawing.Size(59, 13);
            this.lblSearchBy.TabIndex = 8;
            this.lblSearchBy.Text = "Search By ";
            // 
            // FrmUserListing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(750, 449);
            this.Controls.Add(this.rbEmployeeNo);
            this.Controls.Add(this.rbEmployeeName);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.dgLoadEmployees);
            this.Controls.Add(this.lblSearchBy);
            this.Name = "FrmUserListing";
            this.Text = "User Listing";
            this.Load += new System.EventHandler(this.FrmUserListing_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgLoadEmployees)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rbEmployeeNo;
        private System.Windows.Forms.RadioButton rbEmployeeName;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.DataGridView dgLoadEmployees;
        private System.Windows.Forms.Label lblSearchBy;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStudentNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStudentName;
    }
}