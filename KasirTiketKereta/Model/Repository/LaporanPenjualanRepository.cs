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
    class LaporanPenjualanRepository
    {
        private OleDbConnection _conn;
        public LaporanPenjualanRepository(DbContext dbContext)
        {
            _conn = dbContext.Conn;
        }
        public List<LaporanPenjualan> ReadAll()
        {
            List<LaporanPenjualan> list = new List<LaporanPenjualan>();
            try
            {
                string sql = @"SELECT keterangan_tiket.kelas AS kelas, keterangan_tiket.stasiun_asal AS asal, keterangan_tiket.stasiun_tujuan AS tujuan, 
                            count(keterangan_tiket.kelas and keterangan_tiket.stasiun_asal and keterangan_tiket.stasiun_tujuan) AS jumlah, 

                            (select count(*) from (tiket a inner join gerbong b ON b.gerbong_id = a.gerbong_id) 
                            inner join keterangan_tiket c on c.keterangan_tiket_id = b.keterangan_tiket_id 
                            where a.pesanan_id is null and c.kelas = keterangan_tiket.kelas and c.stasiun_asal = keterangan_tiket.stasiun_asal 
                            and c.stasiun_tujuan = keterangan_tiket.stasiun_tujuan and c.jadwal_keberangkatan > #"+DateTime.Now.ToString("yyyy/MM/dd hh:mm:ss")+ @"#) AS tersedia, 

                            (select count(*) from (tiket a inner join gerbong b ON b.gerbong_id = a.gerbong_id) 
                            inner join keterangan_tiket c on c.keterangan_tiket_id = b.keterangan_tiket_id 
                            where a.pesanan_id is null and c.kelas = keterangan_tiket.kelas and c.stasiun_asal = keterangan_tiket.stasiun_asal 
                            and c.stasiun_tujuan = keterangan_tiket.stasiun_tujuan  and c.jadwal_keberangkatan <= #" + DateTime.Now.ToString("yyyy/MM/dd hh:mm:ss") + @"#) AS tidak_terjual, 

                            (select count(*) from (tiket a inner join gerbong b ON b.gerbong_id = a.gerbong_id) 
                            inner join keterangan_tiket c on c.keterangan_tiket_id = b.keterangan_tiket_id 
                            where a.pesanan_id is not null and c.kelas = keterangan_tiket.kelas and c.stasiun_asal = keterangan_tiket.stasiun_asal 
                            and c.stasiun_tujuan = keterangan_tiket.stasiun_tujuan) AS terjual, 

                            (select sum(c.harga) from (tiket a inner join gerbong b ON b.gerbong_id = a.gerbong_id) 
                            inner join keterangan_tiket c on c.keterangan_tiket_id = b.keterangan_tiket_id 
                            where a.pesanan_id is not null and c.kelas = keterangan_tiket.kelas and c.stasiun_asal = keterangan_tiket.stasiun_asal 
                            and c.stasiun_tujuan = keterangan_tiket.stasiun_tujuan) AS pendapatan

                            FROM keterangan_tiket INNER JOIN (gerbong INNER JOIN tiket ON gerbong.gerbong_id = tiket.gerbong_id) ON keterangan_tiket.keterangan_tiket_id = gerbong.keterangan_tiket_id
                            GROUP BY keterangan_tiket.kelas, keterangan_tiket.stasiun_asal, keterangan_tiket.stasiun_tujuan";
                using (OleDbCommand cmd = new OleDbCommand(sql, _conn))
                {
                    using (OleDbDataReader dtr = cmd.ExecuteReader())
                    {
                        while (dtr.Read())
                        {
                            LaporanPenjualan obj = new LaporanPenjualan();
                            obj.kelas = dtr["kelas"].ToString();
                            obj.asal = dtr["asal"].ToString();
                            obj.tujuan = dtr["tujuan"].ToString();
                            obj.jumlah = dtr["jumlah"].ToString();
                            obj.tersedia = dtr["tersedia"].ToString();
                            obj.tidak_terjual = dtr["tidak_terjual"].ToString();
                            obj.terjual = dtr["terjual"].ToString();
                            try
                            {
                                obj.pendapatan = int.Parse(dtr["pendapatan"].ToString());
                            } catch(Exception ex)
                            {
                                obj.pendapatan = 0;
                            }


                            list.Add(obj);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.Print("ReadAll error: {0}", ex.Message);
                MessageBox.Show("test", "Test", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return list;
        }

        public List<LaporanPenjualan> ReadByField(string value, string field)
        {
            List<LaporanPenjualan> list = new List<LaporanPenjualan>();
            try
            {
                string sql = @"SELECT keterangan_tiket.kelas AS kelas, keterangan_tiket.stasiun_asal AS asal, keterangan_tiket.stasiun_tujuan AS tujuan, count(keterangan_tiket.kelas and keterangan_tiket.stasiun_asal and keterangan_tiket.stasiun_tujuan) AS jumlah, 

                            (select count(*) from (tiket a inner join gerbong b ON b.gerbong_id = a.gerbong_id) 
                            inner join keterangan_tiket c on c.keterangan_tiket_id = b.keterangan_tiket_id 
                            where a.pesanan_id is null and c.kelas = keterangan_tiket.kelas and c.stasiun_asal = keterangan_tiket.stasiun_asal 
                            and c.stasiun_tujuan = keterangan_tiket.stasiun_tujuan and c.jadwal_keberangkatan > #" + DateTime.Now.ToString("yyyy/MM/dd hh:mm:ss") + @"#) AS tersedia, 

                            (select count(*) from (tiket a inner join gerbong b ON b.gerbong_id = a.gerbong_id) 
                            inner join keterangan_tiket c on c.keterangan_tiket_id = b.keterangan_tiket_id 
                            where a.pesanan_id is null and c.kelas = keterangan_tiket.kelas and c.stasiun_asal = keterangan_tiket.stasiun_asal 
                            and c.stasiun_tujuan = keterangan_tiket.stasiun_tujuan  and c.jadwal_keberangkatan <= #" + DateTime.Now.ToString("yyyy/MM/dd hh:mm:ss") + @"#) AS tidak_terjual, 

                            (select count(*) from (tiket a inner join gerbong b ON b.gerbong_id = a.gerbong_id) 
                            inner join keterangan_tiket c on c.keterangan_tiket_id = b.keterangan_tiket_id 
                            where a.pesanan_id is not null and c.kelas = keterangan_tiket.kelas and c.stasiun_asal = keterangan_tiket.stasiun_asal 
                            and c.stasiun_tujuan = keterangan_tiket.stasiun_tujuan) AS terjual, 

                            (select sum(c.harga) from (tiket a inner join gerbong b ON b.gerbong_id = a.gerbong_id) 
                            inner join keterangan_tiket c on c.keterangan_tiket_id = b.keterangan_tiket_id 
                            where a.pesanan_id is not null and c.kelas = keterangan_tiket.kelas and c.stasiun_asal = keterangan_tiket.stasiun_asal 
                            and c.stasiun_tujuan = keterangan_tiket.stasiun_tujuan) AS pendapatan

                            FROM keterangan_tiket INNER JOIN (gerbong INNER JOIN tiket ON gerbong.gerbong_id = tiket.gerbong_id) ON keterangan_tiket.keterangan_tiket_id = gerbong.keterangan_tiket_id
                            where " + field + @" like @value
                            GROUP BY keterangan_tiket.kelas, keterangan_tiket.stasiun_asal, keterangan_tiket.stasiun_tujuan";

                if (field == @"(select sum(c.harga) from (tiket a inner join gerbong b ON b.gerbong_id = a.gerbong_id) 
                            inner join keterangan_tiket c on c.keterangan_tiket_id = b.keterangan_tiket_id 
                            where a.pesanan_id is not null and c.kelas = keterangan_tiket.kelas and c.stasiun_asal = keterangan_tiket.stasiun_asal 
                            and c.stasiun_tujuan = keterangan_tiket.stasiun_tujuan)" && value == "0")
                {
                    sql = @"SELECT keterangan_tiket.kelas AS kelas, keterangan_tiket.stasiun_asal AS asal, keterangan_tiket.stasiun_tujuan AS tujuan, count(keterangan_tiket.kelas and keterangan_tiket.stasiun_asal and keterangan_tiket.stasiun_tujuan) AS jumlah, 

                            (select count(*) from (tiket a inner join gerbong b ON b.gerbong_id = a.gerbong_id) 
                            inner join keterangan_tiket c on c.keterangan_tiket_id = b.keterangan_tiket_id 
                            where a.pesanan_id is null and c.kelas = keterangan_tiket.kelas and c.stasiun_asal = keterangan_tiket.stasiun_asal 
                            and c.stasiun_tujuan = keterangan_tiket.stasiun_tujuan and c.jadwal_keberangkatan > #" + DateTime.Now.ToString("yyyy/MM/dd hh:mm:ss") + @"#) AS tersedia, 

                            (select count(*) from (tiket a inner join gerbong b ON b.gerbong_id = a.gerbong_id) 
                            inner join keterangan_tiket c on c.keterangan_tiket_id = b.keterangan_tiket_id 
                            where a.pesanan_id is null and c.kelas = keterangan_tiket.kelas and c.stasiun_asal = keterangan_tiket.stasiun_asal 
                            and c.stasiun_tujuan = keterangan_tiket.stasiun_tujuan  and c.jadwal_keberangkatan <= #" + DateTime.Now.ToString("yyyy/MM/dd hh:mm:ss") + @"#) AS tidak_terjual, 

                            (select count(*) from (tiket a inner join gerbong b ON b.gerbong_id = a.gerbong_id) 
                            inner join keterangan_tiket c on c.keterangan_tiket_id = b.keterangan_tiket_id 
                            where a.pesanan_id is not null and c.kelas = keterangan_tiket.kelas and c.stasiun_asal = keterangan_tiket.stasiun_asal 
                            and c.stasiun_tujuan = keterangan_tiket.stasiun_tujuan) AS terjual, 

                            (select sum(c.harga) from (tiket a inner join gerbong b ON b.gerbong_id = a.gerbong_id) 
                            inner join keterangan_tiket c on c.keterangan_tiket_id = b.keterangan_tiket_id 
                            where a.pesanan_id is not null and c.kelas = keterangan_tiket.kelas and c.stasiun_asal = keterangan_tiket.stasiun_asal 
                            and c.stasiun_tujuan = keterangan_tiket.stasiun_tujuan) AS pendapatan

                            FROM keterangan_tiket INNER JOIN (gerbong INNER JOIN tiket ON gerbong.gerbong_id = tiket.gerbong_id) ON keterangan_tiket.keterangan_tiket_id = gerbong.keterangan_tiket_id
                            where " + field + @" is null
                            GROUP BY keterangan_tiket.kelas, keterangan_tiket.stasiun_asal, keterangan_tiket.stasiun_tujuan";
                } else if(field == @"count(keterangan_tiket.kelas and keterangan_tiket.stasiun_asal and keterangan_tiket.stasiun_tujuan)")
                {
                    sql = @"SELECT keterangan_tiket.kelas AS kelas, keterangan_tiket.stasiun_asal AS asal, keterangan_tiket.stasiun_tujuan AS tujuan, count(keterangan_tiket.kelas and keterangan_tiket.stasiun_asal and keterangan_tiket.stasiun_tujuan) AS jumlah, 

                            (select count(*) from (tiket a inner join gerbong b ON b.gerbong_id = a.gerbong_id) 
                            inner join keterangan_tiket c on c.keterangan_tiket_id = b.keterangan_tiket_id 
                            where a.pesanan_id is null and c.kelas = keterangan_tiket.kelas and c.stasiun_asal = keterangan_tiket.stasiun_asal 
                            and c.stasiun_tujuan = keterangan_tiket.stasiun_tujuan and c.jadwal_keberangkatan > #" + DateTime.Now.ToString("yyyy/MM/dd hh:mm:ss") + @"#) AS tersedia, 

                            (select count(*) from (tiket a inner join gerbong b ON b.gerbong_id = a.gerbong_id) 
                            inner join keterangan_tiket c on c.keterangan_tiket_id = b.keterangan_tiket_id 
                            where a.pesanan_id is null and c.kelas = keterangan_tiket.kelas and c.stasiun_asal = keterangan_tiket.stasiun_asal 
                            and c.stasiun_tujuan = keterangan_tiket.stasiun_tujuan  and c.jadwal_keberangkatan <= #" + DateTime.Now.ToString("yyyy/MM/dd hh:mm:ss") + @"#) AS tidak_terjual, 

                            (select count(*) from (tiket a inner join gerbong b ON b.gerbong_id = a.gerbong_id) 
                            inner join keterangan_tiket c on c.keterangan_tiket_id = b.keterangan_tiket_id 
                            where a.pesanan_id is not null and c.kelas = keterangan_tiket.kelas and c.stasiun_asal = keterangan_tiket.stasiun_asal 
                            and c.stasiun_tujuan = keterangan_tiket.stasiun_tujuan) AS terjual, 

                            (select sum(c.harga) from (tiket a inner join gerbong b ON b.gerbong_id = a.gerbong_id) 
                            inner join keterangan_tiket c on c.keterangan_tiket_id = b.keterangan_tiket_id 
                            where a.pesanan_id is not null and c.kelas = keterangan_tiket.kelas and c.stasiun_asal = keterangan_tiket.stasiun_asal 
                            and c.stasiun_tujuan = keterangan_tiket.stasiun_tujuan) AS pendapatan

                            FROM keterangan_tiket INNER JOIN (gerbong INNER JOIN tiket ON gerbong.gerbong_id = tiket.gerbong_id) ON keterangan_tiket.keterangan_tiket_id = gerbong.keterangan_tiket_id
                            GROUP BY keterangan_tiket.kelas, keterangan_tiket.stasiun_asal, keterangan_tiket.stasiun_tujuan
                            having " +field+@" like @value";
                }

                using (OleDbCommand cmd = new OleDbCommand(sql, _conn))
                {
                    if (field == "keterangan_tiket.kelas" || field == "keterangan_tiket.stasiun_asal" 
                        || field == "keterangan_tiket.stasiun_tujuan")
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
                            LaporanPenjualan obj = new LaporanPenjualan();
                            obj.kelas = dtr["kelas"].ToString();
                            obj.asal = dtr["asal"].ToString();
                            obj.tujuan = dtr["tujuan"].ToString();
                            obj.jumlah = dtr["jumlah"].ToString();
                            obj.tersedia = dtr["tersedia"].ToString();
                            obj.tidak_terjual = dtr["tidak_terjual"].ToString();
                            obj.terjual = dtr["terjual"].ToString();
                            try
                            {
                                obj.pendapatan = int.Parse(dtr["pendapatan"].ToString());
                            }
                            catch(Exception ex)
                            {
                                obj.pendapatan = 0;
                            }


                            list.Add(obj);
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
    }
}
