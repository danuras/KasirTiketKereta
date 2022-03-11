using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KasirTiketKereta.Model.Entity
{
    public class Tiket
    {
        public string tiket_id { get; set; }
        public int nomor_kursi { get; set; }
        public string pesanan_id { get; set; }
        public string gerbong_id { get; set; }

    }
}
