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
    public partial class frmgrafik : Form
    {
        public frmgrafik()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source = DESKTOP-152EBLU;Initial Catalog=personel_veri_tabani;Integrated Security=True");
        private void frmgrafik_Load(object sender, EventArgs e)
        {
            baglanti.Open();
           
            SqlCommand komutg1 = new SqlCommand("select PerSehir,count(*) from Tbl_personel group by PerSehir", baglanti);
            SqlDataReader drg1 = komutg1.ExecuteReader();
           
            while (drg1.Read())
            {
                chart1.Series["Sehirler"].Points.AddXY(drg1[0], drg1[1]);
            }
            
            baglanti.Close();

            baglanti.Open();
            
            SqlCommand komutg2 = new SqlCommand("select PerMeslek,avg(PerMaas) from Tbl_personel group by PerMeslek",baglanti);
            SqlDataReader drg2 = komutg2.ExecuteReader();
           
            while (drg2.Read())
            {
                chart2.Series["Meslek-Maas"].Points.AddXY(drg2[0], drg2[1]);
            }

            baglanti.Close();
        }
    }
}
