using KasirTiketKereta.Asset_Code;
using KasirTiketKereta.Controller;
using KasirTiketKereta.Model.Entity;
using KasirTiketKereta.View.Menu.Tambah_Tiket;
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
    public partial class FrmTambahKeteranganTiket : Form
    {
        private FrmTambahGerbong frmGerbong;
        private Label title;
        private KeteranganTiket keteranganTiket;
        private KeteranganTiketController keteranganTiketController;
        private string jenis_kereta;
        public FrmTambahKeteranganTiket(Label title, KeteranganTiketController keteranganTiketController)
        {
            this.keteranganTiketController = keteranganTiketController;
            this.title = title;
            this.SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            InitializeComponent();
            this.cmbKelas.SelectedIndex = 0;
            txtHarga.Text = "100000";
            GlobalVariable.isReference = false;
            GlobalVariable.isNewData = true;
            Tampilan();
        }

        private void Tampilan()
        {
            BackColor = Color.FromArgb(180, 0, 0, 0);
            panelA.BackColor = Tema.ppc[GlobalVariable.id_tema];
            panelB.BackColor = Tema.ppc[GlobalVariable.id_tema];
            panelC.BackColor = Tema.ppc[GlobalVariable.id_tema];
            panelD.BackColor = Tema.ppc[GlobalVariable.id_tema];
            panelE.BackColor = Tema.ppc[GlobalVariable.id_tema];
            lblA.ForeColor = Tema.fcfc[GlobalVariable.id_tema];
            lblB.ForeColor = Tema.fcfc[GlobalVariable.id_tema];
            lblC.ForeColor = Tema.fcfc[GlobalVariable.id_tema];
            lblD.ForeColor = Tema.fcfc[GlobalVariable.id_tema];
            lblE.ForeColor = Tema.fcfc[GlobalVariable.id_tema];
            lblF.ForeColor = Tema.fcfc[GlobalVariable.id_tema];
            lblG.ForeColor = Tema.fcfc[GlobalVariable.id_tema];
            lblH.ForeColor = Tema.fcfc[GlobalVariable.id_tema];
            lblI.ForeColor = Tema.fcfc[GlobalVariable.id_tema];
            lblJ.ForeColor = Tema.fcfc[GlobalVariable.id_tema];
            lblK.ForeColor = Tema.fcfc[GlobalVariable.id_tema];
            lblL.ForeColor = Tema.fcfc[GlobalVariable.id_tema];
            lblM.ForeColor = Tema.fcfc[GlobalVariable.id_tema];
            rdoKota.ForeColor = Tema.fcfc[GlobalVariable.id_tema];
            rdoLokal.ForeColor = Tema.fcfc[GlobalVariable.id_tema];
        }
        public void IsiFrmTetangga(FrmTambahGerbong  frmGerbong)
        {
            this.frmGerbong = frmGerbong;
        }

        private string BuatKeteranganTiketID()
        {
            string key = keteranganTiketController.ReadLastKey();
            if (key == "")
            {
                return "KT-0000";
            }
            int angka = int.Parse(key.Remove(0, 3)) + 1;
            string nol = "000";
            for(int i = 10; i < 100000; i *= 10)
            {
                if(angka < i)
                {
                    key  = "KT-" + nol + angka;
                    break;
                }
                nol = nol.Remove(0, 1);
            }
            return key;
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (GlobalVariable.isNewData)
            {
                string id = BuatKeteranganTiketID();
                keteranganTiket = new KeteranganTiket();
                GlobalVariable.keterangan_id = id;
                keteranganTiket.keterangan_tiket_id = id;
                keteranganTiket.jenis_kereta = jenis_kereta;
                keteranganTiket.kelas = cmbKelas.Items[cmbKelas.SelectedIndex].ToString();
                keteranganTiket.nama_kereta = txtNamaKereta.Text;
                keteranganTiket.stasiun_asal = txtAsal.Text;
                keteranganTiket.stasiun_tujuan = txtTujuan.Text;
                keteranganTiket.jadwal_keberangkatan = dtpBerangkat.Text + " " + txtBerangkat.Text;
                keteranganTiket.jadwal_kedatangan = dtpKedatangan.Text + " " + txtKedatangan.Text;
                try
                {
                    keteranganTiket.harga = int.Parse(txtHarga.Text);
                }
                catch (Exception ex)
                {
                    keteranganTiket.harga = 0;
                }
                int result = keteranganTiketController.Create(keteranganTiket);
                if (result > 0)
                {
                    GlobalVariable.isNewData = false;
                    frmGerbong.BringToFront();
                    title.Text = frmGerbong.Text;
                }
            }
            else
            {
                keteranganTiket = new KeteranganTiket();
                keteranganTiket.keterangan_tiket_id = GlobalVariable.keterangan_id;
                keteranganTiket.jenis_kereta = jenis_kereta;
                keteranganTiket.kelas = cmbKelas.Items[cmbKelas.SelectedIndex].ToString();
                keteranganTiket.nama_kereta = txtNamaKereta.Text;
                keteranganTiket.stasiun_asal = txtAsal.Text;
                keteranganTiket.stasiun_tujuan = txtTujuan.Text;
                keteranganTiket.jadwal_keberangkatan = dtpBerangkat.Text + " " + txtBerangkat.Text;
                keteranganTiket.jadwal_kedatangan = dtpKedatangan.Text + " " + txtKedatangan.Text;
                try
                {
                    keteranganTiket.harga = int.Parse(txtHarga.Text);
                }
                catch (Exception ex)
                {
                    keteranganTiket.harga = 0;
                }
                int result = keteranganTiketController.Update(keteranganTiket);
                if (result > 0)
                {
                    GlobalVariable.isNewData = false;
                    frmGerbong.BringToFront();
                    title.Text = frmGerbong.Text;
                }
            }
        }

        private void FrmKeteranganTiket_Load(object sender, EventArgs e)
        {

        }

        private void rdoLokal_CheckedChanged(object sender, EventArgs e)
        {
            jenis_kereta = "Lokal";
        }

        private void rdoKota_CheckedChanged(object sender, EventArgs e)
        {
            jenis_kereta = "Antar Kota";
        }

    }
}
