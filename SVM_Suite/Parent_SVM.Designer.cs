namespace SVM_Suite
{
    partial class Parent_SVM
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
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.fileMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuUserMaintenance = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAccessMaintenance = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuStudentMaintenance = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuTuition = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFeeMaintenance = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuVendor = new System.Windows.Forms.ToolStripMenuItem();
            this.bankToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.discountToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modeOfPaymentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.assessmentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuMakeAssessment = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuMakePayment = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.dueDateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip.SuspendLayout();
            this.toolStrip.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileMenu,
            this.mnuTuition,
            this.assessmentToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(632, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "MenuStrip";
            // 
            // fileMenu
            // 
            this.fileMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuUserMaintenance,
            this.mnuAccessMaintenance,
            this.mnuStudentMaintenance,
            this.toolStripSeparator3,
            this.toolStripSeparator4,
            this.toolStripSeparator5,
            this.exitToolStripMenuItem});
            this.fileMenu.ImageTransparentColor = System.Drawing.SystemColors.ActiveBorder;
            this.fileMenu.Name = "fileMenu";
            this.fileMenu.Size = new System.Drawing.Size(114, 20);
            this.fileMenu.Text = "&User Maintenance";
            // 
            // mnuUserMaintenance
            // 
            this.mnuUserMaintenance.Name = "mnuUserMaintenance";
            this.mnuUserMaintenance.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.A)));
            this.mnuUserMaintenance.Size = new System.Drawing.Size(223, 22);
            this.mnuUserMaintenance.Text = "User Maintenance";
            this.mnuUserMaintenance.Click += new System.EventHandler(this.userMaintenanceToolStripMenuItem_Click);
            // 
            // mnuAccessMaintenance
            // 
            this.mnuAccessMaintenance.ImageTransparentColor = System.Drawing.Color.Black;
            this.mnuAccessMaintenance.Name = "mnuAccessMaintenance";
            this.mnuAccessMaintenance.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.mnuAccessMaintenance.Size = new System.Drawing.Size(223, 22);
            this.mnuAccessMaintenance.Text = "Change Password";
            this.mnuAccessMaintenance.ToolTipText = "Create, Edit or Delete SVM Users";
            this.mnuAccessMaintenance.Visible = false;
            this.mnuAccessMaintenance.Click += new System.EventHandler(this.ShowNewForm);
            // 
            // mnuStudentMaintenance
            // 
            this.mnuStudentMaintenance.ImageTransparentColor = System.Drawing.Color.Black;
            this.mnuStudentMaintenance.Name = "mnuStudentMaintenance";
            this.mnuStudentMaintenance.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.S)));
            this.mnuStudentMaintenance.Size = new System.Drawing.Size(223, 22);
            this.mnuStudentMaintenance.Text = "Student Maintenance";
            this.mnuStudentMaintenance.Click += new System.EventHandler(this.mnuStudentMaintenance_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(220, 6);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(220, 6);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(220, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(223, 22);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolsStripMenuItem_Click);
            // 
            // mnuTuition
            // 
            this.mnuTuition.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFeeMaintenance,
            this.mnuVendor,
            this.bankToolStripMenuItem,
            this.discountToolStripMenuItem,
            this.modeOfPaymentToolStripMenuItem,
            this.dueDateToolStripMenuItem});
            this.mnuTuition.Name = "mnuTuition";
            this.mnuTuition.Size = new System.Drawing.Size(88, 20);
            this.mnuTuition.Text = "Maintenance";
            this.mnuTuition.Click += new System.EventHandler(this.mnuTuition_Click);
            // 
            // mnuFeeMaintenance
            // 
            this.mnuFeeMaintenance.ImageTransparentColor = System.Drawing.Color.Black;
            this.mnuFeeMaintenance.Name = "mnuFeeMaintenance";
            this.mnuFeeMaintenance.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
            this.mnuFeeMaintenance.ShowShortcutKeys = false;
            this.mnuFeeMaintenance.Size = new System.Drawing.Size(171, 22);
            this.mnuFeeMaintenance.Text = "&Tuition";
            this.mnuFeeMaintenance.Click += new System.EventHandler(this.mnuFeeMaintenance_Click);
            // 
            // mnuVendor
            // 
            this.mnuVendor.Name = "mnuVendor";
            this.mnuVendor.Size = new System.Drawing.Size(171, 22);
            this.mnuVendor.Text = "Vendor";
            this.mnuVendor.Click += new System.EventHandler(this.vendorToolStripMenuItem_Click);
            // 
            // bankToolStripMenuItem
            // 
            this.bankToolStripMenuItem.Name = "bankToolStripMenuItem";
            this.bankToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.bankToolStripMenuItem.Text = "Bank";
            // 
            // discountToolStripMenuItem
            // 
            this.discountToolStripMenuItem.Name = "discountToolStripMenuItem";
            this.discountToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.discountToolStripMenuItem.Text = "Discount";
            this.discountToolStripMenuItem.Click += new System.EventHandler(this.discountToolStripMenuItem_Click);
            // 
            // modeOfPaymentToolStripMenuItem
            // 
            this.modeOfPaymentToolStripMenuItem.Name = "modeOfPaymentToolStripMenuItem";
            this.modeOfPaymentToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.modeOfPaymentToolStripMenuItem.Text = "Mode Of Payment";
            // 
            // assessmentToolStripMenuItem
            // 
            this.assessmentToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuMakeAssessment,
            this.mnuMakePayment});
            this.assessmentToolStripMenuItem.Name = "assessmentToolStripMenuItem";
            this.assessmentToolStripMenuItem.Size = new System.Drawing.Size(81, 20);
            this.assessmentToolStripMenuItem.Text = "Assessment";
            // 
            // mnuMakeAssessment
            // 
            this.mnuMakeAssessment.Name = "mnuMakeAssessment";
            this.mnuMakeAssessment.Size = new System.Drawing.Size(168, 22);
            this.mnuMakeAssessment.Text = "Make Assessment";
            this.mnuMakeAssessment.Click += new System.EventHandler(this.mnuMakeAssessment_Click);
            // 
            // mnuMakePayment
            // 
            this.mnuMakePayment.Name = "mnuMakePayment";
            this.mnuMakePayment.Size = new System.Drawing.Size(168, 22);
            this.mnuMakePayment.Text = "Make Payment";
            this.mnuMakePayment.Click += new System.EventHandler(this.mnuMakePayment_Click);
            // 
            // toolStrip
            // 
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator1,
            this.toolStripSeparator2});
            this.toolStrip.Location = new System.Drawing.Point(0, 24);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Size = new System.Drawing.Size(632, 25);
            this.toolStrip.TabIndex = 1;
            this.toolStrip.Text = "ToolStrip";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel});
            this.statusStrip.Location = new System.Drawing.Point(0, 431);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(632, 22);
            this.statusStrip.TabIndex = 2;
            this.statusStrip.Text = "StatusStrip";
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(39, 17);
            this.toolStripStatusLabel.Text = "Status";
            // 
            // dueDateToolStripMenuItem
            // 
            this.dueDateToolStripMenuItem.Name = "dueDateToolStripMenuItem";
            this.dueDateToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.dueDateToolStripMenuItem.Text = "Due Date";
            this.dueDateToolStripMenuItem.Click += new System.EventHandler(this.dueDateToolStripMenuItem_Click);
            // 
            // Parent_SVM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 453);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.toolStrip);
            this.Controls.Add(this.menuStrip);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip;
            this.Name = "Parent_SVM";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SV Montessori Suite";
            this.Load += new System.EventHandler(this.Parent_SVM_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion


        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
        private System.Windows.Forms.ToolStripMenuItem fileMenu;
        private System.Windows.Forms.ToolStripMenuItem mnuAccessMaintenance;
        private System.Windows.Forms.ToolStripMenuItem mnuStudentMaintenance;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuTuition;
        private System.Windows.Forms.ToolStripMenuItem mnuFeeMaintenance;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.ToolStripMenuItem mnuUserMaintenance;
        private System.Windows.Forms.ToolStripMenuItem assessmentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuMakeAssessment;
        private System.Windows.Forms.ToolStripMenuItem mnuVendor;
        private System.Windows.Forms.ToolStripMenuItem bankToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem discountToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modeOfPaymentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuMakePayment;
        private System.Windows.Forms.ToolStripMenuItem dueDateToolStripMenuItem;
    }
}



