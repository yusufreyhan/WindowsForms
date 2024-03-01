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
    public partial class frm_doktor_ekran : Form
    {
        public frm_doktor_ekran()
        {
            InitializeComponent();
        }
        clsSqlBaglanti bgl = new clsSqlBaglanti();
        private void btnCikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
       
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {  
            frm_doktor_guncelle fr = new frm_doktor_guncelle();
            fr.tcno = lblTcNo.Text;
            fr.Show();
        }

        private void lblTcNo_Click(object sender, EventArgs e)
        {

        }
        public string tc;
        private void frm_doktor_ekran_Load(object sender, EventArgs e)
        {
            lblTcNo.Text = tc;

            //ad soyad
            SqlCommand komut = new SqlCommand("select doktorAd,doktorSoyad from Tbl_doktor where doktorTc=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", lblTcNo.Text);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                lblAdSoyad.Text = dr[0] + " " + dr[1];
            }

            bgl.baglanti().Close();

            //randevu
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select * from tbl_randevu where randevudoktor='" + lblAdSoyad.Text + "'", bgl.baglanti());
            da.Fill (dt);
            dataGridView1.DataSource= dt;

        }

        private void btnDuyuru_Click(object sender, EventArgs e)
        {


            frm_duyurular fr = new frm_duyurular();

            fr.Show();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            richtxtSikayet.Text = dataGridView1.Rows[secilen].Cells[7].Value.ToString();

        }
    }
}
