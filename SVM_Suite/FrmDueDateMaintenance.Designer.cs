namespace SVM_Suite
{
    partial class FrmDueDateMaintenance
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
            this.dgvDueDates = new System.Windows.Forms.DataGridView();
            this.cmbPaymentTerm = new System.Windows.Forms.ComboBox();
            this.lblPaymentTerm = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblDesc = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDueDates)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvDueDates
            // 
            this.dgvDueDates.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDueDates.Location = new System.Drawing.Point(33, 105);
            this.dgvDueDates.Name = "dgvDueDates";
            this.dgvDueDates.Size = new System.Drawing.Size(450, 221);
            this.dgvDueDates.TabIndex = 0;
            // 
            // cmbPaymentTerm
            // 
            this.cmbPaymentTerm.FormattingEnabled = true;
            this.cmbPaymentTerm.Location = new System.Drawing.Point(124, 60);
            this.cmbPaymentTerm.Name = "cmbPaymentTerm";
            this.cmbPaymentTerm.Size = new System.Drawing.Size(175, 21);
            this.cmbPaymentTerm.TabIndex = 1;
            this.cmbPaymentTerm.SelectionChangeCommitted += new System.EventHandler(this.cmbPaymentTerm_SelectionChangeCommitted);
            // 
            // lblPaymentTerm
            // 
            this.lblPaymentTerm.AutoSize = true;
            this.lblPaymentTerm.Location = new System.Drawing.Point(32, 63);
            this.lblPaymentTerm.Name = "lblPaymentTerm";
            this.lblPaymentTerm.Size = new System.Drawing.Size(75, 13);
            this.lblPaymentTerm.TabIndex = 2;
            this.lblPaymentTerm.Text = "Payment Term";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(306, 352);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(408, 352);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lblDesc
            // 
            this.lblDesc.AutoSize = true;
            this.lblDesc.Location = new System.Drawing.Point(33, 13);
            this.lblDesc.Name = "lblDesc";
            this.lblDesc.Size = new System.Drawing.Size(35, 13);
            this.lblDesc.TabIndex = 5;
            this.lblDesc.Text = "label1";
            // 
            // FrmDueDateMaintenance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(518, 395);
            this.Controls.Add(this.lblDesc);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lblPaymentTerm);
            this.Controls.Add(this.cmbPaymentTerm);
            this.Controls.Add(this.dgvDueDates);
            this.Name = "FrmDueDateMaintenance";
            this.Text = "Dates Maintenance";
            this.Load += new System.EventHandler(this.FrmDueDateMaintenance_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDueDates)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDueDates;
        private System.Windows.Forms.ComboBox cmbPaymentTerm;
        private System.Windows.Forms.Label lblPaymentTerm;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblDesc;
    }
}