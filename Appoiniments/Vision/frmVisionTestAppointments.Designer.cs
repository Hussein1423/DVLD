﻿namespace DVLDtest.Appoiniments
{
    partial class frmVisionTestAppointments
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmVisionTestAppointments));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvTests = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.editDateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.takeTestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label3 = new System.Windows.Forms.Label();
            this.lblRecords = new System.Windows.Forms.Label();
            this.gabClose = new Guna.UI.WinForms.GunaButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.gabAddVision = new Guna.UI.WinForms.GunaButton();
            this.ucApplicationBasicInfo1 = new DVLDtest.Applications.ucApplicationBasicInfo();
            this.ucDrivingLicenseApplicationInfo1 = new DVLDtest.LocalDrivingsLA.ucDrivingLicenseApplicationInfo();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTests)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 683);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 19);
            this.label1.TabIndex = 2;
            this.label1.Text = "Appoiniments:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(267, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(375, 39);
            this.label2.TabIndex = 4;
            this.label2.Text = "Vision Test Appointments";
            // 
            // dgvTests
            // 
            this.dgvTests.AllowUserToAddRows = false;
            this.dgvTests.AllowUserToDeleteRows = false;
            this.dgvTests.AllowUserToOrderColumns = true;
            this.dgvTests.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTests.ContextMenuStrip = this.contextMenuStrip1;
            this.dgvTests.Location = new System.Drawing.Point(35, 731);
            this.dgvTests.Name = "dgvTests";
            this.dgvTests.ReadOnly = true;
            this.dgvTests.RowHeadersWidth = 62;
            this.dgvTests.RowTemplate.Height = 29;
            this.dgvTests.Size = new System.Drawing.Size(845, 145);
            this.dgvTests.TabIndex = 6;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editDateToolStripMenuItem,
            this.takeTestToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(249, 101);
            // 
            // editDateToolStripMenuItem
            // 
            this.editDateToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("editDateToolStripMenuItem.Image")));
            this.editDateToolStripMenuItem.Name = "editDateToolStripMenuItem";
            this.editDateToolStripMenuItem.Size = new System.Drawing.Size(248, 32);
            this.editDateToolStripMenuItem.Text = "Edit Date";
            this.editDateToolStripMenuItem.Click += new System.EventHandler(this.editDateToolStripMenuItem_Click);
            // 
            // takeTestToolStripMenuItem
            // 
            this.takeTestToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("takeTestToolStripMenuItem.Image")));
            this.takeTestToolStripMenuItem.Name = "takeTestToolStripMenuItem";
            this.takeTestToolStripMenuItem.Size = new System.Drawing.Size(248, 32);
            this.takeTestToolStripMenuItem.Text = "Take Test";
            this.takeTestToolStripMenuItem.Click += new System.EventHandler(this.takeTestToolStripMenuItem_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 895);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 19);
            this.label3.TabIndex = 7;
            this.label3.Text = "Records:";
            // 
            // lblRecords
            // 
            this.lblRecords.AutoSize = true;
            this.lblRecords.Location = new System.Drawing.Point(108, 895);
            this.lblRecords.Name = "lblRecords";
            this.lblRecords.Size = new System.Drawing.Size(18, 19);
            this.lblRecords.TabIndex = 8;
            this.lblRecords.Text = "7";
            // 
            // gabClose
            // 
            this.gabClose.AnimationHoverSpeed = 0.07F;
            this.gabClose.AnimationSpeed = 0.03F;
            this.gabClose.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gabClose.BorderColor = System.Drawing.Color.Black;
            this.gabClose.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gabClose.FocusedColor = System.Drawing.Color.Empty;
            this.gabClose.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gabClose.ForeColor = System.Drawing.Color.White;
            this.gabClose.Image = ((System.Drawing.Image)(resources.GetObject("gabClose.Image")));
            this.gabClose.ImageSize = new System.Drawing.Size(20, 20);
            this.gabClose.Location = new System.Drawing.Point(776, 882);
            this.gabClose.Name = "gabClose";
            this.gabClose.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.gabClose.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gabClose.OnHoverForeColor = System.Drawing.Color.White;
            this.gabClose.OnHoverImage = null;
            this.gabClose.OnPressedColor = System.Drawing.Color.Black;
            this.gabClose.Size = new System.Drawing.Size(104, 42);
            this.gabClose.TabIndex = 9;
            this.gabClose.Text = "Close";
            this.gabClose.Click += new System.EventHandler(this.gabClose_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(382, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(87, 72);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // gabAddVision
            // 
            this.gabAddVision.AnimationHoverSpeed = 0.07F;
            this.gabAddVision.AnimationSpeed = 0.03F;
            this.gabAddVision.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gabAddVision.BorderColor = System.Drawing.Color.Black;
            this.gabAddVision.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gabAddVision.FocusedColor = System.Drawing.Color.Empty;
            this.gabAddVision.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gabAddVision.ForeColor = System.Drawing.Color.White;
            this.gabAddVision.Image = ((System.Drawing.Image)(resources.GetObject("gabAddVision.Image")));
            this.gabAddVision.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.gabAddVision.ImageSize = new System.Drawing.Size(20, 20);
            this.gabAddVision.Location = new System.Drawing.Point(811, 670);
            this.gabAddVision.Name = "gabAddVision";
            this.gabAddVision.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.gabAddVision.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gabAddVision.OnHoverForeColor = System.Drawing.Color.White;
            this.gabAddVision.OnHoverImage = null;
            this.gabAddVision.OnPressedColor = System.Drawing.Color.Black;
            this.gabAddVision.Size = new System.Drawing.Size(57, 42);
            this.gabAddVision.TabIndex = 3;
            this.gabAddVision.Click += new System.EventHandler(this.gabAddVision_Click);
            // 
            // ucApplicationBasicInfo1
            // 
            this.ucApplicationBasicInfo1.Location = new System.Drawing.Point(35, 346);
            this.ucApplicationBasicInfo1.Name = "ucApplicationBasicInfo1";
            this.ucApplicationBasicInfo1.Size = new System.Drawing.Size(930, 300);
            this.ucApplicationBasicInfo1.TabIndex = 1;
            // 
            // ucDrivingLicenseApplicationInfo1
            // 
            this.ucDrivingLicenseApplicationInfo1.Location = new System.Drawing.Point(35, 149);
            this.ucDrivingLicenseApplicationInfo1.Name = "ucDrivingLicenseApplicationInfo1";
            this.ucDrivingLicenseApplicationInfo1.Size = new System.Drawing.Size(938, 200);
            this.ucDrivingLicenseApplicationInfo1.TabIndex = 0;
            // 
            // frmVisionTestAppointments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(996, 950);
            this.Controls.Add(this.gabClose);
            this.Controls.Add(this.lblRecords);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dgvTests);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.gabAddVision);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ucApplicationBasicInfo1);
            this.Controls.Add(this.ucDrivingLicenseApplicationInfo1);
            this.Name = "frmVisionTestAppointments";
            this.Text = "frmVisionTestAppointments";
            ((System.ComponentModel.ISupportInitialize)(this.dgvTests)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private LocalDrivingsLA.ucDrivingLicenseApplicationInfo ucDrivingLicenseApplicationInfo1;
        private Applications.ucApplicationBasicInfo ucApplicationBasicInfo1;
        private System.Windows.Forms.Label label1;
        private Guna.UI.WinForms.GunaButton gabAddVision;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dgvTests;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblRecords;
        private Guna.UI.WinForms.GunaButton gabClose;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem editDateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem takeTestToolStripMenuItem;
    }
}