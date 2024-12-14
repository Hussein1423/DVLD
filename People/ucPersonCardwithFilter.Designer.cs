namespace DVLDtest.People
{
    partial class ucPersonCardwithFilter
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
            this.ucPersonalCard1 = new DVLDtest.ucPersonalCard();
            this.label1 = new System.Windows.Forms.Label();
            this.cbFliter = new System.Windows.Forms.ComboBox();
            this.mtbFliter = new System.Windows.Forms.MaskedTextBox();
            this.btnShow = new System.Windows.Forms.Button();
            this.btnAddPerson = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ucPersonalCard1
            // 
            this.ucPersonalCard1.Location = new System.Drawing.Point(0, 82);
            this.ucPersonalCard1.Name = "ucPersonalCard1";
            this.ucPersonalCard1.personID = 0;
            this.ucPersonalCard1.Size = new System.Drawing.Size(634, 450);
            this.ucPersonalCard1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 24);
            this.label1.TabIndex = 5;
            this.label1.Text = "Fliter:";
            // 
            // cbFliter
            // 
            this.cbFliter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFliter.FormattingEnabled = true;
            this.cbFliter.Items.AddRange(new object[] {
            "PersonID",
            "NationalNo"});
            this.cbFliter.Location = new System.Drawing.Point(69, 49);
            this.cbFliter.Name = "cbFliter";
            this.cbFliter.Size = new System.Drawing.Size(145, 27);
            this.cbFliter.TabIndex = 4;
            this.cbFliter.SelectedIndexChanged += new System.EventHandler(this.cbFliter_SelectedIndexChanged);
            // 
            // mtbFliter
            // 
            this.mtbFliter.Location = new System.Drawing.Point(220, 48);
            this.mtbFliter.Name = "mtbFliter";
            this.mtbFliter.Size = new System.Drawing.Size(149, 27);
            this.mtbFliter.TabIndex = 6;
            // 
            // btnShow
            // 
            this.btnShow.Location = new System.Drawing.Point(375, 46);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(75, 29);
            this.btnShow.TabIndex = 7;
            this.btnShow.Text = "Show";
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // btnAddPerson
            // 
            this.btnAddPerson.Location = new System.Drawing.Point(456, 46);
            this.btnAddPerson.Name = "btnAddPerson";
            this.btnAddPerson.Size = new System.Drawing.Size(75, 29);
            this.btnAddPerson.TabIndex = 8;
            this.btnAddPerson.Text = "Add";
            this.btnAddPerson.UseVisualStyleBackColor = true;
            this.btnAddPerson.Click += new System.EventHandler(this.btnAddPerson_Click);
            // 
            // ucPersonCardwithFilter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnAddPerson);
            this.Controls.Add(this.btnShow);
            this.Controls.Add(this.mtbFliter);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbFliter);
            this.Controls.Add(this.ucPersonalCard1);
            this.Name = "ucPersonCardwithFilter";
            this.Size = new System.Drawing.Size(637, 535);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ucPersonalCard ucPersonalCard1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbFliter;
        private System.Windows.Forms.MaskedTextBox mtbFliter;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.Button btnAddPerson;
    }
}
