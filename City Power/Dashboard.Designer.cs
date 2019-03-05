namespace City_Power
{
    partial class frmCityPower
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCityPower));
            this.radResidential = new System.Windows.Forms.RadioButton();
            this.radCommercial = new System.Windows.Forms.RadioButton();
            this.radIndustrial = new System.Windows.Forms.RadioButton();
            this.lblkWh = new System.Windows.Forms.Label();
            this.txtKilowatthours = new System.Windows.Forms.TextBox();
            this.btnCalc = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.txtChargeTotal = new System.Windows.Forms.TextBox();
            this.lblTotalCharge = new System.Windows.Forms.Label();
            this.gbxSelectedChargeTime = new System.Windows.Forms.GroupBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.txtIndustrialSubTotal = new System.Windows.Forms.TextBox();
            this.ckBxOffPeak = new System.Windows.Forms.CheckBox();
            this.ckBxPeakHours = new System.Windows.Forms.CheckBox();
            this.txtOffPeak = new System.Windows.Forms.TextBox();
            this.txtPeak = new System.Windows.Forms.TextBox();
            this.lblCompanyName = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.gbxCustType = new System.Windows.Forms.GroupBox();
            this.lblCustName = new System.Windows.Forms.Label();
            this.lblAcctNum = new System.Windows.Forms.Label();
            this.txtCustName = new System.Windows.Forms.TextBox();
            this.txtCustAcctNo = new System.Windows.Forms.TextBox();
            this.gbxSelectedChargeTime.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.gbxCustType.SuspendLayout();
            this.SuspendLayout();
            // 
            // radResidential
            // 
            this.radResidential.AutoSize = true;
            this.radResidential.Checked = true;
            this.radResidential.Location = new System.Drawing.Point(14, 29);
            this.radResidential.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.radResidential.Name = "radResidential";
            this.radResidential.Size = new System.Drawing.Size(113, 24);
            this.radResidential.TabIndex = 4;
            this.radResidential.TabStop = true;
            this.radResidential.Text = "&Residential";
            this.radResidential.UseVisualStyleBackColor = true;
            this.radResidential.CheckedChanged += new System.EventHandler(this.radResidential_CheckedChanged);
            // 
            // radCommercial
            // 
            this.radCommercial.AutoSize = true;
            this.radCommercial.Location = new System.Drawing.Point(191, 26);
            this.radCommercial.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.radCommercial.Name = "radCommercial";
            this.radCommercial.Size = new System.Drawing.Size(117, 24);
            this.radCommercial.TabIndex = 5;
            this.radCommercial.TabStop = true;
            this.radCommercial.Text = "Co&mmercial";
            this.radCommercial.UseVisualStyleBackColor = true;
            this.radCommercial.CheckedChanged += new System.EventHandler(this.radCommercial_CheckedChanged);
            // 
            // radIndustrial
            // 
            this.radIndustrial.AutoSize = true;
            this.radIndustrial.Location = new System.Drawing.Point(363, 26);
            this.radIndustrial.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.radIndustrial.Name = "radIndustrial";
            this.radIndustrial.Size = new System.Drawing.Size(99, 24);
            this.radIndustrial.TabIndex = 6;
            this.radIndustrial.TabStop = true;
            this.radIndustrial.Text = "&Industrial";
            this.radIndustrial.UseVisualStyleBackColor = true;
            this.radIndustrial.CheckedChanged += new System.EventHandler(this.radIndustrial_CheckedChanged);
            // 
            // lblkWh
            // 
            this.lblkWh.AutoSize = true;
            this.lblkWh.Location = new System.Drawing.Point(396, 240);
            this.lblkWh.Name = "lblkWh";
            this.lblkWh.Size = new System.Drawing.Size(90, 20);
            this.lblkWh.TabIndex = 21;
            this.lblkWh.Text = "Total (kWh)";
            // 
            // txtKilowatthours
            // 
            this.txtKilowatthours.Location = new System.Drawing.Point(353, 210);
            this.txtKilowatthours.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtKilowatthours.Name = "txtKilowatthours";
            this.txtKilowatthours.Size = new System.Drawing.Size(133, 26);
            this.txtKilowatthours.TabIndex = 10;
            this.txtKilowatthours.Text = "0";
            this.txtKilowatthours.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtKilowatthours.TextChanged += new System.EventHandler(this.txtIndustrialSubTotal_TextChanged);
            // 
            // btnCalc
            // 
            this.btnCalc.Location = new System.Drawing.Point(353, 273);
            this.btnCalc.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(150, 54);
            this.btnCalc.TabIndex = 11;
            this.btnCalc.Text = "&Calculate";
            this.btnCalc.UseVisualStyleBackColor = true;
            this.btnCalc.Click += new System.EventHandler(this.btnCalc_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(727, 406);
            this.btnClear.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(150, 54);
            this.btnClear.TabIndex = 12;
            this.btnClear.Text = "C&lear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(727, 495);
            this.btnExit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(150, 54);
            this.btnExit.TabIndex = 13;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // txtChargeTotal
            // 
            this.txtChargeTotal.BackColor = System.Drawing.Color.Yellow;
            this.txtChargeTotal.Enabled = false;
            this.txtChargeTotal.Font = new System.Drawing.Font("Broadway", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtChargeTotal.ForeColor = System.Drawing.Color.Chartreuse;
            this.txtChargeTotal.Location = new System.Drawing.Point(238, 447);
            this.txtChargeTotal.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtChargeTotal.Multiline = true;
            this.txtChargeTotal.Name = "txtChargeTotal";
            this.txtChargeTotal.ReadOnly = true;
            this.txtChargeTotal.Size = new System.Drawing.Size(308, 76);
            this.txtChargeTotal.TabIndex = 25;
            this.txtChargeTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            
            // 
            // lblTotalCharge
            // 
            this.lblTotalCharge.AutoSize = true;
            this.lblTotalCharge.Location = new System.Drawing.Point(446, 533);
            this.lblTotalCharge.Name = "lblTotalCharge";
            this.lblTotalCharge.Size = new System.Drawing.Size(100, 20);
            this.lblTotalCharge.TabIndex = 22;
            this.lblTotalCharge.Text = "Total Charge";
            // 
            // gbxSelectedChargeTime
            // 
            this.gbxSelectedChargeTime.Controls.Add(this.lblTotal);
            this.gbxSelectedChargeTime.Controls.Add(this.txtIndustrialSubTotal);
            this.gbxSelectedChargeTime.Controls.Add(this.ckBxOffPeak);
            this.gbxSelectedChargeTime.Controls.Add(this.ckBxPeakHours);
            this.gbxSelectedChargeTime.Controls.Add(this.txtOffPeak);
            this.gbxSelectedChargeTime.Controls.Add(this.txtPeak);
            this.gbxSelectedChargeTime.Location = new System.Drawing.Point(14, 68);
            this.gbxSelectedChargeTime.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbxSelectedChargeTime.Name = "gbxSelectedChargeTime";
            this.gbxSelectedChargeTime.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbxSelectedChargeTime.Size = new System.Drawing.Size(484, 134);
            this.gbxSelectedChargeTime.TabIndex = 23;
            this.gbxSelectedChargeTime.TabStop = false;
            this.gbxSelectedChargeTime.Text = "ChargeTime";
            this.gbxSelectedChargeTime.Visible = false;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(349, 104);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(123, 20);
            this.lblTotal.TabIndex = 18;
            this.lblTotal.Text = "Sub Total (kWh)";
            // 
            // txtIndustrialSubTotal
            // 
            this.txtIndustrialSubTotal.Location = new System.Drawing.Point(339, 26);
            this.txtIndustrialSubTotal.Multiline = true;
            this.txtIndustrialSubTotal.Name = "txtIndustrialSubTotal";
            this.txtIndustrialSubTotal.ReadOnly = true;
            this.txtIndustrialSubTotal.Size = new System.Drawing.Size(133, 75);
            this.txtIndustrialSubTotal.TabIndex = 17;
            this.txtIndustrialSubTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtIndustrialSubTotal.TextChanged += new System.EventHandler(this.txtIndustrialSubTotal_TextChanged);
            // 
            // ckBxOffPeak
            // 
            this.ckBxOffPeak.AutoSize = true;
            this.ckBxOffPeak.Location = new System.Drawing.Point(11, 75);
            this.ckBxOffPeak.Name = "ckBxOffPeak";
            this.ckBxOffPeak.Size = new System.Drawing.Size(145, 24);
            this.ckBxOffPeak.TabIndex = 8;
            this.ckBxOffPeak.Text = "Off-Peak Hours";
            this.ckBxOffPeak.UseVisualStyleBackColor = true;
            this.ckBxOffPeak.CheckedChanged += new System.EventHandler(this.ckBxOffPeak_CheckedChanged);
            // 
            // ckBxPeakHours
            // 
            this.ckBxPeakHours.AutoSize = true;
            this.ckBxPeakHours.Location = new System.Drawing.Point(12, 29);
            this.ckBxPeakHours.Name = "ckBxPeakHours";
            this.ckBxPeakHours.Size = new System.Drawing.Size(118, 24);
            this.ckBxPeakHours.TabIndex = 6;
            this.ckBxPeakHours.Text = "Peak Hours";
            this.ckBxPeakHours.UseVisualStyleBackColor = true;
            this.ckBxPeakHours.CheckedChanged += new System.EventHandler(this.ckBxPeakHours_CheckedChanged);
            // 
            // txtOffPeak
            // 
            this.txtOffPeak.Location = new System.Drawing.Point(164, 75);
            this.txtOffPeak.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtOffPeak.Name = "txtOffPeak";
            this.txtOffPeak.Size = new System.Drawing.Size(152, 26);
            this.txtOffPeak.TabIndex = 9;
            this.txtOffPeak.Text = "0";
            this.txtOffPeak.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtOffPeak.Visible = false;
            this.txtOffPeak.TextChanged += new System.EventHandler(this.txtOffPeak_TextChanged);
            // 
            // txtPeak
            // 
            this.txtPeak.Location = new System.Drawing.Point(164, 27);
            this.txtPeak.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPeak.Name = "txtPeak";
            this.txtPeak.Size = new System.Drawing.Size(152, 26);
            this.txtPeak.TabIndex = 7;
            this.txtPeak.Text = "0";
            this.txtPeak.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtPeak.Visible = false;
            this.txtPeak.TextChanged += new System.EventHandler(this.txtPeak_TextChanged);
            // 
            // lblCompanyName
            // 
            this.lblCompanyName.BackColor = System.Drawing.SystemColors.Highlight;
            this.lblCompanyName.Font = new System.Drawing.Font("Palatino Linotype", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCompanyName.ForeColor = System.Drawing.Color.Yellow;
            this.lblCompanyName.Location = new System.Drawing.Point(456, -19);
            this.lblCompanyName.Name = "lblCompanyName";
            this.lblCompanyName.Size = new System.Drawing.Size(431, 106);
            this.lblCompanyName.TabIndex = 24;
            this.lblCompanyName.Text = "City Power";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(552, 91);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(335, 307);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // gbxCustType
            // 
            this.gbxCustType.Controls.Add(this.radResidential);
            this.gbxCustType.Controls.Add(this.radCommercial);
            this.gbxCustType.Controls.Add(this.radIndustrial);
            this.gbxCustType.Controls.Add(this.lblkWh);
            this.gbxCustType.Controls.Add(this.txtKilowatthours);
            this.gbxCustType.Controls.Add(this.gbxSelectedChargeTime);
            this.gbxCustType.Controls.Add(this.btnCalc);
            this.gbxCustType.Location = new System.Drawing.Point(30, 106);
            this.gbxCustType.Name = "gbxCustType";
            this.gbxCustType.Size = new System.Drawing.Size(516, 334);
            this.gbxCustType.TabIndex = 3;
            this.gbxCustType.TabStop = false;
            this.gbxCustType.Text = "-";
            // 
            // lblCustName
            // 
            this.lblCustName.AutoSize = true;
            this.lblCustName.Location = new System.Drawing.Point(26, 74);
            this.lblCustName.Name = "lblCustName";
            this.lblCustName.Size = new System.Drawing.Size(124, 20);
            this.lblCustName.TabIndex = 27;
            this.lblCustName.Text = "Customer Name";
            // 
            // lblAcctNum
            // 
            this.lblAcctNum.AutoSize = true;
            this.lblAcctNum.Location = new System.Drawing.Point(26, 28);
            this.lblAcctNum.Name = "lblAcctNum";
            this.lblAcctNum.Size = new System.Drawing.Size(128, 20);
            this.lblAcctNum.TabIndex = 28;
            this.lblAcctNum.Text = "Account Number";
            // 
            // txtCustName
            // 
            this.txtCustName.Location = new System.Drawing.Point(176, 68);
            this.txtCustName.Name = "txtCustName";
            this.txtCustName.Size = new System.Drawing.Size(274, 26);
            this.txtCustName.TabIndex = 2;
            // 
            // txtCustAcctNo
            // 
            this.txtCustAcctNo.Location = new System.Drawing.Point(176, 22);
            this.txtCustAcctNo.Name = "txtCustAcctNo";
            this.txtCustAcctNo.Size = new System.Drawing.Size(274, 26);
            this.txtCustAcctNo.TabIndex = 1;
            // 
            // frmCityPower
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(900, 562);
            this.Controls.Add(this.txtCustAcctNo);
            this.Controls.Add(this.txtCustName);
            this.Controls.Add(this.lblAcctNum);
            this.Controls.Add(this.lblCustName);
            this.Controls.Add(this.gbxCustType);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblCompanyName);
            this.Controls.Add(this.lblTotalCharge);
            this.Controls.Add(this.txtChargeTotal);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClear);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmCityPower";
            this.Text = "City Power";
            this.gbxSelectedChargeTime.ResumeLayout(false);
            this.gbxSelectedChargeTime.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.gbxCustType.ResumeLayout(false);
            this.gbxCustType.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RadioButton radResidential;
        private System.Windows.Forms.RadioButton radCommercial;
        private System.Windows.Forms.RadioButton radIndustrial;
        private System.Windows.Forms.Label lblkWh;
        private System.Windows.Forms.TextBox txtKilowatthours;
        private System.Windows.Forms.Button btnCalc;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblTotalCharge;
        private System.Windows.Forms.GroupBox gbxSelectedChargeTime;
        private System.Windows.Forms.Label lblCompanyName;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox gbxCustType;
        private System.Windows.Forms.TextBox txtOffPeak;
        private System.Windows.Forms.TextBox txtPeak;
        private System.Windows.Forms.CheckBox ckBxOffPeak;
        private System.Windows.Forms.CheckBox ckBxPeakHours;
        private System.Windows.Forms.Label lblCustName;
        private System.Windows.Forms.Label lblAcctNum;
        private System.Windows.Forms.TextBox txtCustName;
        private System.Windows.Forms.TextBox txtCustAcctNo;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.TextBox txtIndustrialSubTotal;
        public System.Windows.Forms.TextBox txtChargeTotal;
    }
}

