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
    public class PelangganController
    {
        private PelangganRepository _repository;
        public List<Pelanggan> ReadAll()
        {
            List<Pelanggan> list = new List<Pelanggan>();
            using (DbContext context = new DbContext())
            {
                _repository = new PelangganRepository(context);
                list = _repository.ReadAll();
            }

            return list;
        }
        public int Create(Pelanggan pelanggan)
        {
            int result = 0;

            if (string.IsNullOrEmpty(pelanggan.alamat_email))
            {
                MessageBox.Show("Alamat email harus diisi !!!", "Peringatan",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }

            if (string.IsNullOrEmpty(pelanggan.no_hp))
            {
                MessageBox.Show("no_hp harus diisi !!!", "Peringatan",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }


            if (string.IsNullOrEmpty(pelanggan.jenis_kelamin))
            {
                MessageBox.Show("jenis kelamin harus diisi !!!", "Peringatan",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }


            if (string.IsNullOrEmpty(pelanggan.nama))
            {
                MessageBox.Show("nama harus diisi !!!", "Peringatan",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }

            using (DbContext context = new DbContext())
            {
                _repository = new PelangganRepository(context);
                result = _repository.Create(pelanggan);
            }
            if (GlobalVariable.isReference)
            {
                if (result > 0)
                {
                    MessageBox.Show("Data pelanggan berhasil disimpan !", "Informasi",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                    MessageBox.Show("Data pelanggan gagal disimpan !!!", "Peringatan",
                            MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            return result;
        }
        public int Update(Pelanggan pelanggan)
        {
            int result = 0;
            if (string.IsNullOrEmpty(pelanggan.alamat_email))
            {
                MessageBox.Show("Alamat email harus diisi !!!", "Peringatan",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }

            if (string.IsNullOrEmpty(pelanggan.no_hp))
            {
                MessageBox.Show("no_hp harus diisi !!!", "Peringatan",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }


            if (string.IsNullOrEmpty(pelanggan.jenis_kelamin))
            {
                MessageBox.Show("jenis kelamin harus diisi !!!", "Peringatan",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }


            if (string.IsNullOrEmpty(pelanggan.nama))
            {
                MessageBox.Show("Nama harus diisi !!!", "Peringatan",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }
            if (string.IsNullOrEmpty(pelanggan.pelanggan_id))
            {
                MessageBox.Show("ID Pelanggan harus diisi !!!", "Peringatan",
                       MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }

            using (DbContext context = new DbContext())
            {
                _repository = new PelangganRepository(context);
                result = _repository.Update(pelanggan);
            }

            if (GlobalVariable.isReference)
            {
                if (result > 0)
                {
                    MessageBox.Show("Data pelanggan berhasil diupdate !", "Informasi",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                    MessageBox.Show("Data pelanggan gagal diupdate !!!", "Peringatan",
                            MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            return result;
        }
        public int Delete(Pelanggan pelanggan)
        {
            int result = 0;
            using (DbContext context = new DbContext())
            {
                _repository = new PelangganRepository(context);
                result = _repository.Delete(pelanggan);
            }

            if (GlobalVariable.isReference)
            {
                if (result > 0)
                {
                    MessageBox.Show("Data pelanggan berhasil didelete !", "Informasi",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                    MessageBox.Show("Data pelanggan gagal didelete !!!", "Peringatan",
                            MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
                return result;
        }

        public List<Pelanggan> ReadByField(string value, string field)
        {
            List<Pelanggan> list = new List<Pelanggan>();
            using (DbContext context = new DbContext())
            {
                _repository = new PelangganRepository(context);
                list = _repository.ReadByField(value, field);
            }
            return list;
        }
        public string ReadLastKey()
        {
            string key = "";
            using (DbContext context = new DbContext())
            {
                _repository = new PelangganRepository(context);
                key = _repository.ReadLastKey();
            }
            return key;
        }

        public bool IsIDExist(string id)
        {
            if (string.IsNullOrEmpty(id))
            {
                MessageBox.Show("ID pelanggan harus diisi !!!", "Peringatan",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }

            bool isValidUser = false;

            using (DbContext context = new DbContext())
            {
                _repository = new PelangganRepository(context);
                isValidUser = _repository.IsIDExist(id);
            }

            if (!isValidUser)
            {
                MessageBox.Show("ID Pelanggan tidak ada !!!", "Peringatan",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                return false;
            }

            return true;
        }
    }
}
