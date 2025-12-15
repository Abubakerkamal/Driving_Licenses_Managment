namespace Driving_License_Management
{
    partial class Test
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
            this.ucSchedule1 = new Driving_License_Management.Controls.ucSchedule();
            this.SuspendLayout();
            // 
            // ucSchedule1
            // 
            this.ucSchedule1.Location = new System.Drawing.Point(203, 65);
            this.ucSchedule1.Name = "ucSchedule1";
            this.ucSchedule1.Size = new System.Drawing.Size(552, 718);
            this.ucSchedule1.TabIndex = 0;
            // 
            // Test
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1038, 795);
            this.Controls.Add(this.ucSchedule1);
            this.Name = "Test";
            this.Text = "Test";
            this.Load += new System.EventHandler(this.Test_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Controls.ucSchedule ucSchedule1;
    }
}