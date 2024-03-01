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
using System.Reflection.Emit;

namespace proje8_Hastane_Sistemi
{
    public partial class frm_sekreter_doktor : Form
    {
        public frm_sekreter_doktor()
        {
            InitializeComponent();
        }

        clsSqlBaglanti bgl = new clsSqlBaglanti();
        private void frm_sekreter_doktor_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select * from tbl_doktor", bgl.baglanti());
            da.Fill(dt);
            dataGridView1.DataSource = dt;

            //branş çekme
            SqlCommand komut2 = new SqlCommand("select bransAd from tbl_brans", bgl.baglanti());
            SqlDataReader dr2 = komut2.ExecuteReader();
            while (dr2.Read())
            {
                cmbBrans.Items.Add(dr2[0]);
            }

            bgl.baglanti().Close();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into Tbl_Doktor (DoktorAd, DoktorSoyad,DoktorBrans,doktorsifre,doktortc) values (@p1,@p2,@p3,@p4,@p5)", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", txtAd.Text);
            komut.Parameters.AddWithValue("@p2", txtSoyad.Text);
            komut.Parameters.AddWithValue("@p3", cmbBrans.Text);
            komut.Parameters.AddWithValue("@p4", txtSifre.Text);
            komut.Parameters.AddWithValue("@p5", mskTc.Text);
            

            komut.ExecuteNonQuery();

            bgl.baglanti().Close();
            MessageBox.Show("Doktor Eklenmiştir !!!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            SqlCommand komutsil = new SqlCommand("delete from Tbl_doktor where doktortc=@k1", bgl.baglanti());
            komutsil.Parameters.AddWithValue("@k1", mskTc.Text);
            komutsil.ExecuteNonQuery();

            bgl.baglanti().Close();

            MessageBox.Show("Doktor Silinmiştir !!!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            txtAd.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            txtSoyad.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            cmbBrans.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            txtSifre.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            mskTc.Text = dataGridView1.Rows[secilen].Cells[5].Value.ToString();
        }

        private void btnGüncelle_Click(object sender, EventArgs e)
        {
            SqlCommand komutguncelle = new SqlCommand("Update Tbl_doktor Set DoktorAd=@d1, DoktorSoyad=@d2,DoktorBrans=@d3,doktorsifre=@d4 where doktortc=@d5", bgl.baglanti());
            komutguncelle.Parameters.AddWithValue("@d1", txtAd.Text);
            komutguncelle.Parameters.AddWithValue("@d2", txtSoyad.Text);
            komutguncelle.Parameters.AddWithValue("@d3", cmbBrans.Text);
            komutguncelle.Parameters.AddWithValue("@d4", txtSifre.Text);
            komutguncelle.Parameters.AddWithValue("@d5", mskTc.Text);
            
            komutguncelle.ExecuteNonQuery();

            bgl.baglanti().Close();

            MessageBox.Show("Doktor Bilgisi Güncellenmiştir !!!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
