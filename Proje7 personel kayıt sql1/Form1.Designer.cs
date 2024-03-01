namespace Proje7_personel_kayıt_sql1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.d = new System.Windows.Forms.GroupBox();
            this.cmbsehir = new System.Windows.Forms.ComboBox();
            this.msktxtmaas = new System.Windows.Forms.MaskedTextBox();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.txtmeslek = new System.Windows.Forms.TextBox();
            this.txtsoyad = new System.Windows.Forms.TextBox();
            this.txtad = new System.Windows.Forms.TextBox();
            this.txtid = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btngarafikler = new System.Windows.Forms.Button();
            this.btnistatistik = new System.Windows.Forms.Button();
            this.btntemizle = new System.Windows.Forms.Button();
            this.btngüncelle = new System.Windows.Forms.Button();
            this.btbsil = new System.Windows.Forms.Button();
            this.btnkaydet = new System.Windows.Forms.Button();
            this.btnlistele = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.peridDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.perAdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.perSoyadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.perSehirDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.perMaasDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.perMedeniDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.perMeslekDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblpersonelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.personel_veri_tabaniDataSet = new Proje7_personel_kayıt_sql1.personel_veri_tabaniDataSet();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tbl_personelTableAdapter = new Proje7_personel_kayıt_sql1.personel_veri_tabaniDataSetTableAdapters.Tbl_personelTableAdapter();
            this.d.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblpersonelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personel_veri_tabaniDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // d
            // 
            this.d.Controls.Add(this.cmbsehir);
            this.d.Controls.Add(this.msktxtmaas);
            this.d.Controls.Add(this.radioButton2);
            this.d.Controls.Add(this.radioButton1);
            this.d.Controls.Add(this.txtmeslek);
            this.d.Controls.Add(this.txtsoyad);
            this.d.Controls.Add(this.txtad);
            this.d.Controls.Add(this.txtid);
            this.d.Controls.Add(this.label7);
            this.d.Controls.Add(this.label6);
            this.d.Controls.Add(this.label5);
            this.d.Controls.Add(this.label4);
            this.d.Controls.Add(this.label3);
            this.d.Controls.Add(this.label2);
            this.d.Controls.Add(this.label1);
            this.d.Location = new System.Drawing.Point(15, 12);
            this.d.Name = "d";
            this.d.Size = new System.Drawing.Size(508, 462);
            this.d.TabIndex = 0;
            this.d.TabStop = false;
            this.d.Text = "Personel Kayıt";
            // 
            // cmbsehir
            // 
            this.cmbsehir.FormattingEnabled = true;
            this.cmbsehir.Location = new System.Drawing.Point(197, 223);
            this.cmbsehir.Name = "cmbsehir";
            this.cmbsehir.Size = new System.Drawing.Size(273, 41);
            this.cmbsehir.TabIndex = 4;
            // 
            // msktxtmaas
            // 
            this.msktxtmaas.Location = new System.Drawing.Point(197, 271);
            this.msktxtmaas.Mask = "0000";
            this.msktxtmaas.Name = "msktxtmaas";
            this.msktxtmaas.Size = new System.Drawing.Size(273, 40);
            this.msktxtmaas.TabIndex = 5;
            this.msktxtmaas.ValidatingType = typeof(int);
            this.msktxtmaas.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBox1_MaskInputRejected);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(312, 322);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(104, 39);
            this.radioButton2.TabIndex = 13;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Bekar";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(198, 322);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(78, 39);
            this.radioButton1.TabIndex = 12;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Evli";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // txtmeslek
            // 
            this.txtmeslek.Location = new System.Drawing.Point(197, 371);
            this.txtmeslek.Name = "txtmeslek";
            this.txtmeslek.Size = new System.Drawing.Size(273, 40);
            this.txtmeslek.TabIndex = 6;
            // 
            // txtsoyad
            // 
            this.txtsoyad.Location = new System.Drawing.Point(197, 176);
            this.txtsoyad.Name = "txtsoyad";
            this.txtsoyad.Size = new System.Drawing.Size(273, 40);
            this.txtsoyad.TabIndex = 3;
            // 
            // txtad
            // 
            this.txtad.Location = new System.Drawing.Point(197, 127);
            this.txtad.Name = "txtad";
            this.txtad.Size = new System.Drawing.Size(273, 40);
            this.txtad.TabIndex = 2;
            // 
            // txtid
            // 
            this.txtid.Enabled = false;
            this.txtid.Location = new System.Drawing.Point(197, 76);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(273, 40);
            this.txtid.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(54, 374);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(111, 35);
            this.label7.TabIndex = 6;
            this.label7.Text = "Meslek :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(51, 325);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(116, 35);
            this.label6.TabIndex = 5;
            this.label6.Text = "Medeni :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(51, 276);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 35);
            this.label5.TabIndex = 4;
            this.label5.Text = "Maaş :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(50, 229);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 35);
            this.label4.TabIndex = 3;
            this.label4.Text = "Şehir :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(50, 176);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 35);
            this.label3.TabIndex = 2;
            this.label3.Text = "Soyad :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(46, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 35);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ad :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 35);
            this.label1.TabIndex = 0;
            this.label1.Text = "İd :";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.btngarafikler);
            this.groupBox2.Controls.Add(this.btnistatistik);
            this.groupBox2.Controls.Add(this.btntemizle);
            this.groupBox2.Controls.Add(this.btngüncelle);
            this.groupBox2.Controls.Add(this.btbsil);
            this.groupBox2.Controls.Add(this.btnkaydet);
            this.groupBox2.Controls.Add(this.btnlistele);
            this.groupBox2.Location = new System.Drawing.Point(547, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(508, 462);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "İşlemler";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(410, 36);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(86, 35);
            this.label8.TabIndex = 4;
            this.label8.Text = "label8";
            this.label8.Visible = false;
            // 
            // btngarafikler
            // 
            this.btngarafikler.Location = new System.Drawing.Point(51, 374);
            this.btngarafikler.Name = "btngarafikler";
            this.btngarafikler.Size = new System.Drawing.Size(333, 42);
            this.btngarafikler.TabIndex = 6;
            this.btngarafikler.Text = "Grafikler";
            this.btngarafikler.UseVisualStyleBackColor = true;
            this.btngarafikler.Click += new System.EventHandler(this.btngarafikler_Click);
            // 
            // btnistatistik
            // 
            this.btnistatistik.Location = new System.Drawing.Point(51, 324);
            this.btnistatistik.Name = "btnistatistik";
            this.btnistatistik.Size = new System.Drawing.Size(333, 42);
            this.btnistatistik.TabIndex = 5;
            this.btnistatistik.Text = "İstatistik";
            this.btnistatistik.UseVisualStyleBackColor = true;
            this.btnistatistik.Click += new System.EventHandler(this.btnistatistik_Click);
            // 
            // btntemizle
            // 
            this.btntemizle.Location = new System.Drawing.Point(51, 276);
            this.btntemizle.Name = "btntemizle";
            this.btntemizle.Size = new System.Drawing.Size(333, 42);
            this.btntemizle.TabIndex = 4;
            this.btntemizle.Text = "Temizle";
            this.btntemizle.UseVisualStyleBackColor = true;
            this.btntemizle.Click += new System.EventHandler(this.btntemizle_Click);
            // 
            // btngüncelle
            // 
            this.btngüncelle.Location = new System.Drawing.Point(51, 224);
            this.btngüncelle.Name = "btngüncelle";
            this.btngüncelle.Size = new System.Drawing.Size(333, 42);
            this.btngüncelle.TabIndex = 3;
            this.btngüncelle.Text = "Güncelle";
            this.btngüncelle.UseVisualStyleBackColor = true;
            this.btngüncelle.Click += new System.EventHandler(this.btngüncelle_Click);
            // 
            // btbsil
            // 
            this.btbsil.Location = new System.Drawing.Point(51, 171);
            this.btbsil.Name = "btbsil";
            this.btbsil.Size = new System.Drawing.Size(333, 42);
            this.btbsil.TabIndex = 2;
            this.btbsil.Text = "Sil";
            this.btbsil.UseVisualStyleBackColor = true;
            this.btbsil.Click += new System.EventHandler(this.btbsil_Click);
            // 
            // btnkaydet
            // 
            this.btnkaydet.Location = new System.Drawing.Point(51, 120);
            this.btnkaydet.Name = "btnkaydet";
            this.btnkaydet.Size = new System.Drawing.Size(333, 42);
            this.btnkaydet.TabIndex = 1;
            this.btnkaydet.Text = "Kaydet";
            this.btnkaydet.UseVisualStyleBackColor = true;
            this.btnkaydet.Click += new System.EventHandler(this.btnkaydet_Click);
            // 
            // btnlistele
            // 
            this.btnlistele.Location = new System.Drawing.Point(51, 69);
            this.btnlistele.Name = "btnlistele";
            this.btnlistele.Size = new System.Drawing.Size(333, 42);
            this.btnlistele.TabIndex = 0;
            this.btnlistele.Text = "Listele";
            this.btnlistele.UseVisualStyleBackColor = true;
            this.btnlistele.Click += new System.EventHandler(this.btnlistele_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dataGridView1);
            this.groupBox3.Location = new System.Drawing.Point(12, 500);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1043, 263);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Kayıtlar";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.peridDataGridViewTextBoxColumn,
            this.perAdDataGridViewTextBoxColumn,
            this.perSoyadDataGridViewTextBoxColumn,
            this.perSehirDataGridViewTextBoxColumn,
            this.perMaasDataGridViewTextBoxColumn,
            this.perMedeniDataGridViewCheckBoxColumn,
            this.perMeslekDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tblpersonelBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 36);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1037, 224);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // peridDataGridViewTextBoxColumn
            // 
            this.peridDataGridViewTextBoxColumn.DataPropertyName = "Perid";
            this.peridDataGridViewTextBoxColumn.HeaderText = "Perid";
            this.peridDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.peridDataGridViewTextBoxColumn.Name = "peridDataGridViewTextBoxColumn";
            this.peridDataGridViewTextBoxColumn.ReadOnly = true;
            this.peridDataGridViewTextBoxColumn.Width = 125;
            // 
            // perAdDataGridViewTextBoxColumn
            // 
            this.perAdDataGridViewTextBoxColumn.DataPropertyName = "PerAd";
            this.perAdDataGridViewTextBoxColumn.HeaderText = "PerAd";
            this.perAdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.perAdDataGridViewTextBoxColumn.Name = "perAdDataGridViewTextBoxColumn";
            this.perAdDataGridViewTextBoxColumn.Width = 125;
            // 
            // perSoyadDataGridViewTextBoxColumn
            // 
            this.perSoyadDataGridViewTextBoxColumn.DataPropertyName = "PerSoyad";
            this.perSoyadDataGridViewTextBoxColumn.HeaderText = "PerSoyad";
            this.perSoyadDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.perSoyadDataGridViewTextBoxColumn.Name = "perSoyadDataGridViewTextBoxColumn";
            this.perSoyadDataGridViewTextBoxColumn.Width = 125;
            // 
            // perSehirDataGridViewTextBoxColumn
            // 
            this.perSehirDataGridViewTextBoxColumn.DataPropertyName = "PerSehir";
            this.perSehirDataGridViewTextBoxColumn.HeaderText = "PerSehir";
            this.perSehirDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.perSehirDataGridViewTextBoxColumn.Name = "perSehirDataGridViewTextBoxColumn";
            this.perSehirDataGridViewTextBoxColumn.Width = 125;
            // 
            // perMaasDataGridViewTextBoxColumn
            // 
            this.perMaasDataGridViewTextBoxColumn.DataPropertyName = "PerMaas";
            this.perMaasDataGridViewTextBoxColumn.HeaderText = "PerMaas";
            this.perMaasDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.perMaasDataGridViewTextBoxColumn.Name = "perMaasDataGridViewTextBoxColumn";
            this.perMaasDataGridViewTextBoxColumn.Width = 125;
            // 
            // perMedeniDataGridViewCheckBoxColumn
            // 
            this.perMedeniDataGridViewCheckBoxColumn.DataPropertyName = "PerMedeni";
            this.perMedeniDataGridViewCheckBoxColumn.HeaderText = "PerMedeni";
            this.perMedeniDataGridViewCheckBoxColumn.MinimumWidth = 6;
            this.perMedeniDataGridViewCheckBoxColumn.Name = "perMedeniDataGridViewCheckBoxColumn";
            this.perMedeniDataGridViewCheckBoxColumn.Width = 125;
            // 
            // perMeslekDataGridViewTextBoxColumn
            // 
            this.perMeslekDataGridViewTextBoxColumn.DataPropertyName = "PerMeslek";
            this.perMeslekDataGridViewTextBoxColumn.HeaderText = "PerMeslek";
            this.perMeslekDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.perMeslekDataGridViewTextBoxColumn.Name = "perMeslekDataGridViewTextBoxColumn";
            this.perMeslekDataGridViewTextBoxColumn.Width = 125;
            // 
            // tblpersonelBindingSource
            // 
            this.tblpersonelBindingSource.DataMember = "Tbl_personel";
            this.tblpersonelBindingSource.DataSource = this.personel_veri_tabaniDataSet;
            // 
            // personel_veri_tabaniDataSet
            // 
            this.personel_veri_tabaniDataSet.DataSetName = "personel_veri_tabaniDataSet";
            this.personel_veri_tabaniDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1091, 25);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(455, 735);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // tbl_personelTableAdapter
            // 
            this.tbl_personelTableAdapter.ClearBeforeFill = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 33F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Tan;
            this.ClientSize = new System.Drawing.Size(1924, 778);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.d);
            this.Font = new System.Drawing.Font("Corbel", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.d.ResumeLayout(false);
            this.d.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblpersonelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personel_veri_tabaniDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox d;
        private System.Windows.Forms.MaskedTextBox msktxtmaas;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.ComboBox cmbsehir;
        private System.Windows.Forms.TextBox txtmeslek;
        private System.Windows.Forms.TextBox txtsoyad;
        private System.Windows.Forms.TextBox txtad;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btngarafikler;
        private System.Windows.Forms.Button btnistatistik;
        private System.Windows.Forms.Button btntemizle;
        private System.Windows.Forms.Button btngüncelle;
        private System.Windows.Forms.Button btbsil;
        private System.Windows.Forms.Button btnkaydet;
        private System.Windows.Forms.Button btnlistele;
        private System.Windows.Forms.DataGridView dataGridView1;
        private personel_veri_tabaniDataSet personel_veri_tabaniDataSet;
        private System.Windows.Forms.BindingSource tblpersonelBindingSource;
        private personel_veri_tabaniDataSetTableAdapters.Tbl_personelTableAdapter tbl_personelTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn peridDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn perAdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn perSoyadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn perSehirDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn perMaasDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn perMedeniDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn perMeslekDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label8;
    }
}

