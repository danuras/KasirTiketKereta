using KasirTiketKereta.Asset_Code;
using KasirTiketKereta.Controller;
using KasirTiketKereta.Model.Entity;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace KasirTiketKereta.View.Menu.Reference
{
    public partial class FrmLaporanKerja : Form
    {
        private List<LaporanKerja> listOfObject = new List<LaporanKerja>();
        private LaporanKerjaController controller;
        private int total, tiket;
        private string[] field = {"kasir.nama_kasir",
                                    "count(*)", 
                                    "(select sum(jumlah_tiket_dipesan) from pesanan where nama_kasir = kasir.nama_kasir)",
                                    "(select sum(total_bayar) from pesanan where nama_kasir = kasir.nama_kasir)"};
        public FrmLaporanKerja()
        {
            InitializeComponent();
            this.SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            this.controller = new LaporanKerjaController();
            InisialisasiListView();
            LoadData();
            cmbField.SelectedIndex = 0;
            this.BackColor = Color.FromArgb(0,0,0,0) ;
            Tampilan();
        }

        private void InisialisasiListView()
        {
            lvwReferences.View = System.Windows.Forms.View.Details;
            lvwReferences.FullRowSelect = true;
            lvwReferences.GridLines = true;
            lvwReferences.Columns.Add("No.", 35, HorizontalAlignment.Center);
            lvwReferences.Columns.Add("Nama kasir", 150, HorizontalAlignment.Center);
            lvwReferences.Columns.Add("Jumlah Pelanggan", 130, HorizontalAlignment.Center);
            lvwReferences.Columns.Add("Jumlah Penjualan", 100, HorizontalAlignment.Center);
            lvwReferences.Columns.Add("pendapatan", 130, HorizontalAlignment.Center);
        }

        private void Tampilan()
        {
            lblA.ForeColor = Tema.fcfc[GlobalVariable.id_tema];
            lblB.ForeColor = Tema.fcfc[GlobalVariable.id_tema];
            lvwReferences.BackColor = Tema.ol[GlobalVariable.id_tema];
            lvwReferences.ForeColor = Tema.ofl[GlobalVariable.id_tema];
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
                item.SubItems.Add(obj.nama_kasir);
                item.SubItems.Add(obj.jumlah_pelanggan);
                item.SubItems.Add(obj.tiket_terjual);
                item.SubItems.Add(obj.pendapatan);
                total += int.Parse(obj.pendapatan);
                tiket += int.Parse(obj.tiket_terjual);

                lvwReferences.Items.Add(item);
            }
            txtTotal.Text = total.ToString();
            txtTiket.Text = tiket.ToString();
        }
        private void btnCari_Click(object sender, EventArgs e)
        {
            LoadDataByField();
        }

        private void txtCari_TextChanged(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lvwReferences_SelectedIndexChanged(object sender, EventArgs e)
        {

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
                item.SubItems.Add(obj.nama_kasir);
                item.SubItems.Add(obj.jumlah_pelanggan);
                item.SubItems.Add(obj.tiket_terjual);
                item.SubItems.Add(obj.pendapatan);
                total += int.Parse(obj.pendapatan);
                tiket += int.Parse(obj.tiket_terjual);

                lvwReferences.Items.Add(item);
            }
            txtTotal.Text = total.ToString();
            txtTiket.Text = tiket.ToString();
        }
    }
}
