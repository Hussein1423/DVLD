namespace DVLDtest.Appoiniments.Vision
{
    partial class frmTakeVisionTest
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTakeVisionTest));
            this.ucTakeTest1 = new DVLDtest.Tests.ucTakeTest();
            this.gabSave = new Guna.UI.WinForms.GunaButton();
            this.gabClose = new Guna.UI.WinForms.GunaButton();
            this.SuspendLayout();
            // 
            // ucTakeTest1
            // 
            this.ucTakeTest1.Location = new System.Drawing.Point(124, 12);
            this.ucTakeTest1.Name = "ucTakeTest1";
            this.ucTakeTest1.Size = new System.Drawing.Size(505, 804);
            this.ucTakeTest1.TabIndex = 0;
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
            this.gabSave.Location = new System.Drawing.Point(469, 834);
            this.gabSave.Name = "gabSave";
            this.gabSave.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.gabSave.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gabSave.OnHoverForeColor = System.Drawing.Color.White;
            this.gabSave.OnHoverImage = null;
            this.gabSave.OnPressedColor = System.Drawing.Color.Black;
            this.gabSave.Size = new System.Drawing.Size(160, 42);
            this.gabSave.TabIndex = 1;
            this.gabSave.Text = "Save";
            this.gabSave.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
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
            this.gabClose.Location = new System.Drawing.Point(167, 834);
            this.gabClose.Name = "gabClose";
            this.gabClose.OnHoverBaseColor = System.Drawing.Color.Red;
            this.gabClose.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gabClose.OnHoverForeColor = System.Drawing.Color.White;
            this.gabClose.OnHoverImage = null;
            this.gabClose.OnPressedColor = System.Drawing.Color.Black;
            this.gabClose.Size = new System.Drawing.Size(160, 42);
            this.gabClose.TabIndex = 2;
            this.gabClose.Text = "Close";
            this.gabClose.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // frmTakeVisionTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 951);
            this.Controls.Add(this.gabClose);
            this.Controls.Add(this.gabSave);
            this.Controls.Add(this.ucTakeTest1);
            this.Name = "frmTakeVisionTest";
            this.Text = "frmTakeVisionTest";
            this.ResumeLayout(false);

        }

        #endregion

        private Tests.ucTakeTest ucTakeTest1;
        private Guna.UI.WinForms.GunaButton gabSave;
        private Guna.UI.WinForms.GunaButton gabClose;
    }
}