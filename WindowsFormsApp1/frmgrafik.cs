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
    public partial class frmgrafik : Form
    {
        public frmgrafik()
        {
            InitializeComponent();
        }
        SqlConnection bgl = new SqlConnection(@"Data Source=DESKTOP-152EBLU;Initial Catalog=secım_proje;Integrated Security=True");
        private void frmgrafik_Load(object sender, EventArgs e)
        {
            //ilçe adlarını combobox a çekme
            bgl.Open();
            SqlCommand komut = new SqlCommand("select ılcead from tbl_ilce",bgl);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                comboBox1.Items.Add(dr[0]);
            }
            bgl.Close();

            //grafiğe sonuç getirme

            bgl.Open();
            SqlCommand komut2 = new SqlCommand("select Sum(akp),sum(chp),sum(mhp),sum(ıyıp),sum(hdp) from tbl_ilce", bgl);
            SqlDataReader dr2 = komut2.ExecuteReader(); 
            while (dr2.Read())
            {
                chart1.Series["Partiler"].Points.AddXY("AKP",  dr2[0]);
                chart1.Series["Partiler"].Points.AddXY("CHP",  dr2[1]);
                chart1.Series["Partiler"].Points.AddXY("MHP",  dr2[2]);
                chart1.Series["Partiler"].Points.AddXY("IYIP", dr2[3]);
                chart1.Series["Partiler"].Points.AddXY("HDP",  dr2[4]);
            }
            bgl.Close();

          
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            bgl.Open();
            SqlCommand komut = new SqlCommand("select * from tbl_ilce where ılcead=@p1", bgl);
            komut.Parameters.AddWithValue("@p1", comboBox1.Text);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                progressBar1.Value = int.Parse(dr[2].ToString());
                progressBar2.Value = int.Parse(dr[3].ToString());
                progressBar3.Value = int.Parse(dr[4].ToString());
                progressBar4.Value = int.Parse(dr[5].ToString());
                progressBar5.Value = int.Parse(dr[6].ToString());

                lblakp.Text  = dr[2].ToString();
                lblchp.Text  = dr[3].ToString();
                lblmhp.Text  = dr[4].ToString();
                lblıyıp.Text = dr[5].ToString();
                lblhdp.Text  = dr[6].ToString();

            }

            bgl.Close();
        }
    }
}
