using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SVM_Logic;
using SVM_Processor.Models;
using SVM_Processor.DTO;
using SVM_Contracts;


namespace SVM_Suite
{
    public partial class FrmTuitionMaintenance : Form
    {
        public FrmTuitionMaintenance()
        {
            InitializeComponent();
        }

        ITuitionService _tuitionService = new TuitionService();

        private void txtTodlrTuitQuartr_TextChanged(object sender, EventArgs e)
        {
            // txtTodlrTuitQuartr.Text = Convert.ToString(Convert.ToInt32(txtTodlrTuitQuartr.Text) != 0 ? Convert.ToInt32(txtTodlrTuidMonth.Text) / 4 : 0 );
        }

        private void btnSaveToddler_Click(object sender, EventArgs e)
        {

        }

        private void txtTodlrTuitAnnual_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCompute_Click(object sender, EventArgs e)
        {
            txtToddlerTuitQuarterly.Text = Convert.ToString(Convert.ToInt32(txtToddlerTuitAnnual.Text) / 4);
            txtToddlerTuitMonthly.Text = Convert.ToString(Convert.ToInt32(txtToddlerTuitAnnual.Text) / 12);
            txtToddlerMiscQuarterly.Text = Convert.ToString(Convert.ToInt32(txtToddlerMiscAnnual.Text) / 4);
            txtToddlerMiscMonthly.Text = Convert.ToString(Convert.ToInt32(txtToddlerMiscAnnual.Text) / 12);
        }

        private void grpToddlerAndJunior_Enter(object sender, EventArgs e)
        {

        }

        private void btnComputeCasa_Click(object sender, EventArgs e)
        {
            double o;



            //txtToddlerTuitBiAnnual.Text = Double.TryParse(txtToddlerTuitAnnual.Text, out o) || Double.TryParse(txtToddlerTuitAnnual.Text, out o)? (Convert.ToDouble(txtToddlerTuitAnnual.Text) / 2).ToString(): 0.00.ToString();
            //txtToddlerTuitQuarterly.Text = Double.TryParse(txtToddlerTuitAnnual.Text, out o) || Double.TryParse(txtToddlerTuitAnnual.Text, out o) ? (Convert.ToDouble(txtToddlerTuitAnnual.Text) / 4).ToString() : 0.00.ToString();
            //txtToddlerTuitMonthly.Text = Double.TryParse(txtToddlerTuitAnnual.Text, out o) || Double.TryParse(txtToddlerTuitAnnual.Text, out o) ? (Convert.ToDouble(txtToddlerTuitAnnual.Text) / 12).ToString() : 0.00.ToString();

            //txtSeniorTuitBiAnnual.Text = (Convert.ToDouble(txtSeniorTuitAnnual.Text) / 2).ToString();
            //txtSeniorTuitQuarterly.Text = (Convert.ToDouble(txtSeniorTuitAnnual.Text) / 4).ToString();
            //txtSeniorTuitMonthly.Text = (Convert.ToDouble(txtSeniorTuitAnnual.Text) / 12).ToString();

            //txtSeniorTuitBiAnnual.Text = (Convert.ToDouble(txtSeniorTuitAnnual.Text) / 2).ToString();
            //txtSeniorTuitQuarterly.Text = (Convert.ToDouble(txtSeniorTuitAnnual.Text) / 4).ToString();
            //txtSeniorTuitMonthly.Text = (Convert.ToDouble(txtSeniorTuitAnnual.Text) / 12).ToString();

            //txtToddlerMiscBiAnnual.Text = (Convert.ToDouble(txtToddlerMiscAnnual.Text) / 2).ToString();
            //txtToddlerMiscQuarterly.Text = (Convert.ToDouble(txtToddlerMiscAnnual.Text) / 4).ToString();
            //txtToddlerMiscMonthly.Text = (Convert.ToDouble(txtToddlerMiscAnnual.Text) / 12).ToString();

            //txtSeniorBiAnnualMisc.Text = (Convert.ToDouble(txtSeniorMiscAnnual.Text) / 2).ToString();
            //txtSeniorMiscQuarterly.Text = (Convert.ToDouble(txtSeniorMiscQuarterly.Text) / 4).ToString();
            //txtSeniorMiscMonthly.Text = (Convert.ToDouble(txtSeniorMiscAnnual.Text) / 12).ToString();

            //txtSeniorBiAnnualMisc.Text = (Convert.ToDouble(txtSeniorMiscAnnual.Text) / 2).ToString();
            //txtSeniorMiscQuarterly.Text = (Convert.ToDouble(txtSeniorMiscQuarterly.Text) / 4).ToString();
            //txtSeniorMiscMonthly.Text = (Convert.ToDouble(txtSeniorMiscAnnual.Text) / 12).ToString();


        }

