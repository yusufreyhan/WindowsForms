using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;


namespace _2._2_proje_gerçek_döviz__xml_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string bugun = "https://www.tcmb.gov.tr/kurlar/today.xml";
            var xmldosya = new XmlDocument();  
            xmldosya.Load(bugun);

            string dolaralis = xmldosya.SelectSingleNode("Tarih_Date/Currency[@Kod='USD']/BanknoteBuying").InnerXml;
            lblda.Text = dolaralis;

            string dolarsatis = xmldosya.SelectSingleNode("Tarih_Date/Currency[@Kod='USD']/BanknoteSelling").InnerXml;
            lblds.Text = dolarsatis;

            string euroalis = xmldosya.SelectSingleNode("Tarih_Date/Currency[@Kod='EUR']/BanknoteBuying").InnerXml;
            lblea.Text = euroalis;

            string eurosatis = xmldosya.SelectSingleNode("Tarih_Date/Currency[@Kod='EUR']/BanknoteSelling").InnerXml;
            lbles.Text = eurosatis;

        }

        private void btnda_Click(object sender, EventArgs e)
        {
            txtkur.Text = lblda.Text;
        }

        private void btnds_Click(object sender, EventArgs e)
        {
            txtkur.Text = lblds.Text;
        }

        private void btnea_Click(object sender, EventArgs e)
        {
            txtkur.Text = lblea.Text;
        }

        private void btnes_Click(object sender, EventArgs e)
        {
            txtkur.Text = lbles.Text;
        }

        private void txtkur_TextChanged(object sender, EventArgs e)
        {
            txtkur.Text = txtkur.Text.Replace(".", ",");
        }

        private void btnsatisyap_Click(object sender, EventArgs e)
        {
            double kur, miktar, tutar;
            kur = Convert.ToDouble(txtkur.Text);
            miktar = Convert.ToDouble(txtmıktar.Text);
            tutar = miktar * kur;
            txttutar.Text = tutar.ToString();
            txtkalan.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double kur = Convert.ToDouble(txtkur.Text);
            int miktar = Convert.ToInt32(txtmıktar.Text);
            int tutar = Convert.ToInt32(miktar/kur);
            txttutar .Text = tutar.ToString();
            double kalan = miktar % kur;
            txtkalan.Text = kalan.ToString();

        }
    }
}
