namespace Driving_License_Management.Licenses
{
    partial class frmPersonLicensesHistory
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
            this.pbox = new System.Windows.Forms.PictureBox();
            this.ucPersonInfoWithFilter1 = new Driving_License_Management.Controls.ucPersonInfoWithFilter();
            this.ucDriverLicenses1 = new Driving_License_Management.Licenses.Controls.ucDriverLicenses();
            ((System.ComponentModel.ISupportInitialize)(this.pbox)).BeginInit();
            this.SuspendLayout();
            // 
            // pbox
            // 
            this.pbox.Location = new System.Drawing.Point(12, 234);
            this.pbox.Name = "pbox";
            this.pbox.Size = new System.Drawing.Size(175, 137);
            this.pbox.TabIndex = 2;
            this.pbox.TabStop = false;
            // 
            // ucPersonInfoWithFilter1
            // 
            this.ucPersonInfoWithFilter1.BackColor = System.Drawing.SystemColors.Window;
            this.ucPersonInfoWithFilter1.FilterEnabeled = true;
            this.ucPersonInfoWithFilter1.Location = new System.Drawing.Point(193, -2);
            this.ucPersonInfoWithFilter1.Name = "ucPersonInfoWithFilter1";
            this.ucPersonInfoWithFilter1.ShowBtnAddPerson = true;
            this.ucPersonInfoWithFilter1.Size = new System.Drawing.Size(970, 456);
            this.ucPersonInfoWithFilter1.TabIndex = 1;
            this.ucPersonInfoWithFilter1.OnPersonSelected += new System.Action<int>(this.ctrlPersonCardWithFilter1_OnPersonSelected);

            // 
            // ucDriverLicenses1
            // 
            this.ucDriverLicenses1.Location = new System.Drawing.Point(86, 451);
            this.ucDriverLicenses1.Name = "ucDriverLicenses1";
            this.ucDriverLicenses1.Size = new System.Drawing.Size(1077, 339);
            this.ucDriverLicenses1.TabIndex = 0;
            // 
            // frmPersonLicensesHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1200, 792);
            this.Controls.Add(this.pbox);
            this.Controls.Add(this.ucPersonInfoWithFilter1);
            this.Controls.Add(this.ucDriverLicenses1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "frmPersonLicensesHistory";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Person Licenses History";
            ((System.ComponentModel.ISupportInitialize)(this.pbox)).EndInit();
            this.ResumeLayout(false);
            this.Load += new System.EventHandler(this.frmPersonLicensesHistory_Load);
            this.Height = 600;

        }

        #endregion

        private Controls.ucDriverLicenses ucDriverLicenses1;
        private Driving_License_Management.Controls.ucPersonInfoWithFilter ucPersonInfoWithFilter1;
        private System.Windows.Forms.PictureBox pbox;
    }
}