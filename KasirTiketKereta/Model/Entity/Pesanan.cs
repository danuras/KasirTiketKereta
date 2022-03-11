using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KasirTiketKereta.Model.Entity
{
    public class Pesanan
    {
        public string pesanan_id { get; set; }
        public string waktu_pemesanan { get; set; }
        public string metode_pembayaran { get; set; }
        public int jumlah_tiket_dipesan { get; set; }
        public int total_bayar { get; set; }
        public string pelanggan_id { get; set; }
        public string nama_kasir { get; set; }
    }
}
