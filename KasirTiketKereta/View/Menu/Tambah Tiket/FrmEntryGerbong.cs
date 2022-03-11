using KasirTiketKereta.Asset_Code;
using KasirTiketKereta.Controller;
using KasirTiketKereta.Model.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KasirTiketKereta.View.Menu.Tambah_Tiket
{
    public partial class FrmEntryGerbong : Form
    {
        public delegate void CreateUpdateEventHandler(Gerbong gerbong);

        public event CreateUpdateEventHandler OnCreate;

        public event CreateUpdateEventHandler OnUpdate;

        private GerbongController controller;
        private TiketController tiketController;
        private bool isNewData = true;
        private string gerbong_id;

        private Gerbong gerbong;
        public FrmEntryGerbong()
        {
            InitializeComponent();
            this.SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            Tampilan();
        }

        private void Tampilan()
        {
            BackColor = Color.FromArgb(180, 0, 0, 0);
            panelA.BackColor = Tema.ppc[GlobalVariable.id_tema];
            this.BackgroundImage = Tema.pbim[GlobalVariable.id_tema];
            lblA.ForeColor = Tema.fmu[GlobalVariable.id_tema];
            lblB.ForeColor = Tema.fmu[GlobalVariable.id_tema];
            pnlControl.BackColor = Tema.ptc2[GlobalVariable.id_tema];
        }
        public FrmEntryGerbong(string title, GerbongController controller, TiketController tiketController)
         : this()
        {
            this.title.Text = title;
            this.controller = controller;
            this.tiketController = tiketController;
        }
        // constructor untuk inisialisasi data ketika mengedit data
        public FrmEntryGerbong(string title, Gerbong obj, GerbongController controller, TiketController tiketController)
         : this()
        {
            // ganti text/judul form
            this.title.Text = title;
            this.controller = controller;
            this.tiketController = tiketController;
            isNewData = false; 
            gerbong = obj; 
            gerbong_id = gerbong.gerbong_id;
            txtNama.Text = gerbong.nama_gerbong;
            txtJumlahKursi.Text = gerbong.jumlah_kursi.ToString();
        }
        //untuk dapat drag dengan custom
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int IParam);

        private string BuatTiketID()
        {
            //cari id terbesar
            string key = tiketController.ReadLastKey();
            if (key == "")
            {
                return "T-00000000";
            }
            //naikan angkanya
            int angka = int.Parse(key.Remove(0, 2)) + 1;
            //bentuk kembali formatnya
            string nol = "0000000";
            for (int i = 10; i < 100000000; i *= 10)
            {
                if (angka < i)
                {
                    key = "T-" + nol + angka;
                    break;
                }
                nol = nol.Remove(0, 1);
            }
            return key;
        }
        private string BuatGerbongID()
        {
            //cari id terbesar
            string key = controller.ReadLastKey();
            if (key == "")
            {
                return "G-00000";
            }
            //naikan angkanya
            int angka = int.Parse(key.Remove(0, 2)) + 1;
            //bentuk kembali formatnya
            string nol = "0000";
            for (int i = 10; i < 100000; i *= 10)
            {
                if (angka < i)
                {
                    key = "G-" + nol + angka;
                    break;
                }
                nol = nol.Remove(0, 1);
            }
            return key;
        }
        //untuk drag secara kustom
        private void pnlControl_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnPerbaiki_Click(object sender, EventArgs e)
        {
            if (isNewData) gerbong = new Gerbong();
            gerbong.gerbong_id = gerbong_id;
            gerbong.nama_gerbong = txtNama.Text;
            try
            {
                gerbong.jumlah_kursi = int.Parse(txtJumlahKursi.Text);
            }
            catch
            {
                gerbong.jumlah_kursi = 0;
            }
            gerbong.keterangan_tiket_id = GlobalVariable.keterangan_id;
            int result = 0;
            if (isNewData)
            {
                gerbong.gerbong_id = BuatGerbongID();
                result = controller.Create(gerbong);
                if (result > 0)
                {
                    int i = 1, progress = 1000 / gerbong.jumlah_kursi + 1;
                    Tiket tiket = new Tiket();
                    while (i <= gerbong.jumlah_kursi)
                    {
                        tiket.tiket_id = BuatTiketID();
                        tiket.nomor_kursi = i;
                        tiket.gerbong_id = gerbong.gerbong_id;
                        tiketController.Create(tiket);
                        if ((pgbInput.Value + progress) < 1000) pgbInput.Value += progress;
                        i++;
                    }
                    pgbInput.Value = 0;
                    OnCreate(gerbong);
                    gerbong_id = "";
                    txtNama.Clear();
                    txtJumlahKursi.Clear();
                }
            }
            else
            {
                tiketController.DeleteByGerbong(gerbong_id);
                result = controller.Update(gerbong);
                if (result > 0)
                {
                    int i = 1, progress = 1000 / gerbong.jumlah_kursi + 1;
                    Tiket tiket = new Tiket();
                    while (i <= gerbong.jumlah_kursi)
                    {
                        tiket.tiket_id = BuatTiketID();
                        tiket.nomor_kursi = i;
                        tiket.gerbong_id = gerbong.gerbong_id;
                        tiketController.Create(tiket);
                        if ((pgbInput.Value + progress) < 1000) pgbInput.Value += progress;
                        i++;
                    }
                    pgbInput.Value = 0;
                    OnUpdate(gerbong); 
                    this.Close();
                }
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void txtJumlahKursi_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
        (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }
    }
}
