namespace DVLDtest.People
{
    partial class frmShowPerson
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
            this.lnkEdit = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // ucPersonalCard1
            // 
            this.ucPersonalCard1.Location = new System.Drawing.Point(76, 1);
            this.ucPersonalCard1.Name = "ucPersonalCard1";
            this.ucPersonalCard1.personID = 0;
            this.ucPersonalCard1.Size = new System.Drawing.Size(667, 450);
            this.ucPersonalCard1.TabIndex = 0;
            // 
            // lnkEdit
            // 
            this.lnkEdit.AutoSize = true;
            this.lnkEdit.Location = new System.Drawing.Point(534, 53);
            this.lnkEdit.Name = "lnkEdit";
            this.lnkEdit.Size = new System.Drawing.Size(36, 19);
            this.lnkEdit.TabIndex = 1;
            this.lnkEdit.TabStop = true;
            this.lnkEdit.Text = "Edit";
            this.lnkEdit.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkEdit_LinkClicked);
            // 
            // frmShowPerson
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lnkEdit);
            this.Controls.Add(this.ucPersonalCard1);
            this.Name = "frmShowPerson";
            this.Text = "frmShowPerson";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ucPersonalCard ucPersonalCard1;
        private System.Windows.Forms.LinkLabel lnkEdit;
    }
}