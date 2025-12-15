namespace Driving_License_Management.Users
{
    partial class frmChangePassword
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
            this.txbCurrentPassword = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txbConfirmPassword = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txbNewPassword = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ucUserInformation1 = new Driving_License_Management.Controls.ucUserInformation();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // txbCurrentPassword
            // 
            this.txbCurrentPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbCurrentPassword.Location = new System.Drawing.Point(269, 504);
            this.txbCurrentPassword.Name = "txbCurrentPassword";
            this.txbCurrentPassword.PasswordChar = '*';
            this.txbCurrentPassword.Size = new System.Drawing.Size(208, 26);
            this.txbCurrentPassword.TabIndex = 105;
            this.txbCurrentPassword.UseSystemPasswordChar = true;
            this.txbCurrentPassword.Validating += new System.ComponentModel.CancelEventHandler(this.txbCurrentPassword_Validating);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label2.Location = new System.Drawing.Point(99, 509);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 25);
            this.label2.TabIndex = 104;
            this.label2.Text = "Password:";
            // 
            // txbConfirmPassword
            // 
            this.txbConfirmPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbConfirmPassword.Location = new System.Drawing.Point(269, 600);
            this.txbConfirmPassword.Name = "txbConfirmPassword";
            this.txbConfirmPassword.Size = new System.Drawing.Size(208, 26);
            this.txbConfirmPassword.TabIndex = 102;
            this.txbConfirmPassword.UseSystemPasswordChar = true;
            this.txbConfirmPassword.Validating += new System.ComponentModel.CancelEventHandler(this.txbConfirmPassword_Validating);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.label3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label3.Location = new System.Drawing.Point(16, 601);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(194, 25);
            this.label3.TabIndex = 101;
            this.label3.Text = "Confirm Password:";
            // 
            // txbNewPassword
            // 
            this.txbNewPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbNewPassword.Location = new System.Drawing.Point(269, 553);
            this.txbNewPassword.Name = "txbNewPassword";
            this.txbNewPassword.PasswordChar = '*';
            this.txbNewPassword.Size = new System.Drawing.Size(208, 26);
            this.txbNewPassword.TabIndex = 108;
            this.txbNewPassword.UseSystemPasswordChar = true;
            this.txbNewPassword.Validating += new System.ComponentModel.CancelEventHandler(this.txbNewPassword_Validating);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.label5.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label5.Location = new System.Drawing.Point(51, 559);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(161, 25);
            this.label5.TabIndex = 107;
            this.label5.Text = "Nwe Password:";
            // 
            // btnClose
            // 
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Image = global::Driving_License_Management.Properties.Resources.Close_32;
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.Location = new System.Drawing.Point(638, 665);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(157, 53);
            this.btnClose.TabIndex = 111;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnSave
            // 
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Image = global::Driving_License_Management.Properties.Resources.Save_32;
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.Location = new System.Drawing.Point(832, 665);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(157, 53);
            this.btnSave.TabIndex = 110;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // pictureBox3
            // 
            ////     this.pictureBox3.Image = global::Driving_License_Management.Properties.Resources.Number_32;
            this.pictureBox3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.pictureBox3.Location = new System.Drawing.Point(220, 547);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(32, 34);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 109;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            ////     this.pictureBox2.Image = global::Driving_License_Management.Properties.Resources.Number_32;
            this.pictureBox2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.pictureBox2.Location = new System.Drawing.Point(220, 498);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(32, 34);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 106;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            ////       this.pictureBox1.Image = global::Driving_License_Management.Properties.Resources.Number_32;
            this.pictureBox1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.pictureBox1.Location = new System.Drawing.Point(220, 596);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(32, 34);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 103;
            this.pictureBox1.TabStop = false;
            // 
            // ucUserInformation1
            // 
            this.ucUserInformation1.BackColor = System.Drawing.SystemColors.Window;
            this.ucUserInformation1.Location = new System.Drawing.Point(21, -1);
            this.ucUserInformation1.Name = "ucUserInformation1";
            this.ucUserInformation1.Size = new System.Drawing.Size(977, 462);
            this.ucUserInformation1.TabIndex = 112;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // frmChangePassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1010, 731);
            this.Controls.Add(this.ucUserInformation1);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txbNewPassword);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.txbCurrentPassword);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txbConfirmPassword);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "frmChangePassword";
            this.ShowIcon = false;
            this.Text = "Change Password";
            this.Load += new System.EventHandler(this.frmChangePassword_Load);

            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txbCurrentPassword;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txbConfirmPassword;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txbNewPassword;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnSave;
        private Controls.ucUserInformation ucUserInformation1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}