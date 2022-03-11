using KasirTiketKereta.Model.Context;
using KasirTiketKereta.Model.Entity;
using System;
using System.Collections.Generic;
using System.Data.OleDb;

namespace KasirTiketKereta.Model.Repository
{
    class LaporanKerjaRepository
    {
        private OleDbConnection _conn;
        public LaporanKerjaRepository(DbContext dbContext)
        {
            _conn = dbContext.Conn;
        }

        public List<LaporanKerja> ReadAll()
        {
            List<LaporanKerja> list = new List<LaporanKerja>();
            try
            {
                string sql = @"select kasir.nama_kasir as nama, count(*) as jumlah_pelanggan, 
                                (select sum(jumlah_tiket_dipesan) from pesanan where nama_kasir = kasir.nama_kasir)  as jumlah_tiket_terjual,
                                (select sum(total_bayar) from pesanan where nama_kasir = kasir.nama_kasir) as pendapatan from (kasir inner join pelanggan
                                on kasir.nama_kasir=pelanggan.nama_kasir) group by kasir.nama_kasir";
                using (OleDbCommand cmd = new OleDbCommand(sql, _conn))
                {
                    using (OleDbDataReader dtr = cmd.ExecuteReader())
                    {
                        while (dtr.Read())
                        {
                            LaporanKerja laporanKerja = new LaporanKerja();
                            laporanKerja.nama_kasir = dtr["nama"].ToString();
                            laporanKerja.jumlah_pelanggan = dtr["jumlah_pelanggan"].ToString();
                            laporanKerja.tiket_terjual = dtr["jumlah_tiket_terjual"].ToString();
                            laporanKerja.pendapatan = dtr["pendapatan"].ToString();

                            list.Add(laporanKerja);
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

        public List<LaporanKerja> ReadByField(string value, string field)
        {
            List<LaporanKerja> list = new List<LaporanKerja>();

            try
            {
                string sql = @"select kasir.nama_kasir as nama, count(*) as jumlah_pelanggan, 
                                (select sum(jumlah_tiket_dipesan) from pesanan where nama_kasir = kasir.nama_kasir) as jumlah_tiket_terjual,
                                (select sum(total_bayar) from pesanan where nama_kasir = kasir.nama_kasir)  as pendapatan from (kasir inner join pelanggan
                                on kasir.nama_kasir=pelanggan.nama_kasir) group by kasir.nama_kasir having " + field + @" like @value";

                using (OleDbCommand cmd = new OleDbCommand(sql, _conn))
                {
                    if (field == "kasir.nama_kasir")
                    {
                        cmd.Parameters.AddWithValue("@value", "%" + value + "%");
                    }
                    else
                    {
                        cmd.Parameters.AddWithValue("@value",  value);
                    }


                    using (OleDbDataReader dtr = cmd.ExecuteReader())
                    {
                        while (dtr.Read())
                        {
                            LaporanKerja laporanKerja = new LaporanKerja();
                            laporanKerja.nama_kasir = dtr["nama"].ToString();
                            laporanKerja.jumlah_pelanggan = dtr["jumlah_pelanggan"].ToString();
                            laporanKerja.tiket_terjual = dtr["jumlah_tiket_terjual"].ToString();
                            laporanKerja.pendapatan = dtr["pendapatan"].ToString();

                            list.Add(laporanKerja);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.Print("ReadByField error: {0}", ex.Message);
            }

            return list;
        }
    }
}
