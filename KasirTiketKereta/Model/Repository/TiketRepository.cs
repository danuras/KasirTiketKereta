using KasirTiketKereta.Asset_Code;
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
    class TiketRepository
    {
        private OleDbConnection _conn;
        public TiketRepository(DbContext dbContext)
        {
            _conn = dbContext.Conn;
        }
        public int Create(Tiket tiket)
        {
            int result = 0;
            string sql = (GlobalVariable.isReference)? 
                @"insert into tiket (tiket_id, nomor_kursi, pesanan_id, gerbong_id) values ('"+tiket.tiket_id+"', "+tiket.nomor_kursi+", '"+tiket.pesanan_id+"', '"+tiket.gerbong_id+"')" 
            : @"insert into tiket (tiket_id, nomor_kursi, gerbong_id) values (@tiket_id, @nomor_kursi, @gerbong_id)";
            using(OleDbCommand cmd = new OleDbCommand(sql, _conn))
            {
                if (!GlobalVariable.isReference)
                {
                    cmd.Parameters.AddWithValue("@tiket_id", tiket.tiket_id);
                    cmd.Parameters.AddWithValue("@nomor_kursi", tiket.nomor_kursi);
                    cmd.Parameters.AddWithValue("@gerbong_id", tiket.gerbong_id);
                    cmd.Parameters.AddWithValue("@pesanan_id", tiket.pesanan_id);
                }
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
        public int Update(Tiket tiket)
        {
            int result = 0;
            string sql = @"update tiket set nomor_kursi = "+ tiket.nomor_kursi + ", gerbong_id = '"+ tiket.gerbong_id + "', pesanan_id = '"+ tiket.pesanan_id + "' where tiket_id = '"+ tiket.tiket_id + "'";
            using (OleDbCommand cmd = new OleDbCommand(sql, _conn))
            {
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
        public int UpdatePesananID(string tiket_id, string pesanan_id)
        {
            int result = 0;
            string sql = @"update tiket set pesanan_id = @pesanan_id where tiket_id = @tiket_id and pesanan_id is null";
            using (OleDbCommand cmd = new OleDbCommand(sql, _conn))
            {
                cmd.Parameters.AddWithValue("@pesanan_id", pesanan_id);
                cmd.Parameters.AddWithValue("@tiket_id", tiket_id);
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
        public int Delete(Tiket tiket)
        {
            int result = 0;
            string sql = @"delete from tiket
                           where tiket_id = @tiket_id";
            using (OleDbCommand cmd = new OleDbCommand(sql, _conn))
            {
                cmd.Parameters.AddWithValue("@tiket_id", tiket.tiket_id);

                try
                {
                    result = cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    System.Diagnostics.Debug.Print("Delete error: {0}", ex.Message);
                }
            }
            return result;
        }
        public int DeleteByGerbong(string gerbong_id)
        {
            int result = 0;
            string sql = @"delete from tiket
                           where gerbong_id = @gerbong_id";
            using (OleDbCommand cmd = new OleDbCommand(sql, _conn))
            {
                cmd.Parameters.AddWithValue("@gerbong_id", gerbong_id);

                try
                {
                    result = cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    System.Diagnostics.Debug.Print("Delete error: {0}", ex.Message);
                }
            }
            return result;
        }
        public List<Tiket> ReadAll()
        {
            List<Tiket> list = new List<Tiket>();
            try
            {
                string sql = @"select tiket_id, nomor_kursi, pesanan_id, gerbong_id from tiket";
                using (OleDbCommand cmd = new OleDbCommand(sql, _conn))
                {
                    using (OleDbDataReader dtr = cmd.ExecuteReader())
                    {
                        while (dtr.Read())
                        {
                            Tiket tiket = new Tiket();
                            tiket.tiket_id = dtr["tiket_id"].ToString();
                            tiket.nomor_kursi = int.Parse(dtr["nomor_kursi"].ToString());
                            tiket.pesanan_id = dtr["pesanan_id"].ToString();
                            tiket.gerbong_id = dtr["gerbong_id"].ToString();

                            list.Add(tiket);
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
        public List<Tiket> ReadByField(string value, string field)
        {
            List<Tiket> list = new List<Tiket>();

            try
            {
                string sql = @"select * from tiket where "+field+" like @value order by tiket_id";

                using (OleDbCommand cmd = new OleDbCommand(sql, _conn))
                {
                    if (field != "nomor_kursi") { 
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
                            Tiket obj = new Tiket();
                            obj.tiket_id = dtr["tiket_id"].ToString();
                            obj.nomor_kursi = int.Parse(dtr["nomor_kursi"].ToString());
                            obj.pesanan_id = dtr["pesanan_id"].ToString();
                            obj.gerbong_id = dtr["gerbong_id"].ToString();

                            list.Add(obj);
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
        public string ReadTiketIDNull(string asal, string tujuan, string kelas)
        {
            string key = "";
            try
            {
                string sql = @"select TOP 1 tiket_id 
                                from (tiket inner join gerbong 
                                on tiket.gerbong_id = gerbong.gerbong_id)
                                 inner join keterangan_tiket
                                on keterangan_tiket.keterangan_tiket_id = gerbong.keterangan_tiket_id
                                where keterangan_tiket.stasiun_asal = @asal and keterangan_tiket.stasiun_tujuan = @tujuan 
                                and keterangan_tiket.kelas = @kelas and tiket.pesanan_id is null and keterangan_tiket.jadwal_keberangkatan > #"
                                + DateTime.Now.ToString("yyyy/MM/dd hh:mm:ss") + "#";
                using (OleDbCommand cmd = new OleDbCommand(sql, _conn))
                {
                    cmd.Parameters.AddWithValue("@asal", asal);
                    cmd.Parameters.AddWithValue("@tujuan", tujuan);
                    cmd.Parameters.AddWithValue("@kelas", kelas);
                    using (OleDbDataReader dtr = cmd.ExecuteReader())
                    {
                        while (dtr.Read())
                        {
                            key = dtr["tiket_id"].ToString();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.Print("ReadTiketIDNull error: {0}", ex.Message);
            }
            return key;
        }
        public int ReadNullPesananID(string asal, string tujuan, string kelas)
        {
            int result = 0;
            try
            {
                string sql = @"select count(*) as row_count
                                from (tiket inner join gerbong 
                                on tiket.gerbong_id = gerbong.gerbong_id)
                                 inner join keterangan_tiket
                                on keterangan_tiket.keterangan_tiket_id = gerbong.keterangan_tiket_id
                                where keterangan_tiket.stasiun_asal = @asal and keterangan_tiket.stasiun_tujuan = @tujuan 
                                and keterangan_tiket.kelas = @kelas and tiket.pesanan_id is null and keterangan_tiket.jadwal_keberangkatan > #" 
                                + DateTime.Now.ToString("yyyy/MM/dd hh:mm:ss") + "#";
                using (OleDbCommand cmd = new OleDbCommand(sql, _conn))
                {
                    cmd.Parameters.AddWithValue("@asal", asal);
                    cmd.Parameters.AddWithValue("@tujuan", tujuan);
                    cmd.Parameters.AddWithValue("@kelas", kelas);
                    using (OleDbDataReader dtr = cmd.ExecuteReader())
                    {
                        while (dtr.Read())
                        {
                            result = Convert.ToInt32(dtr["row_count"]);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.Print("ReadNullPesananID error: {0}", ex.Message);
            }
            return result;
        }
        public string ReadLastKey()
        {
            string key = "";
            try
            {
                string sql = @"SELECT TOP 1 * FROM tiket ORDER BY tiket_id DESC";
                using (OleDbCommand cmd = new OleDbCommand(sql, _conn))
                {
                    using (OleDbDataReader dtr = cmd.ExecuteReader())
                    {
                        dtr.Read();
                        key = dtr["tiket_id"].ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.Print("ReadLastKey error: {0}", ex.Message);
            }
            return key;
        }
    }
}
