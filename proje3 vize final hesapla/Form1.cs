using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proje3_vize_final_hesapla
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double vıze, fınal, ort;
                vıze = Convert.ToDouble(textBox1.Text);
                fınal = Convert.ToDouble(textBox2.Text);
                ort = (vıze * 0.4) + (fınal * 0.6);
                listBox1.Items.Add(ort);
        }
    }
}
