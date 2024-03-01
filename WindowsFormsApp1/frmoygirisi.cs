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

namespace WindowsFormsApp1
{
    public partial class frmoygirisi : Form
    {
        public frmoygirisi()
        {
            InitializeComponent();
        }
        SqlConnection bgl = new SqlConnection(@"Data Source=DESKTOP-152EBLU;Initial Catalog=secım_proje;Integrated Security=True");
        private void button1_Click(object sender, EventArgs e)
        {
            bgl.Open();
           
            SqlCommand komut = new SqlCommand("insert into tbl_ilce (ılcead,akp,chp,mhp,ıyıp,hdp) values (@p1,@p2,@p3,@p4,@p5,@p6)", bgl );
           
            komut.Parameters.AddWithValue("@p1", txtilce.Text);
            komut.Parameters.AddWithValue("@p2", txtakp.Text);
            komut.Parameters.AddWithValue("@p3", txtchp.Text);
            komut.Parameters.AddWithValue("@p4", txtmhp.Text);
            komut.Parameters.AddWithValue("@p5", txtıyıp.Text);
            komut.Parameters.AddWithValue("@p6", txthdp.Text);
          
            komut.ExecuteNonQuery();
           
            bgl.Close();
           
            MessageBox.Show("Oy Girişi Gerçekleşti");

           
        }

        private void btngrafik_Click(object sender, EventArgs e)
        {
            frmgrafik fr = new frmgrafik();
            fr.Show();
        }
    }
}
