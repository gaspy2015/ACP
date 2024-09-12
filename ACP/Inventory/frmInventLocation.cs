using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace ACP
{
    public partial class frmInventLocation : Form
    {
        productCreation pc = new productCreation();
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["ACP.Properties.Settings.connectionDB"].ConnectionString);
        public frmInventLocation()
        {
            InitializeComponent();
        }

        public void inventLocation()
        {
            //con.Open();
            //SqlCommand cmd = new SqlCommand("Select inventDesc from inventLocation", con);
            //SqlDataAdapter sda = new SqlDataAdapter(cmd);
            //DataTable dt = new DataTable();
            //sda.Fill(dt);
            //dgvInventLocation.DataSource = dt;

            DataTable dt = pc.fetchRecord("VIEW", "FETCHINVENTLOC", "", "", "", "", "", "");
            BindingSource source = new BindingSource();
            source.DataSource = dt;
            dgvInventLocation.DataSource = source;
        }

        //public void address()
        //{
        //    DataSet ds = pc.fetchSupplierId("VIEW", "ADDRESS", "Address");
        //    cbAddress.DataSource = ds.Tables["Address"];
        //    cbAddress.DisplayMember = "Address";
        //    cbAddress.ValueMember = "Address ID";
        //    cbAddress.Text = Id.address;
        //}

        public void site()
        {
            DataSet ds = pc.fetchData("VIEW", "FETCHSITE", "Name");
            cbAddress.DataSource = ds.Tables["Name"];
            cbAddress.DisplayMember = "Name";
            cbAddress.ValueMember = "ID";
            cbAddress.Text = Id.address;

        }

        private void frmInventLocation_Load(object sender, EventArgs e)
        {
            inventLocation();
            site();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            btnCreate.Text = "Create";
            btnCreate.Enabled = true;
            Id.button = "CREATE";

        }

        private void btEdit_Click(object sender, EventArgs e)
        {
            btnCreate.Text = "Update";
            btnCreate.Enabled = true;
            txtDesc.Text = Id.globalString;
            cbAddress.Text = Id.globalString2;
            txtLocation.Text = Id.location;
            Id.button = "UPDATE";
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            btnCreate.Text = "Create";
            btnCreate.Enabled = false;
            txtDesc.Clear();
            txtLocation.Clear();
            cbAddress.Text = "";
            inventLocation();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            if (Id.button == "CREATE")
            {
                string description = txtDesc.Text;
                description = char.ToUpper(description[0]) + description.Substring(1);
                DataTable dt = pc.fetchRecord("VIEW", "FETCHBINVENTLOCBYDESC", "", txtDesc.Text, "", "", "", "");
                if (dt.Rows.Count > 0)
                {
                    errorProvider1.SetError(txtDesc, "Description already exist");
                    txtDesc.Focus();
                }
                else
                {
                    if (!string.IsNullOrEmpty(txtDesc.Text))
                    {
                        //pc.modifyProduct("CRUD", "INVENTLOC", pc.autoIncrementID("inventLocID", "inventLocation").ToString(), cbAddress.GetItemText(cbAddress.SelectedValue), description, txtLocation.Text, "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "");
                        inventLocation();
                        txtDesc.Clear();
                        txtLocation.Clear();
                        cbAddress.Text = "";
                        btnCreate.Enabled = false;
                        MessageBox.Show("Successfull saved", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            else if (Id.button == "UPDATE")
            {
                string description = txtDesc.Text;
                DataTable dt = pc.fetchRecord("VIEW", "FETCHBINVENTLOCBYUPDATE", Id.globalID, txtDesc.Text, "", "", "", "");
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
                        //pc.modifyProduct("CRUD", "INVENTLOC", Id.globalID, cbAddress.GetItemText(cbAddress.SelectedValue), description, txtLocation.Text, "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "");
                        inventLocation();
                        txtDesc.Clear();
                        txtLocation.Clear();
                        cbAddress.Text = "";
                        btnAdd.Enabled = false;
                        MessageBox.Show("Successfull updated", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }

        private void txtDesc_TextChanged(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            if (Id.button == "CREATE")
            {
                DataTable dt = pc.fetchRecord("VIEW", "FETCHBINVENTLOCBYDESC", "", txtDesc.Text, "", "", "", "");
                if (dt.Rows.Count > 0)
                {
                    errorProvider1.SetError(txtDesc, "Description already exist");
                    txtDesc.Focus();
                }
            }
            else
            {
                DataTable dt = pc.fetchRecord("VIEW", "FETCHBINVENTLOCBYUPDATE", Id.globalID, txtDesc.Text, "", "", "", "");
                if (dt.Rows.Count > 0)
                {
                    errorProvider1.SetError(txtDesc, "Description already exist");
                    txtDesc.Focus();
                }
            }
        }

        private void btDelete_Click(object sender, EventArgs e)
        {
            if (dgvInventLocation.SelectedRows.Count > 0)
            {
                //pc.modifyProduct("DELETE", "INVENTLOC", Id.globalID, "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "");
                inventLocation();
                btnCreate.Enabled = false;
                txtDesc.Clear();
                txtLocation.Clear();
                cbAddress.Text = "";
            }
            else
            {
                MessageBox.Show("Please select a row to delete", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void dgvInventLocation_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dgvInventLocation.ClearSelection();
        }

        private void dgvInventLocation_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = this.dgvInventLocation.Rows[e.RowIndex];

            Id.inventLocID = row.Cells["ID"].Value.ToString();
            Id.globalID = row.Cells["ID"].Value.ToString();
            Id.globalString = row.Cells["Name"].Value.ToString();
            Id.globalString2 = row.Cells["Site"].Value.ToString();
            Id.location = row.Cells["Location"].Value.ToString();
        }

        private void frmInventLocation_FormClosing(object sender, FormClosingEventArgs e)
        {
            foreach (Form f in Application.OpenForms)
            {
                //if (f.Name == "frmProdAdditionalInfo")
                //{
                //    //(f as frmProdAdditionalInfo).cbWarehouse.Text = Id.globalString;
                //    //modifyProd.Controls.RemoveByKey("pCatHierarchy");
                //    (f as frmProdAdditionalInfo).Controls.RemoveByKey("pWarehouse");
                //    (f as frmProdAdditionalInfo).cbWarehouse.Focus();
                //    //(f as frmModifyProd).cbCategoryCode.BeginInvoke(new Action(() => (f as frmModifyProd).cbCategoryCode.SelectionLength = 0));
                //    Id.showWH = false;

                //}
            }
        }

        private void dgvInventLocation_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dgvInventLocation.Rows[e.RowIndex];

            //if(Id.access == "NEWPROD")
            //{
            //    frmProdAdditionalInfo additionalInfo = new frmProdAdditionalInfo();
            //    additionalInfo.cbWarehouse.Text = row.Cells["Name"].Value.ToString();
            //}
        }
    }
}
