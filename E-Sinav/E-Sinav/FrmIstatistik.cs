using E_Sinav.ORM;
using E_Sinav.ORM.Entity;
using E_Sinav.ORM.Facade;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace E_Sinav
{
    public partial class FrmIstatistik : Form
    {
        public FrmIstatistik()
        {
            InitializeComponent();
        }
        Ogrenci ogr = new Ogrenci();
        private void FrmIstatistik_Load(object sender, EventArgs e)
        {
            ogr = Login.student;
            TarihBilgiGetir(ogr);
            KonuBilgiGetir(ogr);
        }
         void  TarihBilgiGetir(Ogrenci ogrenci)
        {
            SqlCommand komut = new SqlCommand("TarihBilgiCek", Baglanma.Baglanti);
            Baglanma.Baglanti.Open();
            komut.CommandType = CommandType.StoredProcedure;
            komut.Parameters.AddWithValue("OgrenciID", ogrenci.OgrenciID);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                chartTarih.Series["Notlar"].Points.AddXY(dr[0].ToString(), dr[1].ToString()); 
            }
            Baglanma.Baglanti.Close();
        }
        void KonuBilgiGetir(Ogrenci ogrenci)
        {
            SqlCommand komut = new SqlCommand("KonuBilgiCek", Baglanma.Baglanti);
            Baglanma.Baglanti.Open();
            komut.CommandType = CommandType.StoredProcedure;
            komut.Parameters.AddWithValue("OgrenciID", ogrenci.OgrenciID);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                chartKonu.Series["SoruMiktar"].Points.AddXY(dr[1].ToString(), dr[0].ToString());
            }
            Baglanma.Baglanti.Close();
        }

    }
}
