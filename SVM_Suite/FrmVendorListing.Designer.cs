namespace SVM_Suite
{
    partial class FrmVendorListing
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
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.dgLoadVendors = new System.Windows.Forms.DataGridView();
            this.colVendorCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colVendorName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colVendorDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rbVendorCode = new System.Windows.Forms.RadioButton();
            this.rbVendorName = new System.Windows.Forms.RadioButton();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.lblSearchBy = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgLoadVendors)).BeginInit();
            this.SuspendLayout();
            // 
            // btnEdit
            // 
            this.btnEdit.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.btnEdit.Location = new System.Drawing.Point(613, 365);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 23);
            this.btnEdit.TabIndex = 11;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            // 
            // btnNew
            // 
            this.btnNew.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.btnNew.Location = new System.Drawing.Point(520, 365);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(75, 23);
            this.btnNew.TabIndex = 10;
            this.btnNew.Text = "New";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // dgLoadVendors
            // 
            this.dgLoadVendors.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgLoadVendors.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colVendorCode,
            this.colVendorName,
            this.colVendorDescription});
            this.dgLoadVendors.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.dgLoadVendors.Location = new System.Drawing.Point(12, 71);
            this.dgLoadVendors.Name = "dgLoadVendors";
            this.dgLoadVendors.ReadOnly = true;
            this.dgLoadVendors.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgLoadVendors.Size = new System.Drawing.Size(644, 275);
            this.dgLoadVendors.TabIndex = 9;
            this.dgLoadVendors.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgLoadVendors_CellContentClick);
            this.dgLoadVendors.DoubleClick += new System.EventHandler(this.dgLoadVendors_DoubleClick);
            // 
            // colVendorCode
            // 
            this.colVendorCode.HeaderText = "Vendor Code";
            this.colVendorCode.Name = "colVendorCode";
            this.colVendorCode.ReadOnly = true;
            this.colVendorCode.Width = 200;
            // 
            // colVendorName
            // 
            this.colVendorName.HeaderText = "Vendor Name";
            this.colVendorName.Name = "colVendorName";
            this.colVendorName.ReadOnly = true;
            this.colVendorName.Width = 200;
            // 
            // colVendorDescription
            // 
            this.colVendorDescription.HeaderText = "Vendor Description";
            this.colVendorDescription.Name = "colVendorDescription";
            this.colVendorDescription.ReadOnly = true;
            // 
            // rbVendorCode
            // 
            this.rbVendorCode.AutoSize = true;
            this.rbVendorCode.Location = new System.Drawing.Point(121, 35);
            this.rbVendorCode.Name = "rbVendorCode";
            this.rbVendorCode.Size = new System.Drawing.Size(87, 17);
            this.rbVendorCode.TabIndex = 15;
            this.rbVendorCode.TabStop = true;
            this.rbVendorCode.Text = "Vendor Code";
            this.rbVendorCode.UseVisualStyleBackColor = true;
            this.rbVendorCode.CheckedChanged += new System.EventHandler(this.rbVendorCode_CheckedChanged);
            // 
            // rbVendorName
            // 
            this.rbVendorName.AutoSize = true;
            this.rbVendorName.Location = new System.Drawing.Point(121, 12);
            this.rbVendorName.Name = "rbVendorName";
            this.rbVendorName.Size = new System.Drawing.Size(90, 17);
            this.rbVendorName.TabIndex = 14;
            this.rbVendorName.TabStop = true;
            this.rbVendorName.Text = "Vendor Name";
            this.rbVendorName.UseVisualStyleBackColor = true;
            this.rbVendorName.CheckedChanged += new System.EventHandler(this.rbVendorName_CheckedChanged);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(217, 12);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(220, 20);
            this.txtSearch.TabIndex = 13;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // lblSearchBy
            // 
            this.lblSearchBy.AutoSize = true;
            this.lblSearchBy.Location = new System.Drawing.Point(56, 11);
            this.lblSearchBy.Name = "lblSearchBy";
            this.lblSearchBy.Size = new System.Drawing.Size(59, 13);
            this.lblSearchBy.TabIndex = 12;
            this.lblSearchBy.Text = "Search By ";
            this.lblSearchBy.Click += new System.EventHandler(this.lblSearchBy_Click);
            // 
            // FrmVendorListing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(720, 444);
            this.Controls.Add(this.rbVendorCode);
            this.Controls.Add(this.rbVendorName);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.lblSearchBy);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.dgLoadVendors);
            this.Name = "FrmVendorListing";
            this.Text = "FmVendorListing";
            this.Load += new System.EventHandler(this.FrmVendorListing_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgLoadVendors)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.DataGridView dgLoadVendors;
        private System.Windows.Forms.DataGridViewTextBoxColumn colVendorCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn colVendorName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colVendorDescription;
        private System.Windows.Forms.RadioButton rbVendorCode;
        private System.Windows.Forms.RadioButton rbVendorName;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label lblSearchBy;
    }
}