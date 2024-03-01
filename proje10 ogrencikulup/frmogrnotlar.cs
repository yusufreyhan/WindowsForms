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

namespace proje10_ogrencikulup
{
    public partial class frmogrnotlar : Form
    {
        public frmogrnotlar()
        {
            InitializeComponent();
        }

        public string numara;
        SqlConnection bgl = new SqlConnection(@"Data Source=DESKTOP-152EBLU;Initial Catalog=ogrencikulup;Integrated Security=True");

        private void frmogrnotlar_Load(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("select dersad,sınav1,sınav2,sınav3,proje,ortalama,durum from tblnotlar inner join tbldersler on tblnotlar.dersıd = tbldersler.dersıd where @p1=ogrıd", bgl);
            komut.Parameters.AddWithValue("@p1", numara);
            //this.Text = numara.ToString();
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }
    }
}
