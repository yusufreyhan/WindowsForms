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
using System.Windows.Forms.VisualStyles;

namespace proje_2._4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        OleDbConnection bgl = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\acr\\Desktop\\dbSozluk.accdb");
        Random rast = new Random();
        int sure = 90, kelime = 0;
        

        void getir()
        {
            int sayi;
            sayi = rast.Next(1, 2490);


            bgl.Open();
            OleDbCommand komut = new OleDbCommand("select * from sozluk where id=@p1", bgl);
            komut.Parameters.AddWithValue("@p1", sayi);
            OleDbDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                txting.Text = dr[1].ToString();
                lblcevap.Text = dr[2].ToString();
                lblcevap.Text=lblcevap.Text.ToLower();
            }
            bgl.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            getir();
            timer1.Start();
            txting.Enabled = false;
        }

        private void txttr_TextChanged(object sender, EventArgs e)
        {
            
            if (txttr.Text == lblcevap.Text)
            {
                getir();
                kelime++;
                lblkelime.Text = kelime.ToString();
                txttr.Clear();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            sure--;
            lblsüre.Text = sure.ToString();
            if (sure == 0)
            {
                timer1.Stop();
                txttr.Enabled = false;
                MessageBox.Show("SÜRENİZ BİTTİ");
                
            }
        }

        private void label3_DockChanged(object sender, EventArgs e)
        {

        }
    }
}
