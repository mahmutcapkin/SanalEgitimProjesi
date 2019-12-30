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
    public partial class FrmSoruEkle : Form
    {
        public FrmSoruEkle()
        {
            InitializeComponent();
        }
        int soruid=0;
        int deger = 0;
        int id = 0;
        private void btnResimAktif_Click(object sender, EventArgs e)
        {
            pcbSoru.Visible = true;
            openFileDialog1.ShowDialog();
            pcbSoru.ImageLocation = openFileDialog1.FileName;
            txtResim.Text= openFileDialog1.FileName;
        }

        private void FrmSoruEkle_Load(object sender, EventArgs e)
        {
            pcbSoru.Visible = false;
        }

        private void btnSoruKaydet_Click(object sender, EventArgs e)
        {
            dgwListe.DataSource = Sorular.Listele();            
            deger = dgwListe.RowCount-2;          
            dgwOgrenci.DataSource= Ogrenciler.OgrenciGetir();          
            SoruEkleme();   
        }
       
        public void Temizle()
        {
            txtA.Text = "";
            txtB.Text = "";
            txtC.Text = "";
            txtD.Text = "";
            txtResim.Text = "";
            txtSoruMetni.Text = "";
            cmbDogru.Text = "";
            cmbKonu.Text = "";
            pcbSoru.Image = null;
            pcbSoru.Invalidate();
            pcbSoru.Visible = false;
        }


        private void txtSoruMetni_KeyPress(object sender, KeyPressEventArgs e)
        {
                 
                if (e.KeyChar == '£' || e.KeyChar == '½' ||
                e.KeyChar == '€' || e.KeyChar == '₺' ||
                e.KeyChar == '¨' || e.KeyChar == 'æ' ||
                e.KeyChar == 'ß' || e.KeyChar == '´')
                {
                    e.Handled = true;
                }
                if ((int)e.KeyChar == 95 || (int)e.KeyChar == 96 || (int)e.KeyChar == 34 || (int)e.KeyChar == 46 || (int)e.KeyChar == 64 || (int)e.KeyChar == 59)
                {
                    e.Handled = true;
                }
       
         
        }
        private void txtA_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (e.KeyChar == '£' || e.KeyChar == '½' ||
            e.KeyChar == '€' || e.KeyChar == '₺' ||
            e.KeyChar == '¨' || e.KeyChar == 'æ' ||
            e.KeyChar == 'ß' || e.KeyChar == '´')
            {
                e.Handled = true;
            }
            if ((int)e.KeyChar == 95 || (int)e.KeyChar == 96 || (int)e.KeyChar == 34 || (int)e.KeyChar == 46 || (int)e.KeyChar == 64 || (int)e.KeyChar == 59)
            {
                e.Handled = true;
            }
        }


        private void txtB_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '£' || e.KeyChar == '½' ||
                e.KeyChar == '€' || e.KeyChar == '₺' ||
                e.KeyChar == '¨' || e.KeyChar == 'æ' ||
                e.KeyChar == 'ß' || e.KeyChar == '´')
            {
                e.Handled = true;
            }
            if ((int)e.KeyChar == 95 || (int)e.KeyChar == 96 || (int)e.KeyChar == 34 || (int)e.KeyChar == 46 || (int)e.KeyChar == 64 || (int)e.KeyChar == 59)
            {
                e.Handled = true;
            }
        }

        private void txtC_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '£' || e.KeyChar == '½' ||
                 e.KeyChar == '€' || e.KeyChar == '₺' ||
                 e.KeyChar == '¨' || e.KeyChar == 'æ' ||
                 e.KeyChar == 'ß' || e.KeyChar == '´')
            {
                e.Handled = true;
            }
            if ((int)e.KeyChar == 95 || (int)e.KeyChar == 96 || (int)e.KeyChar == 34 || (int)e.KeyChar == 46 || (int)e.KeyChar == 64 || (int)e.KeyChar == 59)
            {
                e.Handled = true;
            }
        }

        private void txtD_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '£' || e.KeyChar == '½' ||
                e.KeyChar == '€' || e.KeyChar == '₺' ||
                e.KeyChar == '¨' || e.KeyChar == 'æ' ||
                e.KeyChar == 'ß' || e.KeyChar == '´')
            {
                e.Handled = true;
            }
            if ((int)e.KeyChar == 95 || (int)e.KeyChar == 96 || (int)e.KeyChar == 34 || (int)e.KeyChar == 46 || (int)e.KeyChar == 64 || (int)e.KeyChar == 59)
            {
                e.Handled = true;
            }
        }

        void SoruEkleme()
        {
            if (txtA.Text == "" || txtB.Text == "" || txtC.Text == "" || txtD.Text == "" || txtSoruMetni.Text == "")
            {
                MessageBox.Show("Soru Metni ya da şıklar boş geçilemez", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                UzunlukKontrol();
            }
        }
        void UzunlukKontrol()
        {
            if (txtA.TextLength > 75 || txtB.TextLength > 75 || txtC.TextLength > 75 || txtD.TextLength > 75  || txtSoruMetni.TextLength > 240)
            {
                MessageBox.Show("Soru Metni uzunluğunu ya da seçenek uzunluğunu Aşmayın", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txtA.TextLength <=75 || txtB.TextLength <= 75 || txtC.TextLength <= 75 || txtD.TextLength <= 75 || txtSoruMetni.TextLength <= 240)
            {
                Soru soru = new Soru();
                soru.cevapA = txtA.Text;
                soru.cevapB = txtB.Text;
                soru.cevapC = txtC.Text;
                soru.cevapD = txtD.Text;
                soru.DogruCevap = cmbDogru.Text;
                soru.SoruMetni = txtSoruMetni.Text;
                soru.KonuID = cmbKonu.SelectedIndex + 1;
                soru.Resim = txtResim.Text;
                if (!Sorular.Ekle(soru))
                    MessageBox.Show("Soru Eklenemedi");
                else
                {
                    MessageBox.Show("Soru Eklendi");
                    soruid = Convert.ToInt32(dgwListe.Rows[deger].Cells[2].Value);
                    for (int i = 1; i < dgwOgrenci.RowCount; i++)
                    {
                        id = Convert.ToInt32(dgwOgrenci.Rows[i].Index);
                        Sorular.AsamaEkle(soruid, id);
                    }
                    Temizle();
                }                
            }
            else
                MessageBox.Show("Soru Eklenemedi Lütfen Tekrar deneyiniz", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

    }
}
