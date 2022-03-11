using KasirTiketKereta.Asset_Code;
using KasirTiketKereta.Controller;
using KasirTiketKereta.Model.Entity;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace KasirTiketKereta.View.Menu.Reference
{
    public partial class FrmGerbong : Form
    {
        private List<Gerbong> listOfGerbong = new List<Gerbong>();
        private GerbongController controller;
        private string[] field = { "gerbong_id", "nama_gerbong", "keterangan_tiket_id", "jumlah_kursi"};
        public FrmGerbong()
        {
            InitializeComponent();
            this.SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            this.controller = new GerbongController();
            InisialisasiListView();
            LoadDataTiket();
            this.BackColor = Color.FromArgb(0,0,0,0) ;
            cmbField.SelectedIndex = 0;
            Tampilan();
        }
        private void Tampilan()
        {
            lvwReferences.BackColor = Tema.ol[GlobalVariable.id_tema];
            lvwReferences.ForeColor = Tema.ofl[GlobalVariable.id_tema];
        }
        private void InisialisasiListView()
        {
            lvwReferences.View = System.Windows.Forms.View.Details;
            lvwReferences.FullRowSelect = true;
            lvwReferences.GridLines = true;
            lvwReferences.Columns.Add("No.", 35, HorizontalAlignment.Center);
            lvwReferences.Columns.Add("ID Gerbong", 120, HorizontalAlignment.Center);
            lvwReferences.Columns.Add("Nama Gerbong", 167, HorizontalAlignment.Center);
            lvwReferences.Columns.Add("ID Keterangan", 120, HorizontalAlignment.Center);
            lvwReferences.Columns.Add("Jumlah Kursi", 120, HorizontalAlignment.Center);
        }

        private void LoadDataTiket()
        {
            lvwReferences.Items.Clear();
            listOfGerbong = controller.ReadAll();
            foreach (var obj in listOfGerbong)
            {
                var noUrut = lvwReferences.Items.Count + 1;
                var item = new ListViewItem(noUrut.ToString());
                item.SubItems.Add(obj.gerbong_id);
                item.SubItems.Add(obj.nama_gerbong);
                item.SubItems.Add(obj.keterangan_tiket_id);
                item.SubItems.Add(obj.jumlah_kursi.ToString());

                lvwReferences.Items.Add(item);
            }
        }


        private void OnCreateEventHandlerTiket(Gerbong obj)
        {
            listOfGerbong.Add(obj);
            int noUrut = lvwReferences.Items.Count + 1;
            ListViewItem item = new ListViewItem(noUrut.ToString());
            item.SubItems.Add(obj.gerbong_id);
            item.SubItems.Add(obj.nama_gerbong);
            item.SubItems.Add(obj.keterangan_tiket_id);
            item.SubItems.Add(obj.jumlah_kursi.ToString());
            lvwReferences.Items.Add(item);
        }
        private void OnUpdateEventHandlerTiket(Gerbong obj)
        {
            int index = lvwReferences.SelectedIndices[0];
            ListViewItem itemRow = lvwReferences.Items[index];
            itemRow.SubItems[1].Text = obj.gerbong_id;
            itemRow.SubItems[2].Text = obj.nama_gerbong;
            itemRow.SubItems[3].Text = obj.keterangan_tiket_id;
            itemRow.SubItems[4].Text = obj.jumlah_kursi.ToString();
        }

        private void btnTambah_Click(object sender, EventArgs e)
        {
            FrmEntryGerbong frmEntryGerbong = new FrmEntryGerbong("Tambah Data Gerbong", controller);
            frmEntryGerbong.OnCreate += OnCreateEventHandlerTiket;
            frmEntryGerbong.ShowDialog();
        }

        private void btnHapus_Click(object sender, EventArgs e)
        {
            if (lvwReferences.SelectedItems.Count > 0)
            {
                var konfirmasi = MessageBox.Show("Apakah data gerbong ingin dihapus?", "Konfirmasi",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

                if (konfirmasi == DialogResult.Yes)
                {
                    Gerbong gerbong = listOfGerbong[lvwReferences.SelectedIndices[0]];
                    var result = controller.Delete(gerbong);
                    if (result > 0) LoadDataTiket();
                }
            }
            else 
            {
                MessageBox.Show("Data gerbong belum dipilih !!!", "Peringatan",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnPerbaiki_Click(object sender, EventArgs e)
        {
            if (lvwReferences.SelectedItems.Count > 0)
            {
                Gerbong gerbong = listOfGerbong[lvwReferences.SelectedIndices[0]];
                FrmEntryGerbong frmEntry = new FrmEntryGerbong("Edit Data Gerbong", controller, gerbong);
                frmEntry.OnUpdate += OnUpdateEventHandlerTiket;
                frmEntry.ShowDialog();
            }
            else
            {
                MessageBox.Show("Data gerbong belum dipilih", "Peringatan",
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }


        private void btnCari_Click(object sender, EventArgs e)
        {
            lvwReferences.Items.Clear();
            listOfGerbong = controller.ReadByField(txtCari.Text, field[cmbField.SelectedIndex]);
            foreach (var obj in listOfGerbong)
            {
                var noUrut = lvwReferences.Items.Count + 1;
                var item = new ListViewItem(noUrut.ToString());
                item.SubItems.Add(obj.gerbong_id);
                item.SubItems.Add(obj.nama_gerbong);
                item.SubItems.Add(obj.keterangan_tiket_id);
                item.SubItems.Add(obj.jumlah_kursi.ToString());

                lvwReferences.Items.Add(item);
            }
        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnSemua_Click(object sender, EventArgs e)
        {
            LoadDataTiket();
        }
    }
}
