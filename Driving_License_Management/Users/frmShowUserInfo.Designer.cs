namespace Driving_License_Management.Users
{
    partial class frmShowUserInfo
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
            this.ucUserInformation1 = new Driving_License_Management.Controls.ucUserInformation();
            this.SuspendLayout();
            // 
            // ucUserInformation1
            // 
            this.ucUserInformation1.BackColor = System.Drawing.SystemColors.Window;
            this.ucUserInformation1.Location = new System.Drawing.Point(1, -1);
            this.ucUserInformation1.Name = "ucUserInformation1";
            this.ucUserInformation1.Size = new System.Drawing.Size(968, 463);
            this.ucUserInformation1.TabIndex = 0;
            // 
            // frmShowUserInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(970, 466);
            this.Controls.Add(this.ucUserInformation1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "frmShowUserInfo";
            this.Text = "User Information";
            this.ResumeLayout(false);

        }

        #endregion

        private Controls.ucUserInformation ucUserInformation1;
    }
}