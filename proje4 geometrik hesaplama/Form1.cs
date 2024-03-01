using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proje4_geometrik_hesaplama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int kenar_k, cevre_k, alan_k;
            kenar_k = Convert.ToInt32(textBox1.Text);
            alan_k = kenar_k * kenar_k;
            cevre_k = kenar_k * 4;
            textBox10.Text = alan_k.ToString();
            textBox11.Text = cevre_k.ToString();
        }
        private void label4_Click(object sender, EventArgs e) { }
        private void textBox8_TextChanged(object sender, EventArgs e) { }

        private void button2_Click(object sender, EventArgs e)
        {
            int kenar_d, cevre_d, alan_d, kenar2_d;
            kenar_d = Convert.ToInt32(textBox2.Text);
            kenar2_d = Convert.ToInt32(textBox3.Text);
            alan_d = kenar_d * kenar2_d;
            cevre_d = kenar_d * 2 + kenar2_d * 2;
            textBox10.Text = alan_d.ToString();
            textBox11.Text = cevre_d.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int kenar1_u, cevre_u, alan_u, kenar2_u, kenar3_u, yukseklık_u;
            kenar1_u = Convert.ToInt32(textBox4.Text);
            kenar2_u = Convert.ToInt32(textBox5.Text);
            kenar3_u = Convert.ToInt32(textBox6.Text);
            yukseklık_u = Convert.ToInt32(textBox7.Text);
            alan_u = (kenar3_u * yukseklık_u) / 2;
            cevre_u = kenar1_u + kenar2_u + kenar3_u;
            textBox10.Text = alan_u.ToString();
            textBox11.Text = cevre_u.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int r, alan_c, cevre_c;
            r = Convert.ToInt32(textBox8.Text);
            alan_c = r * r * 3;
            cevre_c = 2 * r * 3;
            textBox10.Text = alan_c.ToString();
            textBox11.Text = cevre_c.ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            foreach (Control item in this.Controls)
            {
                if (item is TextBox)
                {
                    (item as TextBox).Clear();
                }
            }
        }
    }
}

    


