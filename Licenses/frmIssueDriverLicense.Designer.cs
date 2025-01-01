namespace DVLDtest.Licenses
{
    partial class frmIssueDriverLicense
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmIssueDriverLicense));
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.gabSave = new Guna.UI.WinForms.GunaAdvenceButton();
            this.gabClose = new Guna.UI.WinForms.GunaAdvenceButton();
            this.ucApplicationBasicInfo1 = new DVLDtest.Applications.ucApplicationBasicInfo();
            this.ucDrivingLicenseApplicationInfo1 = new DVLDtest.LocalDrivingsLA.ucDrivingLicenseApplicationInfo();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 616);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 19);
            this.label1.TabIndex = 2;
            this.label1.Text = "Notes:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(107, 616);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(854, 135);
            this.textBox1.TabIndex = 3;
            // 
            // gabSave
            // 
            this.gabSave.AnimationHoverSpeed = 0.07F;
            this.gabSave.AnimationSpeed = 0.03F;
            this.gabSave.BaseColor = System.Drawing.Color.Silver;
            this.gabSave.BorderColor = System.Drawing.Color.Black;
            this.gabSave.CheckedBaseColor = System.Drawing.Color.Gray;
            this.gabSave.CheckedBorderColor = System.Drawing.Color.Black;
            this.gabSave.CheckedForeColor = System.Drawing.Color.White;
            this.gabSave.CheckedImage = ((System.Drawing.Image)(resources.GetObject("gabSave.CheckedImage")));
            this.gabSave.CheckedLineColor = System.Drawing.Color.DimGray;
            this.gabSave.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gabSave.FocusedColor = System.Drawing.Color.Empty;
            this.gabSave.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gabSave.ForeColor = System.Drawing.Color.White;
            this.gabSave.Image = ((System.Drawing.Image)(resources.GetObject("gabSave.Image")));
            this.gabSave.ImageSize = new System.Drawing.Size(20, 20);
            this.gabSave.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.gabSave.Location = new System.Drawing.Point(781, 797);
            this.gabSave.Name = "gabSave";
            this.gabSave.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.gabSave.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gabSave.OnHoverForeColor = System.Drawing.Color.White;
            this.gabSave.OnHoverImage = null;
            this.gabSave.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.gabSave.OnPressedColor = System.Drawing.Color.Black;
            this.gabSave.Size = new System.Drawing.Size(180, 42);
            this.gabSave.TabIndex = 5;
            this.gabSave.Text = "Save";
            this.gabSave.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.gabSave.Click += new System.EventHandler(this.gabSave_Click);
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
            this.gabClose.Location = new System.Drawing.Point(565, 797);
            this.gabClose.Name = "gabClose";
            this.gabClose.OnHoverBaseColor = System.Drawing.Color.Red;
            this.gabClose.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gabClose.OnHoverForeColor = System.Drawing.Color.White;
            this.gabClose.OnHoverImage = null;
            this.gabClose.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.gabClose.OnPressedColor = System.Drawing.Color.Black;
            this.gabClose.Size = new System.Drawing.Size(180, 42);
            this.gabClose.TabIndex = 4;
            this.gabClose.Text = "Close";
            this.gabClose.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.gabClose.Click += new System.EventHandler(this.gabClose_Click);
            // 
            // ucApplicationBasicInfo1
            // 
            this.ucApplicationBasicInfo1.Location = new System.Drawing.Point(31, 274);
            this.ucApplicationBasicInfo1.Name = "ucApplicationBasicInfo1";
            this.ucApplicationBasicInfo1.Size = new System.Drawing.Size(930, 300);
            this.ucApplicationBasicInfo1.TabIndex = 1;
            // 
            // ucDrivingLicenseApplicationInfo1
            // 
            this.ucDrivingLicenseApplicationInfo1.Location = new System.Drawing.Point(31, 51);
            this.ucDrivingLicenseApplicationInfo1.Name = "ucDrivingLicenseApplicationInfo1";
            this.ucDrivingLicenseApplicationInfo1.Size = new System.Drawing.Size(739, 200);
            this.ucDrivingLicenseApplicationInfo1.TabIndex = 0;
            // 
            // frmIssueDriverLicense
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 862);
            this.Controls.Add(this.gabSave);
            this.Controls.Add(this.gabClose);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ucApplicationBasicInfo1);
            this.Controls.Add(this.ucDrivingLicenseApplicationInfo1);
            this.Name = "frmIssueDriverLicense";
            this.Text = "frmIssueDriverLicense";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmIssueDriverLicense_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private LocalDrivingsLA.ucDrivingLicenseApplicationInfo ucDrivingLicenseApplicationInfo1;
        private Applications.ucApplicationBasicInfo ucApplicationBasicInfo1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private Guna.UI.WinForms.GunaAdvenceButton gabClose;
        private Guna.UI.WinForms.GunaAdvenceButton gabSave;
    }
}