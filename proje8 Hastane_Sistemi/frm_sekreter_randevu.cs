using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proje8_Hastane_Sistemi
{
    public partial class frm_sekreter_randevu : Form
    {
        public frm_sekreter_randevu()
        {
            InitializeComponent();
        }
        public int secilen;
        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            secilen = dataGridView1.SelectedCells[0].RowIndex;
        }
    }
}
