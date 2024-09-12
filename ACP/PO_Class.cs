using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
namespace ACP
{
    class PO_Class
    {
        dbClass db = new dbClass();

        public DataTable fetch_supplier() {

            return db.getRecord("Select * from supplier");
        }

        public DataTable fetch_supplierID(string suppID)
        {

            return db.getRecord("Select * from vwSupplier where suppID = '" + suppID + "'");
        }
        public DataSet fetch_pool()
        {
            return db.cbRecords("sp_purchaseOrder", "Pool", "fetchPool", "poolID");
        }

        public DataTable fetch_poolID(string poolID)
        {

            return db.getRecord("Select * from _pool where poolID = '" + poolID + "'");
        }
    }
}
