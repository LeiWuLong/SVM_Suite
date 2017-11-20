namespace SVM_Suite
{
    partial class FrmVendorMaintenance
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
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblVendorName = new System.Windows.Forms.Label();
            this.lblVendorCode = new System.Windows.Forms.Label();
            this.lblVendorDesc = new System.Windows.Forms.Label();
            this.txtVendorName = new System.Windows.Forms.TextBox();
            this.txtVendorDesc = new System.Windows.Forms.TextBox();
            this.txtVendorCode = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(185, 186);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(283, 186);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lblVendorName
            // 
            this.lblVendorName.AutoSize = true;
            this.lblVendorName.Location = new System.Drawing.Point(37, 39);
            this.lblVendorName.Name = "lblVendorName";
            this.lblVendorName.Size = new System.Drawing.Size(72, 13);
            this.lblVendorName.TabIndex = 2;
            this.lblVendorName.Text = "Vendor Name";
            // 
            // lblVendorCode
            // 
            this.lblVendorCode.AutoSize = true;
            this.lblVendorCode.Location = new System.Drawing.Point(40, 90);
            this.lblVendorCode.Name = "lblVendorCode";
            this.lblVendorCode.Size = new System.Drawing.Size(69, 13);
            this.lblVendorCode.TabIndex = 3;
            this.lblVendorCode.Text = "Vendor Code";
            // 
            // lblVendorDesc
            // 
            this.lblVendorDesc.AutoSize = true;
            this.lblVendorDesc.Location = new System.Drawing.Point(40, 139);
            this.lblVendorDesc.Name = "lblVendorDesc";
            this.lblVendorDesc.Size = new System.Drawing.Size(69, 13);
            this.lblVendorDesc.TabIndex = 4;
            this.lblVendorDesc.Text = "Vendor Desc";
            // 
            // txtVendorName
            // 
            this.txtVendorName.Location = new System.Drawing.Point(119, 36);
            this.txtVendorName.Name = "txtVendorName";
            this.txtVendorName.Size = new System.Drawing.Size(173, 20);
            this.txtVendorName.TabIndex = 5;
            // 
            // txtVendorDesc
            // 
            this.txtVendorDesc.Location = new System.Drawing.Point(119, 132);
            this.txtVendorDesc.Name = "txtVendorDesc";
            this.txtVendorDesc.Size = new System.Drawing.Size(173, 20);
            this.txtVendorDesc.TabIndex = 6;
            // 
            // txtVendorCode
            // 
            this.txtVendorCode.Location = new System.Drawing.Point(119, 83);
            this.txtVendorCode.Name = "txtVendorCode";
            this.txtVendorCode.Size = new System.Drawing.Size(173, 20);
            this.txtVendorCode.TabIndex = 7;
            // 
            // FrmVendorMaintenance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(370, 256);
            this.Controls.Add(this.txtVendorCode);
            this.Controls.Add(this.txtVendorDesc);
            this.Controls.Add(this.txtVendorName);
            this.Controls.Add(this.lblVendorDesc);
            this.Controls.Add(this.lblVendorCode);
            this.Controls.Add(this.lblVendorName);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Name = "FrmVendorMaintenance";
            this.Text = "Vendor Maintenance";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmVendorMaintenance_FormClosed);
            this.Load += new System.EventHandler(this.FrmVendorMaintenance_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblVendorName;
        private System.Windows.Forms.Label lblVendorCode;
        private System.Windows.Forms.Label lblVendorDesc;
        private System.Windows.Forms.TextBox txtVendorName;
        private System.Windows.Forms.TextBox txtVendorDesc;
        private System.Windows.Forms.TextBox txtVendorCode;
    }
}