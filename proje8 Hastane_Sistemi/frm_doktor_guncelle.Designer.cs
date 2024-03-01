namespace proje8_Hastane_Sistemi
{
    partial class frm_doktor_guncelle
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
            this.label7 = new System.Windows.Forms.Label();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.cmbBrans = new System.Windows.Forms.ComboBox();
            this.mskTc = new System.Windows.Forms.MaskedTextBox();
            this.txtSifre = new System.Windows.Forms.TextBox();
            this.txtSoyad = new System.Windows.Forms.TextBox();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.lblCinsiyet = new System.Windows.Forms.Label();
            this.lblSifre = new System.Windows.Forms.Label();
            this.lblTc = new System.Windows.Forms.Label();
            this.lblSoyad = new System.Windows.Forms.Label();
            this.lblad = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Forte", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(110, 19);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(708, 66);
            this.label7.TabIndex = 41;
            this.label7.Text = "Doktor Bilgi Güncelleme ";
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Location = new System.Drawing.Point(420, 585);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(151, 46);
            this.btnGuncelle.TabIndex = 40;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = true;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // cmbBrans
            // 
            this.cmbBrans.FormattingEnabled = true;
            this.cmbBrans.Items.AddRange(new object[] {
            "Erkek",
            "Kadın"});
            this.cmbBrans.Location = new System.Drawing.Point(387, 491);
            this.cmbBrans.Name = "cmbBrans";
            this.cmbBrans.Size = new System.Drawing.Size(233, 45);
            this.cmbBrans.TabIndex = 39;
            this.cmbBrans.SelectedIndexChanged += new System.EventHandler(this.cmbBrans_SelectedIndexChanged);
            // 
            // mskTc
            // 
            this.mskTc.Location = new System.Drawing.Point(387, 308);
            this.mskTc.Mask = "00000000000";
            this.mskTc.Name = "mskTc";
            this.mskTc.Size = new System.Drawing.Size(233, 44);
            this.mskTc.TabIndex = 37;
            // 
            // txtSifre
            // 
            this.txtSifre.Location = new System.Drawing.Point(387, 401);
            this.txtSifre.Name = "txtSifre";
            this.txtSifre.Size = new System.Drawing.Size(233, 44);
            this.txtSifre.TabIndex = 36;
            // 
            // txtSoyad
            // 
            this.txtSoyad.Location = new System.Drawing.Point(387, 224);
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.Size = new System.Drawing.Size(233, 44);
            this.txtSoyad.TabIndex = 35;
            // 
            // txtAd
            // 
            this.txtAd.Location = new System.Drawing.Point(387, 147);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(233, 44);
            this.txtAd.TabIndex = 34;
            // 
            // lblCinsiyet
            // 
            this.lblCinsiyet.AutoSize = true;
            this.lblCinsiyet.Location = new System.Drawing.Point(224, 494);
            this.lblCinsiyet.Name = "lblCinsiyet";
            this.lblCinsiyet.Size = new System.Drawing.Size(102, 37);
            this.lblCinsiyet.TabIndex = 33;
            this.lblCinsiyet.Text = "Branş :";
            // 
            // lblSifre
            // 
            this.lblSifre.AutoSize = true;
            this.lblSifre.Location = new System.Drawing.Point(245, 401);
            this.lblSifre.Name = "lblSifre";
            this.lblSifre.Size = new System.Drawing.Size(90, 37);
            this.lblSifre.TabIndex = 32;
            this.lblSifre.Text = "Şifre :";
            // 
            // lblTc
            // 
            this.lblTc.AutoSize = true;
            this.lblTc.Location = new System.Drawing.Point(176, 315);
            this.lblTc.Name = "lblTc";
            this.lblTc.Size = new System.Drawing.Size(150, 37);
            this.lblTc.TabIndex = 30;
            this.lblTc.Text = "TC Kimlik :";
            // 
            // lblSoyad
            // 
            this.lblSoyad.AutoSize = true;
            this.lblSoyad.Location = new System.Drawing.Point(223, 227);
            this.lblSoyad.Name = "lblSoyad";
            this.lblSoyad.Size = new System.Drawing.Size(109, 37);
            this.lblSoyad.TabIndex = 29;
            this.lblSoyad.Text = "Soyad :";
            // 
            // lblad
            // 
            this.lblad.AutoSize = true;
            this.lblad.Location = new System.Drawing.Point(271, 147);
            this.lblad.Name = "lblad";
            this.lblad.Size = new System.Drawing.Size(66, 37);
            this.lblad.TabIndex = 28;
            this.lblad.Text = "Ad :";
            // 
            // frm_doktor_guncelle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(909, 695);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.cmbBrans);
            this.Controls.Add(this.mskTc);
            this.Controls.Add(this.txtSifre);
            this.Controls.Add(this.txtSoyad);
            this.Controls.Add(this.txtAd);
            this.Controls.Add(this.lblCinsiyet);
            this.Controls.Add(this.lblSifre);
            this.Controls.Add(this.lblTc);
            this.Controls.Add(this.lblSoyad);
            this.Controls.Add(this.lblad);
            this.Font = new System.Drawing.Font("Corbel", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.Name = "frm_doktor_guncelle";
            this.Text = "frm_doktor_guncelle";
            this.Load += new System.EventHandler(this.frm_doktor_guncelle_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.ComboBox cmbBrans;
        private System.Windows.Forms.MaskedTextBox mskTc;
        private System.Windows.Forms.TextBox txtSifre;
        private System.Windows.Forms.TextBox txtSoyad;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.Label lblCinsiyet;
        private System.Windows.Forms.Label lblSifre;
        private System.Windows.Forms.Label lblTc;
        private System.Windows.Forms.Label lblSoyad;
        private System.Windows.Forms.Label lblad;
    }
}