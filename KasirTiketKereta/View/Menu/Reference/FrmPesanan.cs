using KasirTiketKereta.Asset_Code;
using KasirTiketKereta.Controller;
using KasirTiketKereta.Model.Entity;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace KasirTiketKereta.View.Menu.Reference
{
    public partial class FrmPesanan : Form
    {
        private List<Pesanan> listOfPesanan = new List<Pesanan>();
        private PesananController controller;
        private string[] field = {"pesanan_id","waktu_pemesanan","metode_pembayaran","jumlah_tiket_dipesan","total_bayar","pelanggan_id","nama_kasir" };
        public FrmPesanan()
        {
            InitializeComponent();
            this.SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            this.controller = new PesananController();
            InisialisasiListViewPesanan();
            LoadDataPesanan();
            this.BackColor = Color.FromArgb(0,0,0,0);
            cmbField.SelectedIndex = 0;
            Tampilan();
        }
        private void Tampilan()
        {
            lvwReferences.BackColor = Tema.ol[GlobalVariable.id_tema];
            lvwReferences.ForeColor = Tema.ofl[GlobalVariable.id_tema];
        }
        private void InisialisasiListViewPesanan()
        {
            lvwReferences.View = System.Windows.Forms.View.Details;
            lvwReferences.FullRowSelect = true;
            lvwReferences.GridLines = true;
            lvwReferences.Columns.Add("No.", 35, HorizontalAlignment.Center);
            lvwReferences.Columns.Add("ID Pesanan", 100, HorizontalAlignment.Center);
            lvwReferences.Columns.Add("Waktu Pemesanan", 100, HorizontalAlignment.Center);
            lvwReferences.Columns.Add("Metode Bayar", 100, HorizontalAlignment.Center);
            lvwReferences.Columns.Add("Jumlah Pesanan", 100, HorizontalAlignment.Center);
            lvwReferences.Columns.Add("Total Bayar", 100, HorizontalAlignment.Center);
            lvwReferences.Columns.Add("ID Pelanggan", 100, HorizontalAlignment.Center);
            lvwReferences.Columns.Add("Nama Kasir", 100, HorizontalAlignment.Center);
        }

        private void LoadDataPesanan()
        {
            lvwReferences.Items.Clear();
            listOfPesanan = controller.ReadAll();
            foreach (var obj in listOfPesanan)
            {
                var noUrut = lvwReferences.Items.Count + 1;
                var item = new ListViewItem(noUrut.ToString());
                item.SubItems.Add(obj.pesanan_id);
                item.SubItems.Add(obj.waktu_pemesanan);
                item.SubItems.Add(obj.metode_pembayaran);
                item.SubItems.Add(obj.jumlah_tiket_dipesan.ToString());
                item.SubItems.Add(obj.total_bayar.ToString());
                item.SubItems.Add(obj.pelanggan_id);
                item.SubItems.Add(obj.nama_kasir);

                lvwReferences.Items.Add(item);
            }
        }


        private void OnCreateEventHandlerPesanan(Pesanan obj)
        {
            listOfPesanan.Add(obj);
            int noUrut = lvwReferences.Items.Count + 1;
            ListViewItem item = new ListViewItem(noUrut.ToString());
            item.SubItems.Add(obj.pesanan_id);
            item.SubItems.Add(obj.waktu_pemesanan);
            item.SubItems.Add(obj.metode_pembayaran);
            item.SubItems.Add(obj.jumlah_tiket_dipesan.ToString());
            item.SubItems.Add(obj.total_bayar.ToString());
            item.SubItems.Add(obj.pelanggan_id);
            item.SubItems.Add(obj.nama_kasir);
            lvwReferences.Items.Add(item);
        }
        private void OnUpdateEventHandlerPesanan(Pesanan obj)
        {
            int index = lvwReferences.SelectedIndices[0];
            ListViewItem itemRow = lvwReferences.Items[index];
            itemRow.SubItems[1].Text = obj.pesanan_id;
            itemRow.SubItems[2].Text = obj.waktu_pemesanan;
            itemRow.SubItems[3].Text = obj.metode_pembayaran;
            itemRow.SubItems[4].Text = obj.jumlah_tiket_dipesan.ToString();
            itemRow.SubItems[5].Text = obj.total_bayar.ToString();
            itemRow.SubItems[6].Text = obj.pelanggan_id.ToString();
            itemRow.SubItems[7].Text = obj.nama_kasir.ToString();
        }

        private void btnTambah_Click(object sender, EventArgs e)
        {
            FrmEntryPesanan frmEntryPesanan = new FrmEntryPesanan("Tambah Data Pesanan", controller);
            frmEntryPesanan.OnCreate += OnCreateEventHandlerPesanan;
            frmEntryPesanan.ShowDialog();
        }

        private void btnHapus_Click(object sender, EventArgs e)
        {
            if (lvwReferences.SelectedItems.Count > 0)
            {
                var konfirmasi = MessageBox.Show("Apakah data pesanan ingin dihapus?", "Konfirmasi",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

                if (konfirmasi == DialogResult.Yes)
                {
                    Pesanan pesanan = listOfPesanan[lvwReferences.SelectedIndices[0]];
                    var result = controller.Delete(pesanan);
                    if (result > 0) LoadDataPesanan();
                }
            }
            else 
            {
                MessageBox.Show("Data pesanan belum dipilih !!!", "Peringatan",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnPerbaiki_Click(object sender, EventArgs e)
        {
            if (lvwReferences.SelectedItems.Count > 0)
            {
                Pesanan pesanan = listOfPesanan[lvwReferences.SelectedIndices[0]];
                FrmEntryPesanan frmEntry = new FrmEntryPesanan("Edit Data Pesanan", controller, pesanan);
                frmEntry.OnUpdate += OnUpdateEventHandlerPesanan;
                frmEntry.ShowDialog();
            }
            else
            {
                MessageBox.Show("Data pesanan belum dipilih", "Peringatan",
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnCari_Click(object sender, EventArgs e)
        {
            lvwReferences.Items.Clear();
            listOfPesanan = controller.ReadByField(txtCari.Text, field[cmbField.SelectedIndex]);
            foreach (var obj in listOfPesanan)
            {
                var noUrut = lvwReferences.Items.Count + 1;
                var item = new ListViewItem(noUrut.ToString());
                item.SubItems.Add(obj.pesanan_id);
                item.SubItems.Add(obj.waktu_pemesanan);
                item.SubItems.Add(obj.metode_pembayaran);
                item.SubItems.Add(obj.jumlah_tiket_dipesan.ToString());
                item.SubItems.Add(obj.total_bayar.ToString());
                item.SubItems.Add(obj.pelanggan_id);
                item.SubItems.Add(obj.nama_kasir);

                lvwReferences.Items.Add(item);
            }
        }

        private void btnSemua_Click(object sender, EventArgs e)
        {
            LoadDataPesanan();
        }
    }
}
