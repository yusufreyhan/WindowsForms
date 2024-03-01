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
    public partial class frmkulup : Form
    {
        public frmkulup()
        {
            InitializeComponent();
        }

        SqlConnection bgl = new SqlConnection((@"Data Source=DESKTOP-152EBLU;Initial Catalog=ogrencikulup;Integrated Security=True");

        private void Form2_Load(object sender, EventArgs e)
        {
            SqlDataAdapter da = new SqlDataAdapter("select * from tblkulupler", bgl);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }
    }
}
