namespace ACP
{
    partial class frmAddLines
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddLines));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtFilter = new System.Windows.Forms.TextBox();
            this.cmbFilter = new System.Windows.Forms.ComboBox();
            this.btnFilter = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tpExistItems = new System.Windows.Forms.TabPage();
            this.dgvExistItems = new System.Windows.Forms.DataGridView();
            this.tpNewItems = new System.Windows.Forms.TabPage();
            this.dgvNewItems = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnSelect = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.dgvSelectedItems = new System.Windows.Forms.DataGridView();
            this.SKU = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.barcode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemDesc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnCreate = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnCopy = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tpExistItems.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvExistItems)).BeginInit();
            this.tpNewItems.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNewItems)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSelectedItems)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtFilter);
            this.groupBox1.Controls.Add(this.cmbFilter);
            this.groupBox1.Controls.Add(this.btnFilter);
            this.groupBox1.Controls.Add(this.tabControl1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(596, 518);
            this.groupBox1.TabIndex = 95;
            this.groupBox1.TabStop = false;
            // 
            // txtFilter
            // 
            this.txtFilter.Location = new System.Drawing.Point(467, 106);
            this.txtFilter.Name = "txtFilter";
            this.txtFilter.Size = new System.Drawing.Size(121, 22);
            this.txtFilter.TabIndex = 99;
            // 
            // cmbFilter
            // 
            this.cmbFilter.FormattingEnabled = true;
            this.cmbFilter.Items.AddRange(new object[] {
            "",
            "Supplier ID",
            "SKU",
            "Barcode",
            "Item description"});
            this.cmbFilter.Location = new System.Drawing.Point(467, 76);
            this.cmbFilter.Name = "cmbFilter";
            this.cmbFilter.Size = new System.Drawing.Size(121, 24);
            this.cmbFilter.TabIndex = 98;
            // 
            // btnFilter
            // 
            this.btnFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFilter.Location = new System.Drawing.Point(467, 42);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(75, 28);
            this.btnFilter.TabIndex = 97;
            this.btnFilter.Text = "Filter";
            this.btnFilter.UseVisualStyleBackColor = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tpExistItems);
            this.tabControl1.Controls.Add(this.tpNewItems);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(3, 18);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(458, 497);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.Selected += new System.Windows.Forms.TabControlEventHandler(this.tabControl1_Selected);
            // 
            // tpExistItems
            // 
            this.tpExistItems.Controls.Add(this.dgvExistItems);
            this.tpExistItems.Location = new System.Drawing.Point(4, 24);
            this.tpExistItems.Name = "tpExistItems";
            this.tpExistItems.Padding = new System.Windows.Forms.Padding(3);
            this.tpExistItems.Size = new System.Drawing.Size(450, 469);
            this.tpExistItems.TabIndex = 0;
            this.tpExistItems.Text = "Existing items";
            this.tpExistItems.UseVisualStyleBackColor = true;
            // 
            // dgvExistItems
            // 
            this.dgvExistItems.AllowUserToAddRows = false;
            this.dgvExistItems.AllowUserToDeleteRows = false;
            this.dgvExistItems.AllowUserToResizeColumns = false;
            this.dgvExistItems.AllowUserToResizeRows = false;
            this.dgvExistItems.BackgroundColor = System.Drawing.Color.White;
            this.dgvExistItems.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvExistItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvExistItems.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvExistItems.Location = new System.Drawing.Point(3, 3);
            this.dgvExistItems.MultiSelect = false;
            this.dgvExistItems.Name = "dgvExistItems";
            this.dgvExistItems.ReadOnly = true;
            this.dgvExistItems.RowHeadersVisible = false;
            this.dgvExistItems.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvExistItems.Size = new System.Drawing.Size(444, 463);
            this.dgvExistItems.TabIndex = 5;
            // 
            // tpNewItems
            // 
            this.tpNewItems.Controls.Add(this.dgvNewItems);
            this.tpNewItems.Location = new System.Drawing.Point(4, 24);
            this.tpNewItems.Name = "tpNewItems";
            this.tpNewItems.Padding = new System.Windows.Forms.Padding(3);
            this.tpNewItems.Size = new System.Drawing.Size(450, 469);
            this.tpNewItems.TabIndex = 1;
            this.tpNewItems.Text = "New items";
            this.tpNewItems.UseVisualStyleBackColor = true;
            this.tpNewItems.Enter += new System.EventHandler(this.tpNewItems_Enter);
            // 
            // dgvNewItems
            // 
            this.dgvNewItems.AllowUserToAddRows = false;
            this.dgvNewItems.AllowUserToDeleteRows = false;
            this.dgvNewItems.AllowUserToResizeColumns = false;
            this.dgvNewItems.AllowUserToResizeRows = false;
            this.dgvNewItems.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvNewItems.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgvNewItems.BackgroundColor = System.Drawing.Color.White;
            this.dgvNewItems.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvNewItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNewItems.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvNewItems.Location = new System.Drawing.Point(3, 3);
            this.dgvNewItems.Name = "dgvNewItems";
            this.dgvNewItems.RowHeadersVisible = false;
            this.dgvNewItems.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvNewItems.Size = new System.Drawing.Size(444, 463);
            this.dgvNewItems.TabIndex = 6;
            this.dgvNewItems.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.dgvNewItems_CellBeginEdit);
            this.dgvNewItems.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvNewItems_CellClick);
            this.dgvNewItems.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvNewItems_CellContentClick);
            this.dgvNewItems.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvNewItems_CellEndEdit);
            this.dgvNewItems.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvNewItems_CellMouseClick);
            this.dgvNewItems.CellValidated += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvNewItems_CellValidated);
            this.dgvNewItems.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.dgvNewItems_CellValidating);
            this.dgvNewItems.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvNewItems_CellValueChanged);
            this.dgvNewItems.CellValuePushed += new System.Windows.Forms.DataGridViewCellValueEventHandler(this.dgvNewItems_CellValuePushed);
            this.dgvNewItems.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgvNewItems_DataBindingComplete);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnSelect);
            this.groupBox2.Controls.Add(this.btnDelete);
            this.groupBox2.Controls.Add(this.dgvSelectedItems);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(677, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(577, 518);
            this.groupBox2.TabIndex = 96;
            this.groupBox2.TabStop = false;
            // 
            // btnSelect
            // 
            this.btnSelect.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelect.Location = new System.Drawing.Point(486, 16);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(75, 28);
            this.btnSelect.TabIndex = 101;
            this.btnSelect.Text = "Select";
            this.btnSelect.UseVisualStyleBackColor = true;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(486, 50);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 28);
            this.btnDelete.TabIndex = 100;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // dgvSelectedItems
            // 
            this.dgvSelectedItems.AllowUserToAddRows = false;
            this.dgvSelectedItems.AllowUserToDeleteRows = false;
            this.dgvSelectedItems.AllowUserToResizeColumns = false;
            this.dgvSelectedItems.AllowUserToResizeRows = false;
            this.dgvSelectedItems.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgvSelectedItems.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgvSelectedItems.BackgroundColor = System.Drawing.Color.White;
            this.dgvSelectedItems.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvSelectedItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSelectedItems.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SKU,
            this.barcode,
            this.itemDesc,
            this.qty});
            this.dgvSelectedItems.Dock = System.Windows.Forms.DockStyle.Left;
            this.dgvSelectedItems.Location = new System.Drawing.Point(3, 17);
            this.dgvSelectedItems.MultiSelect = false;
            this.dgvSelectedItems.Name = "dgvSelectedItems";
            this.dgvSelectedItems.RowHeadersVisible = false;
            this.dgvSelectedItems.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvSelectedItems.Size = new System.Drawing.Size(477, 498);
            this.dgvSelectedItems.TabIndex = 5;
            // 
            // SKU
            // 
            this.SKU.HeaderText = "SKU";
            this.SKU.Name = "SKU";
            this.SKU.ReadOnly = true;
            this.SKU.Width = 57;
            // 
            // barcode
            // 
            this.barcode.HeaderText = "Barcode";
            this.barcode.Name = "barcode";
            this.barcode.ReadOnly = true;
            this.barcode.Width = 78;
            // 
            // itemDesc
            // 
            this.itemDesc.HeaderText = "Item description";
            this.itemDesc.Name = "itemDesc";
            this.itemDesc.ReadOnly = true;
            this.itemDesc.Width = 109;
            // 
            // qty
            // 
            this.qty.HeaderText = "Quantity";
            this.qty.Name = "qty";
            this.qty.ReadOnly = true;
            this.qty.Width = 76;
            // 
            // btnCreate
            // 
            this.btnCreate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCreate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(132)))), ((int)(((byte)(227)))));
            this.btnCreate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCreate.FlatAppearance.BorderColor = System.Drawing.Color.SlateGray;
            this.btnCreate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreate.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreate.ForeColor = System.Drawing.Color.White;
            this.btnCreate.Image = ((System.Drawing.Image)(resources.GetObject("btnCreate.Image")));
            this.btnCreate.Location = new System.Drawing.Point(1086, 539);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(83, 30);
            this.btnCreate.TabIndex = 97;
            this.btnCreate.Text = "  Create";
            this.btnCreate.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCreate.UseVisualStyleBackColor = false;
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(132)))), ((int)(((byte)(227)))));
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.FlatAppearance.BorderColor = System.Drawing.Color.SlateGray;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.Location = new System.Drawing.Point(1175, 539);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(79, 30);
            this.btnClose.TabIndex = 98;
            this.btnClose.Text = " Cancel";
            this.btnClose.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnClose.UseVisualStyleBackColor = false;
            // 
            // btnCopy
            // 
            this.btnCopy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(132)))), ((int)(((byte)(227)))));
            this.btnCopy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCopy.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCopy.ForeColor = System.Drawing.Color.White;
            this.btnCopy.Image = ((System.Drawing.Image)(resources.GetObject("btnCopy.Image")));
            this.btnCopy.Location = new System.Drawing.Point(614, 270);
            this.btnCopy.Name = "btnCopy";
            this.btnCopy.Size = new System.Drawing.Size(57, 28);
            this.btnCopy.TabIndex = 101;
            this.btnCopy.UseVisualStyleBackColor = false;
            this.btnCopy.Click += new System.EventHandler(this.btnCopy_Click);
            // 
            // frmAddLines
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1268, 581);
            this.Controls.Add(this.btnCopy);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmAddLines";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Product sorting form";
            this.Load += new System.EventHandler(this.frmAddLines_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tpExistItems.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvExistItems)).EndInit();
            this.tpNewItems.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNewItems)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSelectedItems)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtFilter;
        private System.Windows.Forms.ComboBox cmbFilter;
        private System.Windows.Forms.Button btnFilter;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tpExistItems;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvSelectedItems;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.DataGridView dgvExistItems;
        private System.Windows.Forms.TabPage tpNewItems;
        private System.Windows.Forms.DataGridView dgvNewItems;
        private System.Windows.Forms.Button btnCopy;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.DataGridViewTextBoxColumn SKU;
        private System.Windows.Forms.DataGridViewTextBoxColumn barcode;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemDesc;
        private System.Windows.Forms.DataGridViewTextBoxColumn qty;
        private System.Windows.Forms.Button btnSelect;
    }
}