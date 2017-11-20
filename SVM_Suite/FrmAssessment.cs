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
using SVM_Processor.DTO;

namespace SVM_Suite
{
    public partial class FrmAssessment : Form
    {
        public FrmAssessment()
        {
            InitializeComponent();
        }

        
        IAssessmentService _assessmentService = new AssessmentService();
        IStudentService _studentService = new StudentService();
        IPaymentService _paymentService = new PaymentService();
        List<tblstudent> lstSibling = new List<tblstudent>();
        List<tblstudent> lstReferral = new List<tblstudent>();
        List<TuitionDTO> lstDiscount = new List<TuitionDTO>();
        double alumniDiscount;
        double tuition = 0;
        double misc = 0;
        double computedReferralAmt = 0;
        double computedSiblingAmt = 0;
        double lastReferralAmt;
        double lastSiblingAmt;
        double computedAlumniDiscount;
        int siblingDiscountType;
        int referralDiscountType;
        double siblingDiscount;
        double referralDiscount;
        int divisor;
        // FrmStudentListing frmStudentListing = new
        int s = 0;


        private void FrmAssessment_Load(object sender, EventArgs e)
        {
            //eager load discounts
            lstDiscount = _assessmentService.GetDiscount();

             alumniDiscount = lstDiscount.Where(x => x.DiscountTypeDesc == "Alumni").FirstOrDefault().DiscountVal;
             
            var lstSibling = lstDiscount.Where(x => x.DiscountTypeDesc == "Family Assistance").ToList();
            var lstReferral = lstDiscount.Where(x => x.DiscountTypeDesc == "Referral").ToList();

             siblingDiscountType = lstSibling[0].DiscountTypeId;
             referralDiscountType = lstReferral[0].DiscountTypeId;

            tblstudent student = _studentService.GetStudent(Global.selectedStudent);
            Global.selectedId = Global.selectedStudent;
            txtStudentName.Text = student.FirstName + " " + student.MiddleName + " " + student.LastName;
            txtStudentNo.Text = student.StudentNo;

            pbStudent.Image = Image.FromFile(student.path);




            tblassessment assessment = _assessmentService.GetAssessment(Global.selectedStudent);
            txtStudentName.ReadOnly = true;
            txtStudentNo.ReadOnly = true;
            txtStatus.ReadOnly = true;
            txtDiscount.Text = assessment.Discount.ToString();

            cmbSection.DataSource = _assessmentService.GetSections(assessment.EducationalLevel);


            cmbSection.ValueMember = "SectionId";
            cmbSection.DisplayMember = "SectionName";
            cmbSection.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            cmbSection.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cmbSection.AutoCompleteSource = AutoCompleteSource.ListItems;

            cmbEducationLevel.DataSource = _studentService.GetEducationLevel();
            cmbEducationLevel.ValueMember = "LevelId";
            cmbEducationLevel.DisplayMember = "Level";
            cmbEducationLevel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            cmbEducationLevel.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cmbEducationLevel.AutoCompleteSource = AutoCompleteSource.ListItems;


            cmbEducationLevel.ValueMember = "LevelId";
            cmbEducationLevel.DisplayMember = "Level";
            cmbEducationLevel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            cmbEducationLevel.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cmbEducationLevel.AutoCompleteSource = AutoCompleteSource.ListItems;

            cmbPaymentTerm.DataSource = _paymentService.GetPaymentTerms();
            cmbPaymentTerm.ValueMember = "PaymentTermId";
            cmbPaymentTerm.DisplayMember = "PaymentDesc";
            cmbPaymentTerm.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            cmbPaymentTerm.SelectedValue = assessment.PaymentTerm;
            cmbPaymentTerm.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cmbPaymentTerm.AutoCompleteSource = AutoCompleteSource.ListItems;




            if (assessment.Status == 2)//if enrolled (status 2) means this is editing
            {
                cmbSection.SelectedValue = assessment.Section;
                cmbEducationLevel.SelectedValue = assessment.EducationalLevel;
                txtStatus.Text = "Enrolled";
                FillValues();
            }
            else
            {
                cmbSection.SelectedIndex = -1;
                cmbPaymentTerm.SelectedIndex = 1;
                cmbEducationLevel.SelectedIndex = -1;


                txtStatus.Text = "On Assessment";
               // txtStatus.Text = assessment.Status == 1 ? "On Assessment" : assessment.Status == 2 ? "Enrolled" : "";
            }

            lastReferralAmt = assessment.ReferralDiscount;
            lastSiblingAmt = assessment.SiblingDiscount;
            //fill siblings and referral grid
            FillReferralsGrid();
            FillSiblingsGrid();

            txtTotal.Text = assessment.FullAmount.ToString() ;
        }

