namespace proje8_Hastane_Sistemi
{
    partial class frm_bilgi_duzenle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_bilgi_duzenle));
            this.label7 = new System.Windows.Forms.Label();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.cmbCinsiyet = new System.Windows.Forms.ComboBox();
            this.mskTel = new System.Windows.Forms.MaskedTextBox();
            this.mskTc = new System.Windows.Forms.MaskedTextBox();
            this.txtSifre = new System.Windows.Forms.TextBox();
            this.txtSoyad = new System.Windows.Forms.TextBox();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.lblCinsiyet = new System.Windows.Forms.Label();
            this.lblSifre = new System.Windows.Forms.Label();
            this.lblTel = new System.Windows.Forms.Label();
            this.lblTc = new System.Windows.Forms.Label();
            this.lblSoyad = new System.Windows.Forms.Label();
            this.lblad = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Forte", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(75, 31);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(689, 66);
            this.label7.TabIndex = 27;
            this.label7.Text = "Hasta Bilgi Güncelleme ";
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Location = new System.Drawing.Point(388, 680);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(151, 46);
            this.btnGuncelle.TabIndex = 26;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = true;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // cmbCinsiyet
            // 
            this.cmbCinsiyet.FormattingEnabled = true;
            this.cmbCinsiyet.Items.AddRange(new object[] {
            "Erkek",
            "Kadın"});
            this.cmbCinsiyet.Location = new System.Drawing.Point(352, 600);
            this.cmbCinsiyet.Name = "cmbCinsiyet";
            this.cmbCinsiyet.Size = new System.Drawing.Size(233, 48);
            this.cmbCinsiyet.TabIndex = 25;
            // 
            // mskTel
            // 
            this.mskTel.Location = new System.Drawing.Point(352, 415);
            this.mskTel.Mask = "(999) 000-0000";
            this.mskTel.Name = "mskTel";
            this.mskTel.Size = new System.Drawing.Size(233, 48);
            this.mskTel.TabIndex = 24;
            // 
            // mskTc
            // 
            this.mskTc.Enabled = false;
            this.mskTc.Location = new System.Drawing.Point(352, 320);
            this.mskTc.Mask = "00000000000";
            this.mskTc.Name = "mskTc";
            this.mskTc.Size = new System.Drawing.Size(233, 48);
            this.mskTc.TabIndex = 23;
            // 
            // txtSifre
            // 
            this.txtSifre.Location = new System.Drawing.Point(352, 516);
            this.txtSifre.Name = "txtSifre";
            this.txtSifre.Size = new System.Drawing.Size(233, 48);
            this.txtSifre.TabIndex = 22;
            // 
            // txtSoyad
            // 
            this.txtSoyad.Location = new System.Drawing.Point(352, 236);
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.Size = new System.Drawing.Size(233, 48);
            this.txtSoyad.TabIndex = 21;
            // 
            // txtAd
            // 
            this.txtAd.Location = new System.Drawing.Point(352, 159);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(233, 48);
            this.txtAd.TabIndex = 20;
            // 
            // lblCinsiyet
            // 
            this.lblCinsiyet.AutoSize = true;
            this.lblCinsiyet.Location = new System.Drawing.Point(163, 603);
            this.lblCinsiyet.Name = "lblCinsiyet";
            this.lblCinsiyet.Size = new System.Drawing.Size(141, 40);
            this.lblCinsiyet.TabIndex = 19;
            this.lblCinsiyet.Text = "Cinsiyet :";
            // 
            // lblSifre
            // 
            this.lblSifre.AutoSize = true;
            this.lblSifre.Location = new System.Drawing.Point(210, 516);
            this.lblSifre.Name = "lblSifre";
            this.lblSifre.Size = new System.Drawing.Size(96, 40);
            this.lblSifre.TabIndex = 18;
            this.lblSifre.Text = "Şifre :";
            // 
            // lblTel
            // 
            this.lblTel.AutoSize = true;
            this.lblTel.Location = new System.Drawing.Point(170, 422);
            this.lblTel.Name = "lblTel";
            this.lblTel.Size = new System.Drawing.Size(134, 40);
            this.lblTel.TabIndex = 17;
            this.lblTel.Text = "Telefon :";
            // 
            // lblTc
            // 
            this.lblTc.AutoSize = true;
            this.lblTc.Location = new System.Drawing.Point(141, 327);
            this.lblTc.Name = "lblTc";
            this.lblTc.Size = new System.Drawing.Size(163, 40);
            this.lblTc.TabIndex = 16;
            this.lblTc.Text = "TC Kimlik :";
            // 
            // lblSoyad
            // 
            this.lblSoyad.AutoSize = true;
            this.lblSoyad.Location = new System.Drawing.Point(188, 239);
            this.lblSoyad.Name = "lblSoyad";
            this.lblSoyad.Size = new System.Drawing.Size(119, 40);
            this.lblSoyad.TabIndex = 15;
            this.lblSoyad.Text = "Soyad :";
            // 
            // lblad
            // 
            this.lblad.AutoSize = true;
            this.lblad.Location = new System.Drawing.Point(236, 159);
            this.lblad.Name = "lblad";
            this.lblad.Size = new System.Drawing.Size(72, 40);
            this.lblad.TabIndex = 14;
            this.lblad.Text = "Ad :";
            // 
            // frm_bilgi_duzenle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(18F, 40F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(844, 752);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.cmbCinsiyet);
            this.Controls.Add(this.mskTel);
            this.Controls.Add(this.mskTc);
            this.Controls.Add(this.txtSifre);
            this.Controls.Add(this.txtSoyad);
            this.Controls.Add(this.txtAd);
            this.Controls.Add(this.lblCinsiyet);
            this.Controls.Add(this.lblSifre);
            this.Controls.Add(this.lblTel);
            this.Controls.Add(this.lblTc);
            this.Controls.Add(this.lblSoyad);
            this.Controls.Add(this.lblad);
            this.Font = new System.Drawing.Font("Corbel", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.MaximizeBox = false;
            this.Name = "frm_bilgi_duzenle";
            this.Text = "Hasta Bilgi Güncelleme";
            this.Load += new System.EventHandler(this.frm_bilgi_duzenle_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.ComboBox cmbCinsiyet;
        private System.Windows.Forms.MaskedTextBox mskTel;
        private System.Windows.Forms.MaskedTextBox mskTc;
        private System.Windows.Forms.TextBox txtSifre;
        private System.Windows.Forms.TextBox txtSoyad;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.Label lblCinsiyet;
        private System.Windows.Forms.Label lblSifre;
        private System.Windows.Forms.Label lblTel;
        private System.Windows.Forms.Label lblTc;
        private System.Windows.Forms.Label lblSoyad;
        private System.Windows.Forms.Label lblad;
    }
}