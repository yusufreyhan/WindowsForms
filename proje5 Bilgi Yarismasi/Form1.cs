using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proje5_Bilgi_Yarismasi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int soruno = 0, dogru = 0, yanlis = 0;

        private void label2_Click(object sender, EventArgs e){}

        private void btna_Click(object sender, EventArgs e)
        {
            btna.Enabled = false;
            btnb.Enabled = false;
            btnc.Enabled = false;
            btnd.Enabled = false;
            button5.Enabled = true;

            label2.Text=btna.Text;
            if (label1.Text ==label2.Text)
            {
                dogru++;
                lbld.Text = dogru.ToString();
                pictureBox1.Visible = true;

            }
            else
            {
                yanlis++;
                lbly.Text = yanlis.ToString();
                pictureBox2.Visible=true;
            }
        }

        private void btnb_Click(object sender, EventArgs e)
        {
            btna.Enabled = false;
            btnb.Enabled = false;
            btnc.Enabled = false;
            btnd.Enabled = false;
            button5.Enabled = true;

            label2.Text = btnb.Text;
            if (label1.Text == label2.Text)
            {
                dogru++;
                lbld.Text = dogru.ToString();
                pictureBox1.Visible = true;

            }
            else
            {
                yanlis++;
                lbly.Text = yanlis.ToString();
                pictureBox2.Visible = true;
            }
        }

        private void btnc_Click(object sender, EventArgs e)
        {
            btna.Enabled = false;
            btnb.Enabled = false;
            btnc.Enabled = false;
            btnd.Enabled = false;
            button5.Enabled = true;

            label2.Text = btnc.Text;
            if (label1.Text == label2.Text)
            {
                dogru++;
                lbld.Text = dogru.ToString();
                pictureBox1.Visible = true;

            }
            else
            {
                yanlis++;
                lbly.Text = yanlis.ToString();
                pictureBox2.Visible = true;
            }
        }

        private void btnd_Click(object sender, EventArgs e)
        {
            btna.Enabled = false;
            btnb.Enabled = false;
            btnc.Enabled = false;
            btnd.Enabled = false;
            button5.Enabled = true;

            label2.Text = btnd.Text;
            if (label1.Text == label2.Text)
            {
                dogru++;
                lbld.Text = dogru.ToString();
                pictureBox1.Visible = true;

            }
            else
            {
                yanlis++;
                lbly.Text = yanlis.ToString();
                pictureBox2.Visible = true;
            }
            
        }

        private void lblsoruno_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e){}

        private void button5_Click(object sender, EventArgs e)
        {
            pictureBox1.Visible = false;
            pictureBox2.Visible = false;
            button5.Enabled = false;
            btna.Enabled = true;
            btnb.Enabled = true;
            btnc.Enabled = true;    
            btnd.Enabled = true;

            soruno++;
            lbls.Text=soruno.ToString();
            

            if (soruno == 1)
            {
                richTextBox1.Text = "Cumhuriyet kaç yılında kurulmuştur ?";
                btna.Text = "1921";
                btnb.Text = "1922";
                btnc.Text = "1923";
                btnd.Text = "1924";
                label1.Text = "1923";
            }
                if (soruno == 2)
                {
                    richTextBox1.Text = "Fatih Sultan Mehmet'in babası Kimdir ?";
                    btna.Text = "2. Murat";
                    btnb.Text = "1. Mehmet";
                    btnc.Text = "Yıldırım Beyazıt";
                    btnd.Text = "2. Mehmet";
                    label1.Text = "2. Murat";
                }


                    if (soruno == 3) 
                    {
                        richTextBox1.Text = "Badminton topu hangisi ile yapılır ?";
                        btna.Text = "At kuyruğu";
                        btnb.Text = "Kaz tüyü";
                        btnc.Text = "Kuru inek gözü";
                        btnd.Text = "Keçi Boynuzu";
                        label1.Text = "Kaz tüyü";
                    }
                   
            if (soruno == 4)
            {
                richTextBox1.Text = "Hangisi periyodik tabloda bulunan bir element değildir ?";
                btna.Text = "Azot";
                btnb.Text = "Hidrojen";
                btnc.Text = "Helyum";
                btnd.Text = "Su";
                label1.Text = "Su";
            }
            if(soruno == 5)
            {
                richTextBox1.Text = "Kıbrıs barış harekatı hangi yıl yapılmıştır ?";
                btna.Text = "1970";
                btnb.Text = "1972";
                btnc.Text = "1974";
                btnd.Text = "1976";
                label1.Text = "1974";
            }
            if (soruno == 6)
            {
                richTextBox1.Text = " ABD başkanlarından John Fitzgerald Kennedy’e suikast düzenleyerek öldüren kimdir ?";
                btna.Text = "Lee Harvey Oswald";
                btnb.Text = "Michael Scofield";
                btnc.Text = "Jack Ruby";
                btnd.Text = "Clay Shaw";
                label1.Text = "Lee Harvey Oswald";
            }
            if (soruno == 7)
            {
                richTextBox1.Text = "Hangisi bir hücrede bulunun organeldir ?";
                btna.Text = "DNA";
                btnb.Text = "RNA";
                btnc.Text = "Lizozom";
                btnd.Text = "Kalpçik";
                label1.Text = "Lizozom";
            }
               if (soruno == 8)
            {
                richTextBox1.Text = "Hangi hayvan memeli değildir ?";
                btna.Text = "Penguen";
                btnb.Text = "Kirpi";
                btnc.Text = "Fare";
                btnd.Text = "Yarasa";
                label1.Text = "Penguen";
            }
               if (soruno == 9)
            {
                richTextBox1.Text = "Bir elektrik devresinde direnç hangi harfle gösterilir ?";
                btna.Text = "D";
                btnb.Text = "A";
                btnc.Text = "R";
                btnd.Text = "I";
                label1.Text = "R";
            }
               if (soruno == 10)
            {
                richTextBox1.Text = "1'in türevi kaçtır ?";
                btna.Text = "-1";
                btnb.Text = "0";
                btnc.Text = "1";
                btnd.Text = "Sonsuz";
                label1.Text = "0";
            }
               if (soruno == 11)
            {
                richTextBox1.Text = "İstiklal Marşı hangi yıl yazılmıştır ?";
                btna.Text = "1921";
                btnb.Text = "1922";
                btnc.Text = "1923";
                btnd.Text = "1924";
                label1.Text = "1921";
            }
               if (soruno==12)
            {
                richTextBox1.Text = "Dünya kupalarında en fazla gol atan oyuncu kimdir ?";
                btna.Text = "Messi";
                btnb.Text = "Miroslav Klose";
                btnc.Text = "Mbabbe";
                btnd.Text = "Pele";
                label1.Text = "Miroslav Klose";
            }
               if (soruno == 13)
            {
                richTextBox1.Text = "Dünya kupalarında en fazla forma giyen oyuncu kimdir ?";
                btna.Text = "Messi";
                btnb.Text = "Miroslav Klose";
                btnc.Text = "Maldini";
                btnd.Text = "Maradona";
                label1.Text = "Messi";
            }
               if (soruno == 14)
            {
                richTextBox1.Text = "Geminin baş kısmının adı nedir ?";
                btna.Text = "Pupa";
                btnb.Text = "Sancak";
                btnc.Text = "Liman";
                btnd.Text = "Pruva";
                label1.Text = "Pruva";
            }
               if (soruno == 15)
            {
                richTextBox1.Text = "Futbol maçlarında oynanan topun FİFA kurallarına göre ağırlığı ne kadar olmalıdır ?";
                btna.Text = "396";
                btnb.Text = "288";
                btnc.Text = "452";
                btnd.Text = "368";
                label1.Text = "452";
                button5.Text = "Sonuçlar";

            }
               if (soruno == 16)
            {
                MessageBox.Show("Doğru : " + dogru + "\n" + "Yanlış : " + yanlis );
                btna.Enabled = false;
                btnb.Enabled = false;
                btnc.Enabled = false;
                btnd.Enabled = false;
            }
        }

    }
}
        
    

