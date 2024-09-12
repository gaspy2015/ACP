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
    public partial class frmPostingReceipt : Form
    {
        acpEntities db = new acpEntities();
        barcodeClass code = new barcodeClass();
        public frmPostingReceipt()
        {
            InitializeComponent();
        }

        private void frmPostingReceipt_Load(object sender, EventArgs e)
        {
            if (dgvReceipt.Rows.Count > 0)
            {
                tsbNew.Enabled = false;
            }
            else
            {
                tsbNew.Enabled = true;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(dgvReceipt.Rows[0].Cells["invoice"].Value as String))
            {
                MessageBox.Show("Fill up necessary information", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                int rowIndex = dgvReceipt.CurrentRow.Index;
                dgvReceipt.CurrentCell = dgvReceipt.Rows[rowIndex].Cells["productReceipt"];
            }
            else if (string.IsNullOrEmpty(dgvReceipt.Rows[0].Cells["acrNo"].Value as String))
            {
                MessageBox.Show("Fill up necessary information", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                int rowIndex = dgvReceipt.CurrentRow.Index;
                dgvReceipt.CurrentCell = dgvReceipt.Rows[rowIndex].Cells["acrNo"];
            }
            else if (string.IsNullOrEmpty(dgvReceipt.Rows[0].Cells["voyageNo"].Value as String))
            {
                MessageBox.Show("Fill up necessary information", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                int rowIndex = dgvReceipt.CurrentRow.Index;
                dgvReceipt.CurrentCell = dgvReceipt.Rows[rowIndex].Cells["voyageNo"];
            }
            else if (string.IsNullOrEmpty(dgvReceipt.Rows[0].Cells["vanNo"].Value as String))
            {
                MessageBox.Show("Fill up necessary information", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                int rowIndex = dgvReceipt.CurrentRow.Index;
                dgvReceipt.CurrentCell = dgvReceipt.Rows[rowIndex].Cells["vanNo"];
            }
            else if (string.IsNullOrEmpty(dgvReceipt.Rows[0].Cells["dateArrived"].Value as String))
            {
                MessageBox.Show("Fill up necessary information", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                int rowIndex = dgvReceipt.CurrentRow.Index;
                dgvReceipt.CurrentCell = dgvReceipt.Rows[rowIndex].Cells["dateArrived"];
            }
            else
            {

                receiving rcv = new receiving();
                string rrNum = code.GenerateEan5();
                string orderNo = dgvReceipt.Rows[0].Cells["orderNo"].Value.ToString();
                string invoice = dgvReceipt.Rows[0].Cells["invoice"].Value.ToString();
                string acrNum = dgvReceipt.Rows[0].Cells["acrNo"].Value.ToString();;
                string voyageNum = dgvReceipt.Rows[0].Cells["voyageNo"].Value.ToString();
                string vanNum = dgvReceipt.Rows[0].Cells["vanNo"].Value.ToString();
                string remarks = dgvReceipt.Rows[0].Cells["cartons"].Value.ToString();
                DateTime dateArrived = Convert.ToDateTime(dgvReceipt.Rows[0].Cells["dateArrived"].Value);
                DateTime transDate = DateTime.Now;

                rcv.rrNum = rrNum;
                rcv.orderNo = orderNo;
                rcv.invoice = invoice;
                rcv.ACRnum = acrNum;
                rcv.voyageNum = voyageNum;
                rcv.vanNum = vanNum;
                rcv.cartons = remarks;
                rcv.dateArrived = dateArrived;
                rcv.transDate = transDate;

                db.receivings.Add(rcv);
                db.SaveChanges();
                DialogResult res = MessageBox.Show("Successfully saved. Print receiving report?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                if(res == DialogResult.Yes)
                {
                    this.DialogResult = DialogResult.No;
                    this.Hide();
                }
                else
                {
                    this.DialogResult = DialogResult.No;
                    this.Hide();
                }
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvReceipt_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0)
            {
                if(dgvReceipt.Rows.Count > 0)
                {
                    tsbNew.Enabled = false;
                }
                else
                {
                    tsbNew.Enabled = true;
                }
                if(dgvReceipt.SelectedRows.Count > 0)
                {
                    var objExist = db.receivings.Where(a => a.orderNo.Equals(Id.orderNo));
                    if(objExist.Any())
                    {
                        tsbCancel.Enabled = true;
                        tsbPrint.Enabled = true;
                    }
                    else
                    {
                        tsbCancel.Enabled = false;
                        tsbPrint.Enabled = false;
                    }
                }
                else
                {
                    tsbCancel.Enabled = false;
                }
            }
        }

        private void tsbNew_Click(object sender, EventArgs e)
        {
            var objCol = db.vwPurchaseOrders.Where(a => a.Order_No.Equals(Id.orderNo)).SingleOrDefault();
            bool isOutright = Convert.ToBoolean(objCol.isConcession);
            string isConcession;
            if(isOutright)
            {
                isConcession = "Concession";
            }
            else
            {
                isConcession = "Outright";
            }
            dgvReceipt.Rows.Add(Id.orderNo, Id.globalString, "", isConcession, "", "", "", "", "");
            var lines = db.vwPO_Line.Where(a => a.orderNo.Equals(Id.orderNo)).ToList();
            int i = 1;
            if(lines.Any())
            {
                foreach (vwPO_Line line in lines)
                {
                    dgvLines.Rows.Add(i++, line.SKU, line.barcode, line.posDesc, line.subcat_desc, line.qty, line.rcve, line.CPuomDesc, line.costPrice, line.retailPrice, line.lineDisc, line.Net_amount);
                }
            }
            tsbNew.Enabled = false;
            
        }

        private void tsbCancel_Click(object sender, EventArgs e)
        {
            if(dgvReceipt.SelectedRows.Count > 0)
            {
                DialogResult res = MessageBox.Show("Delete packing slip?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if(res == DialogResult.Yes)
                {
                    var objDel = db.receivings.Where(a => a.orderNo.Equals(Id.orderNo)).SingleOrDefault();

                    db.receivings.Remove(objDel);
                    db.SaveChanges();

                    MessageBox.Show("Successfully deleted", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dgvReceipt.Rows.Clear();
                    dgvLines.Rows.Clear();
                }
            }
        }

        private void dgvReceipt_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dgvReceipt.ClearSelection();
        }

        private void dgvLines_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dgvLines.ClearSelection();
        }
    }
}
