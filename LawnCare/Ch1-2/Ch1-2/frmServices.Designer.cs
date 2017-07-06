namespace Ch1_2
{
    partial class frmServices
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
            this.lblCustomer = new System.Windows.Forms.Label();
            this.lblService = new System.Windows.Forms.Label();
            this.lblHours = new System.Windows.Forms.Label();
            this.btnCalcBalance = new System.Windows.Forms.Button();
            this.txtCustomerFirstName = new System.Windows.Forms.TextBox();
            this.txtCustomerLastName = new System.Windows.Forms.TextBox();
            this.txtMowLawnHours = new System.Windows.Forms.TextBox();
            this.chkMowLawn = new System.Windows.Forms.CheckBox();
            this.chkTrimLawn = new System.Windows.Forms.CheckBox();
            this.chkSpraying = new System.Windows.Forms.CheckBox();
            this.chkTrimFoliage = new System.Windows.Forms.CheckBox();
            this.txtTrimLawnHours = new System.Windows.Forms.TextBox();
            this.txtSprayingHours = new System.Windows.Forms.TextBox();
            this.txtTrimFoliageHours = new System.Windows.Forms.TextBox();
            this.lblFirst = new System.Windows.Forms.Label();
            this.lblLast = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblCustomer
            // 
            this.lblCustomer.AutoSize = true;
            this.lblCustomer.Location = new System.Drawing.Point(107, 9);
            this.lblCustomer.Name = "lblCustomer";
            this.lblCustomer.Size = new System.Drawing.Size(82, 13);
            this.lblCustomer.TabIndex = 11;
            this.lblCustomer.Text = "Customer Name";
            // 
            // lblService
            // 
            this.lblService.AutoSize = true;
            this.lblService.Location = new System.Drawing.Point(43, 66);
            this.lblService.Name = "lblService";
            this.lblService.Size = new System.Drawing.Size(48, 13);
            this.lblService.TabIndex = 14;
            this.lblService.Text = "Services";
            // 
            // lblHours
            // 
            this.lblHours.AutoSize = true;
            this.lblHours.Location = new System.Drawing.Point(216, 66);
            this.lblHours.Name = "lblHours";
            this.lblHours.Size = new System.Drawing.Size(35, 13);
            this.lblHours.TabIndex = 15;
            this.lblHours.Text = "Hours";
            // 
            // btnCalcBalance
            // 
            this.btnCalcBalance.Location = new System.Drawing.Point(75, 186);
            this.btnCalcBalance.Name = "btnCalcBalance";
            this.btnCalcBalance.Size = new System.Drawing.Size(130, 23);
            this.btnCalcBalance.TabIndex = 10;
            this.btnCalcBalance.Text = "&Calculate Balance Due";
            this.btnCalcBalance.UseVisualStyleBackColor = true;
            this.btnCalcBalance.Click += new System.EventHandler(this.btnCalcBalance_Click);
            // 
            // txtCustomerFirstName
            // 
            this.txtCustomerFirstName.Location = new System.Drawing.Point(47, 34);
            this.txtCustomerFirstName.Name = "txtCustomerFirstName";
            this.txtCustomerFirstName.Size = new System.Drawing.Size(100, 20);
            this.txtCustomerFirstName.TabIndex = 0;
            // 
            // txtCustomerLastName
            // 
            this.txtCustomerLastName.Location = new System.Drawing.Point(186, 34);
            this.txtCustomerLastName.Name = "txtCustomerLastName";
            this.txtCustomerLastName.Size = new System.Drawing.Size(100, 20);
            this.txtCustomerLastName.TabIndex = 1;
            // 
            // txtMowLawnHours
            // 
            this.txtMowLawnHours.Location = new System.Drawing.Point(186, 82);
            this.txtMowLawnHours.Name = "txtMowLawnHours";
            this.txtMowLawnHours.Size = new System.Drawing.Size(100, 20);
            this.txtMowLawnHours.TabIndex = 3;
            // 
            // chkMowLawn
            // 
            this.chkMowLawn.AutoSize = true;
            this.chkMowLawn.Location = new System.Drawing.Point(12, 84);
            this.chkMowLawn.Name = "chkMowLawn";
            this.chkMowLawn.Size = new System.Drawing.Size(107, 17);
            this.chkMowLawn.TabIndex = 2;
            this.chkMowLawn.Text = "Mow Lawn $5/hr";
            this.chkMowLawn.UseVisualStyleBackColor = true;
            // 
            // chkTrimLawn
            // 
            this.chkTrimLawn.AutoSize = true;
            this.chkTrimLawn.Location = new System.Drawing.Point(12, 110);
            this.chkTrimLawn.Name = "chkTrimLawn";
            this.chkTrimLawn.Size = new System.Drawing.Size(104, 17);
            this.chkTrimLawn.TabIndex = 4;
            this.chkTrimLawn.Text = "Trim Lawn $5/hr";
            this.chkTrimLawn.UseVisualStyleBackColor = true;
            // 
            // chkSpraying
            // 
            this.chkSpraying.AutoSize = true;
            this.chkSpraying.Location = new System.Drawing.Point(12, 136);
            this.chkSpraying.Name = "chkSpraying";
            this.chkSpraying.Size = new System.Drawing.Size(96, 17);
            this.chkSpraying.TabIndex = 6;
            this.chkSpraying.Text = "Spraying $8/hr";
            this.chkSpraying.UseVisualStyleBackColor = true;
            // 
            // chkTrimFoliage
            // 
            this.chkTrimFoliage.AutoSize = true;
            this.chkTrimFoliage.Location = new System.Drawing.Point(12, 162);
            this.chkTrimFoliage.Name = "chkTrimFoliage";
            this.chkTrimFoliage.Size = new System.Drawing.Size(168, 17);
            this.chkTrimFoliage.TabIndex = 8;
            this.chkTrimFoliage.Text = "Trim Trees and Shrubs $10/hr";
            this.chkTrimFoliage.UseVisualStyleBackColor = true;
            // 
            // txtTrimLawnHours
            // 
            this.txtTrimLawnHours.Location = new System.Drawing.Point(186, 108);
            this.txtTrimLawnHours.Name = "txtTrimLawnHours";
            this.txtTrimLawnHours.Size = new System.Drawing.Size(100, 20);
            this.txtTrimLawnHours.TabIndex = 5;
            // 
            // txtSprayingHours
            // 
            this.txtSprayingHours.Location = new System.Drawing.Point(186, 134);
            this.txtSprayingHours.Name = "txtSprayingHours";
            this.txtSprayingHours.Size = new System.Drawing.Size(100, 20);
            this.txtSprayingHours.TabIndex = 7;
            // 
            // txtTrimFoliageHours
            // 
            this.txtTrimFoliageHours.Location = new System.Drawing.Point(186, 160);
            this.txtTrimFoliageHours.Name = "txtTrimFoliageHours";
            this.txtTrimFoliageHours.Size = new System.Drawing.Size(100, 20);
            this.txtTrimFoliageHours.TabIndex = 9;
            // 
            // lblFirst
            // 
            this.lblFirst.AutoSize = true;
            this.lblFirst.Location = new System.Drawing.Point(15, 37);
            this.lblFirst.Name = "lblFirst";
            this.lblFirst.Size = new System.Drawing.Size(26, 13);
            this.lblFirst.TabIndex = 12;
            this.lblFirst.Text = "First";
            // 
            // lblLast
            // 
            this.lblLast.AutoSize = true;
            this.lblLast.Location = new System.Drawing.Point(153, 37);
            this.lblLast.Name = "lblLast";
            this.lblLast.Size = new System.Drawing.Size(27, 13);
            this.lblLast.TabIndex = 13;
            this.lblLast.Text = "Last";
            // 
            // frmServices
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(295, 216);
            this.Controls.Add(this.lblLast);
            this.Controls.Add(this.lblFirst);
            this.Controls.Add(this.txtTrimFoliageHours);
            this.Controls.Add(this.txtSprayingHours);
            this.Controls.Add(this.txtTrimLawnHours);
            this.Controls.Add(this.chkTrimFoliage);
            this.Controls.Add(this.chkSpraying);
            this.Controls.Add(this.chkTrimLawn);
            this.Controls.Add(this.chkMowLawn);
            this.Controls.Add(this.txtMowLawnHours);
            this.Controls.Add(this.txtCustomerLastName);
            this.Controls.Add(this.txtCustomerFirstName);
            this.Controls.Add(this.btnCalcBalance);
            this.Controls.Add(this.lblHours);
            this.Controls.Add(this.lblService);
            this.Controls.Add(this.lblCustomer);
            this.Name = "frmServices";
            this.Text = "Earth Matters Services";
            this.Load += new System.EventHandler(this.frmServices_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCustomer;
        private System.Windows.Forms.Label lblService;
        private System.Windows.Forms.Label lblHours;
        private System.Windows.Forms.Button btnCalcBalance;
        private System.Windows.Forms.TextBox txtCustomerFirstName;
        private System.Windows.Forms.TextBox txtCustomerLastName;
        private System.Windows.Forms.TextBox txtMowLawnHours;
        private System.Windows.Forms.CheckBox chkMowLawn;
        private System.Windows.Forms.CheckBox chkTrimLawn;
        private System.Windows.Forms.CheckBox chkSpraying;
        private System.Windows.Forms.CheckBox chkTrimFoliage;
        private System.Windows.Forms.TextBox txtTrimLawnHours;
        private System.Windows.Forms.TextBox txtSprayingHours;
        private System.Windows.Forms.TextBox txtTrimFoliageHours;
        private System.Windows.Forms.Label lblFirst;
        private System.Windows.Forms.Label lblLast;
    }
}