        public void FillSiblingsGrid()
        {
            List<StudentListingDTO> lstSiblingLoad;
            lstSiblingLoad = _assessmentService.GetReferralSiblingGrid(Global.selectedStudent, siblingDiscountType);
            lstSibling = lstSiblingLoad.Select(x => new tblstudent()
            {
                StudentId = x.StudentId,
                StudentNo = x.StudentNo,
                FirstName = x.FirstName,
                MiddleName = x.MiddleName,
                LastName = x.LastName
            }).ToList();
            var siblingBindingList = new BindingList<tblstudent>(lstSibling);
            var siblingBindingSource = new BindingSource(siblingBindingList, null);
            // dgvReferral.Columns.Clear();
            dgvSibling.AutoGenerateColumns = false;

            if (dgvSibling.DataSource == null)
            {
                dgvSibling.ColumnCount = 6;
            }

            dgvSibling.Columns[0].Name = "colStudentId";
            dgvSibling.Columns[0].Visible = false;
            dgvSibling.Columns[0].DataPropertyName = "StudentId";

            dgvSibling.Columns[1].Name = "colStudentNo";
            dgvSibling.Columns[1].HeaderText = "Student No";
            dgvSibling.Columns[1].DataPropertyName = "StudentNo";

            dgvSibling.Columns[2].Name = "colFirstName";
            dgvSibling.Columns[2].HeaderText = "First Name";
            dgvSibling.Columns[2].DataPropertyName = "FirstName";

            dgvSibling.Columns[3].Name = "colMiddleName";
            dgvSibling.Columns[3].HeaderText = "Middle Name";
            dgvSibling.Columns[3].DataPropertyName = "MiddleName";

            dgvSibling.Columns[4].Name = "colLastName";
            dgvSibling.Columns[4].HeaderText = "Last Name";
            dgvSibling.Columns[4].DataPropertyName = "LastName";

            dgvSibling.Columns[5].Name = "colStudentId";
            dgvSibling.Columns[5].Visible = false;
            dgvSibling.Columns[5].DataPropertyName = "StudentId";

            dgvSibling.DataSource = siblingBindingList;
            dgvSibling.ReadOnly = true;
        }
        //fill textboxes upon load
        public void FillValues()
        {
            List<TuitionDTO> fee = _assessmentService.GetFees(Convert.ToInt32(cmbEducationLevel.SelectedValue)
               , Convert.ToInt32(cmbPaymentTerm.SelectedValue));

            //get the divisor
            divisor = fee[0].Divisor;

            //1=tuit , 
            //2=misc
            //3=down
            if (fee != null)
            {
                foreach (var item in fee)
                {


                    if (item.TuitMisc == 1)
                    {
                        tuition = item.Fee;
                        // txtFullMisc.Text = Convert.ToString(item.Fee / item.Divisor);
                    }
                    else if (item.TuitMisc == 2)
                    {
                        misc = item.Fee;
                    }
                    else if (item.TuitMisc == 3)
                    {
                        txtDownpayment.Text = item.Fee.ToString();

                        //put them to text field
                        txtTotal.Text = (tuition).ToString();
                        txtDeferred.Text = ((tuition + misc) / item.Divisor).ToString("##.#");
                        computedAlumniDiscount = (tuition) * (alumniDiscount / 100);
                        txtFullMisc.Text = misc.ToString("##.#");
                        txtDeferredMisc.Text = (misc / item.Divisor).ToString("##.#");
                        
                        
                    }
                }
            }
        }

