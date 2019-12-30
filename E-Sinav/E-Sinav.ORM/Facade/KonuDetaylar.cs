using E_Sinav.ORM.Entity;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Sinav.ORM.Facade
{
    public class KonuDetaylar
    {
        public static bool KonuDetayEkle(Ogrenci ogr,int konu,int deger)
        {
            SqlCommand komut = new SqlCommand("KonuNot", Baglanma.Baglanti);
            komut.CommandType = CommandType.StoredProcedure;
            komut.Parameters.AddWithValue("OgrenciID",ogr.OgrenciID);
            komut.Parameters.AddWithValue("KonuID", konu);
            komut.Parameters.AddWithValue("DogruSayisi", deger);
            return Baglanma.ExecuteNonQuery(komut);
        }
    }
}
