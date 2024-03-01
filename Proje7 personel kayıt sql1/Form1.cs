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

namespace Proje7_personel_kayıt_sql1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Data Source = DESKTOP-152EBLU;Initial Catalog=personel_veri_tabani;Integrated Security=True");

        void temizle ()
        { txtad.Text = "";
            txtsoyad.Text = "";
            txtmeslek.Text = "";
            txtid.Text = "";
            msktxtmaas.Text = "";
            cmbsehir.Text = "";
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            txtad.Focus();
        }


        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
          
                
            
            this.tbl_personelTableAdapter.Fill(this.personel_veri_tabaniDataSet.Tbl_personel);

        }

        private void btnlistele_Click(object sender, EventArgs e)
        {
            this.tbl_personelTableAdapter.Fill(this.personel_veri_tabaniDataSet.Tbl_personel);
        }

        private void btnkaydet_Click(object sender, EventArgs e)
        {
            baglanti.Open();

            SqlCommand komut = new SqlCommand("insert into Tbl_personel (PerAd,PerSoyad,PerMeslek,PerSehir,PerMaas,PerMedeni) values (@p1,@p2,@p3,@p4,@p5,@p6)", baglanti);
            komut.Parameters.AddWithValue("@p1", txtad.Text);
            komut.Parameters.AddWithValue("@p2", txtsoyad.Text);
            komut.Parameters.AddWithValue("@p3", txtmeslek.Text);
            komut.Parameters.AddWithValue("@p4", cmbsehir.Text);
            komut.Parameters.AddWithValue("@p5", msktxtmaas.Text);
            komut.Parameters.AddWithValue("@p6", label8.Text);

            komut.ExecuteNonQuery();

             baglanti.Close();
            MessageBox.Show("Personel Eklendi !!!");

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            label8.Text = "True";
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            label8.Text = "False";
        }

        private void btntemizle_Click(object sender, EventArgs e)
        {
            temizle();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            
            txtid.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            txtad.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            txtsoyad.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            cmbsehir.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            msktxtmaas.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            label8.Text = dataGridView1.Rows[secilen].Cells[5].Value.ToString();
            txtmeslek.Text = dataGridView1.Rows[secilen].Cells[6].Value.ToString();

            if (label8.Text == "True") 
            {
                radioButton1.Checked = true;
            }
            else 
            { 
                radioButton2.Checked = true;
            }
        }

        private void btbsil_Click(object sender, EventArgs e)
        {
            baglanti.Open();

            SqlCommand komutsil = new SqlCommand("delete from Tbl_personel where Perid=@k1", baglanti);
            komutsil.Parameters.AddWithValue("@k1",txtid.Text);
            komutsil.ExecuteNonQuery();

            baglanti.Close();
            
            MessageBox.Show("Personel Kaydı Silindi !!!");
        }

        private void btngüncelle_Click(object sender, EventArgs e)
        {
            baglanti.Open();

            SqlCommand komutguncelle = new SqlCommand("Update Tbl_personel Set PerAd=@a1,PerSoyad=@a2,PerSehir=@a3,PerMaas=@a4,PerMedeni=@a5,PerMeslek=@a6 where Perid=@a7", baglanti);
            komutguncelle.Parameters.AddWithValue("@a1", txtad.Text);
            komutguncelle.Parameters.AddWithValue("@a2", txtsoyad.Text);
            komutguncelle.Parameters.AddWithValue("@a3", cmbsehir.Text);
            komutguncelle.Parameters.AddWithValue("@a4", msktxtmaas.Text);
            komutguncelle.Parameters.AddWithValue("@a5", label8.Text);
            komutguncelle.Parameters.AddWithValue("@a6", txtmeslek.Text);
            komutguncelle.Parameters.AddWithValue("@a7", txtid.Text);
            komutguncelle.ExecuteNonQuery();
           
            baglanti.Close();
            
            MessageBox.Show("Personel Bilgisi Güncellendi !!!");
        }

        private void btnistatistik_Click(object sender, EventArgs e)
        {
            frmistatistik fr2 = new frmistatistik();
            fr2.Show();
        }

        private void btngarafikler_Click(object sender, EventArgs e)
        {
            frmgrafik fr3 = new frmgrafik();
            fr3.Show();
        }
    }
}
