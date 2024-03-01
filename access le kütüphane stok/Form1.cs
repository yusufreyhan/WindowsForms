using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Reflection.Emit;

namespace access_le_kütüphane_stok
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        OleDbConnection bgl = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\acr\Desktop\kitaplik.mdb");

        void listele ()
            {
       
            DataTable dt = new DataTable();
            OleDbDataAdapter da = new OleDbDataAdapter("select * from kitaplar", bgl);
            da.Fill (dt);
            dataGridView1.DataSource = dt;

            }

        private void Form1_Load(object sender, EventArgs e)
        {
            listele();
        }

        private void btnlistele_Click(object sender, EventArgs e)
        {
            listele();
        }

        string durum ="";

        private void btmkaydet_Click(object sender, EventArgs e)
        {
            bgl.Open();
          
            OleDbCommand komut = new OleDbCommand("insert into kitaplar (kitapad,kitapyazar,kitapsayfa,kitaptür,kitapdurum) values (@p1,@p2,@p3,@p4,@p5)", bgl);
            komut.Parameters.AddWithValue("@p1", txtad.Text);
            komut.Parameters.AddWithValue("@p2", txtyazar.Text);
            komut.Parameters.AddWithValue("@p3", txtsayfa.Text);
            komut.Parameters.AddWithValue("@p4", cmbtür.Text);
            komut.Parameters.AddWithValue("@p5", durum);
           
            komut.ExecuteNonQuery();
            
            bgl.Close();
            
            MessageBox.Show("Kitap kaydedildi!","Bilgi",MessageBoxButtons.OK, MessageBoxIcon.Information);


            listele();
        }

        private void rdbtn2_CheckedChanged(object sender, EventArgs e)
        {
            durum = "0";
        }

        private void rdbtn0_CheckedChanged(object sender, EventArgs e)
        {
            durum = "1";
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;

            txtid.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            txtad.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            txtyazar.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            txtsayfa.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            cmbtür.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();

            if (dataGridView1.Rows[secilen].Cells[5].Value.ToString() == "True")
            {
                rdbtn0.Checked = true;

            }
            else
            {

                rdbtn2.Checked = true;
            }
        }

        private void btnsil_Click(object sender, EventArgs e)
        {
            bgl.Open();

            OleDbCommand komutsil = new OleDbCommand ("delete from kitaplar where kitapid=@k1", bgl);
            komutsil.Parameters.AddWithValue("@k1", txtid.Text);
            komutsil.ExecuteNonQuery();

            bgl.Close();

            MessageBox.Show("kitap Kaydı Silindi !!!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

            listele();
        }

        private void btngüncelle_Click(object sender, EventArgs e)
        {
            bgl.Open();

            OleDbCommand komutg = new OleDbCommand("Update kitaplar Set kitapAd=@a1,kitapyazar=@a2,kitapsayfa=@a3,kitaptür=@a4,kitapdurum=@a5 where kitapid=@a6", bgl);
            komutg.Parameters.AddWithValue("@a1", txtad.Text);
            komutg.Parameters.AddWithValue("@a2", txtyazar.Text);
            komutg.Parameters.AddWithValue("@a3", txtsayfa.Text);
            komutg.Parameters.AddWithValue("@a4", cmbtür.Text);
            if(rdbtn2.Checked == true)
                {
                komutg.Parameters.AddWithValue("@a5", durum);
                }
            if(rdbtn0.Checked == true) 
            {
                komutg.Parameters.AddWithValue("@a5", durum);
            }
            komutg.Parameters.AddWithValue("@a6", txtid.Text);
           
            komutg.ExecuteNonQuery();

            bgl.Close();

            MessageBox.Show("Kitap Bilgisi Güncellendi !!!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

            listele();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OleDbCommand komuta = new OleDbCommand ("select * from kitaplar where kitapad like '%" +  textBox1.Text + "%'",bgl);
                DataTable dt = new DataTable();
            OleDbDataAdapter da = new OleDbDataAdapter(komuta);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }
    }
}
