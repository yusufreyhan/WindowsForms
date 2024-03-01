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
    public partial class Frm_Hasta_Ekran : Form
    {
        public Frm_Hasta_Ekran()
        {
            InitializeComponent();
        } 

        clsSqlBaglanti bgl = new clsSqlBaglanti();

        public string tc;
        
        private void Frm_Hasta_Ekran_Load(object sender, EventArgs e)
        {
            //tc çekme
            lblTcNo.Text = tc;
            //isim çekme
            SqlCommand komut = new SqlCommand("select hastaAd,HastaSoyad from Tbl_Hasta where HastaTc=@p1" , bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", lblTcNo.Text);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read()) 
            {
                lblAdSoyad.Text= dr[0] + " " + dr[1];
            }

            bgl.baglanti().Close();

            //randevu geçmişi
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select * from tbl_randevu where hastatc="+lblTcNo.Text , bgl.baglanti());
            da.Fill(dt);
            dataGridView1.DataSource = dt;

            //brans çekme
            SqlCommand komut2 = new SqlCommand("select bransAd from tbl_brans", bgl.baglanti());
            SqlDataReader dr2 = komut2.ExecuteReader();
            while(dr2.Read())
            {
                cmbBrans.Items.Add(dr2[0]);
            }
            
            bgl.baglanti().Close();
          


        }


        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frm_bilgi_duzenle fr = new frm_bilgi_duzenle();
            fr.tcno = lblTcNo.Text;
            fr.Show();
            
        }

        private void cmbBrans_SelectedIndexChanged(object sender, EventArgs e)
        {

            //doktor çekme
            cmbDoktor.Items.Clear();
            cmbDoktor.Text = " ";
            
            
            SqlCommand komut3 = new SqlCommand("select doktorAd,doktorSoyad from tbl_doktor where doktorbrans=@p1", bgl.baglanti());
            komut3.Parameters.AddWithValue("@p1", cmbBrans.Text);
            SqlDataReader dr3 = komut3.ExecuteReader();
            while (dr3.Read())
            {
                cmbDoktor.Items.Add(dr3[0] + " " + dr3[1]);
            }

            bgl.baglanti().Close();

        }

        private void cmbDoktor_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select * from tbl_randevu where randevubrans='" + cmbBrans.Text + "'" + "and randevudoktor='" +cmbDoktor.Text+"' and randevudurum=0", bgl.baglanti());
            da.Fill(dt);
            dataGridView2.DataSource = dt;
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView2.SelectedCells[0].RowIndex;
            label1.Text = dataGridView2.Rows[secilen].Cells[0].Value.ToString();
        }

        private void btnRandevuAl_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("update tbl_randevu set randevudurum=1,hastatc=@p1,sikayet=@p2 where randevuid=@p3", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", lblTcNo.Text);
            komut.Parameters.AddWithValue("@p2", richtxtSikayet.Text);
            komut.Parameters.AddWithValue("@p3", label1.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Randevu alındı", "UYARI", MessageBoxButtons.OK,MessageBoxIcon.Warning);
        }
    }
}
