using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KasirTiketKereta.Model.Entity
{
    public class Pelanggan
    {
        public string pelanggan_id { get; set; }
        public string alamat_email { get; set; }
        public string no_hp { get; set; }
        public string jenis_kelamin { get; set; }
        public string nama_kasir { get; set; }
        public string nama { get; set; }
    }
}
