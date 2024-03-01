namespace proje8_Hastane_Sistemi
{
    partial class frm_doktor_ekran
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
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.richtxtSikayet = new System.Windows.Forms.RichTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.lblAdSoyad = new System.Windows.Forms.Label();
            this.lblTcNo = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblTc = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnCikis = new System.Windows.Forms.Button();
            this.btnDuyuru = new System.Windows.Forms.Button();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dataGridView1);
            this.groupBox3.Location = new System.Drawing.Point(499, 4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(737, 706);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Randevu Geçmişi";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 44);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(731, 659);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.richtxtSikayet);
            this.groupBox2.Location = new System.Drawing.Point(31, 248);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(437, 350);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Şikayet";
            // 
            // richtxtSikayet
            // 
            this.richtxtSikayet.Location = new System.Drawing.Point(13, 57);
            this.richtxtSikayet.Name = "richtxtSikayet";
            this.richtxtSikayet.Size = new System.Drawing.Size(405, 275);
            this.richtxtSikayet.TabIndex = 0;
            this.richtxtSikayet.Text = "";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.linkLabel1);
            this.groupBox1.Controls.Add(this.lblAdSoyad);
            this.groupBox1.Controls.Add(this.lblTcNo);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.lblTc);
            this.groupBox1.Location = new System.Drawing.Point(31, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(437, 238);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Doktor Bilgisi";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Corbel", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.linkLabel1.Location = new System.Drawing.Point(268, 207);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(163, 28);
            this.linkLabel1.TabIndex = 4;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Bilgileri Düzenle";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // lblAdSoyad
            // 
            this.lblAdSoyad.AutoSize = true;
            this.lblAdSoyad.Location = new System.Drawing.Point(192, 141);
            this.lblAdSoyad.Name = "lblAdSoyad";
            this.lblAdSoyad.Size = new System.Drawing.Size(124, 40);
            this.lblAdSoyad.TabIndex = 3;
            this.lblAdSoyad.Text = "null null";
            // 
            // lblTcNo
            // 
            this.lblTcNo.AutoSize = true;
            this.lblTcNo.Location = new System.Drawing.Point(192, 73);
            this.lblTcNo.Name = "lblTcNo";
            this.lblTcNo.Size = new System.Drawing.Size(204, 40);
            this.lblTcNo.TabIndex = 2;
            this.lblTcNo.Text = "00000000000";
            this.lblTcNo.Click += new System.EventHandler(this.lblTcNo_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 141);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(164, 40);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ad Soyad :";
            // 
            // lblTc
            // 
            this.lblTc.AutoSize = true;
            this.lblTc.Location = new System.Drawing.Point(53, 73);
            this.lblTc.Name = "lblTc";
            this.lblTc.Size = new System.Drawing.Size(117, 40);
            this.lblTc.TabIndex = 0;
            this.lblTc.Text = "TC No :";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnCikis);
            this.groupBox4.Controls.Add(this.btnDuyuru);
            this.groupBox4.Location = new System.Drawing.Point(31, 604);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(437, 103);
            this.groupBox4.TabIndex = 6;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Erişim";
            // 
            // btnCikis
            // 
            this.btnCikis.Location = new System.Drawing.Point(235, 47);
            this.btnCikis.Name = "btnCikis";
            this.btnCikis.Size = new System.Drawing.Size(183, 47);
            this.btnCikis.TabIndex = 1;
            this.btnCikis.Text = "Çıkış";
            this.btnCikis.UseVisualStyleBackColor = true;
            this.btnCikis.Click += new System.EventHandler(this.btnCikis_Click);
            // 
            // btnDuyuru
            // 
            this.btnDuyuru.Location = new System.Drawing.Point(22, 47);
            this.btnDuyuru.Name = "btnDuyuru";
            this.btnDuyuru.Size = new System.Drawing.Size(183, 47);
            this.btnDuyuru.TabIndex = 0;
            this.btnDuyuru.Text = "Duyurular";
            this.btnDuyuru.UseVisualStyleBackColor = true;
            this.btnDuyuru.Click += new System.EventHandler(this.btnDuyuru_Click);
            // 
            // frm_doktor_ekran
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(18F, 40F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(1266, 722);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Corbel", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.Name = "frm_doktor_ekran";
            this.Text = "frm_doktor_ekran";
            this.Load += new System.EventHandler(this.frm_doktor_ekran_Load);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label lblAdSoyad;
        private System.Windows.Forms.Label lblTcNo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblTc;
        private System.Windows.Forms.RichTextBox richtxtSikayet;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnCikis;
        private System.Windows.Forms.Button btnDuyuru;
    }
}