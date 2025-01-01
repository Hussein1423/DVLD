namespace DVLDtest.Drivers
{
    partial class ucShowDrivers
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucShowDrivers));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dgvDrivers = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.cbFliter = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.mtbFliter = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblRecords = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDrivers)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(474, 54);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(82, 59);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // dgvDrivers
            // 
            this.dgvDrivers.AllowUserToAddRows = false;
            this.dgvDrivers.AllowUserToDeleteRows = false;
            this.dgvDrivers.AllowUserToOrderColumns = true;
            this.dgvDrivers.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDrivers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDrivers.Location = new System.Drawing.Point(0, 135);
            this.dgvDrivers.Name = "dgvDrivers";
            this.dgvDrivers.ReadOnly = true;
            this.dgvDrivers.RowHeadersWidth = 62;
            this.dgvDrivers.RowTemplate.Height = 29;
            this.dgvDrivers.Size = new System.Drawing.Size(903, 315);
            this.dgvDrivers.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label4.Location = new System.Drawing.Point(398, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(239, 39);
            this.label4.TabIndex = 18;
            this.label4.Text = "Manage Drivers";
            // 
            // cbFliter
            // 
            this.cbFliter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFliter.FormattingEnabled = true;
            this.cbFliter.Items.AddRange(new object[] {
            "PersonID",
            "NationalNo",
            "FirstName",
            "SecondName",
            "LastName",
            "Phone",
            "Email"});
            this.cbFliter.Location = new System.Drawing.Point(75, 86);
            this.cbFliter.Name = "cbFliter";
            this.cbFliter.Size = new System.Drawing.Size(145, 27);
            this.cbFliter.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 24);
            this.label1.TabIndex = 12;
            this.label1.Text = "Fliter:";
            // 
            // mtbFliter
            // 
            this.mtbFliter.Location = new System.Drawing.Point(252, 86);
            this.mtbFliter.Name = "mtbFliter";
            this.mtbFliter.Size = new System.Drawing.Size(173, 27);
            this.mtbFliter.TabIndex = 13;
            this.mtbFliter.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 472);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 24);
            this.label2.TabIndex = 14;
            this.label2.Text = "Records:";
            // 
            // lblRecords
            // 
            this.lblRecords.AutoSize = true;
            this.lblRecords.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecords.Location = new System.Drawing.Point(97, 472);
            this.lblRecords.Name = "lblRecords";
            this.lblRecords.Size = new System.Drawing.Size(64, 24);
            this.lblRecords.TabIndex = 15;
            this.lblRecords.Text = "label3";
            // 
            // ucShowDrivers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblRecords);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.mtbFliter);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbFliter);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dgvDrivers);
            this.Name = "ucShowDrivers";
            this.Size = new System.Drawing.Size(903, 510);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDrivers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dgvDrivers;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbFliter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox mtbFliter;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblRecords;
    }
}
