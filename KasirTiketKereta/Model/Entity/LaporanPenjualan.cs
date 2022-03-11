using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KasirTiketKereta.Model.Entity
{
    class LaporanPenjualan
    {
        public string kelas { get; set; }
        public string asal { get; set; }
        public string tujuan { get; set; }
        public string jumlah { get; set; }
        public string tersedia { get; set; }
        public string tidak_terjual { get; set; }
        public string terjual { get; set; }
        public int pendapatan { get; set; }
    }
}
