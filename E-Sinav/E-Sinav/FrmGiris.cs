using E_Sinav.ORM.Entity;
using E_Sinav.ORM.Facade;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace E_Sinav
{
    public partial class FrmGiris : Form
    {
        public FrmGiris()
        {
            InitializeComponent();
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            Giris();
        }
        private void btnKapat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtTc_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar >= 47 && (int)e.KeyChar <= 57)
            {
                e.Handled = false;
            }
            else if ((int)e.KeyChar == 8)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }
         void Giris()
        {
            if(rdbOgrenci.Checked==true)
            {
                UzunlukS();
            }
            else if (rdbOgretmen.Checked == true)
            {
                UzunlukT();               
            }
            else
                MessageBox.Show("Lütfen Öğretmen ya da Öğrenci seçimi yapınız", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void txtSifre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar >= 47 && (int)e.KeyChar <= 57)
            {
                e.Handled = false;//eğer 47 -58 arasındaysa tuşu yazdır.
            }      
            else if ((int)e.KeyChar == 8)
            {
                e.Handled = false;//eğer basılan tuş backspace ise yazdır.
            }
            else
            {
                e.Handled = true;//bunların dışındaysa hiçbirisini yazdırma
            }
        }


        void Ogretmen()
        {
            Ogretmen ogretmen = new Ogretmen();
            ogretmen.OgrTCKN = txtTc.Text;
            ogretmen.OgrSifre = txtSifre.Text;
            if (Login.OgretmenGiris(ogretmen) == true)
            {
                FrmOgretmen ogr = new FrmOgretmen();
                ogr.Show();
                this.Hide();
            }
            else
                MessageBox.Show("Hatalı kullanıcı adı ya da şifre girdiniz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        void Ogrenci()
        {
            Ogrenci ogrenci = new Ogrenci();
            ogrenci.TCKN = txtTc.Text;
            ogrenci.Sifre = txtSifre.Text;
            if (Login.GirisYap(ogrenci) == true)
            {
                FrmOgrenci ogr = new FrmOgrenci();
                ogr.Show();
                this.Hide();
            }
            else
                MessageBox.Show("Hatalı kullanıcı adı ya da şifre girdiniz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        void UzunlukT()
    {
        if (txtSifre.Text == "" || txtSifre.Text == "")
        {
            MessageBox.Show(" kullanıcı adı veya şifre boş geçilemez", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        else
        {
            if (txtSifre.TextLength > 5 || txtTc.TextLength > 11)
            {
                MessageBox.Show("TCKN uzunuluğunu ya da şifre uzunluğunu aşmayın", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txtSifre.TextLength == 5 || txtTc.TextLength == 11)
            {
                Ogretmen();
            }
            else
                MessageBox.Show("TCKN uzunluğunu ya da şifre uzunluğunu doğru girin", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

    }

        void UzunlukS()
        {
            if (txtSifre.Text == "" || txtSifre.Text == "")
            {
                MessageBox.Show(" kullanıcı adı veya şifre boş geçilemez", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (txtSifre.TextLength > 5 || txtTc.TextLength > 11)
                {
                    MessageBox.Show("TCKN uzunuluğunu ya da şifre uzunluğunu aşmayın", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (txtSifre.TextLength == 5 || txtTc.TextLength == 11)
                {
                    Ogrenci();
                }
                else
                    MessageBox.Show("TCKN uzunluğunu ya da şifre uzunluğunu doğru girin", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


    }

}
