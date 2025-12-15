namespace Driving_License_Management.Licenses.LocalLicenses.Controls
{
    partial class ucDriverLicenseWithFilter
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gbFilters = new System.Windows.Forms.GroupBox();
            this.btnFind = new System.Windows.Forms.Button();
            this.txtLicenseID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ucLocalDriver_sLicense1 = new Driving_License_Management.Licenses.LocalLicenses.Controls.ucLocalDriver_sLicense();
            this.gbFilters.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbFilters
            // 
            this.gbFilters.Controls.Add(this.btnFind);
            this.gbFilters.Controls.Add(this.txtLicenseID);
            this.gbFilters.Controls.Add(this.label1);
            this.gbFilters.Location = new System.Drawing.Point(17, 19);
            this.gbFilters.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbFilters.Name = "gbFilters";
            this.gbFilters.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbFilters.Size = new System.Drawing.Size(974, 98);
            this.gbFilters.TabIndex = 18;
            this.gbFilters.TabStop = false;
            this.gbFilters.Text = "Filter";
            // 
            // btnFind
            // 
            this.btnFind.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFind.Location = new System.Drawing.Point(872, 22);
            this.btnFind.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(66, 57);
            this.btnFind.TabIndex = 18;
            this.btnFind.UseVisualStyleBackColor = true;
            btnFind.Click += new System.EventHandler(this.btnFind_Click);

            // 
            // txtLicenseID
            // 
            this.txtLicenseID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtLicenseID.Location = new System.Drawing.Point(426, 38);
            this.txtLicenseID.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.txtLicenseID.Name = "txtLicenseID";
            this.txtLicenseID.Size = new System.Drawing.Size(407, 26);
            this.txtLicenseID.TabIndex = 17;
            this.txtLicenseID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtLicenseID_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(266, 35);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 29);
            this.label1.TabIndex = 19;
            this.label1.Text = "LicenseID:";
            // 
            // ucLocalDriver_sLicense1
            // 
            this.ucLocalDriver_sLicense1.Location = new System.Drawing.Point(17, 125);
            this.ucLocalDriver_sLicense1.Name = "ucLocalDriver_sLicense1";
            this.ucLocalDriver_sLicense1.Size = new System.Drawing.Size(974, 299);
            this.ucLocalDriver_sLicense1.TabIndex = 19;
            // 
            // 
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ucLocalDriver_sLicense1);
            this.Controls.Add(this.gbFilters);
            this.Name = "ucDriverLicenseWithFilter";
            this.Size = new System.Drawing.Size(1016, 438);
            this.gbFilters.ResumeLayout(false);
            this.gbFilters.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbFilters;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.TextBox txtLicenseID;
        private System.Windows.Forms.Label label1;
        private ucLocalDriver_sLicense ucLocalDriver_sLicense1;
    }
}
