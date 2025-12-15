namespace Driving_License_Management.Tests
{
    partial class frmAddUpdateTestAppointment
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
            this.ucSchedule1 = new Driving_License_Management.Controls.ucSchedule();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.AutoEllipsis = true;
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.Location = new System.Drawing.Point(193, 727);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(135, 36);
            this.btnClose.TabIndex = 137;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // ucSchedule1
            // 
            this.ucSchedule1.Location = new System.Drawing.Point(0, 3);
            this.ucSchedule1.Name = "ucSchedule1";
            this.ucSchedule1.Size = new System.Drawing.Size(552, 718);
            this.ucSchedule1.TabIndex = 0;
            // 
            // frmAddTestAppointment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(552, 768);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.ucSchedule1);
            this.Name = "frmAddTestAppointment";
            this.Text = "Add Appointment";
            this.Load += new System.EventHandler(this.frmAddTestAppointment_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Controls.ucSchedule ucSchedule1;
        private System.Windows.Forms.Button btnClose;
    }
}