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
    public class KeteranganTiketController
    {
        private KeteranganTiketRepository _repository;
        public int Create(KeteranganTiket keteranganTiket)
        {
            int result = 0;
            if (string.IsNullOrEmpty(keteranganTiket.keterangan_tiket_id))
            {
                MessageBox.Show("Keterangan Tiket ID harus diisi !!!", "Peringatan",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }
            if (string.IsNullOrEmpty(keteranganTiket.jenis_kereta))
            {
                MessageBox.Show("Jenis Kereta harus diisi !!!", "Peringatan",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }
            if (string.IsNullOrEmpty(keteranganTiket.kelas))
            {
                MessageBox.Show("Kelas harus diisi !!!", "Peringatan",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }
            if (string.IsNullOrEmpty(keteranganTiket.nama_kereta))
            {
                MessageBox.Show("Nama kereta harus diisi !!!", "Peringatan",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }
            if (string.IsNullOrEmpty(keteranganTiket.stasiun_asal))
            {
                MessageBox.Show("Stasiun asal harus diisi !!!", "Peringatan",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }
            if (string.IsNullOrEmpty(keteranganTiket.stasiun_tujuan))
            {
                MessageBox.Show("Stasiun tujuan harus diisi !!!", "Peringatan",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }
            if (string.IsNullOrEmpty(keteranganTiket.jadwal_keberangkatan))
            {
                MessageBox.Show("Jadwal keberangkatan harus diisi !!!", "Peringatan",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }
            if (string.IsNullOrEmpty(keteranganTiket.jadwal_kedatangan))
            {
                MessageBox.Show("Jadwal kedatangan harus diisi !!!", "Peringatan",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }
            if (keteranganTiket.harga == 0)
            {
                MessageBox.Show("Harga harus diisi !!!", "Peringatan",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }
            using (DbContext context = new DbContext())
            {
                _repository = new KeteranganTiketRepository(context);
                result = _repository.Create(keteranganTiket);
            }

            if (GlobalVariable.isReference)
            {
                if (result > 0)
                {
                    MessageBox.Show("Data keterangan tiket berhasil disimpan !", "Informasi",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                    MessageBox.Show("Data keterangan tiket gagal disimpan !!!", "Peringatan",
                            MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            return result;
        }
        public int Update(KeteranganTiket keteranganTiket)
        {
            int result = 0;
            if (string.IsNullOrEmpty(keteranganTiket.keterangan_tiket_id))
            {
                MessageBox.Show("Keterangan Tiket ID harus diisi !!!", "Peringatan",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }
            if (string.IsNullOrEmpty(keteranganTiket.jenis_kereta))
            {
                MessageBox.Show("Jenis Kereta harus diisi !!!", "Peringatan",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }
            if (string.IsNullOrEmpty(keteranganTiket.kelas))
            {
                MessageBox.Show("Kelas harus diisi !!!", "Peringatan",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }
            if (string.IsNullOrEmpty(keteranganTiket.nama_kereta))
            {
                MessageBox.Show("Nama kereta harus diisi !!!", "Peringatan",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }
            if (string.IsNullOrEmpty(keteranganTiket.stasiun_asal))
            {
                MessageBox.Show("Stasiun asal harus diisi !!!", "Peringatan",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }
            if (string.IsNullOrEmpty(keteranganTiket.stasiun_tujuan))
            {
                MessageBox.Show("Stasiun tujuan harus diisi !!!", "Peringatan",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }
            if (string.IsNullOrEmpty(keteranganTiket.jadwal_keberangkatan))
            {
                MessageBox.Show("Jadwal keberangkatan harus diisi !!!", "Peringatan",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }
            if (string.IsNullOrEmpty(keteranganTiket.jadwal_kedatangan))
            {
                MessageBox.Show("Jadwal kedatangan harus diisi !!!", "Peringatan",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }
            if (keteranganTiket.harga == 0)
            {
                MessageBox.Show("Harga harus diisi !!!", "Peringatan",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }
            using (DbContext context = new DbContext())
            {
                _repository = new KeteranganTiketRepository(context);
                result = _repository.Update(keteranganTiket);
            }

            if (GlobalVariable.isReference)
            {
                if (result > 0)
                {
                    MessageBox.Show("Data keterangan tiket berhasil diupdate !", "Informasi",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                    MessageBox.Show("Data keterangan tiket gagal diupdate !!!", "Peringatan",
                            MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            return result;
        }
        public int Delete(KeteranganTiket keteranganTiket)
        {
            int result = 0;
            if (string.IsNullOrEmpty(keteranganTiket.keterangan_tiket_id))
            {
                MessageBox.Show("Keterangan Tiket ID harus diisi !!!", "Peringatan",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }
            using (DbContext context = new DbContext())
            {
                _repository = new KeteranganTiketRepository(context);
                result = _repository.Delete(keteranganTiket);
            }

            if (GlobalVariable.isReference)
            {
                if (result > 0)
                {
                    MessageBox.Show("Data keterangan tiket berhasil didelete !", "Informasi",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                    MessageBox.Show("Data keterangan tiket gagal didelete !!!", "Peringatan",
                            MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            return result;
        }
        public List<KeteranganTiket> ReadAll()
        {
            List<KeteranganTiket> list = new List<KeteranganTiket>();
            using (DbContext context = new DbContext())
            {
                _repository = new KeteranganTiketRepository(context);
                list = _repository.ReadAll();
            }
            return list;
        }
        public List<KeteranganTiket> ReadByField(string value, string field)
        {
            List<KeteranganTiket> list = new List<KeteranganTiket>();
            using (DbContext context = new DbContext())
            {
                _repository = new KeteranganTiketRepository(context);
                list = _repository.ReadByField(value, field);
            }
            return list;
        }
        public string ReadLastKey()
        {
            string key = "";
            using (DbContext context = new DbContext())
            {
                _repository = new KeteranganTiketRepository(context);
                key = _repository.ReadLastKey();
            }
            return key;
        }
        public string ReadPrice(string asal, string tujuan, string kelas)
        {
            string price = "";
            if (string.IsNullOrEmpty(asal))
            {
                MessageBox.Show("Stasiun asal harus diisi !!!", "Peringatan",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return "";
            }

            if (string.IsNullOrEmpty(tujuan))
            {
                MessageBox.Show("Stasiun tujuan harus diisi !!!", "Peringatan",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return "";
            }


            if (string.IsNullOrEmpty(kelas))
            {
                MessageBox.Show("Kelas kereta harus diisi !!!", "Peringatan",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return "";
            }
            using (DbContext context = new DbContext())
            {
                _repository = new KeteranganTiketRepository(context);
                price = _repository.ReadPrice(asal, tujuan, kelas);
            }
            return price;
        }

        public bool IsIDExist(string id)
        {
            if (string.IsNullOrEmpty(id))
            {
                MessageBox.Show("ID Keterangan harus diisi !!!", "Peringatan",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }

            bool isValidUser = false;

            using (DbContext context = new DbContext())
            {
                _repository = new KeteranganTiketRepository(context);
                isValidUser = _repository.IsIDExist(id);
            }

            if (!isValidUser)
            {
                MessageBox.Show("ID Keterangan tidak ada !!!", "Peringatan",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                return false;
            }

            return true;
        }
    }
}
