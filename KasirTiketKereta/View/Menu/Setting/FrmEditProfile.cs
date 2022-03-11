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
    public partial class FrmEditProfile : Form
    {
        private KasirController kasirController;

        private Kasir kasir;
        private string oldName;
        public FrmEditProfile()
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
        }
        public FrmEditProfile( KasirController kasirController, Kasir kasir)
         : this()
        {
            // ganti text/judul form
            this.kasirController = kasirController;
            this.kasir = kasir;
            this.txtNama.Text = kasir.nama_kasir;
            this.oldName = kasir.nama_kasir;
            this.txtPassword.Text = kasir.password;
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
            kasir.nama_kasir = txtNama.Text;
            kasir.password = txtPassword.Text;
            result = kasirController.Update(kasir, oldName);
            if (result > 0)
            {
                if (oldName == Properties.Settings.Default.admin)
                {
                    Properties.Settings.Default.admin = txtNama.Text;
                }
                this.Close();
            }
        }
        private void txtNomorKursi_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
        (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }
        private void btnSelesai_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnClose_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
