namespace proje11_ogrencinorkayıt
{
    partial class frmgiris
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
            button1 = new Button();
            maskedTextBox1 = new MaskedTextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(95, 148);
            button1.Name = "button1";
            button1.Size = new Size(193, 62);
            button1.TabIndex = 0;
            button1.Text = "giriş yap";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // maskedTextBox1
            // 
            maskedTextBox1.Location = new Point(199, 74);
            maskedTextBox1.Mask = "000";
            maskedTextBox1.Name = "maskedTextBox1";
            maskedTextBox1.Size = new Size(125, 47);
            maskedTextBox1.TabIndex = 1;
            maskedTextBox1.ValidatingType = typeof(int);
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(47, 74);
            label1.Name = "label1";
            label1.Size = new Size(133, 41);
            label1.TabIndex = 2;
            label1.Text = "numara :";
            // 
            // frmgiris
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Tan;
            ClientSize = new Size(454, 351);
            Controls.Add(label1);
            Controls.Add(maskedTextBox1);
            Controls.Add(button1);
            Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(7, 7, 7, 7);
            Name = "frmgiris";
            Text = "frmgiris";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private MaskedTextBox maskedTextBox1;
        private Label label1;
    }
}