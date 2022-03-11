using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KasirTiketKereta.Model.Entity
{
    public class KeteranganTiket
    {
        public string keterangan_tiket_id{ get; set; }
        public string jenis_kereta{ get; set; }
        public string kelas{ get; set; }
        public string nama_kereta{ get; set; }
        public string stasiun_asal{ get; set; }
        public string stasiun_tujuan{ get; set; }
        public string jadwal_keberangkatan{ get; set; }
        public string jadwal_kedatangan{ get; set; }
        public int harga{ get; set; }

    }
}
