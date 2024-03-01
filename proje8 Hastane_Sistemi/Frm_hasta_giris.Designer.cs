namespace proje8_Hastane_Sistemi
{
    partial class Frm_hasta_giris
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_hasta_giris));
            this.lblTc = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.mskTc = new System.Windows.Forms.MaskedTextBox();
            this.btnGirişYap = new System.Windows.Forms.Button();
            this.lnklblÜyeOl = new System.Windows.Forms.LinkLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblTc
            // 
            this.lblTc.AutoSize = true;
            this.lblTc.Location = new System.Drawing.Point(78, 202);
            this.lblTc.Name = "lblTc";
            this.lblTc.Size = new System.Drawing.Size(150, 37);
            this.lblTc.TabIndex = 1;
            this.lblTc.Text = "TC Kimlik :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Forte", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(173, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(346, 66);
            this.label3.TabIndex = 2;
            this.label3.Text = "Hasta Giriş ";
            // 
            // mskTc
            // 
            this.mskTc.Location = new System.Drawing.Point(255, 198);
            this.mskTc.Mask = "00000000000";
            this.mskTc.Name = "mskTc";
            this.mskTc.Size = new System.Drawing.Size(254, 44);
            this.mskTc.TabIndex = 1;
            // 
            // btnGirişYap
            // 
            this.btnGirişYap.Location = new System.Drawing.Point(301, 366);
            this.btnGirişYap.Name = "btnGirişYap";
            this.btnGirişYap.Size = new System.Drawing.Size(141, 42);
            this.btnGirişYap.TabIndex = 5;
            this.btnGirişYap.Text = "Giriş Yap";
            this.btnGirişYap.UseVisualStyleBackColor = true;
            this.btnGirişYap.Click += new System.EventHandler(this.btnGirişYap_Click);
            // 
            // lnklblÜyeOl
            // 
            this.lnklblÜyeOl.AutoSize = true;
            this.lnklblÜyeOl.Location = new System.Drawing.Point(324, 438);
            this.lnklblÜyeOl.Name = "lnklblÜyeOl";
            this.lnklblÜyeOl.Size = new System.Drawing.Size(100, 37);
            this.lnklblÜyeOl.TabIndex = 6;
            this.lnklblÜyeOl.TabStop = true;
            this.lnklblÜyeOl.Text = "Üye Ol";
            this.lnklblÜyeOl.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnklblÜyeOl_LinkClicked);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(138, 285);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 37);
            this.label1.TabIndex = 7;
            this.label1.Text = "Şifre :";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(255, 285);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(254, 44);
            this.textBox1.TabIndex = 2;
            this.textBox1.UseSystemPasswordChar = true;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Frm_hasta_giris
            // 
            this.AcceptButton = this.btnGirişYap;
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(628, 511);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lnklblÜyeOl);
            this.Controls.Add(this.btnGirişYap);
            this.Controls.Add(this.mskTc);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblTc);
            this.Font = new System.Drawing.Font("Corbel", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.MaximizeBox = false;
            this.Name = "Frm_hasta_giris";
            this.Text = "Hasta Giriş";
            this.Load += new System.EventHandler(this.Frm_hasta_giris_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblTc;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox mskTc;
        private System.Windows.Forms.Button btnGirişYap;
        private System.Windows.Forms.LinkLabel lnklblÜyeOl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
    }
}