namespace DVLDtest.International
{
    partial class frmAddInternationalLicense
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddInternationalLicense));
            this.lnkHistory = new System.Windows.Forms.LinkLabel();
            this.lnkLicenseInfo = new System.Windows.Forms.LinkLabel();
            this.gabClose = new Guna.UI.WinForms.GunaAdvenceButton();
            this.gabIssue = new Guna.UI.WinForms.GunaAdvenceButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.mtbLicenseID = new System.Windows.Forms.MaskedTextBox();
            this.gabAddLicense = new Guna.UI.WinForms.GunaAdvenceButton();
            this.ucApplicationInfo1 = new DVLDtest.International.ucApplicationInfo();
            this.ucDriverLicense1 = new DVLDtest.LocalDrivingsLA.ucDriverLicense();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lnkHistory
            // 
            this.lnkHistory.AutoSize = true;
            this.lnkHistory.Enabled = false;
            this.lnkHistory.Location = new System.Drawing.Point(753, 587);
            this.lnkHistory.Name = "lnkHistory";
            this.lnkHistory.Size = new System.Drawing.Size(166, 19);
            this.lnkHistory.TabIndex = 2;
            this.lnkHistory.TabStop = true;
            this.lnkHistory.Text = "Show Licenses History";
            this.lnkHistory.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkHistory_LinkClicked);
            // 
            // lnkLicenseInfo
            // 
            this.lnkLicenseInfo.AutoSize = true;
            this.lnkLicenseInfo.Enabled = false;
            this.lnkLicenseInfo.Location = new System.Drawing.Point(753, 654);
            this.lnkLicenseInfo.Name = "lnkLicenseInfo";
            this.lnkLicenseInfo.Size = new System.Drawing.Size(138, 19);
            this.lnkLicenseInfo.TabIndex = 3;
            this.lnkLicenseInfo.TabStop = true;
            this.lnkLicenseInfo.Text = "Show License Info";
            // 
            // gabClose
            // 
            this.gabClose.AnimationHoverSpeed = 0.07F;
            this.gabClose.AnimationSpeed = 0.03F;
            this.gabClose.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
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
            this.gabClose.ImageSize = new System.Drawing.Size(20, 20);
            this.gabClose.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.gabClose.Location = new System.Drawing.Point(757, 808);
            this.gabClose.Name = "gabClose";
            this.gabClose.OnHoverBaseColor = System.Drawing.Color.Red;
            this.gabClose.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gabClose.OnHoverForeColor = System.Drawing.Color.White;
            this.gabClose.OnHoverImage = null;
            this.gabClose.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.gabClose.OnPressedColor = System.Drawing.Color.Black;
            this.gabClose.Size = new System.Drawing.Size(141, 42);
            this.gabClose.TabIndex = 4;
            this.gabClose.Text = "Close";
            this.gabClose.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // gabIssue
            // 
            this.gabIssue.AnimationHoverSpeed = 0.07F;
            this.gabIssue.AnimationSpeed = 0.03F;
            this.gabIssue.BaseColor = System.Drawing.Color.Gray;
            this.gabIssue.BorderColor = System.Drawing.Color.Black;
            this.gabIssue.CheckedBaseColor = System.Drawing.Color.Gray;
            this.gabIssue.CheckedBorderColor = System.Drawing.Color.Black;
            this.gabIssue.CheckedForeColor = System.Drawing.Color.White;
            this.gabIssue.CheckedImage = ((System.Drawing.Image)(resources.GetObject("gabIssue.CheckedImage")));
            this.gabIssue.CheckedLineColor = System.Drawing.Color.DimGray;
            this.gabIssue.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gabIssue.Enabled = false;
            this.gabIssue.FocusedColor = System.Drawing.Color.Empty;
            this.gabIssue.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gabIssue.ForeColor = System.Drawing.Color.White;
            this.gabIssue.Image = ((System.Drawing.Image)(resources.GetObject("gabIssue.Image")));
            this.gabIssue.ImageSize = new System.Drawing.Size(20, 20);
            this.gabIssue.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.gabIssue.Location = new System.Drawing.Point(757, 718);
            this.gabIssue.Name = "gabIssue";
            this.gabIssue.OnHoverBaseColor = System.Drawing.Color.Silver;
            this.gabIssue.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gabIssue.OnHoverForeColor = System.Drawing.Color.White;
            this.gabIssue.OnHoverImage = null;
            this.gabIssue.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.gabIssue.OnPressedColor = System.Drawing.Color.Black;
            this.gabIssue.Size = new System.Drawing.Size(141, 42);
            this.gabIssue.TabIndex = 5;
            this.gabIssue.Text = "Issue";
            this.gabIssue.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.gabIssue.Click += new System.EventHandler(this.gabIssue_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.gabAddLicense);
            this.groupBox1.Controls.Add(this.mtbLicenseID);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(153, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(503, 59);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filter";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "LicenseID";
            // 
            // mtbLicenseID
            // 
            this.mtbLicenseID.Location = new System.Drawing.Point(112, 19);
            this.mtbLicenseID.Mask = "00000000000000";
            this.mtbLicenseID.Name = "mtbLicenseID";
            this.mtbLicenseID.Size = new System.Drawing.Size(223, 27);
            this.mtbLicenseID.TabIndex = 1;
            // 
            // gabAddLicense
            // 
            this.gabAddLicense.AnimationHoverSpeed = 0.07F;
            this.gabAddLicense.AnimationSpeed = 0.03F;
            this.gabAddLicense.BaseColor = System.Drawing.Color.Transparent;
            this.gabAddLicense.BorderColor = System.Drawing.Color.Black;
            this.gabAddLicense.CheckedBaseColor = System.Drawing.Color.Gray;
            this.gabAddLicense.CheckedBorderColor = System.Drawing.Color.Black;
            this.gabAddLicense.CheckedForeColor = System.Drawing.Color.White;
            this.gabAddLicense.CheckedImage = ((System.Drawing.Image)(resources.GetObject("gabAddLicense.CheckedImage")));
            this.gabAddLicense.CheckedLineColor = System.Drawing.Color.DimGray;
            this.gabAddLicense.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gabAddLicense.FocusedColor = System.Drawing.Color.Empty;
            this.gabAddLicense.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gabAddLicense.ForeColor = System.Drawing.Color.White;
            this.gabAddLicense.Image = ((System.Drawing.Image)(resources.GetObject("gabAddLicense.Image")));
            this.gabAddLicense.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.gabAddLicense.ImageSize = new System.Drawing.Size(40, 40);
            this.gabAddLicense.LineColor = System.Drawing.Color.Transparent;
            this.gabAddLicense.Location = new System.Drawing.Point(363, 16);
            this.gabAddLicense.Name = "gabAddLicense";
            this.gabAddLicense.OnHoverBaseColor = System.Drawing.Color.Transparent;
            this.gabAddLicense.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gabAddLicense.OnHoverForeColor = System.Drawing.Color.White;
            this.gabAddLicense.OnHoverImage = null;
            this.gabAddLicense.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.gabAddLicense.OnPressedColor = System.Drawing.Color.Black;
            this.gabAddLicense.Size = new System.Drawing.Size(68, 34);
            this.gabAddLicense.TabIndex = 2;
            this.gabAddLicense.Click += new System.EventHandler(this.gunaAdvenceButton1_Click);
            // 
            // ucApplicationInfo1
            // 
            this.ucApplicationInfo1.internationalID = 0;
            this.ucApplicationInfo1.Location = new System.Drawing.Point(35, 568);
            this.ucApplicationInfo1.Name = "ucApplicationInfo1";
            this.ucApplicationInfo1.Size = new System.Drawing.Size(699, 373);
            this.ucApplicationInfo1.TabIndex = 1;
            // 
            // ucDriverLicense1
            // 
            this.ucDriverLicense1.LicenseID = 0;
            this.ucDriverLicense1.Location = new System.Drawing.Point(35, 77);
            this.ucDriverLicense1.Name = "ucDriverLicense1";
            this.ucDriverLicense1.Size = new System.Drawing.Size(926, 466);
            this.ucDriverLicense1.TabIndex = 0;
            // 
            // frmAddInternationalLicense
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1007, 911);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gabIssue);
            this.Controls.Add(this.gabClose);
            this.Controls.Add(this.lnkLicenseInfo);
            this.Controls.Add(this.lnkHistory);
            this.Controls.Add(this.ucApplicationInfo1);
            this.Controls.Add(this.ucDriverLicense1);
            this.Name = "frmAddInternationalLicense";
            this.Text = "frmAddInternationalLicense";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private LocalDrivingsLA.ucDriverLicense ucDriverLicense1;
        private ucApplicationInfo ucApplicationInfo1;
        private System.Windows.Forms.LinkLabel lnkHistory;
        private System.Windows.Forms.LinkLabel lnkLicenseInfo;
        private Guna.UI.WinForms.GunaAdvenceButton gabClose;
        private Guna.UI.WinForms.GunaAdvenceButton gabIssue;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.MaskedTextBox mtbLicenseID;
        private System.Windows.Forms.Label label1;
        private Guna.UI.WinForms.GunaAdvenceButton gabAddLicense;
    }
}