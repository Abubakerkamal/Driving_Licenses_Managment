namespace Driving_License_Management
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.userToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.drivingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newDrivingLicenseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.localLicenseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.internationalLicenseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.renewDrivingLicenseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.replacemrntForLosOrDamegedLicenseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.retakeTestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageApplicationsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.localDrivingLicenseApplicationsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.internationalLicenseApplicationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.detainLicensesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageDetainedLicenseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.detainLicenseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.releaseDetainLicenseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageApplicationsTypsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageTestTypesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.peopleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.driversToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.accountSettingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CurrentUserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ChangePasswordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.SignOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lbPersonName = new System.Windows.Forms.Label();
            this.pBPersonPhoto = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBPersonPhoto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.AutoSize = false;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(3);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(55, 55);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.userToolStripMenuItem,
            this.peopleToolStripMenuItem,
            this.driversToolStripMenuItem,
            this.usersToolStripMenuItem,
            this.accountSettingToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menuStrip1.Size = new System.Drawing.Size(1760, 84);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // userToolStripMenuItem
            // 
            this.userToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.drivingToolStripMenuItem,
            this.manageApplicationsToolStripMenuItem,
            this.detainLicensesToolStripMenuItem,
            this.manageApplicationsTypsToolStripMenuItem,
            this.manageTestTypesToolStripMenuItem});
            this.userToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("userToolStripMenuItem.Image")));
            this.userToolStripMenuItem.Name = "userToolStripMenuItem";
            this.userToolStripMenuItem.Size = new System.Drawing.Size(197, 80);
            this.userToolStripMenuItem.Text = "Applications";
            // 
            // drivingToolStripMenuItem
            // 
            this.drivingToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newDrivingLicenseToolStripMenuItem,
            this.renewDrivingLicenseToolStripMenuItem,
            this.replacemrntForLosOrDamegedLicenseToolStripMenuItem,
            this.reaToolStripMenuItem,
            this.retakeTestToolStripMenuItem});
            this.drivingToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("drivingToolStripMenuItem.Image")));
            this.drivingToolStripMenuItem.Name = "drivingToolStripMenuItem";
            this.drivingToolStripMenuItem.Size = new System.Drawing.Size(392, 66);
            this.drivingToolStripMenuItem.Text = "Driving Licenses Services";
            // 
            // newDrivingLicenseToolStripMenuItem
            // 
            this.newDrivingLicenseToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.localLicenseToolStripMenuItem,
            this.internationalLicenseToolStripMenuItem});
            this.newDrivingLicenseToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("newDrivingLicenseToolStripMenuItem.Image")));
            this.newDrivingLicenseToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.newDrivingLicenseToolStripMenuItem.Name = "newDrivingLicenseToolStripMenuItem";
            this.newDrivingLicenseToolStripMenuItem.Size = new System.Drawing.Size(498, 42);
            this.newDrivingLicenseToolStripMenuItem.Text = "New Driving License";
            // 
            // localLicenseToolStripMenuItem
            // 
            this.localLicenseToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("localLicenseToolStripMenuItem.Image")));
            this.localLicenseToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.localLicenseToolStripMenuItem.Name = "localLicenseToolStripMenuItem";
            this.localLicenseToolStripMenuItem.Size = new System.Drawing.Size(308, 42);
            this.localLicenseToolStripMenuItem.Text = "Local License";
            this.localLicenseToolStripMenuItem.Click += new System.EventHandler(this.localLicenseToolStripMenuItem_Click);
            // 
            // internationalLicenseToolStripMenuItem
            // 
            this.internationalLicenseToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("internationalLicenseToolStripMenuItem.Image")));
            this.internationalLicenseToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.internationalLicenseToolStripMenuItem.Name = "internationalLicenseToolStripMenuItem";
            this.internationalLicenseToolStripMenuItem.Size = new System.Drawing.Size(308, 42);
            this.internationalLicenseToolStripMenuItem.Text = "International License";
            this.internationalLicenseToolStripMenuItem.Click += new System.EventHandler(this.internationalLicenseToolStripMenuItem_Click);
            // 
            // renewDrivingLicenseToolStripMenuItem
            // 
            this.renewDrivingLicenseToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("renewDrivingLicenseToolStripMenuItem.Image")));
            this.renewDrivingLicenseToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.renewDrivingLicenseToolStripMenuItem.Name = "renewDrivingLicenseToolStripMenuItem";
            this.renewDrivingLicenseToolStripMenuItem.Size = new System.Drawing.Size(498, 42);
            this.renewDrivingLicenseToolStripMenuItem.Text = "Renew Driving License";
            this.renewDrivingLicenseToolStripMenuItem.Click += new System.EventHandler(this.renewDrivingLicenseToolStripMenuItem_Click);
            // 
            // replacemrntForLosOrDamegedLicenseToolStripMenuItem
            // 
            this.replacemrntForLosOrDamegedLicenseToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("replacemrntForLosOrDamegedLicenseToolStripMenuItem.Image")));
            this.replacemrntForLosOrDamegedLicenseToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.replacemrntForLosOrDamegedLicenseToolStripMenuItem.Name = "replacemrntForLosOrDamegedLicenseToolStripMenuItem";
            this.replacemrntForLosOrDamegedLicenseToolStripMenuItem.Size = new System.Drawing.Size(498, 42);
            this.replacemrntForLosOrDamegedLicenseToolStripMenuItem.Text = "Replacemrnt For Lose or Damaged License";
            this.replacemrntForLosOrDamegedLicenseToolStripMenuItem.Click += new System.EventHandler(this.replacemrntForLosOrDamegedLicenseToolStripMenuItem_Click);
            // 
            // reaToolStripMenuItem
            // 
            this.reaToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("reaToolStripMenuItem.Image")));
            this.reaToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.reaToolStripMenuItem.Name = "reaToolStripMenuItem";
            this.reaToolStripMenuItem.Size = new System.Drawing.Size(498, 42);
            this.reaToolStripMenuItem.Text = " Release Detained Driving License";
            this.reaToolStripMenuItem.Click += new System.EventHandler(this.reaToolStripMenuItem_Click);
            // 
            // retakeTestToolStripMenuItem
            // 
            this.retakeTestToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("retakeTestToolStripMenuItem.Image")));
            this.retakeTestToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.retakeTestToolStripMenuItem.Name = "retakeTestToolStripMenuItem";
            this.retakeTestToolStripMenuItem.Size = new System.Drawing.Size(498, 42);
            this.retakeTestToolStripMenuItem.Text = "Retake Test";
            this.retakeTestToolStripMenuItem.Click += new System.EventHandler(this.retakeTestToolStripMenuItem_Click);
            // 
            // manageApplicationsToolStripMenuItem
            // 
            this.manageApplicationsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.localDrivingLicenseApplicationsToolStripMenuItem,
            this.internationalLicenseApplicationToolStripMenuItem});
            this.manageApplicationsToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("manageApplicationsToolStripMenuItem.Image")));
            this.manageApplicationsToolStripMenuItem.Name = "manageApplicationsToolStripMenuItem";
            this.manageApplicationsToolStripMenuItem.Size = new System.Drawing.Size(392, 66);
            this.manageApplicationsToolStripMenuItem.Text = "Manage Applications";
            this.manageApplicationsToolStripMenuItem.Click += new System.EventHandler(this.manageApplicationsToolStripMenuItem_Click);
            // 
            // localDrivingLicenseApplicationsToolStripMenuItem
            // 
            this.localDrivingLicenseApplicationsToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("localDrivingLicenseApplicationsToolStripMenuItem.Image")));
            this.localDrivingLicenseApplicationsToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.localDrivingLicenseApplicationsToolStripMenuItem.Name = "localDrivingLicenseApplicationsToolStripMenuItem";
            this.localDrivingLicenseApplicationsToolStripMenuItem.Size = new System.Drawing.Size(430, 42);
            this.localDrivingLicenseApplicationsToolStripMenuItem.Text = "Local Driving License Applications";
            this.localDrivingLicenseApplicationsToolStripMenuItem.Click += new System.EventHandler(this.localDrivingLicenseApplicationsToolStripMenuItem_Click);
            // 
            // internationalLicenseApplicationToolStripMenuItem
            // 
            this.internationalLicenseApplicationToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("internationalLicenseApplicationToolStripMenuItem.Image")));
            this.internationalLicenseApplicationToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.internationalLicenseApplicationToolStripMenuItem.Name = "internationalLicenseApplicationToolStripMenuItem";
            this.internationalLicenseApplicationToolStripMenuItem.Size = new System.Drawing.Size(430, 42);
            this.internationalLicenseApplicationToolStripMenuItem.Text = "International License Application";
            this.internationalLicenseApplicationToolStripMenuItem.Click += new System.EventHandler(this.internationalLicenseApplicationToolStripMenuItem_Click);
            // 
            // detainLicensesToolStripMenuItem
            // 
            this.detainLicensesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.manageDetainedLicenseToolStripMenuItem,
            this.detainLicenseToolStripMenuItem,
            this.releaseDetainLicenseToolStripMenuItem});
            this.detainLicensesToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("detainLicensesToolStripMenuItem.Image")));
            this.detainLicensesToolStripMenuItem.Name = "detainLicensesToolStripMenuItem";
            this.detainLicensesToolStripMenuItem.Size = new System.Drawing.Size(392, 66);
            this.detainLicensesToolStripMenuItem.Text = "Detain Licenses";
            // 
            // manageDetainedLicenseToolStripMenuItem
            // 
            this.manageDetainedLicenseToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("manageDetainedLicenseToolStripMenuItem.Image")));
            this.manageDetainedLicenseToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.manageDetainedLicenseToolStripMenuItem.Name = "manageDetainedLicenseToolStripMenuItem";
            this.manageDetainedLicenseToolStripMenuItem.Size = new System.Drawing.Size(350, 42);
            this.manageDetainedLicenseToolStripMenuItem.Text = "Manage Detained License";
            this.manageDetainedLicenseToolStripMenuItem.Click += new System.EventHandler(this.manageDetainedLicenseToolStripMenuItem_Click);
            // 
            // detainLicenseToolStripMenuItem
            // 
            this.detainLicenseToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("detainLicenseToolStripMenuItem.Image")));
            this.detainLicenseToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.detainLicenseToolStripMenuItem.Name = "detainLicenseToolStripMenuItem";
            this.detainLicenseToolStripMenuItem.Size = new System.Drawing.Size(350, 42);
            this.detainLicenseToolStripMenuItem.Text = "Detain License";
            this.detainLicenseToolStripMenuItem.Click += new System.EventHandler(this.detainLicenseToolStripMenuItem_Click);
            // 
            // releaseDetainLicenseToolStripMenuItem
            // 
            this.releaseDetainLicenseToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("releaseDetainLicenseToolStripMenuItem.Image")));
            this.releaseDetainLicenseToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.releaseDetainLicenseToolStripMenuItem.Name = "releaseDetainLicenseToolStripMenuItem";
            this.releaseDetainLicenseToolStripMenuItem.Size = new System.Drawing.Size(350, 42);
            this.releaseDetainLicenseToolStripMenuItem.Text = "Release Detain License";
            this.releaseDetainLicenseToolStripMenuItem.Click += new System.EventHandler(this.releaseDetainLicenseToolStripMenuItem_Click);
            // 
            // manageApplicationsTypsToolStripMenuItem
            // 
            this.manageApplicationsTypsToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("manageApplicationsTypsToolStripMenuItem.Image")));
            this.manageApplicationsTypsToolStripMenuItem.Name = "manageApplicationsTypsToolStripMenuItem";
            this.manageApplicationsTypsToolStripMenuItem.Size = new System.Drawing.Size(392, 66);
            this.manageApplicationsTypsToolStripMenuItem.Text = "Manage Applications Tyeps";
            this.manageApplicationsTypsToolStripMenuItem.Click += new System.EventHandler(this.manageApplicationsTypsToolStripMenuItem_Click);
            // 
            // manageTestTypesToolStripMenuItem
            // 
            this.manageTestTypesToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("manageTestTypesToolStripMenuItem.Image")));
            this.manageTestTypesToolStripMenuItem.Name = "manageTestTypesToolStripMenuItem";
            this.manageTestTypesToolStripMenuItem.Size = new System.Drawing.Size(392, 66);
            this.manageTestTypesToolStripMenuItem.Text = "Manage Test Types";
            this.manageTestTypesToolStripMenuItem.Click += new System.EventHandler(this.manageTestTypesToolStripMenuItem_Click);
            // 
            // peopleToolStripMenuItem
            // 
            this.peopleToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.peopleToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("peopleToolStripMenuItem.Image")));
            this.peopleToolStripMenuItem.Margin = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.peopleToolStripMenuItem.Name = "peopleToolStripMenuItem";
            this.peopleToolStripMenuItem.Padding = new System.Windows.Forms.Padding(6, 3, 6, 3);
            this.peopleToolStripMenuItem.Size = new System.Drawing.Size(144, 80);
            this.peopleToolStripMenuItem.Text = "People";
            this.peopleToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.peopleToolStripMenuItem.Click += new System.EventHandler(this.peopleToolStripMenuItem_Click);
            // 
            // driversToolStripMenuItem
            // 
            this.driversToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("driversToolStripMenuItem.Image")));
            this.driversToolStripMenuItem.Name = "driversToolStripMenuItem";
            this.driversToolStripMenuItem.Size = new System.Drawing.Size(149, 80);
            this.driversToolStripMenuItem.Text = "Drivers";
            this.driversToolStripMenuItem.Click += new System.EventHandler(this.driversToolStripMenuItem_Click);
            // 
            // usersToolStripMenuItem
            // 
            this.usersToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usersToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("usersToolStripMenuItem.Image")));
            this.usersToolStripMenuItem.Name = "usersToolStripMenuItem";
            this.usersToolStripMenuItem.Size = new System.Drawing.Size(132, 80);
            this.usersToolStripMenuItem.Text = "Users";
            this.usersToolStripMenuItem.Click += new System.EventHandler(this.usersToolStripMenuItem_Click);
            // 
            // accountSettingToolStripMenuItem
            // 
            this.accountSettingToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CurrentUserToolStripMenuItem,
            this.ChangePasswordToolStripMenuItem,
            this.toolStripSeparator1,
            this.SignOutToolStripMenuItem});
            this.accountSettingToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accountSettingToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("accountSettingToolStripMenuItem.Image")));
            this.accountSettingToolStripMenuItem.Name = "accountSettingToolStripMenuItem";
            this.accountSettingToolStripMenuItem.Size = new System.Drawing.Size(235, 80);
            this.accountSettingToolStripMenuItem.Text = "Account Settings";
            // 
            // CurrentUserToolStripMenuItem
            // 
            this.CurrentUserToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.CurrentUserToolStripMenuItem.Name = "CurrentUserToolStripMenuItem";
            this.CurrentUserToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.CurrentUserToolStripMenuItem.Text = "&Current User Info";
            this.CurrentUserToolStripMenuItem.Click += new System.EventHandler(this.uToolStripMenuItem_Click);
            // 
            // ChangePasswordToolStripMenuItem
            // 
            this.ChangePasswordToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ChangePasswordToolStripMenuItem.Name = "ChangePasswordToolStripMenuItem";
            this.ChangePasswordToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.ChangePasswordToolStripMenuItem.Text = "Change Password";
            this.ChangePasswordToolStripMenuItem.Click += new System.EventHandler(this.ChangePasswordToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(267, 6);
            // 
            // SignOutToolStripMenuItem
            // 
            this.SignOutToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.SignOutToolStripMenuItem.Name = "SignOutToolStripMenuItem";
            this.SignOutToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.SignOutToolStripMenuItem.Text = "Sign Out";
            this.SignOutToolStripMenuItem.Click += new System.EventHandler(this.SignOutToolStripMenuItem_Click);
            // 
            // lbPersonName
            // 
            this.lbPersonName.AutoSize = true;
            this.lbPersonName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPersonName.Location = new System.Drawing.Point(1339, 21);
            this.lbPersonName.Name = "lbPersonName";
            this.lbPersonName.Size = new System.Drawing.Size(153, 29);
            this.lbPersonName.TabIndex = 5;
            this.lbPersonName.Text = "Bakri Kamal";
            // 
            // pBPersonPhoto
            // 
            this.pBPersonPhoto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pBPersonPhoto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pBPersonPhoto.Location = new System.Drawing.Point(1555, 9);
            this.pBPersonPhoto.Name = "pBPersonPhoto";
            this.pBPersonPhoto.Size = new System.Drawing.Size(81, 50);
            this.pBPersonPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pBPersonPhoto.TabIndex = 6;
            this.pBPersonPhoto.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(0, 84);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1760, 616);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(396, 174);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(697, 537);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox2.TabIndex = 8;
            this.pictureBox2.TabStop = false;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1760, 700);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pBPersonPhoto);
            this.Controls.Add(this.lbPersonName);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMain";
            this.Text = "Main";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBPersonPhoto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem peopleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem userToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripMenuItem drivingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageApplicationsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newDrivingLicenseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem renewDrivingLicenseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem replacemrntForLosOrDamegedLicenseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem detainLicensesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageApplicationsTypsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageTestTypesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem localLicenseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem internationalLicenseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem retakeTestToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageDetainedLicenseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem accountSettingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem CurrentUserToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ChangePasswordToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SignOutToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.Label lbPersonName;
        private System.Windows.Forms.PictureBox pBPersonPhoto;
        private System.Windows.Forms.ToolStripMenuItem driversToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem localDrivingLicenseApplicationsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem internationalLicenseApplicationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem detainLicenseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem releaseDetainLicenseToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

