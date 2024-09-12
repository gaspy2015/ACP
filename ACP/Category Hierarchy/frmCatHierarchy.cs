using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Linq;
using System.Data.Entity.SqlServer;

namespace ACP
{
    public partial class frmCatHierarchy : Form
    {
        // Declares a private variable lastAddedNode of type TreeNode and initializes it to null
        private TreeNode lastAddedNode = null;
        // Creates an instance of the CatHierarchyClass and assigns it to the variable cat
        CatHierarchyClass cat = new CatHierarchyClass();
        int status = 1;
        // Creates an instance of the TextInfo class from the current culture and assigns it to the variable txtInfo
        TextInfo txtInfo = CultureInfo.CurrentCulture.TextInfo;
        acpEntities db = new acpEntities();

        public frmCatHierarchy()
        {
            InitializeComponent();
            tvCatHierarchy.DrawMode = TreeViewDrawMode.OwnerDrawText;
          // tvCatHierarchy.DrawNode += tvCatHierarchy_DrawNode;
            //PopulateTreeView();
            btDelete.Enabled = false;
            btEdit.Enabled = false;
            Id.autoRID = cat.autoIncrementRid().ToString();
        }

        public void cleartext() {
            txtDesc.Clear();
            txtCode.Clear();
            rbYes.Checked = false;
            rbNo.Checked = false;
            btn.Enabled = false;
        }
        int profID;
        private void PopulateTreeView()
        {
            try
            {
                // Clears any existing nodes in the TreeView
                tvCatHierarchy.Nodes.Clear();
                // Resets the lastAddedNode variable to null
                lastAddedNode = null;
                profID = Convert.ToInt32(cmbProfile.SelectedValue);
                // Fetches a DataTable containing category hierarchy data
                //DataTable dataTable = cat.fetchCatHierarchy();
                    var hierarchy = db.sp_Hierarchy(profID).ToList();
                    // Creates a dictionary to store TreeNode objects, with string keys and TreeNode values
                    Dictionary<string, TreeNode> nodeDict = new Dictionary<string, TreeNode>();
                    // Iterates through each row in the DataTable
                    //foreach (DataRow row in dataTable.Rows)
                    //{
                    //    // Extracts values from the current DataRow
                    //    string RID = row["RID"].ToString();
                    //    string desc = row["desc"].ToString();
                    //    string lbl = row["code"].ToString().Trim();
                    //    string rtype = Convert.IsDBNull(row["rType"]) ? "0" : row["rType"].ToString();
                    foreach (sp_Hierarchy_Result item in hierarchy)
                    {
                        long RID = item.RID;
                        int profileID = item.profileID;
                        string profDesc = item.profDesc;
                        string code;
                        string desc = item.desc;
                        string rType = item.rType;
                        string pDesc = item.pDesc;
                        
                        TreeNode node = new TreeNode(desc);
                        if(!string.IsNullOrEmpty(item.code))
                        {
                            code = item.code.Trim();
                            node = new TreeNode(code +" "+ desc);
                        }
                        else
                        {
                            node = new TreeNode(desc);
                        }
                        // Creates a new TreeNode with a label that combines "lbl" and "desc"
                        //TreeNode node = new TreeNode(code + " " + desc);
                        // Sets the Tag property of the TreeNode to the value of "RID"
                        node.Tag = RID;
                        // Adds the TreeNode to the TreeView's root if "rtype" is "0"
                        if (string.IsNullOrEmpty(rType))
                        {
                            tvCatHierarchy.Nodes.Add(node);
                        }
                        // Adds the TreeNode to the parent node if the corresponding key exists in the dictionary
                        else
                        {
                            if (nodeDict.ContainsKey(rType))
                            {
                                TreeNode parentNode = nodeDict[rType];
                                parentNode.Nodes.Add(node);
                            }
                        }
                        // Adds the current TreeNode to the dictionary using "RID" as the key
                        nodeDict.Add(RID.ToString(), node);
                        // Updates the lastAddedNode variable with the current TreeNode
                        lastAddedNode = node;
                    
                }
            }
            catch (Exception ex )
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        // Declares a method named FindNodeById that returns a TreeNode
        private TreeNode FindNodeById(TreeNodeCollection nodes, string RID)
        {
            // Iterates through each TreeNode in the given TreeNodeCollection
            foreach (TreeNode node in nodes)
            {
                // Checks if the Tag property of the current node is equal to the provided "rType"
                if (node.Tag.ToString() == RID)
                {
                    // Returns the current node if the Tag property matches "rType"
                    return node;
                }
                // Recursively calls the FindNodeById method on the child nodes of the current node
                TreeNode foundNode = FindNodeById(node.Nodes, RID);
                // Returns the found node if it is not null (indicating a match)
                if (foundNode != null)
                {
                    return foundNode;
                }
            }
            // Returns null if no matching node is found in the entire TreeNode hierarchy
            return null;
        }

        private void tvCatHierarchy_DrawNode(object sender, DrawTreeNodeEventArgs e)
        {
            // treeview tree = new treeview();
            //  tree._treeview(e);
            e.DrawDefault = true;


        }

        private void profile()
        {
            cmbProfile.DataSource = (from a in db.profiles 
                                     select new 
                                     {
                                     a.profileID,
                                     a.profDesc
                                     }).ToList();
            cmbProfile.DisplayMember = "profDesc";
            cmbProfile.ValueMember = "profileID";
            cmbProfile.Text = "";
        }
        private void frmCatHierarchy_Load(object sender, EventArgs e)
        {
            profile();
            rbYes.Enabled = false;
            rbNo.Enabled = false;
            tvCatHierarchy.Focus();
           
        }

        private void tvCatHierarchy_AfterSelect(object sender, TreeViewEventArgs e)
        {
            // Retrieves the currently selected TreeNode from the TreeView
            TreeNode selectedNode = tvCatHierarchy.SelectedNode;
            // Retrieves the Tag property of the selected node and converts it to a string
            string selectedNodeID = selectedNode.Tag.ToString();
            // Sets a static property "rtypeID" in the "Id" class to the value of the selected node's ID
            Id.RID = selectedNodeID;
            RIDL = Convert.ToInt64(selectedNodeID);
            // Checks if the selected node's text matches a specific condition
            //if (tvCatHierarchy.SelectedNode.Text == "ACP ACE CENTERPOINT")
            var ifEmpty = (from a in db.hierarchies where a.RID == RIDL select a).SingleOrDefault();
            string rType = ifEmpty.rType;
            if(string.IsNullOrEmpty(rType))
            {
                btDelete.Enabled = false;
                btEdit.Enabled = false;
            }
            else
            {
                btDelete.Enabled = true;
                btEdit.Enabled = true;
            }
            rbYes.Enabled = false;
            rbNo.Enabled = false;
            cleartext();
        }
  
        private void btEdit_Click(object sender, EventArgs e)
        {
            btn.Text = "Update";
            try
            {
                
                //DataTable tbl = cat.fetchRecord(Id.RID);
                var objFetch = db.hierarchies.Where(a => a.RID == RIDL).ToList();
                foreach(hierarchy item in objFetch)
                {
                    txtCode.Text = item.code;
                    txtDesc.Text = item.desc;
                    Id.isActive = Convert.ToBoolean(item.isActive);
                    if(Id.isActive == true)
                    {
                        rbYes.Checked = true;
                    }
                    else
                    {
                        rbNo.Checked = true;
                    }
                    rbYes.Enabled = true;
                    rbNo.Enabled = true;
                }
                //foreach (DataRow row in tbl.Rows)
                //{
                //    txtCode.Text = row["code"].ToString().Trim();
                //    txtDesc.Text = row["desc"].ToString();
                //   Id.globalID = row["RID"].ToString();
                  
                //    int status = Convert.ToInt32(row["isActive"]);
                //    if (status == 1)
                //    {
                //        rbYes.Checked = true;
                //    }
                //    else if (status == 0) {

                //        rbNo.Checked = true;
                //    }
                //    rbYes.Enabled = true;
                //    rbNo.Enabled = true;
                //}
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
        private void btDelete_Click(object sender, EventArgs e)
        {
           
              DialogResult result = MessageBox.Show("Are you sure you want to delete?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

              if (result == DialogResult.Yes)
              {
                  var objDelete = db.hierarchies.Where(a => a.RID == RIDL).SingleOrDefault();
                  //cat.removeCategory();
                  db.hierarchies.Remove(objDelete);
                  db.SaveChanges();
                  tvCatHierarchy.SelectedNode.Remove();
                  autoInc();
              }

        }
        private void rbYes_CheckedChanged(object sender, EventArgs e)
        {
            if (rbYes.Checked)
            {
                status = 1;
                Id.isActive = true;
            }
        }
        private void rbNo_CheckedChanged(object sender, EventArgs e)
        {
            if (rbNo.Checked)
            {
                status = 0;
                Id.isActive = false;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(cmbProfile.Text))
            {
                btn.Text = "Create";
                rbYes.Enabled = false;
                rbNo.Enabled = false;
                cleartext();
                btn.Enabled = true;
                rbYes.Checked = true;
            }
            else
            {
                MessageBox.Show("Please select profile", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cmbProfile.Focus();
            }
            
        }

        private void txtCode_TextChanged(object sender, EventArgs e)
        {
          
            string code = txtCode.Text;
           // string ID = lbRID.Text;
            errorProvider1.Clear();
            btn.Enabled = true;
            DataTable dt = cat.CheckRecord(code,Id.RID);
            foreach (DataRow item in dt.Rows)
            {
                string lbl = item["code"].ToString().Trim();
                if (lbl== code)
                {
                    btn.Enabled = true; 
                    rbYes.Checked = true;
                }
                else {
                    errorProvider1.SetError(txtCode,"Code is Already Exist");
                    btn.Enabled = false;
                }
            }
        }

        //private void autoID()
        //{

        //    Id.autoRID = cat.autoIncrementRid().ToString();
        //}
        //int autoRID;
        long autoRID;
        private void autoInc()
        {

            autoRID = cat.autoIncrementRid();
            //var inc = db.sp_autoInc("Hierarchy");
            //if(inc.Any())
            //{
            //    autoRID = Convert.ToInt64(inc.FirstOrDefault().Value);
            //}
            //var inc = db.sp_autoInc("Hierarchy").Max(a => Convert.ToInt64(a.Value));
            //autoRID = inc.ToString();
        }
     
        string msg;
        long RIDL;
        private void btn_Click(object sender, EventArgs e)
        {
            //try
            //{

                autoInc();
                MessageBox.Show(autoRID.ToString());
                string action = btn.Text;
                string code = txtCode.Text;
                string rtype = Id.RID;
                string desc = txtInfo.ToTitleCase(txtDesc.Text);
                long rid = autoRID;
                int profileID = Convert.ToInt32(cmbProfile.SelectedValue);
                RIDL = Convert.ToInt64(Id.RID);
                switch (action)
                {
                    case "Create":
                        msg = "Save";
                        break;
                    case "Update":
                        msg = "Update";
                        break;
                }
                
                if (!string.IsNullOrEmpty(desc))
                {
                    DialogResult result = MessageBox.Show("Are you sure you want to " + msg + "?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (result == DialogResult.Yes)
                    {
                        if (action == "Create")
                        {
                            TreeNode tn = tvCatHierarchy.SelectedNode;
                            hierarchy h = new hierarchy();
                            if (tn == null)
                            {
                                h.RID = rid;
                                h.profileID = profileID;
                                h.code = code;
                                h.desc = desc;
                                h.rType = null;
                                h.pDesc = null;
                                h.isActive = Id.isActive;
                                h.transDate = DateTime.Now;

                                db.hierarchies.Add(h);
                                db.SaveChanges();
                            }
                            else
                            {
                                h.RID = rid;
                                h.profileID = profileID;
                                h.code = code;
                                h.desc = desc;
                                h.rType = rtype;
                                h.pDesc = null;
                                h.isActive = Id.isActive;
                                h.transDate = DateTime.Now;

                                db.hierarchies.Add(h);
                                db.SaveChanges();
                            }
                            //cat.CatHierarchyCrud(rid, code, desc, rtype, status, "");
                            // Creates a new TreeNode with the specified label and ID
                            TreeNode newNode = new TreeNode(code + " " + desc);
                            newNode.Tag = rid;
                            // Finds the parent node in the TreeView based on the rtype and adds the new node
                            TreeNode parentNode = FindNodeById(tvCatHierarchy.Nodes, rtype);
                            if (parentNode != null)
                            {
                                parentNode.Nodes.Add(newNode);
                            }
                            // Selects the newly added node, ensures visibility, and updates the lastAddedNode variable
                            tvCatHierarchy.SelectedNode = newNode;
                            newNode.EnsureVisible();
                            lastAddedNode = newNode;
                            cleartext();


                        }else if(action == "Update"){

                            var objUpdate = db.hierarchies.Where(a => a.RID == RIDL).SingleOrDefault();
                            objUpdate.code = code;
                            objUpdate.desc = desc;
                            objUpdate.isActive = Id.isActive;

                            db.SaveChanges();
                            MessageBox.Show("Successfully updated", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            //cat.CatHierarchyCrud(Id.globalID,code,desc,rtype,status,"");
                            // Finds the node to update in the TreeView based on the globalID
                            TreeNode nodeToUpdate = FindNodeById(tvCatHierarchy.Nodes, Id.RID);
                            //if (nodeToUpdate != null)
                            //{
                                // Updates the text and Tag properties of the node
                                nodeToUpdate.Text = txtCode.Text + " " + txtDesc.Text;
                                nodeToUpdate.Tag = Id.globalID; // Update the Tag if necessary

                                // Ensure the updated node is visible
                                nodeToUpdate.EnsureVisible();
                            //}
                            //PopulateTreeView();
                        }
                    }
                }
                else {

                    MessageBox.Show("Please provide values for all fields.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            //}

            //catch (Exception ex)
            //{

            //    MessageBox.Show(ex.Message);
            //}
     
        }

        //public string code { get; set; }
        private void tvCatHierarchy_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            //if (Id.access == "NEWPROD")
            //{
            //    frmModifyProd modyProd = new frmModifyProd();

            //    try
            //    {

            //        DataTable tbl = cat.fetchRecord(Id.rtypeID);
            //        foreach (DataRow row in tbl.Rows)
            //        {
            //            //modyProd.cbCategoryCode.Text = row["code"].ToString().Trim();
            //            Id.categoryCode = row["code"].ToString();
            //            //modyProd.cbCategoryCode.Refresh();
            //            //modyProd.cbCategoryCode.Text = Id.categoryCode;
            //            //code = row["code"].ToString().Trim();

            //            this.Close();

            //        }
            //    }
            //    catch (Exception ex)
            //    {

            //        MessageBox.Show(ex.Message);
            //    }

            //}
        }

        bool doubleClik;
        private void tvCatHierarchy_MouseDown(object sender, MouseEventArgs e)
        {
            if(Id.access == "NEWPROD")
            {
                doubleClik = e.Button == MouseButtons.Left && e.Clicks == 2;
            }
        }

        private void tvCatHierarchy_BeforeExpand(object sender, TreeViewCancelEventArgs e)
        {
            if (Id.access == "NEWPROD")
            {
                if (e.Action == TreeViewAction.Expand) e.Cancel = doubleClik;
            }
        }

        private void frmCatHierarchy_FormClosing(object sender, FormClosingEventArgs e)
        {
            foreach(Form f in Application.OpenForms)
            {
                if(f.Name == "frmModifyProd")
                {
                    //(f as frmModifyProd).cmbCategoryCode.Text = Id.categoryCode;
                    //modifyProd.Controls.RemoveByKey("pCatHierarchy");
                    (f as frmModifyProd).pGeneral.Controls.RemoveByKey("pCatHierarchy");
                    //(f as frmModifyProd).cmbCategoryCode.Focus();
                    //(f as frmModifyProd).cbCategoryCode.BeginInvoke(new Action(() => (f as frmModifyProd).cbCategoryCode.SelectionLength = 0));
                    Id.shown = false;

                }
            }
        }

        private void tvCatHierarchy_Click(object sender, EventArgs e)
        {
            btn.Enabled = false;
        }

        private void frmCatHierarchy_Deactivate(object sender, EventArgs e)
        {

        }

        private void cmbProfile_SelectionChangeCommitted(object sender, EventArgs e)
        {
            PopulateTreeView();
        }

        private void cmbProfile_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            PopulateTreeView();
            cleartext();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //var inc = db.sp_autoInc("Hierarchy");
        }

        private void txtDesc_TextChanged(object sender, EventArgs e)
        {
            if(!string.IsNullOrEmpty(txtDesc.Text))
            {
                btn.Enabled = true;
                rbYes.Checked = true;
            }
            else
            {
                btn.Enabled = false;
            }
        }
        

        
    }
     



}




        