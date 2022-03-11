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
    class PelangganRepository
    {
        private OleDbConnection _conn;
        public PelangganRepository(DbContext dbContext)
        {
            _conn = dbContext.Conn;
        }
        public int Create(Pelanggan pelanggan)
        {
            int result = 0;
            string sql = @"insert into pelanggan (pelanggan_id, alamat_email, no_hp, jenis_kelamin, nama_kasir, nama)
                           values (@pelanggan_id, @alamat_email, @no_hp, @jenis_kelamin, @nama_kasir, @nama)";
            using (OleDbCommand cmd = new OleDbCommand(sql, _conn))
            {
                cmd.Parameters.AddWithValue("@pelanggan_id", pelanggan.pelanggan_id);
                cmd.Parameters.AddWithValue("@alamat_email", pelanggan.alamat_email);
                cmd.Parameters.AddWithValue("@no_hp", pelanggan.no_hp);
                cmd.Parameters.AddWithValue("@jenis_kelamin", pelanggan.jenis_kelamin);
                cmd.Parameters.AddWithValue("@nama_kasir", pelanggan.nama_kasir);
                cmd.Parameters.AddWithValue("@nama", pelanggan.nama);
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
        public int Update(Pelanggan pelanggan)
        {
            int result = 0;
            string sql = @"update pelanggan set alamat_email = '"+pelanggan.alamat_email+@"', no_hp = '"+pelanggan.no_hp+@"', 
                           jenis_kelamin = '"+pelanggan.jenis_kelamin+@"', nama_kasir = '"+pelanggan.nama_kasir+@"', nama = '"+pelanggan.nama+@"'
                           where pelanggan_id = '"+pelanggan.pelanggan_id+@"'";
            using (OleDbCommand cmd = new OleDbCommand(sql, _conn))
            {
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
        public int Delete(Pelanggan pelanggan)
        {
            int result = 0;
            string sql = @"delete from pelanggan 
                           where pelanggan_id = @pelanggan_id";
            using (OleDbCommand cmd = new OleDbCommand(sql, _conn))
            {
                cmd.Parameters.AddWithValue("@pelanggan_id", pelanggan.pelanggan_id);
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

        public List<Pelanggan> ReadByField(string value, string field)
        {
            List<Pelanggan> list = new List<Pelanggan>();

            try
            {
                string sql = @"select * from pelanggan where " + field + " like @value order by pelanggan_id";

                using (OleDbCommand cmd = new OleDbCommand(sql, _conn))
                {
                    cmd.Parameters.AddWithValue("@value", "%" + value + "%");


                    using (OleDbDataReader dtr = cmd.ExecuteReader())
                    {
                        while (dtr.Read())
                        {
                            Pelanggan obj = new Pelanggan();
                            obj.pelanggan_id = dtr["pelanggan_id"].ToString();
                            obj.alamat_email = dtr["alamat_email"].ToString();
                            obj.no_hp = dtr["no_hp"].ToString();
                            obj.jenis_kelamin = dtr["jenis_kelamin"].ToString();
                            obj.nama = dtr["nama"].ToString();
                            obj.nama_kasir = dtr["nama_kasir"].ToString();

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
        public List<Pelanggan> ReadAll()
        {
            List<Pelanggan> list = new List<Pelanggan>();
            try
            {
                string sql = @"select pelanggan_id, alamat_email, no_hp, jenis_kelamin,
                               nama_kasir, nama from pelanggan
                               order by nama";
                using (OleDbCommand cmd = new OleDbCommand(sql, _conn))
                {
                    using (OleDbDataReader dtr = cmd.ExecuteReader())
                    {
                        while (dtr.Read())
                        {
                            Pelanggan pelanggan = new Pelanggan();
                            pelanggan.pelanggan_id = dtr["pelanggan_id"].ToString();
                            pelanggan.alamat_email = dtr["alamat_email"].ToString();
                            pelanggan.no_hp = dtr["no_hp"].ToString();
                            pelanggan.jenis_kelamin = dtr["jenis_kelamin"].ToString();
                            pelanggan.nama_kasir = dtr["nama_kasir"].ToString();
                            pelanggan.nama = dtr["nama"].ToString();

                            list.Add(pelanggan);
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
                string sql = @"SELECT TOP 1 * FROM pelanggan ORDER BY pelanggan_id DESC";
                using (OleDbCommand cmd = new OleDbCommand(sql, _conn))
                {
                    using (OleDbDataReader dtr = cmd.ExecuteReader())
                    {
                        dtr.Read();
                        key = dtr["pelanggan_id"].ToString();
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
                           from pelanggan
                           where pelanggan_id = @pelanggan_id";

            using (OleDbCommand cmd = new OleDbCommand(sql, _conn))
            {
                cmd.Parameters.AddWithValue("@pelanggan_id", id);

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
