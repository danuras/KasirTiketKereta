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
    public partial class FrmEntryPesanan : Form
    {
        public delegate void CreateUpdateEventHandler(Pesanan pesanan);
        public event CreateUpdateEventHandler OnCreate;
        public event CreateUpdateEventHandler OnUpdate;
        private PesananController pesananController;
        private PelangganController pelangganController;
        private bool isNewData = true;

        private Pesanan pesanan;
        public FrmEntryPesanan()
        {
            InitializeComponent();
            this.SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            this.pelangganController = new PelangganController();
            cmbPayment.SelectedIndex = 0;
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
        }
        public FrmEntryPesanan(string title, PesananController pesananController)
         : this()
        {
            this.title.Text = title;
            this.pesananController = pesananController;
            txtNamaKasir.Text = GlobalVariable.nama;
            txtWaktuPesan.Text = DateTime.Now.ToString();
        }
        // constructor untuk inisialisasi data ketika mengedit data
        public FrmEntryPesanan(string title, PesananController pesananController, Pesanan pesanan)
         : this()
        {
            // ganti text/judul form
            this.title.Text = title;
            this.pesananController = pesananController;
            isNewData = false;
            this.pesanan = pesanan;
            txtIDPesanan.Text = pesanan.pesanan_id;
            txtWaktuPesan.Text = pesanan.waktu_pemesanan;
            for(int i = 0; i < 4; i++)
            {
                if(pesanan.metode_pembayaran == cmbPayment.Items[i].ToString())
                {
                    cmbPayment.SelectedIndex = i;
                }
            }
            txtJumlah.Text = pesanan.jumlah_tiket_dipesan.ToString();
            txtTotal.Text = pesanan.total_bayar.ToString();
            txtIDPelanggan.Text = pesanan.pelanggan_id;
            txtNamaKasir.Text = pesanan.nama_kasir;

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
            if (isNewData) pesanan = new Pesanan();
            pesanan.pesanan_id = txtIDPesanan.Text;
            pesanan.waktu_pemesanan = txtWaktuPesan.Text;
            pesanan.metode_pembayaran = cmbPayment.Items[cmbPayment.SelectedIndex].ToString();
            try
            {
                pesanan.jumlah_tiket_dipesan = int.Parse(txtJumlah.Text);
            }
            catch(Exception ex)
            {
                pesanan.jumlah_tiket_dipesan = 0;
            }
            try
            {
                pesanan.total_bayar = int.Parse(txtTotal.Text);
            }
            catch(Exception ex)
            {
                pesanan.total_bayar = 0;
            }
            pesanan.pelanggan_id = txtIDPelanggan.Text;
            pesanan.nama_kasir = txtNamaKasir.Text;

            if (pelangganController.IsIDExist(pesanan.pelanggan_id))
            {
                if (isNewData)
                {
                    result = pesananController.Create(pesanan);
                    if (result > 0)
                    {
                        OnCreate(pesanan);
                        txtJumlah.Clear();
                        txtTotal.Clear();
                        txtIDPelanggan.Clear();
                        txtWaktuPesan.Clear();
                        txtIDPesanan.Focus();
                    }
                }
                else
                {
                    result = pesananController.Update(pesanan);
                    if (result > 0)
                    {
                        OnUpdate(pesanan);
                        this.Close();
                    }
                }
            }
        }

        private void btnSelesai_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtJumlah_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
        (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void txtTotal_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
        (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
