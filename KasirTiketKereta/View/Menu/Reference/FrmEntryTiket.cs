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
    public partial class FrmEntryTiket : Form
    {
        public delegate void CreateUpdateEventHandler(Tiket tiket);
        public event CreateUpdateEventHandler OnCreate;
        public event CreateUpdateEventHandler OnUpdate;
        private TiketController tiketController;
        private PesananController pesananController;
        private GerbongController gerbongController;
        private bool isNewData = true;

        private Tiket tiket;
        public FrmEntryTiket()
        {
            InitializeComponent();
            this.SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            this.pesananController = new PesananController();
            this.gerbongController = new GerbongController();
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
        }
        public FrmEntryTiket(string title, TiketController tiketController)
         : this()
        {
            this.title.Text = title;
            this.tiketController = tiketController;
        }
        // constructor untuk inisialisasi data ketika mengedit data
        public FrmEntryTiket(string title, TiketController tiketController, Tiket tiket)
         : this()
        {
            // ganti text/judul form
            this.title.Text = title;
            this.tiketController = tiketController;
            isNewData = false;
            this.tiket = tiket;
            this.txtIDTiket.Text = tiket.tiket_id;
            this.txtNomorKursi.Text = tiket.nomor_kursi.ToString();
            this.txtIDGerbong.Text = tiket.gerbong_id;
            this.txtIDPesan.Text = tiket.pesanan_id;
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
            if (isNewData) tiket = new Tiket();
            tiket.tiket_id = txtIDTiket.Text;
            try
            {
                tiket.nomor_kursi = int.Parse(txtNomorKursi.Text);
            }
            catch (Exception ex)
            {
                tiket.nomor_kursi = 0;
            }
            tiket.gerbong_id = txtIDGerbong.Text;
            tiket.pesanan_id = txtIDPesan.Text;
            if (gerbongController.IsIDExist(tiket.gerbong_id) && pesananController.IsIDExist(tiket.pesanan_id))
            {
                if (isNewData)
                {
                    result = tiketController.Create(tiket);
                    if (result > 0)
                    {
                        OnCreate(tiket);
                        txtIDGerbong.Clear();
                        txtIDPesan.Clear();
                        txtNomorKursi.Clear();
                        txtIDTiket.Focus();
                    }
                }
                else
                {
                    result = tiketController.Update(tiket);
                    if (result > 0)
                    {
                        OnUpdate(tiket);
                        this.Close();
                    }
                }
            }
        }

        private void btnSelesai_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void txtNomorKursi_KeyPress(object sender, KeyPressEventArgs e)
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
