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
    public partial class frmAddLines : Form
    {
        acpEntities db = new acpEntities();
        public frmAddLines()
        {
            InitializeComponent();
        }

        private void tabControl1_Selected(object sender, TabControlEventArgs e)
        {

        }

        public void selectedItems()
        {
            DataGridViewCheckBoxColumn checkboxSI = new DataGridViewCheckBoxColumn();
            checkboxSI.Name = "cbSelectedItems";
            checkboxSI.HeaderText = "";
            dgvSelectedItems.Columns.Insert(0, checkboxSI);
            headerCheckBoxsi();
            headerCBsi.MouseClick += headerCBsi_MouseClick;
            dgvSelectedItems.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvSelectedItems.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvSelectedItems.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dgvSelectedItems.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvSelectedItems.Columns[0].Width = 25;
            //dgvSelectedItems.RowHeadersWidth = 50;
        }

        CheckBox headerCBsi = null;
        bool isHeaderCBsiclicked = false;
        private void headerCheckBoxsi()
        {
            headerCBsi = new CheckBox();
            headerCBsi.Size = new Size(15, 15);
            this.dgvSelectedItems.Controls.Add(headerCBsi);
            Rectangle rect = dgvSelectedItems.GetCellDisplayRectangle(0, -1, false);
            rect.X = rect.Location.X + (rect.Width / 4);
            rect.Y = rect.Location.Y + (rect.Height / 4);
            headerCBsi.Location = rect.Location;
        }

        private void headerCBsiclick(CheckBox hCheckBoxsi)
        {
            isHeaderCBsiclicked = true;

            foreach (DataGridViewRow row in dgvSelectedItems.Rows)
                ((DataGridViewCheckBoxCell)row.Cells["cbSelectedItems"]).Value = hCheckBoxsi.Checked;

            dgvSelectedItems.RefreshEdit();

            isHeaderCBsiclicked = false;
        }
        private void headerCBsi_MouseClick(object sender, MouseEventArgs e)
        {
            headerCBsiclick((CheckBox)sender);
        }

        public void newItems()
        {
            dgvNewItems.Columns.Clear();
            dgvNewItems.DataSource = (from a in db.vwProducts where a.suppID == Id.suppID
                                      select new 
                                      {
                                      a.SKU,
                                      a.Barcode,
                                      a.Product_description,
                                      a.desc
                                      }).ToList();
            DataGridViewCheckBoxColumn checkbox = new DataGridViewCheckBoxColumn();
            checkbox.Name = "cbItems";
            checkbox.HeaderText = "";
            dgvNewItems.Columns.Insert(0, checkbox);
            headerCheckBox();
            headerCB.MouseClick += headerCB_MouseClick;
            //DataGridViewCheckBoxColumn checkbox = new DataGridViewCheckBoxColumn();
            //checkbox.ValueType = typeof(bool);
            //checkbox.Name = "Select";
            //checkbox.HeaderText = "Select";
            //dgvNewItems.Columns.Insert(4, checkbox);
            //dgvNewItems.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvNewItems.Columns[1].HeaderText = "SKU";
            dgvNewItems.Columns[2].HeaderText = "Barcode";
            dgvNewItems.Columns[3].HeaderText = "Product description";
            dgvNewItems.Columns[4].HeaderText = "Sub category";
            //dgvNewItems.Columns[6].DataPropertyName = "isDistributor";
        }

        CheckBox headerCB = null;
        bool isHeaderCBclicked = false;
        private void headerCheckBox()
        {
            headerCB = new CheckBox();
            headerCB.Size = new Size(15, 15);
            this.dgvNewItems.Controls.Add(headerCB);
            Rectangle rect = dgvNewItems.GetCellDisplayRectangle(0, -1, false);
            rect.X = rect.Location.X + (rect.Width + 5);
            rect.Y = rect.Location.Y + (rect.Height + 6);
            headerCB.Location = rect.Location;
        }

        private void headerCBclick(CheckBox hCheckBox)
        {
            isHeaderCBclicked = true;

            foreach (DataGridViewRow row in dgvNewItems.Rows)
                ((DataGridViewCheckBoxCell)row.Cells["cbItems"]).Value = hCheckBox.Checked;

            dgvNewItems.RefreshEdit();

            isHeaderCBclicked = false;
        }
        private void headerCB_MouseClick(object sender, MouseEventArgs e)
        {
            headerCBclick((CheckBox)sender);
        }


        private void tpNewItems_Enter(object sender, EventArgs e)
        {
            
        }

        private void dgvNewItems_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //DataGridViewRow row = dgvNewItems.Rows[e.RowIndex];
            //bool select = Convert.ToBoolean(row.Cells["Select"].Value);
            //if(e.ColumnIndex == 4 && e.RowIndex != -1)
            //{
            //    if (select == true)
            //    {
            //        dgvSelectedItems.Rows.Add(row.Cells["SKU"].Value.ToString(), row.Cells["barcode"].Value.ToString(), row.Cells["posDesc"].Value.ToString(), "");
            //    } 
            //}
            
        }

        private void dgvNewItems_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            //Fires after selecting a row
        }

        private void dgvNewItems_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
        }
        private void dgvNewItems_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            
            dgvNewItems.ClearSelection();
        }
        private void dgvNewItems_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //DataGridViewRow row = dgvNewItems.Rows[e.RowIndex];
            //bool select = Convert.ToBoolean(row.Cells["Select"].Value);
            //if (select)
            //{
            //    dgvSelectedItems.Rows.Add(row.Cells["SKU"].Value.ToString(), row.Cells["barcode"].Value.ToString(), row.Cells["posDesc"].Value.ToString(), "");
            //} 
        }

        private void dgvNewItems_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            
        }

        private void dgvNewItems_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            //Fires after selecting a row
        }

        private void dgvNewItems_CellValuePushed(object sender, DataGridViewCellValueEventArgs e)
        {
            
        }

        private void dgvNewItems_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
        }

        private void dgvNewItems_CellValidated(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void frmAddLines_Load(object sender, EventArgs e)
        {
            newItems();
            //selectedItems();
        }

        private void btnCopy_Click(object sender, EventArgs e)
        {
            //DataGridViewRow row = dgvNewItems.Rows[e.RowIndex];
            //bool select = Convert.ToBoolean(row.Cells["Select"].Value);
            //if (e.ColumnIndex == 4 && e.RowIndex != -1)
            //{
            //    if (select == true)
            //    {
            //        dgvSelectedItems.Rows.Add(row.Cells["SKU"].Value.ToString(), row.Cells["barcode"].Value.ToString(), row.Cells["posDesc"].Value.ToString(), "");
            //    }
            //}
            if (btnSelect.Text.Equals("Cancel"))
            {
                btnSelect.Text = "Select";
                dgvSelectedItems.Columns.RemoveAt(0);
                dgvSelectedItems.Controls.Remove(headerCBsi);
            }

            dgvSelectedItems.Rows.Clear();
            foreach(DataGridViewRow row in dgvNewItems.Rows)
            {
                    bool select = Convert.ToBoolean(row.Cells["cbItems"].Value);
                    if(select)
                    {
                        int i = dgvSelectedItems.Rows.Add();
                        dgvSelectedItems.Rows[i].Cells[0].Value = row.Cells[1].Value.ToString();
                        dgvSelectedItems.Rows[i].Cells[1].Value = row.Cells[2].Value.ToString();
                        dgvSelectedItems.Rows[i].Cells[2].Value = row.Cells[3].Value.ToString();
                        //dgvSelectedItems.Rows.Add(row.Cells["SKU"].Value.ToString(), row.Cells["Barcode"].Value.ToString(), row.Cells["Product_Description"].Value.ToString(), "");
                    //foreach(DataGridViewRow row2 in dgvSelectedItems.Rows)
                    //{
                    //   if (row.Cells["Barcode"].Value.ToString() == row2.Cells["barcode"].Value.ToString())
                    //        {
                    //            dgvSelectedItems.Rows.Add(row.Cells["SKU"].Value.ToString(), row.Cells["Barcode"].Value.ToString(), row.Cells["Product_Description"].Value.ToString(), "");
                    //        }
                    //        else
                    //        {
                                
                    //        }
                        
                        
                    }
                dgvSelectedItems.Columns["qty"].ReadOnly = false;
                //dgvSelectedItems.Columns[1].ReadOnly = true;
                //dgvSelectedItems.Columns[2].ReadOnly = true;
                //dgvSelectedItems.Columns[3].ReadOnly = false;
                //dgvSelectedItems.Columns[4].ReadOnly = false;
            }
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            if(btnSelect.Text.Equals("Select"))
            {
                btnSelect.Text = "Cancel";
                selectedItems();
            }
            else if(btnSelect.Text.Equals("Cancel"))
            {
                btnSelect.Text = "Select";
                dgvSelectedItems.Columns.RemoveAt(0);
                dgvSelectedItems.Controls.Remove(headerCBsi);
            }
        }
    }
}
