namespace DVLDtest.Appoiniments.Written
{
    partial class frmScheduleWrittenTest
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmScheduleWrittenTest));
            this.lblAppointmentID = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.gdtpDate = new Guna.UI.WinForms.GunaDateTimePicker();
            this.gbRetake = new System.Windows.Forms.GroupBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.lblTotalFees = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.lblAppFees = new System.Windows.Forms.Label();
            this.label = new System.Windows.Forms.Label();
            this.lblFees = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblClass = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblDIAppID = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gabClose = new Guna.UI.WinForms.GunaButton();
            this.gabSave = new Guna.UI.WinForms.GunaButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.gbRetake.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblAppointmentID
            // 
            this.lblAppointmentID.AutoSize = true;
            this.lblAppointmentID.Location = new System.Drawing.Point(158, 510);
            this.lblAppointmentID.Name = "lblAppointmentID";
            this.lblAppointmentID.Size = new System.Drawing.Size(67, 19);
            this.lblAppointmentID.TabIndex = 33;
            this.lblAppointmentID.Text = "Unkown";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 510);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 19);
            this.label2.TabIndex = 32;
            this.label2.Text = "AppointmentID:";
            // 
            // gdtpDate
            // 
            this.gdtpDate.BaseColor = System.Drawing.Color.White;
            this.gdtpDate.BorderColor = System.Drawing.Color.Silver;
            this.gdtpDate.CustomFormat = null;
            this.gdtpDate.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.gdtpDate.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gdtpDate.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gdtpDate.ForeColor = System.Drawing.Color.Black;
            this.gdtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.gdtpDate.Location = new System.Drawing.Point(157, 381);
            this.gdtpDate.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.gdtpDate.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.gdtpDate.Name = "gdtpDate";
            this.gdtpDate.OnHoverBaseColor = System.Drawing.Color.White;
            this.gdtpDate.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gdtpDate.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gdtpDate.OnPressedColor = System.Drawing.Color.Black;
            this.gdtpDate.Size = new System.Drawing.Size(223, 30);
            this.gdtpDate.TabIndex = 31;
            this.gdtpDate.Text = "12/22/2024";
            this.gdtpDate.Value = new System.DateTime(2024, 12, 22, 20, 25, 32, 317);
            // 
            // gbRetake
            // 
            this.gbRetake.Controls.Add(this.label16);
            this.gbRetake.Controls.Add(this.label15);
            this.gbRetake.Controls.Add(this.lblTotalFees);
            this.gbRetake.Controls.Add(this.label13);
            this.gbRetake.Controls.Add(this.lblAppFees);
            this.gbRetake.Controls.Add(this.label);
            this.gbRetake.Enabled = false;
            this.gbRetake.Location = new System.Drawing.Point(55, 563);
            this.gbRetake.Name = "gbRetake";
            this.gbRetake.Size = new System.Drawing.Size(465, 109);
            this.gbRetake.TabIndex = 28;
            this.gbRetake.TabStop = false;
            this.gbRetake.Text = "Retake Test Info";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(108, 77);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(37, 19);
            this.label16.TabIndex = 17;
            this.label16.Text = "N/A";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(6, 77);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(101, 19);
            this.label15.TabIndex = 16;
            this.label15.Text = "Test App ID:";
            // 
            // lblTotalFees
            // 
            this.lblTotalFees.AutoSize = true;
            this.lblTotalFees.Location = new System.Drawing.Point(373, 39);
            this.lblTotalFees.Name = "lblTotalFees";
            this.lblTotalFees.Size = new System.Drawing.Size(27, 19);
            this.lblTotalFees.TabIndex = 15;
            this.lblTotalFees.Text = "10";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(275, 39);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(87, 19);
            this.label13.TabIndex = 14;
            this.label13.Text = "Total Fees:";
            // 
            // lblAppFees
            // 
            this.lblAppFees.AutoSize = true;
            this.lblAppFees.Location = new System.Drawing.Point(108, 39);
            this.lblAppFees.Name = "lblAppFees";
            this.lblAppFees.Size = new System.Drawing.Size(18, 19);
            this.lblAppFees.TabIndex = 13;
            this.lblAppFees.Text = "0";
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(6, 39);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(80, 19);
            this.label.TabIndex = 12;
            this.label.Text = "App Fees:";
            // 
            // lblFees
            // 
            this.lblFees.AutoSize = true;
            this.lblFees.Location = new System.Drawing.Point(163, 451);
            this.lblFees.Name = "lblFees";
            this.lblFees.Size = new System.Drawing.Size(27, 19);
            this.lblFees.TabIndex = 27;
            this.lblFees.Text = "20";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(51, 378);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(47, 19);
            this.label8.TabIndex = 25;
            this.label8.Text = "Date:";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(153, 322);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(200, 19);
            this.lblName.TabIndex = 24;
            this.lblName.Text = "Hussein Mutahar Ali Qayed";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(51, 321);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 19);
            this.label6.TabIndex = 23;
            this.label6.Text = "Name:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(51, 451);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(46, 19);
            this.label9.TabIndex = 26;
            this.label9.Text = "Fees:";
            // 
            // lblClass
            // 
            this.lblClass.AutoSize = true;
            this.lblClass.Location = new System.Drawing.Point(153, 263);
            this.lblClass.Name = "lblClass";
            this.lblClass.Size = new System.Drawing.Size(93, 19);
            this.lblClass.TabIndex = 22;
            this.lblClass.Text = "Class 3 - Or";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(51, 264);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 19);
            this.label4.TabIndex = 21;
            this.label4.Text = "D.Class:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label3.Location = new System.Drawing.Point(150, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(216, 39);
            this.label3.TabIndex = 20;
            this.label3.Text = "Schedule Test";
            // 
            // lblDIAppID
            // 
            this.lblDIAppID.AutoSize = true;
            this.lblDIAppID.Location = new System.Drawing.Point(153, 204);
            this.lblDIAppID.Name = "lblDIAppID";
            this.lblDIAppID.Size = new System.Drawing.Size(27, 19);
            this.lblDIAppID.TabIndex = 19;
            this.lblDIAppID.Text = "41";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 204);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 19);
            this.label1.TabIndex = 18;
            this.label1.Text = "D.I.App.ID:";
            // 
            // gabClose
            // 
            this.gabClose.AnimationHoverSpeed = 0.07F;
            this.gabClose.AnimationSpeed = 0.03F;
            this.gabClose.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.gabClose.BorderColor = System.Drawing.Color.Black;
            this.gabClose.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gabClose.FocusedColor = System.Drawing.Color.Empty;
            this.gabClose.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gabClose.ForeColor = System.Drawing.Color.White;
            this.gabClose.Image = ((System.Drawing.Image)(resources.GetObject("gabClose.Image")));
            this.gabClose.ImageSize = new System.Drawing.Size(20, 20);
            this.gabClose.Location = new System.Drawing.Point(55, 691);
            this.gabClose.Name = "gabClose";
            this.gabClose.OnHoverBaseColor = System.Drawing.Color.Red;
            this.gabClose.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gabClose.OnHoverForeColor = System.Drawing.Color.White;
            this.gabClose.OnHoverImage = null;
            this.gabClose.OnPressedColor = System.Drawing.Color.Black;
            this.gabClose.Size = new System.Drawing.Size(160, 42);
            this.gabClose.TabIndex = 30;
            this.gabClose.Text = "Close";
            this.gabClose.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.gabClose.Click += new System.EventHandler(this.gabClose_Click);
            // 
            // gabSave
            // 
            this.gabSave.AnimationHoverSpeed = 0.07F;
            this.gabSave.AnimationSpeed = 0.03F;
            this.gabSave.BaseColor = System.Drawing.Color.Silver;
            this.gabSave.BorderColor = System.Drawing.Color.Black;
            this.gabSave.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gabSave.FocusedColor = System.Drawing.Color.Empty;
            this.gabSave.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gabSave.ForeColor = System.Drawing.Color.White;
            this.gabSave.Image = ((System.Drawing.Image)(resources.GetObject("gabSave.Image")));
            this.gabSave.ImageSize = new System.Drawing.Size(20, 20);
            this.gabSave.Location = new System.Drawing.Point(360, 691);
            this.gabSave.Name = "gabSave";
            this.gabSave.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.gabSave.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gabSave.OnHoverForeColor = System.Drawing.Color.White;
            this.gabSave.OnHoverImage = null;
            this.gabSave.OnPressedColor = System.Drawing.Color.Black;
            this.gabSave.Size = new System.Drawing.Size(160, 42);
            this.gabSave.TabIndex = 29;
            this.gabSave.Text = "Save";
            this.gabSave.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.gabSave.Click += new System.EventHandler(this.gabSave_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(198, 36);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(109, 85);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // frmScheduleWrittenTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(541, 768);
            this.Controls.Add(this.lblAppointmentID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.gdtpDate);
            this.Controls.Add(this.gabClose);
            this.Controls.Add(this.gabSave);
            this.Controls.Add(this.gbRetake);
            this.Controls.Add(this.lblFees);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.lblClass);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblDIAppID);
            this.Controls.Add(this.label1);
            this.Name = "frmScheduleWrittenTest";
            this.Text = "frmScheduleWrittenTest";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmScheduleWrittenTest_FormClosed);
            this.gbRetake.ResumeLayout(false);
            this.gbRetake.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAppointmentID;
        private System.Windows.Forms.Label label2;
        private Guna.UI.WinForms.GunaDateTimePicker gdtpDate;
        private Guna.UI.WinForms.GunaButton gabClose;
        private Guna.UI.WinForms.GunaButton gabSave;
        private System.Windows.Forms.GroupBox gbRetake;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label lblTotalFees;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label lblAppFees;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Label lblFees;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblClass;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblDIAppID;
        private System.Windows.Forms.Label label1;
    }
}