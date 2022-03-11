using KasirTiketKereta.Asset_Code;
using KasirTiketKereta.Controller;
using KasirTiketKereta.Model.Entity;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace KasirTiketKereta.View.Menu.Reference
{
    public partial class FrmLaporanPenjualan : Form
    {
        private List<LaporanPenjualan> listOfObject = new List<LaporanPenjualan>();
        private LaporanPenjualanController controller;
        private int total = 0, jumlah = 0, tersedia = 0, tidak_terjual = 0, terjual = 0;
        private string[] field = {"keterangan_tiket.kelas", "keterangan_tiket.stasiun_asal","keterangan_tiket.stasiun_tujuan",

                            "count(keterangan_tiket.kelas and keterangan_tiket.stasiun_asal and keterangan_tiket.stasiun_tujuan)", 

                            @"(select count(*) from (tiket a inner join gerbong b ON b.gerbong_id = a.gerbong_id)
                            inner join keterangan_tiket c on c.keterangan_tiket_id = b.keterangan_tiket_id
                            where a.pesanan_id is null and c.kelas = keterangan_tiket.kelas and c.stasiun_asal = keterangan_tiket.stasiun_asal
                            and c.stasiun_tujuan = keterangan_tiket.stasiun_tujuan and c.jadwal_keberangkatan > #" + DateTime.Now.ToString("yyyy/MM/dd hh:mm:ss") + @"#)",

                            @"(select count(*) from (tiket a inner join gerbong b ON b.gerbong_id = a.gerbong_id) 
                            inner join keterangan_tiket c on c.keterangan_tiket_id = b.keterangan_tiket_id 
                            where a.pesanan_id is null and c.kelas = keterangan_tiket.kelas and c.stasiun_asal = keterangan_tiket.stasiun_asal 
                            and c.stasiun_tujuan = keterangan_tiket.stasiun_tujuan  and c.jadwal_keberangkatan <= #" + DateTime.Now.ToString("yyyy/MM/dd hh:mm:ss") + @"#)",

                            @"(select count(*) from (tiket a inner join gerbong b ON b.gerbong_id = a.gerbong_id) 
                            inner join keterangan_tiket c on c.keterangan_tiket_id = b.keterangan_tiket_id
                            where a.pesanan_id is not null and c.kelas = keterangan_tiket.kelas and c.stasiun_asal = keterangan_tiket.stasiun_asal
                            and c.stasiun_tujuan = keterangan_tiket.stasiun_tujuan)",

                            @"(select sum(c.harga) from (tiket a inner join gerbong b ON b.gerbong_id = a.gerbong_id) 
                            inner join keterangan_tiket c on c.keterangan_tiket_id = b.keterangan_tiket_id 
                            where a.pesanan_id is not null and c.kelas = keterangan_tiket.kelas and c.stasiun_asal = keterangan_tiket.stasiun_asal 
                            and c.stasiun_tujuan = keterangan_tiket.stasiun_tujuan)"};
        public FrmLaporanPenjualan()
        {
            InitializeComponent();
            this.SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            this.controller = new LaporanPenjualanController();
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

        private void btnSemua_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void InisialisasiListView()
        {
            lvwReferences.View = System.Windows.Forms.View.Details;
            lvwReferences.FullRowSelect = true;
            lvwReferences.GridLines = true;
            lvwReferences.Columns.Add("No.", 35, HorizontalAlignment.Center);
            lvwReferences.Columns.Add("Kelas", 100, HorizontalAlignment.Center);
            lvwReferences.Columns.Add("Stasiun Asal", 100, HorizontalAlignment.Center);
            lvwReferences.Columns.Add("Stasiun Tujuan", 100, HorizontalAlignment.Center);
            lvwReferences.Columns.Add("Jumlah Tiket", 100, HorizontalAlignment.Center);
            lvwReferences.Columns.Add("Tersedia", 100, HorizontalAlignment.Center);
            lvwReferences.Columns.Add("Tidak Terjual", 100, HorizontalAlignment.Center);
            lvwReferences.Columns.Add("Terjual", 100, HorizontalAlignment.Center);
            lvwReferences.Columns.Add("Pendapatan", 100, HorizontalAlignment.Center);
        }

        private void LoadData()
        {
            lvwReferences.Items.Clear();
            listOfObject = controller.ReadAll();
            total = 0; jumlah = 0; tersedia = 0; terjual = 0; tidak_terjual = 0;
            foreach (var obj in listOfObject)
            {
                var noUrut = lvwReferences.Items.Count + 1;
                var item = new ListViewItem(noUrut.ToString());
                item.SubItems.Add(obj.kelas);
                item.SubItems.Add(obj.asal);
                item.SubItems.Add(obj.tujuan);
                item.SubItems.Add(obj.jumlah);
                item.SubItems.Add(obj.tersedia);
                item.SubItems.Add(obj.tidak_terjual);
                item.SubItems.Add(obj.terjual);
                item.SubItems.Add(obj.pendapatan.ToString());
                total += obj.pendapatan;
                jumlah += int.Parse(obj.jumlah);
                terjual += int.Parse(obj.terjual);
                tersedia += int.Parse(obj.tersedia);
                tidak_terjual += int.Parse(obj.tidak_terjual);

                lvwReferences.Items.Add(item);
            }
            txtTotal.Text = total.ToString();
            txtTiket.Text = jumlah.ToString() + "/" + tersedia.ToString() +"/" + tidak_terjual.ToString() + "/" + terjual.ToString();
        }
        private void btnCari_Click(object sender, EventArgs e)
        {
            LoadDataByField();
        }
        private void LoadDataByField()
        {
            lvwReferences.Items.Clear();
            listOfObject = controller.ReadByFieldRP(txtCari.Text, field[cmbField.SelectedIndex]);
            total = 0; jumlah = 0; tersedia = 0; terjual = 0; tidak_terjual = 0;
            foreach (var obj in listOfObject)
            {
                var noUrut = lvwReferences.Items.Count + 1;
                var item = new ListViewItem(noUrut.ToString());
                item.SubItems.Add(obj.kelas);
                item.SubItems.Add(obj.asal);
                item.SubItems.Add(obj.tujuan);
                item.SubItems.Add(obj.jumlah);
                item.SubItems.Add(obj.tersedia);
                item.SubItems.Add(obj.tidak_terjual);
                item.SubItems.Add(obj.terjual);
                item.SubItems.Add(obj.pendapatan.ToString());
                total += obj.pendapatan;
                jumlah += int.Parse(obj.jumlah);
                terjual += int.Parse(obj.terjual);
                tersedia += int.Parse(obj.tersedia);
                tidak_terjual += int.Parse(obj.tidak_terjual);

                lvwReferences.Items.Add(item);
            }
            txtTotal.Text = total.ToString();
            txtTiket.Text = jumlah.ToString() + "/" + tersedia.ToString() + "/" + tidak_terjual.ToString() + "/" + terjual.ToString();
        }
    }
}
