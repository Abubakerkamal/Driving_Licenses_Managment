namespace Driving_License_Management.People
{
    partial class frmFindPerson
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.ucPersonInfoWithFilter1 = new Driving_License_Management.Controls.ucPersonInfoWithFilter();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(344, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(339, 64);
            this.label1.TabIndex = 87;
            this.label1.Text = "Find Person";
            // 
            // btnClose
            // 
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnClose.Image = global::Driving_License_Management.Properties.Resources.Close_32;
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnClose.Location = new System.Drawing.Point(862, 582);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(148, 49);
            this.btnClose.TabIndex = 88;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click_1);
            // 
            // ucPersonInfoWithFilter1
            // 
            this.ucPersonInfoWithFilter1.BackColor = System.Drawing.SystemColors.Window;
            this.ucPersonInfoWithFilter1.FilterEnabeled = true;
            this.ucPersonInfoWithFilter1.Location = new System.Drawing.Point(40, 126);
            this.ucPersonInfoWithFilter1.Name = "ucPersonInfoWithFilter1";
            this.ucPersonInfoWithFilter1.ShowBtnAddPerson = true;
            this.ucPersonInfoWithFilter1.Size = new System.Drawing.Size(970, 439);
            this.ucPersonInfoWithFilter1.TabIndex = 0;
            // 
            // frmFindPerson
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1051, 643);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ucPersonInfoWithFilter1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "frmFindPerson";
            this.Text = "frmFindPerson";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Controls.ucPersonInfoWithFilter ucPersonInfoWithFilter1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnClose;
    }
}