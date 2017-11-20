using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SVM_Contracts;
using SVM_Processor.Models;
using SVM_Logic;

namespace SVM_Suite
{
    public partial class FrmDiscountMaintenance : Form
    {
        public FrmDiscountMaintenance()
        {
            InitializeComponent();
        }

        IDiscountService _discountService = new DiscountService();

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void tabAlumni_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void txtSiblingDiscount_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void tabScholarship_Click(object sender, EventArgs e)
        {

        }

        private void lblDiscountType_Click(object sender, EventArgs e)
        {

        }

        private void FrmDiscountMaintenance_Load(object sender, EventArgs e)
        {
           

            cmbDiscountType.DataSource = _discountService.GetDiscountTypes();
            cmbDiscountType.ValueMember = "DiscountTypeId";
            cmbDiscountType.DisplayMember = "DiscountType";
            
            cmbDiscountType.SelectedIndex = -1;

        }

        private void cmbDiscountType_SelectedIndexChanged(object sender, EventArgs e)
        {
            //int s;
            //if(!String.IsNullOrEmpty(cmbDiscountType.SelectedValue.ToString()))
            //    { 
            //        if(int.TryParse(cmbDiscountType.SelectedValue.ToString(),out  s))
            //         { 
            //                List<tbldiscount> lstDiscount =_discountService.GetDiscount(Convert.ToInt32(cmbDiscountType.SelectedValue));

            //                var gridBindingList = new BindingList<tbldiscount>(lstDiscount);
            //                var gridBindingSource = new BindingSource(gridBindingList, null);

            
            //                dgvDiscount.DataSource = gridBindingSource;

            //                dgvDiscount.Columns["DiscountId"].Visible = false;
            //                dgvDiscount.Columns["DiscountTypeId"].Visible = false;
            //                dgvDiscount.Columns["DiscountTypeVal"].HeaderText = "%Discount";
            //                dgvDiscount.Columns["DiscountTypeDesc"].HeaderText = "Discount Description";
            //                dgvDiscount.Columns["DiscountTypeVal"].DefaultCellStyle.Format= "0\\%";
            //        }
            //}
        }

        private void cmbDiscountType_SelectionChangeCommitted(object sender, EventArgs e)
        {
            int s;
            if (!String.IsNullOrEmpty(cmbDiscountType.SelectedValue.ToString()))
            {
                if (int.TryParse(cmbDiscountType.SelectedValue.ToString(), out s))
                {
                    List<tbldiscount> lstDiscount = _discountService.GetDiscountByTypeId(Convert.ToInt32(cmbDiscountType.SelectedValue));

                    var gridBindingList = new BindingList<tbldiscount>(lstDiscount);
                    var gridBindingSource = new BindingSource(gridBindingList, null);


                    dgvDiscount.DataSource = gridBindingSource;

                    dgvDiscount.Columns["DiscountId"].Visible = false;
                    dgvDiscount.Columns["DiscountTypeId"].Visible = false;
                    dgvDiscount.Columns["DiscountTypeVal"].HeaderText = "%Discount";
                    dgvDiscount.Columns["DiscountTypeDesc"].HeaderText = "Discount Description";
                    dgvDiscount.Columns["DiscountTypeVal"].DefaultCellStyle.Format = "0\\%";
                    dgvDiscount.Columns["isDeleted"].Visible = false;
                    dgvDiscount.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

                    if (Convert.ToInt32(cmbDiscountType.SelectedValue)==4)
                    {
                        //if alumni discount
                        btnInsert.Enabled = false;
                    }
                    else
                    {
                        //if not alumni discount
                        btnInsert.Enabled = true;
                    }
                }
            }
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            int s;

            //1 family assistance
            //2 referral
            //3 early bird
            //4 alumni
            //5 scholarship

            if (int.TryParse(cmbDiscountType.SelectedValue.ToString(), out s))
            {
                tbldiscount tblDiscount = new tbldiscount();
                //family referral
                if (Convert.ToInt32(cmbDiscountType.SelectedValue) != 4)
                {
                    btnInsert.Enabled = true;
                    tblDiscount.DiscountTypeId = Convert.ToInt32(cmbDiscountType.SelectedValue);
                    tblDiscount.DiscountTypeVal = Convert.ToDouble(numDiscount.Value);
                    tblDiscount.DiscountTypeDesc = numVar.Value.ToString();

                    _discountService.SaveDiscount(tblDiscount);
                }
               
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            tbldiscount tblDiscount = new tbldiscount();

            if (Convert.ToInt32(cmbDiscountType.SelectedValue) != 4)
            {
                //btnInsert.Enabled = true;
                tblDiscount.DiscountTypeId = Convert.ToInt32(cmbDiscountType.SelectedValue);
                tblDiscount.DiscountTypeVal = Convert.ToDouble(numDiscount.Value);
                tblDiscount.DiscountTypeDesc = numVar.Value.ToString();
                tblDiscount.DiscountId = Convert.ToInt32(dgvDiscount.SelectedRows[0].Cells["DiscountId"].Value.ToString());
                _discountService.UpdateDiscount(tblDiscount);
            }
            else
            {
               // btnInsert.Enabled = false;
                tblDiscount.DiscountTypeId = Convert.ToInt32(cmbDiscountType.SelectedValue);
                tblDiscount.DiscountTypeVal = Convert.ToDouble(numDiscount.Value);
                tblDiscount.DiscountTypeDesc = numVar.Value.ToString();
                tblDiscount.DiscountId = Convert.ToInt32(dgvDiscount.SelectedRows[0].Cells["DiscountId"].Value.ToString());
                _discountService.UpdateDiscount(tblDiscount);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvDiscount.SelectedCells.Count > 0)
            {
                //if a row is selected
                MessageBox.Show("Row selected");
                int selectedrowindex = dgvDiscount.SelectedCells[0].RowIndex;

                DataGridViewRow selectedRow = dgvDiscount.Rows[selectedrowindex];

                int discountId = Convert.ToInt32(selectedRow.Cells["DiscountId"].Value);
                _discountService.DeleteDiscount(discountId);
                MessageBox.Show("Record Deleted");
            }
            else
            {
                //if no row selected, prompt.
                MessageBox.Show("No row Selected. Please select a row.");
            }
        }
    }
}
