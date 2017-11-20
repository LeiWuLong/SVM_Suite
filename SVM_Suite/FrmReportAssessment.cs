using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SVM_Processor.DTO;
using SVM_Processor.Models;

namespace SVM_Suite
{
    public partial class FrmReportAssessment : Form
    {
        public FrmReportAssessment()
        {
            InitializeComponent();
        }

        private void FrmReportAssessment_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();

            LoadReport(Global.selectedId);
        }

        public void LoadReport(int studentId)
        {
            SVMContext svmContext = new SVMContext();

            var data = svmContext.tblassessment.Where(x=>x.StudentId==studentId).ToList();
            var reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            reportDataSource1.Name = "dataSet11";
            reportDataSource1.Value = data;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "ReportSample.Report1.rdlc";
            this.reportViewer1.RefreshReport();

        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {
            LoadReport(Global.selectedStudent);
        }
    }
}
