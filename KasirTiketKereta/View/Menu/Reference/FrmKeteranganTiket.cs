using KasirTiketKereta.Asset_Code;
using KasirTiketKereta.Controller;
using KasirTiketKereta.Model.Entity;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace KasirTiketKereta.View.Menu.Reference
{
    public partial class FrmKeteranganTiket : Form
    {
        private List<KeteranganTiket> listOfKeteranganTiket = new List<KeteranganTiket>();
        private KeteranganTiketController controller;
        private string[] field = { "keterangan_tiket_id", "jenis_kereta", "kelas", "nama_kereta", "stasiun_asal", "stasiun_tujuan", "jadwal_keberangkatan", "jadwal_kedatangan", "harga" };
        public FrmKeteranganTiket()
        {
            InitializeComponent();
            this.SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            this.controller = new KeteranganTiketController();
            InisialisasiListViewTiket();
            LoadDataKeteranganTiket();
            cmbField.SelectedIndex = 0;
            this.BackColor = Color.FromArgb(0,0,0,0) ;
            Tampilan();
        }
        private void Tampilan()
        {
            lvwReferences.BackColor = Tema.ol[GlobalVariable.id_tema];
            lvwReferences.ForeColor = Tema.ofl[GlobalVariable.id_tema];
        }
        private void InisialisasiListViewTiket()
        {
            lvwReferences.View = System.Windows.Forms.View.Details;
            lvwReferences.FullRowSelect = true;
            lvwReferences.GridLines = true;
            lvwReferences.Columns.Add("No.", 35, HorizontalAlignment.Center);
            lvwReferences.Columns.Add("ID Keterangan Tiket", 100, HorizontalAlignment.Center);
            lvwReferences.Columns.Add("Jenis Kereta", 100, HorizontalAlignment.Center);
            lvwReferences.Columns.Add("Kelas", 100, HorizontalAlignment.Center);
            lvwReferences.Columns.Add("Nama Kereta", 100, HorizontalAlignment.Center);
            lvwReferences.Columns.Add("Stasiun Asal", 100, HorizontalAlignment.Center);
            lvwReferences.Columns.Add("Stasiun Tujuan", 100, HorizontalAlignment.Center);
            lvwReferences.Columns.Add("Jadwal Keberangkatan", 100, HorizontalAlignment.Center);
            lvwReferences.Columns.Add("Jadwal Kedatangan", 100, HorizontalAlignment.Center);
            lvwReferences.Columns.Add("Harga", 100, HorizontalAlignment.Center);
        }

        private void LoadDataKeteranganTiket()
        {
            lvwReferences.Items.Clear();
            listOfKeteranganTiket = controller.ReadAll();
            foreach (var obj in listOfKeteranganTiket)
            {
                var noUrut = lvwReferences.Items.Count + 1;
                var item = new ListViewItem(noUrut.ToString());
                item.SubItems.Add(obj.keterangan_tiket_id);
                item.SubItems.Add(obj.jenis_kereta);
                item.SubItems.Add(obj.kelas);
                item.SubItems.Add(obj.nama_kereta);
                item.SubItems.Add(obj.stasiun_asal);
                item.SubItems.Add(obj.stasiun_tujuan);
                item.SubItems.Add(obj.jadwal_keberangkatan);
                item.SubItems.Add(obj.jadwal_kedatangan);
                item.SubItems.Add(obj.harga.ToString());

                lvwReferences.Items.Add(item);
            }
        }


        private void OnCreateEventHandler(KeteranganTiket obj)
        {
            listOfKeteranganTiket.Add(obj);
            int noUrut = lvwReferences.Items.Count + 1;
            ListViewItem item = new ListViewItem(noUrut.ToString());
            item.SubItems.Add(obj.keterangan_tiket_id);
            item.SubItems.Add(obj.jenis_kereta);
            item.SubItems.Add(obj.kelas);
            item.SubItems.Add(obj.nama_kereta);
            item.SubItems.Add(obj.stasiun_asal);
            item.SubItems.Add(obj.stasiun_tujuan);
            item.SubItems.Add(obj.jadwal_keberangkatan);
            item.SubItems.Add(obj.jadwal_kedatangan);
            item.SubItems.Add(obj.harga.ToString());
            lvwReferences.Items.Add(item);
        }
        private void OnUpdateEventHandler(KeteranganTiket keteranganTiket)
        {
            int index = lvwReferences.SelectedIndices[0];
            ListViewItem itemRow = lvwReferences.Items[index];
            itemRow.SubItems[1].Text = keteranganTiket.keterangan_tiket_id;
            itemRow.SubItems[2].Text = keteranganTiket.jenis_kereta;
            itemRow.SubItems[3].Text = keteranganTiket.kelas;
            itemRow.SubItems[4].Text = keteranganTiket.nama_kereta;
            itemRow.SubItems[5].Text = keteranganTiket.stasiun_asal;
            itemRow.SubItems[6].Text = keteranganTiket.stasiun_tujuan;
            itemRow.SubItems[7].Text = keteranganTiket.jadwal_keberangkatan;
            itemRow.SubItems[8].Text = keteranganTiket.jadwal_kedatangan;
            itemRow.SubItems[9].Text = keteranganTiket.harga.ToString();
        }

        private void btnTambah_Click(object sender, EventArgs e)
        {
            FrmEntryKeteranganTiket frmEntryKeteranganTiket = new FrmEntryKeteranganTiket("Tambah Data Keterangan Tiket", controller);
            frmEntryKeteranganTiket.OnCreate += OnCreateEventHandler;
            frmEntryKeteranganTiket.ShowDialog();
        }

        private void btnHapus_Click(object sender, EventArgs e)
        {
            if (lvwReferences.SelectedItems.Count > 0)
            {
                var konfirmasi = MessageBox.Show("Apakah data keterangan tiket ingin dihapus?", "Konfirmasi",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

                if (konfirmasi == DialogResult.Yes)
                {
                    KeteranganTiket keteranganTiket = listOfKeteranganTiket[lvwReferences.SelectedIndices[0]];
                    var result = controller.Delete(keteranganTiket);
                    if (result > 0) LoadDataKeteranganTiket();
                }
            }
            else 
            {
                MessageBox.Show("Data keterangan tiket belum dipilih !!!", "Peringatan",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnPerbaiki_Click(object sender, EventArgs e)
        {
            if (lvwReferences.SelectedItems.Count > 0)
            {
                KeteranganTiket keteranganTiket = listOfKeteranganTiket[lvwReferences.SelectedIndices[0]];
                FrmEntryKeteranganTiket frmEntry = new FrmEntryKeteranganTiket("Edit Data Keterangan Tiket", controller, keteranganTiket);
                frmEntry.OnUpdate += OnUpdateEventHandler;
                frmEntry.ShowDialog();
            }
            else
            {
                MessageBox.Show("Data keterangan tiket belum dipilih", "Peringatan",
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }


        private void btnCari_Click(object sender, EventArgs e)
        {
            lvwReferences.Items.Clear();
            listOfKeteranganTiket = controller.ReadByField(txtCari.Text, field[cmbField.SelectedIndex]);
            foreach (var obj in listOfKeteranganTiket)
            {
                var noUrut = lvwReferences.Items.Count + 1;
                var item = new ListViewItem(noUrut.ToString());
                item.SubItems.Add(obj.keterangan_tiket_id);
                item.SubItems.Add(obj.jenis_kereta);
                item.SubItems.Add(obj.kelas);
                item.SubItems.Add(obj.nama_kereta);
                item.SubItems.Add(obj.stasiun_asal);
                item.SubItems.Add(obj.stasiun_tujuan);
                item.SubItems.Add(obj.jadwal_keberangkatan);
                item.SubItems.Add(obj.jadwal_kedatangan);
                item.SubItems.Add(obj.harga.ToString());

                lvwReferences.Items.Add(item);
            }
        }

        private void btnSemua_Click(object sender, EventArgs e)
        {
            LoadDataKeteranganTiket();
        }
    }
}
