using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SVM_Processor.Models;
using SVM_Logic;
using SVM_Contracts;

namespace SVM_Suite
{
    public partial class FrmVendorMaintenance : Form
    {
        SVMContext svmContext = new SVMContext();
        IVendorService _vendorService = new VendorService();
       

        public FrmVendorMaintenance()
        {

            InitializeComponent();
        }

        private FrmVendorListing frmVendorListing;
        public FrmVendorMaintenance(FrmVendorListing frm)
        {

            InitializeComponent();
            frmVendorListing = frm;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                
                if (Global.isEdit == true)
                {
                    _vendorService.UpdateVendor(Global.selectedId, txtVendorCode.Text, txtVendorName.Text, txtVendorDesc.Text);
                    MessageBox.Show("Saved");
                    txtVendorCode.Enabled = false;
                    txtVendorDesc.Enabled = false;
                    txtVendorName.Enabled = false;
                    
                }
                else
                {
                    _vendorService.SaveVendor(txtVendorName.Text, txtVendorCode.Text, txtVendorDesc.Text);
                }
            }
            catch (Exception x)
            {
                MessageBox.Show(x.ToString());
            }
        }

        private void FrmVendorMaintenance_Load(object sender, EventArgs e)
        {
            if (Global.isEdit == true)
            {
                tblvendor vendor = _vendorService.GetVendorById(Global.selectedId);

                txtVendorCode.Text = vendor.VendorCode;
                txtVendorDesc.Text = vendor.VendorDescription;
                txtVendorName.Text = vendor.VendorName;
                
            }
            else //if new
            {
                
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
            frmVendorListing.LoadVendors();
        }

        private void FrmVendorMaintenance_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmVendorListing.LoadVendors();



        }
    }
}
