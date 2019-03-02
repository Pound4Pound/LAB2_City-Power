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
            this.txtBxOffPeak = new System.Windows.Forms.TextBox();
            this.txtBxPeak = new System.Windows.Forms.TextBox();
            this.lblCompanyName = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.gbxCustType = new System.Windows.Forms.GroupBox();
            this.ckBxPeakHours = new System.Windows.Forms.CheckBox();
            this.ckBxOffPeak = new System.Windows.Forms.CheckBox();
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
            this.radResidential.TabIndex = 1;
            this.radResidential.TabStop = true;
            this.radResidential.Text = "&Residential";
            this.radResidential.UseVisualStyleBackColor = true;
            this.radResidential.CheckedChanged += new System.EventHandler(this.radResidential_CheckedChanged);
            // 
            // radCommercial
            // 
            this.radCommercial.AutoSize = true;
            this.radCommercial.Location = new System.Drawing.Point(146, 29);
            this.radCommercial.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.radCommercial.Name = "radCommercial";
            this.radCommercial.Size = new System.Drawing.Size(117, 24);
            this.radCommercial.TabIndex = 2;
            this.radCommercial.TabStop = true;
            this.radCommercial.Text = "Co&mmercial";
            this.radCommercial.UseVisualStyleBackColor = true;
            this.radCommercial.CheckedChanged += new System.EventHandler(this.radCommercial_CheckedChanged);
            // 
            // radIndustrial
            // 
            this.radIndustrial.AutoSize = true;
            this.radIndustrial.Location = new System.Drawing.Point(269, 29);
            this.radIndustrial.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.radIndustrial.Name = "radIndustrial";
            this.radIndustrial.Size = new System.Drawing.Size(99, 24);
            this.radIndustrial.TabIndex = 3;
            this.radIndustrial.TabStop = true;
            this.radIndustrial.Text = "&Industrial";
            this.radIndustrial.UseVisualStyleBackColor = true;
            this.radIndustrial.CheckedChanged += new System.EventHandler(this.radIndustrial_CheckedChanged);
            // 
            // lblkWh
            // 
            this.lblkWh.AutoSize = true;
            this.lblkWh.Location = new System.Drawing.Point(19, 175);
            this.lblkWh.Name = "lblkWh";
            this.lblkWh.Size = new System.Drawing.Size(150, 20);
            this.lblkWh.TabIndex = 21;
            this.lblkWh.Text = "Kilowatthours (kWh)";
            // 
            // txtKilowatthours
            // 
            this.txtKilowatthours.Location = new System.Drawing.Point(222, 172);
            this.txtKilowatthours.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtKilowatthours.Name = "txtKilowatthours";
            this.txtKilowatthours.Size = new System.Drawing.Size(152, 26);
            this.txtKilowatthours.TabIndex = 4;
            // 
            // btnCalc
            // 
            this.btnCalc.Location = new System.Drawing.Point(220, 320);
            this.btnCalc.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(150, 54);
            this.btnCalc.TabIndex = 6;
            this.btnCalc.Text = "&Calculate";
            this.btnCalc.UseVisualStyleBackColor = true;
            this.btnCalc.Click += new System.EventHandler(this.btnCalc_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(222, 477);
            this.btnClear.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(150, 54);
            this.btnClear.TabIndex = 7;
            this.btnClear.Text = "C&lear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(685, 477);
            this.btnExit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(150, 54);
            this.btnExit.TabIndex = 8;
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
            this.txtChargeTotal.Location = new System.Drawing.Point(62, 382);
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
            this.lblTotalCharge.Location = new System.Drawing.Point(19, 357);
            this.lblTotalCharge.Name = "lblTotalCharge";
            this.lblTotalCharge.Size = new System.Drawing.Size(100, 20);
            this.lblTotalCharge.TabIndex = 22;
            this.lblTotalCharge.Text = "Total Charge";
            // 
            // gbxSelectedChargeTime
            // 
            this.gbxSelectedChargeTime.Controls.Add(this.ckBxOffPeak);
            this.gbxSelectedChargeTime.Controls.Add(this.ckBxPeakHours);
            this.gbxSelectedChargeTime.Controls.Add(this.txtBxOffPeak);
            this.gbxSelectedChargeTime.Controls.Add(this.txtBxPeak);
            this.gbxSelectedChargeTime.Location = new System.Drawing.Point(15, 208);
            this.gbxSelectedChargeTime.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbxSelectedChargeTime.Name = "gbxSelectedChargeTime";
            this.gbxSelectedChargeTime.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbxSelectedChargeTime.Size = new System.Drawing.Size(371, 104);
            this.gbxSelectedChargeTime.TabIndex = 23;
            this.gbxSelectedChargeTime.TabStop = false;
            this.gbxSelectedChargeTime.Text = "ChargeTime";
            this.gbxSelectedChargeTime.Visible = false;
            // 
            // txtBxOffPeak
            // 
            this.txtBxOffPeak.Location = new System.Drawing.Point(207, 59);
            this.txtBxOffPeak.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtBxOffPeak.Name = "txtBxOffPeak";
            this.txtBxOffPeak.Size = new System.Drawing.Size(152, 26);
            this.txtBxOffPeak.TabIndex = 14;
            // 
            // txtBxPeak
            // 
            this.txtBxPeak.Location = new System.Drawing.Point(207, 25);
            this.txtBxPeak.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtBxPeak.Name = "txtBxPeak";
            this.txtBxPeak.Size = new System.Drawing.Size(152, 26);
            this.txtBxPeak.TabIndex = 13;
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
            this.gbxCustType.Location = new System.Drawing.Point(12, 91);
            this.gbxCustType.Name = "gbxCustType";
            this.gbxCustType.Size = new System.Drawing.Size(374, 77);
            this.gbxCustType.TabIndex = 26;
            this.gbxCustType.TabStop = false;
            this.gbxCustType.Text = "Customer Type";
            // 
            // ckBxPeakHours
            // 
            this.ckBxPeakHours.AutoSize = true;
            this.ckBxPeakHours.Location = new System.Drawing.Point(11, 27);
            this.ckBxPeakHours.Name = "ckBxPeakHours";
            this.ckBxPeakHours.Size = new System.Drawing.Size(118, 24);
            this.ckBxPeakHours.TabIndex = 15;
            this.ckBxPeakHours.Text = "Peak Hours";
            this.ckBxPeakHours.UseVisualStyleBackColor = true;
            // 
            // ckBxOffPeak
            // 
            this.ckBxOffPeak.AutoSize = true;
            this.ckBxOffPeak.Location = new System.Drawing.Point(11, 61);
            this.ckBxOffPeak.Name = "ckBxOffPeak";
            this.ckBxOffPeak.Size = new System.Drawing.Size(145, 24);
            this.ckBxOffPeak.TabIndex = 16;
            this.ckBxOffPeak.Text = "Off-Peak Hours";
            this.ckBxOffPeak.UseVisualStyleBackColor = true;
            // 
            // frmCityPower
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(900, 562);
            this.Controls.Add(this.gbxCustType);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblCompanyName);
            this.Controls.Add(this.gbxSelectedChargeTime);
            this.Controls.Add(this.lblTotalCharge);
            this.Controls.Add(this.txtChargeTotal);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnCalc);
            this.Controls.Add(this.txtKilowatthours);
            this.Controls.Add(this.lblkWh);
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
        private System.Windows.Forms.TextBox txtChargeTotal;
        private System.Windows.Forms.Label lblTotalCharge;
        private System.Windows.Forms.GroupBox gbxSelectedChargeTime;
        private System.Windows.Forms.Label lblCompanyName;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox gbxCustType;
        private System.Windows.Forms.TextBox txtBxOffPeak;
        private System.Windows.Forms.TextBox txtBxPeak;
        private System.Windows.Forms.CheckBox ckBxOffPeak;
        private System.Windows.Forms.CheckBox ckBxPeakHours;
    }
}

