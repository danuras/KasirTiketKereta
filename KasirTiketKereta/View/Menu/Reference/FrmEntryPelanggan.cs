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
    public partial class FrmEntryPelanggan : Form
    {
        public delegate void CreateUpdateEventHandler(Pelanggan pelanggan);
        public event CreateUpdateEventHandler OnCreate;
        public event CreateUpdateEventHandler OnUpdate;
        private PelangganController pelangganController;
        private bool isNewData = true;

        private Pelanggan pelanggan;
        public FrmEntryPelanggan()
        {
            InitializeComponent();
            this.SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            cmbGender.SelectedIndex = 0;
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
        }
        public FrmEntryPelanggan(string title, PelangganController pelangganController)
         : this()
        {
            this.title.Text = title;
            this.pelangganController = pelangganController;
            txtNamaKasir.Text = GlobalVariable.nama;
        }
        // constructor untuk inisialisasi data ketika mengedit data
        public FrmEntryPelanggan(string title, PelangganController pelangganController, Pelanggan pelanggan)
         : this()
        {
            // ganti text/judul form
            this.title.Text = title;
            this.pelangganController = pelangganController;
            isNewData = false;
            this.pelanggan = pelanggan;
            txtIDPelanggan.Text = pelanggan.pelanggan_id;
            txtNama.Text = pelanggan.nama;
            txtAlamatEmail.Text = pelanggan.alamat_email;
            txtNamaKasir.Text = pelanggan.nama_kasir;
            txtNoHP.Text = pelanggan.no_hp;
            cmbGender.SelectedIndex = (pelanggan.jenis_kelamin == "Laki-laki") ? 0 : 1;
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
            if (isNewData) pelanggan = new Pelanggan();
            pelanggan.pelanggan_id = txtIDPelanggan.Text;
            pelanggan.alamat_email = txtAlamatEmail.Text;
            pelanggan.no_hp = txtNoHP.Text;
            pelanggan.jenis_kelamin = cmbGender.Items[cmbGender.SelectedIndex].ToString();
            pelanggan.nama_kasir = txtNamaKasir.Text;
            pelanggan.nama = txtNama.Text;
            if (isNewData)
            {
                result = pelangganController.Create(pelanggan);
                if (result > 0)
                {
                    OnCreate(pelanggan);
                    txtNamaKasir.Clear();
                    txtNoHP.Clear();
                    txtAlamatEmail.Clear();
                    txtNama.Clear();
                    txtIDPelanggan.Focus();
                }
            }
            else
            {
                result = pelangganController.Update(pelanggan);
                if (result > 0)
                {
                    OnUpdate(pelanggan);
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
    }
}
