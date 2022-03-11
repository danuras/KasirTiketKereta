using KasirTiketKereta.Model.Context;
using KasirTiketKereta.Model.Entity;
using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KasirTiketKereta.Model.Repository
{
    class RiwayatPemesananRepository
    {
        private OleDbConnection _conn;
        public RiwayatPemesananRepository(DbContext dbContext)
        {
            _conn = dbContext.Conn;
        }
        public List<RiwayatPemesanan> ReadAll()
        {
            List<RiwayatPemesanan> list = new List<RiwayatPemesanan>();
            try
            {
                string sql = @"select distinct pelanggan.nama as nama, pesanan.waktu_pemesanan as waktu, keterangan_tiket.stasiun_asal as asal,
                                keterangan_tiket.kelas as kelas, keterangan_tiket.stasiun_tujuan as tujuan, 
                                pesanan.jumlah_tiket_dipesan as jumlah, pesanan.total_bayar as total, pesanan.nama_kasir as kasir
                                from (((pelanggan inner join pesanan on pelanggan.pelanggan_id = pesanan.pelanggan_id)
                                inner join tiket on tiket.pesanan_id = pesanan.pesanan_id)
                                inner join gerbong on gerbong.gerbong_id = tiket.gerbong_id)
                                inner join keterangan_tiket on keterangan_tiket.keterangan_tiket_id = gerbong.keterangan_tiket_id";
                using (OleDbCommand cmd = new OleDbCommand(sql, _conn))
                {
                    using (OleDbDataReader dtr = cmd.ExecuteReader())
                    {
                        while (dtr.Read())
                        {
                            RiwayatPemesanan riwayatPemesanan = new RiwayatPemesanan();
                            riwayatPemesanan.nama = dtr["nama"].ToString();
                            riwayatPemesanan.waktu = dtr["waktu"].ToString();
                            riwayatPemesanan.asal = dtr["asal"].ToString();
                            riwayatPemesanan.tujuan = dtr["tujuan"].ToString();
                            riwayatPemesanan.kelas = dtr["kelas"].ToString();
                            riwayatPemesanan.jumlah = dtr["jumlah"].ToString();
                            riwayatPemesanan.total = dtr["total"].ToString();
                            riwayatPemesanan.kasir = dtr["kasir"].ToString();


                            list.Add(riwayatPemesanan);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.Print("ReadAll error: {0}", ex.Message);
            }
            return list;
        }

        public List<RiwayatPemesanan> ReadByField(string value, string field)
        {
            List<RiwayatPemesanan> list = new List<RiwayatPemesanan>();

            try
            {
                string sql = @"select distinct pelanggan.nama as nama, pesanan.waktu_pemesanan as waktu, keterangan_tiket.stasiun_asal as asal, keterangan_tiket.kelas as kelas, keterangan_tiket.stasiun_tujuan as tujuan, 
                                pesanan.jumlah_tiket_dipesan as jumlah, pesanan.total_bayar as total, pesanan.nama_kasir as kasir
                                from (((pelanggan inner join pesanan on pelanggan.pelanggan_id = pesanan.pelanggan_id)
                                inner join tiket on tiket.pesanan_id = pesanan.pesanan_id)
                                inner join gerbong on gerbong.gerbong_id = tiket.gerbong_id)
                                inner join keterangan_tiket on keterangan_tiket.keterangan_tiket_id = gerbong.keterangan_tiket_id where " + field + @" like @value order by pelanggan.nama";

                using (OleDbCommand cmd = new OleDbCommand(sql, _conn))
                {
                    if (field != "pesanan.jumlah_tiket_dipesan" && field != "pesanan.total_bayar")
                    {
                        cmd.Parameters.AddWithValue("@value", "%" + value + "%");
                    }
                    else
                    {
                        cmd.Parameters.AddWithValue("@value", value);
                    }


                    using (OleDbDataReader dtr = cmd.ExecuteReader())
                    {
                        while (dtr.Read())
                        {
                            RiwayatPemesanan riwayatPemesanan = new RiwayatPemesanan();
                            riwayatPemesanan.nama = dtr["nama"].ToString();
                            riwayatPemesanan.waktu = dtr["waktu"].ToString();
                            riwayatPemesanan.asal = dtr["asal"].ToString();
                            riwayatPemesanan.tujuan = dtr["tujuan"].ToString();
                            riwayatPemesanan.jumlah = dtr["jumlah"].ToString();
                            riwayatPemesanan.kelas = dtr["kelas"].ToString();
                            riwayatPemesanan.total = dtr["total"].ToString();
                            riwayatPemesanan.kasir = dtr["kasir"].ToString();

                            list.Add(riwayatPemesanan);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.Print("ReadByField error: {0}", ex.Message);
                MessageBox.Show("ReadByField error: {0}", ex.Message);
            }

            return list;
        }

    }
}
