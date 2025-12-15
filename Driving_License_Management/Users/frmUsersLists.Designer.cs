namespace Driving_License_Management.Users
{
    partial class frmUsersLists
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUsersLists));
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txbFilter = new System.Windows.Forms.TextBox();
            this.cmpFilterBy = new System.Windows.Forms.ComboBox();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.showDetailsToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewPersonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changePasswordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.sendEmailToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.callPhoneToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.cmpIsActive = new System.Windows.Forms.ComboBox();
            this.lbRecords = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnAddNew = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(322, 184);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(290, 46);
            this.label3.TabIndex = 94;
            this.label3.Text = "Manage Users";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(40, 255);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 20);
            this.label1.TabIndex = 91;
            this.label1.Text = "Filter By";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txbFilter
            // 
            this.txbFilter.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txbFilter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbFilter.Location = new System.Drawing.Point(361, 255);
            this.txbFilter.Name = "txbFilter";
            this.txbFilter.Size = new System.Drawing.Size(376, 26);
            this.txbFilter.TabIndex = 90;
            this.txbFilter.TextChanged += new System.EventHandler(this.txbFilter_TextChanged);
            this.txbFilter.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbFilter_KeyPress);
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
            "User ID",
            "Person ID",
            "Full Name",
            "User Name",
            "Is Active"});
            this.cmpFilterBy.Location = new System.Drawing.Point(130, 253);
            this.cmpFilterBy.Name = "cmpFilterBy";
            this.cmpFilterBy.Size = new System.Drawing.Size(206, 28);
            this.cmpFilterBy.TabIndex = 89;
            this.cmpFilterBy.SelectedIndexChanged += new System.EventHandler(this.cmpFilterBy_SelectedIndexChanged);
            // 
            // dgv
            // 
            this.dgv.AllowUserToAddRows = false;
            this.dgv.AllowUserToDeleteRows = false;
            this.dgv.AllowUserToOrderColumns = true;
            this.dgv.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgv.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.ContextMenuStrip = this.contextMenuStrip1;
            this.dgv.GridColor = System.Drawing.SystemColors.MenuText;
            this.dgv.Location = new System.Drawing.Point(38, 305);
            this.dgv.Name = "dgv";
            this.dgv.ReadOnly = true;
            this.dgv.RowHeadersWidth = 62;
            this.dgv.RowTemplate.Height = 28;
            this.dgv.Size = new System.Drawing.Size(867, 340);
            this.dgv.TabIndex = 88;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showDetailsToolStripMenuItem1,
            this.addNewPersonToolStripMenuItem,
            this.editToolStripMenuItem,
            this.deleteToolStripMenuItem,
            this.changePasswordToolStripMenuItem,
            this.toolStripSeparator1,
            this.sendEmailToolStripMenuItem1,
            this.callPhoneToolStripMenuItem1});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(225, 234);
            // 
            // showDetailsToolStripMenuItem1
            // 
            this.showDetailsToolStripMenuItem1.Name = "showDetailsToolStripMenuItem1";
            this.showDetailsToolStripMenuItem1.Size = new System.Drawing.Size(224, 32);
            this.showDetailsToolStripMenuItem1.Text = "Show Details";
            this.showDetailsToolStripMenuItem1.Click += new System.EventHandler(this.showDetailsToolStripMenuItem1_Click);
            // 
            // addNewPersonToolStripMenuItem
            // 
            this.addNewPersonToolStripMenuItem.Name = "addNewPersonToolStripMenuItem";
            this.addNewPersonToolStripMenuItem.Size = new System.Drawing.Size(224, 32);
            this.addNewPersonToolStripMenuItem.Text = "Add New Person";
            this.addNewPersonToolStripMenuItem.Click += new System.EventHandler(this.addNewUserToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(224, 32);
            this.editToolStripMenuItem.Text = "Edit";
            this.editToolStripMenuItem.Click += new System.EventHandler(this.editToolStripMenuItem_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(224, 32);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // changePasswordToolStripMenuItem
            // 
            this.changePasswordToolStripMenuItem.Name = "changePasswordToolStripMenuItem";
            this.changePasswordToolStripMenuItem.Size = new System.Drawing.Size(224, 32);
            this.changePasswordToolStripMenuItem.Text = "Change Password";
            this.changePasswordToolStripMenuItem.Click += new System.EventHandler(this.changePasswordToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(221, 6);
            // 
            // sendEmailToolStripMenuItem1
            // 
            this.sendEmailToolStripMenuItem1.Name = "sendEmailToolStripMenuItem1";
            this.sendEmailToolStripMenuItem1.Size = new System.Drawing.Size(224, 32);
            this.sendEmailToolStripMenuItem1.Text = "Send Email";
            // 
            // callPhoneToolStripMenuItem1
            // 
            this.callPhoneToolStripMenuItem1.Name = "callPhoneToolStripMenuItem1";
            this.callPhoneToolStripMenuItem1.Size = new System.Drawing.Size(224, 32);
            this.callPhoneToolStripMenuItem1.Text = "Call Phone";
            // 
            // cmpIsActive
            // 
            this.cmpIsActive.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.cmpIsActive.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cmpIsActive.CausesValidation = false;
            this.cmpIsActive.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmpIsActive.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cmpIsActive.IntegralHeight = false;
            this.cmpIsActive.Items.AddRange(new object[] {
            "All",
            "Yes",
            "No"});
            this.cmpIsActive.Location = new System.Drawing.Point(361, 252);
            this.cmpIsActive.Name = "cmpIsActive";
            this.cmpIsActive.Size = new System.Drawing.Size(150, 28);
            this.cmpIsActive.TabIndex = 96;
            this.cmpIsActive.Visible = false;
            this.cmpIsActive.SelectedIndexChanged += new System.EventHandler(this.cmpIsActive_SelectedIndexChanged);
            // 
            // lbRecords
            // 
            this.lbRecords.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbRecords.AutoSize = true;
            this.lbRecords.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRecords.Location = new System.Drawing.Point(128, 663);
            this.lbRecords.Name = "lbRecords";
            this.lbRecords.Size = new System.Drawing.Size(19, 20);
            this.lbRecords.TabIndex = 98;
            this.lbRecords.Text = "0";
            this.lbRecords.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(34, 663);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 20);
            this.label2.TabIndex = 97;
            this.label2.Text = "#Records";
            this.label2.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // btnClose
            // 
            this.btnClose.AllowDrop = true;
            this.btnClose.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnClose.AutoEllipsis = true;
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnClose.Location = new System.Drawing.Point(752, 651);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(153, 45);
            this.btnClose.TabIndex = 95;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(253, 26);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(427, 155);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 93;
            this.pictureBox1.TabStop = false;
            // 
            // btnAddNew
            // 
            this.btnAddNew.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnAddNew.AutoSize = true;
            this.btnAddNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddNew.Image = ((System.Drawing.Image)(resources.GetObject("btnAddNew.Image")));
            this.btnAddNew.Location = new System.Drawing.Point(849, 231);
            this.btnAddNew.Name = "btnAddNew";
            this.btnAddNew.Size = new System.Drawing.Size(56, 44);
            this.btnAddNew.TabIndex = 92;
            this.btnAddNew.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAddNew.UseVisualStyleBackColor = true;
            this.btnAddNew.Click += new System.EventHandler(this.btnAddNew_Click);
            // 
            // frmUsersLists
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(943, 707);
            this.Controls.Add(this.lbRecords);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmpIsActive);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnAddNew);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txbFilter);
            this.Controls.Add(this.cmpFilterBy);
            this.Controls.Add(this.dgv);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmUsersLists";
            this.Text = "frmUsersListcs";
            this.Load += new System.EventHandler(this.frmUsersLists_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnAddNew;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbFilter;
        internal System.Windows.Forms.ComboBox cmpFilterBy;
        private System.Windows.Forms.DataGridView dgv;
        internal System.Windows.Forms.ComboBox cmpIsActive;
        private System.Windows.Forms.Label lbRecords;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem showDetailsToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem addNewPersonToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sendEmailToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem callPhoneToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem changePasswordToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
    }
}