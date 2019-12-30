using E_Sinav.ORM.Entity;
using E_Sinav.ORM.Facade;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace E_Sinav
{
    public partial class FrmTestCoz : Form
    {
        public FrmTestCoz()
        {
            InitializeComponent();
        }
        //SÜRE KONTROLÜ İÇİN
        int saniye = 60;
        int dakika = 10;
        //CEVAP KONTROLÜ İÇİN
        string[] Vcevap = new string[5] { null, null, null, null, null };
        string[] Dcevap = new string[5] { null, null, null, null, null };
        int bos = 0, yanlis = 0, dogru = 0;

        KonuDetay sorudetay = new KonuDetay();
        Soru soru = new Soru();
        Ogrenci ogrenci = new Ogrenci();
        TarihBilgi gun = new TarihBilgi();       
        private void FrmTestCoz_Load(object sender, EventArgs e)
        {
            ogrenci = Login.student;
            labelGorunumF();
            dgwSoru.Visible = false;
            dgwSoru.DataSource = Sorular.Getir(ogrenci.OgrenciID);
            timerSoru.Start();
            SoruSayisi();
            VeriCek(index);
            Kontrol();               
        }

        private void SoruSayisi()
        {
            lblSayi.Text = sorusayisi.ToString();
        }
          //SORULARI GETİRME İŞLEMİ 
        int index = 0;
        int sorusayisi = 1;
        public void VeriCek(int index)
        {         
            lblA.Text = dgwSoru.Rows[index].Cells[0].Value.ToString();
            lblB.Text = dgwSoru.Rows[index].Cells[1].Value.ToString();
            lblC.Text = dgwSoru.Rows[index].Cells[2].Value.ToString();
            lblD.Text = dgwSoru.Rows[index].Cells[3].Value.ToString();
            lblDogru.Text = dgwSoru.Rows[index].Cells[4].Value.ToString();
            txtSoruM.Text= dgwSoru.Rows[index].Cells[8].Value.ToString();
            pcbSoruResim.ImageLocation= dgwSoru.Rows[index].Cells[6].Value.ToString();
            Dcevap[index]= dgwSoru.Rows[index].Cells[4].Value.ToString();
            soru.askID[index] = Convert.ToInt32(dgwSoru.Rows[index].Cells[7].Value);
            soru.subjectID[index] = Convert.ToInt32(dgwSoru.Rows[index].Cells[5].Value);

            if (Vcevap[index]=="A")
            {
                ButonBoya();
                btnA.BackColor = Color.Red;
            }
            else if(Vcevap[index] == "B")
            {
                ButonBoya();
                btnB.BackColor = Color.Red;
            }
            else if(Vcevap[index] == "C")
            {
               ButonBoya();
                btnC.BackColor = Color.Red;
            }
            else if(Vcevap[index] == "D")
            {
                ButonBoya();
                btnD.BackColor = Color.Red;
            }
            else
                ButonBoya();

        }

        private void timerSoru_Tick(object sender, EventArgs e)
        {
            timerSoru.Interval = 1000;
            saniye = saniye - 1;
            lblSaniye.Text = saniye.ToString();
            lblDakika.Text = (dakika - 1).ToString();
            if(saniye==0)
            {
                dakika = dakika - 1;
                lblDakika.Text = dakika.ToString();
                saniye = 60;
            }
            
            if(lblDakika.Text=="-1")
            {
                timerSoru.Stop();
                lblDakika.Text = "00";
                lblSaniye.Text = "00";
                MessageBox.Show("Sınav Süreniz Bitmiştir","Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        public void Kontrol()
        {
            if (index == 4)
            {
                btnİleri.Visible = false;
               
            }

            if (index == 0)
            {
                btnGeri.Visible = false;
                
            }
        }
         
        private void btnİleri_Click(object sender, EventArgs e)
        {
            sorusayisi++;
            SoruSayisi();
            index++;
            VeriCek(index);
            Kontrol();
            btnGeri.Visible = true;
        }

        private void btnGeri_Click(object sender, EventArgs e)
        {
            sorusayisi--;
            SoruSayisi();
            index--;
            Kontrol();                
            VeriCek(index);
            btnİleri.Visible = true;
        }


        public  void ButonBoya()
        {
            btnA.BackColor = Color.FromArgb(46,139,87);
            btnB.BackColor = Color.FromArgb(46, 139, 87);
            btnC.BackColor = Color.FromArgb(46, 139, 87);
            btnD.BackColor = Color.FromArgb(46, 139, 87);
        }
        public void DogruKontrol(string[] dogrucevap,string[] verilencevap)
        {
            int i = 0;
            for(i=0;i<5;i++)
            {
                if (Vcevap[i] == null)
                {
                    bos++;
                }
                else if (Vcevap[i] == dogrucevap[i])
                {
                    
                    Sorular.AsamaArttir(soru.askID[i],ogrenci);
                    KonuDetaylar.KonuDetayEkle(ogrenci,soru.subjectID[i],dogru);
                    dogru++;
                }
                else if (Vcevap[i] != dogrucevap[i])
                {
                    yanlis++;
                }
                else
                    continue;
                   
            }

        }

        private void btnB_Click(object sender, EventArgs e)
        {
            ButonBoya();
            btnB.BackColor = Color.Red;
            Vcevap[index] = "B";
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            ButonBoya();
            btnC.BackColor = Color.Red;
            Vcevap[index] = "C";
        }

        private void btnD_Click(object sender, EventArgs e)
        {
            ButonBoya();
            btnD.BackColor = Color.Red;
            Vcevap[index] = "D";
        }

        private void btnA_Click(object sender, EventArgs e)
        {
            ButonBoya();
            btnA.BackColor = Color.Red;
            Vcevap[index] = "A";

        }

        private void btnBitir_Click(object sender, EventArgs e)
        {
            gun.SinavTarih = DateTime.Today;
            DogruKontrol(Dcevap,Vcevap);
            timerSoru.Stop();
            btnA.Enabled = false;
            btnB.Enabled = false;
            btnC.Enabled = false;
            btnD.Enabled = false;
            btnBitir.Enabled = false;
            labelGorunumT();
            lblDsayi.Text = dogru.ToString();
            lblYsayi.Text = yanlis.ToString();
            lblBsayi.Text = bos.ToString();
            TarihBilgiler.ZamanNotEkle(ogrenci,gun,dogru);
            btnBitir.Enabled = false;
        }



        public void labelGorunumT()
        {
            lblDogru.Visible = true;
            lblDogruC.Visible = true;
            lblDsayi.Visible = true;
            lblDsayisi.Visible = true;
            lblYsayi.Visible = true;
            lblYsayisi.Visible = true;
            lblBsayi.Visible = true;
            lblBsayisi.Visible = true;
        }
        public void labelGorunumF()
        {
            lblDogru.Visible = false;
            lblDogruC.Visible = false;
            lblDsayi.Visible = false;
            lblDsayisi.Visible = false;
            lblYsayi.Visible = false;
            lblYsayisi.Visible = false;
            lblBsayi.Visible = false;
            lblBsayisi.Visible = false;
        }


    }
}
