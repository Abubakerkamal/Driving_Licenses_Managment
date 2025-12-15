namespace Driving_License_Management.Tests
{
    partial class frmTakeTest
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
            this.btnSave = new System.Windows.Forms.Button();
            this.txbNotes = new System.Windows.Forms.TextBox();
            this.rbFaild = new System.Windows.Forms.RadioButton();
            this.rbPass = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ucScheduled1 = new Driving_License_Management.Controls.ucScheduled();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(285, 639);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(98, 39);
            this.btnSave.TabIndex = 12;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txbNotes
            // 
            this.txbNotes.Location = new System.Drawing.Point(112, 563);
            this.txbNotes.Multiline = true;
            this.txbNotes.Name = "txbNotes";
            this.txbNotes.Size = new System.Drawing.Size(293, 70);
            this.txbNotes.TabIndex = 11;
            // 
            // rbFaild
            // 
            this.rbFaild.AutoSize = true;
            this.rbFaild.Location = new System.Drawing.Point(229, 520);
            this.rbFaild.Name = "rbFaild";
            this.rbFaild.Size = new System.Drawing.Size(68, 24);
            this.rbFaild.TabIndex = 10;
            this.rbFaild.TabStop = true;
            this.rbFaild.Text = "Faild";
            this.rbFaild.UseVisualStyleBackColor = true;
            // 
            // rbPass
            // 
            this.rbPass.AutoSize = true;
            this.rbPass.Location = new System.Drawing.Point(126, 520);
            this.rbPass.Name = "rbPass";
            this.rbPass.Size = new System.Drawing.Size(69, 24);
            this.rbPass.TabIndex = 9;
            this.rbPass.TabStop = true;
            this.rbPass.Text = "Pass";
            this.rbPass.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(31, 562);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 25);
            this.label2.TabIndex = 8;
            this.label2.Text = "Notes:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(31, 520);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 25);
            this.label1.TabIndex = 7;
            this.label1.Text = "Result:";
            // 
            // ucScheduled1
            // 
            this.ucScheduled1.Location = new System.Drawing.Point(36, -34);
            this.ucScheduled1.Name = "ucScheduled1";
            this.ucScheduled1.Size = new System.Drawing.Size(434, 551);
            this.ucScheduled1.TabIndex = 13;
            // 
            // frmTakeTest1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(494, 690);
            this.Controls.Add(this.ucScheduled1);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txbNotes);
            this.Controls.Add(this.rbFaild);
            this.Controls.Add(this.rbPass);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmTakeTest1";
            this.Text = "frmTakeTest1";
            this.Load += new System.EventHandler(this.frmTakeTest_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txbNotes;
        private System.Windows.Forms.RadioButton rbFaild;
        private System.Windows.Forms.RadioButton rbPass;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Controls.ucScheduled ucScheduled1;
    }
}