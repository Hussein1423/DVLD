namespace DVLDtest.Users
{
    partial class frmShowUser
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
            this.ucPersonalCard1 = new DVLDtest.ucPersonalCard();
            this.ucUserCard1 = new DVLDtest.Users.ucUserCard();
            this.SuspendLayout();
            // 
            // ucPersonalCard1
            // 
            this.ucPersonalCard1.Location = new System.Drawing.Point(2, 13);
            this.ucPersonalCard1.Name = "ucPersonalCard1";
            this.ucPersonalCard1.personID = 0;
            this.ucPersonalCard1.Size = new System.Drawing.Size(677, 450);
            this.ucPersonalCard1.TabIndex = 0;
            // 
            // ucUserCard1
            // 
            this.ucUserCard1.idUser = 0;
            this.ucUserCard1.Location = new System.Drawing.Point(2, 469);
            this.ucUserCard1.Name = "ucUserCard1";
            this.ucUserCard1.Size = new System.Drawing.Size(677, 158);
            this.ucUserCard1.TabIndex = 1;
            // 
            // frmCurrentUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(683, 589);
            this.Controls.Add(this.ucUserCard1);
            this.Controls.Add(this.ucPersonalCard1);
            this.Name = "frmCurrentUser";
            this.Text = "frmCurrentUser";
            this.ResumeLayout(false);

        }

        #endregion

        private ucPersonalCard ucPersonalCard1;
        private ucUserCard ucUserCard1;
    }
}