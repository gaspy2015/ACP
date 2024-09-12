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
    public partial class frmPaymentConfig : Form
    {
        productCreation pc = new productCreation();
        public frmPaymentConfig()
        {
            InitializeComponent();
        }

        public void paymentConfig()
        {
            DataTable dt = pc.fetchRecord("VIEW", "FETCHPAYCONFIG", "", "", "", "", "", "");
            BindingSource source = new BindingSource();
            source.DataSource = dt;
            dgvPaymentConfig.DataSource = source;

        }

        private void frmPaymentConfig_Load(object sender, EventArgs e)
        {
            paymentConfig();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            btnCreate.Text = "Create";
            btnCreate.Enabled = true;
            Id.button = "CREATE";
        }

        private void btEdit_Click(object sender, EventArgs e)
        {
            if (dgvPaymentConfig.SelectedRows.Count > 0)
            {
                btnCreate.Text = "Update";
                btnCreate.Enabled = true;
                txtDesc.Text = Id.globalString;
                Id.button = "UPDATE";
            }
            else
            {
                MessageBox.Show("Please select a row to edit", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btDelete_Click(object sender, EventArgs e)
        {
            if (dgvPaymentConfig.SelectedRows.Count > 0)
            {
                //pc.modifyProduct("DELETE", "PAYCONFIG", Id.globalID, "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "");
                paymentConfig();
                btnCreate.Enabled = false;
                txtDesc.Clear();
            }
            else
            {
                MessageBox.Show("Please select a row to delete", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            paymentConfig();
            txtDesc.Clear();
            btnCreate.Enabled = false;
            btnCreate.Text = "Create";
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            if (Id.button == "CREATE")
            {
                string description = txtDesc.Text;
                description = char.ToUpper(description[0]) + description.Substring(1);
                DataTable dt = pc.fetchRecord("VIEW", "FETCHPAYCONFIGBYDESC", "", txtDesc.Text, "", "", "", "");
                if (dt.Rows.Count > 0)
                {
                    errorProvider1.SetError(txtDesc, "Description already exist");
                    txtDesc.Focus();
                }
                else
                {
                    if (!string.IsNullOrEmpty(txtDesc.Text))
                    {
                        //pc.modifyProduct("CRUD", "PAYCONFIG", pc.autoIncrementID("payID", "paymentConfig").ToString(), description, "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "");
                        paymentConfig();
                        txtDesc.Clear();
                        btnCreate.Enabled = false;
                        MessageBox.Show("Successfull saved", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            else if (Id.button == "UPDATE")
            {
                string description = txtDesc.Text;
                DataTable dt = pc.fetchRecord("VIEW", "FETCHPAYCONFIGFORUPDATE", Id.globalID, txtDesc.Text, "", "", "", "");
                if (dt.Rows.Count > 0)
                {
                    errorProvider1.SetError(txtDesc, "Description already exist");
                    txtDesc.Focus();
                }
                else
                {
                    if (!string.IsNullOrEmpty(txtDesc.Text))
                    {
                        description = char.ToUpper(description[0]) + description.Substring(1);
                        //pc.modifyProduct("CRUD", "PAYCONFIG", Id.globalID, description, "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "");
                        paymentConfig();
                        txtDesc.Clear();
                        btnAdd.Enabled = false;
                        MessageBox.Show("Successfull saved", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }

        private void dgvPaymentConfig_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = this.dgvPaymentConfig.Rows[e.RowIndex];

            Id.globalID = row.Cells["ID"].Value.ToString();
            Id.globalString = row.Cells["Description"].Value.ToString();
        }

        private void txtDesc_TextChanged(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            if (Id.button == "CREATE")
            {
                DataTable dt = pc.fetchRecord("VIEW", "FETCHPAYCONFIGBYDESC", "", txtDesc.Text, "", "", "", "");
                if (dt.Rows.Count > 0)
                {
                    errorProvider1.SetError(txtDesc, "Description already exist");
                    txtDesc.Focus();
                }
            }
            else
            {
                DataTable dt = pc.fetchRecord("VIEW", "FETCHPAYCONFIGFORUPDATE", Id.globalID, txtDesc.Text, "", "", "", "");
                if (dt.Rows.Count > 0)
                {
                    errorProvider1.SetError(txtDesc, "Description already exist");
                    txtDesc.Focus();
                }
            }
        }

        private void dgvPaymentConfig_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dgvPaymentConfig.ClearSelection();
        }
    }
}
