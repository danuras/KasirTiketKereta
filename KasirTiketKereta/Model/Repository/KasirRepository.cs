using KasirTiketKereta.Asset_Code;
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
    class KasirRepository
    {
        private OleDbConnection _conn;

        public KasirRepository(DbContext context)
        {
            _conn = context.Conn;
        }
        public bool IsValidUser(string userName, string password)
        {
            bool result = false;

            string sql = @"select count(*) as row_count
                           from kasir
                           where nama_kasir = @userName and password = @password";

            using (OleDbCommand cmd = new OleDbCommand(sql, _conn))
            {
                cmd.Parameters.AddWithValue("@userName", userName);
                cmd.Parameters.AddWithValue("@password", password);

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
        public int Create(Kasir kasir)
        {
            int result = 0;
            string sql = @"insert into kasir (nama_kasir, [password]) values (@nama_kasir, @password)";
            using (OleDbCommand cmd = new OleDbCommand(sql, _conn))
            {
                cmd.Parameters.AddWithValue("@nama_kasir", kasir.nama_kasir);
                cmd.Parameters.AddWithValue("@password", kasir.password);
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

        public int Update(Kasir kasir, string oldname)
        {
            int result = 0;
            string sql = @"update kasir set [password] = '" + kasir.password + "', nama_kasir = '"+kasir.nama_kasir+"' where nama_kasir = '" + oldname + "'";
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

        public int Delete(Kasir kasir)
        {
            int result = 0;
            string sql = @"delete from kasir
                           where nama_kasir = @nama_kasir";
            using (OleDbCommand cmd = new OleDbCommand(sql, _conn))
            {
                cmd.Parameters.AddWithValue("@nama_kasir", kasir.nama_kasir);
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
        public List<Kasir> ReadAll()
        {
            List<Kasir> list = new List<Kasir>();
            try
            {
                string sql = @"select nama_kasir, password from kasir where nama_kasir <> @value
                               order by nama_kasir";
                using (OleDbCommand cmd = new OleDbCommand(sql, _conn))
                {
                    cmd.Parameters.AddWithValue("@value", Properties.Settings.Default.admin);
                    using (OleDbDataReader dtr = cmd.ExecuteReader())
                    {
                        while (dtr.Read())
                        {
                            Kasir kasir = new Kasir();
                            kasir.nama_kasir = dtr["nama_kasir"].ToString();
                            kasir.password = dtr["password"].ToString();

                            list.Add(kasir);
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
        public string ReadPassword()
        {
            string key = "";
            try
            {
                string sql = @"SELECT [password] FROM kasir where nama_kasir = @value";
                using (OleDbCommand cmd = new OleDbCommand(sql, _conn))
                {
                    cmd.Parameters.AddWithValue("@value", GlobalVariable.nama);
                    using (OleDbDataReader dtr = cmd.ExecuteReader())
                    {
                        while (dtr.Read())
                        {
                            key = dtr["password"].ToString();
                        }
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
