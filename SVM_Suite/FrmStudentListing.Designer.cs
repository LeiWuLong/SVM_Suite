namespace SVM_Suite
{
    partial class FrmStudentListing
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
            this.lblSearchBy = new System.Windows.Forms.Label();
            this.dgLoadStudents = new System.Windows.Forms.DataGridView();
            this.colStudentNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStudentName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.rbName = new System.Windows.Forms.RadioButton();
            this.rbStudentNo = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgLoadStudents)).BeginInit();
            this.SuspendLayout();
            // 
            // lblSearchBy
            // 
            this.lblSearchBy.AutoSize = true;
            this.lblSearchBy.Location = new System.Drawing.Point(67, 11);
            this.lblSearchBy.Name = "lblSearchBy";
            this.lblSearchBy.Size = new System.Drawing.Size(59, 13);
            this.lblSearchBy.TabIndex = 0;
            this.lblSearchBy.Text = "Search By ";
            // 
            // dgLoadStudents
            // 
            this.dgLoadStudents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgLoadStudents.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colStudentNumber,
            this.colStudentName});
            this.dgLoadStudents.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.dgLoadStudents.Location = new System.Drawing.Point(16, 60);
            this.dgLoadStudents.Name = "dgLoadStudents";
            this.dgLoadStudents.ReadOnly = true;
            this.dgLoadStudents.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgLoadStudents.Size = new System.Drawing.Size(644, 275);
            this.dgLoadStudents.TabIndex = 1;
            this.dgLoadStudents.ReadOnlyChanged += new System.EventHandler(this.dgLoadStudents_ReadOnlyChanged);
            this.dgLoadStudents.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgLoadStudents_CellContentClick);
            this.dgLoadStudents.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgLoadStudents_DataBindingComplete);
            this.dgLoadStudents.SelectionChanged += new System.EventHandler(this.dgLoadStudents_SelectionChanged);
            this.dgLoadStudents.DoubleClick += new System.EventHandler(this.dgLoadStudents_DoubleClick);
            // 
            // colStudentNumber
            // 
            this.colStudentNumber.HeaderText = "Student Number";
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
            // btnNew
            // 
            this.btnNew.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.btnNew.Location = new System.Drawing.Point(508, 358);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(75, 23);
            this.btnNew.TabIndex = 3;
            this.btnNew.Text = "New";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.btnEdit.Location = new System.Drawing.Point(621, 358);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 23);
            this.btnEdit.TabIndex = 4;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(202, 12);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(220, 20);
            this.txtSearch.TabIndex = 5;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // rbName
            // 
            this.rbName.AutoSize = true;
            this.rbName.Location = new System.Drawing.Point(132, 12);
            this.rbName.Name = "rbName";
            this.rbName.Size = new System.Drawing.Size(53, 17);
            this.rbName.TabIndex = 6;
            this.rbName.TabStop = true;
            this.rbName.Text = "Name";
            this.rbName.UseVisualStyleBackColor = true;
            this.rbName.CheckedChanged += new System.EventHandler(this.rbName_CheckedChanged);
            // 
            // rbStudentNo
            // 
            this.rbStudentNo.AutoSize = true;
            this.rbStudentNo.Location = new System.Drawing.Point(132, 35);
            this.rbStudentNo.Name = "rbStudentNo";
            this.rbStudentNo.Size = new System.Drawing.Size(79, 17);
            this.rbStudentNo.TabIndex = 7;
            this.rbStudentNo.TabStop = true;
            this.rbStudentNo.Text = "Student No";
            this.rbStudentNo.UseVisualStyleBackColor = true;
            this.rbStudentNo.CheckedChanged += new System.EventHandler(this.rbStudentNo_CheckedChanged);
            // 
            // FrmStudentListing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(708, 393);
            this.Controls.Add(this.rbStudentNo);
            this.Controls.Add(this.rbName);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.dgLoadStudents);
            this.Controls.Add(this.lblSearchBy);
            this.Name = "FrmStudentListing";
            this.Text = "Student Listing";
            this.Load += new System.EventHandler(this.FrmStudentListing_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgLoadStudents)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSearchBy;
        private System.Windows.Forms.DataGridView dgLoadStudents;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStudentNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStudentName;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.RadioButton rbName;
        private System.Windows.Forms.RadioButton rbStudentNo;
    }
}