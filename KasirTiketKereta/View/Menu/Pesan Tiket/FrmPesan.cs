using KasirTiketKereta.Asset_Code;
using KasirTiketKereta.Controller;
using KasirTiketKereta.Model.Entity;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace KasirTiketKereta.View.Menu.Pesan_Tiket
{
    public partial class FrmPesan : Form
    {
        private FrmTambahPelanggan frmPelanggan;
        private PelangganController pelangganController;
        private PesananController pesananController;
        private TiketController tiketController;
        private KeteranganTiketController keteranganTiketController;
        private Label title;
        private Pesanan pesanan;
        private int sisaTiket, harga;
        public string kelas, tujuan, asal;
        public delegate void OnSelesaiEventHandler();
        public event OnSelesaiEventHandler OnSelesai;
        public FrmPesan(Label title)
        {
            this.title = title;
            this.SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            InitializeComponent();
            this.pelangganController = new PelangganController();
            this.pesananController = new PesananController();
            this.tiketController = new TiketController();
            this.keteranganTiketController = new KeteranganTiketController();
            this.cmbPembayaran.SelectedIndex = 0;
            this.cmbKelas.SelectedIndex = 0;
            Tampilan();
            this.panelB.Visible = false;
        }
        public void IsiFrmTetangga(FrmTambahPelanggan frmPelanggan)
        {
            this.frmPelanggan = frmPelanggan;
        }
        private void Tampilan()
        {
            BackColor = Color.FromArgb(180, 0, 0, 0);
            panelA.BackColor = Tema.ppc[GlobalVariable.id_tema];
            panelB.BackColor = Tema.ppc[GlobalVariable.id_tema];
            panelC.BackColor = Tema.ppc[GlobalVariable.id_tema];
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
        }
        private string BuatPesananID()
        {
            string key = pesananController.ReadLastKey();
            if (key == "")
            {
                return "R-00000000";
            }
            int angka = int.Parse(key.Remove(0, 2)) + 1;
            string nol = "0000000";
            for (int i = 10; i < 100000000; i *= 10)
            {
                if (angka < i)
                {
                    key = "R-" + nol + angka;
                    break;
                }
                nol = nol.Remove(0, 1);
            }
            return key;
        }
        private void btnPrevious_Click(object sender, EventArgs e)
        {
            frmPelanggan.BringToFront();
            title.Text = frmPelanggan.Text;
        }

        private void btnPesan_Click(object sender, EventArgs e)
        {
            string id = BuatPesananID();
            pesanan = new Pesanan();
            pesanan.pesanan_id = id;
            pesanan.waktu_pemesanan = DateTime.Now.ToString();
            pesanan.metode_pembayaran = cmbPembayaran.Items[cmbPembayaran.SelectedIndex].ToString();
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
            pesanan.pelanggan_id = GlobalVariable.pelanggan_id;
            pesanan.nama_kasir = GlobalVariable.nama;
            int result = pesananController.Create(pesanan);
            int proses = 1000 / pesanan.jumlah_tiket_dipesan;
            if (result > 0)
            {
                for (int i = 0; i < pesanan.jumlah_tiket_dipesan; i++)
                {
                    tiketController.UpdatePesananID(tiketController.ReadTiketIDNull(asal, tujuan, kelas), id);
                    pgbPesan.Value += proses;
                }
                pgbPesan.Value = 0;
                sisaTiket -= pesanan.jumlah_tiket_dipesan;
                txtSisa.Text = sisaTiket.ToString();
                txtJumlah.Text = "0";
            }
        }

        private void btnSelesai_Click(object sender, EventArgs e)
        {
            this.Close();
            frmPelanggan.Close();
            OnSelesai();
        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FrmPesan_Load(object sender, EventArgs e)
        {

        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            asal = txtAsal.Text;
            tujuan = txtTujuan.Text;
            kelas = cmbKelas.Items[cmbKelas.SelectedIndex].ToString();
            sisaTiket = tiketController.ReadNullPesananID(asal, tujuan, kelas);
            try
            {
                harga = int.Parse(keteranganTiketController.ReadPrice(asal, tujuan, kelas));
            }
            catch(Exception ex)
            {
                harga = 0;
            }
            txtSisa.Text = sisaTiket.ToString();
            this.panelB.Visible = true;

        }

        private void txtJumlah_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
        (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void txtJumlah_TextChanged(object sender, EventArgs e)
        {
            int number;
            if (int.TryParse(txtJumlah.Text, out number))
            {
                if (number > sisaTiket)
                {
                    txtJumlah.Text = sisaTiket.ToString();
                    number = sisaTiket;
                }
                else if(number < 0)
                {
                    txtJumlah.Text = "0";
                    number = 0;
                }
            }
            txtTotal.Text = (number * harga).ToString();
        }
    }
}
