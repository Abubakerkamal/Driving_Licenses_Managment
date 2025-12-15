namespace Driving_License_Management.Login
{
    partial class frmAdd_UpdateUser
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPersonInfo = new System.Windows.Forms.TabPage();
            this.ucPersonInfoWithFilter1 = new Driving_License_Management.Controls.ucPersonInfoWithFilter();
            this.btnNext = new System.Windows.Forms.Button();
            this.tapUserInfo = new System.Windows.Forms.TabPage();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.chkIsActive = new System.Windows.Forms.CheckBox();
            this.lbUserID = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.txbPassword = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txbConfirmPassword = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.txbUsername = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lbHeader = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.tabControl1.SuspendLayout();
            this.tabPersonInfo.SuspendLayout();
            this.tapUserInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPersonInfo);
            this.tabControl1.Controls.Add(this.tapUserInfo);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(34, 102);
            this.tabControl1.Multiline = true;
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1228, 621);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPersonInfo
            // 
            this.tabPersonInfo.BackColor = System.Drawing.SystemColors.Window;
            this.tabPersonInfo.Controls.Add(this.ucPersonInfoWithFilter1);
            this.tabPersonInfo.Controls.Add(this.btnNext);
            this.tabPersonInfo.Location = new System.Drawing.Point(4, 29);
            this.tabPersonInfo.Name = "tabPersonInfo";
            this.tabPersonInfo.Padding = new System.Windows.Forms.Padding(3);
            this.tabPersonInfo.Size = new System.Drawing.Size(1220, 588);
            this.tabPersonInfo.TabIndex = 0;
            this.tabPersonInfo.Text = "Person Info";
            // 
            // ucPersonInfoWithFilter1
            // 
            this.ucPersonInfoWithFilter1.BackColor = System.Drawing.SystemColors.Window;
            this.ucPersonInfoWithFilter1.FilterEnabeled = true;
            this.ucPersonInfoWithFilter1.Location = new System.Drawing.Point(55, 67);
            this.ucPersonInfoWithFilter1.Name = "ucPersonInfoWithFilter1";
            this.ucPersonInfoWithFilter1.ShowBtnAddPerson = true;
            this.ucPersonInfoWithFilter1.Size = new System.Drawing.Size(1144, 439);
            this.ucPersonInfoWithFilter1.TabIndex = 2;
            // 
            // btnNext
            // 
            this.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
          //  this.btnNext.Image = global::Driving_License_Management.Properties.Resources.Next_32;
            this.btnNext.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNext.Location = new System.Drawing.Point(1027, 524);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(157, 53);
            this.btnNext.TabIndex = 1;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // tapUserInfo
            // 
            this.tapUserInfo.BackColor = System.Drawing.SystemColors.Window;
            this.tapUserInfo.Controls.Add(this.btnPrevious);
            this.tapUserInfo.Controls.Add(this.chkIsActive);
            this.tapUserInfo.Controls.Add(this.lbUserID);
            this.tapUserInfo.Controls.Add(this.pictureBox2);
            this.tapUserInfo.Controls.Add(this.txbPassword);
            this.tapUserInfo.Controls.Add(this.label2);
            this.tapUserInfo.Controls.Add(this.pictureBox1);
            this.tapUserInfo.Controls.Add(this.txbConfirmPassword);
            this.tapUserInfo.Controls.Add(this.label1);
            this.tapUserInfo.Controls.Add(this.pictureBox4);
            this.tapUserInfo.Controls.Add(this.pictureBox3);
            this.tapUserInfo.Controls.Add(this.txbUsername);
            this.tapUserInfo.Controls.Add(this.label11);
            this.tapUserInfo.Controls.Add(this.label10);
            this.tapUserInfo.Location = new System.Drawing.Point(4, 29);
            this.tapUserInfo.Name = "tapUserInfo";
            this.tapUserInfo.Padding = new System.Windows.Forms.Padding(3);
            this.tapUserInfo.Size = new System.Drawing.Size(1220, 588);
            this.tapUserInfo.TabIndex = 1;
            this.tapUserInfo.Text = "User Info";
            // 
            // btnPrevious
            // 
            this.btnPrevious.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
   //         this.btnPrevious.Image = global::Driving_License_Management.Properties.Resources.Prev_32;
            this.btnPrevious.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPrevious.Location = new System.Drawing.Point(1027, 529);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(157, 53);
            this.btnPrevious.TabIndex = 103;
            this.btnPrevious.Text = "     Previous";
            this.btnPrevious.UseVisualStyleBackColor = true;
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // chkIsActive
            // 
            this.chkIsActive.AutoSize = true;
            this.chkIsActive.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chkIsActive.Location = new System.Drawing.Point(284, 366);
            this.chkIsActive.Name = "chkIsActive";
            this.chkIsActive.Size = new System.Drawing.Size(99, 24);
            this.chkIsActive.TabIndex = 102;
            this.chkIsActive.Text = "Is Active";
            this.chkIsActive.UseVisualStyleBackColor = true;
            // 
            // lbUserID
            // 
            this.lbUserID.AutoSize = true;
            this.lbUserID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.lbUserID.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbUserID.Location = new System.Drawing.Point(279, 118);
            this.lbUserID.Name = "lbUserID";
            this.lbUserID.Size = new System.Drawing.Size(62, 25);
            this.lbUserID.TabIndex = 101;
            this.lbUserID.Text = "[???]";
            // 
            // pictureBox2
            // 
        //    this.pictureBox2.Image = global::Driving_License_Management.Properties.Resources.Number_32;
            this.pictureBox2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.pictureBox2.Location = new System.Drawing.Point(235, 240);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(32, 34);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 100;
            this.pictureBox2.TabStop = false;
            // 
            // txbPassword
            // 
            this.txbPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbPassword.Location = new System.Drawing.Point(284, 246);
            this.txbPassword.Name = "txbPassword";
            this.txbPassword.PasswordChar = '*';
            this.txbPassword.Size = new System.Drawing.Size(208, 26);
            this.txbPassword.TabIndex = 99;
            this.txbPassword.UseSystemPasswordChar = true;
            this.txbPassword.Validating += new System.ComponentModel.CancelEventHandler(this.txbPassword_Validating);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label2.Location = new System.Drawing.Point(100, 245);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 25);
            this.label2.TabIndex = 98;
            this.label2.Text = "Password:";
            // 
            // pictureBox1
            // 
      //      this.pictureBox1.Image = global::Driving_License_Management.Properties.Resources.Number_32;
            this.pictureBox1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.pictureBox1.Location = new System.Drawing.Point(235, 301);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(32, 34);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 97;
            this.pictureBox1.TabStop = false;
            // 
            // txbConfirmPassword
            // 
            this.txbConfirmPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbConfirmPassword.Location = new System.Drawing.Point(284, 305);
            this.txbConfirmPassword.Name = "txbConfirmPassword";
            this.txbConfirmPassword.Size = new System.Drawing.Size(208, 26);
            this.txbConfirmPassword.TabIndex = 96;
            this.txbConfirmPassword.UseSystemPasswordChar = true;
            this.txbConfirmPassword.Validating += new System.ComponentModel.CancelEventHandler(this.txbConfirmPassword_Validating);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(23, 301);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(194, 25);
            this.label1.TabIndex = 95;
            this.label1.Text = "Confirm Password:";
            // 
            // pictureBox4
            // 
     //       this.pictureBox4.Image = global::Driving_License_Management.Properties.Resources.Number_32;
            this.pictureBox4.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.pictureBox4.Location = new System.Drawing.Point(235, 109);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(32, 34);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 94;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
  //          this.pictureBox3.Image = global::Driving_License_Management.Properties.Resources.Person_32;
            this.pictureBox3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.pictureBox3.Location = new System.Drawing.Point(235, 176);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(32, 34);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 93;
            this.pictureBox3.TabStop = false;
            // 
            // txbUsername
            // 
            this.txbUsername.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbUsername.Location = new System.Drawing.Point(284, 185);
            this.txbUsername.Name = "txbUsername";
            this.txbUsername.Size = new System.Drawing.Size(208, 26);
            this.txbUsername.TabIndex = 91;
            this.txbUsername.Validating += new System.ComponentModel.CancelEventHandler(this.txbUsername_Validating);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.label11.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label11.Location = new System.Drawing.Point(100, 185);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(117, 25);
            this.label11.TabIndex = 90;
            this.label11.Text = "Username:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.label10.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label10.Location = new System.Drawing.Point(122, 118);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(91, 25);
            this.label10.TabIndex = 89;
            this.label10.Text = "User ID:";
            // 
            // lbHeader
            // 
            this.lbHeader.AutoSize = true;
            this.lbHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbHeader.ForeColor = System.Drawing.Color.Red;
            this.lbHeader.Location = new System.Drawing.Point(421, 35);
            this.lbHeader.Name = "lbHeader";
            this.lbHeader.Size = new System.Drawing.Size(397, 64);
            this.lbHeader.TabIndex = 1;
            this.lbHeader.Text = "Add New User";
            // 
            // btnClose
            // 
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
   //         this.btnClose.Image = global::Driving_License_Management.Properties.Resources.Close_32;
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.Location = new System.Drawing.Point(874, 739);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(157, 53);
            this.btnClose.TabIndex = 3;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnSave
            // 
            this.btnSave.Enabled = false;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
  //          this.btnSave.Image = global::Driving_License_Management.Properties.Resources.Save_32;
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.Location = new System.Drawing.Point(1065, 739);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(157, 53);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // frmAdd_UpdateUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1274, 891);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lbHeader);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmAdd_UpdateUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmAdd_UpdateUser";
            this.Load += new System.EventHandler(this.frmAdd_UpdateUser_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPersonInfo.ResumeLayout(false);
            this.tapUserInfo.ResumeLayout(false);
            this.tapUserInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPersonInfo;
        private System.Windows.Forms.TabPage tapUserInfo;
        private System.Windows.Forms.Button btnNext;
        private Controls.ucPersonInfoWithFilter ucPersonInfoWithFilter1;
        private System.Windows.Forms.Label lbHeader;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.TextBox txbUsername;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lbUserID;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox txbPassword;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txbConfirmPassword;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox chkIsActive;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}