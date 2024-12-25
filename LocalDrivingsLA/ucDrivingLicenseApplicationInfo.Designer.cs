namespace DVLDtest.LocalDrivingsLA
{
    partial class ucDrivingLicenseApplicationInfo
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lnklblLicenseInfo = new System.Windows.Forms.LinkLabel();
            this.lblPaseedTest = new System.Windows.Forms.Label();
            this.lblClass = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblDLAID = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lnklblLicenseInfo);
            this.groupBox1.Controls.Add(this.lblPaseedTest);
            this.groupBox1.Controls.Add(this.lblClass);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.lblDLAID);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(739, 200);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Driving License Application Info";
            // 
            // lnklblLicenseInfo
            // 
            this.lnklblLicenseInfo.AutoSize = true;
            this.lnklblLicenseInfo.Location = new System.Drawing.Point(15, 120);
            this.lnklblLicenseInfo.Name = "lnklblLicenseInfo";
            this.lnklblLicenseInfo.Size = new System.Drawing.Size(138, 19);
            this.lnklblLicenseInfo.TabIndex = 6;
            this.lnklblLicenseInfo.TabStop = true;
            this.lnklblLicenseInfo.Text = "Show License Info";
            // 
            // lblPaseedTest
            // 
            this.lblPaseedTest.AutoSize = true;
            this.lblPaseedTest.Location = new System.Drawing.Point(360, 120);
            this.lblPaseedTest.Name = "lblPaseedTest";
            this.lblPaseedTest.Size = new System.Drawing.Size(33, 19);
            this.lblPaseedTest.TabIndex = 5;
            this.lblPaseedTest.Text = "0/3";
            // 
            // lblClass
            // 
            this.lblClass.AutoSize = true;
            this.lblClass.Location = new System.Drawing.Point(360, 45);
            this.lblClass.Name = "lblClass";
            this.lblClass.Size = new System.Drawing.Size(249, 19);
            this.lblClass.TabIndex = 4;
            this.lblClass.Text = "Class 3 - Ordinary Driving License";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(238, 120);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 19);
            this.label4.TabIndex = 3;
            this.label4.Text = "Passed Tests:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(201, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(153, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "Applied For License:";
            // 
            // lblDLAID
            // 
            this.lblDLAID.AutoSize = true;
            this.lblDLAID.Location = new System.Drawing.Point(112, 45);
            this.lblDLAID.Name = "lblDLAID";
            this.lblDLAID.Size = new System.Drawing.Size(27, 19);
            this.lblDLAID.TabIndex = 1;
            this.lblDLAID.Text = "50";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "DLAppID:";
            // 
            // ucDrivingLicenseApplicationInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Name = "ucDrivingLicenseApplicationInfo";
            this.Size = new System.Drawing.Size(739, 200);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel lnklblLicenseInfo;
        private System.Windows.Forms.Label lblPaseedTest;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblDLAID;
        public System.Windows.Forms.Label lblClass;
    }
}
