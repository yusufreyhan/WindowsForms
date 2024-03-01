namespace proje10_ogrencikulup
{
    partial class frmogretmen
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
            this.btnders = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnsınav = new System.Windows.Forms.Button();
            this.btnogrt = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnders
            // 
            this.btnders.Location = new System.Drawing.Point(12, 38);
            this.btnders.Name = "btnders";
            this.btnders.Size = new System.Drawing.Size(357, 73);
            this.btnders.TabIndex = 0;
            this.btnders.Text = "Ders İşlemleri";
            this.btnders.UseVisualStyleBackColor = true;
            this.btnders.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 117);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(357, 73);
            this.button2.TabIndex = 1;
            this.button2.Text = "Kulüp İşlemleri";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnsınav
            // 
            this.btnsınav.Location = new System.Drawing.Point(12, 196);
            this.btnsınav.Name = "btnsınav";
            this.btnsınav.Size = new System.Drawing.Size(357, 73);
            this.btnsınav.TabIndex = 2;
            this.btnsınav.Text = "Sınav Notları";
            this.btnsınav.UseVisualStyleBackColor = true;
            // 
            // btnogrt
            // 
            this.btnogrt.Location = new System.Drawing.Point(12, 275);
            this.btnogrt.Name = "btnogrt";
            this.btnogrt.Size = new System.Drawing.Size(357, 73);
            this.btnogrt.TabIndex = 3;
            this.btnogrt.Text = "Öğretmenler";
            this.btnogrt.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(12, 354);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(357, 73);
            this.button5.TabIndex = 4;
            this.button5.Text = "Öğrenci İşlemleri";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // frmogretmen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 36F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(403, 467);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.btnogrt);
            this.Controls.Add(this.btnsınav);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnders);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.Name = "frmogretmen";
            this.Text = "Form2";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnders;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnsınav;
        private System.Windows.Forms.Button btnogrt;
        private System.Windows.Forms.Button button5;
    }
}