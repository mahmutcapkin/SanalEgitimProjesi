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
    public partial class FrmOgretmen : Form
    {
        public FrmOgretmen()
        {
            InitializeComponent();
        }
        
        private void btnSoruEkle_Click(object sender, EventArgs e)
        {
            FrmSoruEkle soruekle = new FrmSoruEkle();
            soruekle.MdiParent = this;
            soruekle.Show();
        }

        private void btnIstatistik_Click(object sender, EventArgs e)
        {
            FrmTumIstatistikler tumbilgi = new FrmTumIstatistikler();
            tumbilgi.MdiParent = this;
            tumbilgi.Show();
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
