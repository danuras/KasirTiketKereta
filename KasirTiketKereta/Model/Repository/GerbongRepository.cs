using KasirTiketKereta.Model.Context;
using KasirTiketKereta.Model.Entity;
using System;
using System.Collections.Generic;
using System.Data.OleDb;

namespace KasirTiketKereta.Model.Repository
{
    class GerbongRepository
    {
        private OleDbConnection _conn;

        public GerbongRepository(DbContext context)
        {
            _conn = context.Conn;
        }

        public int Create(Gerbong gerbong)
        {
            int result = 0;
            string sql = @"insert into gerbong (gerbong_id, nama_gerbong, jumlah_kursi, keterangan_tiket_id)
                           values (@gerbong_id, @nama_gerbong, @jumlah_kursi, @keterangan_tiket_id)";
            using (OleDbCommand cmd = new OleDbCommand(sql, _conn))
            {
                cmd.Parameters.AddWithValue("@gerbong_id", gerbong.gerbong_id);
                cmd.Parameters.AddWithValue("@nama_gerbong", gerbong.nama_gerbong);
                cmd.Parameters.AddWithValue("@jumlah_kursi", gerbong.jumlah_kursi);
                cmd.Parameters.AddWithValue("@keterangan_tiket_id", gerbong.keterangan_tiket_id);
                try
                {
                    result = cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    System.Diagnostics.Debug.Print("Create error: {0}", ex.Message);
                }
            }

            return result;
        }

        public int Update(Gerbong gerbong)
        {
            int result = 0;
            string sql = @"update gerbong set nama_gerbong = '"+ gerbong.nama_gerbong+"', jumlah_kursi = "+gerbong.jumlah_kursi.ToString()+ " where gerbong_id = '"+gerbong.gerbong_id+"'";
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

        public int Delete(Gerbong gerbong)
        {
            int result = 0;
            string sql = @"delete from gerbong
                           where gerbong_id = @gerbong_id";
            using (OleDbCommand cmd = new OleDbCommand(sql, _conn))
            {
                cmd.Parameters.AddWithValue("@gerbong_id", gerbong.gerbong_id);
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
        public List<Gerbong> ReadAll()
        {
            List<Gerbong> list = new List<Gerbong>();
            try
            {
                string sql = @"select gerbong_id, nama_gerbong, keterangan_tiket_id, jumlah_kursi from gerbong
                               order by nama_gerbong";
                using (OleDbCommand cmd = new OleDbCommand(sql, _conn))
                {
                    using (OleDbDataReader dtr = cmd.ExecuteReader())
                    {
                        while (dtr.Read())
                        {
                            Gerbong gerbong = new Gerbong();
                            gerbong.gerbong_id = dtr["gerbong_id"].ToString();
                            gerbong.nama_gerbong = dtr["nama_gerbong"].ToString();
                            gerbong.keterangan_tiket_id = dtr["keterangan_tiket_id"].ToString();
                            gerbong.jumlah_kursi = int.Parse(dtr["jumlah_kursi"].ToString());

                            list.Add(gerbong);
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
        public List<Gerbong> ReadByField(string value, string field)
        {
            List<Gerbong> list = new List<Gerbong>();

            try
            {
                string sql = @"select * from gerbong where " + field + " like @value order by gerbong_id";

                using (OleDbCommand cmd = new OleDbCommand(sql, _conn))
                {
                    if (field != "jumlah_kursi")
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
                            Gerbong gerbong = new Gerbong();
                            gerbong.gerbong_id = dtr["gerbong_id"].ToString();
                            gerbong.nama_gerbong = dtr["nama_gerbong"].ToString();
                            gerbong.keterangan_tiket_id = dtr["keterangan_tiket_id"].ToString();
                            gerbong.jumlah_kursi = int.Parse(dtr["jumlah_kursi"].ToString());

                            list.Add(gerbong);
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
        public List<Gerbong> ReadByKT(string kt)
        {
            List<Gerbong> list = new List<Gerbong>();
            try
            {
                string sql = @"select gerbong_id, nama_gerbong, jumlah_kursi from gerbong
                               where keterangan_tiket_id = @keterangan_tiket_id";
                using (OleDbCommand cmd = new OleDbCommand(sql, _conn))
                {
                    cmd.Parameters.AddWithValue("@keterangan_tiket_id", kt);
                    using (OleDbDataReader dtr = cmd.ExecuteReader())
                    {
                        while (dtr.Read())
                        {
                            Gerbong gerbong = new Gerbong();
                            gerbong.gerbong_id = dtr["gerbong_id"].ToString();
                            gerbong.nama_gerbong = dtr["nama_gerbong"].ToString();
                            gerbong.jumlah_kursi = int.Parse(dtr["jumlah_kursi"].ToString());

                            list.Add(gerbong);
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
                string sql = @"SELECT TOP 1 * FROM gerbong ORDER BY gerbong_id DESC";
                using (OleDbCommand cmd = new OleDbCommand(sql, _conn))
                {
                    using (OleDbDataReader dtr = cmd.ExecuteReader())
                    {
                        dtr.Read();
                        key = dtr["gerbong_id"].ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.Print("ReadLastKey error: {0}", ex.Message);
            }
            return key;
        }

        public bool IsIDExist(string id)
        {
            bool result = false;

            string sql = @"select count(*) as row_count
                           from gerbong
                           where gerbong_id = @id";

            using (OleDbCommand cmd = new OleDbCommand(sql, _conn))
            {
                cmd.Parameters.AddWithValue("@id", id);

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