        public void FillReferralsGrid()
        {
            List<StudentListingDTO> lstReferralLoad;
            lstReferralLoad = _assessmentService.GetReferralSiblingGrid(Global.selectedStudent, referralDiscountType);
            lstReferral = lstReferralLoad.Select(x => new tblstudent()
            {
                StudentId = x.StudentId,
                StudentNo = x.StudentNo,
                FirstName = x.FirstName,
                MiddleName = x.MiddleName,
                LastName = x.LastName
            }).ToList();
            var referralBindingList = new BindingList<tblstudent>(lstReferral);
            var referralBindingSource = new BindingSource(referralBindingList, null);
            // dgvReferral.Columns.Clear();
            dgvReferral.AutoGenerateColumns = false;

            if (dgvReferral.DataSource == null)
            {
                dgvReferral.ColumnCount = 6;
            }

            dgvReferral.Columns[0].Name = "colStudentId";
            dgvReferral.Columns[0].Visible = false;
            dgvReferral.Columns[0].DataPropertyName = "StudentId";

            dgvReferral.Columns[1].Name = "colStudentNo";
            dgvReferral.Columns[1].HeaderText = "Student No";
            dgvReferral.Columns[1].DataPropertyName = "StudentNo";

            dgvReferral.Columns[2].Name = "colFirstName";
            dgvReferral.Columns[2].HeaderText = "First Name";
            dgvReferral.Columns[2].DataPropertyName = "FirstName";

            dgvReferral.Columns[3].Name = "colMiddleName";
            dgvReferral.Columns[3].HeaderText = "Middle Name";
            dgvReferral.Columns[3].DataPropertyName = "MiddleName";

            dgvReferral.Columns[4].Name = "colLastName";
            dgvReferral.Columns[4].HeaderText = "Last Name";
            dgvReferral.Columns[4].DataPropertyName = "LastName";

            dgvReferral.Columns[5].Name = "colStudentId";
            dgvReferral.Columns[5].Visible = false;
            dgvReferral.Columns[5].DataPropertyName = "StudentId";

            dgvReferral.DataSource = referralBindingList;
            dgvReferral.ReadOnly = true;
        }
            //fill textboxes upon load
        //    public void FillValues()
        //{ 
        //    List<TuitionDTO> fee = _assessmentService.GetFees(Convert.ToInt32(cmbEducationLevel.SelectedValue)
        //       , Convert.ToInt32(cmbPaymentTerm.SelectedValue));

        //    //1=tuit , 
        //    //2=misc
        //    //3=down
        //    if(fee != null)
        //    {
        //        foreach (var item in fee)
        //        {


        //            if (item.TuitMisc == 1)
        //            {
        //                tuition = item.Fee;
        //                // txtFullMisc.Text = Convert.ToString(item.Fee / item.Divisor);
        //            }
        //            else if (item.TuitMisc == 2)
        //            {
        //                misc = item.Fee;
        //            }
        //            else if (item.TuitMisc == 3)
        //            {
        //                txtDownpayment.Text = item.Fee.ToString();

        //                //put them to text field
        //                txtTotal.Text = (tuition + misc).ToString();
        //                txtDeferred.Text = ((tuition + misc) / item.Divisor).ToString("#.##");
        //                computedAlumniDiscount = (tuition * (alumniDiscount / 100));
                       
        //            }
        //        }
        //    }
        //}

        private void btnSave_Click(object sender, EventArgs e)
        {
            int o;


            _assessmentService.UpdateTblAssessment(Global.selectedId, Convert.ToInt32(cmbSection.SelectedValue),
                Convert.ToInt32(cmbEducationLevel.SelectedValue), Convert.ToInt32(cmbPaymentTerm.SelectedValue)
                , Convert.ToDouble(txtTotal.Text)
            , Convert.ToDouble(txtDownpayment.Text), Convert.ToDouble(txtDeferred.Text),Convert.ToDouble(txtDiscount.Text),
                cbAlumni.Checked,siblingDiscount,referralDiscount,cbTransferee.Checked,
                Convert.ToDouble(txtFullMisc.Text),Convert.ToDouble(txtDeferredMisc.Text),
                Convert.ToDouble(tuition));

            //remove referrals
            _assessmentService.RemoveReferralSiblings(Global.selectedId);

            //remove siblings

            for (int x = 0; x <= lstReferral.Count() - 1; x++)
            {
                _assessmentService.SaveReferral(Global.selectedId, lstReferral[x].StudentId,referralDiscountType);
            }

            for (int y = 0; y <= lstSibling.Count() - 1; y++)
            {
                _assessmentService.SaveReferral(Global.selectedId, lstSibling[y].StudentId,siblingDiscountType);
            }

            MessageBox.Show("Student Enrolled");
        }

        private void btnAddSibling_Click(object sender, EventArgs e)
        {
            Global.formToOpen = "AddStudent";
            FrmStudentListing frmStudentListing = new FrmStudentListing(this);
            frmStudentListing.UpdateEventHandler += FrmStudentListing_UpdateEventHandler;
            frmStudentListing.ShowDialog();

        }

        private void FrmStudentListing_UpdateEventHandler(object sender, FrmStudentListing.UpdateEventArgs args)
        {
            UpdateSiblingGrid();
        }

