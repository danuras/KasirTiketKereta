using KasirTiketKereta.Asset_Code;
using KasirTiketKereta.Controller;
using KasirTiketKereta.Model.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KasirTiketKereta.View.Menu.Tambah_Tiket
{
    public partial class FrmTambahGerbong : Form
    {
        private Label title;
        private List<Gerbong> listOfGerbong = new List<Gerbong>();
        private FrmTambahKeteranganTiket frmKeteranganTiket;
        private GerbongController gerbongController;
        private TiketController tiketController;
        private KeteranganTiketController keteranganTiketController;
        public delegate void OnSelesaiEventHandler();
        public event OnSelesaiEventHandler OnSelesai;
        public FrmTambahGerbong(Label title, TiketController tiketController, GerbongController gerbongController, KeteranganTiketController keteranganTiketController)
        {
            this.title = title;
            InitializeComponent();
            this.gerbongController = gerbongController;
            this.tiketController = tiketController;
            this.keteranganTiketController = keteranganTiketController;
            this.SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            InisialisasiListView();
            Tampilan();
        }
        private void InisialisasiListView()
        {
            lvwGerbong.View = System.Windows.Forms.View.Details;
            lvwGerbong.FullRowSelect = true;
            lvwGerbong.GridLines = true;
            lvwGerbong.Columns.Add("No.", 35, HorizontalAlignment.Center);
            lvwGerbong.Columns.Add("ID", 100, HorizontalAlignment.Center);
            lvwGerbong.Columns.Add("Nama", 314, HorizontalAlignment.Center);
            lvwGerbong.Columns.Add("Jumlah Kursi", 112, HorizontalAlignment.Center);
        }

        private void Tampilan()
        {
            BackColor = Color.FromArgb(180, 0, 0, 0);
            panelA.BackColor = Tema.ppc[GlobalVariable.id_tema];
            lblA.ForeColor = Tema.fcfc[GlobalVariable.id_tema];
            lvwGerbong.BackColor = Tema.ol[GlobalVariable.id_tema];
            lvwGerbong.ForeColor = Tema.ofl[GlobalVariable.id_tema];
        }
        public void IsiFormTetangga(FrmTambahKeteranganTiket frmKeteranganTiket)
        {
            this.frmKeteranganTiket = frmKeteranganTiket;
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            KeteranganTiket keteranganTiket = new KeteranganTiket();
            keteranganTiket.keterangan_tiket_id = GlobalVariable.keterangan_id;
            frmKeteranganTiket.BringToFront();
            title.Text = frmKeteranganTiket.Text;
        }

        

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            frmKeteranganTiket.Close();
            this.Close();
            OnSelesai();
        }

        private void FrmGerbong_Load(object sender, EventArgs e)
        {

        }
        private void LoadDataGerbong()
        {
            lvwGerbong.Items.Clear();
            listOfGerbong = gerbongController.ReadByKT(GlobalVariable.keterangan_id);
            foreach (var gerbong in listOfGerbong)
            {
                var noUrut = lvwGerbong.Items.Count + 1;
                var item = new ListViewItem(noUrut.ToString());
                item.SubItems.Add(gerbong.gerbong_id);
                item.SubItems.Add(gerbong.nama_gerbong);
                item.SubItems.Add(gerbong.jumlah_kursi.ToString());

                lvwGerbong.Items.Add(item);
            }
        }


        private void btnHapus_Click(object sender, EventArgs e)
        {
            if(lvwGerbong.SelectedItems.Count > 0)
            {
                var konfirmasi = MessageBox.Show("Apakah data gerbong ingin dihapus ? ", "Konfirmasi",
                MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                if (konfirmasi == DialogResult.Yes)
                {
                    Gerbong gerbong = listOfGerbong[lvwGerbong.SelectedIndices[0]];

                    var result = gerbongController.Delete(gerbong);
                    if (result > 0) LoadDataGerbong();
                }
            }
            else
            {
                MessageBox.Show("Data Gerbong belum dipilih !!!", "Peringatan",
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        private void txtJumlahKursi_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsControl(e.KeyChar)&&!char.IsDigit(e.KeyChar)&&(e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void btnTambahController_Click_1(object sender, EventArgs e)
        {
            FrmEntryGerbong frmEntry = new FrmEntryGerbong("Tambah Data Gerbong", gerbongController, tiketController);
            frmEntry.OnCreate += OnCreateEventHandler;
            frmEntry.ShowDialog();
        }
        private void OnCreateEventHandler(Gerbong gerbong)
        {
            listOfGerbong.Add(gerbong);
            int noUrut = lvwGerbong.Items.Count + 1;
            ListViewItem item = new ListViewItem(noUrut.ToString());
            item.SubItems.Add(gerbong.gerbong_id);
            item.SubItems.Add(gerbong.nama_gerbong);
            item.SubItems.Add(gerbong.jumlah_kursi.ToString());
            lvwGerbong.Items.Add(item);
        }

        private void btnPerbaikiController_Click(object sender, EventArgs e)
        {
            if (lvwGerbong.SelectedItems.Count > 0)
            {
                Gerbong gerbong = listOfGerbong[lvwGerbong.SelectedIndices[0]];
                FrmEntryGerbong frmEntry = new FrmEntryGerbong("Edit Data Gerbong", gerbong, gerbongController,tiketController);
                frmEntry.OnUpdate += OnUpdateEventHandler;
                frmEntry.ShowDialog();
            }
            else 
            {
                MessageBox.Show("Data belum dipilih", "Peringatan",
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        private void OnUpdateEventHandler(Gerbong gerbong)
        {
            int index = lvwGerbong.SelectedIndices[0];
            ListViewItem itemRow = lvwGerbong.Items[index];
            itemRow.SubItems[1].Text = gerbong.gerbong_id;
            itemRow.SubItems[2].Text = gerbong.nama_gerbong;
            itemRow.SubItems[3].Text = gerbong.jumlah_kursi.ToString();
        }
    }
}
