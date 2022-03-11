using KasirTiketKereta.Model.Context;
using KasirTiketKereta.Model.Entity;
using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KasirTiketKereta.Model.Repository
{
    class KeteranganTiketRepository
    {
        private OleDbConnection _conn;
        public KeteranganTiketRepository(DbContext dbContext)
        {
            _conn = dbContext.Conn;
        }
        public int Create(KeteranganTiket keteranganTiket)
        {
            int result = 0;
            string sql = @"insert into keterangan_tiket 
                    (keterangan_tiket_id, jenis_kereta, kelas, 
                    nama_kereta, stasiun_asal, stasiun_tujuan,
                    jadwal_keberangkatan, jadwal_kedatangan, harga)
                    values (@keterangan_tiket_id, @jenis_kereta, @kelas, 
                    @nama_kereta, @stasiun_asal, @stasiun_tujuan,
                    @jadwal_keberangkatan, @jadwal_kedatangan, @harga)";
            using (OleDbCommand cmd = new OleDbCommand(sql, _conn))
            {
                cmd.Parameters.AddWithValue("@keterangan_tiket_id", keteranganTiket.keterangan_tiket_id);
                cmd.Parameters.AddWithValue("@jenis_kereta", keteranganTiket.jenis_kereta);
                cmd.Parameters.AddWithValue("@kelas", keteranganTiket.kelas);
                cmd.Parameters.AddWithValue("@nama_kereta", keteranganTiket.nama_kereta);
                cmd.Parameters.AddWithValue("@stasiun_asal", keteranganTiket.stasiun_asal);
                cmd.Parameters.AddWithValue("@stasiun_tujuan", keteranganTiket.stasiun_tujuan);
                cmd.Parameters.AddWithValue("@jadwal_keberangkatan", keteranganTiket.jadwal_keberangkatan);
                cmd.Parameters.AddWithValue("@jadwal_kedatangan", keteranganTiket.jadwal_kedatangan);
                cmd.Parameters.AddWithValue("@harga", keteranganTiket.harga);

                try
                {
                    result = cmd.ExecuteNonQuery();
                }
                catch(Exception ex)
                {
                    System.Diagnostics.Debug.Print("Create error: {0}", ex.Message);
                }
            }
            return result;
        }
        public int Update(KeteranganTiket keteranganTiket)
        {
            int result = 0;
            string sql = @"update keterangan_tiket set
                    keterangan_tiket_id = @keterangan_tiket_id, 
                    jenis_kereta = @jenis_kereta, kelas = @kelas, 
                    nama_kereta = @nama_kereta, stasiun_asal = @stasiun_asal, 
                    stasiun_tujuan = @stasiun_tujuan, harga = "+keteranganTiket.harga.ToString()+@",
                    jadwal_keberangkatan = @jadwal_keberangkatan, 
                    jadwal_kedatangan = @jadwal_kedatangan
                    where keterangan_tiket_id = @keterangan_tiket_id";
            using (OleDbCommand cmd = new OleDbCommand(sql, _conn))
            {
                cmd.Parameters.AddWithValue("@keterangan_tiket_id", keteranganTiket.keterangan_tiket_id);
                cmd.Parameters.AddWithValue("@jenis_kereta", keteranganTiket.jenis_kereta);
                cmd.Parameters.AddWithValue("@kelas", keteranganTiket.kelas);
                cmd.Parameters.AddWithValue("@nama_kereta", keteranganTiket.nama_kereta);
                cmd.Parameters.AddWithValue("@stasiun_asal", keteranganTiket.stasiun_asal);
                cmd.Parameters.AddWithValue("@stasiun_tujuan", keteranganTiket.stasiun_tujuan);
                cmd.Parameters.AddWithValue("@jadwal_keberangkatan", keteranganTiket.jadwal_keberangkatan);
                cmd.Parameters.AddWithValue("@jadwal_kedatangan", keteranganTiket.jadwal_kedatangan);

                try
                {
                    result = cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    System.Diagnostics.Debug.Print("Update error: {0}", ex.Message);
                }
            }
            return result;
        }
        public int Delete(KeteranganTiket keteranganTiket)
        {
            int result = 0;
            string sql = @"delete from keterangan_tiket
                           where keterangan_tiket_id = @keterangan_tiket_id";
            using (OleDbCommand cmd = new OleDbCommand(sql, _conn))
            {
                cmd.Parameters.AddWithValue("@keterangan_tiket_id", keteranganTiket.keterangan_tiket_id);
                try
                {
                    result = cmd.ExecuteNonQuery();
                }
                catch(Exception ex)
                {
                    System.Diagnostics.Debug.Print("Delete error: {0}", ex.Message);
                }
            }

            return result;
        }
        public List<KeteranganTiket> ReadByField(string value, string field)
        {
            List<KeteranganTiket> list = new List<KeteranganTiket>();

            try
            {
                string sql = @"select * from keterangan_tiket where " + field + " like @value order by keterangan_tiket_id";

                using (OleDbCommand cmd = new OleDbCommand(sql, _conn))
                {
                    if (field != "harga")
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
                            KeteranganTiket keteranganTiket = new KeteranganTiket();
                            keteranganTiket.keterangan_tiket_id = dtr["keterangan_tiket_id"].ToString();
                            keteranganTiket.jenis_kereta = dtr["jenis_kereta"].ToString();
                            keteranganTiket.kelas = dtr["kelas"].ToString();
                            keteranganTiket.nama_kereta = dtr["nama_kereta"].ToString();
                            keteranganTiket.stasiun_asal = dtr["stasiun_asal"].ToString();
                            keteranganTiket.stasiun_tujuan = dtr["stasiun_tujuan"].ToString();
                            keteranganTiket.jadwal_keberangkatan = dtr["jadwal_keberangkatan"].ToString();
                            keteranganTiket.jadwal_kedatangan = dtr["jadwal_kedatangan"].ToString();
                            keteranganTiket.harga = int.Parse(dtr["harga"].ToString());

                            list.Add(keteranganTiket);
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
        public List<KeteranganTiket> ReadAll()
        {
            List<KeteranganTiket> list = new List<KeteranganTiket>();
            try
            {
                string sql = @"select keterangan_tiket_id, jenis_kereta, kelas, 
                    nama_kereta, stasiun_asal, stasiun_tujuan,
                    jadwal_keberangkatan, jadwal_kedatangan, harga from Keterangan_tiket
                               order by keterangan_tiket_id";
                using (OleDbCommand cmd = new OleDbCommand(sql, _conn))
                {
                    using (OleDbDataReader dtr = cmd.ExecuteReader())
                    {
                        while (dtr.Read())
                        {
                            KeteranganTiket keteranganTiket = new KeteranganTiket();
                            keteranganTiket.keterangan_tiket_id = dtr["keterangan_tiket_id"].ToString();
                            keteranganTiket.jenis_kereta = dtr["jenis_kereta"].ToString();
                            keteranganTiket.kelas = dtr["kelas"].ToString();
                            keteranganTiket.nama_kereta = dtr["nama_kereta"].ToString();
                            keteranganTiket.stasiun_asal = dtr["stasiun_asal"].ToString();
                            keteranganTiket.stasiun_tujuan = dtr["stasiun_tujuan"].ToString();
                            keteranganTiket.jadwal_keberangkatan = dtr["jadwal_keberangkatan"].ToString();
                            keteranganTiket.jadwal_kedatangan = dtr["jadwal_kedatangan"].ToString();
                            keteranganTiket.harga = int.Parse(dtr["harga"].ToString());

                            list.Add(keteranganTiket);
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
        public string ReadLastKey()
        {
            string key = "";
            try
            {
                string sql = @"SELECT TOP 1 * FROM keterangan_tiket ORDER BY keterangan_tiket_id DESC";
                using(OleDbCommand cmd = new OleDbCommand(sql, _conn))
                {
                    using(OleDbDataReader dtr= cmd.ExecuteReader())
                    {
                        dtr.Read();
                        key = dtr["keterangan_tiket_id"].ToString();
                    }
                }
            }
            catch(Exception ex)
            {
                System.Diagnostics.Debug.Print("ReadLastKey error: {0}", ex.Message);
            }
            return key;
        }
        public string ReadPrice(string asal, string tujuan, string kelas)
        {
            string price = "0";
            try
            {
                string sql = @"SELECT harga FROM keterangan_tiket where stasiun_asal = @asal and stasiun_tujuan = @tujuan and kelas = @kelas";
                using (OleDbCommand cmd = new OleDbCommand(sql, _conn))
                {
                    cmd.Parameters.AddWithValue("@asal", asal);
                    cmd.Parameters.AddWithValue("@tujuan", tujuan);
                    cmd.Parameters.AddWithValue("@kelas", kelas);
                    using (OleDbDataReader dtr = cmd.ExecuteReader())
                    {
                        while (dtr.Read())
                        {
                            price = dtr["harga"].ToString();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.Print("ReadPrice error: {0}", ex.Message);
            }
            return price;
        }

        public bool IsIDExist(string id)
        {
            bool result = false;

            string sql = @"select count(*) as row_count
                           from keterangan_tiket
                           where keterangan_tiket_id = @keterangan_tiket_id";

            using (OleDbCommand cmd = new OleDbCommand(sql, _conn))
            {
                cmd.Parameters.AddWithValue("@keterangan_tiket_id", id);

                using (OleDbDataReader dtr = cmd.ExecuteReader())
                {
                    if (dtr.Read())
                    {
                        result = Convert.ToInt32(dtr["row_count"]) > 0;
                    }
                }
            }

            return result;
        }
    }
}
