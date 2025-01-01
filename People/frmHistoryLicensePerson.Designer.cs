namespace DVLDtest.People
{
    partial class frmHistoryLicensePerson
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
            this.ucPersonalCard1 = new DVLDtest.ucPersonalCard();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabLocal = new System.Windows.Forms.TabPage();
            this.lblRecordsLocal = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvLocal = new System.Windows.Forms.DataGridView();
            this.tabInternational = new System.Windows.Forms.TabPage();
            this.lblRecordsInternational = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvInternational = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabLocal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLocal)).BeginInit();
            this.tabInternational.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInternational)).BeginInit();
            this.SuspendLayout();
            // 
            // ucPersonalCard1
            // 
            this.ucPersonalCard1.Location = new System.Drawing.Point(161, 28);
            this.ucPersonalCard1.Name = "ucPersonalCard1";
            this.ucPersonalCard1.personID = 0;
            this.ucPersonalCard1.Size = new System.Drawing.Size(667, 450);
            this.ucPersonalCard1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tabControl1);
            this.groupBox1.Location = new System.Drawing.Point(59, 498);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(911, 237);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Driver Licenses";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabLocal);
            this.tabControl1.Controls.Add(this.tabInternational);
            this.tabControl1.Location = new System.Drawing.Point(6, 36);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(884, 195);
            this.tabControl1.TabIndex = 0;
            // 
            // tabLocal
            // 
            this.tabLocal.Controls.Add(this.lblRecordsLocal);
            this.tabLocal.Controls.Add(this.label1);
            this.tabLocal.Controls.Add(this.dgvLocal);
            this.tabLocal.Location = new System.Drawing.Point(4, 28);
            this.tabLocal.Name = "tabLocal";
            this.tabLocal.Padding = new System.Windows.Forms.Padding(3);
            this.tabLocal.Size = new System.Drawing.Size(876, 163);
            this.tabLocal.TabIndex = 0;
            this.tabLocal.Text = "Local";
            this.tabLocal.UseVisualStyleBackColor = true;
            // 
            // lblRecordsLocal
            // 
            this.lblRecordsLocal.AutoSize = true;
            this.lblRecordsLocal.Location = new System.Drawing.Point(106, 135);
            this.lblRecordsLocal.Name = "lblRecordsLocal";
            this.lblRecordsLocal.Size = new System.Drawing.Size(24, 19);
            this.lblRecordsLocal.TabIndex = 2;
            this.lblRecordsLocal.Text = "...";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 134);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Records:";
            // 
            // dgvLocal
            // 
            this.dgvLocal.AllowUserToAddRows = false;
            this.dgvLocal.AllowUserToDeleteRows = false;
            this.dgvLocal.AllowUserToOrderColumns = true;
            this.dgvLocal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLocal.Location = new System.Drawing.Point(28, 24);
            this.dgvLocal.Name = "dgvLocal";
            this.dgvLocal.ReadOnly = true;
            this.dgvLocal.RowHeadersWidth = 62;
            this.dgvLocal.RowTemplate.Height = 29;
            this.dgvLocal.Size = new System.Drawing.Size(819, 103);
            this.dgvLocal.TabIndex = 0;
            // 
            // tabInternational
            // 
            this.tabInternational.Controls.Add(this.lblRecordsInternational);
            this.tabInternational.Controls.Add(this.label3);
            this.tabInternational.Controls.Add(this.dgvInternational);
            this.tabInternational.Location = new System.Drawing.Point(4, 28);
            this.tabInternational.Name = "tabInternational";
            this.tabInternational.Padding = new System.Windows.Forms.Padding(3);
            this.tabInternational.Size = new System.Drawing.Size(876, 163);
            this.tabInternational.TabIndex = 1;
            this.tabInternational.Text = "International";
            this.tabInternational.UseVisualStyleBackColor = true;
            // 
            // lblRecordsInternational
            // 
            this.lblRecordsInternational.AutoSize = true;
            this.lblRecordsInternational.Location = new System.Drawing.Point(107, 127);
            this.lblRecordsInternational.Name = "lblRecordsInternational";
            this.lblRecordsInternational.Size = new System.Drawing.Size(24, 19);
            this.lblRecordsInternational.TabIndex = 5;
            this.lblRecordsInternational.Text = "...";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 19);
            this.label3.TabIndex = 4;
            this.label3.Text = "Records:";
            // 
            // dgvInternational
            // 
            this.dgvInternational.AllowUserToAddRows = false;
            this.dgvInternational.AllowUserToDeleteRows = false;
            this.dgvInternational.AllowUserToOrderColumns = true;
            this.dgvInternational.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInternational.Location = new System.Drawing.Point(29, 16);
            this.dgvInternational.Name = "dgvInternational";
            this.dgvInternational.ReadOnly = true;
            this.dgvInternational.RowHeadersWidth = 62;
            this.dgvInternational.RowTemplate.Height = 29;
            this.dgvInternational.Size = new System.Drawing.Size(819, 103);
            this.dgvInternational.TabIndex = 3;
            // 
            // frmHistoryLicensePerson
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1015, 747);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.ucPersonalCard1);
            this.Name = "frmHistoryLicensePerson";
            this.Text = "frmHistoryLicensePerson";
            this.groupBox1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabLocal.ResumeLayout(false);
            this.tabLocal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLocal)).EndInit();
            this.tabInternational.ResumeLayout(false);
            this.tabInternational.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInternational)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ucPersonalCard ucPersonalCard1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabLocal;
        private System.Windows.Forms.TabPage tabInternational;
        private System.Windows.Forms.Label lblRecordsLocal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvLocal;
        private System.Windows.Forms.Label lblRecordsInternational;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgvInternational;
    }
}