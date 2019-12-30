using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Sinav.ORM.Entity
{
    public class TarihBilgi
    {
        public DateTime SinavTarih { get; set; }
        public int DogruSayisi { get; set; }
        public int OgrenciID { get; set; }
    }
}
