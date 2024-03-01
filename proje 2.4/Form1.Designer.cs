namespace proje_2._4
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblsüre = new System.Windows.Forms.Label();
            this.lblkelime = new System.Windows.Forms.Label();
            this.txting = new System.Windows.Forms.TextBox();
            this.txttr = new System.Windows.Forms.TextBox();
            this.lblcevap = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Georgia", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(66, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(242, 51);
            this.label1.TabIndex = 0;
            this.label1.Text = "İngilizce :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Georgia", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(96, 195);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(208, 51);
            this.label2.TabIndex = 1;
            this.label2.Text = "Türkçe :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Georgia", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(509, 321);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(167, 51);
            this.label3.TabIndex = 2;
            this.label3.Text = "Süre : ";
            this.label3.DockChanged += new System.EventHandler(this.label3_DockChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Georgia", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(460, 427);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(222, 51);
            this.label4.TabIndex = 3;
            this.label4.Text = "Kelime : ";
            // 
            // lblsüre
            // 
            this.lblsüre.AutoSize = true;
            this.lblsüre.BackColor = System.Drawing.Color.Transparent;
            this.lblsüre.Font = new System.Drawing.Font("Georgia", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblsüre.Location = new System.Drawing.Point(662, 321);
            this.lblsüre.Name = "lblsüre";
            this.lblsüre.Size = new System.Drawing.Size(103, 51);
            this.lblsüre.TabIndex = 4;
            this.lblsüre.Text = "120";
            // 
            // lblkelime
            // 
            this.lblkelime.AutoSize = true;
            this.lblkelime.BackColor = System.Drawing.Color.Transparent;
            this.lblkelime.Font = new System.Drawing.Font("Georgia", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblkelime.Location = new System.Drawing.Point(681, 427);
            this.lblkelime.Name = "lblkelime";
            this.lblkelime.Size = new System.Drawing.Size(84, 51);
            this.lblkelime.TabIndex = 5;
            this.lblkelime.Text = "00";
            // 
            // txting
            // 
            this.txting.Font = new System.Drawing.Font("Georgia", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txting.Location = new System.Drawing.Point(303, 87);
            this.txting.Name = "txting";
            this.txting.Size = new System.Drawing.Size(737, 56);
            this.txting.TabIndex = 6;
            // 
            // txttr
            // 
            this.txttr.Font = new System.Drawing.Font("Georgia", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txttr.Location = new System.Drawing.Point(303, 195);
            this.txttr.Name = "txttr";
            this.txttr.Size = new System.Drawing.Size(737, 56);
            this.txttr.TabIndex = 1;
            this.txttr.TextChanged += new System.EventHandler(this.txttr_TextChanged);
            // 
            // lblcevap
            // 
            this.lblcevap.AutoSize = true;
            this.lblcevap.BackColor = System.Drawing.Color.Transparent;
            this.lblcevap.Font = new System.Drawing.Font("Georgia", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblcevap.Location = new System.Drawing.Point(76, 398);
            this.lblcevap.Name = "lblcevap";
            this.lblcevap.Size = new System.Drawing.Size(106, 51);
            this.lblcevap.TabIndex = 8;
            this.lblcevap.Text = "......";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1200, 565);
            this.Controls.Add(this.lblcevap);
            this.Controls.Add(this.txttr);
            this.Controls.Add(this.txting);
            this.Controls.Add(this.lblkelime);
            this.Controls.Add(this.lblsüre);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblsüre;
        private System.Windows.Forms.Label lblkelime;
        private System.Windows.Forms.TextBox txting;
        private System.Windows.Forms.TextBox txttr;
        private System.Windows.Forms.Label lblcevap;
        private System.Windows.Forms.Timer timer1;
    }
}

