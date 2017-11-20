namespace SVM_Suite
{
    partial class FrmDiscountMaintenance
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
            this.numDiscount = new System.Windows.Forms.NumericUpDown();
            this.numVar = new System.Windows.Forms.NumericUpDown();
            this.btnDelete = new System.Windows.Forms.Button();
            this.lblDiscount = new System.Windows.Forms.Label();
            this.lblVar = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnInsert = new System.Windows.Forms.Button();
            this.dgvDiscount = new System.Windows.Forms.DataGridView();
            this.cmbDiscountType = new System.Windows.Forms.ComboBox();
            this.lblDiscountType = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numDiscount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numVar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDiscount)).BeginInit();
            this.SuspendLayout();
            // 
            // numDiscount
            // 
            this.numDiscount.Location = new System.Drawing.Point(485, 172);
            this.numDiscount.Name = "numDiscount";
            this.numDiscount.Size = new System.Drawing.Size(120, 20);
            this.numDiscount.TabIndex = 20;
            // 
            // numVar
            // 
            this.numVar.Location = new System.Drawing.Point(485, 135);
            this.numVar.Name = "numVar";
            this.numVar.Size = new System.Drawing.Size(120, 20);
            this.numVar.TabIndex = 19;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(579, 245);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 18;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // lblDiscount
            // 
            this.lblDiscount.AutoSize = true;
            this.lblDiscount.Location = new System.Drawing.Point(411, 172);
            this.lblDiscount.Name = "lblDiscount";
            this.lblDiscount.Size = new System.Drawing.Size(57, 13);
            this.lblDiscount.TabIndex = 17;
            this.lblDiscount.Text = "%Discount";
            // 
            // lblVar
            // 
            this.lblVar.AutoSize = true;
            this.lblVar.Location = new System.Drawing.Point(373, 143);
            this.lblVar.Name = "lblVar";
            this.lblVar.Size = new System.Drawing.Size(95, 13);
            this.lblVar.TabIndex = 16;
            this.lblVar.Text = "Number of Siblings";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(485, 245);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 15;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(392, 245);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(75, 23);
            this.btnInsert.TabIndex = 14;
            this.btnInsert.Text = "Insert";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // dgvDiscount
            // 
            this.dgvDiscount.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDiscount.Location = new System.Drawing.Point(25, 85);
            this.dgvDiscount.Name = "dgvDiscount";
            this.dgvDiscount.Size = new System.Drawing.Size(281, 257);
            this.dgvDiscount.TabIndex = 13;
            // 
            // cmbDiscountType
            // 
            this.cmbDiscountType.FormattingEnabled = true;
            this.cmbDiscountType.Location = new System.Drawing.Point(94, 29);
            this.cmbDiscountType.Name = "cmbDiscountType";
            this.cmbDiscountType.Size = new System.Drawing.Size(212, 21);
            this.cmbDiscountType.TabIndex = 21;
            this.cmbDiscountType.SelectedIndexChanged += new System.EventHandler(this.cmbDiscountType_SelectedIndexChanged);
            this.cmbDiscountType.SelectionChangeCommitted += new System.EventHandler(this.cmbDiscountType_SelectionChangeCommitted);
            // 
            // lblDiscountType
            // 
            this.lblDiscountType.AutoSize = true;
            this.lblDiscountType.Location = new System.Drawing.Point(12, 32);
            this.lblDiscountType.Name = "lblDiscountType";
            this.lblDiscountType.Size = new System.Drawing.Size(76, 13);
            this.lblDiscountType.TabIndex = 22;
            this.lblDiscountType.Text = "Discount Type";
            this.lblDiscountType.Click += new System.EventHandler(this.lblDiscountType_Click);
            // 
            // FrmDiscountMaintenance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(709, 387);
            this.Controls.Add(this.lblDiscountType);
            this.Controls.Add(this.cmbDiscountType);
            this.Controls.Add(this.numDiscount);
            this.Controls.Add(this.numVar);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.lblDiscount);
            this.Controls.Add(this.lblVar);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.dgvDiscount);
            this.Name = "FrmDiscountMaintenance";
            this.Text = "Discount Maintenance";
            this.Load += new System.EventHandler(this.FrmDiscountMaintenance_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numDiscount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numVar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDiscount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown numDiscount;
        private System.Windows.Forms.NumericUpDown numVar;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label lblDiscount;
        private System.Windows.Forms.Label lblVar;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.DataGridView dgvDiscount;
        private System.Windows.Forms.ComboBox cmbDiscountType;
        private System.Windows.Forms.Label lblDiscountType;
    }
}