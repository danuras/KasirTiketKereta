using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KasirTiketKereta.Model.Entity
{
    public class Gerbong
    {
        public string gerbong_id { get; set; }
        public string nama_gerbong { get; set; }
        public string keterangan_tiket_id { get; set; }
        public int jumlah_kursi { get; set; }
    }
}