        private void txtSeniorMonthlyMisc_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSaveCasa_Click(object sender, EventArgs e)
        {

            List<tbldimenrollment> lstDimEnrollment = _tuitionService.GetAllDimEnrollment();
            double o;

            foreach (Control ctrl in this.Controls)
            {
                // You can use the following if condition to target the specific control
                // if (ctrl.Name.Equals("groupBox1"))
                if (ctrl.ToString().StartsWith("System.Windows.Forms.GroupBox"))
                {
                    foreach (Control c in ctrl.Controls)
                    {
                        if (c is TextBox) // && (c as TextBox).Name.Contains(item.EnrollmentCode))
                        {
                            foreach (var item in lstDimEnrollment)
                            {
                                //testing
                                TextBox tbx = this.Controls.Find("txt" + item.EnrollmentCode, true).FirstOrDefault() as TextBox;

                                if (tbx != null && !String.IsNullOrEmpty(tbx.Text))
                                {
                                    var a = tbx.Text;
                                    _tuitionService.SaveFee(Convert.ToDouble(a), item.DimEnrollmentId);
                                }
                                else
                                {
                                    _tuitionService.SaveFee(0.00, item.DimEnrollmentId);
                                }
                            }
                        }
                    }
                }

            }



        }

        private void grpAdvanced_Enter(object sender, EventArgs e)
        {

        }

        private void btnSaveG1G5_Click(object sender, EventArgs e)
        {
            List<tbldimenrollment> lstDimEnrollment = _tuitionService.GetAllDimEnrollment();
            double o;

            foreach (Control ctrl in this.Controls)
            {
                // You can use the following if condition to target the specific control
                // if (ctrl.Name.Equals("groupBox1"))
                if (ctrl.ToString().StartsWith("System.Windows.Forms.GroupBox"))
                {
                    foreach (Control c in ctrl.Controls)
                    {
                        if (c is TextBox) // && (c as TextBox).Name.Contains(item.EnrollmentCode))
                        {
                            foreach (var item in lstDimEnrollment)
                            {
                                //testing
                                TextBox tbx = this.Controls.Find("txt" + item.EnrollmentCode, true).FirstOrDefault() as TextBox;

                                if (tbx != null && !String.IsNullOrEmpty(tbx.Text))
                                {
                                    var a = tbx.Text;
                                    _tuitionService.SaveFee(Convert.ToDouble(a), item.DimEnrollmentId);
                                }
                                else
                                {
                                    _tuitionService.SaveFee(0.00, item.DimEnrollmentId);
                                }
                            }
                        }
                    }
                }
            }
        }
        private void btnSaveG6G10_Click(object sender, EventArgs e)
        {
            List<tbldimenrollment> lstDimEnrollment = _tuitionService.GetAllDimEnrollment();
            double o;

            foreach (Control ctrl in this.Controls)
            {
                // You can use the following if condition to target the specific control
                // if (ctrl.Name.Equals("groupBox1"))
                if (ctrl.ToString().StartsWith("System.Windows.Forms.GroupBox"))
                {
                    foreach (Control c in ctrl.Controls)
                    {
                        if (c is TextBox) // && (c as TextBox).Name.Contains(item.EnrollmentCode))
                        {
                            foreach (var item in lstDimEnrollment)
                            {
                                //testing
                                TextBox tbx = this.Controls.Find("txt" + item.EnrollmentCode, true).FirstOrDefault() as TextBox;

                                if (tbx != null && !String.IsNullOrEmpty(tbx.Text))
                                {
                                    var a = tbx.Text;
                                    _tuitionService.SaveFee(Convert.ToDouble(a), item.DimEnrollmentId);
                                }
                                else
                                {
                                    _tuitionService.SaveFee(0.00, item.DimEnrollmentId);
                                }
                            }
                        }
                    }
                }
            }
        }

        private void FrmTuitionMaintenance_Load(object sender, EventArgs e)
        {

        }

        private void grpG1_Enter(object sender, EventArgs e)
        {

        }

        private void txtG8DownMonthly_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtG8DownQuarterly_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtG8DownBiAnnual_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtG8DownAnnual_TextChanged(object sender, EventArgs e)
        {

        }

        private void label30_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtG11Quarterly_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
