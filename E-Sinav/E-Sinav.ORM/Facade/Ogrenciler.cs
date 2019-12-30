using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Sinav.ORM.Facade
{
    public  class Ogrenciler
    {
        public static DataTable OgrenciGetir()
        {
            SqlDataAdapter adp = new SqlDataAdapter("OgrenciName", Baglanma.Baglanti);
            adp.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable dt = new DataTable();
            adp.Fill(dt);
            Baglanma.Baglanti.Close();
            return dt;
        }

    }
}
