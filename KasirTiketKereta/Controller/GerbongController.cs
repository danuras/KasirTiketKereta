using KasirTiketKereta.Asset_Code;
using KasirTiketKereta.Model.Context;
using KasirTiketKereta.Model.Entity;
using KasirTiketKereta.Model.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KasirTiketKereta.Controller
{
    public class GerbongController
    {
        private GerbongRepository _repository;
        public List<Gerbong> ReadAll()
        { 
            List<Gerbong> list = new List<Gerbong>();
            using (DbContext context = new DbContext())
            { 
                _repository = new GerbongRepository(context);
                list = _repository.ReadAll();
            }

            return list;
        }
       
        public List<Gerbong> ReadByKT(string kt)
        {
            List<Gerbong> list = new List<Gerbong>();
            using (DbContext context = new DbContext())
            {
                _repository = new GerbongRepository(context);
                list = _repository.ReadByKT(kt);
            }

            return list;
        }
        public int Create(Gerbong gerbong)
        {
            int result = 0;
            if (string.IsNullOrEmpty(gerbong.gerbong_id))
            {
                MessageBox.Show("Gerbong id diisi !!!", "Peringatan",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }

            if (string.IsNullOrEmpty(gerbong.nama_gerbong))
            {
                MessageBox.Show("Nama gerbong harus diisi !!!", "Peringatan",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }

            if (string.IsNullOrEmpty(gerbong.keterangan_tiket_id))
            {
                MessageBox.Show("Keterangan tiket id harus diisi !!!", "Peringatan",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }
            using(DbContext context = new DbContext())
            {
                _repository = new GerbongRepository(context);
                result = _repository.Create(gerbong);
            }

            if (GlobalVariable.isReference)
            {
                if (result > 0)
                {
                    MessageBox.Show("Data gerbong berhasil disimpan !", "Informasi",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                    MessageBox.Show("Data gerbong gagal disimpan !!!", "Peringatan",
                            MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            return result;
        }
        public int Update(Gerbong gerbong)
        {
            int result = 0;
            if (string.IsNullOrEmpty(gerbong.gerbong_id))
            {
                MessageBox.Show("Gerbong id diisi !!!", "Peringatan",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }

            if (string.IsNullOrEmpty(gerbong.nama_gerbong))
            {
                MessageBox.Show("Nama gerbong harus diisi !!!", "Peringatan",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }

            using (DbContext context = new DbContext())
            {
                _repository = new GerbongRepository(context);
                result = _repository.Update(gerbong);
            }
            if (GlobalVariable.isReference)
            {
                if (result > 0)
                {
                    MessageBox.Show("Data gerbong berhasil diupdate !", "Informasi",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                    MessageBox.Show("Data gerbong gagal diupdate !!!", "Peringatan",
                            MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            return result;
        }
        public int Delete(Gerbong gerbong)
        {
            int result = 0;
            if (string.IsNullOrEmpty(gerbong.gerbong_id))
            {
                MessageBox.Show("Gerbong id diisi !!!", "Peringatan",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }
            using (DbContext context = new DbContext())
            {
                _repository = new GerbongRepository(context);
                result = _repository.Delete(gerbong);
            }
            if (GlobalVariable.isReference)
            {
                if (result > 0)
                {
                    MessageBox.Show("Data gerbong berhasil diupdate !", "Informasi",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                    MessageBox.Show("Data gerbong gagal diupdate !!!", "Peringatan",
                            MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            return result;
        }
        public string ReadLastKey()
        {
            string key = "";
            using (DbContext context = new DbContext())
            {
                _repository = new GerbongRepository(context);
                key = _repository.ReadLastKey();
            }
            return key;
        }

        public List<Gerbong> ReadByField(string value, string field)
        {
            List<Gerbong> list = new List<Gerbong>();
            using (DbContext context = new DbContext())
            {
                _repository = new GerbongRepository(context);
                list = _repository.ReadByField(value, field);
            }
            return list;
        }
        public bool IsIDExist(string id)
        {
            if (string.IsNullOrEmpty(id))
            {
                MessageBox.Show("ID pesanan harus diisi !!!", "Peringatan",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }

            bool isValidUser = false;

            using (DbContext context = new DbContext())
            {
                _repository = new GerbongRepository(context);
                isValidUser = _repository.IsIDExist(id);
            }

            if (!isValidUser)
            {
                MessageBox.Show("ID Gerbong tidak ada !!!", "Peringatan",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                return false;
            }

            return true;
        }
    }
}
