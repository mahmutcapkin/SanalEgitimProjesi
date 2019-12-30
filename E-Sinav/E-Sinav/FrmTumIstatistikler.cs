using E_Sinav.ORM;
using E_Sinav.ORM.Entity;
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
    public partial class FrmTumIstatistikler : Form
    {
        public FrmTumIstatistikler()
        {
            InitializeComponent();
        }
        int ID = 0;
        int deger = 0;
        private void FrmTumIstatistikler_Load(object sender, EventArgs e)
        {
            OgrenciBilgiCek();           
        }
        void TarihBilgiGetir(int deger)
        {
            SqlCommand komut = new SqlCommand("TarihBilgiCek", Baglanma.Baglanti);
            Baglanma.Baglanti.Open();
            komut.CommandType = CommandType.StoredProcedure;
            komut.Parameters.AddWithValue("OgrenciID",deger);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                chartTarih.Series["Notlar"].Points.AddXY(dr[0].ToString(), dr[1].ToString());
            }
            Baglanma.Baglanti.Close();
        }
        void KonuBilgiGetir(int deger)
        {
            SqlCommand komut = new SqlCommand("KonuBilgiCek", Baglanma.Baglanti);
            Baglanma.Baglanti.Open();
            komut.CommandType = CommandType.StoredProcedure;
            komut.Parameters.AddWithValue("OgrenciID", deger);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                chartKonu.Series["SoruMiktar"].Points.AddXY(dr[1].ToString(), dr[0].ToString());
            }
            Baglanma.Baglanti.Close();
        }

        void OgrenciBilgiCek()
        {
            SqlCommand komut = new SqlCommand("OgrenciName", Baglanma.Baglanti);
            Baglanma.Baglanti.Open();
            komut.CommandType = CommandType.StoredProcedure;
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                cmbKonuO.Items.Add(dr[0]);
                cmbTarihO.Items.Add(dr[0]);
            }
            Baglanma.Baglanti.Close();
        }

        private void btnGetirT_Click(object sender, EventArgs e)
        {
            ID = cmbTarihO.SelectedIndex + 1;
            TarihBilgiGetir(ID);
        }
        private void btnGetirK_Click(object sender, EventArgs e)
        {
            deger = cmbKonuO.SelectedIndex + 1;       
            KonuBilgiGetir(deger);
        }

        private void cmbTarihO_SelectedIndexChanged(object sender, EventArgs e)
        {
            Temizle();
        }
        void Temizle()
        {
            foreach (var series in chartTarih.Series)
            {
                series.Points.Clear();
            }
        }

        private void cmbKonuO_SelectedIndexChanged(object sender, EventArgs e)
        {
            Temizle();
        }
    }
}
