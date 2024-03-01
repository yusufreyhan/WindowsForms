﻿using System;
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
    public partial class Frm_Hasta_Kayıt : Form
    {


        public Frm_Hasta_Kayıt()
        {
            InitializeComponent();
        }

        private void Frm_Hasta_Kayıt_Load(object sender, EventArgs e)
        {

        }
        clsSqlBaglanti bgl = new clsSqlBaglanti();
        private void btnKayıtOl_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into Tbl_Hasta (HastaAd,HastaSoyad,HastaTC,HastaTel,HastaSifre,HastaCinsiyet) values (@p1,@p2,@p3,@p4,@p5,@p6)" , bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", txtAd.Text);
            komut.Parameters.AddWithValue("@p2", txtSoyad.Text);
            komut.Parameters.AddWithValue("@p3", mskTc.Text);
            komut.Parameters.AddWithValue("@p4", mskTel.Text);
            komut.Parameters.AddWithValue("@p5", txtSifre.Text);
            komut.Parameters.AddWithValue("@p6", cmbCinsiyet.Text);

            komut.ExecuteNonQuery();
            
            bgl.baglanti().Close();

            MessageBox.Show("Hasta kaydı yapılmıştır Şifreniz : "+txtSifre.Text , "Bilgi" , MessageBoxButtons.OK , MessageBoxIcon.Information );
        }
    }
}
