using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KasirTiketKereta.Model.Context
{
    class DbContext : IDisposable
    {
        private OleDbConnection _conn;

        public OleDbConnection Conn
        {
            get { return _conn ?? (_conn = GetOpenConnection()); }
        }

        private OleDbConnection GetOpenConnection()
        {
            OleDbConnection conn = null; 

            try 
            {
                string dbName = Directory.GetCurrentDirectory() + "\\Database\\DbKasirTiketKereta.mdb";
                string connectionString = string.Format("Provider=Microsoft.Jet.OLEDB.4.0;Data Source={0}", dbName);
                conn = new OleDbConnection(connectionString);
                conn.Open();
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.Print("Open Connection Error: {0}", ex.Message);
            }

            return conn;
        }

        // Method ini digunakan untuk menghapus objek koneksi dari memory ketika sudah tidak digunakan
        public void Dispose()
        {
            if (_conn != null)
            {
                try
                {
                    if (_conn.State != ConnectionState.Closed) _conn.Close();
                }
                finally
                {
                    _conn.Dispose();
                }
            }

            GC.SuppressFinalize(this);
        }
    }
}
