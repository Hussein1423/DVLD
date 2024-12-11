namespace DVLDtest.Users
{
    partial class ucShowUsers
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucShowUsers));
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.gabClose = new Guna.UI.WinForms.GunaAdvenceButton();
            this.gabAddPerson = new Guna.UI.WinForms.GunaAdvenceButton();
            this.lblRecords = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.mtbFliter = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbFliter = new System.Windows.Forms.ComboBox();
            this.callToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deletePersonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editPersonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addPersonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.showDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.changePasswordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.sendEmailToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dgvPeople = new System.Windows.Forms.DataGridView();
            this.cbActive = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPeople)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label4.Location = new System.Drawing.Point(438, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(217, 39);
            this.label4.TabIndex = 19;
            this.label4.Text = "Manage Users";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(509, 66);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(82, 59);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            // 
            // gabClose
            // 
            this.gabClose.AnimationHoverSpeed = 0.07F;
            this.gabClose.AnimationSpeed = 0.03F;
            this.gabClose.BaseColor = System.Drawing.SystemColors.Control;
            this.gabClose.BorderColor = System.Drawing.Color.Black;
            this.gabClose.CheckedBaseColor = System.Drawing.Color.Gray;
            this.gabClose.CheckedBorderColor = System.Drawing.Color.Black;
            this.gabClose.CheckedForeColor = System.Drawing.Color.White;
            this.gabClose.CheckedImage = ((System.Drawing.Image)(resources.GetObject("gabClose.CheckedImage")));
            this.gabClose.CheckedLineColor = System.Drawing.Color.DimGray;
            this.gabClose.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gabClose.FocusedColor = System.Drawing.Color.Empty;
            this.gabClose.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gabClose.ForeColor = System.Drawing.Color.White;
            this.gabClose.Image = ((System.Drawing.Image)(resources.GetObject("gabClose.Image")));
            this.gabClose.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.gabClose.ImageSize = new System.Drawing.Size(30, 30);
            this.gabClose.LineColor = System.Drawing.SystemColors.Control;
            this.gabClose.Location = new System.Drawing.Point(1163, 28);
            this.gabClose.Name = "gabClose";
            this.gabClose.OnHoverBaseColor = System.Drawing.SystemColors.Control;
            this.gabClose.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gabClose.OnHoverForeColor = System.Drawing.Color.White;
            this.gabClose.OnHoverImage = null;
            this.gabClose.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.gabClose.OnPressedColor = System.Drawing.Color.Black;
            this.gabClose.Size = new System.Drawing.Size(44, 42);
            this.gabClose.TabIndex = 17;
            this.gabClose.Text = "gunaAdvenceButton2";
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
            this.gabAddPerson.Location = new System.Drawing.Point(734, 58);
            this.gabAddPerson.Name = "gabAddPerson";
            this.gabAddPerson.OnHoverBaseColor = System.Drawing.Color.Green;
            this.gabAddPerson.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gabAddPerson.OnHoverForeColor = System.Drawing.Color.White;
            this.gabAddPerson.OnHoverImage = null;
            this.gabAddPerson.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.gabAddPerson.OnPressedColor = System.Drawing.Color.Black;
            this.gabAddPerson.Size = new System.Drawing.Size(158, 42);
            this.gabAddPerson.TabIndex = 16;
            this.gabAddPerson.Text = "Add User";
            this.gabAddPerson.Click += new System.EventHandler(this.gabAddPerson_Click);
            // 
            // lblRecords
            // 
            this.lblRecords.AutoSize = true;
            this.lblRecords.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecords.Location = new System.Drawing.Point(126, 474);
            this.lblRecords.Name = "lblRecords";
            this.lblRecords.Size = new System.Drawing.Size(64, 24);
            this.lblRecords.TabIndex = 15;
            this.lblRecords.Text = "label3";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(32, 474);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 24);
            this.label2.TabIndex = 14;
            this.label2.Text = "Records:";
            // 
            // mtbFliter
            // 
            this.mtbFliter.Location = new System.Drawing.Point(252, 73);
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
            this.label1.Location = new System.Drawing.Point(7, 72);
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
            "UserID",
            "PersonID",
            "Username",
            "Active"});
            this.cbFliter.Location = new System.Drawing.Point(75, 73);
            this.cbFliter.Name = "cbFliter";
            this.cbFliter.Size = new System.Drawing.Size(145, 27);
            this.cbFliter.TabIndex = 11;
            this.cbFliter.SelectedIndexChanged += new System.EventHandler(this.cbFliter_SelectedIndexChanged);
            // 
            // callToolStripMenuItem
            // 
            this.callToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("callToolStripMenuItem.Image")));
            this.callToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.callToolStripMenuItem.Name = "callToolStripMenuItem";
            this.callToolStripMenuItem.Size = new System.Drawing.Size(280, 80);
            this.callToolStripMenuItem.Text = "Call";
            this.callToolStripMenuItem.Click += new System.EventHandler(this.callToolStripMenuItem_Click);
            // 
            // deletePersonToolStripMenuItem
            // 
            this.deletePersonToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("deletePersonToolStripMenuItem.Image")));
            this.deletePersonToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.deletePersonToolStripMenuItem.Name = "deletePersonToolStripMenuItem";
            this.deletePersonToolStripMenuItem.Size = new System.Drawing.Size(280, 80);
            this.deletePersonToolStripMenuItem.Text = "Delete User";
            this.deletePersonToolStripMenuItem.Click += new System.EventHandler(this.deletePersonToolStripMenuItem_Click);
            // 
            // editPersonToolStripMenuItem
            // 
            this.editPersonToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("editPersonToolStripMenuItem.Image")));
            this.editPersonToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.editPersonToolStripMenuItem.Name = "editPersonToolStripMenuItem";
            this.editPersonToolStripMenuItem.Size = new System.Drawing.Size(296, 80);
            this.editPersonToolStripMenuItem.Text = "Edit User";
            this.editPersonToolStripMenuItem.Click += new System.EventHandler(this.editPersonToolStripMenuItem_Click);
            // 
            // addPersonToolStripMenuItem
            // 
            this.addPersonToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("addPersonToolStripMenuItem.Image")));
            this.addPersonToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.addPersonToolStripMenuItem.Name = "addPersonToolStripMenuItem";
            this.addPersonToolStripMenuItem.Size = new System.Drawing.Size(280, 80);
            this.addPersonToolStripMenuItem.Text = "Add User";
            this.addPersonToolStripMenuItem.Click += new System.EventHandler(this.addPersonToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(277, 6);
            // 
            // showDetailsToolStripMenuItem
            // 
            this.showDetailsToolStripMenuItem.AutoSize = false;
            this.showDetailsToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("showDetailsToolStripMenuItem.Image")));
            this.showDetailsToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.showDetailsToolStripMenuItem.Name = "showDetailsToolStripMenuItem";
            this.showDetailsToolStripMenuItem.Size = new System.Drawing.Size(288, 70);
            this.showDetailsToolStripMenuItem.Text = "Show Details";
            this.showDetailsToolStripMenuItem.Click += new System.EventHandler(this.showDetailsToolStripMenuItem_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showDetailsToolStripMenuItem,
            this.toolStripSeparator2,
            this.addPersonToolStripMenuItem,
            this.editPersonToolStripMenuItem,
            this.deletePersonToolStripMenuItem,
            this.changePasswordToolStripMenuItem,
            this.toolStripSeparator1,
            this.callToolStripMenuItem,
            this.sendEmailToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(297, 599);
            // 
            // changePasswordToolStripMenuItem
            // 
            this.changePasswordToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("changePasswordToolStripMenuItem.Image")));
            this.changePasswordToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.changePasswordToolStripMenuItem.Name = "changePasswordToolStripMenuItem";
            this.changePasswordToolStripMenuItem.Size = new System.Drawing.Size(280, 80);
            this.changePasswordToolStripMenuItem.Text = "Change Password";
            this.changePasswordToolStripMenuItem.Click += new System.EventHandler(this.changePasswordToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(277, 6);
            // 
            // sendEmailToolStripMenuItem
            // 
            this.sendEmailToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("sendEmailToolStripMenuItem.Image")));
            this.sendEmailToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.sendEmailToolStripMenuItem.Name = "sendEmailToolStripMenuItem";
            this.sendEmailToolStripMenuItem.Size = new System.Drawing.Size(280, 80);
            this.sendEmailToolStripMenuItem.Text = "Send Email";
            this.sendEmailToolStripMenuItem.Click += new System.EventHandler(this.sendEmailToolStripMenuItem_Click);
            // 
            // dgvPeople
            // 
            this.dgvPeople.AllowUserToAddRows = false;
            this.dgvPeople.AllowUserToDeleteRows = false;
            this.dgvPeople.AllowUserToOrderColumns = true;
            this.dgvPeople.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvPeople.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPeople.ContextMenuStrip = this.contextMenuStrip1;
            this.dgvPeople.Location = new System.Drawing.Point(3, 146);
            this.dgvPeople.Name = "dgvPeople";
            this.dgvPeople.ReadOnly = true;
            this.dgvPeople.RowHeadersWidth = 62;
            this.dgvPeople.RowTemplate.Height = 29;
            this.dgvPeople.Size = new System.Drawing.Size(907, 315);
            this.dgvPeople.TabIndex = 10;
            // 
            // cbActive
            // 
            this.cbActive.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbActive.FormattingEnabled = true;
            this.cbActive.Items.AddRange(new object[] {
            "All",
            "Active",
            "Not Active"});
            this.cbActive.Location = new System.Drawing.Point(252, 73);
            this.cbActive.Name = "cbActive";
            this.cbActive.Size = new System.Drawing.Size(173, 27);
            this.cbActive.TabIndex = 20;
            this.cbActive.Visible = false;
            this.cbActive.SelectedIndexChanged += new System.EventHandler(this.cbActive_SelectedIndexChanged);
            // 
            // ucShowUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.cbActive);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.gabClose);
            this.Controls.Add(this.gabAddPerson);
            this.Controls.Add(this.lblRecords);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.mtbFliter);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbFliter);
            this.Controls.Add(this.dgvPeople);
            this.Name = "ucShowUsers";
            this.Size = new System.Drawing.Size(910, 549);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPeople)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Guna.UI.WinForms.GunaAdvenceButton gabClose;
        private Guna.UI.WinForms.GunaAdvenceButton gabAddPerson;
        private System.Windows.Forms.Label lblRecords;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox mtbFliter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbFliter;
        private System.Windows.Forms.ToolStripMenuItem callToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deletePersonToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editPersonToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addPersonToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem showDetailsToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem sendEmailToolStripMenuItem;
        private System.Windows.Forms.DataGridView dgvPeople;
        private System.Windows.Forms.ComboBox cbActive;
        private System.Windows.Forms.ToolStripMenuItem changePasswordToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
    }
}
