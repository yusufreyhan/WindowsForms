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

namespace proje8_Hastane_Sistemi
{
    public partial class frm_doktor_guncelle : Form
    {
        public frm_doktor_guncelle()
        {
            InitializeComponent();
        }
        clsSqlBaglanti bgl = new clsSqlBaglanti();
        public string tcno;
        private void cmbBrans_SelectedIndexChanged(object sender, EventArgs e)
        {
         
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            SqlCommand komutguncelle = new SqlCommand("Update Tbl_doktor Set doktorAd=@a1, doktorSoyad=@a2,doktorsifre=@a4,doktorbrans=@a5 where doktorTc=@a6", bgl.baglanti());
            komutguncelle.Parameters.AddWithValue("@a1", txtAd.Text);
            komutguncelle.Parameters.AddWithValue("@a2", txtSoyad.Text);
            komutguncelle.Parameters.AddWithValue("@a4", txtSifre.Text);
            komutguncelle.Parameters.AddWithValue("@a5", cmbBrans.Text);
            komutguncelle.Parameters.AddWithValue("@a6", mskTc.Text);

            komutguncelle.ExecuteNonQuery();

            bgl.baglanti().Close();

            MessageBox.Show("Doktor Bilgisi Güncellendi !!!");
        }

        private void frm_doktor_guncelle_Load(object sender, EventArgs e)
        {
            mskTc.Text = tcno;

            SqlCommand komut = new SqlCommand("select * from Tbl_doktor where doktorTc=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", mskTc.Text);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                txtAd.Text = dr[1].ToString();
                txtSoyad.Text = dr[2].ToString();
                txtSifre.Text = dr[4].ToString();
                cmbBrans.Text = dr[3].ToString();
            }
            bgl.baglanti().Close();
        }
    }
}
