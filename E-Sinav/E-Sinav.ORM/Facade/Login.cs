using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using E_Sinav.ORM.Entity;

namespace E_Sinav.ORM.Facade
{
    public class Login
    {

        public static bool GirisYap(Ogrenci ogrenci)
        {
            SqlCommand komut = new SqlCommand("GirisYap", Baglanma.Baglanti);
            Baglanma.Baglanti.Open();

            komut.CommandType = CommandType.StoredProcedure;
            komut.Parameters.AddWithValue("@TCKN", ogrenci.TCKN);
            komut.Parameters.AddWithValue("@Sifre", ogrenci.Sifre);
            SqlDataReader dr = komut.ExecuteReader();
            Ogrenci ogr = new Ogrenci();
            if (dr.Read())
            {
                ogr.OgrenciID = Convert.ToInt32(dr["OgrenciID"]);
                ogr.OgrenciAd = dr["OgrenciAd"].ToString();
                ogr.OgrenciSoyad = dr["OgrenciSoyad"].ToString();
                ogr.TCKN = dr["TCKN"].ToString();
                student = ogr;
                Baglanma.Baglanti.Close();
                return true;
            }
            else
            {
                Baglanma.Baglanti.Close();
                return false;
            }

        }
        public static bool OgretmenGiris(Ogretmen ogretmen)
        {
            SqlCommand komut = new SqlCommand("OgretmenGiris", Baglanma.Baglanti);
            Baglanma.Baglanti.Open();
            komut.CommandType = CommandType.StoredProcedure;
            komut.Parameters.AddWithValue("@TCKN", ogretmen.OgrTCKN);
            komut.Parameters.AddWithValue("@Sifre",ogretmen.OgrSifre);
            SqlDataReader dr = komut.ExecuteReader();
            Ogrenci ogr = new Ogrenci();
            if (dr.Read())
            {               
                Baglanma.Baglanti.Close();
                return true;
            }
            else
            {
                Baglanma.Baglanti.Close();
                return false;
            }

        }

        public static Ogrenci student;


  
  

    }
}