        public void UpdateSiblingGrid()
        {
            lstSibling.Add(_studentService.GetStudent(Global.selectedStudent));
            var siblingBindingList = new BindingList<tblstudent>(lstSibling);
            var siblingBindingSource = new BindingSource(siblingBindingList, null);
           // dgvSibling.Columns.Clear();
            dgvSibling.AutoGenerateColumns = false;
           
            if(dgvSibling.DataSource==null)
            { 
                //declare count if datasource is null
             dgvSibling.ColumnCount = 6 ;
            }
            dgvSibling.Columns[0].Name = "colStudentId";
            dgvSibling.Columns[0].Visible = false;
            dgvSibling.Columns[0].DataPropertyName = "StudentId";

            dgvSibling.Columns[1].Name = "colStudentNo";
            dgvSibling.Columns[1].HeaderText = "Student No";
            dgvSibling.Columns[1].DataPropertyName = "StudentNo";

            dgvSibling.Columns[2].Name = "colFirstName";
            dgvSibling.Columns[2].HeaderText = "First Name";
            dgvSibling.Columns[2].DataPropertyName = "FirstName";

            dgvSibling.Columns[3].Name = "colMiddleName";
            dgvSibling.Columns[3].HeaderText = "Middle Name";
            dgvSibling.Columns[3].DataPropertyName = "MiddleName";

            dgvSibling.Columns[4].Name = "colLastName";
            dgvSibling.Columns[4].HeaderText = "Last Name";
            dgvSibling.Columns[4].DataPropertyName = "LastName";

            dgvSibling.Columns[5].Name = "colStudentId";
            dgvSibling.Columns[5].Visible = false;
            dgvSibling.Columns[5].DataPropertyName = "StudentId";

            dgvSibling.DataSource = siblingBindingList;
            dgvSibling.ReadOnly = true;

            TuitionDTO siblingVal = lstDiscount.Where(x => x.DiscountTypeDesc == "Family Assistance"
                               && siblingBindingList.Count() >= Convert.ToInt32(x.DiscountParam)).
                               OrderBy(x => x.DiscountVal).LastOrDefault();

            if (siblingVal != null)
            {

                computedSiblingAmt = tuition * (siblingVal.DiscountVal / 100);

                if (computedSiblingAmt != 0.00 && computedSiblingAmt != lastReferralAmt) // && lastReferralAmt != 0.00 )
                {
                    txtDiscount.Text = (Convert.ToDouble(String.IsNullOrEmpty(txtDiscount.Text) ? 0 : Convert.ToDouble(txtDiscount.Text)) - lastSiblingAmt).ToString("#.##");
                    txtDiscount.Text = (Convert.ToInt32(txtDiscount.Text) + tuition * (siblingVal.DiscountVal / 100)).ToString("#.##");
                    siblingDiscount = Convert.ToDouble(txtDiscount.Text);  
                    txtTotal.Text =(Convert.ToDouble(txtTotal.Text)- (Convert.ToDouble(String.IsNullOrEmpty(txtDiscount.Text) ? 0 : Convert.ToDouble(txtDiscount.Text)))).ToString();
                    //trigger
                    txtDeferred.Text = ((Convert.ToDouble(txtTotal.Text)+Convert.ToDouble(txtDeferredMisc.Text)) / divisor).ToString("#.##");
                }
                else if (computedSiblingAmt != lastReferralAmt && computedSiblingAmt != 0.00)
                {
                    txtDiscount.Text = (Convert.ToInt32(txtDiscount.Text) + tuition * (siblingVal.DiscountVal / 100)).ToString("#.##");
                    siblingDiscount = Convert.ToDouble(txtDiscount.Text);
                    txtTotal.Text = (Convert.ToDouble(txtTotal.Text) - (Convert.ToDouble(String.IsNullOrEmpty(txtDiscount.Text) ? 0 : Convert.ToDouble(txtDiscount.Text)))).ToString();
                    //trigger
                    txtDeferred.Text = ((Convert.ToDouble(txtTotal.Text) + Convert.ToDouble(txtDeferredMisc.Text)) / divisor).ToString("#.##");
                }
            }
            else
            {
                //if null do nothing
            }
            lastSiblingAmt = computedSiblingAmt;

        }

