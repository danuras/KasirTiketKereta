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
    class PesananRepository
    {
        private OleDbConnection _conn;
        public PesananRepository(DbContext dbContext)
        {
            _conn = dbContext.Conn;
        }
        public int Create(Pesanan pesanan)
        {
            int result = 0;
            string sql = @"insert into pesanan 
                    (pesanan_id, waktu_pemesanan, metode_pembayaran, 
                    jumlah_tiket_dipesan, total_bayar, pelanggan_id,
                    nama_kasir)
                    values (@pesanan_id, @waktu_pemesanan, @metode_pembayaran, 
                    @jumlah_tiket_dipesan, @total_bayar, @pelanggan_id,
                    @nama_kasir)";
            using (OleDbCommand cmd = new OleDbCommand(sql, _conn))
            {
                cmd.Parameters.AddWithValue("@pesanan_id", pesanan.pesanan_id);
                cmd.Parameters.AddWithValue("@waktu_pemesanan", pesanan.waktu_pemesanan);
                cmd.Parameters.AddWithValue("@metode_pembayaran", pesanan.metode_pembayaran);
                cmd.Parameters.AddWithValue("@jumlah_tiket_dipesan", pesanan.jumlah_tiket_dipesan);
                cmd.Parameters.AddWithValue("@total_bayar", pesanan.total_bayar);
                cmd.Parameters.AddWithValue("@pelanggan_id", pesanan.pelanggan_id);
                cmd.Parameters.AddWithValue("@nama_kasir", pesanan.nama_kasir);

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
        public int Update(Pesanan pesanan)
        {
            int result = 0;
            string sql = @"update pesanan set
                    waktu_pemesanan = '"+pesanan.waktu_pemesanan+"', metode_pembayaran = '"+pesanan.metode_pembayaran+@"', 
                    jumlah_tiket_dipesan = "+pesanan.jumlah_tiket_dipesan.ToString()+@", total_bayar = "+pesanan.total_bayar.ToString()+@", 
                    pelanggan_id = '"+pesanan.pelanggan_id+@"', nama_kasir = '"+pesanan.nama_kasir+@"'
                    where 
                    pesanan_id = '"+pesanan.pesanan_id+"'";
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
        public int Delete(Pesanan pesanan)
        {
            int result = 0;
            string sql = @"delete from pesanan
                           where pesanan_id = @pesanan_id";
            using (OleDbCommand cmd = new OleDbCommand(sql, _conn))
            {
                cmd.Parameters.AddWithValue("@pesanan_id", pesanan.pesanan_id);
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

        public List<Pesanan> ReadByField(string value, string field)
        {
            List<Pesanan> list = new List<Pesanan>();

            try
            {
                string sql = @"select * from pesanan where " + field + " like @value order by pesanan_id";

                using (OleDbCommand cmd = new OleDbCommand(sql, _conn))
                {
                    if (field != "jumlah_tiket_dipesan" && field != "total_bayar")
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
                            Pesanan obj = new Pesanan();
                            obj.pesanan_id = dtr["pesanan_id"].ToString();
                            obj.waktu_pemesanan = dtr["waktu_pemesanan"].ToString();
                            obj.metode_pembayaran = dtr["metode_pembayaran"].ToString();
                            obj.jumlah_tiket_dipesan = int.Parse(dtr["jumlah_tiket_dipesan"].ToString());
                            obj.total_bayar = int.Parse(dtr["total_bayar"].ToString());
                            obj.pelanggan_id = dtr["pelanggan_id"].ToString();
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
        public List<Pesanan> ReadAll()
        {
            List<Pesanan> list = new List<Pesanan>();
            try
            {
                string sql = @"select pesanan_id, waktu_pemesanan, metode_pembayaran, 
                               jumlah_tiket_dipesan, total_bayar, pelanggan_id,
                               nama_kasir from pesanan
                               order by pesanan_id";
                using (OleDbCommand cmd = new OleDbCommand(sql, _conn))
                {
                    using (OleDbDataReader dtr = cmd.ExecuteReader())
                    {
                        while (dtr.Read())
                        {
                            Pesanan pesanan = new Pesanan();
                            pesanan.pesanan_id = dtr["pesanan_id"].ToString();
                            pesanan.waktu_pemesanan = dtr["waktu_pemesanan"].ToString();
                            pesanan.metode_pembayaran = dtr["metode_pembayaran"].ToString();
                            pesanan.jumlah_tiket_dipesan = int.Parse(dtr["jumlah_tiket_dipesan"].ToString());
                            pesanan.total_bayar = int.Parse(dtr["total_bayar"].ToString());
                            pesanan.pelanggan_id = dtr["pelanggan_id"].ToString();
                            pesanan.nama_kasir = dtr["nama_kasir"].ToString();

                            list.Add(pesanan);
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
                string sql = @"SELECT TOP 1 * FROM pesanan ORDER BY pesanan_id DESC";
                using (OleDbCommand cmd = new OleDbCommand(sql, _conn))
                {
                    using (OleDbDataReader dtr = cmd.ExecuteReader())
                    {
                        dtr.Read();
                        key = dtr["pesanan_id"].ToString();
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
                           from pesanan
                           where pesanan_id = @pesanan_id";

            using (OleDbCommand cmd = new OleDbCommand(sql, _conn))
            {
                cmd.Parameters.AddWithValue("@pesanan_id", id);

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
