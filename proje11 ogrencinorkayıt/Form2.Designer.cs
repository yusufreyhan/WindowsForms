namespace proje11_ogrencinorkayıt
{
    partial class frmogretmendetay
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
            groupBox1 = new GroupBox();
            label1 = new Label();
            label2 = new Label();
            maskedTextBox1 = new MaskedTextBox();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label3 = new Label();
            groupBox2 = new GroupBox();
            textBox3 = new TextBox();
            label4 = new Label();
            textBox4 = new TextBox();
            label5 = new Label();
            label6 = new Label();
            button1 = new Button();
            button2 = new Button();
            textBox5 = new TextBox();
            groupBox3 = new GroupBox();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            groupBox4 = new GroupBox();
            dataGridView1 = new DataGridView();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(textBox2);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(maskedTextBox1);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(43, 15);
            groupBox1.Margin = new Padding(6, 6, 6, 6);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(6, 6, 6, 6);
            groupBox1.Size = new Size(340, 394);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "öğrenci ekle";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(2, 94);
            label1.Name = "label1";
            label1.Size = new Size(133, 41);
            label1.TabIndex = 0;
            label1.Text = "numara :";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(69, 177);
            label2.Name = "label2";
            label2.Size = new Size(66, 41);
            label2.TabIndex = 1;
            label2.Text = "ad :";
            // 
            // maskedTextBox1
            // 
            maskedTextBox1.Location = new Point(156, 94);
            maskedTextBox1.Mask = "000";
            maskedTextBox1.Name = "maskedTextBox1";
            maskedTextBox1.Size = new Size(158, 47);
            maskedTextBox1.TabIndex = 2;
            maskedTextBox1.ValidatingType = typeof(int);
            // 
            // textBox1
            // 
            textBox1.Location = new Point(156, 174);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(158, 47);
            textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(156, 245);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(158, 47);
            textBox2.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(23, 248);
            label3.Name = "label3";
            label3.Size = new Size(112, 41);
            label3.TabIndex = 4;
            label3.Text = "soyad :";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(textBox5);
            groupBox2.Controls.Add(button2);
            groupBox2.Controls.Add(textBox3);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(textBox4);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(label6);
            groupBox2.Location = new Point(406, 15);
            groupBox2.Margin = new Padding(6);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(6);
            groupBox2.Size = new Size(353, 394);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "öğrenci not";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(156, 245);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(158, 47);
            textBox3.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(26, 251);
            label4.Name = "label4";
            label4.Size = new Size(123, 41);
            label4.TabIndex = 4;
            label4.Text = "sınav 3 :";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(156, 174);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(158, 47);
            textBox4.TabIndex = 3;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(26, 180);
            label5.Name = "label5";
            label5.Size = new Size(123, 41);
            label5.TabIndex = 1;
            label5.Text = "sınav 2 :";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(26, 97);
            label6.Name = "label6";
            label6.Size = new Size(123, 41);
            label6.TabIndex = 0;
            label6.Text = "sınav 1 :";
            // 
            // button1
            // 
            button1.Location = new Point(156, 318);
            button1.Name = "button1";
            button1.Size = new Size(158, 67);
            button1.TabIndex = 6;
            button1.Text = "kaydet";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(156, 318);
            button2.Name = "button2";
            button2.Size = new Size(158, 67);
            button2.TabIndex = 7;
            button2.Text = "kaydet";
            button2.UseVisualStyleBackColor = true;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(156, 97);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(158, 47);
            textBox5.TabIndex = 8;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(label12);
            groupBox3.Controls.Add(label11);
            groupBox3.Controls.Add(label10);
            groupBox3.Controls.Add(label7);
            groupBox3.Controls.Add(label8);
            groupBox3.Controls.Add(label9);
            groupBox3.Location = new Point(771, 15);
            groupBox3.Margin = new Padding(6);
            groupBox3.Name = "groupBox3";
            groupBox3.Padding = new Padding(6);
            groupBox3.Size = new Size(341, 394);
            groupBox3.TabIndex = 9;
            groupBox3.TabStop = false;
            groupBox3.Text = "sınıf durumu";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(29, 254);
            label7.Name = "label7";
            label7.Size = new Size(180, 41);
            label7.TabIndex = 4;
            label7.Text = "kalan sayısı :";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(17, 183);
            label8.Name = "label8";
            label8.Size = new Size(192, 41);
            label8.TabIndex = 1;
            label8.Text = "geçen sayısı :";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(60, 103);
            label9.Name = "label9";
            label9.Size = new Size(149, 41);
            label9.TabIndex = 0;
            label9.Text = "ortalama :";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(215, 103);
            label10.Name = "label10";
            label10.Size = new Size(113, 41);
            label10.TabIndex = 5;
            label10.Text = "label10";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(215, 183);
            label11.Name = "label11";
            label11.Size = new Size(113, 41);
            label11.TabIndex = 6;
            label11.Text = "label11";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(215, 254);
            label12.Name = "label12";
            label12.Size = new Size(113, 41);
            label12.TabIndex = 7;
            label12.Text = "label12";
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(dataGridView1);
            groupBox4.Location = new Point(45, 428);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(1067, 495);
            groupBox4.TabIndex = 10;
            groupBox4.TabStop = false;
            groupBox4.Text = "öğrenciler";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(3, 43);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(1061, 449);
            dataGridView1.TabIndex = 0;
            // 
            // frmogretmendetay
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Tan;
            ClientSize = new Size(1127, 948);
            Controls.Add(groupBox4);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(6, 6, 6, 6);
            Name = "frmogretmendetay";
            Text = "öğrenci not kayıt sistemi";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox textBox1;
        private MaskedTextBox maskedTextBox1;
        private Label label2;
        private Label label1;
        private Button button1;
        private TextBox textBox2;
        private Label label3;
        private GroupBox groupBox2;
        private TextBox textBox5;
        private Button button2;
        private TextBox textBox3;
        private Label label4;
        private TextBox textBox4;
        private Label label5;
        private Label label6;
        private GroupBox groupBox3;
        private Label label12;
        private Label label11;
        private Label label10;
        private Label label7;
        private Label label8;
        private Label label9;
        private GroupBox groupBox4;
        private DataGridView dataGridView1;
    }
}