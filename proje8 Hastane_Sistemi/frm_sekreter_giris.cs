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
    public partial class frm_sekreter_giris : Form
    {
        public frm_sekreter_giris()
        {
            InitializeComponent();
        }
        clsSqlBaglanti bgl = new clsSqlBaglanti();
        private void btnGirişYap_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("select * from tbl_sekreter where sekretertc=@p1 and sekretersifre=@p2", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", mskTc.Text);
            komut.Parameters.AddWithValue("@p2", textBox1.Text);

            SqlDataReader dr = komut.ExecuteReader();

            if (dr.Read())
            {
                frm_sekreter_ekran fr = new frm_sekreter_ekran();

                fr.tc = mskTc.Text;

                fr.Show();

                this.Hide();
            }

            else
            {
                MessageBox.Show("Tc Kimlik ve ya Şifre yanlış !!" , "HATA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void frm_sekreter_giris_Load(object sender, EventArgs e)
        {

        }
    }
}
