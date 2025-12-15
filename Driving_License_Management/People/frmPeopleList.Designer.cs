namespace Driving_License_Management
{
    partial class frmPeopleList
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPeopleList));
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.showDetailsToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewUserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sendEmailToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.callPhoneToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.label2 = new System.Windows.Forms.Label();
            this.lbRecords = new System.Windows.Forms.Label();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.cmpFilterBy = new System.Windows.Forms.ComboBox();
            this.txbFilter = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.MP_btnAddNew = new System.Windows.Forms.Button();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showDetailsToolStripMenuItem1,
            this.addNewUserToolStripMenuItem,
            this.editToolStripMenuItem,
            this.deleteToolStripMenuItem,
            this.sendEmailToolStripMenuItem1,
            this.callPhoneToolStripMenuItem1});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(207, 196);
            // 
            // showDetailsToolStripMenuItem1
            // 
            this.showDetailsToolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("showDetailsToolStripMenuItem1.Image")));
            this.showDetailsToolStripMenuItem1.Name = "showDetailsToolStripMenuItem1";
            this.showDetailsToolStripMenuItem1.Size = new System.Drawing.Size(206, 32);
            this.showDetailsToolStripMenuItem1.Text = "Show Details";
            this.showDetailsToolStripMenuItem1.Click += new System.EventHandler(this.showDetailsToolStripMenuItem1_Click);
            // 
            // addNewUserToolStripMenuItem
            // 
            this.addNewUserToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("addNewUserToolStripMenuItem.Image")));
            this.addNewUserToolStripMenuItem.Name = "addNewUserToolStripMenuItem";
            this.addNewUserToolStripMenuItem.Size = new System.Drawing.Size(206, 32);
            this.addNewUserToolStripMenuItem.Text = "Add New User";
            this.addNewUserToolStripMenuItem.Click += new System.EventHandler(this.addNewPersonToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("editToolStripMenuItem.Image")));
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(206, 32);
            this.editToolStripMenuItem.Text = "Edit";
            this.editToolStripMenuItem.Click += new System.EventHandler(this.editToolStripMenuItem_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("deleteToolStripMenuItem.Image")));
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(206, 32);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // sendEmailToolStripMenuItem1
            // 
            this.sendEmailToolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("sendEmailToolStripMenuItem1.Image")));
            this.sendEmailToolStripMenuItem1.Name = "sendEmailToolStripMenuItem1";
            this.sendEmailToolStripMenuItem1.Size = new System.Drawing.Size(206, 32);
            this.sendEmailToolStripMenuItem1.Text = "Send Email";
            // 
            // callPhoneToolStripMenuItem1
            // 
            this.callPhoneToolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("callPhoneToolStripMenuItem1.Image")));
            this.callPhoneToolStripMenuItem1.Name = "callPhoneToolStripMenuItem1";
            this.callPhoneToolStripMenuItem1.Size = new System.Drawing.Size(206, 32);
            this.callPhoneToolStripMenuItem1.Text = "Call Phone";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(4, 663);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "#Records";
            this.label2.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // lbRecords
            // 
            this.lbRecords.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbRecords.AutoSize = true;
            this.lbRecords.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRecords.Location = new System.Drawing.Point(98, 663);
            this.lbRecords.Name = "lbRecords";
            this.lbRecords.Size = new System.Drawing.Size(19, 20);
            this.lbRecords.TabIndex = 7;
            this.lbRecords.Text = "0";
            this.lbRecords.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // dgv
            // 
            this.dgv.AllowUserToAddRows = false;
            this.dgv.AllowUserToDeleteRows = false;
            this.dgv.AllowUserToOrderColumns = true;
            this.dgv.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.ContextMenuStrip = this.contextMenuStrip1;
            this.dgv.GridColor = System.Drawing.SystemColors.MenuText;
            this.dgv.Location = new System.Drawing.Point(-13, 303);
            this.dgv.Name = "dgv";
            this.dgv.ReadOnly = true;
            this.dgv.RowHeadersWidth = 62;
            this.dgv.RowTemplate.Height = 28;
            this.dgv.Size = new System.Drawing.Size(1137, 340);
            this.dgv.TabIndex = 1;
            this.dgv.DoubleClick += new System.EventHandler(this.dgv_DoubleClick);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Crimson;
            this.label3.Location = new System.Drawing.Point(414, 186);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(312, 46);
            this.label3.TabIndex = 9;
            this.label3.Text = "Manage People";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cmpFilterBy
            // 
            this.cmpFilterBy.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.cmpFilterBy.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cmpFilterBy.CausesValidation = false;
            this.cmpFilterBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmpFilterBy.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cmpFilterBy.IntegralHeight = false;
            this.cmpFilterBy.Items.AddRange(new object[] {
            "None",
            "Person ID",
            "National No",
            "First Name",
            "Second Name",
            "Third Name",
            "Last Name",
            "Nationalty",
            "Gendor",
            "Phone",
            "Email"});
            this.cmpFilterBy.Location = new System.Drawing.Point(89, 258);
            this.cmpFilterBy.Name = "cmpFilterBy";
            this.cmpFilterBy.Size = new System.Drawing.Size(206, 28);
            this.cmpFilterBy.TabIndex = 2;
            this.cmpFilterBy.SelectedIndexChanged += new System.EventHandler(this.cmpFilterBy_SelectedIndexChanged);
            // 
            // txbFilter
            // 
            this.txbFilter.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txbFilter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbFilter.Location = new System.Drawing.Point(325, 258);
            this.txbFilter.Name = "txbFilter";
            this.txbFilter.Size = new System.Drawing.Size(376, 26);
            this.txbFilter.TabIndex = 3;
            this.txbFilter.TextChanged += new System.EventHandler(this.txbFilter_TextChanged);
            this.txbFilter.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbFilter_KeyPress);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(4, 264);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Filter By";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnClose
            // 
            this.btnClose.AllowDrop = true;
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.AutoEllipsis = true;
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnClose.Location = new System.Drawing.Point(966, 649);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(146, 43);
            this.btnClose.TabIndex = 87;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(346, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(458, 155);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // MP_btnAddNew
            // 
            this.MP_btnAddNew.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.MP_btnAddNew.AutoSize = true;
            this.MP_btnAddNew.Image = ((System.Drawing.Image)(resources.GetObject("MP_btnAddNew.Image")));
            this.MP_btnAddNew.Location = new System.Drawing.Point(1029, 223);
            this.MP_btnAddNew.Name = "MP_btnAddNew";
            this.MP_btnAddNew.Size = new System.Drawing.Size(83, 63);
            this.MP_btnAddNew.TabIndex = 5;
            this.MP_btnAddNew.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.MP_btnAddNew.UseVisualStyleBackColor = true;
            this.MP_btnAddNew.Click += new System.EventHandler(this.btnAddNew_Click);
            // 
            // frmPeopleList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1124, 724);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lbRecords);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.MP_btnAddNew);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txbFilter);
            this.Controls.Add(this.cmpFilterBy);
            this.Controls.Add(this.dgv);
            this.Name = "frmPeopleList";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manage People";
            this.Load += new System.EventHandler(this.frmPeopleList_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbRecords;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem showDetailsToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem addNewUserToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sendEmailToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem callPhoneToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.Button MP_btnAddNew;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        internal System.Windows.Forms.ComboBox cmpFilterBy;
        private System.Windows.Forms.TextBox txbFilter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnClose;
    }
}