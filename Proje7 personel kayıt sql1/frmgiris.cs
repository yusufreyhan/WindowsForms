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

namespace Proje7_personel_kayıt_sql1
{
    public partial class frmgiris : Form
    {
        public frmgiris()
        {
            InitializeComponent();
        }

        private void frmgiris_Load(object sender, EventArgs e)
        {

        }
        SqlConnection baglanti = new SqlConnection("Data Source = DESKTOP-152EBLU;Initial Catalog=personel_veri_tabani;Integrated Security=True");
        private void button1_Click(object sender, EventArgs e)
        {
            baglanti.Open();

            SqlCommand komutgiris = new SqlCommand("select * from Tbl_yoneticigiris where kullaniciadi=@p1 and sifre =@p2",baglanti);
            komutgiris.Parameters.AddWithValue("@p1", textBox1.Text);
            komutgiris.Parameters.AddWithValue("@p2", textBox2.Text);
            SqlDataReader drgiris = komutgiris.ExecuteReader();

            if(drgiris.Read())
            {
                Form1 form = new Form1();
                form.Show();
                this.Hide();
            }

            else
            {
                MessageBox.Show("Kullanıcı Adı ve ya Şifre Hatalı !!!");
            }

            baglanti.Close();

        }
    }
}