        public void UpdateReferralGrid()
        {
            lstReferral.Add(_studentService.GetStudent(Global.selectedStudent));
            var referralBindingList = new BindingList<tblstudent>(lstReferral);
            var referralBindingSource = new BindingSource(referralBindingList, null);
            // dgvReferral.Columns.Clear();
            dgvReferral.AutoGenerateColumns = false;

            if (dgvReferral.DataSource == null)
            {
                dgvReferral.ColumnCount = 6;
            }

            dgvReferral.Columns[0].Name = "colStudentId";
            dgvReferral.Columns[0].Visible = false;
            dgvReferral.Columns[0].DataPropertyName = "StudentId";

            dgvReferral.Columns[1].Name = "colStudentNo";
            dgvReferral.Columns[1].HeaderText = "Student No";
            dgvReferral.Columns[1].DataPropertyName = "StudentNo";

            dgvReferral.Columns[2].Name = "colFirstName";
            dgvReferral.Columns[2].HeaderText = "First Name";
            dgvReferral.Columns[2].DataPropertyName = "FirstName";

            dgvReferral.Columns[3].Name = "colMiddleName";
            dgvReferral.Columns[3].HeaderText = "Middle Name";
            dgvReferral.Columns[3].DataPropertyName = "MiddleName";

            dgvReferral.Columns[4].Name = "colLastName";
            dgvReferral.Columns[4].HeaderText = "Last Name";
            dgvReferral.Columns[4].DataPropertyName = "LastName";

            dgvReferral.Columns[5].Name = "colStudentId";
            dgvReferral.Columns[5].Visible = false;
            dgvReferral.Columns[5].DataPropertyName = "StudentId";

            dgvReferral.DataSource = referralBindingList;
            dgvReferral.ReadOnly = true;

            TuitionDTO referralVal = lstDiscount.Where(x => x.DiscountTypeDesc == "Referral"
                                && referralBindingList.Count() >= Convert.ToInt32(x.DiscountParam)).
                                OrderBy(x => x.DiscountVal).LastOrDefault();

            if (referralVal != null)    
            {
                
                computedReferralAmt = tuition * (referralVal.DiscountVal / 100);
               
                if (computedReferralAmt != 0.00 && computedReferralAmt !=lastReferralAmt) //if moving on the next discount condition, 
                                                                                          //remove discount applied then apply new discount
                {

                    //
                    txtDiscount.Text = (Convert.ToDouble(String.IsNullOrEmpty(txtDiscount.Text) ? 0 : Convert.ToDouble(txtDiscount.Text)) - lastReferralAmt).ToString("#.##");
                txtDiscount.Text = (Convert.ToInt32(txtDiscount.Text) + tuition * (referralVal.DiscountVal/100)).ToString("#.##");
                    referralDiscount = Convert.ToDouble(txtDiscount.Text);
                    txtTotal.Text = (Convert.ToDouble(txtTotal.Text) - (Convert.ToDouble(String.IsNullOrEmpty(txtDiscount.Text) ? 0 : Convert.ToDouble(txtDiscount.Text)))).ToString();
                    //trigger
                    txtDeferred.Text = ((Convert.ToDouble(txtTotal.Text)+Convert.ToDouble(txtDeferredMisc.Text)) / divisor).ToString("#.##");
                }
                else if (computedReferralAmt !=lastReferralAmt && computedReferralAmt != 0.00)
                {
                    txtDiscount.Text = (Convert.ToInt32(txtDiscount.Text) + tuition * (referralVal.DiscountVal / 100)).ToString("#.##");
                    referralDiscount = Convert.ToDouble(txtDiscount.Text);
                    txtTotal.Text = (Convert.ToDouble(txtTotal.Text) - (Convert.ToDouble(String.IsNullOrEmpty(txtDiscount.Text) ? 0 : Convert.ToDouble(txtDiscount.Text)))).ToString();
                    //trigger
                    txtDeferred.Text = ((Convert.ToDouble(txtTotal.Text)+Convert.ToDouble(txtDeferredMisc.Text)) / divisor).ToString("#.##");
                }
            }
            else
            {
                    //if null do nothing
            }
             lastReferralAmt = computedReferralAmt;
        }

        private void btnAddReferral_Click(object sender, EventArgs e)
        {
            Global.formToOpen = "AddReferral";
            FrmStudentListing frmStudentListing = new FrmStudentListing(this);
            frmStudentListing.UpdateEventHandler += FrmStudentListing_UpdateEventHandlerReferral;
            frmStudentListing.ShowDialog();
        }

        private void FrmStudentListing_UpdateEventHandlerReferral(object sender, FrmStudentListing.UpdateEventArgs args)
        {
            // throw new NotImplementedException();
            UpdateReferralGrid();
        }

