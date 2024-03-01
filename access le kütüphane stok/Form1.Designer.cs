namespace access_le_kütüphane_stok
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtid = new System.Windows.Forms.TextBox();
            this.txtad = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtyazar = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbtür = new System.Windows.Forms.ComboBox();
            this.rdbtn2 = new System.Windows.Forms.RadioButton();
            this.rdbtn0 = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtsayfa = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnlistele = new System.Windows.Forms.Button();
            this.btmkaydet = new System.Windows.Forms.Button();
            this.btnsil = new System.Windows.Forms.Button();
            this.btngüncelle = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(8, 472);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1442, 327);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Corbel", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(88, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 40);
            this.label1.TabIndex = 1;
            this.label1.Text = "Kitap id :";
            // 
            // txtid
            // 
            this.txtid.Enabled = false;
            this.txtid.Font = new System.Drawing.Font("Corbel", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtid.Location = new System.Drawing.Point(257, 76);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(239, 48);
            this.txtid.TabIndex = 2;
            // 
            // txtad
            // 
            this.txtad.Font = new System.Drawing.Font("Corbel", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtad.Location = new System.Drawing.Point(257, 140);
            this.txtad.Name = "txtad";
            this.txtad.Size = new System.Drawing.Size(239, 48);
            this.txtad.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Corbel", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(80, 147);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 40);
            this.label2.TabIndex = 3;
            this.label2.Text = "Kitap ad :";
            // 
            // txtyazar
            // 
            this.txtyazar.Font = new System.Drawing.Font("Corbel", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtyazar.Location = new System.Drawing.Point(257, 203);
            this.txtyazar.Name = "txtyazar";
            this.txtyazar.Size = new System.Drawing.Size(239, 48);
            this.txtyazar.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Corbel", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(38, 206);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(187, 40);
            this.label3.TabIndex = 5;
            this.label3.Text = "Kitap yazar :";
            // 
            // cmbtür
            // 
            this.cmbtür.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbtür.Font = new System.Drawing.Font("Corbel", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbtür.FormattingEnabled = true;
            this.cmbtür.Items.AddRange(new object[] {
            "Hikaye",
            "Roman",
            "Şiir",
            "Tiyatro"});
            this.cmbtür.Location = new System.Drawing.Point(257, 337);
            this.cmbtür.Name = "cmbtür";
            this.cmbtür.Size = new System.Drawing.Size(239, 48);
            this.cmbtür.TabIndex = 7;
            // 
            // rdbtn2
            // 
            this.rdbtn2.AutoSize = true;
            this.rdbtn2.Font = new System.Drawing.Font("Corbel", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rdbtn2.Location = new System.Drawing.Point(257, 402);
            this.rdbtn2.Name = "rdbtn2";
            this.rdbtn2.Size = new System.Drawing.Size(95, 44);
            this.rdbtn2.TabIndex = 8;
            this.rdbtn2.TabStop = true;
            this.rdbtn2.Text = "2. el";
            this.rdbtn2.UseVisualStyleBackColor = true;
            this.rdbtn2.CheckedChanged += new System.EventHandler(this.rdbtn2_CheckedChanged);
            // 
            // rdbtn0
            // 
            this.rdbtn0.AutoSize = true;
            this.rdbtn0.Font = new System.Drawing.Font("Corbel", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rdbtn0.Location = new System.Drawing.Point(405, 402);
            this.rdbtn0.Name = "rdbtn0";
            this.rdbtn0.Size = new System.Drawing.Size(88, 44);
            this.rdbtn0.TabIndex = 9;
            this.rdbtn0.TabStop = true;
            this.rdbtn0.Text = "sıfır";
            this.rdbtn0.UseVisualStyleBackColor = true;
            this.rdbtn0.CheckedChanged += new System.EventHandler(this.rdbtn0_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Corbel", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(40, 277);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(184, 40);
            this.label4.TabIndex = 10;
            this.label4.Text = "Kitap sayfa :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Corbel", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(22, 402);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(203, 40);
            this.label5.TabIndex = 11;
            this.label5.Text = "Kitap durum :";
            // 
            // txtsayfa
            // 
            this.txtsayfa.Font = new System.Drawing.Font("Corbel", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtsayfa.Location = new System.Drawing.Point(257, 270);
            this.txtsayfa.Name = "txtsayfa";
            this.txtsayfa.Size = new System.Drawing.Size(239, 48);
            this.txtsayfa.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Corbel", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(74, 344);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(152, 40);
            this.label6.TabIndex = 12;
            this.label6.Text = "Kitap tür :";
            // 
            // btnlistele
            // 
            this.btnlistele.Location = new System.Drawing.Point(620, 76);
            this.btnlistele.Name = "btnlistele";
            this.btnlistele.Size = new System.Drawing.Size(296, 69);
            this.btnlistele.TabIndex = 14;
            this.btnlistele.Text = "Listele";
            this.btnlistele.UseVisualStyleBackColor = true;
            this.btnlistele.Click += new System.EventHandler(this.btnlistele_Click);
            // 
            // btmkaydet
            // 
            this.btmkaydet.Location = new System.Drawing.Point(620, 178);
            this.btmkaydet.Name = "btmkaydet";
            this.btmkaydet.Size = new System.Drawing.Size(296, 69);
            this.btmkaydet.TabIndex = 15;
            this.btmkaydet.Text = "Kaydet";
            this.btmkaydet.UseVisualStyleBackColor = true;
            this.btmkaydet.Click += new System.EventHandler(this.btmkaydet_Click);
            // 
            // btnsil
            // 
            this.btnsil.Location = new System.Drawing.Point(620, 277);
            this.btnsil.Name = "btnsil";
            this.btnsil.Size = new System.Drawing.Size(296, 69);
            this.btnsil.TabIndex = 16;
            this.btnsil.Text = "Sil";
            this.btnsil.UseVisualStyleBackColor = true;
            this.btnsil.Click += new System.EventHandler(this.btnsil_Click);
            // 
            // btngüncelle
            // 
            this.btngüncelle.Location = new System.Drawing.Point(620, 374);
            this.btngüncelle.Name = "btngüncelle";
            this.btngüncelle.Size = new System.Drawing.Size(296, 69);
            this.btngüncelle.TabIndex = 17;
            this.btngüncelle.Text = "Güncelle";
            this.btngüncelle.UseVisualStyleBackColor = true;
            this.btngüncelle.Click += new System.EventHandler(this.btngüncelle_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(986, 76);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(451, 225);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Corbel", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox1.Location = new System.Drawing.Point(1158, 313);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(239, 48);
            this.textBox1.TabIndex = 19;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Corbel", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(1035, 316);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(106, 40);
            this.label7.TabIndex = 20;
            this.label7.Text = "Kitap :";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1122, 374);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(177, 68);
            this.button1.TabIndex = 21;
            this.button1.Text = "Ara";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(1463, 813);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btngüncelle);
            this.Controls.Add(this.btnsil);
            this.Controls.Add(this.btmkaydet);
            this.Controls.Add(this.btnlistele);
            this.Controls.Add(this.txtsayfa);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.rdbtn0);
            this.Controls.Add(this.rdbtn2);
            this.Controls.Add(this.cmbtür);
            this.Controls.Add(this.txtyazar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtad);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtid);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("Corbel", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.TextBox txtad;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtyazar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbtür;
        private System.Windows.Forms.RadioButton rdbtn2;
        private System.Windows.Forms.RadioButton rdbtn0;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtsayfa;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnlistele;
        private System.Windows.Forms.Button btmkaydet;
        private System.Windows.Forms.Button btnsil;
        private System.Windows.Forms.Button btngüncelle;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button1;
    }
}

