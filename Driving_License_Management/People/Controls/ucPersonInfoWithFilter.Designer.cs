namespace Driving_License_Management.Controls
{
    partial class ucPersonInfoWithFilter
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucPersonInfoWithFilter));
            this.gbFilter = new System.Windows.Forms.GroupBox();
            this.btnAddNewPerson = new System.Windows.Forms.Button();
            this.cmpFindby = new System.Windows.Forms.ComboBox();
            this.btnFind = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtFilterValue = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.ucPersonInfo1 = new Driving_License_Management.ucPersonInfo();
            this.gbFilter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // gbFilter
            // 
            this.gbFilter.Controls.Add(this.btnAddNewPerson);
            this.gbFilter.Controls.Add(this.cmpFindby);
            this.gbFilter.Controls.Add(this.btnFind);
            this.gbFilter.Controls.Add(this.label2);
            this.gbFilter.Controls.Add(this.txtFilterValue);
            this.gbFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbFilter.Location = new System.Drawing.Point(48, 20);
            this.gbFilter.Name = "gbFilter";
            this.gbFilter.Size = new System.Drawing.Size(867, 80);
            this.gbFilter.TabIndex = 0;
            this.gbFilter.TabStop = false;
            this.gbFilter.Text = "Filter";
            this.gbFilter.Enter += new System.EventHandler(this.gbFilter_Enter);
            // 
            // btnAddNewPerson
            // 
            this.btnAddNewPerson.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAddNewPerson.BackgroundImage")));
            this.btnAddNewPerson.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnAddNewPerson.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAddNewPerson.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddNewPerson.Location = new System.Drawing.Point(696, 22);
            this.btnAddNewPerson.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAddNewPerson.Name = "btnAddNewPerson";
            this.btnAddNewPerson.Size = new System.Drawing.Size(54, 50);
            this.btnAddNewPerson.TabIndex = 20;
            this.btnAddNewPerson.UseVisualStyleBackColor = true;
            this.btnAddNewPerson.Click += new System.EventHandler(this.btnAddNewPerson_Click);
            // 
            // cmpFindby
            // 
            this.cmpFindby.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmpFindby.FormattingEnabled = true;
            this.cmpFindby.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cmpFindby.Items.AddRange(new object[] {
            "Person ID",
            "National No"});
            this.cmpFindby.Location = new System.Drawing.Point(163, 31);
            this.cmpFindby.Name = "cmpFindby";
            this.cmpFindby.Size = new System.Drawing.Size(215, 28);
            this.cmpFindby.TabIndex = 1;
            this.cmpFindby.SelectedIndexChanged += new System.EventHandler(this.cmpFindby_SelectedIndexChanged);
            // 
            // btnFind
            // 
            this.btnFind.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnFind.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnFind.BackgroundImage")));
            this.btnFind.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnFind.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFind.Location = new System.Drawing.Point(635, 22);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(54, 50);
            this.btnFind.TabIndex = 18;
            this.btnFind.UseVisualStyleBackColor = true;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(50, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 26);
            this.label2.TabIndex = 0;
            this.label2.Text = "Find BY";
            // 
            // txtFilterValue
            // 
            this.txtFilterValue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFilterValue.Location = new System.Drawing.Point(397, 33);
            this.txtFilterValue.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtFilterValue.Name = "txtFilterValue";
            this.txtFilterValue.Size = new System.Drawing.Size(214, 26);
            this.txtFilterValue.TabIndex = 17;
            this.txtFilterValue.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFilterValue_KeyPress);
            this.txtFilterValue.Validating += new System.ComponentModel.CancelEventHandler(this.txtFilterValue_Validating);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // ucPersonInfo1
            // 
            this.ucPersonInfo1.Location = new System.Drawing.Point(5, 121);
            this.ucPersonInfo1.Name = "ucPersonInfo1";
            this.ucPersonInfo1.Size = new System.Drawing.Size(962, 330);
            this.ucPersonInfo1.TabIndex = 1;
            // 
            // ucPersonInfoWithFilter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.Controls.Add(this.ucPersonInfo1);
            this.Controls.Add(this.gbFilter);
            this.Name = "ucPersonInfoWithFilter";
            this.Size = new System.Drawing.Size(970, 504);
            this.Load += new System.EventHandler(this.ucPersonInfoWithFilter_Load);
            this.gbFilter.ResumeLayout(false);
            this.gbFilter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbFilter;
        private System.Windows.Forms.ComboBox cmpFindby;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAddNewPerson;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.TextBox txtFilterValue;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private ucPersonInfo ucPersonInfo1;
        //private ucPersonInfo ucPersonInfo1;
    }
}
