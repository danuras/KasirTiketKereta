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
    public class KasirController
    {
        private KasirRepository _repository;
        public bool IsValidUser(string userName, string password)
        {
            if (string.IsNullOrEmpty(userName))
            {
                MessageBox.Show("Nama harus diisi !!!", "Peringatan",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }

            if (string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Password harus diisi !!!", "Peringatan",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }

            bool isValidUser = false;

            using (DbContext context = new DbContext())
            {
                _repository = new KasirRepository(context);
                isValidUser = _repository.IsValidUser(userName, password);
            }

            if (!isValidUser)
            {
                MessageBox.Show("User name atau password salah !!!", "Peringatan",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                return false;
            }

            return true;
        }
        public int Create(Kasir kasir)
        {
            int result = 0;
            if (string.IsNullOrEmpty(kasir.nama_kasir))
            {
                MessageBox.Show("nama harus diisi !!!", "Peringatan",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }
            if (string.IsNullOrEmpty(kasir.password))
            {
                MessageBox.Show("Password harus diisi !!!", "Peringatan",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }
            using (DbContext context = new DbContext())
            {
                _repository = new KasirRepository(context);
                result = _repository.Create(kasir);
            }
            if (result > 0)
            {
                MessageBox.Show("Data Kasir berhasil disimpan !", "Informasi",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("Data Kasir gagal disimpan !!!", "Peringatan",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            return result;
        }
        public int Update(Kasir kasir, string oldname)
        {
            int result = 0;
            if (string.IsNullOrEmpty(kasir.nama_kasir))
            {
                MessageBox.Show("nama harus diisi !!!", "Peringatan",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }
            if (string.IsNullOrEmpty(kasir.password))
            {
                MessageBox.Show("Password harus diisi !!!", "Peringatan",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }
            using (DbContext context = new DbContext())
            {
                _repository = new KasirRepository(context);
                result = _repository.Update(kasir, oldname);
            }
            if (result > 0)
            {
                MessageBox.Show("Data kasir berhasil diupdate !", "Informasi",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("Data kasir gagal diupdate !!!", "Peringatan",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            return result;
        }
        public int Delete(Kasir kasir)
        {
            int result = 0;
            if (string.IsNullOrEmpty(kasir.nama_kasir))
            {
                MessageBox.Show("Nama harus diisi !!!", "Peringatan",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }
            using (DbContext context = new DbContext())
            {
                _repository = new KasirRepository(context);
                result = _repository.Delete(kasir);
            }
            if (result > 0)
            {
                MessageBox.Show("Data kasir berhasil didelete !", "Informasi",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("Data kasir didelete !!!", "Peringatan",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            return result;
        }
        public List<Kasir> ReadAll()
        {
            List<Kasir> list = new List<Kasir>();
            using (DbContext context = new DbContext())
            {
                _repository = new KasirRepository(context);
                list = _repository.ReadAll();
            }

            return list;
        }
        public string ReadPassword()
        {
            string key = "";
            using (DbContext context = new DbContext())
            {
                _repository = new KasirRepository(context);
                key = _repository.ReadPassword();
            }
            return key;
        }
    }
}
