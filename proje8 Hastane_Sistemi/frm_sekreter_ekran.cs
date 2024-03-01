using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace proje8_Hastane_Sistemi
{
    public partial class frm_sekreter_ekran : Form
    {
        public frm_sekreter_ekran()
        {
            InitializeComponent();
        }
        clsSqlBaglanti bgl = new clsSqlBaglanti();
        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox6_Enter(object sender, EventArgs e)
        {

        }

        public string tc;
        public string secilen;
        private void frm_sekreter_ekran_Load(object sender, EventArgs e)
        {
            //tc çekme
            lblTcNo.Text = tc;
            txtid.Text = secilen;
            //isim çekme
            SqlCommand komut = new SqlCommand("select sekreterAdSoyad from Tbl_sekreter where sekreterTc=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", lblTcNo.Text);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                lblAdSoyad.Text = dr[0].ToString();
            }

            //branş çekme
            SqlCommand komut2 = new SqlCommand("select bransAd from tbl_brans", bgl.baglanti());
            SqlDataReader dr2 = komut2.ExecuteReader();
            while (dr2.Read())
            {
                cmbBrans.Items.Add(dr2[0]);
            }

            bgl.baglanti().Close();

            //branşları datagride aktarma
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select * from tbl_brans", bgl.baglanti());
            da.Fill(dt);
            dataGridView1.DataSource = dt;

            //doktorları datagride aktarma
            DataTable dt1 = new DataTable();
            SqlDataAdapter da1 = new SqlDataAdapter("select (doktorad + ' ' + doktorsoyad) as 'doktorad' , doktorbrans from tbl_doktor", bgl.baglanti());
            da1.Fill(dt1);
            dataGridView2.DataSource = dt1;

            
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            SqlCommand komutkaydet = new SqlCommand("insert into tbl_randevu (RandevuTarih,RandevuSaat,RandevuBrans,RandevuDoktor) values (@r1,@r2,@r3,@r4)", bgl.baglanti());
            komutkaydet.Parameters.AddWithValue("@r1" , mskTarih.Text);
            komutkaydet.Parameters.AddWithValue("@r2", mskSaat.Text);
            komutkaydet.Parameters.AddWithValue("@r3", cmbBrans.Text);
            komutkaydet.Parameters.AddWithValue("@r4", cmbDoktor.Text);

            SqlDataReader drkaydet = komutkaydet.ExecuteReader();

            MessageBox.Show("Randevu kaydediliştir !!!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void btnOlustur_Click(object sender, EventArgs e)
        {
            SqlCommand komutduyuru = new SqlCommand("insert into tbl_duyuru (duyuru) values (@d1)" ,bgl.baglanti());
            komutduyuru.Parameters.AddWithValue("@d1", richTextBox1.Text);
            komutduyuru.ExecuteNonQuery();
            bgl.baglanti().Close();

            MessageBox.Show("Duyuru Oluşturulmuştur !!!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnDoktorPaneli_Click(object sender, EventArgs e)
        {
            frm_sekreter_doktor frdoktor = new frm_sekreter_doktor();

            frdoktor.Show();

        }

        private void btnBransPaneli_Click(object sender, EventArgs e)
        {
            frm_sekreter_brans frbrans = new frm_sekreter_brans();
            
            frbrans.Show();

        }

        private void btnRandevuPaneli_Click(object sender, EventArgs e)
        {
            frm_sekreter_randevu frrandevu = new frm_sekreter_randevu();

            frrandevu.Show();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frm_duyurular fr = new frm_duyurular();
            fr.Show();
        }
    }
}
