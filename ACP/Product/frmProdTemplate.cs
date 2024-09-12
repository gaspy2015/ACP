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
    public partial class frmProdTemplate : Form
    {
        productCreation pc = new productCreation();
        public frmProdTemplate()
        {
            InitializeComponent();
        }

        private void lblClose_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            frmModifyProd mp = new frmModifyProd();
            if(txtTemplateName.Text == "")
            {
                errorProvider1.SetError(txtTemplateName, "Template name is required");
            }
            else
            {
                //desc26 //27
                //pc.modifyProduct("CRUD", "PRODINVENT", "", "", "", "", mp.txtBarcode.Text, "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", pc.autoIncrementID("templateID", "template").ToString(), txtTemplateName.Text);
            }
        }
    }
}
