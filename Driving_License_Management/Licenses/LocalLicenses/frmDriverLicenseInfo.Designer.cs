namespace Driving_License_Management.Licenses.LocalLicenses
{
    partial class frmDriverLicenseInfo
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
            this.ucLocalDriver_sLicense1 = new Driving_License_Management.Licenses.LocalLicenses.Controls.ucLocalDriver_sLicense();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pbTestTypeImage = new System.Windows.Forms.PictureBox();
            this.btnClose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbTestTypeImage)).BeginInit();
            this.SuspendLayout();
            // 
            // ucLocalDriver_sLicense1
            // 
            this.ucLocalDriver_sLicense1.Location = new System.Drawing.Point(0, 191);
            this.ucLocalDriver_sLicense1.Name = "ucLocalDriver_sLicense1";
            this.ucLocalDriver_sLicense1.Size = new System.Drawing.Size(974, 299);
            this.ucLocalDriver_sLicense1.TabIndex = 0;
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblTitle.Location = new System.Drawing.Point(275, 123);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(441, 56);
            this.lblTitle.TabIndex = 136;
            this.lblTitle.Text = "Driver License Info";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pbTestTypeImage
            // 
            this.pbTestTypeImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbTestTypeImage.InitialImage = null;
            this.pbTestTypeImage.Location = new System.Drawing.Point(447, 14);
            this.pbTestTypeImage.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pbTestTypeImage.Name = "pbTestTypeImage";
            this.pbTestTypeImage.Size = new System.Drawing.Size(113, 104);
            this.pbTestTypeImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbTestTypeImage.TabIndex = 137;
            this.pbTestTypeImage.TabStop = false;
            // 
            // btnClose
            // 
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.Location = new System.Drawing.Point(804, 508);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(126, 37);
            this.btnClose.TabIndex = 138;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // frmDriverLicenseInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(965, 559);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.pbTestTypeImage);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.ucLocalDriver_sLicense1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "frmDriverLicenseInfo";
            this.Text = "Driver License Info";
            ((System.ComponentModel.ISupportInitialize)(this.pbTestTypeImage)).EndInit();
            this.ResumeLayout(false);
            //
            //load
            //
            this.Load += new System.EventHandler(this.frmDriverLicenseInfo_Load);

        }

        #endregion

        private Controls.ucLocalDriver_sLicense ucLocalDriver_sLicense1;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.PictureBox pbTestTypeImage;
        private System.Windows.Forms.Button btnClose;
    }
}