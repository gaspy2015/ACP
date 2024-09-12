using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ACP
{
    public partial class frmReports : Form
    {
        public frmReports()
        {
            InitializeComponent();
        }

        private void frmReports_Load(object sender, EventArgs e)
        {
           
        }

        private void rbCostP_CheckedChanged(object sender, EventArgs e)
        {
            Id.condition = true;
        }

        private void rbRetailP_CheckedChanged(object sender, EventArgs e)
        {
            Id.condition = false;
        }

        private void btnReview_Click(object sender, EventArgs e)
        {
            if (rbCostP.Checked == false && rbRetailP.Checked == false)
            {
                MessageBox.Show("Please select an option to preview", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                // TODO: This line of code loads data into the 'dsPO.sp_reportPO' table. You can move, or remove it, as needed.
                this.sp_reportPOTableAdapter.Fill(this.dsPO.sp_reportPO, Id.orderNo);
                ReportParameter[] parameters = new ReportParameter[1];
                if (Id.condition)
                {
                    parameters[0] = new ReportParameter("HiddenColumn", "False");
                }
                else
                {
                    parameters[0] = new ReportParameter("HiddenColumn", "True");
                }
                this.reportViewer1.LocalReport.SetParameters(parameters);
                this.reportViewer1.RefreshReport();
            }
        }
    }
}
