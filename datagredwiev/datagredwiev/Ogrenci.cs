using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace datagredwiev
{
    internal class Ogrenci
    {
        string okulno;
        string isim;
        string telefon;
        string sinif;

        public string Okulno { get => okulno; set => okulno = value; }
        public string Isim { get => isim; set => isim = value; }
        public string Telefon { get => telefon; set => telefon = value; }
        public string Sinif { get => sinif; set => sinif = value; }
    }
}
