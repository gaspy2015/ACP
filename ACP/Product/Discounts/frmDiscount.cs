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
    public partial class frmDiscount : Form
    {
        productCreation pc = new productCreation();
        public frmDiscount()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            btnCreate.Text = "Create";
            btnCreate.Enabled = true;
            Id.button = "CREATE";
        }

        public void discount()
        {
            DataTable dt = pc.fetchRecord("VIEW", "FETCHDISC", "", "", "", "", "", "");
            BindingSource source = new BindingSource();
            source.DataSource = dt;
            dgvDiscount.DataSource = source;
        }

        private void frmDiscount_Load(object sender, EventArgs e)
        {
            discount();
        }

        private void btEdit_Click(object sender, EventArgs e)
        {
            if (dgvDiscount.SelectedRows.Count > 0)
            {
                btnCreate.Text = "Update";
                btnCreate.Enabled = true;
                txtDesc.Text = Id.globalString;
                cbPercent.Text = Id.globalString2;
                Id.button = "UPDATE";
            }
        }

        private void btDelete_Click(object sender, EventArgs e)
        {
            if (dgvDiscount.SelectedRows.Count > 0)
            {
                //pc.modifyProduct("DELETE", "DISC", Id.globalID, "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "");
                discount();
                btnCreate.Enabled = false;
                txtDesc.Clear();
                cbPercent.Text = "";
            }
            else
            {
                MessageBox.Show("Please select a row to delete", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            discount();
            btnCreate.Text = "Create";
            btnCreate.Enabled = false;
            txtDesc.Clear();
            cbPercent.Text = "";
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            if (Id.button == "CREATE")
            {
                string description = txtDesc.Text;
                DataTable dt = pc.fetchRecord("VIEW", "FETCHDISCBYDESC", "", txtDesc.Text, "", "", "", "");
                if (dt.Rows.Count > 0)
                {
                    errorProvider1.SetError(txtDesc, "Description already exist");
                    txtDesc.Focus();
                }
                else
                {
                    if (txtDesc.Text == "")
                    {
                        errorProvider1.SetError(txtDesc, "Description is required");
                    }
                    else if(cbPercent.Text == "")
                    {
                        errorProvider1.SetError(cbPercent, "Percent is required");
                    }
                    else
                    {
                        description = char.ToUpper(description[0]) + description.Substring(1);
                        //pc.modifyProduct("CRUD", "DISC", pc.autoIncrementID("discountID", "discount").ToString(), description, cbPercent.Text, "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "");
                        discount();
                        txtDesc.Clear();
                        cbPercent.Text = "";
                        btnCreate.Enabled = false;
                        MessageBox.Show("Successfull saved", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            else if (Id.button == "UPDATE")
            {
                string description2 = txtDesc.Text;
                DataTable dt = pc.fetchRecord("VIEW", "FETCHDISCFORUPDATE", Id.globalID, txtDesc.Text, "", "", "", "");
                if (dt.Rows.Count > 0)
                {
                    errorProvider1.SetError(txtDesc, "Description already exist");
                    txtDesc.Focus();
                }
                else
                {
                    if (txtDesc.Text == "")
                    {
                        errorProvider1.SetError(txtDesc, "Description is required");
                    }
                    else if(cbPercent.Text == "")
                    {
                        errorProvider1.SetError(cbPercent, "Percent is required");
                    }
                    else
                    {
                        description2 = char.ToUpper(description2[0]) + description2.Substring(1);
                        //pc.modifyProduct("CRUD", "DISC", Id.globalID, txtDesc.Text, cbPercent.Text, "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "");
                        discount();
                        txtDesc.Clear();
                        cbPercent.Text = "";
                        btnCreate.Enabled = false;
                        MessageBox.Show("Successfull updated", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }

        private void dgvDiscount_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = this.dgvDiscount.Rows[e.RowIndex];

            Id.globalID = row.Cells["ID"].Value.ToString();
            Id.globalString = row.Cells["Description"].Value.ToString();
            Id.globalString2 = row.Cells["Percent"].Value.ToString();
        }
    }
}
