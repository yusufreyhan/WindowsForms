using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proje_6_Film_önerme_fragman
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void korkuToolStripMenuItem_Click(object sender, EventArgs e){}

        private void koyuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.DarkGray;
        }

        private void açıkToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.White;
        }

        private void madMaxToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://www.youtube.com/watch?v=hEJnMQG9ev8&pp=ygUHbWFkIG1heA%3D%3D");
        }

        private void exturacitonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://www.youtube.com/watch?v=ssPxdqHj7mA&pp=ygUMZXh0dXJhY2F0aW9u");
        }

        private void aynıYıldızınAltındaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://www.youtube.com/watch?v=aQnlngjZG48&pp=ygUiYXluxLEgecSxbGTEsXrEsW4gYWx0xLFuZGEgZnJhZ21hbg%3D%3D");
        }

        private void fiveFeetApartToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://www.youtube.com/watch?v=XtgCqMZofqM&pp=ygUsZml2ZSBmZWV0IGFwYXJ0IGZyYWdtYW4gdMO8cmvDp2UgYWx0eWF6xLFsxLE%3D");
        }

        private void yıldızlararasıToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://www.youtube.com/watch?v=vVJeYMRam0o&pp=ygUZecSxbGTEsXpsYXJhcmFzxLEgZnJhZ21hbg%3D%3D");
        }

        private void ıslandToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://www.youtube.com/watch?v=7YrA3VQA22I&pp=ygULYWRhIGZyYWdtYW4%3D");
        }

        private void yeşilYolToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://www.youtube.com/watch?v=hfa5F-kRTq4&pp=ygUKeWXFn2lsIHlvbA%3D%3D");
        }

        private void idiotsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://www.youtube.com/watch?v=7_EI2gz53rs&pp=ygUQMyBpZGlvdHMgZnJhZ21hbg%3D%3D");
        }

        private void misyonumuzToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Büyük adam olmak","Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void kimizToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Kimiz değil kimim ben Yusuf REYHAN işte karşınızadayım", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void çıkışToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void hesapMakinesiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("calc.exe");


        }

        private void paintToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("mspaint.exe");
        }
    }
}
