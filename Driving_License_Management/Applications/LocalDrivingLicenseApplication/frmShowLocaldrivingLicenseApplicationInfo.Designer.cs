namespace Driving_License_Management.Applcations.LocalDrivingLicenseApplication
{
    partial class frmShowLocaldrivingLicenseApplicationInfo
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
            this.btnClose = new System.Windows.Forms.Button();
            this.ucLocalDrivingLicenseApplicationInfo1 = new Driving_License_Management.Controls.ucLocalDrivingLicenseApplicationInfo();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Image = global::Driving_License_Management.Properties.Resources.Close_32;
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.Location = new System.Drawing.Point(955, 474);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(158, 52);
            this.btnClose.TabIndex = 8;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // ucLocalDrivingLicenseApplicationInfo1
            // 
            this.ucLocalDrivingLicenseApplicationInfo1.Location = new System.Drawing.Point(2, 1);
            this.ucLocalDrivingLicenseApplicationInfo1.Name = "ucLocalDrivingLicenseApplicationInfo1";
            this.ucLocalDrivingLicenseApplicationInfo1.Size = new System.Drawing.Size(1125, 469);
            this.ucLocalDrivingLicenseApplicationInfo1.TabIndex = 0;
            // 
            // frmShowLocaldrivingLicenseApplicationInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1125, 538);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.ucLocalDrivingLicenseApplicationInfo1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "frmShowLocaldrivingLicenseApplicationInfo";
            this.ShowIcon = false;
            this.Text = "Local Driving License Application Info";
            this.Load += new System.EventHandler(this.frmShowLocaldrivingLicenseApplicationInfo_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Controls.ucLocalDrivingLicenseApplicationInfo ucLocalDrivingLicenseApplicationInfo1;
        private System.Windows.Forms.Button btnClose;
    }
}