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

namespace KasirTiketKereta
{
    public partial class FrmFirstLogin : Form
    {
        public FrmFirstLogin()
        {
            //untuk dapat menggunakan warna dengan opacity tertentu/transparan
            this.SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            InitializeComponent();
            Warna();
        }
        //baris yang ditambahkan agar dapat melakukan drag secara kustom
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int IParam);
        //method untuk mengubah tampilan sesuai keinginan
        private void Warna()
        {
            this.tlpBackground.BackColor = Tema.ppc[GlobalVariable.id_tema];
            this.tlpBackground.ForeColor = Tema.fmu[GlobalVariable.id_tema];
            txtNama.BackColor = Tema.ot[GlobalVariable.id_tema];
            txtNama.ForeColor = Tema.oft[GlobalVariable.id_tema];
            txtPassword.BackColor = Tema.ot[GlobalVariable.id_tema];
            txtPassword.ForeColor = Tema.oft[GlobalVariable.id_tema];
            btnLogin.BackColor = Tema.ob[GlobalVariable.id_tema];
            btnLogin.ForeColor = Tema.ofb[GlobalVariable.id_tema];
            btnBatal.BackColor = Tema.ob[GlobalVariable.id_tema];
            btnBatal.ForeColor = Tema.ofb[GlobalVariable.id_tema];
            btnClose.ForeColor = Color.White;
            pnlControl.BackColor = Tema.ptc2[GlobalVariable.id_tema];
            this.pnlBackground.BackgroundImage = Tema.pbim[GlobalVariable.id_tema];
        }


        private void btnClose_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("And yakin ingin keluar?", "Perhatian", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        //agar panel2 dapat dijadikan sebagai patokan untuk melakukan drag
        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }


        private void btnLogin_Click_1(object sender, EventArgs e)
        {
            KasirController controller = new KasirController();
            Kasir kasir = new Kasir();
            kasir.nama_kasir = txtNama.Text;
            kasir.password = txtPassword.Text;
            int result = controller.Create(kasir);
            if (result>0)
            {
                //pengubahan nilai setting isFirst menjadi fals, untuk menandai user sudah membuat user admin
                Properties.Settings.Default.isFirst = false;
                //nama user admin disimpan di settings admin
                Properties.Settings.Default.admin = txtNama.Text;
                //untuk mensave settings yang diatas
                Properties.Settings.Default.Save();
                //nama dari admin disimpan di variabel nama di class GlobalVariable
                GlobalVariable.nama = txtNama.Text;
                MenuForm menuForm = new MenuForm();
                menuForm.Show();
                Hide();
            }
        }

        private void btnBatal_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("And yakin ingin keluar?", "Perhatian", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
