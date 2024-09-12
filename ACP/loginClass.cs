using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACP
{
    class loginClass
    {
        dbClass db = new dbClass();
        public DataTable authenticateUser(string username, string password)
        {
            return db.authenticateUser("sp_authenticateUser", username, password);
        }
    }
}
