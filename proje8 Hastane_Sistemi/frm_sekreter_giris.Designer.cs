namespace proje8_Hastane_Sistemi
{
    partial class frm_sekreter_giris
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_sekreter_giris));
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
            this.textBox1.Location = new System.Drawing.Point(284, 297);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(254, 48);
            this.textBox1.TabIndex = 2;
            this.textBox1.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(167, 297);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 40);
            this.label1.TabIndex = 13;
            this.label1.Text = "Şifre :";
            // 
            // btnGirişYap
            // 
            this.btnGirişYap.Location = new System.Drawing.Point(309, 405);
            this.btnGirişYap.Name = "btnGirişYap";
            this.btnGirişYap.Size = new System.Drawing.Size(141, 42);
            this.btnGirişYap.TabIndex = 12;
            this.btnGirişYap.Text = "Giriş Yap";
            this.btnGirişYap.UseVisualStyleBackColor = true;
            this.btnGirişYap.Click += new System.EventHandler(this.btnGirişYap_Click);
            // 
            // mskTc
            // 
            this.mskTc.Location = new System.Drawing.Point(284, 210);
            this.mskTc.Mask = "00000000000";
            this.mskTc.Name = "mskTc";
            this.mskTc.Size = new System.Drawing.Size(254, 48);
            this.mskTc.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Forte", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(163, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(388, 66);
            this.label3.TabIndex = 10;
            this.label3.Text = "Sekreter Giriş ";
            // 
            // lblTc
            // 
            this.lblTc.AutoSize = true;
            this.lblTc.Location = new System.Drawing.Point(107, 214);
            this.lblTc.Name = "lblTc";
            this.lblTc.Size = new System.Drawing.Size(163, 40);
            this.lblTc.TabIndex = 9;
            this.lblTc.Text = "TC Kimlik :";
            // 
            // frm_sekreter_giris
            // 
            this.AcceptButton = this.btnGirişYap;
            this.AutoScaleDimensions = new System.Drawing.SizeF(18F, 40F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Indigo;
            this.ClientSize = new System.Drawing.Size(715, 555);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnGirişYap);
            this.Controls.Add(this.mskTc);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblTc);
            this.Font = new System.Drawing.Font("Corbel", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.MaximizeBox = false;
            this.Name = "frm_sekreter_giris";
            this.Text = "Sekreter Giriş";
            this.Load += new System.EventHandler(this.frm_sekreter_giris_Load);
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