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
    public partial class frm_duyurular : Form
    {
        public frm_duyurular()
        {
            InitializeComponent();
        }
        clsSqlBaglanti bgl = new clsSqlBaglanti();
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void frm_duyurular_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select * from tbl_duyuru", bgl.baglanti()); 
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }
    }
}
