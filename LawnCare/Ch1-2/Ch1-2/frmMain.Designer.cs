namespace Ch1_2
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.imgLogo = new System.Windows.Forms.PictureBox();
            this.btnCompanyInfo = new System.Windows.Forms.Button();
            this.btnContactInfo = new System.Windows.Forms.Button();
            this.lblContactName = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblCityStZip = new System.Windows.Forms.Label();
            this.lblPhone = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.imgDirections = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.imgLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgDirections)).BeginInit();
            this.SuspendLayout();
            // 
            // imgLogo
            // 
            this.imgLogo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.imgLogo.Image = ((System.Drawing.Image)(resources.GetObject("imgLogo.Image")));
            this.imgLogo.Location = new System.Drawing.Point(30, 12);
            this.imgLogo.Name = "imgLogo";
            this.imgLogo.Size = new System.Drawing.Size(352, 141);
            this.imgLogo.TabIndex = 0;
            this.imgLogo.TabStop = false;
            // 
            // btnCompanyInfo
            // 
            this.btnCompanyInfo.Location = new System.Drawing.Point(33, 320);
            this.btnCompanyInfo.Name = "btnCompanyInfo";
            this.btnCompanyInfo.Size = new System.Drawing.Size(113, 38);
            this.btnCompanyInfo.TabIndex = 1;
            this.btnCompanyInfo.Text = "Click here to see company information";
            this.btnCompanyInfo.UseVisualStyleBackColor = true;
            this.btnCompanyInfo.Click += new System.EventHandler(this.btnCompanyInfo_Click);
            // 
            // btnContactInfo
            // 
            this.btnContactInfo.Location = new System.Drawing.Point(33, 264);
            this.btnContactInfo.Name = "btnContactInfo";
            this.btnContactInfo.Size = new System.Drawing.Size(113, 38);
            this.btnContactInfo.TabIndex = 2;
            this.btnContactInfo.Text = "Click here to see contact information";
            this.btnContactInfo.UseVisualStyleBackColor = true;
            this.btnContactInfo.Click += new System.EventHandler(this.btnContactInfo_Click);
            // 
            // lblContactName
            // 
            this.lblContactName.AutoSize = true;
            this.lblContactName.Location = new System.Drawing.Point(57, 183);
            this.lblContactName.Name = "lblContactName";
            this.lblContactName.Size = new System.Drawing.Size(67, 13);
            this.lblContactName.TabIndex = 3;
            this.lblContactName.Text = "EarthMatters";
            this.lblContactName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblContactName.Visible = false;
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Location = new System.Drawing.Point(60, 197);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(58, 13);
            this.lblAddress.TabIndex = 4;
            this.lblAddress.Text = "320 Elm St";
            this.lblAddress.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblAddress.Visible = false;
            // 
            // lblCityStZip
            // 
            this.lblCityStZip.AutoSize = true;
            this.lblCityStZip.Location = new System.Drawing.Point(39, 210);
            this.lblCityStZip.Name = "lblCityStZip";
            this.lblCityStZip.Size = new System.Drawing.Size(103, 13);
            this.lblCityStZip.TabIndex = 5;
            this.lblCityStZip.Text = "St. Cloud MN 56303";
            this.lblCityStZip.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblCityStZip.Visible = false;
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Location = new System.Drawing.Point(50, 223);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(73, 13);
            this.lblPhone.TabIndex = 6;
            this.lblPhone.Text = "320-333-5555";
            this.lblPhone.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblPhone.Visible = false;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(29, 236);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(135, 13);
            this.lblEmail.TabIndex = 7;
            this.lblEmail.Text = "contact@earthmatters.com";
            this.lblEmail.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblEmail.Visible = false;
            // 
            // imgDirections
            // 
            this.imgDirections.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.imgDirections.Image = ((System.Drawing.Image)(resources.GetObject("imgDirections.Image")));
            this.imgDirections.InitialImage = ((System.Drawing.Image)(resources.GetObject("imgDirections.InitialImage")));
            this.imgDirections.Location = new System.Drawing.Point(213, 173);
            this.imgDirections.Name = "imgDirections";
            this.imgDirections.Size = new System.Drawing.Size(169, 129);
            this.imgDirections.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgDirections.TabIndex = 8;
            this.imgDirections.TabStop = false;
            this.imgDirections.Click += new System.EventHandler(this.imgDirections_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(238, 319);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(124, 39);
            this.button1.TabIndex = 9;
            this.button1.Text = "Lawn Care Services";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(407, 371);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.imgDirections);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblPhone);
            this.Controls.Add(this.lblCityStZip);
            this.Controls.Add(this.lblAddress);
            this.Controls.Add(this.lblContactName);
            this.Controls.Add(this.btnContactInfo);
            this.Controls.Add(this.btnCompanyInfo);
            this.Controls.Add(this.imgLogo);
            this.Name = "frmMain";
            this.Text = "EarthMatters";
            ((System.ComponentModel.ISupportInitialize)(this.imgLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgDirections)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox imgLogo;
        private System.Windows.Forms.Button btnCompanyInfo;
        private System.Windows.Forms.Button btnContactInfo;
        private System.Windows.Forms.Label lblContactName;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblCityStZip;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.PictureBox imgDirections;
        private System.Windows.Forms.Button button1;
    }
}

