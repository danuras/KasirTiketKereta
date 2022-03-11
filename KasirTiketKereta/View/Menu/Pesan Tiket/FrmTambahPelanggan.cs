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

namespace KasirTiketKereta.View.Menu.Pesan_Tiket
{
    public partial class FrmTambahPelanggan : Form
    {
        private Label title;
        private FrmPesan frmPesan;
        private PelangganController pelangganController;
        private Pelanggan pelanggan;
        public FrmTambahPelanggan(Label title)
        {
            this.title = title;
            this.SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            this.pelangganController = new PelangganController();
            InitializeComponent();
            this.cmbJenisKelamin.SelectedIndex = 0;
            GlobalVariable.isReference = false;
            GlobalVariable.isNewData = true;
            Tampilan();
        }

        public void IsiFrmTetangga(FrmPesan frmPesan)
        {
            this.frmPesan = frmPesan;
        }
        private string BuatPelangganID()
        {
            string key = pelangganController.ReadLastKey();
            if (key == "")
            {
                return "P-00000000";
            }
            int angka = int.Parse(key.Remove(0, 2)) + 1;
            string nol = "0000000";
            for (int i = 10; i < 100000000; i *= 10)
            {
                if (angka < i)
                {
                    key = "P-" + nol + angka;
                    break;
                }
                nol = nol.Remove(0, 1);
            }
            return key;
        }

        private void Tampilan()
        {
            BackColor = Color.FromArgb(180, 0, 0, 0);
            panelB.BackColor = Tema.ppc[GlobalVariable.id_tema];
            lblA.ForeColor = Tema.fcfc[GlobalVariable.id_tema];
            lblB.ForeColor = Tema.fcfc[GlobalVariable.id_tema];
            lblC.ForeColor = Tema.fcfc[GlobalVariable.id_tema];
            lblD.ForeColor = Tema.fcfc[GlobalVariable.id_tema];
            lblE.ForeColor = Tema.fcfc[GlobalVariable.id_tema];
        }

        private void FrmPelanggan_Load(object sender, EventArgs e)
        {

        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (GlobalVariable.isNewData)
            {
                string id = BuatPelangganID();
                pelanggan = new Pelanggan();
                GlobalVariable.pelanggan_id = id;
                pelanggan.pelanggan_id = id;
                pelanggan.alamat_email = txtEmail.Text;
                pelanggan.jenis_kelamin = cmbJenisKelamin.Items[cmbJenisKelamin.SelectedIndex].ToString();
                pelanggan.nama_kasir = GlobalVariable.nama;
                pelanggan.nama = txtNama.Text;
                pelanggan.no_hp = txtNoHp.Text;
                int result = pelangganController.Create(pelanggan);
                if (result > 0)
                {
                    GlobalVariable.isNewData = false;
                    frmPesan.BringToFront();
                    title.Text = frmPesan.Text;
                }
            }
            else
            {
                pelanggan = new Pelanggan();
                pelanggan.pelanggan_id = GlobalVariable.pelanggan_id;
                pelanggan.alamat_email = txtEmail.Text;
                pelanggan.jenis_kelamin = cmbJenisKelamin.Items[cmbJenisKelamin.SelectedIndex].ToString();
                pelanggan.nama_kasir = GlobalVariable.nama;
                pelanggan.nama = txtNama.Text;
                pelanggan.no_hp = txtNoHp.Text;
                int result = pelangganController.Update(pelanggan);
                if (result > 0)
                {
                    GlobalVariable.isNewData = false;
                    frmPesan.BringToFront();
                    title.Text = frmPesan.Text;
                }
            }
        }
    }
}
