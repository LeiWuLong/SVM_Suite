namespace SVM_Suite
{
    partial class FrmUserAccessMaintenance
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
            this.components = new System.ComponentModel.Container();
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblCurrentPassword = new System.Windows.Forms.Label();
            this.txtCurrentPassword = new System.Windows.Forms.TextBox();
            this.lblRepeatPassword = new System.Windows.Forms.Label();
            this.txtRepeatPassword = new System.Windows.Forms.TextBox();
            this.ddlAccessLevel = new System.Windows.Forms.ComboBox();
            this.lblAccessLevel = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.cmbEmployeeNo = new System.Windows.Forms.ComboBox();
            this.lblNewPassword = new System.Windows.Forms.Label();
            this.txtNewPassword = new System.Windows.Forms.TextBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Enabled = false;
            this.lblUsername.Location = new System.Drawing.Point(62, 47);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(70, 13);
            this.lblUsername.TabIndex = 1;
            this.lblUsername.Text = "Employee No";
            this.lblUsername.Visible = false;
            // 
            // lblCurrentPassword
            // 
            this.lblCurrentPassword.AutoSize = true;
            this.lblCurrentPassword.Location = new System.Drawing.Point(42, 91);
            this.lblCurrentPassword.Name = "lblCurrentPassword";
            this.lblCurrentPassword.Size = new System.Drawing.Size(90, 13);
            this.lblCurrentPassword.TabIndex = 3;
            this.lblCurrentPassword.Text = "Current Password";
            // 
            // txtCurrentPassword
            // 
            this.txtCurrentPassword.Location = new System.Drawing.Point(165, 88);
            this.txtCurrentPassword.MaxLength = 16;
            this.txtCurrentPassword.Name = "txtCurrentPassword";
            this.txtCurrentPassword.Size = new System.Drawing.Size(232, 20);
            this.txtCurrentPassword.TabIndex = 2;
            this.txtCurrentPassword.Validated += new System.EventHandler(this.txtCurrentPassword_Validated);
            // 
            // lblRepeatPassword
            // 
            this.lblRepeatPassword.AutoSize = true;
            this.lblRepeatPassword.Location = new System.Drawing.Point(41, 178);
            this.lblRepeatPassword.Name = "lblRepeatPassword";
            this.lblRepeatPassword.Size = new System.Drawing.Size(91, 13);
            this.lblRepeatPassword.TabIndex = 5;
            this.lblRepeatPassword.Text = "Repeat Password";
            // 
            // txtRepeatPassword
            // 
            this.txtRepeatPassword.Location = new System.Drawing.Point(165, 175);
            this.txtRepeatPassword.MaxLength = 16;
            this.txtRepeatPassword.Name = "txtRepeatPassword";
            this.txtRepeatPassword.Size = new System.Drawing.Size(232, 20);
            this.txtRepeatPassword.TabIndex = 4;
            this.txtRepeatPassword.TextChanged += new System.EventHandler(this.txtRepeatPassword_TextChanged);
            // 
            // ddlAccessLevel
            // 
            this.ddlAccessLevel.Enabled = false;
            this.ddlAccessLevel.FormattingEnabled = true;
            this.ddlAccessLevel.Location = new System.Drawing.Point(165, 213);
            this.ddlAccessLevel.Name = "ddlAccessLevel";
            this.ddlAccessLevel.Size = new System.Drawing.Size(232, 21);
            this.ddlAccessLevel.TabIndex = 6;
            this.ddlAccessLevel.Visible = false;
            // 
            // lblAccessLevel
            // 
            this.lblAccessLevel.AutoSize = true;
            this.lblAccessLevel.Enabled = false;
            this.lblAccessLevel.Location = new System.Drawing.Point(61, 221);
            this.lblAccessLevel.Name = "lblAccessLevel";
            this.lblAccessLevel.Size = new System.Drawing.Size(71, 13);
            this.lblAccessLevel.TabIndex = 7;
            this.lblAccessLevel.Text = "Access Level";
            this.lblAccessLevel.Visible = false;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(165, 271);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 8;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(356, 271);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 9;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // cmbEmployeeNo
            // 
            this.cmbEmployeeNo.Enabled = false;
            this.cmbEmployeeNo.Location = new System.Drawing.Point(165, 44);
            this.cmbEmployeeNo.Name = "cmbEmployeeNo";
            this.cmbEmployeeNo.Size = new System.Drawing.Size(151, 21);
            this.cmbEmployeeNo.TabIndex = 0;
            this.cmbEmployeeNo.Visible = false;
            this.cmbEmployeeNo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbEmpNo_KeyDown);
            // 
            // lblNewPassword
            // 
            this.lblNewPassword.AutoSize = true;
            this.lblNewPassword.Location = new System.Drawing.Point(54, 137);
            this.lblNewPassword.Name = "lblNewPassword";
            this.lblNewPassword.Size = new System.Drawing.Size(78, 13);
            this.lblNewPassword.TabIndex = 13;
            this.lblNewPassword.Text = "New Password";
            // 
            // txtNewPassword
            // 
            this.txtNewPassword.Location = new System.Drawing.Point(165, 134);
            this.txtNewPassword.MaxLength = 16;
            this.txtNewPassword.Name = "txtNewPassword";
            this.txtNewPassword.Size = new System.Drawing.Size(232, 20);
            this.txtNewPassword.TabIndex = 12;
            this.txtNewPassword.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.txtNewPassword.Validated += new System.EventHandler(this.textBox1_Validated);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(261, 271);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 11;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // FrmUserAccessMaintenance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(462, 320);
            this.Controls.Add(this.lblNewPassword);
            this.Controls.Add(this.txtNewPassword);
            this.Controls.Add(this.cmbEmployeeNo);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lblAccessLevel);
            this.Controls.Add(this.ddlAccessLevel);
            this.Controls.Add(this.lblRepeatPassword);
            this.Controls.Add(this.txtRepeatPassword);
            this.Controls.Add(this.lblCurrentPassword);
            this.Controls.Add(this.txtCurrentPassword);
            this.Controls.Add(this.lblUsername);
            this.Name = "FrmUserAccessMaintenance";
            this.Text = "User Maintenance";
            this.Load += new System.EventHandler(this.frmUserMaintenance_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblCurrentPassword;
        private System.Windows.Forms.TextBox txtCurrentPassword;
        private System.Windows.Forms.Label lblRepeatPassword;
        private System.Windows.Forms.TextBox txtRepeatPassword;
        private System.Windows.Forms.ComboBox ddlAccessLevel;
        private System.Windows.Forms.Label lblAccessLevel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.ComboBox cmbEmployeeNo;
        private System.Windows.Forms.Label lblNewPassword;
        private System.Windows.Forms.TextBox txtNewPassword;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}