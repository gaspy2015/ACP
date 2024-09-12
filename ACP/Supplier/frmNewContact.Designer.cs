namespace ACP
{
    partial class frmNewContact
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNewContact));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblNew = new System.Windows.Forms.Label();
            this.btnCreate = new System.Windows.Forms.Button();
            this.txtDesc = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbPrimary = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbCtype = new System.Windows.Forms.ComboBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabContact = new System.Windows.Forms.TabPage();
            this.dgvCon = new System.Windows.Forms.DataGridView();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnConDelete = new System.Windows.Forms.Button();
            this.btnConEdit = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabContact.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCon)).BeginInit();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblNew);
            this.groupBox1.Controls.Add(this.txtDesc);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cbPrimary);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.cmbCtype);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(374, 193);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Contact information";
            // 
            // lblNew
            // 
            this.lblNew.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblNew.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNew.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblNew.Image = ((System.Drawing.Image)(resources.GetObject("lblNew.Image")));
            this.lblNew.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblNew.Location = new System.Drawing.Point(316, 25);
            this.lblNew.Name = "lblNew";
            this.lblNew.Size = new System.Drawing.Size(54, 23);
            this.lblNew.TabIndex = 73;
            this.lblNew.Text = "New";
            this.lblNew.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblNew.Click += new System.EventHandler(this.lblNew_Click);
            // 
            // btnCreate
            // 
            this.btnCreate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(132)))), ((int)(((byte)(227)))));
            this.btnCreate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCreate.FlatAppearance.BorderSize = 0;
            this.btnCreate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreate.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreate.ForeColor = System.Drawing.Color.White;
            this.btnCreate.Location = new System.Drawing.Point(392, 22);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(75, 34);
            this.btnCreate.TabIndex = 72;
            this.btnCreate.Text = "Create";
            this.btnCreate.UseVisualStyleBackColor = false;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // txtDesc
            // 
            this.txtDesc.BackColor = System.Drawing.Color.White;
            this.txtDesc.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDesc.Location = new System.Drawing.Point(104, 67);
            this.txtDesc.Name = "txtDesc";
            this.txtDesc.Size = new System.Drawing.Size(264, 25);
            this.txtDesc.TabIndex = 71;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(9, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 17);
            this.label2.TabIndex = 70;
            this.label2.Text = "Description:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 17);
            this.label1.TabIndex = 69;
            this.label1.Text = "Contact type:";
            // 
            // cbPrimary
            // 
            this.cbPrimary.AutoSize = true;
            this.cbPrimary.Location = new System.Drawing.Point(104, 109);
            this.cbPrimary.Name = "cbPrimary";
            this.cbPrimary.Size = new System.Drawing.Size(15, 14);
            this.cbPrimary.TabIndex = 68;
            this.cbPrimary.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(9, 107);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 17);
            this.label5.TabIndex = 67;
            this.label5.Text = "Primay:";
            // 
            // cmbCtype
            // 
            this.cmbCtype.FormattingEnabled = true;
            this.cmbCtype.Location = new System.Drawing.Point(104, 24);
            this.cmbCtype.Name = "cmbCtype";
            this.cmbCtype.Size = new System.Drawing.Size(207, 25);
            this.cmbCtype.TabIndex = 0;
            this.cmbCtype.SelectedIndexChanged += new System.EventHandler(this.cmbCtype_SelectedIndexChanged);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabContact);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tabControl1.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.tabControl1.Location = new System.Drawing.Point(0, 211);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(723, 328);
            this.tabControl1.TabIndex = 23;
            // 
            // tabContact
            // 
            this.tabContact.Controls.Add(this.dgvCon);
            this.tabContact.Controls.Add(this.panel5);
            this.tabContact.Controls.Add(this.panel4);
            this.tabContact.ImageIndex = 1;
            this.tabContact.Location = new System.Drawing.Point(4, 22);
            this.tabContact.Name = "tabContact";
            this.tabContact.Padding = new System.Windows.Forms.Padding(3);
            this.tabContact.Size = new System.Drawing.Size(715, 302);
            this.tabContact.TabIndex = 1;
            this.tabContact.Text = "Contact Information";
            this.tabContact.UseVisualStyleBackColor = true;
            // 
            // dgvCon
            // 
            this.dgvCon.AllowUserToAddRows = false;
            this.dgvCon.AllowUserToDeleteRows = false;
            this.dgvCon.AllowUserToResizeColumns = false;
            this.dgvCon.AllowUserToResizeRows = false;
            this.dgvCon.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCon.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgvCon.BackgroundColor = System.Drawing.Color.White;
            this.dgvCon.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCon.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.dgvCon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCon.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCon.DefaultCellStyle = dataGridViewCellStyle11;
            this.dgvCon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCon.EnableHeadersVisualStyles = false;
            this.dgvCon.Location = new System.Drawing.Point(3, 47);
            this.dgvCon.MultiSelect = false;
            this.dgvCon.Name = "dgvCon";
            this.dgvCon.ReadOnly = true;
            this.dgvCon.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCon.RowHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.dgvCon.RowHeadersVisible = false;
            this.dgvCon.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCon.Size = new System.Drawing.Size(709, 252);
            this.dgvCon.TabIndex = 23;
            this.dgvCon.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCon_CellClick);
            this.dgvCon.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCon_CellDoubleClick);
            this.dgvCon.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgvCon_DataBindingComplete);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(115)))), ((int)(((byte)(115)))));
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(3, 44);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(709, 3);
            this.panel5.TabIndex = 22;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btnConEdit);
            this.panel4.Controls.Add(this.btnConDelete);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(3, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(709, 41);
            this.panel4.TabIndex = 1;
            // 
            // btnConDelete
            // 
            this.btnConDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConDelete.Enabled = false;
            this.btnConDelete.FlatAppearance.BorderSize = 0;
            this.btnConDelete.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightGray;
            this.btnConDelete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.btnConDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConDelete.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConDelete.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnConDelete.Image = ((System.Drawing.Image)(resources.GetObject("btnConDelete.Image")));
            this.btnConDelete.Location = new System.Drawing.Point(98, 2);
            this.btnConDelete.Name = "btnConDelete";
            this.btnConDelete.Size = new System.Drawing.Size(87, 35);
            this.btnConDelete.TabIndex = 32;
            this.btnConDelete.Text = "Delete";
            this.btnConDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnConDelete.UseVisualStyleBackColor = true;
            this.btnConDelete.Click += new System.EventHandler(this.btnConDelete_Click);
            // 
            // btnConEdit
            // 
            this.btnConEdit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConEdit.Enabled = false;
            this.btnConEdit.FlatAppearance.BorderSize = 0;
            this.btnConEdit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightGray;
            this.btnConEdit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.btnConEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConEdit.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConEdit.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnConEdit.Image = ((System.Drawing.Image)(resources.GetObject("btnConEdit.Image")));
            this.btnConEdit.Location = new System.Drawing.Point(5, 2);
            this.btnConEdit.Name = "btnConEdit";
            this.btnConEdit.Size = new System.Drawing.Size(87, 35);
            this.btnConEdit.TabIndex = 35;
            this.btnConEdit.Text = "Edit";
            this.btnConEdit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnConEdit.UseVisualStyleBackColor = true;
            this.btnConEdit.Click += new System.EventHandler(this.btnConEdit_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(132)))), ((int)(((byte)(227)))));
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(392, 62);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 34);
            this.btnClose.TabIndex = 73;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // frmNewContact
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(723, 539);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmNewContact";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmNewContact_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabContact.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCon)).EndInit();
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.CheckBox cbPrimary;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox txtDesc;
        public System.Windows.Forms.Button btnCreate;
        public System.Windows.Forms.ComboBox cmbCtype;
        private System.Windows.Forms.Label lblNew;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabContact;
        private System.Windows.Forms.DataGridView dgvCon;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnConEdit;
        private System.Windows.Forms.Button btnConDelete;
        public System.Windows.Forms.Button btnClose;
    }
}