using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data.Sql;
using System.Data;
using System.Windows.Forms;

namespace ACP
{
    class productClass
    {
        DataTable dt;
        public DataTable dgvToDt(DataGridView dgv)
        {
            dt = new DataTable();
            //foreach(DataGridViewColumn col in dgv.Columns)
            //{
            //    dt.Columns.Add(col.Name);
            //}
            dt.Columns.Add("code", typeof(string));
            dt.Columns.Add("barcode", typeof(string));
            dt.Columns.Add("description", typeof(string));
            dt.Columns.Add("qty", typeof(decimal));
            dt.Columns.Add("unitID", typeof(int));
            dt.Columns.Add("unit", typeof(string));
            foreach(DataGridViewRow row in dgv.Rows)
            {
                DataRow dRow = dt.NewRow();
                DataRow dRow2 = Id.dt.NewRow();
                foreach(DataGridViewCell cell in row.Cells)
                {
                    dRow[cell.ColumnIndex] = cell.Value;
                }
                dt.Rows.Add(dRow);
                Id.dt.Rows.Add(dRow2);
            }
            return dt;
        }
    }
}
