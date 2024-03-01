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

namespace proje11_ogrencinorkayıt
{
    public partial class frm_ogrencidetay : Form
    {
        public frm_ogrencidetay()
        {
            InitializeComponent();
        }
        public string num;
        private void frm_ogrencidetay_Load(object sender, EventArgs e)
        {
            lblnum.Text = num;
        }
    }
}
