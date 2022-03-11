using KasirTiketKereta.Asset_Code;
using KasirTiketKereta.Controller;
using KasirTiketKereta.Model.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace KasirTiketKereta.View.Menu.Reference
{
    public partial class FrmTiket : Form
    {
        private List<Tiket> listOfTiket = new List<Tiket>();
        private TiketController controller;
        private string[] field = {"tiket_id","nomor_kursi","pesanan_id","gerbong_id" };
        public FrmTiket()
        {
            InitializeComponent();
            this.SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            this.controller = new TiketController();
            InisialisasiListViewTiket();
            LoadDataTiket();
            cmbField.SelectedIndex = 0;
            this.BackColor = Color.FromArgb(0,0,0,0) ;
            Tampilan();
        }
        private void Tampilan() {
            lvwReferences.BackColor = Tema.ol[GlobalVariable.id_tema];
            lvwReferences.ForeColor = Tema.ofl[GlobalVariable.id_tema];
        }
        private void InisialisasiListViewTiket()
        {
            lvwReferences.View = System.Windows.Forms.View.Details;
            lvwReferences.FullRowSelect = true;
            lvwReferences.GridLines = true;
            lvwReferences.Columns.Add("No.", 35, HorizontalAlignment.Center);
            lvwReferences.Columns.Add("ID Tiket", 120, HorizontalAlignment.Center);
            lvwReferences.Columns.Add("Nomor kursi", 167, HorizontalAlignment.Center);
            lvwReferences.Columns.Add("ID Pesanan", 120, HorizontalAlignment.Center);
            lvwReferences.Columns.Add("ID gerbong", 120, HorizontalAlignment.Center);
        }

        private void LoadDataTiket()
        {
            lvwReferences.Items.Clear();
            listOfTiket = controller.ReadAll();
            foreach (var obj in listOfTiket)
            {
                var noUrut = lvwReferences.Items.Count + 1;
                var item = new ListViewItem(noUrut.ToString());
                item.SubItems.Add(obj.tiket_id);
                item.SubItems.Add(obj.nomor_kursi.ToString());
                item.SubItems.Add(obj.pesanan_id);
                item.SubItems.Add(obj.gerbong_id);

                lvwReferences.Items.Add(item);
            }
        }


        private void OnCreateEventHandlerTiket(Tiket tiket)
        {
            listOfTiket.Add(tiket);
            int noUrut = lvwReferences.Items.Count + 1;
            ListViewItem item = new ListViewItem(noUrut.ToString());
            item.SubItems.Add(tiket.tiket_id);
            item.SubItems.Add(tiket.nomor_kursi.ToString());
            item.SubItems.Add(tiket.pesanan_id);
            item.SubItems.Add(tiket.gerbong_id);
            lvwReferences.Items.Add(item);
        }
        private void OnUpdateEventHandlerTiket(Tiket tiket)
        {
            int index = lvwReferences.SelectedIndices[0];
            ListViewItem itemRow = lvwReferences.Items[index];
            itemRow.SubItems[1].Text = tiket.tiket_id;
            itemRow.SubItems[2].Text = tiket.nomor_kursi.ToString();
            itemRow.SubItems[3].Text = tiket.pesanan_id;
            itemRow.SubItems[4].Text = tiket.gerbong_id;
        }

        private void btnTambah_Click(object sender, EventArgs e)
        {
            FrmEntryTiket frmEntryTiket = new FrmEntryTiket("Tambah Data Tiket", controller);
            frmEntryTiket.OnCreate += OnCreateEventHandlerTiket;
            frmEntryTiket.ShowDialog();
        }

        private void btnHapus_Click(object sender, EventArgs e)
        {
            if (lvwReferences.SelectedItems.Count > 0)
            {
                var konfirmasi = MessageBox.Show("Apakah data tiket ingin dihapus?", "Konfirmasi",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

                if (konfirmasi == DialogResult.Yes)
                {
                    Tiket tiket = listOfTiket[lvwReferences.SelectedIndices[0]];
                    var result = controller.Delete(tiket);
                    if (result > 0) LoadDataTiket();
                }
            }
            else 
            {
                MessageBox.Show("Data tiket belum dipilih !!!", "Peringatan",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnPerbaiki_Click(object sender, EventArgs e)
        {
            if (lvwReferences.SelectedItems.Count > 0)
            {
                Tiket tiket = listOfTiket[lvwReferences.SelectedIndices[0]];
                FrmEntryTiket frmEntry = new FrmEntryTiket("Edit Data Tiket", controller, tiket);
                frmEntry.OnUpdate += OnUpdateEventHandlerTiket;
                frmEntry.ShowDialog();
            }
            else
            {
                MessageBox.Show("Data belum dipilih", "Peringatan",
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnCari_Click(object sender, EventArgs e)
        {
            LoadDataByField();
        }
         private void LoadDataByField()
        {
            lvwReferences.Items.Clear();
            listOfTiket = controller.ReadByField(txtCari.Text, field[cmbField.SelectedIndex]);
            foreach (var obj in listOfTiket)
            {
                var noUrut = lvwReferences.Items.Count + 1;
                var item = new ListViewItem(noUrut.ToString());
                item.SubItems.Add(obj.tiket_id);
                item.SubItems.Add(obj.nomor_kursi.ToString());
                item.SubItems.Add(obj.pesanan_id);
                item.SubItems.Add(obj.gerbong_id);

                lvwReferences.Items.Add(item);
            }
        }

        private void btnSemua_Click(object sender, EventArgs e)
        {
            LoadDataTiket();
        }
    }
}
