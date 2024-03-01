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
    public partial class frm_sekreter_brans : Form
    {
        public frm_sekreter_brans()
        {
            InitializeComponent();
        }
         clsSqlBaglanti bgl = new clsSqlBaglanti();
        private void frm_sekreter_brans_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select * from tbl_brans",bgl.baglanti());
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

       

        private void btnEkle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into Tbl_brans (bransad) values (@p1)", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", txtSoyad.Text);

            komut.ExecuteNonQuery();

            bgl.baglanti().Close();
            MessageBox.Show("Branş Eklenmiştir !!!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            SqlCommand komutsil = new SqlCommand("delete from Tbl_brans where bransid=@k1", bgl.baglanti());
            komutsil.Parameters.AddWithValue("@k1", txtAd.Text);
            komutsil.ExecuteNonQuery();

            bgl.baglanti().Close();

            MessageBox.Show("Branş Silinmiştir !!!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnGüncelle_Click(object sender, EventArgs e)
        {
            SqlCommand komutguncelle = new SqlCommand("Update Tbl_brans Set  bransad=@d1 where bransid=@d2", bgl.baglanti());
            komutguncelle.Parameters.AddWithValue("@d1", txtSoyad.Text);
            komutguncelle.Parameters.AddWithValue("@d2", txtAd.Text);

            komutguncelle.ExecuteNonQuery();

            bgl.baglanti().Close();

            MessageBox.Show("Branş Bilgisi Güncellenmiştir !!!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            
            {
                int secilen = dataGridView1.SelectedCells[0].RowIndex;
                txtAd.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
                txtSoyad.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();

            }
        }
    }
}
