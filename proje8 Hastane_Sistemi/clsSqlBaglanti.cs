using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace proje8_Hastane_Sistemi
{
    internal class clsSqlBaglanti
    {
        public SqlConnection baglanti ()
        {
            SqlConnection baglan = new SqlConnection("Data Source=DESKTOP-152EBLU;Initial Catalog=hastane_veri_tabani;Integrated Security=True");
            baglan.Open();
            return baglan;
        }
        
    }
}
