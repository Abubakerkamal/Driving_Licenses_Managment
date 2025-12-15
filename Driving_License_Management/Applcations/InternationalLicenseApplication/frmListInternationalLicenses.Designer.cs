namespace Driving_License_Management.Applcations.InternationalLicenseApplication
{
    partial class frmListInternationalLicenses
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
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblInternationalLicensesRecords = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbIsReleased = new System.Windows.Forms.ComboBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnAddNew = new System.Windows.Forms.Button();
            this.txbFilter = new System.Windows.Forms.TextBox();
            this.cmbFilterBy = new System.Windows.Forms.ComboBox();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.cmsApplications = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.PesonDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showPersonLicenseHistoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.cmsApplications.SuspendLayout();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(361, 161);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(550, 59);
            this.label3.TabIndex = 104;
            this.label3.Text = "International Licenses";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBox2.Location = new System.Drawing.Point(699, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(72, 45);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 106;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBox1.Location = new System.Drawing.Point(512, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(238, 155);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 103;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.lblInternationalLicensesRecords);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.cmbIsReleased);
            this.panel1.Controls.Add(this.btnClose);
            this.panel1.Controls.Add(this.btnAddNew);
            this.panel1.Controls.Add(this.txbFilter);
            this.panel1.Controls.Add(this.cmbFilterBy);
            this.panel1.Controls.Add(this.dgv);
            this.panel1.Location = new System.Drawing.Point(2, 239);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1277, 452);
            this.panel1.TabIndex = 167;
            // 
            // lblInternationalLicensesRecords
            // 
            this.lblInternationalLicensesRecords.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblInternationalLicensesRecords.AutoSize = true;
            this.lblInternationalLicensesRecords.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInternationalLicensesRecords.Location = new System.Drawing.Point(188, 458);
            this.lblInternationalLicensesRecords.Name = "lblInternationalLicensesRecords";
            this.lblInternationalLicensesRecords.Size = new System.Drawing.Size(34, 25);
            this.lblInternationalLicensesRecords.TabIndex = 174;
            this.lblInternationalLicensesRecords.Text = "??";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(43, 455);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(139, 29);
            this.label5.TabIndex = 173;
            this.label5.Text = "# Records:";
            // 
            // cmbIsReleased
            // 
            this.cmbIsReleased.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cmbIsReleased.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbIsReleased.FormattingEnabled = true;
            this.cmbIsReleased.Items.AddRange(new object[] {
            "All",
            "Yes",
            "No"});
            this.cmbIsReleased.Location = new System.Drawing.Point(270, 24);
            this.cmbIsReleased.Name = "cmbIsReleased";
            this.cmbIsReleased.Size = new System.Drawing.Size(121, 28);
            this.cmbIsReleased.TabIndex = 172;
            this.cmbIsReleased.Visible = false;
            // 
            // btnClose
            // 
            this.btnClose.AllowDrop = true;
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.AutoEllipsis = true;
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnClose.Location = new System.Drawing.Point(1121, 453);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(148, 39);
            this.btnClose.TabIndex = 171;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // btnAddNew
            // 
            this.btnAddNew.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnAddNew.AutoSize = true;
            this.btnAddNew.Location = new System.Drawing.Point(1157, 0);
            this.btnAddNew.Name = "btnAddNew";
            this.btnAddNew.Size = new System.Drawing.Size(112, 64);
            this.btnAddNew.TabIndex = 170;
            this.btnAddNew.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAddNew.UseVisualStyleBackColor = true;
            this.btnAddNew.Click += new System.EventHandler(this.btnAddNew_Click);
            // 
            // txbFilter
            // 
            this.txbFilter.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txbFilter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbFilter.Location = new System.Drawing.Point(270, 26);
            this.txbFilter.Name = "txbFilter";
            this.txbFilter.Size = new System.Drawing.Size(376, 26);
            this.txbFilter.TabIndex = 169;
            // 
            // cmbFilterBy
            // 
            this.cmbFilterBy.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.cmbFilterBy.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cmbFilterBy.CausesValidation = false;
            this.cmbFilterBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFilterBy.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cmbFilterBy.IntegralHeight = false;
            this.cmbFilterBy.Items.AddRange(new object[] {
            "None",
            "International License ID",
            "Application ID",
            "Driver ID",
            "Local License ID",
            "Is Active"});
            this.cmbFilterBy.Location = new System.Drawing.Point(25, 26);
            this.cmbFilterBy.Name = "cmbFilterBy";
            this.cmbFilterBy.Size = new System.Drawing.Size(206, 28);
            this.cmbFilterBy.TabIndex = 168;
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
            this.dgv.ContextMenuStrip = this.cmsApplications;
            this.dgv.GridColor = System.Drawing.SystemColors.MenuText;
            this.dgv.Location = new System.Drawing.Point(7, 70);
            this.dgv.Name = "dgv";
            this.dgv.ReadOnly = true;
            this.dgv.RowHeadersWidth = 62;
            this.dgv.RowTemplate.Height = 28;
            this.dgv.Size = new System.Drawing.Size(1262, 377);
            this.dgv.TabIndex = 167;
            // 
            // cmsApplications
            // 
            this.cmsApplications.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.cmsApplications.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.PesonDetailsToolStripMenuItem,
            this.showDetailsToolStripMenuItem,
            this.showPersonLicenseHistoryToolStripMenuItem});
            this.cmsApplications.Name = "contextMenuStrip1";
            this.cmsApplications.Size = new System.Drawing.Size(310, 100);
            // 
            // PesonDetailsToolStripMenuItem
            // 
            this.PesonDetailsToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.PesonDetailsToolStripMenuItem.Name = "PesonDetailsToolStripMenuItem";
            this.PesonDetailsToolStripMenuItem.Size = new System.Drawing.Size(309, 32);
            this.PesonDetailsToolStripMenuItem.Text = "Show Person Details";
            this.PesonDetailsToolStripMenuItem.Click += new System.EventHandler(this.PesonDetailsToolStripMenuItem_Click);
            // 
            // showDetailsToolStripMenuItem
            // 
            this.showDetailsToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.showDetailsToolStripMenuItem.Name = "showDetailsToolStripMenuItem";
            this.showDetailsToolStripMenuItem.Size = new System.Drawing.Size(309, 32);
            this.showDetailsToolStripMenuItem.Text = "&Show License Details";
            this.showDetailsToolStripMenuItem.Click += new System.EventHandler(this.showDetailsToolStripMenuItem_Click);
            // 
            // showPersonLicenseHistoryToolStripMenuItem
            // 
            this.showPersonLicenseHistoryToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.showPersonLicenseHistoryToolStripMenuItem.Name = "showPersonLicenseHistoryToolStripMenuItem";
            this.showPersonLicenseHistoryToolStripMenuItem.Size = new System.Drawing.Size(309, 32);
            this.showPersonLicenseHistoryToolStripMenuItem.Text = "Show Person License History";
            this.showPersonLicenseHistoryToolStripMenuItem.Click += new System.EventHandler(this.showPersonLicenseHistoryToolStripMenuItem_Click);
            // 
            // frmListInternationalLicenses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1285, 692);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox1);
            this.Name = "frmListInternationalLicenses";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "International Licenses";
            this.Load += new System.EventHandler(this.frmListInternationalLicenses_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.cmsApplications.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblInternationalLicensesRecords;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbIsReleased;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnAddNew;
        private System.Windows.Forms.TextBox txbFilter;
        internal System.Windows.Forms.ComboBox cmbFilterBy;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.ContextMenuStrip cmsApplications;
        private System.Windows.Forms.ToolStripMenuItem PesonDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showPersonLicenseHistoryToolStripMenuItem;
    }
}