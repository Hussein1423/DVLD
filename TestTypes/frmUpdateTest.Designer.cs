namespace DVLDtest.TestTypes
{
    partial class frmUpdateTest
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
            this.label1 = new System.Windows.Forms.Label();
            this.lblTestTypeID = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTestTypeTitle = new System.Windows.Forms.TextBox();
            this.txtTestTypeDescription = new System.Windows.Forms.TextBox();
            this.mtbTestTypeFees = new System.Windows.Forms.MaskedTextBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(158, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "TestTypeID:";
            // 
            // lblTestTypeID
            // 
            this.lblTestTypeID.AutoSize = true;
            this.lblTestTypeID.Location = new System.Drawing.Point(261, 9);
            this.lblTestTypeID.Name = "lblTestTypeID";
            this.lblTestTypeID.Size = new System.Drawing.Size(33, 19);
            this.lblTestTypeID.TabIndex = 1;
            this.lblTestTypeID.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(158, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "TestTypeTitle";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(158, 153);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(153, 19);
            this.label3.TabIndex = 3;
            this.label3.Text = "TestTypeDescription";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(158, 311);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 19);
            this.label4.TabIndex = 4;
            this.label4.Text = "TestTypeFees";
            // 
            // txtTestTypeTitle
            // 
            this.txtTestTypeTitle.Location = new System.Drawing.Point(162, 88);
            this.txtTestTypeTitle.Name = "txtTestTypeTitle";
            this.txtTestTypeTitle.Size = new System.Drawing.Size(260, 27);
            this.txtTestTypeTitle.TabIndex = 5;
            // 
            // txtTestTypeDescription
            // 
            this.txtTestTypeDescription.Location = new System.Drawing.Point(162, 186);
            this.txtTestTypeDescription.Multiline = true;
            this.txtTestTypeDescription.Name = "txtTestTypeDescription";
            this.txtTestTypeDescription.Size = new System.Drawing.Size(260, 107);
            this.txtTestTypeDescription.TabIndex = 6;
            // 
            // mtbTestTypeFees
            // 
            this.mtbTestTypeFees.Location = new System.Drawing.Point(162, 349);
            this.mtbTestTypeFees.Mask = "000000000000000000000000000";
            this.mtbTestTypeFees.Name = "mtbTestTypeFees";
            this.mtbTestTypeFees.Size = new System.Drawing.Size(260, 27);
            this.mtbTestTypeFees.TabIndex = 7;
            this.mtbTestTypeFees.TextChanged += new System.EventHandler(this.mtbTestTypeFees_TextChanged);
            this.mtbTestTypeFees.Validated += new System.EventHandler(this.mtbTestTypeFees_Validated);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(235, 402);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(108, 36);
            this.btnUpdate.TabIndex = 8;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // frmUpdateTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(536, 450);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.mtbTestTypeFees);
            this.Controls.Add(this.txtTestTypeDescription);
            this.Controls.Add(this.txtTestTypeTitle);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblTestTypeID);
            this.Controls.Add(this.label1);
            this.Name = "frmUpdateTest";
            this.Text = "frmUpdateTest";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTestTypeID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTestTypeTitle;
        private System.Windows.Forms.TextBox txtTestTypeDescription;
        private System.Windows.Forms.MaskedTextBox mtbTestTypeFees;
        private System.Windows.Forms.Button btnUpdate;
    }
}