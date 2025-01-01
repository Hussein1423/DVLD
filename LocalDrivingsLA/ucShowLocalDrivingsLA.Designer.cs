namespace DVLDtest.LocalDrivingsLA
{
    partial class ucShowLocalDrivingsLA
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucShowLocalDrivingsLA));
            this.label4 = new System.Windows.Forms.Label();
            this.lblRecords = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.mtbFliter = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbFliter = new System.Windows.Forms.ComboBox();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.showApplicationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteApplicationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.EditApplicationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.CancelApplicationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.visionTestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.writtenTestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.streetTestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.IssueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ShowLicenseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.showPersonLicenseHistoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dgvLocalDrivingsLA = new System.Windows.Forms.DataGridView();
            this.gabAddPerson = new Guna.UI.WinForms.GunaAdvenceButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLocalDrivingsLA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label4.Location = new System.Drawing.Point(302, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(339, 39);
            this.label4.TabIndex = 18;
            this.label4.Text = "Manage Local Licenses";
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
            // mtbFliter
            // 
            this.mtbFliter.Location = new System.Drawing.Point(254, 86);
            this.mtbFliter.Name = "mtbFliter";
            this.mtbFliter.Size = new System.Drawing.Size(173, 27);
            this.mtbFliter.TabIndex = 13;
            this.mtbFliter.Visible = false;
            this.mtbFliter.TextChanged += new System.EventHandler(this.mtbFliter_TextChanged);
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
            // cbFliter
            // 
            this.cbFliter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFliter.FormattingEnabled = true;
            this.cbFliter.Items.AddRange(new object[] {
            "LocalDrivingLAID",
            "Class",
            "Name ",
            "State"});
            this.cbFliter.Location = new System.Drawing.Point(75, 86);
            this.cbFliter.Name = "cbFliter";
            this.cbFliter.Size = new System.Drawing.Size(145, 27);
            this.cbFliter.TabIndex = 11;
            this.cbFliter.SelectedIndexChanged += new System.EventHandler(this.cbFliter_SelectedIndexChanged);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(392, 6);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(392, 6);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showApplicationToolStripMenuItem,
            this.toolStripSeparator2,
            this.deleteApplicationToolStripMenuItem,
            this.EditApplicationToolStripMenuItem,
            this.toolStripSeparator3,
            this.CancelApplicationToolStripMenuItem,
            this.toolStripSeparator1,
            this.TestToolStripMenuItem,
            this.toolStripSeparator4,
            this.IssueToolStripMenuItem,
            this.ShowLicenseToolStripMenuItem,
            this.toolStripSeparator5,
            this.showPersonLicenseHistoryToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(396, 701);
            // 
            // showApplicationToolStripMenuItem
            // 
            this.showApplicationToolStripMenuItem.AutoSize = false;
            this.showApplicationToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("showApplicationToolStripMenuItem.Image")));
            this.showApplicationToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.showApplicationToolStripMenuItem.Name = "showApplicationToolStripMenuItem";
            this.showApplicationToolStripMenuItem.Size = new System.Drawing.Size(288, 70);
            this.showApplicationToolStripMenuItem.Text = "Show Application Details";
            // 
            // deleteApplicationToolStripMenuItem
            // 
            this.deleteApplicationToolStripMenuItem.AutoSize = false;
            this.deleteApplicationToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("deleteApplicationToolStripMenuItem.Image")));
            this.deleteApplicationToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.deleteApplicationToolStripMenuItem.Name = "deleteApplicationToolStripMenuItem";
            this.deleteApplicationToolStripMenuItem.Size = new System.Drawing.Size(329, 72);
            this.deleteApplicationToolStripMenuItem.Text = "Delete Application";
            // 
            // EditApplicationToolStripMenuItem
            // 
            this.EditApplicationToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("EditApplicationToolStripMenuItem.Image")));
            this.EditApplicationToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.EditApplicationToolStripMenuItem.Name = "EditApplicationToolStripMenuItem";
            this.EditApplicationToolStripMenuItem.Size = new System.Drawing.Size(395, 82);
            this.EditApplicationToolStripMenuItem.Text = "Edit Application";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(392, 6);
            // 
            // CancelApplicationToolStripMenuItem
            // 
            this.CancelApplicationToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("CancelApplicationToolStripMenuItem.Image")));
            this.CancelApplicationToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.CancelApplicationToolStripMenuItem.Name = "CancelApplicationToolStripMenuItem";
            this.CancelApplicationToolStripMenuItem.Size = new System.Drawing.Size(395, 82);
            this.CancelApplicationToolStripMenuItem.Text = "Canceled";
            this.CancelApplicationToolStripMenuItem.Click += new System.EventHandler(this.deletePersonToolStripMenuItem_Click);
            // 
            // TestToolStripMenuItem
            // 
            this.TestToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.visionTestToolStripMenuItem,
            this.writtenTestToolStripMenuItem,
            this.streetTestToolStripMenuItem});
            this.TestToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("TestToolStripMenuItem.Image")));
            this.TestToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.TestToolStripMenuItem.Name = "TestToolStripMenuItem";
            this.TestToolStripMenuItem.Size = new System.Drawing.Size(395, 82);
            this.TestToolStripMenuItem.Text = "Test";
            // 
            // visionTestToolStripMenuItem
            // 
            this.visionTestToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("visionTestToolStripMenuItem.Image")));
            this.visionTestToolStripMenuItem.Name = "visionTestToolStripMenuItem";
            this.visionTestToolStripMenuItem.Size = new System.Drawing.Size(207, 34);
            this.visionTestToolStripMenuItem.Text = "Vision Test";
            this.visionTestToolStripMenuItem.Click += new System.EventHandler(this.visionTestToolStripMenuItem_Click);
            // 
            // writtenTestToolStripMenuItem
            // 
            this.writtenTestToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("writtenTestToolStripMenuItem.Image")));
            this.writtenTestToolStripMenuItem.Name = "writtenTestToolStripMenuItem";
            this.writtenTestToolStripMenuItem.Size = new System.Drawing.Size(207, 34);
            this.writtenTestToolStripMenuItem.Text = "Written Test";
            this.writtenTestToolStripMenuItem.Click += new System.EventHandler(this.writtenTestToolStripMenuItem_Click);
            // 
            // streetTestToolStripMenuItem
            // 
            this.streetTestToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("streetTestToolStripMenuItem.Image")));
            this.streetTestToolStripMenuItem.Name = "streetTestToolStripMenuItem";
            this.streetTestToolStripMenuItem.Size = new System.Drawing.Size(207, 34);
            this.streetTestToolStripMenuItem.Text = "Street Test";
            this.streetTestToolStripMenuItem.Click += new System.EventHandler(this.streetTestToolStripMenuItem_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(392, 6);
            // 
            // IssueToolStripMenuItem
            // 
            this.IssueToolStripMenuItem.AutoSize = false;
            this.IssueToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("IssueToolStripMenuItem.Image")));
            this.IssueToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.IssueToolStripMenuItem.Name = "IssueToolStripMenuItem";
            this.IssueToolStripMenuItem.Size = new System.Drawing.Size(395, 82);
            this.IssueToolStripMenuItem.Text = "Issue Driving License (First Time)";
            this.IssueToolStripMenuItem.Click += new System.EventHandler(this.sendEmailToolStripMenuItem_Click);
            // 
            // ShowLicenseToolStripMenuItem
            // 
            this.ShowLicenseToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("ShowLicenseToolStripMenuItem.Image")));
            this.ShowLicenseToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ShowLicenseToolStripMenuItem.Name = "ShowLicenseToolStripMenuItem";
            this.ShowLicenseToolStripMenuItem.Size = new System.Drawing.Size(395, 82);
            this.ShowLicenseToolStripMenuItem.Text = "Show License";
            this.ShowLicenseToolStripMenuItem.Click += new System.EventHandler(this.callToolStripMenuItem_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(392, 6);
            // 
            // showPersonLicenseHistoryToolStripMenuItem
            // 
            this.showPersonLicenseHistoryToolStripMenuItem.AutoSize = false;
            this.showPersonLicenseHistoryToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("showPersonLicenseHistoryToolStripMenuItem.Image")));
            this.showPersonLicenseHistoryToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.showPersonLicenseHistoryToolStripMenuItem.Name = "showPersonLicenseHistoryToolStripMenuItem";
            this.showPersonLicenseHistoryToolStripMenuItem.Size = new System.Drawing.Size(395, 82);
            this.showPersonLicenseHistoryToolStripMenuItem.Text = "Show Person License History";
            this.showPersonLicenseHistoryToolStripMenuItem.Click += new System.EventHandler(this.showPersonLicenseHistoryToolStripMenuItem_Click);
            // 
            // dgvLocalDrivingsLA
            // 
            this.dgvLocalDrivingsLA.AllowUserToAddRows = false;
            this.dgvLocalDrivingsLA.AllowUserToDeleteRows = false;
            this.dgvLocalDrivingsLA.AllowUserToOrderColumns = true;
            this.dgvLocalDrivingsLA.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvLocalDrivingsLA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLocalDrivingsLA.ContextMenuStrip = this.contextMenuStrip1;
            this.dgvLocalDrivingsLA.Location = new System.Drawing.Point(0, 135);
            this.dgvLocalDrivingsLA.Name = "dgvLocalDrivingsLA";
            this.dgvLocalDrivingsLA.ReadOnly = true;
            this.dgvLocalDrivingsLA.RowHeadersWidth = 62;
            this.dgvLocalDrivingsLA.RowTemplate.Height = 29;
            this.dgvLocalDrivingsLA.Size = new System.Drawing.Size(903, 315);
            this.dgvLocalDrivingsLA.TabIndex = 10;
            this.dgvLocalDrivingsLA.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvLocalDrivingsLA_CellMouseDown);
            // 
            // gabAddPerson
            // 
            this.gabAddPerson.AnimationHoverSpeed = 0.07F;
            this.gabAddPerson.AnimationSpeed = 0.03F;
            this.gabAddPerson.BaseColor = System.Drawing.Color.Green;
            this.gabAddPerson.BorderColor = System.Drawing.Color.Black;
            this.gabAddPerson.CheckedBaseColor = System.Drawing.Color.Gray;
            this.gabAddPerson.CheckedBorderColor = System.Drawing.Color.Black;
            this.gabAddPerson.CheckedForeColor = System.Drawing.Color.White;
            this.gabAddPerson.CheckedImage = ((System.Drawing.Image)(resources.GetObject("gabAddPerson.CheckedImage")));
            this.gabAddPerson.CheckedLineColor = System.Drawing.Color.DimGray;
            this.gabAddPerson.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gabAddPerson.FocusedColor = System.Drawing.Color.Empty;
            this.gabAddPerson.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gabAddPerson.ForeColor = System.Drawing.Color.White;
            this.gabAddPerson.Image = ((System.Drawing.Image)(resources.GetObject("gabAddPerson.Image")));
            this.gabAddPerson.ImageSize = new System.Drawing.Size(20, 20);
            this.gabAddPerson.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.gabAddPerson.Location = new System.Drawing.Point(734, 71);
            this.gabAddPerson.Name = "gabAddPerson";
            this.gabAddPerson.OnHoverBaseColor = System.Drawing.Color.Green;
            this.gabAddPerson.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gabAddPerson.OnHoverForeColor = System.Drawing.Color.White;
            this.gabAddPerson.OnHoverImage = null;
            this.gabAddPerson.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.gabAddPerson.OnPressedColor = System.Drawing.Color.Black;
            this.gabAddPerson.Size = new System.Drawing.Size(158, 42);
            this.gabAddPerson.TabIndex = 16;
            this.gabAddPerson.Text = "Add Local";
            this.gabAddPerson.Click += new System.EventHandler(this.gabAddPerson_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(455, 54);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(82, 59);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // ucShowLocalDrivingsLA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label4);
            this.Controls.Add(this.gabAddPerson);
            this.Controls.Add(this.lblRecords);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.mtbFliter);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbFliter);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dgvLocalDrivingsLA);
            this.Name = "ucShowLocalDrivingsLA";
            this.Size = new System.Drawing.Size(903, 510);
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLocalDrivingsLA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private Guna.UI.WinForms.GunaAdvenceButton gabAddPerson;
        private System.Windows.Forms.Label lblRecords;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox mtbFliter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbFliter;
        private System.Windows.Forms.ToolStripMenuItem ShowLicenseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem IssueToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem CancelApplicationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem TestToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem EditApplicationToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem showApplicationToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dgvLocalDrivingsLA;
        private System.Windows.Forms.ToolStripMenuItem visionTestToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem writtenTestToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem streetTestToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem deleteApplicationToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem showPersonLicenseHistoryToolStripMenuItem;
    }
}
