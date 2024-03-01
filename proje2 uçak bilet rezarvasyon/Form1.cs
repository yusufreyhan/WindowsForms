using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proje2_uçak_bilet_rezarvasyon
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("İsim Soyisim : "+textBox1.Text+" "+textBox2.Text);
            listBox1.Items.Add("TC : " +maskedTextBox3.Text);
            listBox1.Items.Add("Telefon : " +maskedTextBox2.Text);
            listBox1.Items.Add("Rota : " + comboBox1.Text+" - "+comboBox2.Text);
            listBox1.Items.Add("Zaman : " + dateTimePicker1.Text + " - " + maskedTextBox1.Text);
            MessageBox.Show("Uçuş kaydınız yapıldı");

        }

        private void button2_Click(object sender, EventArgs e)
        {
            label10.Text = comboBox2.Text;
            comboBox2.Text = comboBox1.Text;
            comboBox1.Text = label10.Text;
        }
    }
}
