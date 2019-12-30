using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Sinav.ORM.Entity
{
    public class Soru
    {
        
        public int SoruID { get; set; }
        public string cevapA { get; set; }
        public string cevapB { get; set; }
        public string cevapC { get; set; }
        public string cevapD { get; set; }
        public string DogruCevap { get; set; }
        public string SoruMetni { get; set; }
        public int KonuID { get; set; }
        public string Resim { get; set; }
        public int[] askID = new int[5];
        public int[] subjectID = new int[5];
    }
}
