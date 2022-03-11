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
    public partial class FrmEntryGerbong : Form
    {
        public delegate void CreateUpdateEventHandler(Gerbong gerbong);
        public event CreateUpdateEventHandler OnCreate;
        public event CreateUpdateEventHandler OnUpdate;
        private KeteranganTiketController keteranganTiketController;
        private GerbongController gerbongController;
        private bool isNewData = true;

        private Gerbong gerbong;
        public FrmEntryGerbong()
        {
            InitializeComponent();
            this.SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            this.keteranganTiketController = new KeteranganTiketController();
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
        public FrmEntryGerbong(string title, GerbongController gerbongController)
         : this()
        {
            this.title.Text = title;
            this.gerbongController = gerbongController;
        }
        // constructor untuk inisialisasi data ketika mengedit data
        public FrmEntryGerbong(string title, GerbongController gerbongController, Gerbong obj)
         : this()
        {
            // ganti text/judul form
            this.title.Text = title;
            this.gerbongController = gerbongController;
            isNewData = false;
            this.gerbong = obj;
            this.txtIDGerbong.Text = obj.gerbong_id;
            this.txtNamaGerbong.Text = obj.nama_gerbong;
            this.txtIDKeterangan.Text = obj.keterangan_tiket_id;
            this.txtJumahKursi.Text = obj.jumlah_kursi.ToString();
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
            if (isNewData) gerbong = new Gerbong();
            gerbong.gerbong_id = txtIDGerbong.Text;
            try
            {
                gerbong.jumlah_kursi = int.Parse(txtJumahKursi.Text);
            }
            catch (Exception ex)
            {
                gerbong.jumlah_kursi = 0;
            }
            gerbong.nama_gerbong = txtNamaGerbong.Text;
            gerbong.keterangan_tiket_id = txtIDKeterangan.Text;
            if (keteranganTiketController.IsIDExist(gerbong.keterangan_tiket_id))
            {
                if (isNewData)
                {
                    result = gerbongController.Create(gerbong);
                    if (result > 0)
                    {
                        OnCreate(gerbong);
                        txtJumahKursi.Clear();
                        txtIDKeterangan.Clear();
                        txtNamaGerbong.Clear();
                        txtIDGerbong.Focus();
                    }
                }
                else
                {
                    result = gerbongController.Update(gerbong);
                    if (result > 0)
                    {
                        OnUpdate(gerbong);
                        this.Close();
                    }
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

        private void txtJumahKursi_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
        (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }
    }
}
