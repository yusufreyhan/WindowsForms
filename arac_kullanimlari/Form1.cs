using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace arac_kullanimlari
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Merhaba kenks");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label3.Text = "Baran";
            label4.Text = "Reyhan";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //textBox1.Text = "Yusuf";
            //textBox2.Text = "Reyhan";
            label7.Text = textBox1.Text;
            label8.Text = textBox2.Text;
        }

        private void label9_Click(object sender, EventArgs e) { }
        private void textBox3_TextChanged(object sender, EventArgs e) { }

        private void button4_Click(object sender, EventArgs e)
        {
            comboBox1.Items.Add(textBox3.Text);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(textBox4.Text);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            listBox2.Items.Add(maskedTextBox1.Text);
            listBox2.Items.Add(maskedTextBox2.Text);
            listBox2.Items.Add(textBox5.Text);
            listBox2.Items.Add(dateTimePicker1.Text);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            //int sayi1, sayi2;
            //char ısaret;
            //sayi1 = Convert.ToInt32(textBox6.Text);
            //sayi2 = Convert.ToInt32(textBox7.Text);
            //ısaret =Convert.ToChar(textBox8.Text);

            //switch (ısaret) 
            //{
            //    case + : textBox9.Text = sayi1 + sayi2; break;
            //    case - : textBox9.Text = sayi1 - sayi2; break;
            //    case * || X || . : textBox9.Text = sayi1 * sayi2; break;
            //    case / : textBox9.Text = sayi1 / sayi2; break;
            //}
        }

        private void button8_Click(object sender, EventArgs e)
        {
            //int sayi,sonuc;
            //sayi = Convert.ToInt32(textBox10.Text);
            //for (int i = 1; i <= sayi; i++)
            //{
            //    sayi * i =sonuc
                
            //}
            
              
            
            
        }
        int sayac;
        private void timer1_Tick(object sender, EventArgs e)
        {
            sayac++;
            label14.Text=sayac.ToString();
            if (sayac <= 5)

            { this.BackColor = Color.Red; }
            if (sayac <= 8 && sayac>5)
            { this.BackColor = Color.Yellow; }
            if (sayac <= 15 && sayac > 8)
            { this.BackColor = Color.Green; }
            if (sayac >= 15 )
            sayac = 0;
          
        }

        
        private void button9_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }
        int toplam = 0;
        int dorttoplam = 0;
        private void button10_Click(object sender, EventArgs e)
        {
            int[] sayi = {4,10,12,14,16,24,56,77,78,90};
            foreach (int s in sayi)
            {
                listBox3.Items.Add(s);
                toplam = toplam + s;
                label17.Text = toplam.ToString();
                if (s % 4 == 0)
                {
                    listBox4.Items.Add (s.ToString());
                   dorttoplam = dorttoplam + s;
                    label15.Text = dorttoplam.ToString();
                }
            }
            
        }
        private void textBox13_TextChanged(object sender, EventArgs e){}


        int topla(int sayim1 , int sayim2)
        {
            int t = sayim1 + sayim2;
            return t;
            
        }

        private void button11_Click(object sender, EventArgs e)
        {
            int bir = Convert.ToInt32(textBox13.Text);
            int iki = Convert.ToInt32(textBox12.Text);
            label16.Text = topla(bir,iki).ToString();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            Random rast = new Random();
            int s1 , s2 , s3 , s4 ;
            s1 = rast.Next(1,6);
            s2 = rast.Next(1,6);
            s3 = rast.Next(1,6);
            s4 = rast.Next(1,6);
            label18.Text = s1.ToString();
            label19.Text = s2.ToString();
            label20.Text = s3.ToString();  
            label21.Text = s4.ToString();
            
            //s1
            if (label18.Text == textBox14.Text)
            {
                textBox14.BackColor = Color.Green;
            }
            else 
            {
            textBox14.BackColor = Color.Red;
            }
            //s2
            if (label19.Text == textBox15.Text)
            {
                textBox15.BackColor = Color.Green;
            }
            else
            {
                textBox15.BackColor = Color.Red;
            }
            //s3
            if (label20.Text == textBox16.Text)
            {
                textBox16.BackColor = Color.Green;
            }
            else
            {
                textBox16.BackColor = Color.Red;
            }
            //s4
            if (label21.Text == textBox17.Text)
            {
                textBox17.BackColor = Color.Green;
            }
            else
            {
                textBox17.BackColor = Color.Red;
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            string[] sembol1 = { "A", "B", "C", "D", "E", "F", };
            string[] sembol2 = { "q", "w" ,"e" ,"r",  "s" , "t" , "u" , "v" };
            string[] sembol3 = { "#", "-", "+", "*", "/", "<", ">" };

            Random rast = new Random();
            int se1,se2,se3;
           
            se1 = rast.Next(0, sembol1.Length);
            se2 = rast.Next(0, sembol2.Length);
            se3 = rast.Next(0, sembol3.Length);

            label22.Text = rast.Next(1, 10) + sembol1[se1] + sembol2[se2] + rast.Next(10,100) + sembol3[se3];
        }

        private void button14_Click(object sender, EventArgs e)
        {
            Form2 fr = new Form2();
            fr.Show();

        }
    }
}
