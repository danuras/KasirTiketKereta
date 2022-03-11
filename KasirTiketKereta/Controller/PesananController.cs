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
    public class PesananController
    {
        private PesananRepository _repository;
        public List<Pesanan> ReadAll()
        {
            List<Pesanan> list = new List<Pesanan>();
            using (DbContext context = new DbContext())
            {
                _repository = new PesananRepository(context);
                list = _repository.ReadAll();
            }

            return list;
        }
        public List<Pesanan> ReadByField(string value, string field)
        {
            List<Pesanan> list = new List<Pesanan>();
            using (DbContext context = new DbContext())
            {
                _repository = new PesananRepository(context);
                list = _repository.ReadByField(value, field);
            }
            return list;
        }
        public int Create(Pesanan pesanan)
        {
            int result = 0;
            if (string.IsNullOrEmpty(pesanan.pesanan_id))
            {
                MessageBox.Show("Pesanan ID harus diisi !!!", "Peringatan",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }
            if (string.IsNullOrEmpty(pesanan.waktu_pemesanan))
            {
                MessageBox.Show("Waktu pemesanan harus diisi !!!", "Peringatan",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }
            if (string.IsNullOrEmpty(pesanan.metode_pembayaran))
            {
                MessageBox.Show("Metode pembayaran harus diisi !!!", "Peringatan",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }
            if (pesanan.jumlah_tiket_dipesan == 0)
            {
                MessageBox.Show("Jumlah tiket dipesan harus diisi !!!", "Peringatan",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }
            if (pesanan.total_bayar == 0)
            {
                MessageBox.Show("Total bayar harus diisi !!!", "Peringatan",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }
            if (string.IsNullOrEmpty(pesanan.pelanggan_id))
            {
                MessageBox.Show("ID pelanggan harus diisi !!!", "Peringatan",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }
            if (string.IsNullOrEmpty(pesanan.nama_kasir))
            {
                MessageBox.Show("Nama kasir harus diisi !!!", "Peringatan",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }
            using (DbContext context = new DbContext())
            {
                _repository = new PesananRepository(context);
                result = _repository.Create(pesanan);
            }
            if (GlobalVariable.isReference)
            {
                if (result > 0)
                {
                    MessageBox.Show("Data pesanan berhasil disimpan !", "Informasi",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                    MessageBox.Show("Data pesanan gagal disimpan !!!", "Peringatan",
                            MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            return result;
        }
        public int Update(Pesanan pesanan)
        {
            int result = 0;

            if (string.IsNullOrEmpty(pesanan.pesanan_id))
            {
                MessageBox.Show("Pesanan ID harus diisi !!!", "Peringatan",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }
            if (string.IsNullOrEmpty(pesanan.waktu_pemesanan))
            {
                MessageBox.Show("Waktu pemesanan harus diisi !!!", "Peringatan",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }
            if (string.IsNullOrEmpty(pesanan.metode_pembayaran))
            {
                MessageBox.Show("Metode pembayaran harus diisi !!!", "Peringatan",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }
            if (pesanan.jumlah_tiket_dipesan == 0)
            {
                MessageBox.Show("Jumlah tiket dipesan harus diisi !!!", "Peringatan",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }
            if (pesanan.total_bayar == 0)
            {
                MessageBox.Show("Total bayar harus diisi !!!", "Peringatan",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }
            if (string.IsNullOrEmpty(pesanan.pelanggan_id))
            {
                MessageBox.Show("ID pelanggan harus diisi !!!", "Peringatan",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }
            if (string.IsNullOrEmpty(pesanan.nama_kasir))
            {
                MessageBox.Show("Nama kasir harus diisi !!!", "Peringatan",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }
            using (DbContext context = new DbContext())
            {
                _repository = new PesananRepository(context);
                result = _repository.Update(pesanan);
            }
            if (GlobalVariable.isReference)
            {
                if (result > 0)
                {
                    MessageBox.Show("Data pesanan berhasil diupdate !", "Informasi",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                    MessageBox.Show("Data pesanan gagal diupdate !!!", "Peringatan",
                            MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            return result;
        }
        public int Delete(Pesanan pesanan)
        {
            int result = 0;
            if (string.IsNullOrEmpty(pesanan.pesanan_id))
            {
                MessageBox.Show("Pesanan ID harus diisi !!!", "Peringatan",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }
            using (DbContext context = new DbContext())
            {
                _repository = new PesananRepository(context);
                result = _repository.Delete(pesanan);
            }
            if (GlobalVariable.isReference)
            {
                if (result > 0)
                {
                    MessageBox.Show("Data pesanan berhasil didelete !", "Informasi",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                    MessageBox.Show("Data pesanan didelete !!!", "Peringatan",
                            MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            return result;
        }
        public string ReadLastKey()
        {
            string key = "";
            using (DbContext context = new DbContext())
            {
                _repository = new PesananRepository(context);
                key = _repository.ReadLastKey();
            }
            return key;
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
                _repository = new PesananRepository(context);
                isValidUser = _repository.IsIDExist(id);
            }

            if (!isValidUser)
            {
                MessageBox.Show("ID Pesanan tidak ada !!!", "Peringatan",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                return false;
            }

            return true;
        }
    }
}


