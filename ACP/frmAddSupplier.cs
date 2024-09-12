using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace ACP
{
    public partial class frmAddSupplier : Form
    {
        supplierClass supClass = new supplierClass();
        string TID, description, Pdesc, rtype;
        public frmAddSupplier()
        {
            InitializeComponent();
            dgvAddress.Focus();
          //  dgvAddress.Rows.Clear();
        }

        private void lbNew_Click(object sender, EventArgs e)
        {
            Id.columnID = "TID";
            Id.table = "RecordType";
            frmRecordType record = new frmRecordType();

            if (record.ShowDialog() == DialogResult.OK)
            {
                TID = supClass.autoIncrementID().ToString();
                //description = record.txtDesc.Text;
                Pdesc = record.txtPdesc.Text;
               rtype = record.txtRType.Text;
               supClass.insertRecordType(TID, description, rtype, Pdesc);
                fetchRtype();
            }
        }

        public void fetchRtype()
        {
            DataSet ds = supClass.fetchRType();
            cbType.DataSource = ds.Tables["tdesc"];
            cbType.DataSource = ds.Tables["tDesc"];
            cbType.DisplayMember = "tDesc";
            cbType.ValueMember = "TID";
            cbType.Text = Id.globalString;
            cbType.Text = Id.globalString;
        }
        private void frmAddSupplier_Load(object sender, EventArgs e)
        {
            Id.rType = "1";
            if (Id.button.Equals("Create"))
            {
                fetchRtype();
            }
            else if (Id.button.Equals("Update"))
            {
                fetch_sAddress();
                fetchRtype();
                SelectFirstRow();
               
            }
           
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string TID = cbType.GetItemText(cbType.SelectedValue);
            string suppID = txtSupCode.Text;
            string suppDesc =txtSuppDesc.Text;
            string agent = txtAgent.Text;
            frmSupplierMgt mgt = new frmSupplierMgt(); 
            string msg = "";
            if (Id.button.Equals("Create"))
            {
               msg = "Save";
            }
            else if(Id.button.Equals("Update")) {
               msg = "Update";
            }
            if (!string.IsNullOrEmpty(cbType.Text) && !string.IsNullOrEmpty(txtSupCode.Text) && !string.IsNullOrEmpty(txtSuppDesc.Text) && !string.IsNullOrEmpty(txtAgent.Text) && !string.IsNullOrEmpty(cbGroup.Text))
            {
                DialogResult result = MessageBox.Show("Are you sure you want to "+msg+"?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                string SuppID = txtSupCode.Text;
                if (result == DialogResult.Yes)
                {
                    if (dgvAddress.Rows.Count > 0)
                    {
                        foreach (DataGridViewRow row in dgvAddress.Rows)
                        {
                            string addressID = row.Cells["addressID"].Value.ToString();
                           supClass.insertMultiAddress(SuppID, addressID);
                       }
                    }
                    else
                    {
                        supClass.insertMultiAddress(SuppID,"NULL");
                    }

                    this.DialogResult = DialogResult.OK;
                
                  
                }
            }
            else {

                MessageBox.Show("Please provde values for all fields.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

           

        }

        private void btnLink_Click(object sender, EventArgs e)
        {
            frmAddress address = new frmAddress();
            DialogResult result = address.ShowDialog();
            if (result ==  DialogResult.OK)
            {
                foreach (DataGridViewRow row in address.dgvListAdd.SelectedRows)
                {
                    string id = row.Cells[0].Value.ToString();

                    bool idExists = dgvAddress.Rows.Cast<DataGridViewRow>()
                           .Any(r => r.Cells[0].Value.ToString() == id);
                    if (!idExists)
                    {
                        DataGridViewRow clonedRow = (DataGridViewRow)row.Clone();
                        foreach (DataGridViewCell cell in row.Cells)
                        {
                            clonedRow.Cells[cell.ColumnIndex].Value = cell.Value;
                        }

                        dgvAddress.Rows.Add(clonedRow);
                    }
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (Id.button.Equals("Create"))
            {
                if (dgvAddress.SelectedRows.Count > 0)
                {
                    dgvAddress.Rows.RemoveAt(dgvAddress.SelectedRows[0].Index);
                }

            }else if(Id.button.Equals("Update")){

                DialogResult result = MessageBox.Show("Are you sure you want to delete ?", "Delete Message", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result.Equals(DialogResult.Yes))
                {
                    supClass.delete_suppAddress(txtSupCode.Text, Id.addressID);
                    fetch_sAddress();
                }
              

            }
           
        }
        private void SelectFirstRow()
        {
            if (dgvAddress.Rows.Count > 0)
            {
                Id.addressID = dgvAddress.SelectedRows[0].Cells["addressID"].Value.ToString();
            }
        }

        private void dgvAddress_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dgvAddress.Rows[e.RowIndex];

            if (e.RowIndex >= 0)
            {
                Id.addressID = row.Cells["addressID"].Value.ToString();
            }
        }

        private void btnConAdd_Click(object sender, EventArgs e)
        {
            frmListOfContact listCon = new frmListOfContact();
            listCon.ShowDialog();
        }

        public void fetch_sAddress()
        {
            dgvAddress.Rows.Clear();
            DataTable dtAddress = supClass.fetch_suppAddress();
            foreach (DataRow row in dtAddress.Rows)
            {
                bool hasEmptyOrNull = false;
                // Check each column for null or empty values
                foreach (var item in row.ItemArray)
                {
                    if (item == null || string.IsNullOrWhiteSpace(item.ToString()))
                    {
                        hasEmptyOrNull = true;
                        break;
                    }
                }
                // Add row if it doesn't have any null or empty values
                if (!hasEmptyOrNull)
                {
                    dgvAddress.Rows.Add(
                        row["Address ID"].ToString(),
                        row["Description"].ToString(),
                        row["Address"].ToString(),
                        row["City"].ToString(),
                        row["Province"].ToString(),
                        row["Remarks"].ToString()
                    );
                }
            }
        }

    }
}