        private void txtStatus_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmbEducationLevel_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmbPaymentTerm_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmbPaymentTerm_SelectionChangeCommitted(object sender, EventArgs e)
        {
            List<TuitionDTO> fee = _assessmentService.GetFees(Convert.ToInt32(cmbEducationLevel.SelectedValue)
                ,Convert.ToInt32(cmbPaymentTerm.SelectedValue));

            //1=tuit , 
            //2=misc
            //3=down

            foreach (var item in fee)
            {


                if (item.TuitMisc == 1)
                {
                    tuition = item.Fee;
                   // txtFullMisc.Text = Convert.ToString(item.Fee / item.Divisor);
                }
                else if (item.TuitMisc == 2)
                {
                    misc = item.Fee;
                }
                else if (item.TuitMisc == 3)
                {
                    txtDownpayment.Text = item.Fee.ToString();

                    //put them to text field
                    txtTotal.Text = (tuition).ToString();
                    txtFullMisc.Text = misc.ToString("#.##");
                    txtDeferred.Text = ((tuition + misc) / item.Divisor).ToString("#.##");
                    computedAlumniDiscount = (tuition * (alumniDiscount  /100));
                    txtDeferredMisc.Text = (misc / item.Divisor).ToString();

                    //clear grids
                   
                }
            }
        }

        private void fileSystemWatcher1_Changed(object sender, System.IO.FileSystemEventArgs e)
        {

        }

        private void cbAlumni_CheckedChanged(object sender, EventArgs e)
        {

            //txtDiscount.Text = (Convert.ToDouble(txtDiscount.Text == null ? computedAlumniDiscount
            //        : Convert.ToInt32(txtDiscount.Text))
            //        + computedAlumniDiscount).ToString("#.##");

            if (cbAlumni.Checked == true )
            {

                txtDiscount.Text =Convert.ToString(String.IsNullOrEmpty(txtDiscount.Text) ?
                    computedAlumniDiscount : Convert.ToDouble(txtDiscount.Text) + computedAlumniDiscount);
                txtTotal.Text = (Convert.ToDouble(txtTotal.Text) - computedAlumniDiscount).ToString("#.##");//(Convert.ToDouble(String.IsNullOrEmpty(txtDiscount.Text) ? 0 : Convert.ToDouble(txtDiscount.Text)))).ToString();
                //trigger
                txtDeferred.Text = (Convert.ToDouble(txtTotal.Text) / divisor).ToString("#.##");
            }
            else if (cbAlumni.Checked == false)
            {
                if (!String.IsNullOrEmpty(txtDiscount.Text))
                {
                    txtDiscount.Text = (Convert.ToDouble(txtDiscount.Text == null ? 0
                        : Convert.ToInt32(txtDiscount.Text))
                        - computedAlumniDiscount).ToString("#.##");
                    // txtDiscount.Text = String.IsNullOrEmpty(txtDiscount.Text) ? "0" : txtDiscount.Text; //do nothing ;
                    txtTotal.Text = (Convert.ToDouble(txtTotal.Text) + computedAlumniDiscount).ToString();//(Convert.ToDouble(String.IsNullOrEmpty(txtDiscount.Text) ? 0 : Convert.ToDouble(txtDiscount.Text)))).ToString();
                    //trigger
                    txtDeferred.Text = (Convert.ToDouble(txtTotal.Text) / divisor).ToString("#.##");
                }
                else
                {
                    txtDiscount.Text = "0";
                }
            }
        }

