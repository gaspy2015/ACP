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
    public partial class frmOtherPrice : Form
    {
        productCreation pc = new productCreation();
        public frmOtherPrice()
        {
            InitializeComponent();
        }

        private void tsBtnNew_Click(object sender, EventArgs e)
        {
            //DataTable dt = pc.fetchRecord("VIEW", "FETCHPAYCONFIG", "", "", "", "", "", "");
            //BindingSource source = new BindingSource();
            //source.DataSource = dt;
            //cbSgroup.DataSource = ds.Tables["Description"];
            //cbSgroup.DisplayMember = "Description";
            //cbSgroup.ValueMember = "Storage ID";
            //cbSgroup.Text = Id.sdGroupDesc;
            //int n = dgvOtherPrice.Rows.Add();
            //List<string> desc = new List<string>();
            //foreach (DataGridViewRow row in dgvOtherPrice.Rows)
            //{
            //    DataGridViewComboBoxCell cbCell = (row.Cells["payID"] as DataGridViewComboBoxCell);
            //    foreach (DataRow dRow in dt.Rows)
            //    {
            //        //cbCell.DisplayMember = dRow[1].ToString();
            //        //cbCell.ValueMember = dRow[0].ToString();
            //        cbCell.Items.Clear();
            //        //cbCell.Items.Add(dRow[1]);
            //        desc.Add(dRow[0].ToString());
            //        cbCell.Items.Add(desc);
            //    }
            //}
            DataSet ds = pc.fetchData("VIEW", "FETCHPAYCONFIG", "Description");
            DataGridViewComboBoxCell c = new DataGridViewComboBoxCell();
            c.DataSource = ds.Tables["Description"];
            c.ValueMember = "ID";
            c.DisplayMember = "Description";
            int n = dgvOtherPrice.Rows.Add();
            dgvOtherPrice.Rows[n].Cells["payID"] = c;
        }

        private void frmOtherPrice_Load(object sender, EventArgs e)
        {
            
        }
    }
}
