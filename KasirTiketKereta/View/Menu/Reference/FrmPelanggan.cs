using KasirTiketKereta.Asset_Code;
using KasirTiketKereta.Controller;
using KasirTiketKereta.Model.Entity;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace KasirTiketKereta.View.Menu.Reference
{
    public partial class FrmPelanggan : Form
    {
        private List<Pelanggan> listOfPelanggan = new List<Pelanggan>();
        private PelangganController controller;
        private string[] field = { "pelanggan_id", "alamat_email", "no_hp", "jenis_kelamin", "nama_kasir", "nama"};
        public FrmPelanggan()
        {
            InitializeComponent();
            this.SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            this.controller = new PelangganController();
            InisialisasiListViewPelanggan();
            LoadDataPelanggan();
            this.BackColor = Color.FromArgb(0,0,0,0);
            cmbField.SelectedIndex = 0;
            Tampilan();
        }
        private void Tampilan()
        {
            lvwReferences.BackColor = Tema.ol[GlobalVariable.id_tema];
            lvwReferences.ForeColor = Tema.ofl[GlobalVariable.id_tema];
        }
        private void InisialisasiListViewPelanggan()
        {
            lvwReferences.View = System.Windows.Forms.View.Details;
            lvwReferences.FullRowSelect = true;
            lvwReferences.GridLines = true;
            lvwReferences.Columns.Add("No.", 35, HorizontalAlignment.Center);
            lvwReferences.Columns.Add("ID Pelanggan", 100, HorizontalAlignment.Center);
            lvwReferences.Columns.Add("Nama", 100, HorizontalAlignment.Center);
            lvwReferences.Columns.Add("Alamat email", 120, HorizontalAlignment.Center);
            lvwReferences.Columns.Add("No Hp", 100, HorizontalAlignment.Center);
            lvwReferences.Columns.Add("Jenis Kelamin", 100, HorizontalAlignment.Center);
            lvwReferences.Columns.Add("Nama Kasir", 100, HorizontalAlignment.Center);
        }

        private void LoadDataPelanggan()
        {
            lvwReferences.Items.Clear();
            listOfPelanggan = controller.ReadAll();
            foreach (var obj in listOfPelanggan)
            {
                var noUrut = lvwReferences.Items.Count + 1;
                var item = new ListViewItem(noUrut.ToString());
                item.SubItems.Add(obj.pelanggan_id);
                item.SubItems.Add(obj.nama);
                item.SubItems.Add(obj.alamat_email);
                item.SubItems.Add(obj.no_hp);
                item.SubItems.Add(obj.jenis_kelamin);
                item.SubItems.Add(obj.nama_kasir);

                lvwReferences.Items.Add(item);
            }
        }


        private void OnCreateEventHandlerPelanggan(Pelanggan obj)
        {
            listOfPelanggan.Add(obj);
            int noUrut = lvwReferences.Items.Count + 1;
            ListViewItem item = new ListViewItem(noUrut.ToString());
            item.SubItems.Add(obj.pelanggan_id);
            item.SubItems.Add(obj.nama);
            item.SubItems.Add(obj.alamat_email);
            item.SubItems.Add(obj.no_hp);
            item.SubItems.Add(obj.jenis_kelamin);
            item.SubItems.Add(obj.nama_kasir);
            lvwReferences.Items.Add(item);
        }
        private void OnUpdateEventHandlerPelanggan(Pelanggan pelanggan)
        {
            int index = lvwReferences.SelectedIndices[0];
            ListViewItem itemRow = lvwReferences.Items[index];
            itemRow.SubItems[1].Text = pelanggan.pelanggan_id;
            itemRow.SubItems[2].Text = pelanggan.nama;
            itemRow.SubItems[3].Text = pelanggan.alamat_email;
            itemRow.SubItems[4].Text = pelanggan.no_hp;
            itemRow.SubItems[5].Text = pelanggan.jenis_kelamin;
            itemRow.SubItems[6].Text = pelanggan.nama_kasir;
        }

        private void btnTambah_Click(object sender, EventArgs e)
        {
            FrmEntryPelanggan frmEntryPelanggan = new FrmEntryPelanggan("Tambah Data Pelanggan", controller);
            frmEntryPelanggan.OnCreate += OnCreateEventHandlerPelanggan;
            frmEntryPelanggan.ShowDialog();
        }

        private void btnHapus_Click(object sender, EventArgs e)
        {
            if (lvwReferences.SelectedItems.Count > 0)
            {
                var konfirmasi = MessageBox.Show("Apakah data pelanggan ingin dihapus?", "Konfirmasi",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

                if (konfirmasi == DialogResult.Yes)
                {
                    Pelanggan pelanggan = listOfPelanggan[lvwReferences.SelectedIndices[0]];
                    var result = controller.Delete(pelanggan);
                    if (result > 0) LoadDataPelanggan();
                }
            }
            else 
            {
                MessageBox.Show("Data pelanggan belum dipilih !!!", "Peringatan",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnPerbaiki_Click(object sender, EventArgs e)
        {
            if (lvwReferences.SelectedItems.Count > 0)
            {
                Pelanggan pelanggan = listOfPelanggan[lvwReferences.SelectedIndices[0]];
                FrmEntryPelanggan frmEntry = new FrmEntryPelanggan("Edit Data Pelanggan", controller, pelanggan);
                frmEntry.OnUpdate += OnUpdateEventHandlerPelanggan;
                frmEntry.ShowDialog();
            }
            else
            {
                MessageBox.Show("Data pelanggan belum dipilih", "Peringatan",
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnCari_Click(object sender, EventArgs e)
        {
            lvwReferences.Items.Clear();
            listOfPelanggan = controller.ReadByField(txtCari.Text, field[cmbField.SelectedIndex]);
            foreach (var obj in listOfPelanggan)
            {
                var noUrut = lvwReferences.Items.Count + 1;
                var item = new ListViewItem(noUrut.ToString());
                item.SubItems.Add(obj.pelanggan_id);
                item.SubItems.Add(obj.nama);
                item.SubItems.Add(obj.alamat_email);
                item.SubItems.Add(obj.no_hp);
                item.SubItems.Add(obj.jenis_kelamin);
                item.SubItems.Add(obj.nama_kasir);

                lvwReferences.Items.Add(item);
            }
        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnSemua_Click(object sender, EventArgs e)
        {
            LoadDataPelanggan();
        }
    }
}
