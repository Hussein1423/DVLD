namespace DVLDtest.ApplicationTypes
{
    partial class frmUpdateApplicationType
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
            this.label = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtApplicationTypeTitle = new System.Windows.Forms.TextBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.lblApplicationTypeID = new System.Windows.Forms.Label();
            this.mtbApplicationFees = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(200, 22);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(146, 19);
            this.label.TabIndex = 0;
            this.label.Text = "ApplicationTypeID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(200, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(154, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "ApplicationTypeTitle";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(203, 185);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "ApplicationFees";
            // 
            // txtApplicationTypeTitle
            // 
            this.txtApplicationTypeTitle.Location = new System.Drawing.Point(186, 117);
            this.txtApplicationTypeTitle.Name = "txtApplicationTypeTitle";
            this.txtApplicationTypeTitle.Size = new System.Drawing.Size(181, 27);
            this.txtApplicationTypeTitle.TabIndex = 3;
            this.txtApplicationTypeTitle.Validated += new System.EventHandler(this.txtApplicationTypeTitle_Validated);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(207, 295);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(147, 34);
            this.btnUpdate.TabIndex = 5;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // lblApplicationTypeID
            // 
            this.lblApplicationTypeID.AutoSize = true;
            this.lblApplicationTypeID.Location = new System.Drawing.Point(346, 22);
            this.lblApplicationTypeID.Name = "lblApplicationTypeID";
            this.lblApplicationTypeID.Size = new System.Drawing.Size(0, 19);
            this.lblApplicationTypeID.TabIndex = 6;
            // 
            // mtbApplicationFees
            // 
            this.mtbApplicationFees.Location = new System.Drawing.Point(186, 224);
            this.mtbApplicationFees.Mask = "00000000000000000000000000000000000000000000000";
            this.mtbApplicationFees.Name = "mtbApplicationFees";
            this.mtbApplicationFees.Size = new System.Drawing.Size(181, 27);
            this.mtbApplicationFees.TabIndex = 7;
            this.mtbApplicationFees.TextChanged += new System.EventHandler(this.mtbApplicationFees_TextChanged);
            this.mtbApplicationFees.Validated += new System.EventHandler(this.mtbApplicationFees_Validated);
            // 
            // frmUpdateApplicationType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(536, 450);
            this.Controls.Add(this.mtbApplicationFees);
            this.Controls.Add(this.lblApplicationTypeID);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.txtApplicationTypeTitle);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label);
            this.Name = "frmUpdateApplicationType";
            this.Text = "frmUpdateApplicationType";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtApplicationTypeTitle;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Label lblApplicationTypeID;
        private System.Windows.Forms.MaskedTextBox mtbApplicationFees;
    }
}