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
using System.Reflection.Emit;

namespace proje8_Hastane_Sistemi
{
    public partial class frm_bilgi_duzenle : Form
    {
        public frm_bilgi_duzenle()
        {
            InitializeComponent();
        }

        clsSqlBaglanti bgl = new clsSqlBaglanti();
        public string tcno;
        private void frm_bilgi_duzenle_Load(object sender, EventArgs e)
        {
            mskTc.Text = tcno;

            SqlCommand komut = new SqlCommand("select hastaAd,HastaSoyad,hastaTel,HastaSifre,HastaCinsiyet from Tbl_Hasta where hastaTc=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", mskTc.Text);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read()) 
            {
                txtAd.Text = dr[0].ToString();
                txtSoyad.Text = dr[1].ToString();
                mskTel.Text = dr[2].ToString();
                txtSifre.Text = dr[3].ToString();
                cmbCinsiyet.Text = dr[4].ToString();
            }
            bgl.baglanti().Close();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            SqlCommand komutguncelle = new SqlCommand("Update Tbl_hasta Set hastaAd=@a1, hastaSoyad=@a2,hastaTel=@a3,hastaSifre=@a4,hastaCinsiyet=@a5 where hastaTc=@a6", bgl.baglanti());
            komutguncelle.Parameters.AddWithValue("@a1", txtAd.Text);
            komutguncelle.Parameters.AddWithValue("@a2", txtSoyad.Text);
            komutguncelle.Parameters.AddWithValue("@a3", mskTel.Text);
            komutguncelle.Parameters.AddWithValue("@a4", txtSifre.Text);
            komutguncelle.Parameters.AddWithValue("@a5", cmbCinsiyet.Text);
            komutguncelle.Parameters.AddWithValue("@a6", mskTc.Text);
            
            komutguncelle.ExecuteNonQuery();

            bgl.baglanti().Close();

            MessageBox.Show("Hasta Bilgisi Güncellendi !!!");
        }
    }
}
