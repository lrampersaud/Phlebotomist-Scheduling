namespace Phlebotomist_Scheduling
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtMaximumTime = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMimimumTime = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPhlebotomists = new System.Windows.Forms.TextBox();
            this.txtPatients = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnComute = new System.Windows.Forms.Button();
            this.dgSchedule = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtCoolRate = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtInitialTemperature = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblCost = new System.Windows.Forms.Label();
            this.txtRestarts = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtStartHour = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtEndHour = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgSchedule)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtEndHour);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.txtStartHour);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.txtRestarts);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.txtInitialTemperature);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txtCoolRate);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtMaximumTime);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtMimimumTime);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtPhlebotomists);
            this.groupBox1.Controls.Add(this.txtPatients);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnComute);
            this.groupBox1.Location = new System.Drawing.Point(711, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(216, 590);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Input";
            // 
            // txtMaximumTime
            // 
            this.txtMaximumTime.Location = new System.Drawing.Point(14, 47);
            this.txtMaximumTime.Name = "txtMaximumTime";
            this.txtMaximumTime.Size = new System.Drawing.Size(124, 20);
            this.txtMaximumTime.TabIndex = 8;
            this.txtMaximumTime.Text = "25";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(133, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Maximum Time for Patients";
            // 
            // txtMimimumTime
            // 
            this.txtMimimumTime.Location = new System.Drawing.Point(14, 105);
            this.txtMimimumTime.Name = "txtMimimumTime";
            this.txtMimimumTime.Size = new System.Drawing.Size(124, 20);
            this.txtMimimumTime.TabIndex = 6;
            this.txtMimimumTime.Text = "12";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Minimum Time for Patients";
            // 
            // txtPhlebotomists
            // 
            this.txtPhlebotomists.Location = new System.Drawing.Point(14, 165);
            this.txtPhlebotomists.Name = "txtPhlebotomists";
            this.txtPhlebotomists.Size = new System.Drawing.Size(198, 20);
            this.txtPhlebotomists.TabIndex = 4;
            this.txtPhlebotomists.Text = "2";
            // 
            // txtPatients
            // 
            this.txtPatients.Location = new System.Drawing.Point(14, 229);
            this.txtPatients.Name = "txtPatients";
            this.txtPatients.Size = new System.Drawing.Size(198, 20);
            this.txtPatients.TabIndex = 3;
            this.txtPatients.Text = "15";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 212);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Number of Patients";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 148);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Number of Phlebotomists";
            // 
            // btnComute
            // 
            this.btnComute.Location = new System.Drawing.Point(66, 549);
            this.btnComute.Name = "btnComute";
            this.btnComute.Size = new System.Drawing.Size(75, 23);
            this.btnComute.TabIndex = 0;
            this.btnComute.Text = "Start";
            this.btnComute.UseVisualStyleBackColor = true;
            this.btnComute.Click += new System.EventHandler(this.btnComute_Click);
            // 
            // dgSchedule
            // 
            this.dgSchedule.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgSchedule.Location = new System.Drawing.Point(12, 12);
            this.dgSchedule.Name = "dgSchedule";
            this.dgSchedule.Size = new System.Drawing.Size(678, 528);
            this.dgSchedule.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(145, 53);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(28, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "mins";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(145, 112);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(28, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "mins";
            // 
            // txtCoolRate
            // 
            this.txtCoolRate.Location = new System.Drawing.Point(17, 395);
            this.txtCoolRate.Name = "txtCoolRate";
            this.txtCoolRate.Size = new System.Drawing.Size(124, 20);
            this.txtCoolRate.TabIndex = 12;
            this.txtCoolRate.Text = "0.8";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(11, 379);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "Cooling Rate";
            // 
            // txtInitialTemperature
            // 
            this.txtInitialTemperature.Location = new System.Drawing.Point(17, 459);
            this.txtInitialTemperature.Name = "txtInitialTemperature";
            this.txtInitialTemperature.Size = new System.Drawing.Size(124, 20);
            this.txtInitialTemperature.TabIndex = 14;
            this.txtInitialTemperature.Text = "100";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(11, 443);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(94, 13);
            this.label8.TabIndex = 13;
            this.label8.Text = "Initial Temperature";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(14, 564);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(119, 20);
            this.label9.TabIndex = 2;
            this.label9.Text = "Solution cost:";
            // 
            // lblCost
            // 
            this.lblCost.AutoSize = true;
            this.lblCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCost.ForeColor = System.Drawing.Color.Maroon;
            this.lblCost.Location = new System.Drawing.Point(139, 564);
            this.lblCost.Name = "lblCost";
            this.lblCost.Size = new System.Drawing.Size(19, 20);
            this.lblCost.TabIndex = 3;
            this.lblCost.Text = "0";
            // 
            // txtRestarts
            // 
            this.txtRestarts.Location = new System.Drawing.Point(17, 508);
            this.txtRestarts.Name = "txtRestarts";
            this.txtRestarts.Size = new System.Drawing.Size(124, 20);
            this.txtRestarts.TabIndex = 16;
            this.txtRestarts.Text = "10";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(11, 492);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(46, 13);
            this.label10.TabIndex = 15;
            this.label10.Text = "Restarts";
            // 
            // txtStartHour
            // 
            this.txtStartHour.Location = new System.Drawing.Point(17, 293);
            this.txtStartHour.Name = "txtStartHour";
            this.txtStartHour.Size = new System.Drawing.Size(124, 20);
            this.txtStartHour.TabIndex = 18;
            this.txtStartHour.Text = "8";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(11, 277);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(85, 13);
            this.label11.TabIndex = 17;
            this.label11.Text = "Start Hour (24 h)";
            // 
            // txtEndHour
            // 
            this.txtEndHour.Location = new System.Drawing.Point(17, 344);
            this.txtEndHour.Name = "txtEndHour";
            this.txtEndHour.Size = new System.Drawing.Size(124, 20);
            this.txtEndHour.TabIndex = 20;
            this.txtEndHour.Text = "10";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(11, 328);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(79, 13);
            this.label12.TabIndex = 19;
            this.label12.Text = "End Hour (24h)";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(939, 614);
            this.Controls.Add(this.lblCost);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.dgSchedule);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmMain";
            this.Text = "Phlebotomist  Scheduling";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgSchedule)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtPhlebotomists;
        private System.Windows.Forms.TextBox txtPatients;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnComute;
        private System.Windows.Forms.TextBox txtMimimumTime;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMaximumTime;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dgSchedule;
        private System.Windows.Forms.TextBox txtInitialTemperature;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtCoolRate;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblCost;
        private System.Windows.Forms.TextBox txtRestarts;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtEndHour;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtStartHour;
        private System.Windows.Forms.Label label11;
    }
}

