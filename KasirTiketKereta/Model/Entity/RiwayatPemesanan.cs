using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KasirTiketKereta.Model.Entity
{
    class RiwayatPemesanan
    {
        public string nama { get; set; }
        public string waktu { get; set; }
        public string asal { get; set; }
        public string tujuan { get; set; }
        public string jumlah { get; set; }
        public string kelas { get; set; }
        public string total { get; set; }
        public string kasir { get; set; }
    }
}
