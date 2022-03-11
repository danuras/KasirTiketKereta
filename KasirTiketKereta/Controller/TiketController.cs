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
    public class TiketController
    {
        private TiketRepository _repository;
        public int Create(Tiket tiket)
        {
            int result = 0;
            if (GlobalVariable.isReference)
            {
                if (string.IsNullOrEmpty(tiket.tiket_id))
                {
                    MessageBox.Show("Id tiket harus diisi !!!", "Peringatan",
                            MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return 0;
                }

                if (tiket.nomor_kursi == 0)
                {
                    MessageBox.Show("Nomor kursi harus diisi !!!", "Peringatan",
                            MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return 0;
                }

                if (string.IsNullOrEmpty(tiket.pesanan_id))
                {
                    MessageBox.Show("Id pesanan harus diisi !!!", "Peringatan",
                            MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return 0;
                }

                if (string.IsNullOrEmpty(tiket.gerbong_id))
                {
                    MessageBox.Show("Gerbong id harus diisi !!!", "Peringatan",
                            MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return 0;
                }
            }
            using (DbContext context = new DbContext())
            {
                _repository = new TiketRepository(context);
                result = _repository.Create(tiket);
            }
            if (GlobalVariable.isReference)
            {
                if (result > 0)
                {
                    MessageBox.Show("Data tiket berhasil disimpan !", "Informasi",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                    MessageBox.Show("Data tiket gagal disimpan !!!", "Peringatan",
                            MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            return result;
        }
        public int Update(Tiket tiket)
        {
            int result = 0;

            if (GlobalVariable.isReference)
            {
                if (string.IsNullOrEmpty(tiket.tiket_id))
                {
                    MessageBox.Show("Id tiket harus diisi !!!", "Peringatan",
                            MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return 0;
                }

                if (tiket.nomor_kursi == 0)
                {
                    MessageBox.Show("Nomor kursi harus diisi !!!", "Peringatan",
                            MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return 0;
                }

                if (string.IsNullOrEmpty(tiket.pesanan_id))
                {
                    MessageBox.Show("Id pesanan harus diisi !!!", "Peringatan",
                            MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return 0;
                }

                if (string.IsNullOrEmpty(tiket.gerbong_id))
                {
                    MessageBox.Show("ID Gerbong harus diisi !!!", "Peringatan",
                            MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return 0;
                }
            }
            using (DbContext context = new DbContext())
            {
                _repository = new TiketRepository(context);
                result = _repository.Update(tiket);
            }

            if (GlobalVariable.isReference)
            {
                if (result > 0)
                {
                    MessageBox.Show("Data tiket berhasil diupdate !", "Informasi",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                    MessageBox.Show("Data tiket gagal diupdate !!!", "Peringatan",
                            MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            return result;
        }
        public int UpdatePesananID(string tiket_id, string pesanan_id)
        {
            int result = 0;
            using (DbContext context = new DbContext())
            {
                _repository = new TiketRepository(context);
                result = _repository.UpdatePesananID(tiket_id, pesanan_id);
            }
            return result;
        }
        public int Delete(Tiket tiket)
        {
            int result = 0;
            if (string.IsNullOrEmpty(tiket.tiket_id))
            {
                MessageBox.Show("Tiket id harus diisi !!!", "Peringatan",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }
            using (DbContext context = new DbContext())
            {
                _repository = new TiketRepository(context);
                result = _repository.Delete(tiket);
            }

            if (GlobalVariable.isReference)
            {
                if (result > 0)
                {
                    MessageBox.Show("Data tiket berhasil dihapus !", "Informasi",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                    MessageBox.Show("Data tiket gagal dihapus !!!", "Peringatan",
                            MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            return result;
        }

        public int DeleteByGerbong(string gerbong_id)
        {
            int result = 0;
            using (DbContext context = new DbContext())
            {
                _repository = new TiketRepository(context);
                result = _repository.DeleteByGerbong(gerbong_id);
            }
            return result;
        }
        public string ReadTiketIDNull(string asal, string tujuan, string kelas)
        {
            string key = "";
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
                _repository = new TiketRepository(context);
                key = _repository.ReadTiketIDNull(asal, tujuan, kelas);
            }
            return key;
        }
        public int ReadNullPesananID(string asal, string tujuan, string kelas)
        {
            int result = 0;
            if (string.IsNullOrEmpty(asal))
            {
                MessageBox.Show("Stasiun asal harus diisi !!!", "Peringatan",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }

            if (string.IsNullOrEmpty(tujuan))
            {
                MessageBox.Show("Stasiun tujuan harus diisi !!!", "Peringatan",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }


            if (string.IsNullOrEmpty(kelas))
            {
                MessageBox.Show("Kelas kereta harus diisi !!!", "Peringatan",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }
            using (DbContext context = new DbContext())
            {
                _repository = new TiketRepository(context);
                result = _repository.ReadNullPesananID(asal, tujuan, kelas);
            }
            return result;
        }
        public List<Tiket> ReadAll()
        {
            List<Tiket> list = new List<Tiket>();
            using (DbContext context = new DbContext())
            {
                _repository = new TiketRepository(context);
                list = _repository.ReadAll();
            }
            return list;
        }
        public List<Tiket> ReadByField(string value, string field)
        {
            List<Tiket> list = new List<Tiket>();
            using (DbContext context = new DbContext())
            {
                _repository = new TiketRepository(context);
                list = _repository.ReadByField(value, field);
            }
            return list;
        }
        public string ReadLastKey()
        {
            string key = "";
            using (DbContext context = new DbContext())
            {
                _repository = new TiketRepository(context);
                key = _repository.ReadLastKey();
            }
            return key;
        }
    }
}
