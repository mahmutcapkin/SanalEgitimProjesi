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
    public partial class FrmOgrenci : Form
    {
        public FrmOgrenci()
        {
            InitializeComponent();
        }

        private void btnTestCoz_Click(object sender, EventArgs e)
        {
            FrmTestCoz test = new FrmTestCoz();
            test.MdiParent = this;
            test.Show();

        }

        private void btnOgrİstatistik_Click(object sender, EventArgs e)
        {
            FrmIstatistik istatistik = new FrmIstatistik();
            istatistik.MdiParent = this;
            istatistik.Show();
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
           
            Application.Exit();
        }

    }
}
