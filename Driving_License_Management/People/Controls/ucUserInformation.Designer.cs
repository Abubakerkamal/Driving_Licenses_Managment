namespace Driving_License_Management.Controls
{
    partial class ucUserInformation
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
            this.gbUserInfo = new System.Windows.Forms.GroupBox();
            this.lbIsActive = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lbUsername = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbUserID = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ucPersonInfo1 = new Driving_License_Management.ucPersonInfo();
            this.gbUserInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbUserInfo
            // 
            this.gbUserInfo.Controls.Add(this.lbIsActive);
            this.gbUserInfo.Controls.Add(this.label6);
            this.gbUserInfo.Controls.Add(this.lbUsername);
            this.gbUserInfo.Controls.Add(this.label4);
            this.gbUserInfo.Controls.Add(this.lbUserID);
            this.gbUserInfo.Controls.Add(this.label1);
            this.gbUserInfo.Location = new System.Drawing.Point(3, 360);
            this.gbUserInfo.Name = "gbUserInfo";
            this.gbUserInfo.Size = new System.Drawing.Size(962, 100);
            this.gbUserInfo.TabIndex = 3;
            this.gbUserInfo.TabStop = false;
            this.gbUserInfo.Text = "User Info";
            // 
            // lbIsActive
            // 
            this.lbIsActive.AutoSize = true;
            this.lbIsActive.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbIsActive.Location = new System.Drawing.Point(731, 50);
            this.lbIsActive.Name = "lbIsActive";
            this.lbIsActive.Size = new System.Drawing.Size(40, 20);
            this.lbIsActive.TabIndex = 7;
            this.lbIsActive.Text = "Yes";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(590, 44);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(102, 25);
            this.label6.TabIndex = 6;
            this.label6.Text = "Is Active:";
            // 
            // lbUsername
            // 
            this.lbUsername.AutoSize = true;
            this.lbUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUsername.Location = new System.Drawing.Point(469, 51);
            this.lbUsername.Name = "lbUsername";
            this.lbUsername.Size = new System.Drawing.Size(91, 20);
            this.lbUsername.TabIndex = 5;
            this.lbUsername.Text = "Username";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(328, 45);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 25);
            this.label4.TabIndex = 4;
            this.label4.Text = "Username:";
            // 
            // lbUserID
            // 
            this.lbUserID.AutoSize = true;
            this.lbUserID.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUserID.Location = new System.Drawing.Point(207, 49);
            this.lbUserID.Name = "lbUserID";
            this.lbUserID.Size = new System.Drawing.Size(71, 20);
            this.lbUserID.TabIndex = 3;
            this.lbUserID.Text = "User ID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(66, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "User ID:";
            // 
            // ucPersonInfo1
            // 
            this.ucPersonInfo1.Location = new System.Drawing.Point(6, 24);
            this.ucPersonInfo1.Name = "ucPersonInfo1";
            this.ucPersonInfo1.Size = new System.Drawing.Size(962, 330);
            this.ucPersonInfo1.TabIndex = 4;
            // 
            // ucUserInformation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.Controls.Add(this.ucPersonInfo1);
            this.Controls.Add(this.gbUserInfo);
            this.Name = "ucUserInformation";
            this.Size = new System.Drawing.Size(968, 463);
            this.gbUserInfo.ResumeLayout(false);
            this.gbUserInfo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbUserInfo;
        private System.Windows.Forms.Label lbIsActive;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbUsername;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbUserID;
        private System.Windows.Forms.Label label1;
        private ucPersonInfo ucPersonInfo1;
        //   private ucPersonInfo ucPersonInfo1;
    }
}
