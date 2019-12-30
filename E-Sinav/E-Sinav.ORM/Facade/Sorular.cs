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
    public class Sorular
    {

        public static DataTable Getir(int deger)
        {
            SqlDataAdapter adp = new SqlDataAdapter("SoruGetir", Baglanma.Baglanti);
            adp.SelectCommand.CommandType = CommandType.StoredProcedure;
            adp.SelectCommand.Parameters.AddWithValue("OgrenciID",deger);
            DataTable dt = new DataTable();
            adp.Fill(dt);
            Baglanma.Baglanti.Close();
            return dt;
        }
        public static DataTable Listele()
        {
            SqlDataAdapter adp = new SqlDataAdapter("SoruListele", Baglanma.Baglanti);
            adp.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable dt = new DataTable();
            adp.Fill(dt);
            Baglanma.Baglanti.Close();
            return dt;
        }
        public static bool Ekle(Soru soru)
        {
            SqlCommand komut = new SqlCommand("SoruEkle", Baglanma.Baglanti);
            komut.CommandType = CommandType.StoredProcedure;
            komut.Parameters.AddWithValue("cevapA", soru.cevapA);
            komut.Parameters.AddWithValue("cevapB", soru.cevapB);
            komut.Parameters.AddWithValue("cevapC", soru.cevapC);
            komut.Parameters.AddWithValue("cevapD", soru.cevapD);
            komut.Parameters.AddWithValue("DogruCevap", soru.DogruCevap);
            komut.Parameters.AddWithValue("KonuID", soru.KonuID);
            komut.Parameters.AddWithValue("SoruMetni", soru.SoruMetni);
            komut.Parameters.AddWithValue("Resim", soru.Resim);
            return Baglanma.ExecuteNonQuery(komut);
        }

        public static bool AsamaArttir(int deger,Ogrenci ogr)
        {
            SqlCommand komut = new SqlCommand("AsamaArttir", Baglanma.Baglanti);
            komut.CommandType = CommandType.StoredProcedure;
            komut.Parameters.AddWithValue("OgrenciID", ogr.OgrenciID);
            komut.Parameters.AddWithValue("SoruID",deger);
            return Baglanma.ExecuteNonQuery(komut);
        }

        public static bool AsamaEkle(int askid,int ogrid)
        {
            SqlCommand komut = new SqlCommand("AsamaEkle", Baglanma.Baglanti);
            komut.CommandType = CommandType.StoredProcedure;
            komut.Parameters.AddWithValue("OgrenciID", ogrid);
            komut.Parameters.AddWithValue("SoruID", askid);
            return Baglanma.ExecuteNonQuery(komut);
        }





    }
}

