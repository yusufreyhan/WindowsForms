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
    public partial class frmistatistik : Form
    {
        public frmistatistik()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Data Source = DESKTOP-152EBLU;Initial Catalog=personel_veri_tabani;Integrated Security=True");

        private void frmistatistik_Load(object sender, EventArgs e)
        {
            baglanti.Open();

            SqlCommand komut1 = new SqlCommand("select count (*) from Tbl_personel",baglanti);
            SqlDataReader dr1 = komut1.ExecuteReader();
            
            while (dr1.Read()) 
            {
            lbltoplamps.Text = dr1[0].ToString();
            }

            baglanti.Close();

            baglanti.Open();

            SqlCommand komut2 = new SqlCommand("select count(*) from Tbl_personel where PerMedeni=1", baglanti);
            SqlDataReader dr2 = komut2.ExecuteReader();
           

            while (dr2.Read()) 
            {
            lblevliprs.Text = dr2[0].ToString();
            }

            baglanti.Close();

            baglanti.Open();

            SqlCommand komut3 = new SqlCommand("select count (*) from Tbl_personel where PerMedeni=0",baglanti);
            SqlDataReader dr3 = komut3.ExecuteReader();

            while (dr3.Read())
            {
                lblbekarprs.Text = dr3[0].ToString();
            }

            baglanti.Close();

            baglanti.Open();

            SqlCommand komut4 = new SqlCommand("select count(distinct(PerSehir)) from Tbl_personel", baglanti);

            SqlDataReader dr4 = komut4.ExecuteReader();

            while(dr4.Read())
            {
                lbltoplamsehir.Text = dr4[0].ToString();
            }

            baglanti.Close();

            baglanti.Open();

            SqlCommand komut5 = new SqlCommand("select sum(PerMaas) from Tbl_personel", baglanti);
            SqlDataReader dr5 = komut5.ExecuteReader();
            while (dr5.Read()) 
            {
            lbltoplammaass.Text = dr5[0].ToString();
            }

            baglanti.Close();

            baglanti.Open();

            SqlCommand komut6 = new SqlCommand("select avg(PerMaas) from Tbl_personel", baglanti);
            SqlDataReader dr6 = komut6.ExecuteReader();

            while( dr6.Read())
            {
                lblortmaass.Text = dr6[0].ToString();
            }
        }
    }
}