        private void txtDiscount_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtDiscount.Text))
            {
                txtDiscount.Text = "0";
            }
        }

        private void btnRemoveReferral_Click(object sender, EventArgs e)
        {
            
        }

        private void dgvReferral_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvReferral_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvSibling_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            

        }

        private void dgvSibling_DoubleClick(object sender, EventArgs e)
        {
            int selectedrowindex = dgvSibling.SelectedCells[0].RowIndex;

            DataGridViewRow selectedRow = dgvSibling.Rows[selectedrowindex];

            int selectedStudent = Convert.ToInt32(selectedRow.Cells["colStudentId"].Value);


            var item = lstSibling.SingleOrDefault(r => r.StudentId == selectedStudent);
            lstSibling.Remove(item);
            var siblingBindingList = new BindingList<tblstudent>(lstSibling);
            var siblingBindingSource = new BindingSource(siblingBindingList, null);
            // dgvSibling.Columns.Clear();
            dgvSibling.AutoGenerateColumns = false;

            if (dgvSibling.DataSource == null)
            {
                dgvSibling.ColumnCount = 5;
            }

            dgvSibling.Columns[0].Name = "colStudentId";
            dgvSibling.Columns[0].Visible = false;
            dgvSibling.Columns[0].DataPropertyName = "StudentId";

            dgvSibling.Columns[1].Name = "colStudentNo";
            dgvSibling.Columns[1].HeaderText = "Student No";
            dgvSibling.Columns[1].DataPropertyName = "StudentNo";

            dgvSibling.Columns[2].Name = "colFirstName";
            dgvSibling.Columns[2].HeaderText = "First Name";
            dgvSibling.Columns[2].DataPropertyName = "FirstName";

            dgvSibling.Columns[3].Name = "colMiddleName";
            dgvSibling.Columns[3].HeaderText = "Middle Name";
            dgvSibling.Columns[3].DataPropertyName = "MiddleName";

            dgvSibling.Columns[4].Name = "colLastName";
            dgvSibling.Columns[4].HeaderText = "Last Name";
            dgvSibling.Columns[4].DataPropertyName = "LastName";

            dgvSibling.DataSource = siblingBindingList;
            dgvSibling.ReadOnly = true;

            TuitionDTO siblingVal = lstDiscount.Where(x => x.DiscountTypeDesc == "Sibling"
                                && siblingBindingList.Count() >= Convert.ToInt32(x.DiscountParam)).
                                OrderBy(x => x.DiscountVal).LastOrDefault();

            if (siblingVal != null)
            {

                computedSiblingAmt = tuition * (siblingVal.DiscountVal / 100);

                if (computedSiblingAmt != 0.00 && computedSiblingAmt != lastSiblingAmt) // && lastSiblingAmt != 0.00 )
                {
                    txtTotal.Text = (Convert.ToDouble(txtTotal.Text) + (Convert.ToDouble(String.IsNullOrEmpty(txtDiscount.Text) ? 0 : Convert.ToDouble(txtDiscount.Text)))).ToString();

                    txtDiscount.Text = (Convert.ToInt32(txtDiscount.Text) - (lastSiblingAmt - computedSiblingAmt)).ToString("#.##");
                    //trigger
                    txtDeferred.Text = ((Convert.ToDouble(txtTotal.Text)+Convert.ToDouble(txtDeferredMisc.Text)) / divisor).ToString("#.##");
                    siblingDiscount = Convert.ToDouble(txtDiscount.Text);
                }
                else if (computedSiblingAmt != lastSiblingAmt && computedSiblingAmt != 0.00)
                {
                    txtTotal.Text = (Convert.ToDouble(txtTotal.Text) + (Convert.ToDouble(String.IsNullOrEmpty(txtDiscount.Text) ? 0 : Convert.ToDouble(txtDiscount.Text)))).ToString();

                    txtDiscount.Text = (Convert.ToInt32(txtDiscount.Text) - tuition * (siblingVal.DiscountVal / 100)).ToString("#.##");
                   //trigger
                    txtDeferred.Text = ((Convert.ToDouble(txtTotal.Text) + Convert.ToDouble(txtDeferredMisc.Text)) / divisor).ToString("#.##");

                    siblingDiscount = Convert.ToDouble(txtDiscount.Text);
                }
            }
            else if (Convert.ToInt32(txtDiscount.Text) >= lastSiblingAmt) //check if can still be subtracted. logically at this state, ref discount has been applied. 
            {
                txtTotal.Text = (Convert.ToDouble(txtTotal.Text) + (Convert.ToDouble(String.IsNullOrEmpty(txtDiscount.Text) ? 0 : Convert.ToDouble(txtDiscount.Text)))).ToString();

                txtDiscount.Text = (Convert.ToInt32(txtDiscount.Text) - lastSiblingAmt).ToString("#.##");
                //trigger
                txtDeferred.Text = ((Convert.ToDouble(txtTotal.Text) + Convert.ToDouble(txtDeferredMisc.Text)) / divisor).ToString("#.##");

                siblingDiscount = Convert.ToDouble(txtDiscount.Text);
            }
            lastSiblingAmt = computedSiblingAmt;

        }

        private void dgvReferral_DoubleClick(object sender, EventArgs e)
        {

            int selectedrowindex = dgvReferral.SelectedCells[0].RowIndex;

            DataGridViewRow selectedRow = dgvReferral.Rows[selectedrowindex];

            int selectedStudent = Convert.ToInt32(selectedRow.Cells["colStudentId"].Value);


            var item = lstReferral.SingleOrDefault(r => r.StudentId == selectedStudent);
            lstReferral.Remove(item);
            var referralBindingList = new BindingList<tblstudent>(lstReferral);
            var referralBindingSource = new BindingSource(referralBindingList, null);
            // dgvReferral.Columns.Clear();
            dgvReferral.AutoGenerateColumns = false;

            if (dgvReferral.DataSource == null)
            {
                dgvReferral.ColumnCount = 5;
            }

            dgvReferral.Columns[0].Name = "colStudentId";
            dgvReferral.Columns[0].Visible = false;
            dgvReferral.Columns[0].DataPropertyName = "StudentId";

            dgvReferral.Columns[1].Name = "colStudentNo";
            dgvReferral.Columns[1].HeaderText = "Student No";
            dgvReferral.Columns[1].DataPropertyName = "StudentNo";

            dgvReferral.Columns[2].Name = "colFirstName";
            dgvReferral.Columns[2].HeaderText = "First Name";
            dgvReferral.Columns[2].DataPropertyName = "FirstName";

            dgvReferral.Columns[3].Name = "colMiddleName";
            dgvReferral.Columns[3].HeaderText = "Middle Name";
            dgvReferral.Columns[3].DataPropertyName = "MiddleName";

            dgvReferral.Columns[4].Name = "colLastName";
            dgvReferral.Columns[4].HeaderText = "Last Name";
            dgvReferral.Columns[4].DataPropertyName = "LastName";

            dgvReferral.DataSource = referralBindingList;
            dgvReferral.ReadOnly = true;

            TuitionDTO referralVal = lstDiscount.Where(x => x.DiscountTypeDesc == "Referral"
                                 && referralBindingList.Count() >= Convert.ToInt32(x.DiscountParam)).
                                 OrderBy(x => x.DiscountVal).LastOrDefault();

            if (referralVal != null)
            {

                computedReferralAmt = tuition * (referralVal.DiscountVal / 100);

                if (computedReferralAmt != 0.00 && computedReferralAmt != lastReferralAmt) // && lastReferralAmt != 0.00 )
                {
                    txtTotal.Text = (Convert.ToDouble(txtTotal.Text) + (Convert.ToDouble(String.IsNullOrEmpty(txtDiscount.Text) ? 0 : Convert.ToDouble(txtDiscount.Text)))).ToString();
                    //txtDiscount.Text = (Convert.ToInt32(txtDiscount.Text) - tuition * (referralVal.DiscountVal / 100)).ToString("#.##");
                    txtDiscount.Text = (Convert.ToInt32(txtDiscount.Text) - (lastReferralAmt- computedReferralAmt)).ToString("#.##");
                    referralDiscount = Convert.ToDouble(txtDiscount.Text);
                   
                    //trigger
                    txtDeferred.Text = ((Convert.ToDouble(txtTotal.Text) + Convert.ToDouble(txtDeferredMisc.Text)) / divisor).ToString("#.##");
                }
                else if (computedReferralAmt != lastReferralAmt && computedReferralAmt != 0.00)
                {
                    txtTotal.Text = (Convert.ToDouble(txtTotal.Text) + (Convert.ToDouble(String.IsNullOrEmpty(txtDiscount.Text) ? 0 : Convert.ToDouble(txtDiscount.Text)))).ToString();

                    txtDiscount.Text = (Convert.ToInt32(txtDiscount.Text) - tuition * (referralVal.DiscountVal / 100)).ToString("#.##");
                    referralDiscount = Convert.ToDouble(txtDiscount.Text);
                    //trigger
                    txtDeferred.Text = ((Convert.ToDouble(txtTotal.Text) + Convert.ToDouble(txtDeferredMisc.Text)) / divisor).ToString("#.##");
                }
            }
            else if(Convert.ToInt32(txtDiscount.Text) >= lastReferralAmt) //check if can still be subtracted. logically at this state, ref discount has been applied. 
            {
                txtTotal.Text = (Convert.ToDouble(txtTotal.Text) + (Convert.ToDouble(String.IsNullOrEmpty(txtDiscount.Text) ? 0 : Convert.ToDouble(txtDiscount.Text)))).ToString();

                txtDiscount.Text = (Convert.ToInt32(txtDiscount.Text) - lastReferralAmt).ToString("#.##");
                //trigger
                txtDeferred.Text = ((Convert.ToDouble(txtTotal.Text) + Convert.ToDouble(txtDeferredMisc.Text)) / divisor).ToString("#.##");

                referralDiscount = Convert.ToDouble(txtDiscount.Text);
                computedReferralAmt = 0.00;
            }
            lastReferralAmt = computedReferralAmt;

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtTotal_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmReportAssessment report = new FrmReportAssessment();
            report.Show();
        }

        private void txtTotalMiscTuit_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtTotal_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void txtDeferred_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
