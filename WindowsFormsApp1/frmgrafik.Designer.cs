namespace WindowsFormsApp1
{
    partial class frmgrafik
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.progressBar2 = new System.Windows.Forms.ProgressBar();
            this.progressBar3 = new System.Windows.Forms.ProgressBar();
            this.progressBar4 = new System.Windows.Forms.ProgressBar();
            this.progressBar5 = new System.Windows.Forms.ProgressBar();
            this.lblakp = new System.Windows.Forms.Label();
            this.lblchp = new System.Windows.Forms.Label();
            this.lblmhp = new System.Windows.Forms.Label();
            this.lblıyıp = new System.Windows.Forms.Label();
            this.lblhdp = new System.Windows.Forms.Label();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chart1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1217, 387);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Grafik";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.comboBox1);
            this.groupBox2.Controls.Add(this.lblhdp);
            this.groupBox2.Controls.Add(this.lblıyıp);
            this.groupBox2.Controls.Add(this.lblmhp);
            this.groupBox2.Controls.Add(this.lblchp);
            this.groupBox2.Controls.Add(this.lblakp);
            this.groupBox2.Controls.Add(this.progressBar5);
            this.groupBox2.Controls.Add(this.progressBar4);
            this.groupBox2.Controls.Add(this.progressBar3);
            this.groupBox2.Controls.Add(this.progressBar2);
            this.groupBox2.Controls.Add(this.progressBar1);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(12, 405);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1217, 382);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "İlçe Değerleri";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "İLÇE AD :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(109, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 27);
            this.label2.TabIndex = 1;
            this.label2.Text = "AKP :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(108, 164);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 27);
            this.label3.TabIndex = 2;
            this.label3.Text = "CHP :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(100, 210);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 27);
            this.label4.TabIndex = 3;
            this.label4.Text = "MHP :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(108, 254);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 27);
            this.label5.TabIndex = 4;
            this.label5.Text = "IYIP :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(105, 305);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 27);
            this.label6.TabIndex = 5;
            this.label6.Text = "HDP :";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(214, 119);
            this.progressBar1.Maximum = 500;
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(801, 23);
            this.progressBar1.TabIndex = 6;
            // 
            // progressBar2
            // 
            this.progressBar2.Location = new System.Drawing.Point(214, 164);
            this.progressBar2.Maximum = 500;
            this.progressBar2.Name = "progressBar2";
            this.progressBar2.Size = new System.Drawing.Size(801, 23);
            this.progressBar2.TabIndex = 7;
            // 
            // progressBar3
            // 
            this.progressBar3.Location = new System.Drawing.Point(214, 210);
            this.progressBar3.Maximum = 500;
            this.progressBar3.Name = "progressBar3";
            this.progressBar3.Size = new System.Drawing.Size(801, 23);
            this.progressBar3.TabIndex = 8;
            // 
            // progressBar4
            // 
            this.progressBar4.Location = new System.Drawing.Point(214, 258);
            this.progressBar4.Maximum = 500;
            this.progressBar4.Name = "progressBar4";
            this.progressBar4.Size = new System.Drawing.Size(801, 23);
            this.progressBar4.TabIndex = 9;
            // 
            // progressBar5
            // 
            this.progressBar5.Location = new System.Drawing.Point(214, 309);
            this.progressBar5.Maximum = 500;
            this.progressBar5.Name = "progressBar5";
            this.progressBar5.Size = new System.Drawing.Size(801, 23);
            this.progressBar5.TabIndex = 10;
            // 
            // lblakp
            // 
            this.lblakp.AutoSize = true;
            this.lblakp.Location = new System.Drawing.Point(1044, 119);
            this.lblakp.Name = "lblakp";
            this.lblakp.Size = new System.Drawing.Size(44, 27);
            this.lblakp.TabIndex = 11;
            this.lblakp.Text = "00";
            // 
            // lblchp
            // 
            this.lblchp.AutoSize = true;
            this.lblchp.Location = new System.Drawing.Point(1044, 164);
            this.lblchp.Name = "lblchp";
            this.lblchp.Size = new System.Drawing.Size(44, 27);
            this.lblchp.TabIndex = 12;
            this.lblchp.Text = "00";
            // 
            // lblmhp
            // 
            this.lblmhp.AutoSize = true;
            this.lblmhp.Location = new System.Drawing.Point(1044, 210);
            this.lblmhp.Name = "lblmhp";
            this.lblmhp.Size = new System.Drawing.Size(44, 27);
            this.lblmhp.TabIndex = 13;
            this.lblmhp.Text = "00";
            // 
            // lblıyıp
            // 
            this.lblıyıp.AutoSize = true;
            this.lblıyıp.Location = new System.Drawing.Point(1044, 254);
            this.lblıyıp.Name = "lblıyıp";
            this.lblıyıp.Size = new System.Drawing.Size(44, 27);
            this.lblıyıp.TabIndex = 14;
            this.lblıyıp.Text = "00";
            // 
            // lblhdp
            // 
            this.lblhdp.AutoSize = true;
            this.lblhdp.Location = new System.Drawing.Point(1044, 305);
            this.lblhdp.Name = "lblhdp";
            this.lblhdp.Size = new System.Drawing.Size(44, 27);
            this.lblhdp.TabIndex = 15;
            this.lblhdp.Text = "00";
            // 
            // chart1
            // 
            chartArea3.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea3);
            this.chart1.Dock = System.Windows.Forms.DockStyle.Fill;
            legend3.Name = "Legend1";
            this.chart1.Legends.Add(legend3);
            this.chart1.Location = new System.Drawing.Point(3, 30);
            this.chart1.Name = "chart1";
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "Partiler";
            this.chart1.Series.Add(series3);
            this.chart1.Size = new System.Drawing.Size(1211, 354);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(167, 46);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(242, 35);
            this.comboBox1.TabIndex = 16;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // frmgrafik
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Bisque;
            this.ClientSize = new System.Drawing.Size(1241, 789);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Georgia", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "frmgrafik";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.frmgrafik_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Label lblhdp;
        private System.Windows.Forms.Label lblıyıp;
        private System.Windows.Forms.Label lblmhp;
        private System.Windows.Forms.Label lblchp;
        private System.Windows.Forms.Label lblakp;
        private System.Windows.Forms.ProgressBar progressBar5;
        private System.Windows.Forms.ProgressBar progressBar4;
        private System.Windows.Forms.ProgressBar progressBar3;
        private System.Windows.Forms.ProgressBar progressBar2;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}