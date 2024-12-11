namespace DVLDtest.Users
{
    partial class frmChangePassword
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
            this.ucUserCard1 = new DVLDtest.Users.ucUserCard();
            this.ucPersonalCard1 = new DVLDtest.ucPersonalCard();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCurrentPassword = new System.Windows.Forms.TextBox();
            this.txtNewPassword = new System.Windows.Forms.TextBox();
            this.txtConfirmPassword = new System.Windows.Forms.TextBox();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ucUserCard1
            // 
            this.ucUserCard1.idUser = 0;
            this.ucUserCard1.Location = new System.Drawing.Point(12, 484);
            this.ucUserCard1.Name = "ucUserCard1";
            this.ucUserCard1.Size = new System.Drawing.Size(677, 158);
            this.ucUserCard1.TabIndex = 3;
            // 
            // ucPersonalCard1
            // 
            this.ucPersonalCard1.Location = new System.Drawing.Point(12, 28);
            this.ucPersonalCard1.Name = "ucPersonalCard1";
            this.ucPersonalCard1.personID = 0;
            this.ucPersonalCard1.Size = new System.Drawing.Size(677, 450);
            this.ucPersonalCard1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(709, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 19);
            this.label1.TabIndex = 4;
            this.label1.Text = "Current Password";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(709, 185);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 19);
            this.label2.TabIndex = 5;
            this.label2.Text = "New Password";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(709, 318);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(138, 19);
            this.label3.TabIndex = 6;
            this.label3.Text = "Confirm Password";
            // 
            // txtCurrentPassword
            // 
            this.txtCurrentPassword.Location = new System.Drawing.Point(713, 87);
            this.txtCurrentPassword.Name = "txtCurrentPassword";
            this.txtCurrentPassword.Size = new System.Drawing.Size(165, 27);
            this.txtCurrentPassword.TabIndex = 7;
            this.txtCurrentPassword.Validated += new System.EventHandler(this.txtCurrentPassword_Validated);
            // 
            // txtNewPassword
            // 
            this.txtNewPassword.Location = new System.Drawing.Point(713, 219);
            this.txtNewPassword.Name = "txtNewPassword";
            this.txtNewPassword.Size = new System.Drawing.Size(165, 27);
            this.txtNewPassword.TabIndex = 8;
            this.txtNewPassword.Validated += new System.EventHandler(this.txtNewPassword_Validated);
            // 
            // txtConfirmPassword
            // 
            this.txtConfirmPassword.Location = new System.Drawing.Point(713, 351);
            this.txtConfirmPassword.Name = "txtConfirmPassword";
            this.txtConfirmPassword.Size = new System.Drawing.Size(165, 27);
            this.txtConfirmPassword.TabIndex = 9;
            this.txtConfirmPassword.Validated += new System.EventHandler(this.txtConfirmPassword_Validated);
            // 
            // btnConfirm
            // 
            this.btnConfirm.Location = new System.Drawing.Point(730, 415);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(133, 36);
            this.btnConfirm.TabIndex = 10;
            this.btnConfirm.Text = "Confirm";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // frmChangePassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(939, 700);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.txtConfirmPassword);
            this.Controls.Add(this.txtNewPassword);
            this.Controls.Add(this.txtCurrentPassword);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ucUserCard1);
            this.Controls.Add(this.ucPersonalCard1);
            this.Name = "frmChangePassword";
            this.Text = "frmChangePassword";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ucUserCard ucUserCard1;
        private ucPersonalCard ucPersonalCard1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCurrentPassword;
        private System.Windows.Forms.TextBox txtNewPassword;
        private System.Windows.Forms.TextBox txtConfirmPassword;
        private System.Windows.Forms.Button btnConfirm;
    }
}