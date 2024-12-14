namespace DVLDtest.Users
{
    partial class frmUserForm
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPerson = new System.Windows.Forms.TabPage();
            this.btnAddUser = new System.Windows.Forms.Button();
            this.tabUser = new System.Windows.Forms.TabPage();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.rbnotActive = new System.Windows.Forms.RadioButton();
            this.rbActive = new System.Windows.Forms.RadioButton();
            this.txtConfirmPassword = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ucPersonCardwithFilter1 = new DVLDtest.People.ucPersonCardwithFilter();
            this.tabControl1.SuspendLayout();
            this.tabPerson.SuspendLayout();
            this.tabUser.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPerson);
            this.tabControl1.Controls.Add(this.tabUser);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(645, 621);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPerson
            // 
            this.tabPerson.Controls.Add(this.btnAddUser);
            this.tabPerson.Controls.Add(this.ucPersonCardwithFilter1);
            this.tabPerson.Location = new System.Drawing.Point(4, 28);
            this.tabPerson.Name = "tabPerson";
            this.tabPerson.Padding = new System.Windows.Forms.Padding(3);
            this.tabPerson.Size = new System.Drawing.Size(637, 589);
            this.tabPerson.TabIndex = 0;
            this.tabPerson.Text = "Person";
            this.tabPerson.UseVisualStyleBackColor = true;
            // 
            // btnAddUser
            // 
            this.btnAddUser.Location = new System.Drawing.Point(543, 46);
            this.btnAddUser.Name = "btnAddUser";
            this.btnAddUser.Size = new System.Drawing.Size(75, 28);
            this.btnAddUser.TabIndex = 1;
            this.btnAddUser.Text = "User";
            this.btnAddUser.UseVisualStyleBackColor = true;
            this.btnAddUser.Click += new System.EventHandler(this.btnAddUser_Click);
            // 
            // tabUser
            // 
            this.tabUser.Controls.Add(this.btnConfirm);
            this.tabUser.Controls.Add(this.rbnotActive);
            this.tabUser.Controls.Add(this.rbActive);
            this.tabUser.Controls.Add(this.txtConfirmPassword);
            this.tabUser.Controls.Add(this.txtPassword);
            this.tabUser.Controls.Add(this.txtUsername);
            this.tabUser.Controls.Add(this.label4);
            this.tabUser.Controls.Add(this.label3);
            this.tabUser.Controls.Add(this.label2);
            this.tabUser.Controls.Add(this.label1);
            this.tabUser.Location = new System.Drawing.Point(4, 28);
            this.tabUser.Name = "tabUser";
            this.tabUser.Padding = new System.Windows.Forms.Padding(3);
            this.tabUser.Size = new System.Drawing.Size(637, 589);
            this.tabUser.TabIndex = 1;
            this.tabUser.Text = "User";
            this.tabUser.UseVisualStyleBackColor = true;
            // 
            // btnConfirm
            // 
            this.btnConfirm.Location = new System.Drawing.Point(221, 356);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(121, 43);
            this.btnConfirm.TabIndex = 19;
            this.btnConfirm.Text = "Confirm";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // rbnotActive
            // 
            this.rbnotActive.AutoSize = true;
            this.rbnotActive.Location = new System.Drawing.Point(318, 291);
            this.rbnotActive.Name = "rbnotActive";
            this.rbnotActive.Size = new System.Drawing.Size(107, 23);
            this.rbnotActive.TabIndex = 18;
            this.rbnotActive.TabStop = true;
            this.rbnotActive.Text = "Not Active";
            this.rbnotActive.UseVisualStyleBackColor = true;
            // 
            // rbActive
            // 
            this.rbActive.AutoSize = true;
            this.rbActive.Checked = true;
            this.rbActive.Location = new System.Drawing.Point(170, 291);
            this.rbActive.Name = "rbActive";
            this.rbActive.Size = new System.Drawing.Size(77, 23);
            this.rbActive.TabIndex = 17;
            this.rbActive.TabStop = true;
            this.rbActive.Text = "Active";
            this.rbActive.UseVisualStyleBackColor = true;
            // 
            // txtConfirmPassword
            // 
            this.txtConfirmPassword.Location = new System.Drawing.Point(170, 211);
            this.txtConfirmPassword.Name = "txtConfirmPassword";
            this.txtConfirmPassword.Size = new System.Drawing.Size(214, 27);
            this.txtConfirmPassword.TabIndex = 16;
            this.txtConfirmPassword.UseSystemPasswordChar = true;
            this.txtConfirmPassword.Validated += new System.EventHandler(this.txtConfirmPassword_Validated);
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(170, 133);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(214, 27);
            this.txtPassword.TabIndex = 15;
            this.txtPassword.UseSystemPasswordChar = true;
            this.txtPassword.Validated += new System.EventHandler(this.txtPassword_Validated);
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(170, 53);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(214, 27);
            this.txtUsername.TabIndex = 14;
            this.txtUsername.Validated += new System.EventHandler(this.txtUsername_Validated);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(166, 177);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(133, 19);
            this.label4.TabIndex = 13;
            this.label4.Text = "ConfirmPassword";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(166, 256);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 19);
            this.label3.TabIndex = 12;
            this.label3.Text = "Active";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(166, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 19);
            this.label2.TabIndex = 11;
            this.label2.Text = "Password";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(166, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 19);
            this.label1.TabIndex = 10;
            this.label1.Text = "Username";
            // 
            // ucPersonCardwithFilter1
            // 
            this.ucPersonCardwithFilter1.Location = new System.Drawing.Point(6, -1);
            this.ucPersonCardwithFilter1.Name = "ucPersonCardwithFilter1";
            this.ucPersonCardwithFilter1.Size = new System.Drawing.Size(631, 593);
            this.ucPersonCardwithFilter1.TabIndex = 0;
            this.ucPersonCardwithFilter1.showPersonForm += new System.Action<int>(this.ucPersonCardwithFilter1_showPersonForm);
            // 
            // frmUserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(645, 621);
            this.Controls.Add(this.tabControl1);
            this.Name = "frmUserForm";
            this.Text = "frmAddUser";
            this.tabControl1.ResumeLayout(false);
            this.tabPerson.ResumeLayout(false);
            this.tabUser.ResumeLayout(false);
            this.tabUser.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPerson;
        private System.Windows.Forms.TabPage tabUser;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.RadioButton rbnotActive;
        private System.Windows.Forms.RadioButton rbActive;
        private System.Windows.Forms.TextBox txtConfirmPassword;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private People.ucPersonCardwithFilter ucPersonCardwithFilter1;
        private System.Windows.Forms.Button btnAddUser;
    }
}