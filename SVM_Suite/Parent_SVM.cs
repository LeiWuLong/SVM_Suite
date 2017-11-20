using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SVM_Suite
{
    public partial class Parent_SVM : Form
    {
        private int childFormNumber = 0;

        public Parent_SVM()
        {
            InitializeComponent();
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            //-rob
            //disable change password menu
            //FrmUserAccessMaintenance frmuserMaintenance = new FrmUserAccessMaintenance();
            //frmuserMaintenance.MdiParent = this;
         
            //frmuserMaintenance.Show();
        }

        private void OpenFile(object sender, EventArgs e)
        {

        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void ToolBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
          //  toolStrip.Visible = toolBarToolStripMenuItem.Checked;
        }

        private void StatusBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
           // statusStrip.Visible = statusBarToolStripMenuItem.Checked;
        }

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void Parent_SVM_Load(object sender, EventArgs e)
        {
            frmLogin frmlogin = new frmLogin();
            frmlogin.Close();

            if (Global.loggedUserAccess == 1)
            {

            }
            else
            {
                mnuUserMaintenance.Enabled = false;
            }
        }

        private void userMaintenanceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmUserListing frmUserListing = new FrmUserListing();
            frmUserListing.ShowDialog();
        }

        private void mnuStudentMaintenance_Click(object sender, EventArgs e)
        {
            Global.formToOpen = "FrmStudentInformation";
           FrmStudentListing frmStudentListing = new FrmStudentListing();
            frmStudentListing.ShowDialog();
        }

        private void mnuFeeMaintenance_Click(object sender, EventArgs e)
        {
            //Global.formToOpen = "TuitionMaintenance";
            FrmTuitionMaintenance frmTUitionMaintenance = new FrmTuitionMaintenance();

            frmTUitionMaintenance.ShowDialog();
        }

        private void makeAssessmentToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void mnuMakeAssessment_Click(object sender, EventArgs e)
        {
            Global.formToOpen = "FrmAssessment";
            FrmStudentListing frmStudentListing = new FrmStudentListing();
            frmStudentListing.ShowDialog();
        }

        private void mnuTuition_Click(object sender, EventArgs e)
        {

        }

        private void vendorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Global.formToOpen = "FrmVendorMaintenance";
            FrmVendorListing frmVendorListing = new FrmVendorListing();
            frmVendorListing.ShowDialog();
        }

        private void mnuMakePayment_Click(object sender, EventArgs e)
        {
            Global.formToOpen = "FrmPaymentMaintenance";
            FrmPaymentListing frmPaymentListing = new FrmPaymentListing();
            frmPaymentListing.ShowDialog();
        }

        private void discountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmDiscountMaintenance frmDiscountMaintenance = new FrmDiscountMaintenance();
            frmDiscountMaintenance.ShowDialog();
        }

        private void dueDateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmDueDateMaintenance frmDueDateMaintenance = new FrmDueDateMaintenance();
            frmDueDateMaintenance.ShowDialog();
        }
    }
}
