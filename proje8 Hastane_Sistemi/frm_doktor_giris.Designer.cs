namespace proje8_Hastane_Sistemi
{
    partial class frm_doktor_giris
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnGirişYap = new System.Windows.Forms.Button();
            this.mskTc = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblTc = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(268, 354);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(254, 48);
            this.textBox1.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(151, 354);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 40);
            this.label1.TabIndex = 13;
            this.label1.Text = "Şifre :";
            // 
            // btnGirişYap
            // 
            this.btnGirişYap.Location = new System.Drawing.Point(321, 441);
            this.btnGirişYap.Name = "btnGirişYap";
            this.btnGirişYap.Size = new System.Drawing.Size(130, 51);
            this.btnGirişYap.TabIndex = 12;
            this.btnGirişYap.Text = "Giriş Yap";
            this.btnGirişYap.UseVisualStyleBackColor = true;
            this.btnGirişYap.Click += new System.EventHandler(this.btnGirişYap_Click);
            // 
            // mskTc
            // 
            this.mskTc.Location = new System.Drawing.Point(268, 267);
            this.mskTc.Mask = "00000000000";
            this.mskTc.Name = "mskTc";
            this.mskTc.Size = new System.Drawing.Size(254, 48);
            this.mskTc.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Forte", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(174, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(348, 66);
            this.label3.TabIndex = 10;
            this.label3.Text = "Doktor Giriş";
            // 
            // lblTc
            // 
            this.lblTc.AutoSize = true;
            this.lblTc.Location = new System.Drawing.Point(91, 271);
            this.lblTc.Name = "lblTc";
            this.lblTc.Size = new System.Drawing.Size(163, 40);
            this.lblTc.TabIndex = 9;
            this.lblTc.Text = "TC Kimlik :";
            // 
            // frm_doktor_giris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(18F, 40F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(729, 636);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnGirişYap);
            this.Controls.Add(this.mskTc);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblTc);
            this.Font = new System.Drawing.Font("Corbel", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.Name = "frm_doktor_giris";
            this.Text = "frm_doktor_giris";
            this.Load += new System.EventHandler(this.frm_doktor_giris_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnGirişYap;
        private System.Windows.Forms.MaskedTextBox mskTc;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblTc;
    }
}