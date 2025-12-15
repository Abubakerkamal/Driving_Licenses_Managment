namespace Driving_License_Management.Applcations.LocalDrivingLicenseApplication
{
    partial class frmAddUpdataLocalDrivingLicenseApplications
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
            this.lbHeader = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPersonInfo = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.tapUserInfo = new System.Windows.Forms.TabPage();
            this.cmbLicenseClass = new System.Windows.Forms.ComboBox();
            this.lbApplicationDate = new System.Windows.Forms.Label();
            this.lbApplicationFees = new System.Windows.Forms.Label();
            this.lbCreatedBy = new System.Windows.Forms.Label();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.lbDLApplicationID = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnClose = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.ucPersonInfoWithFilter1 = new Driving_License_Management.Controls.ucPersonInfoWithFilter();
            this.tabControl1.SuspendLayout();
            this.tabPersonInfo.SuspendLayout();
            this.tapUserInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbHeader
            // 
            this.lbHeader.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbHeader.AutoSize = true;
            this.lbHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbHeader.ForeColor = System.Drawing.Color.Red;
            this.lbHeader.Location = new System.Drawing.Point(35, 0);
            this.lbHeader.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbHeader.Name = "lbHeader";
            this.lbHeader.Size = new System.Drawing.Size(800, 44);
            this.lbHeader.TabIndex = 5;
            this.lbHeader.Text = "Add New Local Driving License Applications";
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPersonInfo);
            this.tabControl1.Controls.Add(this.tapUserInfo);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(22, 46);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(2);
            this.tabControl1.Multiline = true;
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(819, 351);
            this.tabControl1.TabIndex = 4;
            // 
            // tabPersonInfo
            // 
            this.tabPersonInfo.BackColor = System.Drawing.SystemColors.Window;
            this.tabPersonInfo.Controls.Add(this.button2);
            this.tabPersonInfo.Controls.Add(this.button1);
            this.tabPersonInfo.Controls.Add(this.btnNext);
            this.tabPersonInfo.Controls.Add(this.ucPersonInfoWithFilter1);
            this.tabPersonInfo.Location = new System.Drawing.Point(4, 22);
            this.tabPersonInfo.Margin = new System.Windows.Forms.Padding(2);
            this.tabPersonInfo.Name = "tabPersonInfo";
            this.tabPersonInfo.Padding = new System.Windows.Forms.Padding(2);
            this.tabPersonInfo.Size = new System.Drawing.Size(811, 325);
            this.tabPersonInfo.TabIndex = 0;
            this.tabPersonInfo.Text = "Person Info";
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = global::Driving_License_Management.Properties.Resources.Next_32;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(2658, 1118);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(105, 34);
            this.button1.TabIndex = 9;
            this.button1.Text = "Next";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnNext
            // 
            this.btnNext.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNext.Image = global::Driving_License_Management.Properties.Resources.Next_32;
            this.btnNext.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNext.Location = new System.Drawing.Point(2006, 846);
            this.btnNext.Margin = new System.Windows.Forms.Padding(2);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(105, 35);
            this.btnNext.TabIndex = 1;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // tapUserInfo
            // 
            this.tapUserInfo.BackColor = System.Drawing.SystemColors.Window;
            this.tapUserInfo.Controls.Add(this.cmbLicenseClass);
            this.tapUserInfo.Controls.Add(this.lbApplicationDate);
            this.tapUserInfo.Controls.Add(this.lbApplicationFees);
            this.tapUserInfo.Controls.Add(this.lbCreatedBy);
            this.tapUserInfo.Controls.Add(this.pictureBox5);
            this.tapUserInfo.Controls.Add(this.label3);
            this.tapUserInfo.Controls.Add(this.btnPrevious);
            this.tapUserInfo.Controls.Add(this.lbDLApplicationID);
            this.tapUserInfo.Controls.Add(this.pictureBox2);
            this.tapUserInfo.Controls.Add(this.label2);
            this.tapUserInfo.Controls.Add(this.pictureBox1);
            this.tapUserInfo.Controls.Add(this.label1);
            this.tapUserInfo.Controls.Add(this.pictureBox4);
            this.tapUserInfo.Controls.Add(this.pictureBox3);
            this.tapUserInfo.Controls.Add(this.label11);
            this.tapUserInfo.Controls.Add(this.label10);
            this.tapUserInfo.Location = new System.Drawing.Point(4, 22);
            this.tapUserInfo.Margin = new System.Windows.Forms.Padding(2);
            this.tapUserInfo.Name = "tapUserInfo";
            this.tapUserInfo.Padding = new System.Windows.Forms.Padding(2);
            this.tapUserInfo.Size = new System.Drawing.Size(811, 325);
            this.tapUserInfo.TabIndex = 1;
            this.tapUserInfo.Text = "Application Info";
            // 
            // cmbLicenseClass
            // 
            this.cmbLicenseClass.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbLicenseClass.FormattingEnabled = true;
            this.cmbLicenseClass.Location = new System.Drawing.Point(197, 155);
            this.cmbLicenseClass.Margin = new System.Windows.Forms.Padding(2);
            this.cmbLicenseClass.Name = "cmbLicenseClass";
            this.cmbLicenseClass.Size = new System.Drawing.Size(161, 21);
            this.cmbLicenseClass.TabIndex = 110;
            this.cmbLicenseClass.Validating += new System.ComponentModel.CancelEventHandler(this.cmbLicenseClass_Validating);
            // 
            // lbApplicationDate
            // 
            this.lbApplicationDate.AutoSize = true;
            this.lbApplicationDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.lbApplicationDate.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbApplicationDate.Location = new System.Drawing.Point(193, 116);
            this.lbApplicationDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbApplicationDate.Name = "lbApplicationDate";
            this.lbApplicationDate.Size = new System.Drawing.Size(45, 17);
            this.lbApplicationDate.TabIndex = 109;
            this.lbApplicationDate.Text = "[???]";
            // 
            // lbApplicationFees
            // 
            this.lbApplicationFees.AutoSize = true;
            this.lbApplicationFees.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.lbApplicationFees.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbApplicationFees.Location = new System.Drawing.Point(193, 194);
            this.lbApplicationFees.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbApplicationFees.Name = "lbApplicationFees";
            this.lbApplicationFees.Size = new System.Drawing.Size(45, 17);
            this.lbApplicationFees.TabIndex = 108;
            this.lbApplicationFees.Text = "[???]";
            // 
            // lbCreatedBy
            // 
            this.lbCreatedBy.AutoSize = true;
            this.lbCreatedBy.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.lbCreatedBy.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbCreatedBy.Location = new System.Drawing.Point(193, 233);
            this.lbCreatedBy.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbCreatedBy.Name = "lbCreatedBy";
            this.lbCreatedBy.Size = new System.Drawing.Size(45, 17);
            this.lbCreatedBy.TabIndex = 107;
            this.lbCreatedBy.Text = "[???]";
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::Driving_License_Management.Properties.Resources.User_32__2;
            this.pictureBox5.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.pictureBox5.Location = new System.Drawing.Point(157, 227);
            this.pictureBox5.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(21, 22);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 105;
            this.pictureBox5.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.label3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label3.Location = new System.Drawing.Point(57, 227);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 17);
            this.label3.TabIndex = 104;
            this.label3.Text = "Created By:";
            // 
            // btnPrevious
            // 
            this.btnPrevious.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrevious.Image = global::Driving_License_Management.Properties.Resources.Prev_32;
            this.btnPrevious.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPrevious.Location = new System.Drawing.Point(669, 287);
            this.btnPrevious.Margin = new System.Windows.Forms.Padding(2);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(105, 34);
            this.btnPrevious.TabIndex = 103;
            this.btnPrevious.Text = "     Previous";
            this.btnPrevious.UseVisualStyleBackColor = true;
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // lbDLApplicationID
            // 
            this.lbDLApplicationID.AutoSize = true;
            this.lbDLApplicationID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.lbDLApplicationID.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbDLApplicationID.Location = new System.Drawing.Point(193, 77);
            this.lbDLApplicationID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbDLApplicationID.Name = "lbDLApplicationID";
            this.lbDLApplicationID.Size = new System.Drawing.Size(45, 17);
            this.lbDLApplicationID.TabIndex = 101;
            this.lbDLApplicationID.Text = "[???]";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Driving_License_Management.Properties.Resources.New_Driving_License_32;
            this.pictureBox2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.pictureBox2.Location = new System.Drawing.Point(157, 149);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(21, 22);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 100;
            this.pictureBox2.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label2.Location = new System.Drawing.Point(39, 152);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 17);
            this.label2.TabIndex = 98;
            this.label2.Text = "License Class:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Driving_License_Management.Properties.Resources.money_321;
            this.pictureBox1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.pictureBox1.Location = new System.Drawing.Point(157, 188);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(21, 22);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 97;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(22, 188);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 17);
            this.label1.TabIndex = 95;
            this.label1.Text = "Application Fees:";
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::Driving_License_Management.Properties.Resources.Number_32;
            this.pictureBox4.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.pictureBox4.Location = new System.Drawing.Point(157, 71);
            this.pictureBox4.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(21, 22);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 94;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Driving_License_Management.Properties.Resources.Calendar_321;
            this.pictureBox3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.pictureBox3.Location = new System.Drawing.Point(157, 110);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(21, 22);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 93;
            this.pictureBox3.TabStop = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.label11.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label11.Location = new System.Drawing.Point(24, 114);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(132, 17);
            this.label11.TabIndex = 90;
            this.label11.Text = "Application Date:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.label10.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label10.Location = new System.Drawing.Point(18, 77);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(138, 17);
            this.label10.TabIndex = 89;
            this.label10.Text = "D.L.ApplicationID:";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Image = global::Driving_License_Management.Properties.Resources.Close_32;
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.Location = new System.Drawing.Point(564, 401);
            this.btnClose.Margin = new System.Windows.Forms.Padding(2);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(105, 34);
            this.btnClose.TabIndex = 7;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.Enabled = false;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Image = global::Driving_License_Management.Properties.Resources.Save_32;
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.Location = new System.Drawing.Point(693, 401);
            this.btnSave.Margin = new System.Windows.Forms.Padding(2);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(105, 34);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Image = global::Driving_License_Management.Properties.Resources.Next_32;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(667, 287);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(105, 34);
            this.button2.TabIndex = 10;
            this.button2.Text = "Next";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // ucPersonInfoWithFilter1
            // 
            this.ucPersonInfoWithFilter1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ucPersonInfoWithFilter1.BackColor = System.Drawing.SystemColors.Window;
            this.ucPersonInfoWithFilter1.FilterEnabeled = true;
            this.ucPersonInfoWithFilter1.Location = new System.Drawing.Point(27, 3);
            this.ucPersonInfoWithFilter1.Margin = new System.Windows.Forms.Padding(1);
            this.ucPersonInfoWithFilter1.Name = "ucPersonInfoWithFilter1";
            this.ucPersonInfoWithFilter1.ShowBtnAddPerson = true;
            this.ucPersonInfoWithFilter1.Size = new System.Drawing.Size(765, 286);
            this.ucPersonInfoWithFilter1.TabIndex = 8;
            // 
            // frmAddUpdataLocalDrivingLicenseApplications
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(856, 453);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lbHeader);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmAddUpdataLocalDrivingLicenseApplications";
            this.Text = "Add Local Driving License Applications";
            this.Activated += new System.EventHandler(this.frmAddUpdataLocalDrivingLicenseApplications_Activated);
            this.Load += new System.EventHandler(this.frmAddUpdataLocalDrivingLicenseApplications_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPersonInfo.ResumeLayout(false);
            this.tapUserInfo.ResumeLayout(false);
            this.tapUserInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lbHeader;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPersonInfo;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.TabPage tapUserInfo;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.Label lbDLApplicationID;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbLicenseClass;
        private System.Windows.Forms.Label lbApplicationDate;
        private System.Windows.Forms.Label lbApplicationFees;
        private System.Windows.Forms.Label lbCreatedBy;
        private Controls.ucPersonInfoWithFilter ucPersonInfoWithFilter1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}