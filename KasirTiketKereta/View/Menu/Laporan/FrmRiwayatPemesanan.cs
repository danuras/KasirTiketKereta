using KasirTiketKereta.Asset_Code;
using KasirTiketKereta.Controller;
using KasirTiketKereta.Model.Entity;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace KasirTiketKereta.View.Menu.Reference
{
    public partial class FrmRiwayatPemesanan : Form
    {
        private List<Model.Entity.RiwayatPemesanan> listOfObject = new List<Model.Entity.RiwayatPemesanan>();
        private RiwayatPemesananController controller;
        private int total, tiket;
        private string[] field = {"pelanggan.nama", "pesanan.waktu_pemesanan","keterangan_tiket.stasiun_asal", 
            "keterangan_tiket.stasiun_tujuan", "keterangan_tiket.kelas", "pesanan.jumlah_tiket_dipesan",
            "pesanan.total_bayar", "pesanan.nama_kasir" };
        public FrmRiwayatPemesanan()
        {
            InitializeComponent();
            this.SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            this.controller = new RiwayatPemesananController();
            InisialisasiListView();
            LoadData();
            cmbField.SelectedIndex = 0;
            this.BackColor = Color.FromArgb(0, 0, 0, 0);
            Tampilan();
        }

        private void Tampilan()
        {
            lblA.ForeColor = Tema.fcfc[GlobalVariable.id_tema];
            lblB.ForeColor = Tema.fcfc[GlobalVariable.id_tema];
            lvwReferences.BackColor = Tema.ol[GlobalVariable.id_tema];
            lvwReferences.ForeColor = Tema.ofl[GlobalVariable.id_tema];
        }

        private void InisialisasiListView()
        {
            lvwReferences.View = System.Windows.Forms.View.Details;
            lvwReferences.FullRowSelect = true;
            lvwReferences.GridLines = true;
            lvwReferences.Columns.Add("No.", 35, HorizontalAlignment.Center);
            lvwReferences.Columns.Add("Nama", 100, HorizontalAlignment.Center);
            lvwReferences.Columns.Add("Waktu Pesan", 100, HorizontalAlignment.Center);
            lvwReferences.Columns.Add("Stasiun Asal", 100, HorizontalAlignment.Center);
            lvwReferences.Columns.Add("Stasiun Tujuan", 100, HorizontalAlignment.Center);
            lvwReferences.Columns.Add("Kelas", 100, HorizontalAlignment.Center);
            lvwReferences.Columns.Add("Jumlah Pesan", 100, HorizontalAlignment.Center);
            lvwReferences.Columns.Add("Total Bayar", 100, HorizontalAlignment.Center);
            lvwReferences.Columns.Add("Kasir", 100, HorizontalAlignment.Center);
        }

        private void LoadData()
        {
            lvwReferences.Items.Clear();
            listOfObject = controller.ReadAll();
            total = 0; tiket = 0;
            foreach (var obj in listOfObject)
            {
                var noUrut = lvwReferences.Items.Count + 1;
                var item = new ListViewItem(noUrut.ToString());
                item.SubItems.Add(obj.nama);
                item.SubItems.Add(obj.waktu);
                item.SubItems.Add(obj.asal);
                item.SubItems.Add(obj.tujuan);
                item.SubItems.Add(obj.kelas);
                item.SubItems.Add(obj.jumlah);
                item.SubItems.Add(obj.total);
                item.SubItems.Add(obj.kasir);
                total += int.Parse(obj.total);
                tiket += int.Parse(obj.jumlah);

                lvwReferences.Items.Add(item);
            }
            txtTotal.Text = total.ToString();
            txtTiket.Text = tiket.ToString();
        }
        private void btnCari_Click(object sender, EventArgs e)
        {
            LoadDataByField();
        }

        private void btnSemua_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadDataByField()
        {
            lvwReferences.Items.Clear();
            listOfObject = controller.ReadByField(txtCari.Text, field[cmbField.SelectedIndex]);
            total = 0; tiket = 0;
            foreach (var obj in listOfObject)
            {
                var noUrut = lvwReferences.Items.Count + 1;
                var item = new ListViewItem(noUrut.ToString());
                item.SubItems.Add(obj.nama);
                item.SubItems.Add(obj.waktu);
                item.SubItems.Add(obj.asal);
                item.SubItems.Add(obj.tujuan);
                item.SubItems.Add(obj.kelas);
                item.SubItems.Add(obj.jumlah);
                item.SubItems.Add(obj.total);
                item.SubItems.Add(obj.kasir);
                total += int.Parse(obj.total);
                tiket += int.Parse(obj.jumlah);

                lvwReferences.Items.Add(item);
            }
            txtTotal.Text = total.ToString();
            txtTiket.Text = tiket.ToString();
        }
    }
}
