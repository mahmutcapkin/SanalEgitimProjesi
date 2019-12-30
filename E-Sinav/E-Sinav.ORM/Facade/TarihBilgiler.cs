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
    public class TarihBilgiler
    {
        public static bool ZamanNotEkle(Ogrenci ogr,TarihBilgi zaman,int deger )
        {
            SqlCommand komut = new SqlCommand("TariheGoreNot", Baglanma.Baglanti);
            komut.CommandType = CommandType.StoredProcedure;
            komut.Parameters.AddWithValue("OgrenciID", ogr.OgrenciID);
            komut.Parameters.AddWithValue("SinavTarih",zaman.SinavTarih);
            komut.Parameters.AddWithValue("DogruSayisi",deger);
            return Baglanma.ExecuteNonQuery(komut);
        }

    }
}
