using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Runtime.CompilerServices;

namespace proje8_Hastane_Sistemi
{
    public partial class Frm_hasta_giris : Form
    {
        public Frm_hasta_giris()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        clsSqlBaglanti bgl = new clsSqlBaglanti();
        private void lnklblÜyeOl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Frm_Hasta_Kayıt fr = new Frm_Hasta_Kayıt();
            fr.Show();
            this.Hide();
        }

        private void btnGirişYap_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("select * from tbl_hasta where hastaTc=@p1 and hastaSifre=@p2", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", mskTc.Text);
            komut.Parameters.AddWithValue("@p2", textBox1.Text);

            SqlDataReader dr = komut.ExecuteReader();

            if (dr.Read()) 
            {
            Frm_Hasta_Ekran fr = new Frm_Hasta_Ekran();
                fr.tc = mskTc.Text;

                fr.Show();
                
                this.Hide();
            }
            else
            {
                MessageBox.Show("TC ya da sifre yanlış" , "HATA" , MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
          
            bgl.baglanti().Close();


        }

        private void Frm_hasta_giris_Load(object sender, EventArgs e)
        {
           
        }
    }
}
