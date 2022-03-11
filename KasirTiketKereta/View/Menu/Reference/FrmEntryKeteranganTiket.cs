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

namespace KasirTiketKereta.View.Menu.Reference
{
    public partial class FrmEntryKeteranganTiket : Form
    {
        public delegate void CreateUpdateEventHandler(KeteranganTiket keteranganTiket);
        public event CreateUpdateEventHandler OnCreate;
        public event CreateUpdateEventHandler OnUpdate;
        private KeteranganTiketController keteranganTiketController;
        private bool isNewData = true;

        private KeteranganTiket keteranganTiket;
        public FrmEntryKeteranganTiket()
        {
            InitializeComponent();
            this.SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            Tampilan();
        }

        private void Tampilan()
        {
            BackColor = Color.FromArgb(180, 0, 0, 0);
            panel1.BackColor = Tema.ppc[GlobalVariable.id_tema];
            this.BackgroundImage = Tema.pbim[GlobalVariable.id_tema];
            pnlControl.BackColor = Tema.ptc2[GlobalVariable.id_tema];
            lblA.ForeColor = Tema.fmu[GlobalVariable.id_tema];
            lblB.ForeColor = Tema.fmu[GlobalVariable.id_tema];
            lblC.ForeColor = Tema.fmu[GlobalVariable.id_tema];
            lblD.ForeColor = Tema.fmu[GlobalVariable.id_tema];
            lblE.ForeColor = Tema.fmu[GlobalVariable.id_tema];
            lblF.ForeColor = Tema.fmu[GlobalVariable.id_tema];
            lblG.ForeColor = Tema.fmu[GlobalVariable.id_tema];
            lblH.ForeColor = Tema.fmu[GlobalVariable.id_tema];
            lblI.ForeColor = Tema.fmu[GlobalVariable.id_tema];
        }
        public FrmEntryKeteranganTiket(string title, KeteranganTiketController keteranganTiketController)
         : this()
        {
            this.title.Text = title;
            this.keteranganTiketController = keteranganTiketController;
        }
        // constructor untuk inisialisasi data ketika mengedit data
        public FrmEntryKeteranganTiket(string title, KeteranganTiketController keteranganTiketController, KeteranganTiket keteranganTiket)
         : this()
        {
            // ganti text/judul form
            this.title.Text = title;
            this.keteranganTiketController = keteranganTiketController;
            isNewData = false;
            this.keteranganTiket = keteranganTiket;
            this.txtIDKeterangan.Text = keteranganTiket.keterangan_tiket_id;
            this.txtJenisKereta.Text = keteranganTiket.jenis_kereta;
            this.txtKelas.Text = keteranganTiket.kelas;
            this.txtNama.Text = keteranganTiket.nama_kereta;
            this.txtAsal.Text = keteranganTiket.stasiun_asal;
            this.txtTujuan.Text = keteranganTiket.stasiun_tujuan;
            this.dtpKeberangkatan.Text = keteranganTiket.jadwal_keberangkatan;
            this.dtpKedatangan.Text = keteranganTiket.jadwal_kedatangan;
            this.txtHarga.Text = keteranganTiket.harga.ToString();
        }

        //untuk dapat drag dengan custom
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int IParam);

        private void pnlControl_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            int result = 0;
            if (isNewData) keteranganTiket = new KeteranganTiket();
            keteranganTiket.keterangan_tiket_id = txtIDKeterangan.Text;
            keteranganTiket.jenis_kereta = txtJenisKereta.Text;
            keteranganTiket.kelas = txtKelas.Text;
            keteranganTiket.nama_kereta = txtNama.Text;
            keteranganTiket.stasiun_asal = txtAsal.Text;
            keteranganTiket.stasiun_tujuan = txtTujuan.Text;
            keteranganTiket.jadwal_keberangkatan = dtpKeberangkatan.Text;
            keteranganTiket.jadwal_kedatangan = dtpKedatangan.Text;
            try
            {
                keteranganTiket.harga = int.Parse(txtHarga.Text);
            }
            catch (Exception ex)
            {
                keteranganTiket.harga = 0;
            }
            if (isNewData)
            {
                result = keteranganTiketController.Create(keteranganTiket);
                if (result > 0)
                {
                    OnCreate(keteranganTiket);
                    txtNama.Clear();
                    txtKelas.Clear();
                    txtJenisKereta.Clear();
                    txtIDKeterangan.Focus();
                    txtHarga.Clear();
                    txtAsal.Clear();
                    txtTujuan.Clear();
                }
            }
            else
            {
                result = keteranganTiketController.Update(keteranganTiket);
                if (result > 0)
                {
                    OnUpdate(keteranganTiket);
                    this.Close();
                }
            }
        }

        private void btnSelesai_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtHarga_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
        (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }
    }
}
